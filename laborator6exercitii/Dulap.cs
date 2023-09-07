using System;
using System.Collections.Generic;
using System.Text;

namespace laborator6exercitii
{
    /*Ex 1
        Un dulap are trei caracteristici : lungime, latime, inaltime. Dulapul va avea o 
        metoda care va calcula volumul acestuia. 
        Folositi o clasa care va modela un dulap. 
         Clasa va avea trei campuri private intregi: lungime, latime, inaltime.
         Cele trei campuri vor fi initializate cu ajutorul constructorului
         Scrieti o metoda care va calcula volumul dulapului pe baza celor trei campuri.
        Instantiati un dulap in functia Main, apelati metoda de calcul a volumului si
        afisati rezultatul*/
    class Dulap
    {
        private int lungime ;
        private int latime;
        private int inaltime;

    public Dulap(int lungime, int latime, int inaltime)
    {
        this.lungime = lungime;
        this.latime = latime;
        this.inaltime = inaltime;
    }

        public int GetVolumDulap()
        {
            int volum = lungime * latime * inaltime;
            return volum;
        }
    }
}
