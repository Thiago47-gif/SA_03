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
    public partial class JanelaVeterinario : Form
    {
        List<Veterinario> veterinario;
        public JanelaVeterinario()
        {
            InitializeComponent();
            veterinario = new List<Veterinario>();
        }

        private void JanelaVeterinario_Load(object sender, EventArgs e)
        {

        }

        private void JanelaVeterinario_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0) //Se na aplicação existir zero formulario abesto
            {
                Application.Exit(); //Sair da aplicação
            }
            else //Se não
            {
                foreach (Form formAberto in Application.OpenForms) //Cada formulario que estiver aberto
                {
                    if (formAberto is Form1)
                        formAberto.Show(); //Mostrar formulario
                    break; //Parar
                }
            }

        }

        private void cadastrar_Veterinario_Click(object sender, EventArgs e)
        {
            int index = -1;

            foreach (Veterinario v in veterinario)
            {
                if (v.NomeVeterinario == nome_Veterinario.Text)
                {
                    index = veterinario.IndexOf(v);
                }
            }

            if (nome_Veterinario.Text == "") //Mensagem de campo vazio
            {
                MessageBox.Show("Preencha o campo nome.");
                nome_Veterinario.Focus();
                return;
            }
            if (cpf_Veterinario.Text == "") //Mensagem de campo vazio
            {
                MessageBox.Show("Preencha o campo CPF.");
                cpf_Veterinario.Focus();
                return;
            }
            if (id_Veterinario.Text == "") //Mensagem de campo vazio
            {
                MessageBox.Show("Preencha o campo ID.");
                id_Veterinario.Focus();
                return;
            }

            char sexo;

            if (masculino_Veterinario.Checked)
            {
                sexo = 'M';
            }
            else if (feminino_Veterinario.Checked)
            {
                sexo = 'F';
            }
            else
            {
                sexo = 'O';
            }

            Veterinario V = new Veterinario();
            V.NomeVeterinario = nome_Veterinario.Text;
            V.CPF = cpf_Veterinario.Text;
            V.Especializacao = especializacao_Veterinario.Text;
            V.IdVeterinario = id_Veterinario.Text;
            V.NascimentoVeterinario = nascimento_Veterinario.Text;
            V.TelefoneVeterinario = telefoneVeterinario.Text;
            V.EnderecoVeterinario = endereco_Veterinario.Text;
            V.CidadeVeterinario = cidade_Veterinario.Text;
            V.EstadoVeterinario = estado_Veterinario.Text;
            V.CEPVeterinario = cep_Veterinario.Text;
            V.EmailVeterinario = email_Veterinario.Text;
            V.SexoVeterinario = sexo;

            if (index < 0)
            {
                veterinario.Add(V);
            }
            else
            {
                veterinario[index] = V;
            }

            botaoLimpar_Veterinario_Click(botaoLimpar_Veterinario, EventArgs.Empty);

            Listar();
        }
         
        private void botaoLimpar_Veterinario_Click(object sender, EventArgs e)
        {

        }

        private void botaoExcluir_Veterinario_Click(object sender, EventArgs e)
        {

        }

        private void Listar()
        {
            lista.Items.Clear();

            foreach (Veterinario v in veterinario)
            {
                lista.Items.Add(v.NomeVeterinario);
            }
        }
    }
}
