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
    public partial class DiasComponent : UserControl
    {
        String connString = "SERVER=localhost; DATABASE=db_planner; UID=dotnet; PASSWORD=dotnet123#; SSLMODE=none";
        DateTime dataSelecionada;

        public DiasComponent()
        {
            InitializeComponent();
        }

        public void CarregarData(DateTime dataRecebida)
        {
            DateTime dataAtual = DateTime.UtcNow;
            dataSelecionada = dataRecebida;
            if(dataAtual.Date == dataRecebida.Date)
            {
                painelCabecalho.BackColor = Color.Aqua; 
            }
            lbdias.Text = dataRecebida.Day + " - " + dataRecebida.ToString("dddd");
            //Caso seja necessário, muda as cores do dia de acordo com o dia da semana
            ChangeDayColor(dataRecebida.ToString("dddd"));
            //Carrega todas as tarefas referentes àquela data
            CarregarDados();
        }

        //Responsável por Desativar a interação com todos os dias passados
        private void SetDisabledDays()
        {
            if(dataSelecionada.CompareTo(DateTime.Now) == -1)
                this.Enabled = false;
        }

        private void DiasComponent_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataSelecionada.Year == DateTime.Now.Year &&
                dataSelecionada.Month == DateTime.Now.Month &&
                dataSelecionada.Day == DateTime.Now.Day)
            {
                DialogResult dialogResult = MessageBox.Show("Você não deveria marcar algo em cima da hora." +
                    "\nTem certeza que deseja marcar algo em para hoje?" +
                    "\n\nSaiba que você não poderá marcar metas para hoje e que suas tarefas " +
                    "correm o risco de serem automaticamente preenchidas pelo sistema como 'adiadas'.", 
                    "Tem certeza que deseja marcar algo em cima da hora?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    SeletorForm seletorForm = new SeletorForm(dataSelecionada);
                    seletorForm.disableMetaButton();
                    seletorForm.ShowDialog();
                    CarregarDados();
                    return;
                }
                return;
            }
                
            if(dataSelecionada.CompareTo(DateTime.Now) == -1)
            {
                MessageBox.Show("Você não pode marcar um evento à uma data antiga!\nPor favor, selecione outra data.",
                    "Acho que você ainda não tem uma máquina do tempo.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            CarregarSeletor();
        }

        private void CarregarSeletor()
        {
            SeletorForm seletorForm = new SeletorForm(dataSelecionada);
            seletorForm.ShowDialog();
            CarregarDados();
        }

        private void CarregarTarefas()
        {
            String dataAPesquisar = dataSelecionada.ToString("yyyy-MM-dd");
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            string carregarEvento = "SELECT * FROM tarefa WHERE DATE(data_de_inicio) = '"+dataAPesquisar+"'";
            MySqlCommand cmd = new MySqlCommand(carregarEvento, conn);
            MySqlDataReader leitor = cmd.ExecuteReader();
            while (leitor.Read())
            {
                MiniTarefaComponent tarefaComponent = new MiniTarefaComponent(
                    leitor["id_tarefa"]+"", leitor["descricao"]+"", leitor["nome_categoria"]+"", leitor["estado_de_conclusao"]+"",
                    leitor["data_de_inicio"]+"", leitor["data_de_finalizacao"]+"");
                if (painelDeEventos.Controls.Count == 0)
                {
                    painelDeEventos.Controls.Add(tarefaComponent);
                }
                else
                {
                    foreach (var elemento in painelDeEventos.Controls.OfType<MiniTarefaComponent>())
                    {
                        if (elemento.Id != tarefaComponent.Id)
                            painelDeEventos.Controls.Add(tarefaComponent);
                    }
                }
            }
            leitor.Close();
            conn.Close();
        }

        private void CarregarMetas()
        {
            String dataAPesquisar = dataSelecionada.ToString("yyyy-MM-dd");
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            string carregarEvento = "SELECT * FROM meta WHERE DATE(data_de_efetivacao) = '" + dataAPesquisar + "'";
            MySqlCommand cmd = new MySqlCommand(carregarEvento, conn);
            MySqlDataReader leitor = cmd.ExecuteReader();
            while (leitor.Read())
            {
                MiniMetaComponent metaComponent = new MiniMetaComponent(
                    leitor["id_meta"] + "", leitor["descricao"] + "", leitor["nome_categoria"] + "", leitor["estado_de_conclusao"] + "",
                    leitor["data_de_efetivacao"] + "");

                if (painelDeEventos.Controls.Count == 0)
                {
                    painelDeEventos.Controls.Add(metaComponent);
                }
                else
                {
                    foreach (var elemento in painelDeEventos.Controls.OfType<MiniMetaComponent>())
                    {
                        if (elemento.Id != metaComponent.Id)
                            painelDeEventos.Controls.Add(metaComponent);
                    }
                }
            }
            leitor.Close();
            conn.Close();
        }

        private void CarregarLembretes()
        {
            String dataAPesquisar = dataSelecionada.ToString("yyyy-MM-dd");
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            string carregarEvento = "SELECT * FROM lembrete WHERE DATE(data_do_lembrete) = '" + dataAPesquisar + "'";
            MySqlCommand cmd = new MySqlCommand(carregarEvento, conn);
            MySqlDataReader leitor = cmd.ExecuteReader();
            while (leitor.Read())
            {
                MiniLembreteComponent lembreteComponent = new MiniLembreteComponent(
                    leitor["id_lembrete"] + "", leitor["mensagem"] + "", leitor["id_tarefa_lembrada"] + "");
                if (painelDeEventos.Controls.Count == 0)
                {
                    painelDeEventos.Controls.Add(lembreteComponent);
                }
                else
                {
                    foreach (var elemento in painelDeEventos.Controls.OfType<MiniLembreteComponent>())
                    {
                        if (elemento.Id != lembreteComponent.Id)
                            painelDeEventos.Controls.Add(lembreteComponent);
                    }
                }
            }
            leitor.Close();
            conn.Close();
        }

        //Procedimento para Mudar as Cores dos Cabeçalhos do Dias em Tela
        private void ChangeDayColor(String dia)
        {
            switch(dia){
                case "domingo":
                    //painelCabecalho.BackColor = Color.Red; //este é um exemplo :)
                    //lbdias.ForeColor = Color.White;
                    break;
                case "segunda-feira":
                    break;
                case "terça-feira":
                    break;
                case "quarta-feira":
                    break;
                case "quinta-feira":
                    break;
                case "sexta-feira":
                    break;
                case "sábado":
                    break;
            }
        }

        private void CarregarDados()
        {
            CarregarTarefas();
            CarregarMetas();
            CarregarLembretes();
        }
    }
}
