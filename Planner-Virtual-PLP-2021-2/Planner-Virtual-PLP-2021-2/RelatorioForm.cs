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
    public partial class RelatorioForm : Form
    {
        String connString = "SERVER=localhost; DATABASE=db_planner; UID=dotnet; PASSWORD=dotnet123#; SSLMODE=none";
        public RelatorioForm()
        {
            InitializeComponent();
            UpdateMesProdutivo();
        }

        private void BtnNATarefa_Click(object sender, EventArgs e)
        {
            UpdateAnyQuantidadeTotalTarefa();
            UpdateAnyTotalQuantidadeTarefaExecutada();
            UpdateAnyTotalPorcentagemTarefaExecutada();
            UpdateAnyTotalCategoriaTarefaExecutada();
            UpdateTotalTurnoProdutivo();
        }

        private void BtnNAMeta_Click(object sender, EventArgs e)
        {
            UpdateAnyTotalQuantidadeMeta();
            UpdateAnyTotalQuantidadeMetaAlcancada();
            UpdateAnyTotalPorcentagemMetaAlcancada();
            UpdateAnyTotalCategoriaMetaAlcancada();
        }

        private void UpdateByDataMeta(object sender, EventArgs e)
        {
            String dataI = pickDataInicioMeta.Value.ToString("yyyy-MM-dd");
            String dataF = pickDataFinalMeta.Value.ToString("yyyy-MM-dd");

            txCatMeta.Clear();
            txPorMeta.Clear();
            txQtdMeta.Clear();
            txTotalMeta.Clear();

            UpdateSelectedTotalQuantidadeMeta(dataI, dataF);
            UpdateSelectedTotalQuantidadeMetaAlcancada(dataI, dataF);
            UpdateSelectedTotalPorcentagemMetaAlcancada(dataI, dataF);
            UpdateSelectedTotalCategoriaMetaAlcancada(dataI, dataF);
        }

        private void UpdateByDataTarefa(object sender, EventArgs e)
        {
            String dataI = pickDataInicioTarefa.Value.ToString("yyyy-MM-dd");
            String dataF = pickDataFinalTarefa.Value.ToString("yyyy-MM-dd");

            txCatTarefa.Clear();
            txPorTarefa.Clear();
            txQtdTarefa.Clear();
            txTotalTarefa.Clear();

            UpdateSelectedTotalQuantidadeTarefa(dataI, dataF);
            UpdateSelectedTotalQuantidadeTarefaExecutada(dataI, dataF);
            UpdateSelectedTotalPorcentagemTarefaExecutada(dataI, dataF);
            UpdateSelectedTotalCategoriaTarefaExecutada(dataI, dataF);
            UpdateSelectedTurnoProdutivo(dataI, dataF);
        }

        private void UpdateAnyQuantidadeTotalTarefa()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM tarefa", conn);
            MySqlDataReader leitor = cmd.ExecuteReader();
            while (leitor.Read())
            {
                txTotalTarefa.Text = leitor["COUNT(*)"] + " " + "tarefa(s) fora(m) registrada(s) no sistema.";
            }
            leitor.Close();
            conn.Close();
        }

        private void UpdateAnyTotalQuantidadeTarefaExecutada()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM tarefa WHERE estado_de_conclusao = 'executada'", conn);
            MySqlDataReader leitor = cmd.ExecuteReader();
            while (leitor.Read())
            {
                txQtdTarefa.Text = leitor["COUNT(*)"] + " " + "tarefa(s) fora(m) concluída(s).";
            }
            leitor.Close();
            conn.Close();
        }

        private void UpdateAnyTotalPorcentagemTarefaExecutada()
        {
            float qtdTarefasConcluidas = 0, qtdTarefasRestantes = 0, resultado = 0;

            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) AS qtdExecutada FROM tarefa WHERE estado_de_conclusao = 'executada'", conn);
            MySqlDataReader leitor = cmd.ExecuteReader();
            while (leitor.Read())
            {
                qtdTarefasConcluidas = float.Parse(leitor["qtdExecutada"] + "");
            }
            leitor.Close();


            MySqlCommand cmd2 = new MySqlCommand("SELECT COUNT(*) AS qtdRestante FROM tarefa WHERE estado_de_conclusao != 'executada'", conn);
            MySqlDataReader leitor2 = cmd2.ExecuteReader();
            while (leitor2.Read())
            {
                qtdTarefasRestantes = float.Parse(leitor2["qtdRestante"] + "");
            }
            leitor2.Close();
            conn.Close();

            resultado = qtdTarefasConcluidas / (qtdTarefasConcluidas + qtdTarefasRestantes);

            txPorTarefa.Text = Convert.ToString(String.Format("{0:P2}.", resultado));
        }

        private void UpdateAnyTotalCategoriaTarefaExecutada()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT nome_categoria, COUNT(nome_categoria) AS `qtdDeAparicoes` FROM tarefa WHERE estado_de_conclusao = 'executada' GROUP BY nome_categoria ORDER BY `qtdDeAparicoes` DESC LIMIT 1;", conn);
            MySqlDataReader leitor = cmd.ExecuteReader();
            while (leitor.Read())
            {
                txCatTarefa.Text = leitor["nome_categoria"] + "";
            }
            leitor.Close();
        }

        private void UpdateAnyTotalCategoriaMetaAlcancada()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT nome_categoria, COUNT(nome_categoria) AS `qtdDeAparicoes` FROM meta WHERE estado_de_conclusao = 'atingida com sucesso' GROUP BY nome_categoria ORDER BY `qtdDeAparicoes` DESC LIMIT 1;", conn);
            MySqlDataReader leitor = cmd.ExecuteReader();
            while (leitor.Read())
            {
                txCatMeta.Text = leitor["nome_categoria"] + "";
            }
            leitor.Close();
        }

        private void UpdateAnyTotalPorcentagemMetaAlcancada()
        {
            float qtdMetasConcluidas = 0, qtdMetasRestantes = 0, resultado = 0;

            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) AS qtdExecutada FROM meta WHERE estado_de_conclusao = 'atingida com sucesso'", conn);
            MySqlDataReader leitor = cmd.ExecuteReader();
            while (leitor.Read())
            {
                qtdMetasConcluidas = float.Parse(leitor["qtdExecutada"] + "");
            }
            leitor.Close();


            MySqlCommand cmd2 = new MySqlCommand("SELECT COUNT(*) AS qtdRestante FROM meta WHERE estado_de_conclusao != 'atingida com sucesso'", conn);
            MySqlDataReader leitor2 = cmd2.ExecuteReader();
            while (leitor2.Read())
            {
                qtdMetasRestantes = float.Parse(leitor2["qtdRestante"] + "");
            }
            leitor2.Close();
            conn.Close();

            resultado = qtdMetasConcluidas / (qtdMetasConcluidas + qtdMetasRestantes);

            txPorMeta.Text = Convert.ToString(String.Format("{0:P2}.", resultado));
        }

        private void UpdateAnyTotalQuantidadeMetaAlcancada()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM meta WHERE estado_de_conclusao = 'atingida com sucesso'", conn);
            MySqlDataReader leitor = cmd.ExecuteReader();
            while (leitor.Read())
            {
                txQtdMeta.Text = leitor["COUNT(*)"] + " " + "meta(s) fora(m) concluída(s).";
            }
            leitor.Close();
            conn.Close();
        }

        private void UpdateAnyTotalQuantidadeMeta()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM meta", conn);
            MySqlDataReader leitor = cmd.ExecuteReader();
            while (leitor.Read())
            {
                txTotalMeta.Text = leitor["COUNT(*)"] + " " + "meta(s) fora(m) registrada(s) no sistema.";
            }
            leitor.Close();
            conn.Close();
        }

        private void UpdateSelectedTotalQuantidadeMeta(String dataI, String dataF)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM meta WHERE data_de_efetivacao BETWEEN '"+dataI+"' AND '"+dataF+"'", conn);
            MySqlDataReader leitor = cmd.ExecuteReader();
            while (leitor.Read())
            {
                txTotalMeta.Text = leitor["COUNT(*)"] + " " + "meta(s) existe(m) neste período.";
            }
            leitor.Close();
            conn.Close();
        }

        private void UpdateSelectedTotalQuantidadeMetaAlcancada(String dataI, String dataF)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM meta WHERE estado_de_conclusao = 'atingida com sucesso' AND data_de_efetivacao BETWEEN '" + dataI + "' AND '" + dataF + "'", conn);
            MySqlDataReader leitor = cmd.ExecuteReader();
            while (leitor.Read())
            {
                txQtdMeta.Text = leitor["COUNT(*)"] + " " + "meta(s) fora(m) concluída(s).";
            }
            leitor.Close();
            conn.Close();
        }

        private void UpdateSelectedTotalPorcentagemMetaAlcancada(String dataI, String dataF)
        {
            float qtdMetasConcluidas = 0, qtdMetasRestantes = 0, resultado = 0;

            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) AS qtdExecutada FROM meta WHERE estado_de_conclusao = 'atingida com sucesso' AND data_de_efetivacao BETWEEN '" + dataI + "' AND '" + dataF + "'", conn);
            MySqlDataReader leitor = cmd.ExecuteReader();
            while (leitor.Read())
            {
                qtdMetasConcluidas = float.Parse(leitor["qtdExecutada"] + "");
            }
            leitor.Close();


            MySqlCommand cmd2 = new MySqlCommand("SELECT COUNT(*) AS qtdRestante FROM meta WHERE estado_de_conclusao != 'atingida com sucesso' AND data_de_efetivacao BETWEEN '" + dataI + "' AND '" + dataF + "'", conn);
            MySqlDataReader leitor2 = cmd2.ExecuteReader();
            while (leitor2.Read())
            {
                qtdMetasRestantes = float.Parse(leitor2["qtdRestante"] + "");
            }
            leitor2.Close();
            conn.Close();

            resultado = qtdMetasConcluidas / (qtdMetasConcluidas + qtdMetasRestantes);
            if (qtdMetasConcluidas != float.Parse("0"))
                txPorMeta.Text = Convert.ToString(String.Format("{0:P2}.", resultado));
            else
                txPorMeta.Text = "Não há metas concluídas aqui.";
        }

        private void UpdateSelectedTotalCategoriaMetaAlcancada(String dataI, String dataF)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT nome_categoria, COUNT(nome_categoria) AS `qtdDeAparicoes` FROM meta WHERE estado_de_conclusao = 'atingida com sucesso' AND data_de_efetivacao BETWEEN '" + dataI + "' AND '" + dataF + "' GROUP BY nome_categoria ORDER BY `qtdDeAparicoes` DESC LIMIT 1;", conn);
            MySqlDataReader leitor = cmd.ExecuteReader();
            while (leitor.Read())
            {
                txCatMeta.Text = leitor["nome_categoria"] + "";       
            }
            leitor.Close();
        }

        private void UpdateSelectedTotalCategoriaTarefaExecutada(String dataI, String dataF)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT nome_categoria, COUNT(nome_categoria) AS `qtdDeAparicoes` FROM tarefa WHERE estado_de_conclusao = 'executada' AND data_de_inicio BETWEEN '" + dataI + "' AND '" + dataF + "' GROUP BY nome_categoria ORDER BY `qtdDeAparicoes` DESC LIMIT 1;", conn);
            MySqlDataReader leitor = cmd.ExecuteReader();
            while (leitor.Read())
            {
                txCatTarefa.Text = leitor["nome_categoria"] + "";
            }
            leitor.Close();
        }

        private void UpdateSelectedTotalQuantidadeTarefaExecutada(String dataI, String dataF)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM tarefa WHERE estado_de_conclusao = 'executada' AND data_de_inicio BETWEEN '" + dataI + "' AND '" + dataF + "'", conn);
            MySqlDataReader leitor = cmd.ExecuteReader();
            while (leitor.Read())
            {
                txQtdTarefa.Text = leitor["COUNT(*)"] + " " + "tarefa(s) fora(m) concluída(s).";
            }
            leitor.Close();
            conn.Close();
        }

        private void UpdateSelectedTotalPorcentagemTarefaExecutada(String dataI, String dataF)
        {
            float qtdTarefasConcluidas = 0, qtdTarefasRestantes = 0, resultado = 0;

            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) AS qtdExecutada FROM tarefa WHERE estado_de_conclusao = 'executada' AND data_de_inicio BETWEEN '" + dataI + "' AND '" + dataF + "'", conn);
            MySqlDataReader leitor = cmd.ExecuteReader();
            while (leitor.Read())
            {
                qtdTarefasConcluidas = float.Parse(leitor["qtdExecutada"] + "");
            }
            leitor.Close();


            MySqlCommand cmd2 = new MySqlCommand("SELECT COUNT(*) AS qtdRestante FROM tarefa WHERE estado_de_conclusao != 'executada' AND data_de_inicio BETWEEN '" + dataI + "' AND '" + dataF + "'", conn);
            MySqlDataReader leitor2 = cmd2.ExecuteReader();
            while (leitor2.Read())
            {
                qtdTarefasRestantes = float.Parse(leitor2["qtdRestante"] + "");
            }
            leitor2.Close();
            conn.Close();

            resultado = qtdTarefasConcluidas / (qtdTarefasConcluidas + qtdTarefasRestantes);
            if (qtdTarefasConcluidas != float.Parse("0"))
                txPorTarefa.Text = Convert.ToString(String.Format("{0:P2}.", resultado));
            else
                txPorTarefa.Text = "Não há tarefas concluídas aqui.";
        }


        private void UpdateSelectedTotalQuantidadeTarefa(String dataI, String dataF)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM tarefa WHERE data_de_inicio BETWEEN '" + dataI + "' AND '" + dataF + "'", conn);
            MySqlDataReader leitor = cmd.ExecuteReader();
            while (leitor.Read())
            {
                txTotalTarefa.Text = leitor["COUNT(*)"] + " " + "tarefa(s) existe(m) neste período.";
            }
            leitor.Close();
            conn.Close();
        }

        private void UpdateTotalTurnoProdutivo()
        {
            int madrugada = 0, manha = 0, tarde = 0, noite = 0; //0-04:59, 5-11:59, 12-17:59, 18-23:59

            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM tarefa WHERE estado_de_conclusao = 'executada' AND TIME(data_de_inicio) BETWEEN '00:00' AND '04:59'", conn);
            MySqlDataReader leitor = cmd.ExecuteReader();

            while (leitor.Read())
                madrugada = Convert.ToInt32(leitor["COUNT(*)"]);
            leitor.Close();

            cmd = new MySqlCommand("SELECT COUNT(*) FROM tarefa WHERE estado_de_conclusao = 'executada' AND TIME(data_de_inicio) BETWEEN '05:00' AND '11:59'", conn);
            leitor = cmd.ExecuteReader();

            while (leitor.Read())
                manha = Convert.ToInt32(leitor["COUNT(*)"]);
            leitor.Close();

            cmd = new MySqlCommand("SELECT COUNT(*) FROM tarefa WHERE estado_de_conclusao = 'executada' AND TIME(data_de_inicio) BETWEEN '12:00' AND '17:59'", conn);
            leitor = cmd.ExecuteReader();

            while (leitor.Read())
                tarde = Convert.ToInt32(leitor["COUNT(*)"]);
            leitor.Close();

            cmd = new MySqlCommand("SELECT COUNT(*) FROM tarefa WHERE estado_de_conclusao = 'executada' AND TIME(data_de_inicio) BETWEEN '18:00' AND '23:59'", conn);
            leitor = cmd.ExecuteReader();

            while (leitor.Read())
                noite = Convert.ToInt32(leitor["COUNT(*)"]);
            leitor.Close();
            conn.Close();

            int maiorValor = Math.Max(Math.Max(Math.Max(madrugada, manha), tarde), noite);
            String texto = "Não há turno produtivo neste período.";

            if(maiorValor == 0)
            {
                txTurnoTarefa.Text = texto;
                return;
            }

            if(maiorValor == madrugada)
            {
                texto = "Você tem insônia pela Madrugada.";
            } 
            else if (maiorValor == manha)
            {
                texto = "Você é exímio pela Manhã.";
            } 
            else if (maiorValor == tarde)
            {
                texto = "Você realiza mais atividades à Tarde.";
            } 
            else if (maiorValor == noite)
            {
                texto = "Você é proativo à Noite.";
            }

            txTurnoTarefa.Text = texto;
        }

        private void UpdateSelectedTurnoProdutivo(String dataI, String dataF)
        {
            int madrugada = 0, manha = 0, tarde = 0, noite = 0; //0-04:59, 5-11:59, 12-17:59, 18-23:59

            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM tarefa WHERE estado_de_conclusao = 'executada' AND " +
                "(data_de_inicio BETWEEN '" + dataI + "' AND '" + dataF + "') AND" +
                "(TIME(data_de_inicio) BETWEEN '00:00' AND '04:59')", conn);
            MySqlDataReader leitor = cmd.ExecuteReader();

            while (leitor.Read())
                madrugada = Convert.ToInt32(leitor["COUNT(*)"]);
            leitor.Close();

            cmd = new MySqlCommand("SELECT COUNT(*) FROM tarefa WHERE estado_de_conclusao = 'executada' AND " +
                "(data_de_inicio BETWEEN '" + dataI + "' AND '" + dataF + "') AND" +
                "(TIME(data_de_inicio) BETWEEN '05:00' AND '11:59')", conn);
            leitor = cmd.ExecuteReader();

            while (leitor.Read())
                manha = Convert.ToInt32(leitor["COUNT(*)"]);
            leitor.Close();

            cmd = new MySqlCommand("SELECT COUNT(*) FROM tarefa WHERE estado_de_conclusao = 'executada' AND " +
                "(data_de_inicio BETWEEN '" + dataI + "' AND '" + dataF + "') AND" +
                "(TIME(data_de_inicio) BETWEEN '12:00' AND '17:59')", conn);
            leitor = cmd.ExecuteReader();

            while (leitor.Read())
                tarde = Convert.ToInt32(leitor["COUNT(*)"]);
            leitor.Close();

            cmd = new MySqlCommand("SELECT COUNT(*) FROM tarefa WHERE estado_de_conclusao = 'executada' AND " +
                "(data_de_inicio BETWEEN '" + dataI + "' AND '" + dataF + "') AND" +
                "(TIME(data_de_inicio) BETWEEN '18:00' AND '23:59')", conn);
            leitor = cmd.ExecuteReader();

            while (leitor.Read())
                noite = Convert.ToInt32(leitor["COUNT(*)"]);
            leitor.Close();
            conn.Close();

            int maiorValor = Math.Max(Math.Max(Math.Max(madrugada, manha), tarde), noite);
            String texto = "Não há turno produtivo neste período.";

            if (maiorValor == 0)
            {
                txTurnoTarefa.Text = texto;
                return;
            }

            if (maiorValor == madrugada)
            {
                texto = "Você tem insônia pela Madrugada.";
            }
            else if (maiorValor == manha)
            {
                texto = "Você é exímio pela Manhã.";
            }
            else if (maiorValor == tarde)
            {
                texto = "Você realiza mais atividades à Tarde.";
            }
            else if (maiorValor == noite)
            {
                texto = "Você é proativo à Noite.";
            }

            txTurnoTarefa.Text = texto;
        }

        private void UpdateMesProdutivo()
        {
            String comecoDoAno = DateTime.Now.Year.ToString() + "-01-01";
            String dataAtual = DateTime.Now.Year.ToString() + "-12-31";
            String mes = "";

            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT MONTH(data_de_inicio) as 'mes', COUNT(MONTH(data_de_inicio)) AS 'tarefas_concluidas' FROM tarefa WHERE estado_de_conclusao = 'executada' AND(data_de_inicio BETWEEN '" + comecoDoAno+"' AND '"+dataAtual+ "') GROUP BY MONTH(data_de_inicio) ORDER BY 'tarefas_concluidas' DESC LIMIT 1", conn);
            MySqlDataReader leitor = cmd.ExecuteReader();

            while (leitor.Read())
                mes = leitor["mes"] + "";
            leitor.Close();
            conn.Close();

            txMesProdutivo.Text = conversorMes(mes);
        }

        private String conversorMes(String mesString)
        {
            switch (mesString)
            {
                case "1":
                    return "Janeiro";
                case "2":
                    return "Fevereiro";
                case "3":
                    return "Março";
                case "4":
                    return "Abril";
                case "5":
                    return "Maio";
                case "6":
                    return "Junho";
                case "7":
                    return "Julho";
                case "8":
                    return "Agosto";
                case "9":
                    return "Setembro";
                case "10":
                    return "Outubro";
                case "11":
                    return "Novembro";
                case "12":
                    return "Dezembro";
                default:
                    return "Nenhum";
            }
        }
    }
}
