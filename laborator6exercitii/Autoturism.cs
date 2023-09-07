using System;
using System.Collections.Generic;
using System.Text;

namespace laborator6exercitii
{

    /*
    Ex2: 
        Scrieti un program care va modela un autoturism. Un autoturism va avea o 
    marca (string), un numar de inmatriculare (string), precum si o 
    capacitate cilindrica(int). 
    Autoturismul va avea:
     Campurile corespunzatoare caracteristicilor autoturismului.
     Un constructor care va initializa campurile acestuia
     O metoda “Tiparire” care va afisa pe consola descrierea acestuia sub forma : “marca, 
    numarDeInmatriculare, capacitateCilindrica”.
    Folositi: clase, campuri, metode, modificatorii de acces adecvati, comentarii
    xml pentru metodele publice.
    Creeati doua obiecte de tipul autoturism in functia “Main” si apelati-le 
    metodele “Tipareste”
    */
    class Autoturism
    {
        private string marca;
        private string numarInmatriculare;
        private int capacitateCilindrica;


        public Autoturism(string marca, string numarInmatriculare, int capacitateCilindrica)
        {
            this.marca = marca;
            this.numarInmatriculare = numarInmatriculare;
            this.capacitateCilindrica = capacitateCilindrica;
        }

        //public void SetNumarInmatriculare(string numarNou)
        //{
        //    this.numarInmatriculare = numarNou;

        //}
        public void AfisareAutoturism()
        {
            Console.WriteLine($"Autoturismul cu numar de inmatriculare {numarInmatriculare} are marca {marca} si capacitatea cilindica {capacitateCilindrica}");
        }




    }
}
