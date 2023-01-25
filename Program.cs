using studia_programowanie_obietkowe_zaliczenie;

class Program
{
    private Menu _menu;

    static void Main(string[] args)
    {
        _Menu = new Menu();
        Console.WriteLine("Wybierz co chcesz zrobić: ");
        Console.WriteLine("1. Wyświetl menu");
        Console.WriteLine("2. Złóż zamówienie");
        Console.WriteLine("3. Panel administracyjny");
    }

    public static void AskUserForAction()
    {
        Console.Write("Wybór: ");
        switch (Console.ReadLine())
        {
            case 1:
                //asd
                break;
            case 2:
                Order();
                break;
            default:
                Console.WriteLine("Wybrano niepoprawną opcję, spróbuj ponownie");
                AskUserForAction();
                break;
        }
    }

}