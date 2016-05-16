using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jm.entidade
{
    public class Contas
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public int IdTipo { get; set; }

        public int IdEstado { get; set; }
    }
}
