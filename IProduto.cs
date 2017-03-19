using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchSystem
{ 
    public  interface IProduto
    {
        
        int codigo { get; set; }
        string nome { get; set; }
        string descricao { get; set; }
        decimal preco { get; set; }
        void Create(IProduto p);
        void Update(IProduto p);
        void Deletar(IProduto p);
          
    }
}
