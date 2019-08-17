using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoBD
{
    class UsuarioAplicacao
    {
        private Bd bd;

        private void Inserir(Usuarios usuario)
        {
            var strQuery = "";
            strQuery += "INSERT INTO usuarios(nome, cargo, date)";
            strQuery += string.Format(" VALUES ('{0}', '{1}', '{2}')", usuario.Nome, usuario.Cargo, usuario.Data
                );

            using (bd = new Bd())
            {
                bd.ExecutaComando(strQuery);
            }

        }

        private void Alterar(Usuarios usuarios)
        {
            var strQuery = "";
            strQuery += "UPDATE usuarios SET ";
            strQuery += string.Format("nome = '{0}',", usuarios.Nome);
            strQuery += string.Format("cargo = '{0}',", usuarios.Cargo);
            strQuery += string.Format("date = '{0}' ", usuarios.Data);
            strQuery += string.Format("WHERE usuarioId = {0} ", usuarios.Id);

            using (bd = new Bd())
            {
                bd.ExecutaComando(strQuery);
            }
        }

        public void Salvar(Usuarios usuarios)
        {
            if (usuarios.Id > 0 )
            {
                Alterar(usuarios);
            }
            else
            {
                Inserir(usuarios);
            }
        }


        public void Excluir(int id)
        {
            using(bd =new Bd())
            {
                var strQuery = string.Format(" DELETE FROM usuarios WHERE susuarios = {0}", id);
                bd.ExecutaComando(strQuery);
            }
        }


    }

}
