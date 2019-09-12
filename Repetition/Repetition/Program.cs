using System;

namespace Repetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int selection;

            //Kaikki tehtävän laskutoimitukset tehty yhteen projektiin.
            //"selection" valitsee tarkistettavan tehtävän käyttäjän valinnan perusteella.
            Console.WriteLine("Select the assignment you wish to check:");
            Console.WriteLine("1 checks assignment 1");
            Console.WriteLine("2 checks assignments 2 and 4");
            Console.WriteLine("3 checks assignments 3 and 5");
            Console.WriteLine("Input selection:");
            selection = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //Valitaan tehtävä ja sitä varten tehty funktio if-rakenteella.
            //Varuiksi lisätty vaihtoehto väärille numeroarvoille, ei kaadu jos syöttää esim. 4.
            if (selection == 1)
            {
                Console.WriteLine("Input number for multiplication:");
                number = int.Parse(Console.ReadLine());

                Multiply(number);

            } else if (selection == 2)
            {
                Console.WriteLine("Input number for addition:");
                number = int.Parse(Console.ReadLine());

                Addition(number);

            } else if (selection == 3)
            {
                Console.WriteLine("Input number for split addition:");
                number = int.Parse(Console.ReadLine());

                SplitAdd(number);

            } else
            {
                Console.WriteLine("Invalid selection, please reboot.");
            }
            
        }

        //Tehtävän 1 funktio.
        static void Multiply(int given)
        {
            //"number" käyttäjän antama numero, "calc" on lopputulos laskennan jälkeen
            int number = given;
            int calc = 1;

            //If-rakenteella karsitaan helpot vastaukset pois.
            if (number == 0)
            {
                Console.WriteLine("Your answer is " + calc + ".");
            } else if (number < 0)
            {
                Console.WriteLine("Your answer is undefined");
            } else
            {
                //Toisto-rakenteella lasketaan.
                //"calc" kerrotaan "number" arvolla, "number" arvo vähennetään yhdellä. Toistetaan kunnes "number" on 0.
                do
                {
                    calc *= number;
                    number -= 1;

                } while (number > 0);
                //Tulostetaan lopputulos "calc".
                Console.WriteLine("Your answer is " + calc + ".");
            }
        }
        //Tehtävien 2 ja 4 funktio.
        static void Addition(int given)
        {
            //"number" on käyttäjän antama arvo, "calc" on lopputulos laskennan jälkeen.
            int number = given;
            int calc = 0;

            //Tarkistetaan ensin, onko käyttäjän antama arvo positiivinen vai negatiivinen.
            //"number" lisätään "calc" arvoon, "number" vähennetään yhdellä. Toistetaan kunnes "number" on 0.
            //Negatiivisilla arvoilla samat laskutoimet, mutta "number" muunnetaan ensin positiiviseksi ja "calc" jälkeen negatiiviseksi.
            if (number > 0)
            {
                do
                {
                    calc += number;
                    number -= 1;

                } while (number > 0);

            } else if (number < 0)
            {
                number *= -1;

                do
                {
                    calc += number;
                    number -= 1;

                } while (number > 0);

                calc *= -1;
            }
            //Tulostetaan lopputulos.
            Console.WriteLine("Your answer is " + calc + ".");
        }
        //Tehtävien 3 ja 5 funktio.
        static void SplitAdd(int given)
        {
            //"number" on käyttäjän antama arvo, "odd" ja "even" ovat lopputulokset laskennan jälkeen.
            int number = given;
            int odd = 0;
            int even = 0;

            //tarkistetaan, onko käyttäjän antama arvo positiivinen.
            if (number > 0)
            {
                //Tarkistetaan, onko käyttäjän antama arvo parillinen vai pariton.
                if (number % 2 == 0)
                {
                    //Jos käyttäjän antama arvo oli parillinen, lasketaan.
                    //"even" arvoon alkuperäinen numero, "odd" arvoon lisätään alkuperäinen arvo josta vähennetty 1.
                    //"number" arvosta vähennetään taas 1, toistetaan kunnes "number" on 0.
                    do
                    {
                        even += number;
                        number -= 1;
                        odd += number;
                        number -= 1;

                    } while (number > 0);
                } else
                {
                    //Jos käyttäjän antama arvo ei ollut parillinen, lasketaan näin.
                    //käytännössä samat laskut, "odd" ja "even" vain vaihtavat paikkoja.
                    do
                    {
                        odd += number;
                        number -= 1;
                        even += number;
                        number -= 1;

                    } while (number > 0);
                }
                //Lasketaan näin, jos käyttäjän numero on negatiivinen.
                //Samat laskut kuin yllä, mutta luku muutetaan positiiviseksi ennen laskuja ja tulokset muutetaan negatiiviseksi laskujen jälkeen.
            } else if (number < 0)
            {
                number *= -1;

                if (number % 2 == 0)
                {
                    do
                    {
                        even += number;
                        number -= 1;
                        odd += number;
                        number -= 1;

                    } while (number > 0);
                }
                else
                {
                    do
                    {
                        odd += number;
                        number -= 1;
                        even += number;
                        number -= 1;

                    } while (number > 0);
                }

                odd *= -1;
                even *= -1;
            }
            //Tulostetaan lopputulokset laskennan jälkeen.
            Console.WriteLine("Your answers are " + odd + " for odd numbers, and " + even + " for even numbers.");
        }
    }
}
