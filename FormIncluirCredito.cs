using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CreditoCliente
{
    public partial class FormIncluirCredito : Form
    {
        int INITIAL_HEIGTH = 360;
        public FormIncluirCredito()
        {
            InitializeComponent();
        }

        private void FormIncluirCredito_Load(object sender, EventArgs e)
        {
            textBoxUsuarioId.Select();
            this.Height = INITIAL_HEIGTH;
        }

        private void checkBoxCaixa_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            showHideGroupBox(cb, groupBoxCaixa);           
        }

        private void showHideGroupBox(CheckBox cb, GroupBox gb)
        {            
            if (cb.Checked)
            {
                this.Height = 650;
                gb.Visible = true;
            }
            else
            {
                if (!checkBoxCaixa.Checked && !checkBoxBanco.Checked)
                {
                    this.Height = INITIAL_HEIGTH;
                }
                gb.Visible = false;
            }

        }

        private void checkBoxBanco_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            showHideGroupBox(cb, groupBoxBanco);
        }
    }
}
