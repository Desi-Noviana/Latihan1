using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan
{
    internal class Show 
    {
        public static void show
            (int[] id,
            string[] firstName,
            string[] lastName,
            string[] userName,
            string[] password)
        {
            bool key = true;
            do
            {
                Console.Clear();

                Console.WriteLine("==SHOW USER==");
                for (int i = 0; i < id.Length; i++)
                {
                    if (id[i] != 0)
                    {
                        Console.WriteLine("====================");
                        Console.WriteLine("ID          : " + id[i]);
                        Console.WriteLine("Name        : " + firstName[i] + " " + lastName[i]);
                        Console.WriteLine("Username    : " + firstName[i].Substring(0,2) + lastName[i].Substring(0,2));
                        Console.WriteLine("Password    : " + password[i]);
                        Console.WriteLine("====================");
                    }
                }
                Console.WriteLine("\nMenu");
                string[] menuEdit = { "Edit User", "Delete User", "Back" };
                for (int i = 0; i < menuEdit.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {menuEdit[i]}");
                }

                Console.Write("Input : ");
                int pilihEdit = Convert.ToInt16(Console.ReadLine());

                switch (pilihEdit)
                {
                    case 1:
                        Console.Write("\nID yang ingin diubah: ");
                        int ubahId = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < id.Length; i++)
                        {
                            if (id.Length != null)
                            {
                                Console.Write("First Name : ");
                                string ubahFirst = Console.ReadLine();
                                firstName[ubahId - 1] = ubahFirst;

                                Console.Write("Last Name : ");
                                string ubahLast = Console.ReadLine();
                                lastName[ubahId - 1] = ubahLast;

                                Console.Write("Password : ");
                                string ubahPass = Console.ReadLine();
                                password[ubahId - 1] = ubahPass;
                                break;
                            }
                        }
                        Console.Write("\nUser sudah berhasil diedit");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Write("\nID yang ingin dihapus: ");
                        int hapusId = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < id.Length; i++)
                        {
                            if (id.Length != null)
                            {
                                id[hapusId - 1] = hapusId - hapusId;
                                firstName[hapusId - 1] = "";
                                lastName[hapusId - 1] = "";
                                userName[hapusId - 1] = "";
                                password[hapusId - 1] = "";
                                break;
                            }
                        }
                        Console.Write("\nUser sudah berhasil dihapus");
                        Console.ReadKey();
                        break;
                    case 3:
                        key = false;
                        break;
                    default:
                        Console.Write("\nTidak ada pilihan");
                        Console.ReadKey();
                        break;
                }
            } while (key);
        }
    }
}


