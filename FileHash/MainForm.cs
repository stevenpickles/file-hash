using System;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Threading;

namespace FileHash
{
    public partial class MainForm : Form
    {
        private const int _NUMBER_OF_HASH_ALGORITHMS_C = 6;
        private ManualResetEvent[] _doneEvents;
        private FileHash[] _fileHashes;

        public MainForm()
        {
            InitializeComponent();

            _doneEvents = new ManualResetEvent[ _NUMBER_OF_HASH_ALGORITHMS_C ];
            _fileHashes = new FileHash[ _NUMBER_OF_HASH_ALGORITHMS_C ];

            _fileHashes[ 0 ] = new FileHash( new MD5CryptoServiceProvider() );
            _fileHashes[ 1 ] = new FileHash( new RIPEMD160Managed() );
            _fileHashes[ 2 ] = new FileHash( new SHA1Managed() );
            _fileHashes[ 3 ] = new FileHash( new SHA256Managed() );
            _fileHashes[ 4 ] = new FileHash( new SHA384Managed() );
            _fileHashes[ 5 ] = new FileHash( new SHA512Managed() );
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

                for ( int index = 0 ; index < _NUMBER_OF_HASH_ALGORITHMS_C ; index++ )
                {
                    _doneEvents[ index ] = new ManualResetEvent( false );
                    _fileHashes[ index ].DoneEvent = _doneEvents[ index ];
                    ThreadPool.QueueUserWorkItem( _fileHashes[ index ].GetHashString , fileContents );
                }

                foreach ( var e in _doneEvents )
                {
                    e.WaitOne();
                }

                _MD5HashLabel.Text = _fileHashes[ 0 ].HashString;
                _RIPEMD160HashLabel.Text = _fileHashes[ 1 ].HashString;
                _SHA1HashLabel.Text = _fileHashes[ 2 ].HashString;
                _SHA256HashLabel.Text = _fileHashes[ 3 ].HashString;
                _SHA384HashLabel.Text = _fileHashes[ 4 ].HashString;
                _SHA512HashLabel.Text = _fileHashes[ 5 ].HashString;

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
            string[] files = (string[]) e.Data.GetData( DataFormats.FileDrop );
            _filePathTextBox.Text = files[ 0 ];
            getAllHashes();
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
            _fileHashes[ 0 ].Enabled = ((CheckBox) sender).Checked;
        }

        private void _RIPEMD160CheckBox_CheckedChanged( object sender , EventArgs e )
        {
            _fileHashes[ 1 ].Enabled = ((CheckBox) sender).Checked;
        }

        private void _SHA1CheckBox_CheckedChanged( object sender , EventArgs e )
        {
            _fileHashes[ 2 ].Enabled = ((CheckBox) sender).Checked;
        }

        private void _SHA256CheckBox_CheckedChanged( object sender , EventArgs e )
        {
            _fileHashes[ 3 ].Enabled = ((CheckBox) sender).Checked;
        }

        private void _SHA384CheckBox_CheckedChanged( object sender , EventArgs e )
        {
            _fileHashes[ 4 ].Enabled = ((CheckBox) sender).Checked;
        }

        private void _SHA512CheckBox_CheckedChanged( object sender , EventArgs e )
        {
            _fileHashes[ 5 ].Enabled = ((CheckBox) sender).Checked;
        }


    }
}
