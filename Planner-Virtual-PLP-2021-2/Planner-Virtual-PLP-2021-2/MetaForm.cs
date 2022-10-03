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
    public partial class MetaForm : Form
    {
        //Criando uma conexão com o MySQL
        String connString = "SERVER=localhost; DATABASE=db_planner; UID=dotnet; PASSWORD=dotnet123#; SSLMODE=none";
        String dataAGravar;
        public MetaForm(DateTime dataEscolhida)
        {
            InitializeComponent();
            CarregarComboBox();
            dataAGravar = dataEscolhida.ToString("yyyy-MM-dd");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txDescricao.Text.Equals("")) 
            { 
                MessageBox.Show("ERRO: EmptyFieldException.\n\nUm erro ocoreu durante a inserção de dados, " +
                    "verifique se todos os campos foram inseridos corretamente.");
                return;
            }
            try {
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open(); //abre a conexão com o banco de dados
                String inserirMeta = "INSERT INTO meta (descricao, nome_categoria, data_de_efetivacao) VALUES ('"+txDescricao.Text+"', '"+comboCategoria.Text+"', '"+dataAGravar+"');";
                MySqlCommand cmd = new MySqlCommand(inserirMeta, conn);
                cmd.ExecuteNonQuery();
                conn.Close(); //fecha a conexão com o banco de dados
                MessageBox.Show("Meta salva!");
                this.Close(); //fecha o formulário
            } 
            catch(Exception ex)
            {
                MessageBox.Show("ERRO: " + ex + "\n\nUm erro ocoreu durante a inserção de dados, " +
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
                if (!(leitor["nome"]+"").Equals("indefinida"))
                    comboCategoria.Items.Add(leitor["nome"] + "");
            }
            leitor.Close();
            conn.Close();
        }
    }
}
