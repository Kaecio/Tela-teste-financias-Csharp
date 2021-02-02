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

            grvLancamento.Rows.Add(9);
            grvLancamento.Rows[0].Cells[0].Value = "Almoço";
            grvLancamento.Rows[0].Cells[1].Value = "Conta Inicial";
            grvLancamento.Rows[0].Cells[2].Value = "-180,00";

            grvLancamento.Rows.Add(9);
            grvLancamento.Rows[1].Cells[0].Value = "Transporte";
            grvLancamento.Rows[1].Cells[1].Value = "Conta Inicial";
            grvLancamento.Rows[1].Cells[2].Value = "-550,00";

            grvLancamento.Rows.Add(9);
            grvLancamento.Rows[2].Cells[0].Value = "Venda";
            grvLancamento.Rows[2].Cells[1].Value = "Conta Inicial";
            grvLancamento.Rows[2].Cells[2].Value = "9840,00";

            grvLancamento.Rows.Add(9);
            grvLancamento.Rows[3].Cells[0].Value = "Pg serv. terc";
            grvLancamento.Rows[3].Cells[1].Value = "Conta Inicial";
            grvLancamento.Rows[3].Cells[2].Value = "-700,00";

            grvLancamento.Rows.Add(9);
            grvLancamento.Rows[4].Cells[0].Value = "Aluguel de máquina";
            grvLancamento.Rows[4].Cells[1].Value = "Conta Inicial";
            grvLancamento.Rows[4].Cells[2].Value = "-1000,00";

            grvLancamento.Rows.Add(9);
            grvLancamento.Rows[5].Cells[0].Value = "Depósito";
            grvLancamento.Rows[5].Cells[1].Value = "Conta Inicial";
            grvLancamento.Rows[5].Cells[2].Value = "5500,00";

            grvLancamento.Rows.Add(9);
            grvLancamento.Rows[6].Cells[0].Value = "Telefone";
            grvLancamento.Rows[6].Cells[1].Value = "Conta Inicial";
            grvLancamento.Rows[6].Cells[2].Value = "-170,00";

            grvLancamento.Rows.Add(9);
            grvLancamento.Rows[7].Cells[0].Value = "Água";
            grvLancamento.Rows[7].Cells[1].Value = "Conta Inicial";
            grvLancamento.Rows[7].Cells[2].Value = "-180,00";

            grvLancamento.Rows.Add(9);
            grvLancamento.Rows[7].Cells[0].Value = "Lux";
            grvLancamento.Rows[7].Cells[1].Value = "Conta Inicial";
            grvLancamento.Rows[7].Cells[2].Value = "-205,00";

            grvLancamento.Rows.Add(9);
            grvLancamento.Rows[8].Cells[0].Value = "Venda";
            grvLancamento.Rows[8].Cells[1].Value = "Conta Inicial";
            grvLancamento.Rows[8].Cells[2].Value = "-100,00";

        }

       
        private void guna2TextBox1_Click(object sender, EventArgs e)
        {
            fltBuscaFinancas.Text="";
        }

        private void fltBuscaFinancas_MouseClick(object sender, MouseEventArgs e)
        {
            fltBuscaFinancas.Text = "";
        }
        private void cbxCartoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxCartoes.SelectedItem = "Cartões";
        }
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Form2 cadastro = new Form2();
            cadastro.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 lancamento = new Form2();
            lancamento.ShowDialog();
        }
    }
}
