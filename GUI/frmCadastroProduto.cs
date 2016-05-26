using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using Modelo;
using GUI;
using DAL;
using System.IO;

namespace GUI
{
    public partial class frmCadastroProduto : GUI.frmModeloDeFormularioDeCadastro
    {
        public string foto = "";
        public frmCadastroProduto()
        {  
            InitializeComponent();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }
        private void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtDescricao.Clear();
            
            this.foto = "";
            pbFoto.Image = null;
        }
        private void frmCadastroProduto_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            //combo da categoria
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            cbRaca.DataSource = bll.Localizar("");
            cbRaca.DisplayMember = "cat_nome";
            cbRaca.ValueMember = "cat_cod";
           
        }
     
    
        private void txtQtde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
           
        }


        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alteraBotoes(2);
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura dos dados
                ModeloProduto modelo = new ModeloProduto();
                modelo.ProNome = txtNome.Text;
                modelo.ProDescricao = txtDescricao.Text;
                
                //obj para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                if (this.operacao == "inserir")
                {
                    //cadastrar uma Produto
                    modelo.CarregaImagem(this.foto);
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.ProCod.ToString());

                }
                else
                {
                    modelo.ProCod = Convert.ToInt32(txtCodigo.Text);  
                    //alterar um produto
                    if ( this.foto == "Foto Original")
                    {
                        ModeloProduto mt = bll.CarregaModeloProduto(modelo.ProCod);
                        modelo.ProFoto = mt.ProFoto;
                    }
                    else
                    {
                        modelo.CarregaImagem(this.foto);
                    }
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado");
                }
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btLoFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.ShowDialog();
            if (!string.IsNullOrEmpty(od.FileName))
            {
                this.foto = od.FileName;
                pbFoto.Load(this.foto);
            }
            
        }

        private void btRmFoto_Click(object sender, EventArgs e)
        {
            this.foto = "";
            pbFoto.Image = null;
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
             frmConsultaProduto f = new frmConsultaProduto();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProduto(f.codigo);
                txtCodigo.Text = modelo.CatCod.ToString();
                //colocar os dados na tela
                txtCodigo.Text = modelo.ProCod.ToString();
                txtDescricao.Text = modelo.ProDescricao;
                txtNome.Text = modelo.ProNome;
                cbRaca.SelectedValue = modelo.CatCod;
                try
                {
                    MemoryStream ms = new MemoryStream(modelo.ProFoto);
                    pbFoto.Image = Image.FromStream(ms);
                    this.foto = "Foto Original";
                }
                catch {}
              
                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();
         
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLProduto bll = new BLLProduto(cx);
                    bll.Excluir(Convert.ToInt32(txtCodigo.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);
                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro. \n O registro esta sendo utilizado em outro local.");
                this.alteraBotoes(3);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            this.LimpaTela();
        }

        private void pnBotoes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btaddCategoria_Click(object sender, EventArgs e)
        {
            frmCadastroCategoria f = new frmCadastroCategoria();
            f.ShowDialog();
            f.Dispose();

            //combo da categoria
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            cbRaca.DataSource = bll.Localizar("");
            cbRaca.DisplayMember = "cat_nome";
            cbRaca.ValueMember = "cat_cod";
                      
        }
             
       
        private void pnDados_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
