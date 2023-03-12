using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf {get; private set; }
        public double Salario { get; protected set; } //protected: ele é visivel na classe e nas classes q herdam de funcionario

        public string Senha { get; set; }

        public static int TotalDeFuncionarios { get; private set; } //static propriedade da classe. Como a propriedade é visivel, vou usar private set para bloquear escrita dela

        public abstract double GetBonificacao(); //qualquer classe q herdar de funcionario, pde reescrever esse metodo

        public Funcionario(string cpf, double salario) //vou tornar cpf obrigatorio
        {
            this.Salario = salario;
            this.Cpf = cpf; //propriedade
            TotalDeFuncionarios++; //definindo incremento da propriedade totaldefuncionarios. Como ele ta definindo 2 funcionarios, se na classe diretor n faz isso tb@ tem um motivo do recurso da herança. Oq acontece tb é q sempre que eu crio um objeto q ele herda de outra classe, ele executa o construtor da classe base primeiro, nesse caso funcionario
            //Console.WriteLine("Criando um funcionario");
        }
        public abstract void AumentarSalario();

    }
}

