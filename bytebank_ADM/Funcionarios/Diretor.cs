using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor : Funcionario //diretor herda de funcionario
    {
        public override double GetBonificacao() //esse metodo é uma redefinição do q foi escrito classe funcion
        {
            return this.Salario + base.GetBonificacao(); //base me da acesso aos elementos cs funcionario
        }
    }
}
