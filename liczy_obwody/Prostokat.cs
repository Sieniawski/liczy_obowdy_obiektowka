using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liczy_obwody
{
    public class ZlaNazwaProstokat : Exception
    {
        public ZlaNazwaProstokat(string Message) : base(Message)
        { }
    }

    public class ZlyBokA : Exception
    {
        public ZlyBokA(string Message) : base(Message)
        { }
    }
    public class ZlyBokB : Exception
    {
        public ZlyBokB(string Message) : base(Message)
        { }
    }
    class Prostokat : Ksztalt
    {
        //Pola
        private string s_nazwa = "";
        private float f_boka = 0.0f;
        private float f_bokb = 0.0f;
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
        public float F_boka
        {
            get
            {
                return f_boka;
            }
            set
            {
                F_boka = value;
            }
        }
        public float F_bokb
        {
            get
            {
                return f_bokb;
            }
            set
            {
                F_bokb = value;
            }
        }

        public Prostokat(int iRokProdukcji, float fMarza, float fCenaZakupu)
        {
            if (f_boka < 1)
            {
                throw new ZlyPromien($"Podaj dobry promien wiekszy od 1!");
            }
            if (f_bokb < 1)
            {
                throw new ZlyPromien($"Podaj dobry promien wiekszy od 1!");
            }
            if (string.IsNullOrEmpty(s_nazwa))
            {
                throw new ZlaNazwaProstokat($"String jest pusty, wprowadz nazwe!");
            }
        }

        public override void WyswietlInformacje()
        {
            throw new NotImplementedException();
        }

        public override void WprowadzDane()
        {
            throw new NotImplementedException();
        }

        public override float ObliczObwod()
        {
            throw new NotImplementedException();
        }
    }
}
