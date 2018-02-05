using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace TestCryptoMDP
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("@@@ DEBUT MD5Crypto .NET 3.5 @@@");
            System.Console.Write("Entrer la clé : ");
            string input=System.Console.ReadLine();
            System.Console.WriteLine("  @@@ processing...");
            string output=GetMD5HashData(input);

            System.Console.WriteLine("  @@@ hash généré : "+output);
            System.Console.WriteLine("@@@ FIN @@@");            
            System.Console.ReadLine();
            
        }

        private static string GetMD5HashData(string data)
        {
            try
            {
                MD5 md5 = MD5.Create();

                //convert input to array of bytes
                byte[] hashData = md5.ComputeHash(Encoding.Default.GetBytes(data));


                StringBuilder returnValue = new StringBuilder();

                // loop for each byte and add it to stringbuilder
                for (int i = 0; i < hashData.Length; i++)
                {
                    returnValue.Append(hashData[i].ToString());
                }

                //return hexadcecimal string
                return returnValue.ToString();

            }
            catch (Exception e)
            {                
                System.Console.ForegroundColor=System.ConsoleColor.Red;
                System.Console.WriteLine("  @@@ ERROR !");
                System.Console.ForegroundColor = System.ConsoleColor.Red;
                System.Console.WriteLine("----------------------------------------------------");

                System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                System.Console.Write("Message=");
                System.Console.ForegroundColor = System.ConsoleColor.White;
                System.Console.WriteLine(e.Message);

                System.Console.ForegroundColor = System.ConsoleColor.Red;
                System.Console.WriteLine("----------------------------------------------------");

                System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                System.Console.Write("Source=");
                System.Console.ForegroundColor = System.ConsoleColor.White;
                System.Console.WriteLine(e.Source);



                System.Console.ForegroundColor = System.ConsoleColor.Red;
                System.Console.WriteLine("----------------------------------------------------");


                System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                System.Console.WriteLine("StackTrace:");
                System.Console.ForegroundColor = System.ConsoleColor.White;
                System.Console.WriteLine(e.StackTrace);

                System.Console.ForegroundColor = System.ConsoleColor.Red;
                System.Console.WriteLine("----------------------------------------------------");

                System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                System.Console.WriteLine("InnerException:");
                System.Console.ForegroundColor = System.ConsoleColor.White;
                System.Console.WriteLine(e.InnerException);

                System.Console.ForegroundColor = System.ConsoleColor.Red;
                System.Console.WriteLine("----------------------------------------------------");
                System.Console.ForegroundColor = System.ConsoleColor.White;

                return "ERROR";
                //throw;
            }
           
        }
    }
}
