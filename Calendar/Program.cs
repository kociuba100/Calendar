using System;

namespace Calendar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome in calendar with reminder");
            Console.WriteLine("Please let me know your choice:");
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. Remove Item");
            Console.WriteLine("3 Check Item");
            int choiceOption;
            choiceOption = 15;
            Console.WriteLine(choiceOption);
            string choice = Console.ReadLine();
            Console.WriteLine("czekam na enter");
            Console.WriteLine($"You hav choice option number: {choice}");

            Console.WriteLine("czekam na enter ");

            Int32.TryParse(choice, out choiceOption);

            Console.WriteLine("Please choose another option...");
            choice = Console.ReadLine();

            bool isTrue = true;
            bool isFalse = false;

            int a = 5;
            int b = a;

            Console.WriteLine(a);
            Console.WriteLine(b);

            b = 50;
            Console.WriteLine(a);
            Console.WriteLine(b);


            Item item = new Item() { Id = 1, Name = "Apple" };
            Item item2 = item;

            Console.WriteLine(item.Name); //wysiweli Apple
            Console.WriteLine(item2.Name); //wyświetli Apple

            item2.Name = "Watermelon";

            Console.WriteLine(item.Name); //wyświetli Apple
            Console.WriteLine(item2.Name); //wyświetli Watermleon 




            int c = 13 / 5 / 2;
            int d = 13 / (5 / 2);
            Console.WriteLine($"c = {c}, d = {d}");
            Console.ReadLine();
        }

    }
}
