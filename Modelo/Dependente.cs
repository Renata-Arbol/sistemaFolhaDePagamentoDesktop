using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adicionar_Funcionário.Modelo
{
    public class Dependente
    {
        public string IdDependente { get; set; }
        public string NomeDependente { get; set; }
        public string Grauparentesco { get; set; }

        public Endereco EnderecoDep {  get; set; }
    }
}
