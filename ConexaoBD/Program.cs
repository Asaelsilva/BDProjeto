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
            
            SqlConnection conexao = new SqlConnection(@"data source=DESKTOP-O34D68D\SQLEXPRESS; Integrated Security=SSPI; Initial Catalog=ExemploBD");
            conexao.Open();

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


            //while (dadosSelect.Read())
            //{
            //    Console.WriteLine("Id:{0}, Nome:{1}, Cargo:{2}, Data:{3}", dadosSelect["usuarioId"], dadosSelect["nome"], dadosSelect["cargo"], dadosSelect["date"]);
            //}
            //Console.ReadLine();

        }
    }
}
