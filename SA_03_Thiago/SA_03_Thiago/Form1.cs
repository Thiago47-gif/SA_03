using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA_03_Thiago
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastroVeterinario_Click(object sender, EventArgs e) // Click em Cadastro Veterinario
        {
            JanelaVeterinario TelaV = new JanelaVeterinario(); //Instanciar Janela de cadastro do veterinario
            TelaV.Show(); //Mostrar tela de cadastro do veterinario
            this.Hide(); //Ocultar janela anterior
        }

        private void sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
