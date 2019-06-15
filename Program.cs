using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptingViaMD5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EncryptingMD5("Tu#ki@ja"));
            Console.ReadLine();
        }

        private static string EncryptingMD5(string valueToBeEncrypted)
        {
            using (System.Security.Cryptography.MD5 md5Scrypting = System.Security.Cryptography.MD5.Create())
            {
                byte[] ValueByte = System.Text.Encoding.ASCII.GetBytes(valueToBeEncrypted);


                byte[] ValueHashByte = md5Scrypting.ComputeHash(ValueByte);
                StringBuilder PersonalizedString = new StringBuilder();

                for (int i = 0; i < ValueHashByte.Length; i++)
                    PersonalizedString.Append(ValueHashByte[i].ToString("x2"));
                return PersonalizedString.ToString();
            }
        }
    }
}
