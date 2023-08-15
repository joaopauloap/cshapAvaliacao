using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao5
{
    public class Funcionario
    {
        public double HorasTrabalhadas { get; set; }
        public double ValorHora { get; set; }

        public double Salario()
        {
            return (HorasTrabalhadas * ValorHora);
        }

        public void MostrarSalario()
        {
            Console.WriteLine($"O salário a ser pago é: R$ {(HorasTrabalhadas*ValorHora).ToString("C")}");
        }
    }
}
