using System;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Threading;

namespace FileHash
{
    public partial class MainForm : Form
    {
        private FileHash _MD5Hasher;
        private FileHash _RIPEMD160Hasher;
        private FileHash _SHA1Hasher;
        private FileHash _SHA256Hasher;
        private FileHash _SHA384Hasher;
        private FileHash _SHA512Hasher;

        private bool _busy;
        private int _threadsRemaining;
        private object _threadsRemainingLock;

        public MainForm()
        {
            InitializeComponent();

            _MD5Hasher = new FileHash( new MD5CryptoServiceProvider() );
            _RIPEMD160Hasher = new FileHash( new RIPEMD160Managed() );
            _SHA1Hasher = new FileHash( new SHA1Managed() );
            _SHA256Hasher = new FileHash( new SHA256Managed() );
            _SHA384Hasher = new FileHash( new SHA384Managed() );
            _SHA512Hasher = new FileHash( new SHA512Managed() );

            _busy = false;
            _threadsRemaining = 0;
            _threadsRemainingLock = new object();

            ThreadPool.SetMaxThreads( 30 , 30 );
            ThreadPool.SetMinThreads( 10 , 10 );
        }

        private void _loadFileButton_Click( object sender , EventArgs e )
        {
            getAllHashes();
        }

        private void getAllHashes()
        {
            FileStream fileReader = null;
            byte[] fileContents = null;

            try
            {
                fileReader = File.OpenRead( _filePathTextBox.Text );
                fileContents = new byte[ fileReader.Length ];
                fileReader.Read( fileContents , 0 , (int) fileReader.Length );

                updateAllHashLabels( "" );

                _busy = true;
                _threadsRemaining = 6;
                _loadFileButton.Enabled = false;

                ThreadPool.QueueUserWorkItem( new WaitCallback( GetMD5Hash ) , fileContents );
                ThreadPool.QueueUserWorkItem( new WaitCallback( GetRIPEMD160Hash ) , fileContents );
                ThreadPool.QueueUserWorkItem( new WaitCallback( GetSHA1Hash ) , fileContents );
                ThreadPool.QueueUserWorkItem( new WaitCallback( GetSHA256Hash ) , fileContents );
                ThreadPool.QueueUserWorkItem( new WaitCallback( GetSHA384Hash ) , fileContents );
                ThreadPool.QueueUserWorkItem( new WaitCallback( GetSHA512Hash ) , fileContents );

                fileReader.Close();
            }
            catch( Exception e )
            {
                updateAllHashLabels( e.Message );
            }
            finally
            {
                if ( fileReader != null )
                {
                    fileReader.Close();
                }
            }
        }

        private void GetMD5Hash( object fileContents )
        {
            GetHash( _MD5Hasher , _MD5HashLabel , (byte[]) fileContents );
        }
        
        private void GetRIPEMD160Hash( object fileContents )
        {
            GetHash( _RIPEMD160Hasher , _RIPEMD160HashLabel , (byte[]) fileContents );
        }
        
        private void GetSHA1Hash( object fileContents )
        {
            GetHash( _SHA1Hasher , _SHA1HashLabel , (byte[]) fileContents );
        }

        private void GetSHA256Hash( object fileContents )
        {
            GetHash( _SHA256Hasher , _SHA256HashLabel , (byte[]) fileContents );
        }

        private void GetSHA384Hash( object fileContents )
        {
            GetHash( _SHA384Hasher , _SHA384HashLabel , (byte[]) fileContents );
        }

        private void GetSHA512Hash( object fileContents )
        {
            GetHash( _SHA512Hasher , _SHA512HashLabel , (byte[]) fileContents );
        }

        private void GetHash( FileHash hasher , Label label , byte[] fileContents )
        {
            Action action;

            action = () => label.Text = "... computing ...";
            this.BeginInvoke( action );
            
            hasher.GetHashString( fileContents );

            action = () => label.Text = hasher.HashString;
            this.BeginInvoke( action );

            DecrementThreadsRemaining();
        }

