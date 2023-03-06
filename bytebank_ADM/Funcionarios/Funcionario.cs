using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }

        public virtual double GetBonificacao() //qualquer classe q herdar de funcionario, pde reescrever esse metodo
        {
            return this.Salario * 0.10;
        }
    }
}
