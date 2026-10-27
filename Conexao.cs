using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Salao_de_Beleza.UserControl
{
    internal class Conexao
    {
        private const string StringConexao =
        "Server=localhost;Port=3306;Database=loja_ceet;" +
        "Uid=root;Pwd=root;";
        /// <summary>Cria e já ABRE uma nova conexão.
        /// Quem chama deve descartá-la com using.</summary>
        public static MySqlConnection ObterConexao()
        {
            var conexao = new MySqlConnection(StringConexao);
            conexao.Open();
            return conexao;
        }

    }
}
