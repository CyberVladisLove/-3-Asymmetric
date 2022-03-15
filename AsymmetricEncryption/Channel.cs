using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsymmetricEncryption
{
    class Channel
    {
        public Me me;
        public Neighbour n;
        private byte[] _encryptedData;

        public byte[] EncryptedData
        {
            get => (byte[])_encryptedData.Clone();

            private set { _encryptedData = value; }
        }

        public Channel(Me me, Neighbour n)
        {
            this.me = me;
            this.n = n;
        }

        
        
        public byte[] LetsEncryptByNeighbour(byte[] plainbytes)
        {
            EncryptedData = n.Encrypt(plainbytes);
            return EncryptedData;
        }
        

        

        
    }
}
