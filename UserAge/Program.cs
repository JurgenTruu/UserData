using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma vanus");
            int Age = Convert.ToInt32(Console.ReadLine());
            int userYearOfBirth = 2022 - Age;
            Console.WriteLine("Oled sündinud aastal " + userYearOfBirth );
        }
    }
}