        private void DecrementThreadsRemaining()
        {
            lock ( _threadsRemainingLock )
            {
                _threadsRemaining--;

                if ( _threadsRemaining == 0 )
                {
                    Action action;

                    action = () => _busy = false;
                    this.BeginInvoke( action );

                    action = () => _loadFileButton.Enabled = true;
                    this.BeginInvoke( action );
                }
            }
        }

        private void updateAllHashLabels( string message )
        {
            _MD5HashLabel.Text = updateMD5HashLabel( message );
            _RIPEMD160HashLabel.Text = updateRIPEMD160HashLabel( message );
            _SHA1HashLabel.Text = updateSHA1HashLabel( message );
            _SHA256HashLabel.Text = updateSHA256HashLabel( message );
            _SHA384HashLabel.Text = updateSHA384HashLabel( message );
            _SHA512HashLabel.Text = updateSHA512HashLabel( message );
        }

        private string updateMD5HashLabel( string message )
        {
            if ( _MD5CheckBox.Checked )
            {
                return message;
            }
            else
            {
                return "";
            }
        }

        private string updateRIPEMD160HashLabel( string message )
        {
            if ( _RIPEMD160CheckBox.Checked )
            {
                return message;
            }
            else
            {
                return "";
            }
        }

        private string updateSHA1HashLabel( string message )
        {
            if ( _SHA1CheckBox.Checked )
            {
                return message;
            }
            else
            {
                return "";
            }
        }

        private string updateSHA256HashLabel( string message )
        {
            if ( _SHA256CheckBox.Checked )
            {
                return message;
            }
            else
            {
                return "";
            }
        }

        private string updateSHA384HashLabel( string message )
        {
            if ( _SHA384CheckBox.Checked )
            {
                return message;
            }
            else
            {
                return "";
            }
        }

        private string updateSHA512HashLabel( string message )
        {
            if ( _SHA512CheckBox.Checked )
            {
                return message;
            }
            else
            {
                return "";
            }
        }

        private void MainForm_DragDrop( object sender , DragEventArgs e )
        {
            if ( !_busy )
            {
                string[] files = (string[]) e.Data.GetData( DataFormats.FileDrop );
                _filePathTextBox.Text = files[ 0 ];
                getAllHashes();
            }
        }

        private void MainForm_DragEnter( object sender , DragEventArgs e )
        {
            if ( e.Data.GetDataPresent( DataFormats.Text ) )
            {
                e.Effect = DragDropEffects.Copy;
            }
            else if ( e.Data.GetDataPresent( DataFormats.FileDrop ) )
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void HashLabel_Click( object sender , EventArgs e )
        {
            Clipboard.SetText( ((Label) sender).Text );
        }

        private void _MD5CheckBox_CheckedChanged( object sender , EventArgs e )
        {
            _MD5Hasher.Enabled = ((CheckBox) sender).Checked;
        }

        private void _RIPEMD160CheckBox_CheckedChanged( object sender , EventArgs e )
        {
            _RIPEMD160Hasher.Enabled = ((CheckBox) sender).Checked;
        }

        private void _SHA1CheckBox_CheckedChanged( object sender , EventArgs e )
        {
            _SHA1Hasher.Enabled = ((CheckBox) sender).Checked;
        }

        private void _SHA256CheckBox_CheckedChanged( object sender , EventArgs e )
        {
            _SHA256Hasher.Enabled = ((CheckBox) sender).Checked;
        }

        private void _SHA384CheckBox_CheckedChanged( object sender , EventArgs e )
        {
            _SHA384Hasher.Enabled = ((CheckBox) sender).Checked;
        }

        private void _SHA512CheckBox_CheckedChanged( object sender , EventArgs e )
        {
            _SHA512Hasher.Enabled = ((CheckBox) sender).Checked;
        }


    }
}
