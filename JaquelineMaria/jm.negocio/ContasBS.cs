using jm.dados;
using jm.entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jm.negocio
{
    public class ContasBS
    {
        public static ContasBS New() { return new ContasBS(); }
        public List<Contas> ListarContas () {return ContasDS.New().ListarContas();}
    }
}

