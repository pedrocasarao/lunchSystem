using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchSystem
{
    public   class Kit
    {
        private Drink bebida;
        private Lunch comida;
        private Dessert sobremesa;
        public Kit(Drink umaBebida, Lunch umaComida, Dessert umaSobremesa) {
            sobremesa = umaSobremesa;
            comida = umaComida;
            bebida = umaBebida;
         }

        public decimal precokit(Drink bebida, Lunch comida,Dessert sobremesa) {
            decimal valor = bebida.preco + comida.preco + sobremesa.preco;
            decimal desconto = valor + (decimal)0.5;
            return valor - desconto;
         }

    }
}
