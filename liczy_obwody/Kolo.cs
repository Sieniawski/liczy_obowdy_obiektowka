using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liczy_obwody
{
    //wyjatki
    public class ZlyPromien : Exception
    {
        public ZlyPromien(string Message) : base(Message)
        { }
    }

    public class ZlaNazwaKolo : Exception
    {
        public ZlaNazwaKolo(string Message) : base(Message)
        { }
    }

    class Kolo : Ksztalt
    {

        //Pola
        private string s_nazwa = "";
        private float f_promien = 0.0f;
        public string S_nazwa
        {
            get
            {
                return s_nazwa;
            }
            set
            {
                s_nazwa = value;
            }
        }
        public float F_promien
        {
            get
            {
                return f_promien;
            }
            set
            {
                if (value < 1)
                    throw new ZlyPromien($"Podaj dobry promien wiekszy od 1!");

                f_promien = value;
            }
        }

        public Kolo()
        {

        }

        public Kolo(float f_promien, string s_nazwa)
        {
            if (f_promien < 1)
            {
                throw new ZlyPromien($"Podaj dobry promien wiekszy od 1!");
            }
            if (string.IsNullOrEmpty(s_nazwa))
            {
                throw new ZlaNazwaKolo($"String jest pusty, wprowadz nazwe!");
            }
        }

        public override void WyswietlInformacje()
        {
            Console.WriteLine($"Nazwa: {s_nazwa}, promień: {f_promien}");
        }

        public override void WprowadzDane()
        {
            do
            {
                Console.WriteLine("Wprowadz nazwe:");
                S_nazwa = Console.ReadLine();
            } while (string.IsNullOrEmpty(s_nazwa));

            while (true)
            {
                Console.WriteLine("Wprowadz promien:");
                try
                {
                    F_promien = float.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
            }
        }

        public override float ObliczObwod()
        {
            return (float)(2.0f * Math.PI * f_promien);
        }
    }

}
