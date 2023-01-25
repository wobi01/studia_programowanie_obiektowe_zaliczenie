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
                //stuff to do
                Console.Clear();
                AskUserForAction();
                break;
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

}