
public class Pract5 
{
    static List<string> names = new List<string>(); //Лист

    public static void Main(string[] args) //Публичный метод в строчном варианте 
    {
        Console.WriteLine("Введите свое ФИО:");
        string input = Console.ReadLine();
        string[] parts = input.Split(' ');

        // Проверка на корректность ввода ФИО
        if (parts.Length != 3)
        {
            Console.WriteLine("Некорректный ввод ФИО.");
            return;
        }

        // Добавление ФИО в список
        names.Add(parts[0]); // Фамилия
        names.Add(parts[1]); // Имя
        names.Add(parts[2]); // Отчество

        while (true)
        {
            Console.WriteLine("\nВыберите действие:");
            Console.WriteLine("1. Вытащить фамилию, имя или отчество");
            Console.WriteLine("2. Отсортировать фамилию");
            Console.WriteLine("3. Изменить имя, фамилию, отчество");
            Console.WriteLine("4. Вывести текущее ФИО");
            Console.WriteLine("5. Выход");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CodObrabotki();
                    break;
                case 2:
                    Sort();
                    break;
                case 3:
                    ZamenaFIO();
                    break;
                case 4:
                    FIO();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Неверный выбор.");
                    break;
            }
        }
    }

    static void CodObrabotki()
    {
        Console.WriteLine("Выберите, что вытащить:");
        Console.WriteLine("1. Фамилия");
        Console.WriteLine("2. Имя");
        Console.WriteLine("3. Отчество");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Фамилия: " + names[0]);
                break;
            case 2:
                Console.WriteLine("Имя: " + names[1]);
                break;
            case 3:
                Console.WriteLine("Отчество: " + names[2]);
                break;
            default:
                Console.WriteLine("Неверный выбор.");
                break;
        }
    }

    static void Sort()
    {
        Console.WriteLine("Как отсортировать фамилию:");
        Console.WriteLine("1. По возрастанию");
        Console.WriteLine("2. По убыванию");

        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            names[0] = string.Join("", names[0].OrderBy(c => c)); //Сортирует в порядке возрасания
        }
        else if (choice == 2)
        {
            names[0] = string.Join("", names[0].OrderByDescending(c => c)); //Сортирует в порядке убывания
        }
        else
        {
            Console.WriteLine("Неверный выбор.");
            return;
        }

        Console.WriteLine("Отсортированная фамилия: " + names[0]);
    }

    static void ZamenaFIO()
    {
        Console.WriteLine("Введите новое ФИО (через пробел):");
        string input = Console.ReadLine();
        string[] parts = input.Split(' ');

        // Проверка на корректность ввода ФИО
        if (parts.Length != 3)
        {
            Console.WriteLine("Некорректный ввод ФИО. Введите ФИО в формате 'Фамилия Имя Отчество'.");
            return;
        }

        names[0] = parts[0]; // Фамилия
        names[1] = parts[1]; // Имя
        names[2] = parts[2]; // Отчество
        Console.WriteLine("ФИО успешно изменено.");
    }

    static void FIO()
    {
        Console.WriteLine("Текущее ФИО: " + string.Join(" ", names)); //Соединяет все элементы списка и выводит
    }
}