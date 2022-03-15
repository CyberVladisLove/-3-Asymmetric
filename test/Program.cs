using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;


namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            ASCIIEncoding ByteConverter = new ASCIIEncoding();
            string dataString = "Data to Encrypt";
            byte[] dataToEncrypt = ByteConverter.GetBytes(dataString);
            byte[] encryptedData;
            byte[] decryptedData;
            //Создание экземпляра класса RSACryptoServiceProvider с автоматической генерацией пары ключей
            RSACryptoServiceProvider RSAalg = new RSACryptoServiceProvider();
            Console.WriteLine("Original Data: {0}", dataString);

            //Шифруем данные
            encryptedData = RSAalg.Encrypt(dataToEncrypt, false);

            Console.WriteLine("Encrypted Data: {0}", ByteConverter.GetString(encryptedData));

            //Расшифровываем данные
            decryptedData = RSAalg.Decrypt(encryptedData, false);

            Console.WriteLine("Decrypted plaintext: {0}", ByteConverter.GetString(decryptedData));
            
        }

        //static void WriteRSA(RSACryptoServiceProvider rsa)
        //{
            
            
        //    StreamWriter writer = new StreamWriter(path);
        //    string publicPrivateKeyXML = rsa.ToXmlString(true);
        //    writer.Write(publicPrivateKeyXML);
        //    writer.Close();

        //    writer = new StreamWriter(@"F:\University\Current\Информационная безопасность\Лабы\Лр3 Asymmetric\PublicOnlyKey.xml");
        //    string publicOnlyKeyXML = rsa.ToXmlString(false);
        //    writer.Write(publicOnlyKeyXML);
        //    writer.Close();

        //}
        static RSACryptoServiceProvider ReadRSA(byte[] cipherbytes)
        {

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            StreamReader reader = new StreamReader("PublicPrivateKey.xml");
            string publicPrivateKeyXML = reader.ReadToEnd();
            rsa.FromXmlString(publicPrivateKeyXML);
            reader.Close();

            byte[] plainbytes = rsa.Decrypt(
                        cipherbytes,
                        false); //fOAEP 
            Console.WriteLine(Encoding.UTF8.GetString(plainbytes));
            return rsa;
        }
    }
}
