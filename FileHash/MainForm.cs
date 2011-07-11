using System;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace FileHash
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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

                _MD5HashLabel.Text = getMD5HashString( fileContents );
                _RIPEMD160HashLabel.Text = getRIPEMD160HashString( fileContents );
                _SHA1HashLabel.Text = getSHA1HashString( fileContents );
                _SHA256HashLabel.Text = getSHA256HashString( fileContents );
                _SHA384HashLabel.Text = getSHA384HashString( fileContents );
                _SHA512HashLabel.Text = getSHA512HashString( fileContents );
                
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

        private string getHashString( HashAlgorithm hash , byte[] fileContents )
        {
            byte[] hashBytes = hash.ComputeHash( fileContents );
            string hashString = BitConverter.ToString( hashBytes );
            hashString = hashString.Replace( "-" , "" );
            hashString = hashString.ToLower();
            return hashString;
        }

        private string getMD5HashString( byte[] fileContents )
        {
            if ( _MD5CheckBox.Checked )
            {
                return getHashString( new MD5CryptoServiceProvider() , fileContents );
            }
            else
            {
                return "";
            }
        }

        private string getRIPEMD160HashString( byte[] fileContents )
        {
            if ( _RIPEMD160CheckBox.Checked )
            {
                return getHashString( new RIPEMD160Managed() , fileContents );
            }
            else
            {
                return "";
            }
        }

        private string getSHA1HashString( byte[] fileContents )
        {
            if ( _SHA1CheckBox.Checked )
            {
                return getHashString( new SHA1Managed() , fileContents );
            }
            else
            {
                return "";
            }
        }

        private string getSHA256HashString( byte[] fileContents )
        {
            if ( _SHA256CheckBox.Checked )
            {
                return getHashString( new SHA256Managed() , fileContents );
            }
            else
            {
                return "";
            }
        }

        private string getSHA384HashString( byte[] fileContents )
        {
            if ( _SHA384CheckBox.Checked )
            {
                return getHashString( new SHA384Managed() , fileContents );
            }
            else
            {
                return "";
            }
        }

        private string getSHA512HashString( byte[] fileContents )
        {
            if ( _SHA512CheckBox.Checked )
            {
                return getHashString( new SHA512Managed() , fileContents );
            }
            else
            {
                return "";
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


    }
}
