﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDiseno;

namespace DiseñoTipoTransferencia
{
    public partial class IngresoTipoTransferencia : Form
    {
        Navegador nv = new Navegador();
        public IngresoTipoTransferencia(DataGridView dgv)
        {
            InitializeComponent();

            nv.nombreForm(this);
            nv.dgv_datos(dgv);

            nv.ingresarTabla("tbl_tipo_transferencia");
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "1";
        }
    }
}
