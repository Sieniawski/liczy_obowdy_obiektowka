using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liczy_obwody
{
    class Program
    {
        private static int x;
        private static int y;
        static void Main(string[] args)
        {
            try
            {
                RunApp();
            }
            catch (PustaNazwa e) { Console.WriteLine(e.Message); }
            catch (ZlyPromien e) { Console.WriteLine(e.Message); }
            catch (ZlyBok e) { Console.WriteLine(e.Message); }
            //catch (FormatException) { Console.WriteLine("Wprowadzono liczbę w złym formacie."); }
            catch (OverflowException) { Console.WriteLine("Wprowadzona liczba jest poza dopuszczalnym zakresem."); }
            catch (StackOverflowException) { Console.WriteLine("No to żeś stos zawalił, tej!"); }
            catch (ArgumentNullException) { Console.WriteLine("Koniec strumienia, koniec strumienia, na-na-nanana, koniec strumienia :-)"); }
            //catch (Exception) { Console.WriteLine("A jednak diabli wszystko wzięli. Idziemy do bloku finally :P"); }
            finally
            {
                //Dispose();
            }
        }
        static void RunApp()
        {
            string info = "Program zapyta Cię o dwie wartości: x i y.\n" +
                "Potem program poprosi Cię o podanie danych dla tworzonych obiektów: kół i prostokątów.\n" +
                "Po wprowadzeniu danych system wyświetli informacje o wszystkich obiektach w macierzy\n" +
                "o rozmiarze x na y oraz wskaże, który z obiektów ma największą objętość.\n" +
                "\n" +
                "Wciśnij dowolny klawisz.";

            Console.WriteLine(info);
            Console.ReadKey();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Podaj wartość parametru x: ");
                if (int.TryParse(Console.ReadLine(), out x) || x < 1)
                    break;
            }

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Podaj wartość parametru y: ");
                if (int.TryParse(Console.ReadLine(), out y) || y < 1)
                    break;
            }

            Ksztalt[,] tablica = new Ksztalt[x, y];

            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    if (y % 2 == 2)
                    {
                        Ksztalt k = new Kolo();
                        k.WprowadzDane();
                    }
                    else
                    {
                        Ksztalt k = new Prostokat();
                        k.WprowadzDane();
                    }
                }
            }
        }
    }
}

