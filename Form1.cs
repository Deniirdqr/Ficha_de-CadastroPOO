using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Discurssiva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Clicar no botão sexo
        private void cmbSexo_Click(object sender, EventArgs e)
        {
            cmbSexo.DataSource = Enum.GetNames(typeof(Jovem.Sexo));
        }

        //Clicar no botão trabalho
        private void cmbOcupacao_Click(object sender, EventArgs e)
        {
            cmbOcupacao.DataSource = Enum.GetNames(typeof(Jovem.Trabalha));
        }

        //clicar no botão de salvar
        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (textId.Text.Length == 0)
            {
                Identificacao j = new Identificacao(
                    textNome.Text,
                    int.Parse(textCPF.Text),
                    int.Parse(textIdade.Text),
                    (Jovem.Sexo)cmbSexo.SelectedIndex,
                    (Jovem.Trabalha)cmbOcupacao.SelectedIndex
                    );
                j.Incluir();
                MessageBox.Show("Dados cadastrados com sucesso.", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                Identificacao j = new Identificacao(
                int.Parse(textId.Text),
                textNome.Text,
                int.Parse(textCPF.Text),
                int.Parse(textIdade.Text),
                (Jovem.Sexo)cmbSexo.SelectedIndex,
                (Jovem.Trabalha)cmbOcupacao.SelectedIndex
                );
                j.Alterar();
                MessageBox.Show("Dados alterados com sucesso.", "Aviso", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            PreencherGrid(Identificacao.Consultar());
            LimparTela();
        }

        //Ao carregar o o form1
        private void Form1_Load(object sender, EventArgs e)
        {
            PreencherGrid(Identificacao.Consultar());
            LimparTela();
        }

        //compando de limpar tela
        private void LimparTela()
        {
            textId.Text = "";
            textNome.Text = "";
            textCPF.Text = "";
            textIdade.Text = "";
            cmbSexo.SelectedIndex = 0;
            cmbOcupacao.SelectedIndex = 0;
        }

        //comando de busca do CPF
        private void busca_Click(object sender, EventArgs e)
        {
            PreencherGrid(Identificacao.Consultar(int.Parse(textCPF.Text)));
        }


        //comando de duplo click na lista
        private void dataGridList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int cpf;
            cpf = (int)dataGridList["cpf", e.RowIndex].Value;
            Identificacao c = new Identificacao(cpf);
            textCPF.Text = c.Cpf.ToString();
            textNome.Text = c.Nome;
            textIdade.Text = c.Idade.ToString();
            cmbSexo.SelectedIndex = (int)c.SexO;
            cmbOcupacao.SelectedIndex = (int)c.Trabalho;
        }

        //comando de preencher grid list
        private void PreencherGrid(List<Identificacao> Lista)
        {
            dataGridList.DataSource = new BindingList<Identificacao>(Lista);
        }

        
        private void btpreencher_Click(object sender, EventArgs e)
        {
            Identificacao.Preencher();
            PreencherGrid(Identificacao.Consultar());
        }

        //comando de excluir
        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (textCPF.Text.Length != 0)
            {
                Identificacao.Excluir(int.Parse(textCPF.Text));
                MessageBox.Show("Dados excluídos com sucesso.", "Aviso", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                PreencherGrid(Identificacao.Consultar());
                LimparTela();
            }
            else
            {
                MessageBox.Show("Para esta ação é necessário a escolha de um registro primeiro.",
                    "Aviso", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
        }
    }
}
