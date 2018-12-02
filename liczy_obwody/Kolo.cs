using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liczy_obwody
{
    public class PustaNazwa : Exception
    {
        public PustaNazwa(string Message) : base(Message) { }
    }

    public class ZlyPromien : Exception
    {
        public ZlyPromien(string Message) : base(Message) { }
    }
    public class ZlyBok : Exception
    {
        public ZlyBok(string Message) : base(Message) { }
    }

    public class Kolo : Ksztalt
    {
        private string s_nazwa;
        private float f_promien;

        public string Nazwa
        {
            get
            {
                return s_nazwa;
            }
            set
            {
                if (string.IsNullOrEmpty(s_nazwa))
                {
                    throw new PustaNazwa("Nie można ustawić nazwy pustej.");
                }
                s_nazwa = value;
            }
        }
        public float Promien
        {
            get
            {
                return f_promien;
            }
            set
            {
                if (f_promien < 1.0f)
                {
                    throw new ZlyPromien("Nie można ustawić promienia mniejszego niż jeden.");
                }
                f_promien = value;
            }
        }

        public Kolo()
        {

        }

        public Kolo(string nazwa, float promien)
        {
            s_nazwa = nazwa;
            f_promien = promien;
        }

        public override void WprowadzDane()
        {
            Console.Clear();
            do
            {
                Console.WriteLine("Wprowadz nazwę: ");
                s_nazwa = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(s_nazwa));

            do
            {
                Console.WriteLine("Wprowadź promień: ");
            }
            while (float.TryParse(Console.ReadLine(), out f_promien) == false || f_promien < 1.0f);
        }

        public override float ObliczObwod() => (float)(2.0 * Math.PI * f_promien);
        public override string WyswietlInformacje() => $"Nazwa obiektu: {s_nazwa} \nObwod wynosi: {ObliczObwod()}";
    }
}
