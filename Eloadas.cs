﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EloadasProject {
    public class Eloadas {
        private bool[,] foglalasok;
        public Eloadas(int sorokSzama, int helyekSzama) {
            if(sorokSzama<1 || helyekSzama < 1) {
                throw new ArgumentException("A paramétereknek 0-nál nagyobbnak kell lenniük.");
            }
            foglalasok = new bool[sorokSzama,helyekSzama];
        }
        public bool Lefoglal() {
            bool lefoglalt = false;
            for(int i = 0; i < this.foglalasok.GetLength(0); i++) {
                for (int j = 0; j < this.foglalasok.GetLength(1); j++) {
                    if (this.foglalasok[i, j] == false) {
                        this.foglalasok[i, j] = true;
                        lefoglalt = true;
                        break;
                    }
                }
                if (lefoglalt == true) {
                    break;
                }
            }
            return lefoglalt;
        }
        public int SzabadHelyek {
            get {
                int szabad = 0;
                for (int i = 0; i < this.foglalasok.GetLength(0); i++) {
                    for (int j = 0; j < this.foglalasok.GetLength(1); j++) {
                        if (this.foglalasok[i, j] == false) {
                            szabad++;
                        }
                    }
                }
                return szabad;
            }
        }
        public bool Teli {
            get {
                return SzabadHelyek==0;
            }
        }
        public bool Foglalt(int sorSzam, int helySzam) {
            if (sorSzam < 1 || helySzam < 1) {
                throw new ArgumentException("A paramétereknek 0-nál nagyobbnak kell lenniük.");
            }
            return foglalasok[sorSzam-1, helySzam-1];
        }
    }
}
