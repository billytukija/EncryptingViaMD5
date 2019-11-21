using System;
using System.Text;

namespace EncryptingViaMD5
{
    class Program
    {
        static void Main(string[] args)
        {
            string password;
            bool next = true;

            while (next)
            {
                Console.WriteLine("Enter your dev-safe password: ");
                password = Console.ReadLine();

                if (password != "")
                {
                    Console.WriteLine(EncryptingMD5(password));
                    Console.ReadLine();

                    Console.WriteLine("Deseja gerar mais outra senha? 0 - sim e 1 - Não");
                    var emptyRes = Console.ReadLine();

                    if (emptyRes == "")
                    {
                        Console.WriteLine("Informa a senha para criptografiar");
                    }
                    else
                    {
                        var res = Console.ReadLine();

                        if (res == "0")
                            next = true;
                    }
                }
                else {
                    Console.Clear();
                }
            }
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

                Console.Clear();
                Console.WriteLine("Use the following dev-safe password as your encripted password");
                return PersonalizedString.ToString();
            }
        }
    }
}
