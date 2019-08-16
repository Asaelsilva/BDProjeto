using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConexaoBD
{
    class Program
    {
        static void Main(string[] args)
        {
            var bd = new Bd();
            var usuarioAplicacao = new UsuarioAplicacao();

            //SqlConnection conexao = new SqlConnection(@"data source=; Integrated Security=; Initial Catalog=");
            //conexao.Open();

            Console.WriteLine("Digite o nome do uruario: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o cargo: ");
            string cargo = Console.ReadLine();

            Console.WriteLine("Digite o data: ");
            string data = Console.ReadLine();

            usuarioAplicacao.Insert(nome, cargo, data);

            string strQuerySelect = "SELECT * FROM USUARIOS";
            SqlDataReader dados = bd.ExecutaComandoComRetorno(strQuerySelect);

            while (dados.Read())
            {
                Console.WriteLine("id:{0}, nome:{1}, cargo:{2}, data:{3}", dados["usuarioid"], dados["nome"], dados["cargo"], dados["date"]);
            }
            

            //string strQueryUpdate = "UPDATE usuarios set nome = 'Larissa' WHERE usuarioId = 6";
            //SqlCommand cmdComandoUpdate = new SqlCommand(strQueryUpdate, conexao);
            //cmdComandoUpdate.ExecuteNonQuery();

            //string strQueryDelete = "DELETE FROM usuarios WHERE usuarioId = 9";
            //SqlCommand cmdComandoDelete = new SqlCommand(strQueryDelete, conexao);
            //cmdComandoDelete.ExecuteNonQuery();

            //Console.WriteLine("Digite o nome do uruario: ");
            //string nome = Console.ReadLine();

            //Console.WriteLine("Digite o cargo: ");
            //string cargo = Console.ReadLine();

            //Console.WriteLine("Digite o data: ");
            //string data = Console.ReadLine();

            //string strQueryInsert = string.Format("INSERT INTO usuarios(nome, cargo, date) VALUES('{0}', '{1}', '{2}')", nome, cargo, data);
            //SqlCommand cmdComandoInsert = new SqlCommand(strQueryInsert, conexao);
            //cmdComandoInsert.ExecuteReader();

            //string strQuerySelect = "SELECT * FROM USUARIOS";
            //SqlCommand cmdComandoSelect = new SqlCommand(strQuerySelect, conexao);
            //SqlDataReader dadosSelect = cmdComandoSelect.ExecuteReader();


        }
    }
}
