using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    class DALUnidadeDeMedida
    {
        private DAL.DALConexao conexao;

        public DALUnidadeDeMedida(DAL.DALConexao conexao)
        {
            // TODO: Complete member initialization
            this.conexao = conexao;
        }

        internal void Incluir(Modelo.ModeloUnidadeDeMedida modelo)
        {
            throw new NotImplementedException();
        }

        internal void Alterar(Modelo.ModeloUnidadeDeMedida modelo)
        {
            throw new NotImplementedException();
        }

        internal void Excluir(int codigo)
        {
            throw new NotImplementedException();
        }

        internal System.Data.DataTable Localizar(string valor)
        {
            throw new NotImplementedException();
        }

        internal int VerificaUnidadeDeMedida(string valor)
        {
            throw new NotImplementedException();
        }

        internal Modelo.ModeloUnidadeDeMedida CarregaModeloUnidadeDeMedida(int codigo)
        {
            throw new NotImplementedException();
        }
    }
}
