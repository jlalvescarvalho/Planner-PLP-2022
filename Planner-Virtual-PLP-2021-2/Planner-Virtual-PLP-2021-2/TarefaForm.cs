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
    public partial class TarefaForm : Form
    {
        String connString = "SERVER=localhost; DATABASE=db_planner; UID=dotnet; PASSWORD=dotnet123#; SSLMODE=none";
        String dataEHoraInicio;
        String dataEHoraFinal;
        public TarefaForm(DateTime dataEscolhida)
        {
            dataEHoraInicio = dataEscolhida.ToString("yyyy-MM-dd");
            InitializeComponent();
            CarregarComboBox();
            txDataInicio.Text = dataEscolhida.ToString("dd/MM/yyyy");
            pickDataFinal.Text = dataEscolhida.ToString("dd/MM/yyyy");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txDescricao.Text.Equals(""))
            {
                MessageBox.Show("ERRO: EmptyFieldException.\n\nUm erro ocoreu durante a inserção de dados, " +
                    "verifique se todos os campos foram inseridos corretamente.");
                return;
            }
            DateTime horaInicial = Convert.ToDateTime(pickHoraInicio.Value);
            DateTime dataFinal = Convert.ToDateTime(pickDataFinal.Value);
            DateTime horaFinal = Convert.ToDateTime(pickHorarioFinal.Value);
            dataEHoraInicio = dataEHoraInicio + "T" + horaInicial.ToString("HH:mm"); //"2017-06-01T08:30"
            dataEHoraFinal = dataFinal.ToString("yyyy-MM-dd") + "T" + horaFinal.ToString("HH:mm");

            try
            {
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open(); //abre a conexão com o banco de dados
                String inserirMeta = "INSERT INTO tarefa (descricao, nome_categoria, data_de_inicio, data_de_finalizacao) VALUES ('" + txDescricao.Text + "', '" + comboCategoria.Text + "', '" + dataEHoraInicio + "', '" + dataEHoraFinal + "');";
                MySqlCommand cmd = new MySqlCommand(inserirMeta, conn);
                cmd.ExecuteNonQuery();
                conn.Close(); //fecha a conexão com o banco de dados
                MessageBox.Show("Tarefa salva!");
                this.Close(); //fecha o formulário
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERRO: "+ex+ "\n\nUm erro ocoreu durante a inserção de dados, " +
                    "verifique se todos os campos foram inseridos corretamente.");
            }
            
        }

        private void CarregarComboBox()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            string carregarCategoria = "SELECT * FROM categoria";
            MySqlCommand cmd = new MySqlCommand(carregarCategoria, conn);
            MySqlDataReader leitor = cmd.ExecuteReader();
            while (leitor.Read())
            {
                if (!(leitor["nome"] + "").Equals("indefinida"))
                    comboCategoria.Items.Add(leitor["nome"] + "");
            }
            leitor.Close();
            conn.Close();
        }
    }
}
