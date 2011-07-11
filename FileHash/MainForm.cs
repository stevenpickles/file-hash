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

            try
            {
                fileReader = File.OpenRead( _filePathTextBox.Text );

                _MD5HashLabel.Text = getMD5HashString( fileReader );
                _RIPEMD160HashLabel.Text = getRIPEMD160HashString( fileReader );
                _SHA1HashLabel.Text = getSHA1HashString( fileReader );
                _SHA256HashLabel.Text = getSHA256HashString( fileReader );
                _SHA384HashLabel.Text = getSHA384HashString( fileReader );
                _SHA512HashLabel.Text = getSHA512HashString( fileReader );
                
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

        private string getHashString( HashAlgorithm hash , FileStream fileReader )
        {
            fileReader.Position = 0;
            byte[] hashBytes = hash.ComputeHash( fileReader );
            string hashString = BitConverter.ToString( hashBytes );
            hashString = hashString.Replace( "-" , "" );
            hashString = hashString.ToLower();
            return hashString;
        }

        private string getMD5HashString( FileStream fileReader )
        {
            if ( _MD5CheckBox.Checked )
            {
                return getHashString( new MD5CryptoServiceProvider() , fileReader );
            }
            else
            {
                return "";
            }
        }

        private string getRIPEMD160HashString( FileStream fileReader )
        {
            if ( _RIPEMD160CheckBox.Checked )
            {
                return getHashString( new RIPEMD160Managed() , fileReader );
            }
            else
            {
                return "";
            }
        }

        private string getSHA1HashString( FileStream fileReader )
        {
            if ( _SHA1CheckBox.Checked )
            {
                return getHashString( new SHA1Managed() , fileReader );
            }
            else
            {
                return "";
            }
        }

        private string getSHA256HashString( FileStream fileReader )
        {
            if ( _SHA256CheckBox.Checked )
            {
                return getHashString( new SHA256Managed() , fileReader );
            }
            else
            {
                return "";
            }
        }

        private string getSHA384HashString( FileStream fileReader )
        {
            if ( _SHA384CheckBox.Checked )
            {
                return getHashString( new SHA384Managed() , fileReader );
            }
            else
            {
                return "";
            }
        }

        private string getSHA512HashString( FileStream fileReader )
        {
            if ( _SHA512CheckBox.Checked )
            {
                return getHashString( new SHA512Managed() , fileReader );
            }
            else
            {
                return "";
            }
        }

        private void updateAllHashLabels( string message )
        {
            updateMD5HashLabel( message );
            updateRIPEMD160HashLabel( message );
            updateSHA1HashLabel( message );
            updateSHA256HashLabel( message );
            updateSHA384HashLabel( message );
            updateSHA512HashLabel( message );
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
