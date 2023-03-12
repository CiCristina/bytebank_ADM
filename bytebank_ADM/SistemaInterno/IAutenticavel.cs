using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.SistemaInterno
{
    public interface IAutenticavel //na interface defino propriedades e comportamentos q devem ser implementados por cs. Quem assinar essa interface tem obrigação de implementar autenticar e definir propriedade senha
    {
        public string Senha { get; set; }
        public bool Autenticar(string senha);


    }
}
