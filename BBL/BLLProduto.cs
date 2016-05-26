using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLProduto
    {
        private DALConexao conexao;
        public BLLProduto(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloProduto obj)
        {
            if (obj.ProNome.Trim().Length == 0)
            {
                throw new Exception("O nome do animal é obrigatório");
            }

            if (obj.ProDescricao.Trim().Length == 0)
            {
                throw new Exception("A descrição sobre o animal é obrigatória");
            }
    
          
            DALProduto DALobj = new DALProduto(conexao);
            DALobj.Incluir(obj);
        }
        public void Excluir(int codigo)
        {
            DALProduto DALobj = new DALProduto(conexao);
            DALobj.Excluir(codigo);
        }
        public void Alterar(ModeloProduto obj)
        {
            if (obj.ProNome.Trim().Length == 0)
            {
                throw new Exception("O nome do animal é obrigatório");
            }

            if (obj.ProDescricao.Trim().Length == 0)
            {
                throw new Exception("A descrição sobre o animal é obrigatória");
            }

            if (obj.ProCod <= 0)
            {
                throw new Exception("O código do animal é obrigatório");
            }

            DALProduto DALobj = new DALProduto(conexao);
            DALobj.Alterar(obj);
        }
        public DataTable Localizar(String valor)
        {
            DALProduto DALobj = new DALProduto(conexao);
            return DALobj.Localizar(valor);
        }
        public ModeloProduto CarregaModeloProduto(int codigo)
        {
            DALProduto DALobj = new DALProduto(conexao);
            return DALobj.CarregaModeloProduto(codigo);
        }
    }
}
