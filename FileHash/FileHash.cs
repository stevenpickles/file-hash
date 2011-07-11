using System;
using System.Security.Cryptography;
using System.Threading;

namespace FileHash
{
    public class FileHash
    {
        private HashAlgorithm _hashAlgorithm;

        private string _hashString;
        public string HashString { get { return _hashString; } }

        private bool _enabled;
        public bool Enabled { set { _enabled = value; } get { return _enabled; } }

        private ManualResetEvent _doneEvent;
        public ManualResetEvent DoneEvent { set { _doneEvent = value; } get { return _doneEvent; } }

        public FileHash( HashAlgorithm hashAlgorithm )
        {
            _hashAlgorithm = hashAlgorithm;
            _hashString = "";
            _enabled = true;
            _doneEvent = new ManualResetEvent( false );
        }

        public void GetHashString( object threadContext )
        {
            byte[] bytes = (byte[]) threadContext;

            if ( _enabled )
            {
                byte[] hashBytes = _hashAlgorithm.ComputeHash( bytes );
                _hashString = BitConverter.ToString( hashBytes );
                _hashString = _hashString.Replace( "-" , "" );
                _hashString = _hashString.ToLower();
            }
            else
            {
                _hashString = "";
            }

            _doneEvent.Set();
        }
    }
}
