using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan
{
    public class Create
    {
        public static void create
            (int[] id,
            string[] firstName,
            string[] lastName,
            string[] userName,
            string[] password)
        {
            for (int i = 0; i < id.Length; i++)
            {
                if (id[i] == 0)
                {
                    id[i] = i + 1;

                    Console.Write("First Name : ");
                    firstName[i] = Console.ReadLine();

                    Console.Write("Last Name : ");
                    lastName[i] = Console.ReadLine();

                    userName[i] = firstName[i].Substring(0, 2) + lastName[i].Substring(0, 2);

                    bool check = true;
                    do
                    {
                        Console.Write("Password : ");
                        string checkPass = Console.ReadLine();
                        if (checkPass.Length >= 8)
                        {
                            if (checkPass.Any(char.IsUpper))
                            {
                                if (checkPass.Any(char.IsLower))
                                {
                                    if (checkPass.Any(char.IsNumber))
                                    {
                                        password[i] = checkPass;
                                        check = false;
                                        break;
                                    }
                                }
                            }
                        }
                        Console.WriteLine("\nPassword must have at least 8 characters\r\n with at least one Capital letter, at least one lower case letter and at least one number.\n");
                    } while (check);
                    break;
                }
            }
            Console.Write("\nData user berhasil dibuat");
            Console.ReadKey();
        }


    }
}
