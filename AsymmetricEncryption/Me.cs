using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AsymmetricEncryption
{
    class Me : Person
    {
        public override void InitRSA() { RSAalg = new RSACryptoServiceProvider(); }

        public void SavePublicKeyToXML()
        {
            Crypto.WriteKey(RSAalg, false);
        }
        public void SavePrivateKeyToXML()
        {
            Crypto.WriteKey(RSAalg, true);
        }
        public byte[] Decrypt(byte[] cypherbytes) => RSAalg.Decrypt(cypherbytes, false);    
       // public byte[] Encrypt(byte[] plainbytes) => RSAalg.Encrypt(plainbytes, false); не нужен    
    }
}
