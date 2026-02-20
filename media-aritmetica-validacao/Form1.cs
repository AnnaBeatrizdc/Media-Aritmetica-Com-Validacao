using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace media_aritmetica_validacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_Calcular_Click(object sender, EventArgs e)
        {
            MediaAritmetica MA = new MediaAritmetica();

            MA.setN1(TB_n1.Text);
            MA.setN2(TB_n2.Text);
            MA.setN3(TB_n3.Text);
            MA.setN4(TB_n4.Text);
            MediaAritmeticaBLL.validaDados(MA);
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            }
            else
            {
                TB_Media.Text = MA.getMediaAritmetica();
                TB_n1.Enabled = false;
                TB_n2.Enabled = false;
                TB_n3.Enabled = false;
                TB_n4.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TB_n1.Clear();
            TB_n2.Clear();
            TB_n3.Clear();
            TB_n4.Clear();
            TB_Media.Clear();
            TB_n1.Enabled = true;
            TB_n2.Enabled = true;
            TB_n3.Enabled = true;
            TB_n4.Enabled = true;
            TB_n1.Focus();
        }


        private void Form1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // propriedade keypreview do form em true
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
    }
}
