using bytebank_ADM.SistemaInterno; //atenção
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {

        public override double GetBonificacao() //esse metodo é uma redefinição do q foi escrito classe funcion
        {
            return this.Salario * 0.5; 
        }

        public Diretor (string cpf):base(cpf,5000) //como alterei em funcionario e ele é padrao, aqui da erro pq aqui ta esperando parametro tb. base me da acesso aos elementos cs funcionario
        {
            //Console.WriteLine("Criando um diretor.");
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }
    }


}

