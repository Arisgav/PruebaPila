using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (Pilatext.SelectedIndex != -1)
            {
                
                Pilatext.Items.RemoveAt(Pilatext.SelectedIndex);
            }
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            
            string linea = $"{Tbnombre.Text} {Tbapellido.Text} - {Tbcargo.Text} - ${Tbsalario.Text}";

            
            Pilatext.Items.Add(linea);

            ///
            Tbnombre.Clear();
            Tbapellido.Clear();
            Tbcargo.Clear();
            Tbsalario.Clear();

            
            Tbnombre.Focus();
        }
    }
}
