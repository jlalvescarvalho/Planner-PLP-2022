using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Planner_Virtual_PLP_2021_2
{
    public partial class SeletorForm : Form
    {
        String connString = "SERVER=localhost; DATABASE=db_planner; UID=dotnet; PASSWORD=dotnet123#; SSLMODE=none";
        DateTime dataPassada;
        bool isParaAtualizarTarefa = false, isParaAtualizarMeta = false, isParaAtualizarLembrete = false;
        String tipo, id, operacao; //alt (alterar dados), rem (remover dados), con (concluir atividade)

        //Construtor para as Opções de Seleção (da Data para Cadastro de Algum Evento)
        public SeletorForm(DateTime dataEscolhida)
        {
            dataPassada = dataEscolhida;
            InitializeComponent();
        }

        public SeletorForm(String tipo, String id)
        {
            InitializeComponent();
            this.tipo = tipo;
            this.id = id;
            switch (tipo)
            {
                case "tarefa":
                    BtnToMeta.Text = "Inferir uma conclusão a esta tarefa";
                    BtnToTarefa.Text = "Atualizar dados desta tarefa";
                    BtnToLista.Text = "Remover esta tarefa";
                    isParaAtualizarTarefa = true;
                    Button BtnToLembrete = new Button();
                    this.Controls.Add(BtnToLembrete);
                    BtnToLembrete.Text = "Criar um lembrete para esta tarefa.";
                    BtnToLembrete.Location = new Point(12, 100);
                    BtnToLembrete.Size = new Size(214, 23);
                    BtnToLembrete.Click += new EventHandler(BtnToLembrete_CLick);
                    this.Height += 30;
                    break;

                case "meta":
                    BtnToMeta.Text = "Dar uma conclusão a esta meta";
                    BtnToTarefa.Text = "Atualizar dados desta meta";
                    BtnToLista.Text = "Remover esta meta";
                    isParaAtualizarMeta = true;
                    break;

                case "lembrete":
                    BtnToLista.Text = "Remover este lembrete";
                    isParaAtualizarLembrete = true;
                    BtnToTarefa.Hide();
                    BtnToMeta.Hide();
                    BtnToLista.Location = new Point(12, 10);
                    this.Height -= 60;
                    break;
            }
        }
        
        private void BtnToLembrete_CLick(object sender, EventArgs e)
        {
            LembreteForm lembreteForm = new LembreteForm(id);
            lembreteForm.ShowDialog();
            this.Close();
        }

        private void BtnToMeta_Click(object sender, EventArgs e)
        {
            if (isParaAtualizarMeta == true)
            {
                ClearForm clearForm = new ClearForm(id, tipo);
                clearForm.ShowDialog();
            }
            else if (isParaAtualizarTarefa == true)
            {
                ClearForm clearForm = new ClearForm(id, tipo);
                clearForm.ShowDialog();
            }
            else if(isParaAtualizarLembrete == false & isParaAtualizarMeta == false & isParaAtualizarTarefa == false)
            {
                MetaForm metaForm = new MetaForm(dataPassada);
                metaForm.ShowDialog();
            }
            operacao = "alt";
            this.Close();
        }

        private void BtnToTarefa_Click(object sender, EventArgs e)
        {
            if (isParaAtualizarMeta)
            {
                MetaForm metaForm = new MetaForm(id);
                metaForm.ShowDialog();
            }
            else if (isParaAtualizarTarefa)
            {
                TarefaForm tarefaForm = new TarefaForm(id);
                tarefaForm.ShowDialog();
            }
            else if (isParaAtualizarLembrete == false & isParaAtualizarMeta == false & isParaAtualizarTarefa == false)
            {
                TarefaForm tarefaForm = new TarefaForm(dataPassada);
                tarefaForm.ShowDialog();
            }
            operacao = "alt";
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnToLista_Click(object sender, EventArgs e)
        {
            if (isParaAtualizarMeta == true)
            {
                RemoverEvento();
            }
            else if (isParaAtualizarTarefa == true)
            {
                RemoverEvento();
            }
            else if (isParaAtualizarLembrete == true)
            {
                RemoverEvento();
            }
            else if (isParaAtualizarLembrete == false & isParaAtualizarMeta == false & isParaAtualizarTarefa == false)
            {
                ListaForm listaForm = new ListaForm(dataPassada);
                listaForm.ShowDialog();
            }
            this.Close();
        }

        public string Operacao
        {
            get { return operacao; }
        }

        public void disableMetaButton()
        {
            BtnToMeta.Enabled = false;
        }

        private void RemoverEvento()
        {
            DialogResult dialogResult = MessageBox.Show("Se este evento for uma tarefa, " +
                "todos os seus lembretes também serão removidos do sistema.",
                "Deseja remover este evento?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if(tipo == "tarefa")
                {
                    MySqlConnection novaConexao = new MySqlConnection(connString);
                    novaConexao.Open();
                    string deletarEmCascata = "DELETE FROM lembrete WHERE id_tarefa_lembrada = " + id;
                    MySqlCommand comando = new MySqlCommand(deletarEmCascata, novaConexao);
                    comando.ExecuteNonQuery();
                    novaConexao.Close();
                }

                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                string carregarEvento = "DELETE FROM " + tipo + " WHERE id" + "_" + tipo + " = " + id;
                MySqlCommand cmd = new MySqlCommand(carregarEvento, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                switch (tipo)
                {
                    case "tarefa":
                        MessageBox.Show("Tarefa removida com sucesso!","Remoção concluída!");
                        break;
                    case "meta":
                        MessageBox.Show("Meta removida com sucesso!", "Remoção concluída!");
                        break;
                    case "lembrete":
                        MessageBox.Show("Lembrete removido com sucesso!", "Remoção concluída!");
                        break;
                }
                operacao = "rem";
                this.Close();
            }
        }
    }
}
