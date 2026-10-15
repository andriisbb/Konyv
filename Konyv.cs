using System;
using System.Collections.Generic;
using System.Text;

namespace Konyv
{
    public class Konyvek
    {
        private int ar;
        private int raktarKeszlet;
        private static int osszesRegisztraltKonyv = 0;
        public string Azonosito { get; set; }
        public string Cim { get; set; }
        public string Szerzo { get; set; }
        public int Ar
        {
            get => ar;
            set => ar = value < 0 ? 0 : value;
        }
        public int RaktarKeszlet
        {
            get => raktarKeszlet;
            set => raktarKeszlet = value < 0 ? 0 : value;
        }
        public static int OsszesRegisztraltKonyv
        {
            get => osszesRegisztraltKonyv;
        }
        public Konyvek (string azonosito, string cim, string szerzo, int ar):this(azonosito, cim, szerzo, ar, 1)
        {

        }
        public Konyvek(string azonosito, string cim, string szerzo, int ar, int raktarKeszlet)
        {
            Azonosito = azonosito;
            Cim = cim;
            Szerzo = szerzo;
            Ar = ar;
            RaktarKeszlet = raktarKeszlet;
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
