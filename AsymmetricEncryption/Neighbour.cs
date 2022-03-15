using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace AsymmetricEncryption
{
    class Neighbour : Person
    {
        
        public override void InitRSA()
        {
            RSAalg = Crypto.ReadRSAByKey();
        }
        public string ReadOriginalContent()
        {
            return FileOperations.GetFileContent();
        }
        public byte[] Encrypt(byte[] plainbytes) => RSAalg.Encrypt(plainbytes, false);
    }
}
