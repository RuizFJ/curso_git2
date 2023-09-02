using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_de_Message
{
    public partial class Calcular : Form
    {
        public Calcular()
        {
            InitializeComponent();
        }
        Metodo obj = new Metodo();
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            obj.numero1 = Convert.ToInt32(txtNumero1.Text);
            obj.numero2 = Convert.ToInt32(txtNumero2.Text);
            txtResultado.Text = obj.Calcular().ToString();
        }
    }
}
