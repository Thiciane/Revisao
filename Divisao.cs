using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_apresentacoes
{
    public partial class Divisao : Form
    {
        public Divisao()
        {
            InitializeComponent();
            lb_resultado.Text = String.Empty;
        }

        private void bt_resDivisao_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                double valor1 = Convert.ToDouble(txB_valor1.Text);
                double valor2 = Convert.ToDouble(txB_valor2.Text);

                double resul = valor1 / valor2;

                lb_resultado.Text = resul.ToString();
                //MessageBox.Show(resul.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao dividir!");
            }
        }
    }
}
