using System;
using Latihan;

namespace Latihan;

public class Program
{
    public List<Login> login = new List<Login>();
    public List<Create> create = new List<Create>();
    private static readonly List<Show> shows = new List<Show>();

    // Login login = new Login();
    /*    Create create = new Create();*/
    static void Main()
    {
        bool key = true;

        int[] id = new int[5];
        string[] firstName = new string[5];
        string[] lastName = new string[5];
        string[] userName = new string[5];
        string[] password = new string[5];

        do
        {
            Menu(id, firstName, lastName, userName, password);
        } while (key);
    }


    public static void Menu
        (int[] id,
        string[] firstName,
        string[] lastName,
        string[] userName,
        string[] password)
    {
        Console.Clear();

        string[] menuTampilan = { "Create", "Show", "Login", "Exit" };

        Console.WriteLine("==BASIC AUTHENTICATION==");
        for (int i = 0; i < menuTampilan.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {menuTampilan[i]} User");
        }

        Console.Write("Input : ");
        int pilihMenu = Convert.ToInt32(Console.ReadLine());

        switch (pilihMenu)
        {
            case 1: //CREATE
                Console.Clear();

                Create.create
                    (id,
                    firstName,
                    lastName,
                    userName,
                    password);

                break;
            case 2: //EDIT
                Console.Clear();

                Show.show
                    (id,
                    firstName,
                    lastName,
                    userName,
                    password);

                break;
            case 3: //LOGIN
                Console.Clear();

                Login.login
                    (id,
                    firstName,
                    lastName,
                    password,
                    userName,
                    userName);

                break;
            case 4: //EXIT
                System.Environment.Exit(0);
                break;
            default:
                Console.Write("\nTidak ada pilihan");
                break;
        }
    }
}