using studia_programowanie_obietkowe_zaliczenie;

class Program
{
    public static Menu _menu;

    static void Main(string[] args)
    {
        _menu = new Menu();
        AskUserForAction();
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
                Console.WriteLine("By uzyskać dostęp do panelu administratora podaj hasło (domyślne hasło to 'admin'): ");
                if (Console.ReadLine().ToLower() == "admin")
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
        Console.WriteLine("4. Zakończ program");
        Console.WriteLine("____________________________");
        Console.Write("Wybór: ");
        switch (Console.ReadLine())
        {
            case "1":
                //stuff to do
                Console.Clear();
                AskUserForActionAdmin();
                break;
            case "2":
                //stuff to do
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