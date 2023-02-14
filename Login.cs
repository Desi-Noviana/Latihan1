using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan
{
    public class Login
    {
       public static void login
           (int[] id,
           string[] firstName,
           string[] lastName,
           string[] password,
           string[] userName1,
           string[] password1)
        {
            Console.WriteLine("==LOGIN==");
            Console.Write("USERNAME : ");
            string inputUser = Console.ReadLine();

            Console.Write("PASSWORD : ");
            string inputPass = Console.ReadLine();

            bool status = false;
            for (int i = 0; i < id.Length; i++)
            {
                if ((firstName[i].Substring(0, 2) + lastName[i].Substring(0, 2)) == inputUser && password[i] == inputPass)
                {
                    status = true;
                    break;
                }
            }

            if (status == true)
            {
                Console.Write("Login Berhasil");
                Console.ReadKey();
            }
            else
            {
                Console.Write("Login Gagal");
                Console.ReadKey();
            }
        }
    }
}
