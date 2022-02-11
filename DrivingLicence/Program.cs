using System;

namespace DrivingLicence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun sisesta oma sünniaasta");
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());
            int userAge = 2022 - YearOfBirth;
            if (userAge < 18)
            {
                Console.WriteLine("Oled liiga noor, et juhilube saada!");
            }
            else if (userAge > 18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhilube saada!");
            }
            else if (userAge == 18)
            {
                Console.WriteLine("Palju õnne! Nüüd saad juhilube taodelda");
            }
        }
    }
}
