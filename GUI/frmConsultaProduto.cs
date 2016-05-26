using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmConsultaProduto : Form
    {
        public int codigo = 0;
        public frmConsultaProduto()
        {
            InitializeComponent();
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLProduto bll = new BLLProduto(cx);
            dgvDados.DataSource = bll.Localizar(txtValor.Text);
        }

        private void frmConsultaProduto_Load(object sender, EventArgs e)
        {
             btLocalizar_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Código";
               //dgvDados.Columns[0].HeaderText = "Código";
               dgvDados.Columns[0].Width = 50;
               dgvDados.Columns[1].HeaderText = "Produto";
               dgvDados.Columns[1].Width = 150;
               dgvDados.Columns[2].HeaderText = "Descrição";
               dgvDados.Columns[2].Width = 200;
               dgvDados.Columns[3].HeaderText = "Foto";
               dgvDados.Columns[3].Width = 50;
               dgvDados.Columns[4].HeaderText = "Raça";
               dgvDados.Columns[4].Width = 50;
              // dgvDados.Columns[5].HeaderText = "Raça";
               //dgvDados.Columns[5].Width = 100;


            //oculta colunas
            dgvDados.Columns["pro_foto"].Visible = false;
              
               dgvDados.Columns["cat_cod"].Visible = false;
               

           

        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
