using studia_programowanie_obietkowe_zaliczenie;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Web;

class Program
{
    private static Menu _menu = new Menu();
    private static Order _order = new Order();

    static void Main(string[] args)
    {
        AdminPass adminPass = new AdminPass();
        AdminPass.ReadPassFile();
        _menu = new Menu();
        _order = new Order();
        Category fish = new Category("Rybne");
        Category soup = new Category("Zupy");
        Category meat = new Category("Mięsne");
        Category starter = new Category("Przystawki");
        _menu.AddCategory(fish);
        _menu.AddCategory(soup);
        _menu.AddCategory(meat);
        _menu.AddCategory(starter);
        _menu.categories[0].AddDish(Dish.DishType.Fish, "Sandacz", 25.0);
        _menu.categories[1].AddDish(Dish.DishType.Soup, "Żurek", 7.0);
        _menu.categories[2].AddDish(Dish.DishType.Meat, "Schabowy", 12.0);
        _menu.categories[3].AddDish(Dish.DishType.Starter, "Bułeczki", 4.0);
        AskUserForAction();
    }

    public static void AskUserForAction()
    {
        Console.WriteLine("Wybierz co chcesz zrobić: ");
        Console.WriteLine("1. Wyświetl menu");
        Console.WriteLine("2. Wyszukaj danie");
        Console.WriteLine("3. Złóż zamówienie");
        Console.WriteLine("4. Panel administracyjny");
        Console.WriteLine("5. Zakończ program");
        Console.WriteLine("____________________________________________");
        Console.Write("Wybór: ");
        switch (Console.ReadLine())
        {
            case "1":
                Console.Clear();
                string[] categories = _menu.GetCategories();
                Console.WriteLine("_________________ Menu _________________");
                Array.ForEach(_menu.GetCategories(), Console.WriteLine);
                int exit = categories.Count() + 1;
                Console.WriteLine(categories.Count() + 1 + ". Wróć");
                Console.WriteLine("Wybierz kategorię: ");
                Console.Write("Wybór: ");
                int iSelectedCategory = 0;
                ConsoleKeyInfo UserInput = Console.ReadKey();
                int uInput = int.Parse(UserInput.KeyChar.ToString());
                if (char.IsDigit(UserInput.KeyChar))
                {
                    iSelectedCategory = int.Parse(UserInput.KeyChar.ToString());
                }
                iSelectedCategory--;
                Console.WriteLine();
                if (uInput < exit)
                {
                    Array.ForEach(_menu.categories[iSelectedCategory].GetDishes(), Console.WriteLine);
                    Console.WriteLine("Naciśnij enter, by wrócić");
                    Console.ReadKey();
                    Console.Clear();
                    goto case "1";
                }
                else
                {
                    Console.Clear();
                    AskUserForAction();
                }
                break;
            case "2":
                Console.Clear();
                Console.Write("Wpisz nazwę wyszukiwanego dania: ");
                _menu.SearchByName(Console.ReadLine().ToLower()).ForEach(i => Console.WriteLine(i.ToString()));
                Console.WriteLine("Naciśnij enter by wrócić do menu");
                Console.ReadKey();
                Console.Clear();
                AskUserForAction();
                break;
            case "3":
                Console.WriteLine("_____________________Składanie zamówienia_____________________");
                Console.WriteLine("Wybierz z poniższej listy co chcesz zrobić:");
                Console.WriteLine("1. Dodaj do zamówienia danie rybne");
                Console.WriteLine("2. Dodaj do zamówienia zupę");
                Console.WriteLine("3. Dodaj do zamówienia danie mięsne");
                Console.WriteLine("4. Dodaj do zamówienia przystawkę");
                Console.WriteLine("5. Usuń pozycję ze swojego zamówienia");
                Console.WriteLine("6. Zobacz podsumowanie swojego zamówienia");
                Console.WriteLine("7. Złóż zamówienie");
                Console.WriteLine("8. Anuluj zamówienie");
                int selectedOption = int.Parse(Console.ReadLine());
                switch (selectedOption)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Wybierz danie rybne:");
                        Array.ForEach(_menu.categories[0].GetDishes(), Console.WriteLine);
                        Console.WriteLine("Wybierz danie (podaj jego numer):");
                        int selectedDish = int.Parse(Console.ReadLine());
                        _order.AddPosition(_menu.categories[0].GetDish(selectedDish));
                        Console.Clear();
                        Console.WriteLine("Danie zostało poprawnie dodane");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Wybierz zupę:");
                        Array.ForEach(_menu.categories[1].GetDishes(), Console.WriteLine);
                        Console.WriteLine("Wybierz danie (podaj jego numer):");
                        int selectedDish2 = int.Parse(Console.ReadLine());
                        _order.AddPosition(_menu.categories[1].GetDish(selectedDish2));
                        Console.Clear();
                        Console.WriteLine("Danie zostało poprawnie dodane");
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Wybierz danie mięsne:");
                        Array.ForEach(_menu.categories[2].GetDishes(), Console.WriteLine);
                        Console.WriteLine("Wybierz danie (podaj jego numer):");
                        int selectedDish3 = int.Parse(Console.ReadLine());
                        _order.AddPosition(_menu.categories[2].GetDish(selectedDish3));
                        Console.Clear();
                        Console.WriteLine("Danie zostało poprawnie dodane");
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Wybierz przystawkę:");
                        Array.ForEach(_menu.categories[3].GetDishes(), Console.WriteLine);
                        Console.WriteLine("Wybierz przystawkę (podaj jej numer):");
                        int selectedDish4 = int.Parse(Console.ReadLine());
                        _order.AddPosition(_menu.categories[3].GetDish(selectedDish4));
                        Console.Clear();
                        Console.WriteLine("Danie zostało poprawnie dodane");
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Aktualna zawartość twojego zamówienia:");
                        _order.Summary();
                        Console.WriteLine("By usunąć pozycję ze swojego zamówienia podaj jej numer: ");
                        int DishToDeleteChoice = int.Parse(Console.ReadLine());
                        _order.RemovePosition(DishToDeleteChoice);
                        Console.Clear();
                        Console.WriteLine("Danie zostało poprawnie usunięte");
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Aktualna zawartość twojego zamówienia:");
                        _order.Summary();
                        break;
                    case 7:
                        Console.Clear();
                        _order.Summary();
                        Console.WriteLine("Czy zamówienie się zgadza i chcesz je potwierdzić? (T\\N)");
                        string choice = Console.ReadLine();
                        if (choice.ToLower() == "t")
                        {
                            _order.Confirmation();
                            AskUserForAction();
                        }
                        else
                        {
                            Console.WriteLine("Wracam do składania zamówienia");
                        }
                        break;
                    case 8:
                        Console.WriteLine("Czy na pewno chcesz anulować zamówienie? (T\\N)");
                        if (Console.ReadLine().ToLower() == "t")
                        {
                            _order.ClearOrder();
                            Console.Clear();
                            Console.WriteLine("Zamówienie zostało anulowane");
                            AskUserForAction();
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            break;
                        }
                    default:
                        Console.Clear();
                        Console.WriteLine("Wybrano niepoprawną opcję, spróbuj ponownie");
                        break;
                }
                goto case "3";
            case "4":
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
            case "5":
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
                {
                    string[] categories = _menu.GetCategories();
                    Console.WriteLine("_________________ Menu _________________");
                    Array.ForEach(_menu.GetCategories(), Console.WriteLine);
                    Console.WriteLine("Wybierz kategorię by dodać danie:");
                    string selection = Console.ReadLine();
                    switch (Convert.ToInt16(selection))
                    {
                        case 1:
                            Console.WriteLine("Podaj nazwę dania: ");
                            string dishName = Console.ReadLine();
                            Console.WriteLine("Podaj cenę dania: ");
                            double dishPrice = Convert.ToDouble(Console.ReadLine());
                            _menu.categories[0].AddDish(Dish.DishType.Fish, dishName, dishPrice);
                            break;
                        case 2:
                            Console.WriteLine("Podaj nazwę dania: ");
                            string dishName2 = Console.ReadLine();
                            Console.WriteLine("Podaj cenę dania: ");
                            double dishPrice2 = Convert.ToDouble(Console.ReadLine());
                            _menu.categories[1].AddDish(Dish.DishType.Soup, dishName2, dishPrice2);
                            break;
                        case 3:
                            Console.WriteLine("Podaj nazwę dania: ");
                            string dishName3 = Console.ReadLine();
                            Console.WriteLine("Podaj cenę dania: ");
                            double dishPrice3 = Convert.ToDouble(Console.ReadLine());
                            _menu.categories[2].AddDish(Dish.DishType.Meat, dishName3, dishPrice3);
                            break;
                        case 4:
                            Console.WriteLine("Podaj nazwę dania: ");
                            string dishName4 = Console.ReadLine();
                            Console.WriteLine("Podaj cenę dania: ");
                            double dishPrice4 = Convert.ToDouble(Console.ReadLine());
                            _menu.categories[3].AddDish(Dish.DishType.Starter, dishName4, dishPrice4);
                            break;
                    }
                    Console.Clear();
                    Console.WriteLine("Danie zostało dodane, wracam do panelu administratora.");
                    System.Threading.Thread.Sleep(850);
                    Console.Clear();
                    Console.WriteLine("Danie zostało dodane, wracam do panelu administratora..");
                    System.Threading.Thread.Sleep(850);
                    Console.Clear();
                    Console.WriteLine("Danie zostało dodane, wracam do panelu administratora...");
                    System.Threading.Thread.Sleep(850);
                    Console.Clear();
                    AskUserForActionAdmin();
                    break;
                }
            case "2":
                {
                    string[] categories = _menu.GetCategories();
                    Console.WriteLine("_________________ Menu _________________");
                    Array.ForEach(_menu.GetCategories(), Console.WriteLine);
                    Console.WriteLine("Wybierz kategorię by usunąć danie: ");
                    int selectedCategory = Convert.ToInt16(Console.ReadLine());
                    if (_menu.categories[selectedCategory - 1].GetDishes().Count() == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Brak dań w wybranej kategorii, wracam do panelu administratora");
                        AskUserForActionAdmin();
                        break;
                    }
                    else
                    {
                        switch (selectedCategory)
                        {
                            case 1:
                                Array.ForEach(_menu.categories[0].GetDishes(), Console.WriteLine);
                                break;
                            case 2:
                                Array.ForEach(_menu.categories[1].GetDishes(), Console.WriteLine);
                                break;
                            case 3:
                                Array.ForEach(_menu.categories[2].GetDishes(), Console.WriteLine);
                                break;
                            case 4:
                                Array.ForEach(_menu.categories[3].GetDishes(), Console.WriteLine);
                                break;
                        }
                        Console.WriteLine("Wybierz danie do usunięcia: ");
                        int dishToRemove = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Czy na pewno chcesz usunąć danie? (T\\N)");
                        if (Console.ReadLine().ToLower() == "t")
                        {
                            _menu.categories[selectedCategory - 1].DeleteDish(dishToRemove - 1);
                            Console.Clear();
                            Console.WriteLine("Danie zostało usunięte, wracam do panelu administratora.");
                            System.Threading.Thread.Sleep(850);
                            Console.Clear();
                            Console.WriteLine("Danie zostało usunięte, wracam do panelu administratora..");
                            System.Threading.Thread.Sleep(850);
                            Console.Clear();
                            Console.WriteLine("Danie zostało usunięte, wracam do panelu administratora...");
                            System.Threading.Thread.Sleep(850);
                            Console.Clear();
                            AskUserForActionAdmin();
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Anulowano usunięcie dania, wracam do panelu administratora");
                            AskUserForActionAdmin();
                            break;
                        }
                    }

                }
            case "3":
                {
                    Console.WriteLine("Czy na pewno chcesz wyjść z panelu administratora? (T\\N)");
                    if (Console.ReadLine().ToLower() == "t")
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
                }
            case "4":
                {
                    Console.WriteLine("By zmienić hasło podaj aktualnie ustawione: ");
                    if (Console.ReadLine().ToLower() == AdminPass.GetPasswd())
                    {
                        string newpass = "";
                        Console.WriteLine("Podaj nowe hasło: ");
                        newpass = Console.ReadLine().ToLower();
                        Console.WriteLine("Podaj ponownie nowe hasło by potwierdzić: ");
                        if (Console.ReadLine().ToLower() == newpass)
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
                        AskUserForActionAdmin();
                        break;
                    }
                }
            case "5":
                {
                    Environment.Exit(0);
                }
                break;
            default:
                Console.Clear();
                Console.WriteLine("Wybrano niepoprawną opcję, spróbuj ponownie");
                AskUserForActionAdmin();
                break;
        }
    }
}