using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPOO.Operacoes
{
    public class Soma : Operacao
    {
        public Soma(decimal valor1, decimal valor2) : base(valor1, valor2)
        {
        }

        public override decimal Executar()
        {
            return Valor1 + Valor2;
        }
    }
}
