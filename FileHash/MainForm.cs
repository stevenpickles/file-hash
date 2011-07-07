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
            FileStream fileReader = File.OpenRead( _filePathTextBox.Text );

            try
            {
                string hashStringMD5 = getHashString( new MD5CryptoServiceProvider() , fileReader );
                _MD5HashLabel.Text = hashStringMD5;

                string hashStringRIPEMD160 = getHashString( new RIPEMD160Managed() , fileReader );
                _RIPEMD160HashLabel.Text = hashStringRIPEMD160;

                string hashStringSHA1 = getHashString( new SHA1Managed() , fileReader );
                _SHA1HashLabel.Text = hashStringSHA1;

                string hashStringSHA256 = getHashString( new SHA256Managed() , fileReader );
                _SHA256HashLabel.Text = hashStringSHA256;

                string hashStringSHA384 = getHashString( new SHA384Managed() , fileReader );
                _SHA384HashLabel.Text = hashStringSHA384;

                string hashStringSHA512 = getHashString( new SHA512Managed() , fileReader );
                _SHA512HashLabel.Text = hashStringSHA512;
                
                fileReader.Close();
            }
            finally
            {
                fileReader.Close();
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

        private void MainForm_DragDrop( object sender , DragEventArgs e )
        {
            string[] files = (string[]) e.Data.GetData( DataFormats.FileDrop );
            _filePathTextBox.Text = files[ 0 ];
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
