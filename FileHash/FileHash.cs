using System;
using System.Security.Cryptography;
using System.Threading;
using System.Diagnostics;

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

        public void GetHashString( byte[] bytes )
        {
            if ( _enabled )
            {
                _stopwatch.Reset();
                _stopwatch.Start();
                byte[] hashBytes = _hashAlgorithm.ComputeHash( bytes );
                _hashString = BitConverter.ToString( hashBytes );
                _hashString = _hashString.Replace( "-" , "" );
                _hashString = _hashString.ToLower();
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
