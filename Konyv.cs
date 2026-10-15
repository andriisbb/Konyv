using System;
using System.Collections.Generic;
using System.Text;

namespace Konyv
{
    public class Konyv
    {
        private int ar;
        private int raktarKeszlet;
        private static int osszesRegisztraltKonyv = 0;
        public string Azonosito { get; set; }
        public string Cim { get; set; }
        public string Szerzo { get; set; }
        public int Ar
        {
            get { return Ar; }
            set
            {
                if (value < 0)
                {
                    Ar = 0;
                }
                else
                {
                    Ar = value;
                }
            }
        }
        public int RaktarKeszlet
        {
            get { return raktarKeszlet; }
            set
            {
                if (value < 0)
                {
                    raktarKeszlet = 0;
                }
                else
                {
                    raktarKeszlet = value;
                }
            }
        }
        public static int OsszesRegisztraltKonyv
        {
            get => osszesRegisztraltKonyv;
        }
        public Konyv (string azonosito, string cim, string szerzo, int ar):this(azonosito, cim, szerzo, ar, 1)
        {

        }
        public Konyv(string azonosito, string cim, string szerzo, int ar, int raktarKeszlet)
        {
            Azonosito = azonosito;
            Cim = cim;
            Szerzo = szerzo;
            Ar = ar;
            osszesRegisztraltKonyv++;

        }
        public override string ToString()
        {
            return $"{Azonosito} Szerzo: {Szerzo} {Cim} - {Ar} Ft | Készlet: {RaktarKeszlet} db";
        }
        public int TeljesErtek()
        {
            return Ar* RaktarKeszlet;
        }

    }
}
