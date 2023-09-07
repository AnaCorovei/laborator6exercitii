using System;

namespace laborator6exercitii
{
    class Program
    {
        /*Ex 1
        Un dulap are trei caracteristici : lungime, latime, inaltime. Dulapul va avea o 
        metoda care va calcula volumul acestuia. 
        Folositi o clasa care va modela un dulap. 
         Clasa va avea trei campuri private intregi: lungime, latime, inaltime.
         Cele trei campuri vor fi initializate cu ajutorul constructorului
         Scrieti o metoda care va calcula volumul dulapului pe baza celor trei campuri.
        Instantiati un dulap in functia Main, apelati metoda de calcul a volumului si
        afisati rezultatul
        */
        static void Main(string[] args)
        {

            Autoturism autoturism = new Autoturism("OPEL", "CJ021345", 1234);
            autoturism.AfisareAutoturism();

            Console.WriteLine("Introduceti lungimea: ");
            int lungime = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti latimea: ");
            int latime = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti inaltimea: ");
            int inaltime = int.Parse(Console.ReadLine());

            Dulap dul = new Dulap(lungime, latime ,inaltime);
            Console.WriteLine($"Volumul dulapului este: {dul.GetVolumDulap()}");          
        }
    }
}


