﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewScreenFinance
{
    public partial class Lancamento : Form
    {
        public Lancamento()
        {
            InitializeComponent();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Lancamento_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Lancamento lancamento = new Lancamento();
            lancamento.WindowState = FormWindowState.Minimized;
        }
    }
}
