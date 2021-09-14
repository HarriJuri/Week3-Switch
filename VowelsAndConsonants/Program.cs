using System;

namespace VowelsAndConsonants
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisestada tähte
            //programm kontrollib, kas sisestatud täht on
            //täishäälik või kaashäälik
            //kui sisestatud täht on kaashäälik - programm kuvab
            //"täishäälik"
            //kui sisestatud täht on kaashäälik
            //programm kuvab "kaashäälik"
            //kasutame switch'i

            Console.WriteLine("sisesta täht:");
            char userCharacter = Convert.ToChar(Console.WriteLine().ToLower());

            // "mingi sõne" -string
            // 'a' - character ehk char

            switch (userCharacter)
            {
                case 'a':
                    Console.WriteLine("Täishäälik");
                    break;
                case 'e':
                    Console.WriteLine("Täishäälik");
                    break;
                case 'i':
                    Console.WriteLine("Täishäälik");
                    break;
                case 'o':
                    Console.WriteLine("Täishäälik");
                    break;
                case 'u':
                    Console.WriteLine("Täishäälik");
                    break:
                        default:
                    Console.WriteLine("Täishäälik");
                    break:

                        Console.WriteLine("Kena päeva!");





            }






        }
    }
}
