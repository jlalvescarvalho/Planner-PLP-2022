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
    public partial class ClearForm : Form
    {
        String connString = "SERVER=localhost; DATABASE=db_planner; UID=dotnet; PASSWORD=dotnet123#; SSLMODE=none";
        String id, tipo;
        public ClearForm(String id, String tipo)
        {
            InitializeComponent();
            this.tipo = tipo;
            this.id = id;
            switch (tipo)
            {
                case "tarefa":
                    comboConcluir.Items.Add("Pendente");
                    comboConcluir.Items.Add("Executada");
                    comboConcluir.Items.Add("Parcialmente Executada");
                    comboConcluir.Items.Add("Adiada");
                    comboConcluir.SelectedIndex = 0;
                    break;

                case "meta":
                    comboConcluir.Items.Add("Pendente");
                    comboConcluir.Items.Add("Atingida com Sucesso");
                    comboConcluir.Items.Add("Parcialmente atingida");
                    comboConcluir.Items.Add("Sem sucesso");
                    comboConcluir.SelectedIndex = 0;
                    break;
            }
            CarregarEvento();
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            SalvarConclusao();
        }

        private void CarregarEvento()
        {
            if(tipo == "tarefa")
            {
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM tarefa WHERE id_tarefa = " + id, conn);
                MySqlDataReader leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    txEstadoAtual.Text = leitor["estado_de_conclusao"] + "";
                }
                leitor.Close();
                conn.Close();
            }

            else if(tipo == "meta")
            {
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM meta WHERE id_meta = " + id, conn);
                MySqlDataReader leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    txEstadoAtual.Text = leitor["estado_de_conclusao"] + "";
                }
                leitor.Close();
                conn.Close();
            }
        }

        public void SalvarConclusao()
        {
            if(tipo == "tarefa")
            {
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                String atualizarTarefa = "UPDATE tarefa SET estado_de_conclusao = '" + comboConcluir.Text.ToLowerInvariant() + "'";
                MySqlCommand cmd = new MySqlCommand(atualizarTarefa, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Tarefa atualizada!", "Dados atualizados com sucesso.");
                this.Close();
            } 

            else if (tipo == "meta")
            {
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                String atualizarTarefa = "UPDATE meta SET estado_de_conclusao = '" + comboConcluir.Text.ToLowerInvariant() + "'";
                MySqlCommand cmd = new MySqlCommand(atualizarTarefa, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Meta atualizada!", "Dados atualizados com sucesso.");
                this.Close();
            }

        }
    }
}
