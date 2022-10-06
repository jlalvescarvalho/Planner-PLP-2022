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
        String dataEHoraInicio, dataEHoraFinal, id_tarefa;
        bool isParaEdicao = false;

        //Construtor para o Componente no Formato de Cadastro de Dados
        public TarefaForm(DateTime dataEscolhida)
        {
            dataEHoraInicio = dataEscolhida.ToString("yyyy-MM-dd");
            InitializeComponent();
            CarregarComboBox();
            txDataInicio.Text = dataEscolhida.ToString("dd/MM/yyyy");
            pickDataFinal.Text = dataEscolhida.ToString("dd/MM/yyyy");
            if(dataEscolhida.Year.CompareTo(DateTime.Now.Year) == 0 &
                dataEscolhida.Month.CompareTo(DateTime.Now.Month) == 0 &
                dataEscolhida.Day.CompareTo(DateTime.Now.Day) == 0)
            {
                pickDataFinal.Enabled = false;
            }
        }

        //Construtor para o Componente no Formato de Atualização de Dados
        public TarefaForm(String id_tarefa)
        {
            InitializeComponent();
            CarregarComboBox();
            btnSalvar.Text = "Atualizar";
            isParaEdicao = true;
            this.id_tarefa = id_tarefa;

            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tarefa WHERE id_tarefa = "+id_tarefa, conn);
            MySqlDataReader leitor = cmd.ExecuteReader();
            while (leitor.Read())
            {
                comboCategoria.SelectedItem = leitor["nome_categoria"] + "";
                txDescricao.Text = leitor["descricao"] + "";
                dataEHoraInicio = Convert.ToDateTime(leitor["data_de_inicio"]).ToString("yyyy-MM-dd");
                txDataInicio.Text = Convert.ToDateTime(leitor["data_de_inicio"]).ToString("dd/MM/yyyy");
                pickDataFinal.Value = Convert.ToDateTime(leitor["data_de_finalizacao"]);
                pickHoraInicio.Value = Convert.ToDateTime(leitor["data_de_inicio"]);
                pickHorarioFinal.Value = Convert.ToDateTime(leitor["data_de_finalizacao"]);
            }
            leitor.Close();
            conn.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!isParaEdicao)
                SalvarTarefa();
            else
                AtualizarTarefa();
        }

        private void SalvarTarefa()
        {
            String iString = dataEHoraInicio + " " + pickHoraInicio.Value.ToString("HH:mm");
            String uString = pickDataFinal.Value.ToString("yyyy-MM-dd") + " " + pickHorarioFinal.Value.ToString("HH:mm");
            DateTime dataInicialConvertida = DateTime.ParseExact(iString, "yyyy-MM-dd HH:mm", null);
            DateTime dataFinalConvertida = DateTime.ParseExact(uString, "yyyy-MM-dd HH:mm", null);

            if(dataFinalConvertida.CompareTo(dataInicialConvertida) < 0)
            {
                MessageBox.Show("ERRO: InvalidDataException.\n\n" +
                    "Um erro ocoreu durante a inserção de dados, coloque " +
                    "uma data posterior à data inicial da tarefa para salvá-la.",
                    "Deu ruim.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(dataInicialConvertida.Year.CompareTo(DateTime.Now.Year) == 0 &
                dataInicialConvertida.Month.CompareTo(DateTime.Now.Month) == 0 &
                dataInicialConvertida.Day.CompareTo(DateTime.Now.Day) == 0 &
                ((dataInicialConvertida.Hour.CompareTo(DateTime.Now.Hour) < 0) ||
                (dataInicialConvertida.Hour.CompareTo(DateTime.Now.Hour) == 0 &
                dataInicialConvertida.Minute.CompareTo(DateTime.Now.Minute) < 0)))
            {
                MessageBox.Show("ERRO: InvalidDataException.\n\n" +
                    "Um erro ocoreu durante a inserção de dados, coloque " +
                    "uma data posterior à data inicial da tarefa para salvá-la.",
                    "Deu ruim.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txDescricao.Text.Equals(""))
            {
                MessageBox.Show("ERRO: EmptyFieldException.\n\n" +
                    "Um erro ocoreu durante a inserção de dados, " +
                    "verifique se todos os campos foram inseridos corretamente.",
                    "Deu ruim.", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                String inserirTarefa = "INSERT INTO tarefa (descricao, nome_categoria, data_de_inicio, data_de_finalizacao) VALUES ('" + txDescricao.Text + "', '" + comboCategoria.Text + "', '" + dataEHoraInicio + "', '" + dataEHoraFinal + "');";
                MySqlCommand cmd = new MySqlCommand(inserirTarefa, conn);
                cmd.ExecuteNonQuery();
                conn.Close(); //fecha a conexão com o banco de dados
                MessageBox.Show("Tarefa salva!","Os dados foram salvos corretamente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); //fecha o formulário

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex + "\n\nUm erro ocoreu durante a inserção de dados, " +
                    "verifique se todos os campos foram inseridos corretamente.");
            }
        }

        private void AtualizarTarefa()
        {
            String iString = dataEHoraInicio + " " + pickHoraInicio.Value.ToString("HH:mm");
            String uString = pickDataFinal.Value.ToString("yyyy-MM-dd") + " " + pickHorarioFinal.Value.ToString("HH:mm");
            DateTime dataInicialConvertida = DateTime.ParseExact(iString, "yyyy-MM-dd HH:mm", null);
            DateTime dataFinalConvertida = DateTime.ParseExact(uString, "yyyy-MM-dd HH:mm", null);

            if (dataFinalConvertida.CompareTo(dataInicialConvertida) < 0)
            {
                MessageBox.Show("ERRO: InvalidDataException.\n\n" +
                    "Um erro ocoreu durante a inserção de dados, coloque " +
                    "uma data posterior à data inicial da tarefa para salvá-la.",
                    "Deu ruim.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dataInicialConvertida.Year.CompareTo(DateTime.Now.Year) == 0 &
                dataInicialConvertida.Month.CompareTo(DateTime.Now.Month) == 0 &
                dataInicialConvertida.Day.CompareTo(DateTime.Now.Day) == 0 &
                ((dataInicialConvertida.Hour.CompareTo(DateTime.Now.Hour) < 0) ||
                (dataInicialConvertida.Hour.CompareTo(DateTime.Now.Hour) == 0 &
                dataInicialConvertida.Minute.CompareTo(DateTime.Now.Minute) < 0)))
            {
                MessageBox.Show("ERRO: InvalidDataException.\n\n" +
                    "Um erro ocoreu durante a inserção de dados, coloque " +
                    "uma data posterior à data inicial da tarefa para salvá-la.",
                    "Deu ruim.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txDescricao.Text.Equals(""))
            {
                MessageBox.Show("ERRO: EmptyFieldException.\n\n" +
                    "Um erro ocoreu durante a atualização de dados, " +
                    "verifique se todos os campos foram inseridos corretamente.",
                    "Deu ruim.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime horaInicial = Convert.ToDateTime(pickHoraInicio.Value);
            DateTime dataFinal = Convert.ToDateTime(pickDataFinal.Value);
            DateTime horaFinal = Convert.ToDateTime(pickHorarioFinal.Value);
            dataEHoraInicio = dataEHoraInicio + "T" + horaInicial.ToString("HH:mm");
            dataEHoraFinal = dataFinal.ToString("yyyy-MM-dd") + "T" + horaFinal.ToString("HH:mm");

            try
            {
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                String atualizarTarefa = "UPDATE tarefa SET descricao = '" + txDescricao.Text + "', nome_categoria = '" + comboCategoria.Text + "', data_de_inicio = '" + dataEHoraInicio + "', data_de_finalizacao = '" + dataEHoraFinal + "' WHERE id_tarefa = "+id_tarefa;
                MySqlCommand cmd = new MySqlCommand(atualizarTarefa, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Tarefa atualizada!", "Dados atualizados com sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex + "\n\nUm erro ocoreu durante a atualização de dados, " +
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
