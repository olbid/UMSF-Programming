using System;
using System.Text;



class Program
{

    struct Country
    {

        public string name;
        public int population;
        public string region;

        public string display()
        {
            string result = "Назва країни: " + name + ". Кількість населення: " + Convert.ToString(population)
               + ". Регіон: " + region;

            return result;
        }
    }


    static void Main(string[] args)
    {
        // необхідні команди для коректного виводу/вводу українською мовою
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        // ініціалізація необхідних змінних
        Country country = new Country();
        List<Country> countries = new List<Country>();
        int number_of_countries;
        string[] possible_regions = { "EU", "NA", "SA", "APAC" };



        Console.Write("Скільки країн буде у списку: ");
        number_of_countries = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введіть дані: ");

        for (int i = 0; i < number_of_countries; i++)
        {
            Console.Write("Назва: ");
            country.name = Console.ReadLine();
            Console.Write("Кільість населення: ");
            country.population = Convert.ToInt32(Console.ReadLine());
            Console.Write("Регіон (NA/SA/EU/APAC): ");
            country.region = Console.ReadLine();
            countries.Add(country);
        }

        for (int i = 0; i < number_of_countries; i++)
        {
            Console.WriteLine(countries[i].display());
        }

        // кількість країн у частині світу 
        Console.Write("Яка частина світу цікавить: ");
        string target_region = Console.ReadLine();
        Console.WriteLine();

        int count = 0;
        int total_population = 0;

        for (int i = 0; i < number_of_countries; i++)
        {
            if (possible_regions.Contains(target_region))
            {
                if (countries[i].region == target_region)
                {
                    total_population += countries[i].population;
                    count++;
                }
            }
            else
            {
                Console.WriteLine("Такого регіону немає!");
            }

        }
        Console.WriteLine("Кількість країн у цій частині світу: " + count);
        Console.WriteLine("Загальна кількість населення країн у цій частині світу: " + total_population);


    }

}