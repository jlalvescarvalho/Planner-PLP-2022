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
    public partial class ListaForm : Form
    {
        String connString = "SERVER=localhost; DATABASE=db_planner; UID=dotnet; PASSWORD=dotnet123#; SSLMODE=none";

        public ListaForm()
        {
            InitializeComponent();
            this.Text = "Lista de todos os Eventos já Registrados";
            CarregarTarefas();
            CarregarMetas();
            CarregarLembretes();
            comboTarefa.SelectedIndex = 0;
            comboMeta.SelectedIndex = 0;
            comboLembrete.SelectedIndex = 0;
            CheckEmptyField();
        }

        public ListaForm(DateTime dataSelecionada)
        {
            InitializeComponent();
            this.Text = "Visualização de todos os Eventos do Dia: "+dataSelecionada.ToString("yyyy-MM-dd"); ;
            CarregarMetas(dataSelecionada);
            CarregarTarefas(dataSelecionada);
            CarregarLembretes(dataSelecionada);
            comboLembrete.Enabled = false;
            comboMeta.Enabled = false;
            comboTarefa.Enabled = false;
            lbFiltroTarefas.Text = "O filtro de tarefas está desabilitado para esse modo.";
            lbFiltroMetas.Text = "O filtro de metas está desabilitado para esse modo.";
            lbFiltroLembretes.Text = "O filtro de lembretes está desabilitado para esse modo.";
            CheckEmptyField();
        }

        private void ComboTarefa_Update(object sender, EventArgs e)
        {
            FiltrarTarefas();
            CheckEmptyField();
        }

        private void ComboMeta_Update(object sender, EventArgs e)
        {
            FiltrarMetas();
            CheckEmptyField();
        }

        private void ComboLembrete_Update(object sender, EventArgs e)
        {
            CheckEmptyField();
        }

        private void CheckEmptyField()
        {
            Label textoDeAviso = new Label();
            textoDeAviso.Text = "Vazio";

            if (painelDeMetas.Controls.Count == 0)
                painelDeMetas.Controls.Add(textoDeAviso);

            if (painelDeTarefas.Controls.Count == 0)
                painelDeTarefas.Controls.Add(textoDeAviso);

            if (painelDeLembretes.Controls.Count == 0)
                painelDeLembretes.Controls.Add(textoDeAviso);
        }

        private void CarregarTarefas()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tarefa", conn);
            MySqlDataReader leitor = cmd.ExecuteReader();
            while (leitor.Read())
            {
                MiniTarefaComponent tarefaComponent = new MiniTarefaComponent(
                    leitor["id_tarefa"] + "", leitor["descricao"] + "", leitor["nome_categoria"] + "", leitor["estado_de_conclusao"] + "",
                    leitor["data_de_inicio"] + "", leitor["data_de_finalizacao"] + "");
                painelDeTarefas.Controls.Add(tarefaComponent);
            }
            leitor.Close();
            conn.Close();
        }

        private void CarregarMetas()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM meta", conn);
            MySqlDataReader leitor = cmd.ExecuteReader();
            while (leitor.Read())
            {
                MiniMetaComponent metaComponent = new MiniMetaComponent(
                    leitor["id_meta"] + "", leitor["descricao"] + "", leitor["nome_categoria"] + "", leitor["estado_de_conclusao"] + "",
                    leitor["data_de_efetivacao"] + "");
                painelDeMetas.Controls.Add(metaComponent);
            }
            leitor.Close();
            conn.Close();
        }

        private void CarregarLembretes()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM lembrete", conn);
            MySqlDataReader leitor = cmd.ExecuteReader();
            while (leitor.Read())
            {
                MiniLembreteComponent lembreteComponent = new MiniLembreteComponent(
                    leitor["id_lembrete"] + "", leitor["mensagem"] + "", leitor["id_tarefa_lembrada"] + "");
                painelDeLembretes.Controls.Add(lembreteComponent);
            }
            leitor.Close();
            conn.Close();
        }

        private void CarregarTarefas(DateTime dataSelecionada)
        {
            String dataAPesquisar = dataSelecionada.ToString("yyyy-MM-dd");
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            string carregarEvento = "SELECT * FROM tarefa WHERE DATE(data_de_inicio) = '" + dataAPesquisar + "'";
            MySqlCommand cmd = new MySqlCommand(carregarEvento, conn);
            MySqlDataReader leitor = cmd.ExecuteReader();
            while (leitor.Read())
            {
                MiniTarefaComponent tarefaComponent = new MiniTarefaComponent(
                    leitor["id_tarefa"] + "", leitor["descricao"] + "", leitor["nome_categoria"] + "", leitor["estado_de_conclusao"] + "",
                    leitor["data_de_inicio"] + "", leitor["data_de_finalizacao"] + "");
                painelDeTarefas.Controls.Add(tarefaComponent);
            }
            leitor.Close();
            conn.Close();
        }

        private void CarregarMetas(DateTime dataSelecionada)
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
                painelDeMetas.Controls.Add(metaComponent);
            }
            leitor.Close();
            conn.Close();
        }

        private void CarregarLembretes(DateTime dataSelecionada)
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
                painelDeLembretes.Controls.Add(lembreteComponent);
            }
            leitor.Close();
            conn.Close();
        }

        private void FiltrarMetas()
        {
            switch (comboMeta.SelectedIndex)
            {
                case 0:
                    painelDeMetas.Controls.Clear();
                    CarregarMetas();
                    return;
                case 1:
                    painelDeMetas.Controls.Clear();
                    CarregarEventoPorEstadoDeConclusao("meta", "pendente");
                    return;
                case 2:
                    painelDeMetas.Controls.Clear();
                    CarregarEventoPorEstadoDeConclusao("meta", "atingida com sucesso");
                    return;
                case 3:
                    painelDeMetas.Controls.Clear();
                    CarregarEventoPorEstadoDeConclusao("meta", "parcialmente atingida");
                    return;
                case 4:
                    painelDeMetas.Controls.Clear();
                    CarregarEventoPorCategoria("meta", "sem sucesso");
                    return;
                case 5:
                    painelDeMetas.Controls.Clear();
                    CarregarEventoPorCategoria("meta", "Compras");
                    return;
                case 6:
                    painelDeMetas.Controls.Clear();
                    CarregarEventoPorCategoria("meta", "Diversão");
                    return;
                case 7:
                    painelDeMetas.Controls.Clear();
                    CarregarEventoPorCategoria("meta", "Estudo");
                    return;
                case 8:
                    painelDeMetas.Controls.Clear();
                    CarregarEventoPorCategoria("meta", "Família");
                    return;
                case 9:
                    painelDeMetas.Controls.Clear();
                    CarregarEventoPorCategoria("meta", "Musculação");
                    return;
                case 10:
                    painelDeMetas.Controls.Clear();
                    CarregarEventoPorCategoria("meta", "Pesquisa");
                    return;
                case 11:
                    painelDeMetas.Controls.Clear();
                    CarregarEventoPorCategoria("meta", "Reunião");
                    return;
                case 12:
                    painelDeMetas.Controls.Clear();
                    CarregarEventoPorCategoria("meta", "Telefonema");
                    return;
                case 13:
                    painelDeMetas.Controls.Clear();
                    CarregarEventoPorCategoria("meta", "Trabalho");
                    return;
            }
        }

        //Realiza a Exibição de Determinadas tarefas através dos Filtros da Combo Box
        private void FiltrarTarefas()
        {
            switch (comboTarefa.SelectedIndex)
            {
                case 0:
                    painelDeTarefas.Controls.Clear();
                    CarregarTarefas();
                    return;
                case 1:
                    painelDeTarefas.Controls.Clear();
                    CarregarEventoPorEstadoDeConclusao("tarefa","pendente");
                    return;
                case 2:
                    painelDeTarefas.Controls.Clear();
                    CarregarEventoPorEstadoDeConclusao("tarefa", "executada");
                    return;
                case 3:
                    painelDeTarefas.Controls.Clear();
                    CarregarEventoPorEstadoDeConclusao("tarefa", "parcialmente executada");
                    return;
                case 4:
                    painelDeTarefas.Controls.Clear();
                    CarregarEventoPorCategoria("tarefa", "adiada");
                    return;
                case 5:
                    painelDeTarefas.Controls.Clear();
                    CarregarEventoPorCategoria("tarefa", "Compras");
                    return;
                case 6:
                    painelDeTarefas.Controls.Clear();
                    CarregarEventoPorCategoria("tarefa", "Diversão");
                    return;
                case 7:
                    painelDeTarefas.Controls.Clear();
                    CarregarEventoPorCategoria("tarefa", "Estudo");
                    return;
                case 8:
                    painelDeTarefas.Controls.Clear();
                    CarregarEventoPorCategoria("tarefa", "Família");
                    return;
                case 9:
                    painelDeTarefas.Controls.Clear();
                    CarregarEventoPorCategoria("tarefa", "Musculação");
                    return;
                case 10:
                    painelDeTarefas.Controls.Clear();
                    CarregarEventoPorCategoria("tarefa", "Pesquisa");
                    return;
                case 11:
                    painelDeTarefas.Controls.Clear();
                    CarregarEventoPorCategoria("tarefa", "Reunião");
                    return;
                case 12:
                    painelDeTarefas.Controls.Clear();
                    CarregarEventoPorCategoria("tarefa", "Telefonema");
                    return;
                case 13:
                    painelDeTarefas.Controls.Clear();
                    CarregarEventoPorCategoria("tarefa", "Trabalho");
                    return;
            }
        }

        private void CarregarEventoPorEstadoDeConclusao(String tipoDeEvento, String estado_de_conclusao)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            string carregarEvento = "SELECT * FROM "+tipoDeEvento+" WHERE estado_de_conclusao = '" + estado_de_conclusao + "'";
            MySqlCommand cmd = new MySqlCommand(carregarEvento, conn);
            MySqlDataReader leitor = cmd.ExecuteReader();
            if(tipoDeEvento == "tarefa")
            {
                while (leitor.Read())
                {
                    MiniTarefaComponent tarefaComponent = new MiniTarefaComponent(
                        leitor["id_tarefa"] + "", leitor["descricao"] + "", leitor["nome_categoria"] + "", leitor["estado_de_conclusao"] + "",
                        leitor["data_de_inicio"] + "", leitor["data_de_finalizacao"] + "");
                    painelDeTarefas.Controls.Add(tarefaComponent);
                }
            }
            else if (tipoDeEvento == "meta")
            {
                while (leitor.Read())
                {
                    MiniMetaComponent metaComponent = new MiniMetaComponent(
                    leitor["id_meta"] + "", leitor["descricao"] + "", leitor["nome_categoria"] + "", leitor["estado_de_conclusao"] + "",
                    leitor["data_de_efetivacao"] + "");
                    painelDeMetas.Controls.Add(metaComponent);
                }
            }
            leitor.Close();
            conn.Close();
        }

        private void CarregarEventoPorCategoria(String tipoDeEvento, String categoria)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            string carregarEvento = "SELECT * FROM "+tipoDeEvento+" WHERE nome_categoria = '" + categoria + "'";
            MySqlCommand cmd = new MySqlCommand(carregarEvento, conn);
            MySqlDataReader leitor = cmd.ExecuteReader();
            if(tipoDeEvento == "tarefa")
            {
                while (leitor.Read())
                {
                    MiniTarefaComponent tarefaComponent = new MiniTarefaComponent(
                        leitor["id_tarefa"] + "", leitor["descricao"] + "", leitor["nome_categoria"] + "", leitor["estado_de_conclusao"] + "",
                        leitor["data_de_inicio"] + "", leitor["data_de_finalizacao"] + "");
                    painelDeTarefas.Controls.Add(tarefaComponent);
                }
            }
            else if(tipoDeEvento == "meta")
            {
                while (leitor.Read())
                {
                    MiniMetaComponent metaComponent = new MiniMetaComponent(
                    leitor["id_meta"] + "", leitor["descricao"] + "", leitor["nome_categoria"] + "", leitor["estado_de_conclusao"] + "",
                    leitor["data_de_efetivacao"] + "");
                    painelDeMetas.Controls.Add(metaComponent);
                }
            }
            leitor.Close();
            conn.Close();
        }
    }
}
