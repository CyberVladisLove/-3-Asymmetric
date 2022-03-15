using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AsymmetricEncryption
{
    public abstract class Person
    {
        protected RSACryptoServiceProvider RSAalg { get; set; }

        public Person() { }

        public abstract void InitRSA();

    }
}
