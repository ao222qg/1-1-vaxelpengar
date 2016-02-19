using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1växelpengar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklarera variablerna.

            double roundingOffAmount = 0d;
            double totalSum = 0d;
            uint amount = 0;
            uint total = 0;
            uint change = 0;
    


            while (true) // While gör att programmet körs så länge det inmatade värdet är lämpligt.
            {
                try //try blockerar så att catch satsen inte utlöses direkt.
                {
                    Console.Write("Ange totalsumma     : ");
                    totalSum = double.Parse(Console.ReadLine());
                    if (totalSum <= 1) // If kontrollerar om det inmatade värdet är lämpligt för programmet att läsa av dvs. heltal och decimaler.
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nTotalsumman är för liten. Köpet kunde inte genomföras.");
                        Console.ResetColor();
                        return;
                    }
                    else
                    {
                        break;
                    }

                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nFel! Erhållet belopp felaktig.");
                    Console.ResetColor();
                }
            }

            //Öresavrundning med hjälp av Math.Round
            total = (uint)Math.Round(totalSum);
            roundingOffAmount = totalSum - total;


            while (true)
            {
                try
                {
                    Console.Write("Ange erhållet belopp: ");
                    amount = uint.Parse(Console.ReadLine());
                    if (amount < total)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nErhållet belopp är för litet. Köpet kunde inte genomföras");
                        Console.ResetColor();
                        return;
                    }
                    else
                    {
                        break;
                    }

                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nFel! Erhållet belopp felaktig.");
                    Console.ResetColor();
                }
            }

            // Används för uträkning av vad man får tillbaka i växel.
            change = amount - total;

            //Uträkningar görs och datan skrivs ut i form av ett kvitto
            Console.WriteLine("\nKVITTO ");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Totalt\t\t: {0:0} \tkr", totalSum);
            Console.WriteLine("Öresavrundning\t: {0:f2} \tkr", roundingOffAmount);
            Console.WriteLine("Att betala\t: {0:0} \tkr", totalSum - roundingOffAmount);
            Console.WriteLine("Kontant\t\t: {0:0} \tkr", amount);
            Console.WriteLine("Tillbaka\t: {0:0} \tkr", change);
            Console.WriteLine("---------------------------");


            // Växel som kunden ska ha tillbaka delas upp i antal 500, 100, 50 och 20-lappar samt antal 10, 5 och 1-kronor. 
            if (change >= 500)
            {
                Console.WriteLine("500-lappar\t: {0}", (change / 500));
                change = change % 500;
            }

            if (change >= 100)
            {
                Console.WriteLine("100-lappar\t: {0}", (change / 100));
                change = change % 100;
            }
            if (change >= 50)
            {
                Console.WriteLine("50-lappar\t: {0}", (change / 50));
                change = change % 50;
            }

            if (change >= 20)
            {
                Console.WriteLine("20-lappar\t: {0}", (change / 20));
                change = change % 20;
            }

            if (change >= 10)
            {
                Console.WriteLine("10-kronor\t: {0}", (change / 10));
                change = change % 10;
            }

            if (change >= 5)
            {
                Console.WriteLine("5-kronor\t: {0}", (change / 5));
                change = change % 5;
            }

            if (change >= 1)
            {
                Console.WriteLine("1-kronor\t: {0}", (change / 1));
                change = change % 1;
            }

        }
    }
}

