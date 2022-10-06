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
    public partial class MiniLembreteComponent : UserControl
    {
        String connString = "SERVER=localhost; DATABASE=db_planner; UID=dotnet; PASSWORD=dotnet123#; SSLMODE=none";
        String id_lembrete, id_tarefa;
        public MiniLembreteComponent(String id_lembrete, String mensagem, String id_tarefa_lembrada)
        {
            InitializeComponent();
            lbLembrete.Text += " " + id_lembrete;
            this.id_tarefa = id_tarefa_lembrada;
            this.id_lembrete = id_lembrete;
            lbMensagem.Text = lbMensagem.Text + " " + mensagem;
            UpdateDataTarefa();
            painelCabecalho.BackColor = Color.Black;
            painelCabecalho.ForeColor = Color.White;
        }

        public String Id
        {
            get { return id_lembrete; }
        }

        private void ClickOnLembrete(object sender, EventArgs e)
        {
            SeletorForm seletorForm = new SeletorForm("lembrete", id_lembrete);
            seletorForm.ShowDialog();
            //Remoção do Componente
            if (seletorForm.Operacao == "rem")
                this.DestroyHandle();
            //Atualização do Componente
            else if (seletorForm.Operacao == "alt")
            {
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM lembrete WHERE id_lembrete = " + id_lembrete, conn);
                MySqlDataReader leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    lbMensagem.Text = lbMensagem.Text.ToString().Substring(0, 10) + " " + leitor["mensagem"] + "";
                    id_tarefa = leitor["id_tarefa_lembrada"] + "";
                }
                leitor.Close();
                conn.Close();
                UpdateDataTarefa();
            }
        }

        private void UpdateDataTarefa()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT data_de_inicio FROM tarefa WHERE id_tarefa = " + id_tarefa, conn);
            MySqlDataReader leitor = cmd.ExecuteReader();
            while (leitor.Read())
            {
                lbDataTarefa.Text = lbDataTarefa.Text.ToString().Substring(0,26) + leitor["data_de_inicio"].ToString().Substring(0, 10);
            }
            leitor.Close();
            conn.Close();
        }
    }
}
