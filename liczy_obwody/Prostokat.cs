using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liczy_obwody
{
    public class Prostokat : Ksztalt
    {
        private string s_nazwa;
        private float f_boka;
        private float f_bokb;

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

        public float BokA
        {
            get
            {
                return f_boka;
            }
            set
            {
                if (f_boka < 1.0f)
                {
                    throw new ZlyBok("Nie można ustawić boku mniejszego niż jeden.");
                }
                f_boka = value;
            }
        }

        public float BokB
        {
            get
            {
                return f_bokb;
            }
            set
            {
                if (f_bokb < 1.0f)
                {
                    throw new ZlyBok("Nie można ustawić boku mniejszego niż jeden.");
                }
                f_bokb = value;
            }
        }

        public Prostokat()
        {

        }

        public Prostokat(string nazwa, float boka, float bokb)
        {
            s_nazwa = nazwa;
            f_boka = boka;
            f_bokb = bokb;
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
                Console.WriteLine("Wprowadź bok a: ");
            }
            while (float.TryParse(Console.ReadLine(), out f_boka) == false || f_boka < 1.0f);

            do
            {
                Console.WriteLine("Wprowadź bok b: ");
            }
            while (float.TryParse(Console.ReadLine(), out f_bokb) == false || f_bokb < 1.0f);
        }

        public override float ObliczObwod() => (float)((2.0 * f_boka) + (2.0 * f_bokb));
        public override string WyswietlInformacje() => $"Nazwa obiektu: {s_nazwa} \nObwod wynosi: {ObliczObwod()}";
    }
}
