using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liczy_obwody
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RunApp();
            }
            catch (ZlyPromien e) { Console.WriteLine(e.Message); }
            catch (ZlyBokA e) { Console.WriteLine(e.Message); }
            catch (ZlyBokB e) { Console.WriteLine(e.Message); }
            catch (ZlaNazwaKolo e) { Console.WriteLine(e.Message); }
            catch (ZlaNazwaProstokat e) { Console.WriteLine(e.Message); }
            catch (System.FormatException) { Console.WriteLine("Nie umiem tego obsluzyc."); }
            finally
            {
                DoCleanUp();
            }
        }
        static void RunApp()
        {
            Kolo test = new Kolo();
            test.WprowadzDane();
            test.WyswietlInformacje();
            Console.WriteLine("Obwod wynosi: " + test.ObliczObwod() + " jednostek.");
            Console.ReadKey();
        }
        static void DoCleanUp()
        {

        }
    }
}
