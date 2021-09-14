using System;

namespace InstagramAgeControl
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kautaja sünniaastat
            //programm arvab kasutaja vanust
            //programm kontrollib, kas kautaja on vanem kui 13 või 13 aastat vana
            //kui kasutaja on on 13 aastat vana või vanem
            //siis võib instagram'i kasutada
            //kui kasutaja on noorem, kui 13 siis on ta liiga noor.

            Console.WriteLine("Sisesta oma sünniaasta:");
            int userAge = Convert.ToInt32(Console.ReadLine());

            if(userAge >= 13)
            {
                Console.WriteLine("Tere tulemast instagram'i.");
            }    
            else
            {
                Console.WriteLine("oled liiga noor.");
            }





        }

    }
}
