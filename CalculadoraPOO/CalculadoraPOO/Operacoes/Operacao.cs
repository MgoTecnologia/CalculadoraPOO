using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPOO.Operacoes
{
    public abstract class Operacao
    {
        protected decimal Valor1 { get; set; }
        protected decimal Valor2 { get; set; }

        public Operacao(decimal valor1, decimal valor2)
        {
            Valor1 = valor1;
            Valor2 = valor2;
        }

        public abstract decimal Executar();

        public override string ToString()
        {
            return $"{base.ToString()} Valores: {Valor1}, {Valor2} Resultado: {Executar().ToString()}";
        }
    }
}
