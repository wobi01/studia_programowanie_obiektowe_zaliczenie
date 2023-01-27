using studia_programowanie_obietkowe_zaliczenie;
using System.IO;
using System.Reflection.Metadata.Ecma335;


class Program
{
    public static Menu _menu;

static void Main(string[] args)
    {
        _menu = new Menu();
        AskUserForAction();
        AdminPass adminPass = new AdminPass();
    }

    public static void AskUserForAction()
    {
        Console.WriteLine("Wybierz co chcesz zrobić: ");
        Console.WriteLine("1. Wyświetl menu");
        Console.WriteLine("2. Złóż zamówienie");
        Console.WriteLine("3. Panel administracyjny");
        Console.WriteLine("4. Zakończ program");
        Console.WriteLine("____________________________________________");
        Console.Write("Wybór: ");
        switch (Console.ReadLine())
        {
            case "1":
                //stuff to do
                Console.Clear();
                AskUserForAction();
                break;
            case "2":
                //stuff to do
                Console.Clear();
                AskUserForAction();
                break;
            case "3":
                Console.WriteLine(AdminPass.GetPasswd());
                Console.WriteLine("By uzyskać dostęp do panelu administratora podaj hasło (domyślne hasło to 'admin'): ");
                if (Console.ReadLine().ToLower() == AdminPass.GetPasswd())
                {
                    Console.Clear();
                    AskUserForActionAdmin();
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Podano niepoprawne hasło, spróbuj ponownie");
                    AskUserForAction();
                    break;
                }
            case "4":
                Environment.Exit(0);
                break;
            default:
                Console.Clear();
                Console.WriteLine("Wybrano niepoprawną opcję, spróbuj ponownie");
                AskUserForAction();
                break;
        }
    }

    public static void AskUserForActionAdmin()
    {
        Console.WriteLine("____Panel administratora____");
        Console.WriteLine("1. Dodaj danie");
        Console.WriteLine("2. Usuń danie");
        Console.WriteLine("3. Wyjdź z panelu administratora");
        Console.WriteLine("4. Zmień hasło do panelu administratora");
        Console.WriteLine("5. Zakończ program");
        Console.WriteLine("____________________________");
        Console.Write("Wybór: ");
        switch (Console.ReadLine())
        {
            case "1":
                //Dish.Add();
                Console.Clear();
                AskUserForActionAdmin();
                break;
            case "2":
                //Dish.Remove();
                Console.Clear();
                AskUserForActionAdmin();
                break;
            case "3":
                Console.WriteLine("Czy na pewno chcesz wyjść z panelu administratora? (T\\N)");
                if(Console.ReadLine().ToLower() == "t")
                {
                    Console.Clear();
                    AskUserForAction();
                    break;
                }
                else
                {
                    Console.Clear();
                    AskUserForActionAdmin();
                    break;
                }
            case "4":
                Console.WriteLine("By zmienić hasło podaj aktualnie ustawione: ");
                if (Console.ReadLine().ToLower() == AdminPass.GetPasswd())
                {
                    string newpass = "";
                    Console.WriteLine("Podaj nowe hasło: ");
                    newpass = Console.ReadLine().ToLower();
                    Console.WriteLine("Podaj ponownie nowe hasło by potwierdzić: ");
                    if(Console.ReadLine().ToLower() == newpass)
                    {
                        AdminPass.UpdatePasswd(newpass);
                        Console.Clear();
                        Console.WriteLine("Hasło zostało zmienione, wylogowano z panelu administratora");
                        AskUserForAction();
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Hasła nie zgadzają się, anuluję zmianę hasła");
                        AskUserForActionAdmin();
                        break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Podano niepoprawne hasło, spróbuj ponownie");
                    AskUserForAction();
                    break;
                }
            case "5":
                Environment.Exit(0);
                break;
            default:
                Console.Clear();
                Console.WriteLine("Wybrano niepoprawną opcję, spróbuj ponownie");
                AskUserForActionAdmin();
                break;
        }
    }
}