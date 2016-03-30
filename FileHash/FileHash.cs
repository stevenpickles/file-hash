using System;
using System.Security.Cryptography;
using System.Diagnostics;
using System.IO;

namespace FileHash
{
    public class FileHash
    {
        private HashAlgorithm _hashAlgorithm;

        private string _hashString;
        public string HashString { get { return _hashString; } }

        private bool _enabled;
        public bool Enabled { set { _enabled = value; } get { return _enabled; } }

        private Stopwatch _stopwatch;
        public long ElapsedMilliseconds { get { return _stopwatch.ElapsedMilliseconds; } }

        public FileHash( HashAlgorithm hashAlgorithm )
        {
            _hashAlgorithm = hashAlgorithm;
            _hashString = "";
            _enabled = true;
            _stopwatch = new Stopwatch();
        }

        public void GetHashString( FileInfo fileInfo )
        {
            if ( _enabled )
            {
                _stopwatch.Reset();
                _stopwatch.Start();

                try
                {
                    using ( FileStream fileStream = fileInfo.OpenRead() )
                    {
                        byte[] hashBytes = _hashAlgorithm.ComputeHash( fileStream );
                        _hashString = BitConverter.ToString( hashBytes );
                        _hashString = _hashString.Replace( "-" , "" );
                        _hashString = _hashString.ToLower();
                    }
                }
                catch ( Exception e )
                {
                    _hashString = e.Message;
                }

                _stopwatch.Stop();
            }
            else
            {
                _stopwatch.Reset();
                _hashString = "";
            }
        }
    }
}
