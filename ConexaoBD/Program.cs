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

            Console.WriteLine("Digite o nome do uruario: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o cargo: ");
            string cargo = Console.ReadLine();

            Console.WriteLine("Digite o data: ");
            string data = Console.ReadLine();

            Usuarios usuarios = new Usuarios
            {
                Nome = nome,
                Cargo = cargo,
                Data = DateTime.Parse(data)
                
            };

            usuarios.Id = 17;
            new UsuarioAplicacao().Salvar(usuarios);

            string strQuerySelect = "SELECT * FROM usuarios";
            SqlDataReader dados = bd.ExecutaComandoComRetorno(strQuerySelect);

            while (dados.Read())
            {
                Console.WriteLine("id:{0}, nome:{1}, cargo:{2}, data:{3}", dados["usuarioid"], dados["nome"], dados["cargo"], dados["date"]);
            }
        }
    }
}
