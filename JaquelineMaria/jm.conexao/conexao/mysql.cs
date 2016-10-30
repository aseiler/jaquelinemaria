using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace jm.conexao.conexao
{
    public class mysql
    {

        private MySqlConnection ConexaoMySql()
        {

            return new MySqlConnection("Server=192.168.1.2;Database=contas_qa;Uid=app;Pwd=xxx;");

        }

        public IDataReader ExecuteReader(string sComando) {
            IDataReader reader = null;
            MySqlCommand oCommand = null;
            try
            {
                oCommand = new MySqlCommand(sComando,ConexaoMySql());
                oCommand.Connection.Open();
                reader = oCommand.ExecuteReader(CommandBehavior.CloseConnection);

                return reader;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally {
                reader = null;
            }
        }
    }
}
