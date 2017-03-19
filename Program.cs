using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Drink bebida = new Drink();
            Lunch comida = new Lunch();
            Dessert sobremesa = new Dessert();
            
            Console.WriteLine("Digite o  preço do Hamburger: ");
            Console.ReadLine();
            Console.ReadKey();
       
        }
    }
}
