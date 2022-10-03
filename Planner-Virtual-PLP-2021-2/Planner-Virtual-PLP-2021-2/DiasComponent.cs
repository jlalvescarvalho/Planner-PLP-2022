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

        public void displayData(DateTime dataRecebida)
        {
            dataSelecionada = dataRecebida;
            lbdias.Text = dataRecebida.Day + " - " + dataRecebida.ToString("dddd");
            ChangeDayColor(dataRecebida.ToString("dddd"));
            CarregarTarefas();
            CarregarMetas();
        }

        private void DiasComponent_MouseClick(object sender, MouseEventArgs e)
        {
            SeletorForm seletorForm = new SeletorForm(dataSelecionada);
            seletorForm.ShowDialog();
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
                painelDeEventos.Controls.Add(tarefaComponent);
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
                MiniMetaComponent tarefaComponent = new MiniMetaComponent(
                    leitor["id_meta"] + "", leitor["descricao"] + "", leitor["nome_categoria"] + "", leitor["estado_de_conclusao"] + "",
                    leitor["data_de_efetivacao"] + "");
                painelDeEventos.Controls.Add(tarefaComponent);
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
    }
}
