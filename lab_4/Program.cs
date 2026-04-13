using System;
using System.Text;



class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("******************* Завдання № 1 *******************");
        string first_task_string = "Eye of the tiger, Boom, Boom 1 125 dsad";
        int number_of_symbols = 0;


        if (first_task_string.LastIndexOf(",") != -1)
        {
            for (int i = 0; i < first_task_string.Length; i++)
            {
                number_of_symbols++;
                if (i == first_task_string.LastIndexOf(","))
                {
                    break;
                }

            }
            Console.WriteLine("Кількість символів у рядку до останньої коми у рядку: \"" + first_task_string + "\" дорівнює " + number_of_symbols);
        }
        else
        {
            Console.WriteLine("У рядку немає ком!");
        }

        Console.WriteLine("******************* Завдання № 2 *******************");
        Console.WriteLine("************* /Заміна елементів рядка/ *************");

        string str, str1, str2, str_after_removing_letters;

        Console.Write("str: ");
        str = Console.ReadLine();
        Console.Write("str1: ");
        str1 = Console.ReadLine();
        Console.Write("str2: ");
        str2 = Console.ReadLine();

        Console.WriteLine("Після заміни усіх входжень str1 на str2: " + str.Replace(str1, str2));

        Console.WriteLine("******************* Завдання № 3 *******************");
        Console.WriteLine("************** /Видалення всіх літер/ **************");

        Console.Write("str: ");
        str = Console.ReadLine();
        str_after_removing_letters = str;
        for (int i = str.Length - 1; i >= 0; i--)
        {
            if (char.IsLetter(str[i]) == true)
            {
                str_after_removing_letters = str_after_removing_letters.Remove(i, 1);
            }
        }

        Console.WriteLine("Рядок \"" + str + "\" після видалення у ньому всіх літер: " + str_after_removing_letters);

        Console.WriteLine("******************* Завдання № 4 *******************");
        Console.WriteLine("****** /Вставлення 0 після кожного пропуску/ *******");

        Console.Write("str: ");
        str = Console.ReadLine();
        string string_after_insertion = str;

        for (int i = str.Length - 1; i >= 0; i--)
        {
            if (char.IsWhiteSpace(str[i]) == true)
            {
                string_after_insertion = string_after_insertion.Insert(i + 1, "0");
            }

        }

        Console.WriteLine("Рядок \"" + str + "\" після вставлення 0 після кожного пропуску: " + string_after_insertion);


    }

}










