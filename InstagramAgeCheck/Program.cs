﻿using System;

namespace InstagramAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutaja vanust;
            //Programm kontrollib, kas kasutaja on vanem kui 13 või 13 aastat vana;
            //Kui kasutaja on 13 aastat vana või vanem, siis ta võib Instagram´i kasutada;
            //Kui kasutaja on noorem, kui 13 siis ta on liiga noor.
            Console.WriteLine("Palun sisesta oma vanus:");
            int userAge = Convert.ToInt32 (Console.ReadLine());
            if (userAge > 13)
            {
                Console.WriteLine("Oled piisavalt vana, et Instagrami kontot luua.");
            }
            else if (userAge < 13)
            {
                Console.WriteLine("Oled liiga noor, et Instagrami kontot luua");
            }
            else  
            {
                Console.WriteLine("Oled piisavalt vana, et Instagrami kontot luua.");
            }

            Console.WriteLine("Kena päeva!");


                 
           







        }
    }
}
