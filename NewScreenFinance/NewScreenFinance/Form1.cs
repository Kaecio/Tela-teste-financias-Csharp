using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace NewScreenFinance
{
    public partial class frmFinances : MaterialForm
    {
        public frmFinances()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         

        }
        private void guna2TextBox1_Click(object sender, EventArgs e)
        {
            fltBuscaFinancas.Text="";
        }

        private void fltBuscaFinancas_MouseClick(object sender, MouseEventArgs e)
        {
            fltBuscaFinancas.Text = "";
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Form2 lancamento = new Form2();
            lancamento.ShowDialog();
        }

        private void cbxCartoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxCartoes.SelectedItem = "Cartões";
        }
    }
}
