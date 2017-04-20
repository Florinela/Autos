using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automobile
{
    [Flags]
    enum obtiuni:short
    {
        aer_conditionat=1,
        navigatie =2 ,
        cutie_automata=4 
    };
    class Automobil
    {
        string Marca { set; get; }
        string Model { set; get; }
        int AnFabricatie { set; get; }
        double Pret { set; get; }

        public Automobil (string _marca, string model, int _an, double pret)
        {
            Marca = _marca;
            Model = model;
            AnFabricatie = _an;
            Pret = pret;
        }
        public string ConversieLaSir()
        {
            string s=null;
            s +="Marca:" +Marca +" model: "+Model+" Anul Fabricatiei: "+AnFabricatie+" Pret: "+Pret;
            return s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Automobil a = new Automobil("Range Rover", "Evoque facelift", 2016, 36.792);
            var obt = obtiuni.aer_conditionat | obtiuni.cutie_automata | obtiuni.navigatie;
            Console.WriteLine(a.ConversieLaSir());
            Console.WriteLine(obt);
            Console.ReadKey();
            Automobil a1 = new Automobil("Range Rover", "Sport", 2015, 37.76);
            Console.WriteLine(a1.ConversieLaSir());
            Console.ReadKey();

        }
    }
}
