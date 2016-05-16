using jm.entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using jm.conexao.conexao;
using System.Data;

namespace jm.dados
{
    public class ContasDS
    {
        public static ContasDS New() { return new ContasDS() ; }

        public List<Contas> ListarContas()
        {
            List<Contas> lstContas = null;
            try
            {
                mysql oConexao = new mysql();
                IDataReader reader = oConexao.ExecuteReader("select * from contas");

                while (reader.Read())
                {
                  string steste =  reader["Descricao"].ToString();
                }

                return lstContas;
            }
            catch (Exception ex)
            {
                return null;
                throw;
            }

        }
    }
}
