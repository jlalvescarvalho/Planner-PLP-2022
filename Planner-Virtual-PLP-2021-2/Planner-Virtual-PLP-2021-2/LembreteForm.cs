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
    public partial class LembreteForm : Form
    {
        String connString = "SERVER=localhost; DATABASE=db_planner; UID=dotnet; PASSWORD=dotnet123#; SSLMODE=none";
        String id_tarefa;
        public LembreteForm(String id_tarefa)
        {
            InitializeComponent();
            this.id_tarefa = id_tarefa;

            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tarefa WHERE id_tarefa = " + id_tarefa, conn);
            MySqlDataReader leitor = cmd.ExecuteReader();
            while (leitor.Read())
            {
                pickDataTarefa.Value = Convert.ToDateTime(leitor["data_de_inicio"]);
                pickHorarioTarefa.Value = Convert.ToDateTime(leitor["data_de_inicio"]);
            }
            leitor.Close();
            conn.Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            SalvarLembrete();
        }

        private void SalvarLembrete()
        {
            if(pickDataLembrete.Value.CompareTo(pickDataTarefa.Value) > 0)
            {
                MessageBox.Show("ERRO: FutureDataException.\n\n" +
                    "Um erro ocoreu durante a inserção de dados, coloque " +
                    "uma data anterior à tarefa para este lembrete ser ativado.",
                    "Você tem uma máquina do futuro?.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (pickDataLembrete.Value.Year.CompareTo(DateTime.Now.Year) == 0 &
                pickDataLembrete.Value.Month.CompareTo(DateTime.Now.Month) == 0 &
                pickDataLembrete.Value.Day.CompareTo(DateTime.Now.Day) == 0 &
                ((pickDataLembrete.Value.Hour.CompareTo(DateTime.Now.Hour) < 0) ||
                (pickDataLembrete.Value.Hour.CompareTo(DateTime.Now.Hour) == 0 &
                pickDataLembrete.Value.Minute.CompareTo(DateTime.Now.Minute) < 0)))
            {
                MessageBox.Show("ERRO: InvalidDataException.\n\n" +
                    "Um erro ocoreu durante a inserção de dados, coloque " +
                    "uma data posterior à hoje para salvar um lembrete.",
                    "Deu ruim.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (pickDataLembrete.Value.Year == pickDataTarefa.Value.Year &
                pickDataLembrete.Value.Month == pickDataTarefa.Value.Month &
                pickDataLembrete.Value.Day == pickDataTarefa.Value.Day)
            {
                MessageBox.Show("ERRO: InvalidDataException.\n\n" +
                    "Um erro ocoreu durante a inserção de dados, coloque " +
                    "uma data anterior à tarefa para este lembrete ser ativado.",
                    "Quer marcar um lembrete em cima da hora?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txMensagem.Text.Equals(""))
            {
                MessageBox.Show("ERRO: EmptyFieldException.\n\n" +
                    "Um erro ocoreu durante a inserção de dados, " +
                    "verifique se todos os campos foram inseridos corretamente.",
                    "Deu ruim.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String dataEHoraLembrete = pickDataLembrete.Value.ToString("yyyy-MM-dd") + "T" + pickHoraLembrete.Value.ToString("HH:mm"); //"2017-06-01T08:30"
            
            try
            {
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                String inserirLembrete = "INSERT INTO lembrete (mensagem, id_tarefa_lembrada, data_do_lembrete)" +
                    "VALUES ('" + txMensagem.Text + "', " + id_tarefa + ", '" + dataEHoraLembrete + "')";
                MySqlCommand cmd = new MySqlCommand(inserirLembrete, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Lembrete salvo!", "Os dados foram salvos corretamente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex + "\n\nUm erro ocoreu durante a inserção de dados, " +
                    "verifique se todos os campos foram inseridos corretamente.");
            }
        }
    }
}
