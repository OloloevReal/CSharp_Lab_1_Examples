using System;
using System.Text.RegularExpressions;

namespace Lab_1_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Example_1();
            Example_2();
            Example_3();
            Example_4();
            Example_5();
            Example_6();
            Example_7();
            Example_8();
        }

        static void Example_1()
        {
            string[] firstNames = { "Саша", "Маша", "Олег", "Света", "Игорь" };
            Console.WriteLine("Here is the array:");
            for (int i = 0; i < firstNames.Length; i++)
                Console.WriteLine(firstNames[i] + "\t");
            Console.WriteLine("\n");
            Array.Reverse(firstNames);
            for (int i = 0; i < firstNames.Length; i++)
                Console.WriteLine(firstNames[i] + "\t");
            Console.WriteLine("\n");
            Console.WriteLine("Cleared out all but one…");
            Array.Clear(firstNames, 1, 4);
            for (int i = 0; i < firstNames.Length; i++)
                Console.WriteLine(firstNames[i] + "\t");
        }

        static void Example_2(){
        }
        static void Example_3(){
        }
        static void Example_4(){
        }
        static void Example_5(){
        }

        static void Example_6(){
        }
        static void Example_7(){
            string si = "Это строка для поиска";

            // найти любой пробельный символ следующий за непробельным
            Regex theReg = new Regex(@"(\S+)\s");

            // получить коллекцию результата поиска
            MatchCollection theMatches = theReg.Matches(si);

            // перебор всей коллекции
            foreach (Match theMatch in theMatches) {
                Console.WriteLine( "theMatch.Length: {0}", theMatch.Length);
                if (theMatch.Length != 0){
                    Console.WriteLine("theMatch: {0}", theMatch.ToString( ));
                }
            }
        }

        static void Example_8(){
            string stringl = "04:03:27 127.0.0.0 GotDotNet.ru";
            Regex theReg = new Regex( @"(?<time>(\d|\:)+)\s(?<ip>(\d|\.)+)\s(?<url>\S+)");

            // группа time – одна и более цифр или двоеточий, за которыми следует пробельный символ
            // группа ip адрес – одна и более цифр или точек, за которыми следует пробельный символ
            // группа url – один и более непробельных символов

            MatchCollection theMatches = theReg.Matches(stringl);
            foreach (Match theMatch in theMatches) {
                if (theMatch.Length != 0) {
                    // выводим найденную подстроку
                    Console.WriteLine("\ntheMatch: {0}", theMatch.ToString ());
                    // выводим группу "time"
                    Console.WriteLine ("time: {0}", theMatch.Groups["time"]);
                    // выводим группу "ip"
                    Console.WriteLine("ip: {0}", theMatch.Groups["ip"]);
                    // выводим группу "url"
                    Console.WriteLine("url: {0}", theMatch.Groups["url"]);
                }
            }
        }
    }
}
