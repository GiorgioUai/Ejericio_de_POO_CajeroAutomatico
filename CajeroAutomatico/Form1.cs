﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace CajeroAutomatico
{
    public partial class Form1 : Form
    {
        private Cliente mCliente;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            mCliente = new Cliente(txtUsuario.Text);

        }
    }
}
