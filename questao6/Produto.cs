using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao6
{
    public class Produto
    {
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public double Desconto { get; set; }

        public double Total()
        {
            return (Quantidade*(Preco-Desconto));
        }
    }
}
