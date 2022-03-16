using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsymmetricEncryption
{
    public class Crypto
    {
        public static string WriteKey(RSACryptoServiceProvider rsa, bool isPrivateKey)
        {
            string path = FileOperations.GetPathFileWrite();
            StreamWriter writer = new StreamWriter(path);

            string keyXML = rsa.ToXmlString(isPrivateKey);
            writer.Write(keyXML);
            writer.Close();

            return path;
        }

        public static RSACryptoServiceProvider ReadRSAByKey()
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            string path = FileOperations.GetPathFileRead();
            StreamReader reader = new StreamReader(path);

            string keyXML = reader.ReadToEnd();
            rsa.FromXmlString(keyXML);
            reader.Close();
   
            return rsa;
        }



        //ниже из 4 лабы
        public static string CreateEDS(DSACryptoServiceProvider dsa, string content)
        {
            byte[] hashbytes = CreateHashBytesBySHA1(content);
            byte[] signaturebytes = dsa.SignHash(hashbytes, "1.3.14.3.2.26");

            return Encoding.UTF8.GetString(signaturebytes);
        }
        public static byte[] CreateEDS(DSACryptoServiceProvider dsa, byte[] content)
        {
            byte[] hashbytes = CreateHashBytesBySHA1(content);
            byte[] signaturebytes = dsa.SignHash(hashbytes, "1.3.14.3.2.26");

            return signaturebytes;
        }

        public static bool CheckContentByEDS(DSACryptoServiceProvider dsa, string content, string EDS)
        {  
            return CheckContentByEDS(dsa, content, Encoding.UTF8.GetBytes(EDS));
        }
        public static bool CheckContentByEDS(DSACryptoServiceProvider dsa, string content, byte[] EDS)
        {
            byte[] hashbytes = CreateHashBytesBySHA1(content);

            bool match = dsa.VerifyHash(hashbytes, "1.3.14.3.2.26", EDS);

            return match;
        }

        public static byte[] CreateHashBytesBySHA1(string content)
        {
            //Подписание сообщения
            byte[] messagebytes = Encoding.UTF8.GetBytes(content);

            return CreateHashBytesBySHA1(messagebytes);
        }
        public static byte[] CreateHashBytesBySHA1(byte[] messagebytes)
        {
           
            //создание дайджеста сообщения по алгориму SHA1
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            byte[] hashbytes = sha1.ComputeHash(messagebytes);

            return hashbytes;
        }
    }
}
