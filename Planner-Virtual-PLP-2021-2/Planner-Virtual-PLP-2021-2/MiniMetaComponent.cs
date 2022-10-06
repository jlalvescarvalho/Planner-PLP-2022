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
    public partial class MiniMetaComponent : UserControl
    {
        String connString = "SERVER=localhost; DATABASE=db_planner; UID=dotnet; PASSWORD=dotnet123#; SSLMODE=none";
        String id;
        public MiniMetaComponent(String id, String descricao, String nome_categoria, 
            String estado_de_conclusao, String data_de_efetivacao)
        {
            this.id = id;
            InitializeComponent();
            lbCategoria.Text = nome_categoria;
            lbDescricao.Text = lbDescricao.Text + " " + descricao;
            lbEstado.Text = lbEstado.Text + " " + estado_de_conclusao;
            lbDataFinal.Text = lbDataFinal.Text + " " + data_de_efetivacao.Remove(10);
            ChangeComponentColor(nome_categoria);
        }

        private void ClickOnMeta(object sender, EventArgs e)
        {
            SeletorForm seletorForm = new SeletorForm("meta", id);
            seletorForm.ShowDialog();
            //Remoção do Componente
            if (seletorForm.Operacao == "rem")
                this.DestroyHandle();
            //Atualização do Componente
            else if (seletorForm.Operacao == "alt")
            {
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM meta WHERE id_meta = " + id, conn);
                MySqlDataReader leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    lbCategoria.Text = leitor["nome_categoria"] + "";
                    ChangeComponentColor(lbCategoria.Text);
                    lbEstado.Text = lbEstado.Text.ToString().Substring(0,7) + " " + leitor["estado_de_conclusao"] + "";
                    lbDescricao.Text = lbDescricao.Text.ToString().Substring(0, 10) + " " + leitor["descricao"] + "";
                }
                leitor.Close();
                conn.Close();
            }
        }

        public String Id
        {
            get { return id;  }
        }

        private void ChangeComponentColor(String categoria)
        {
            switch (categoria)
            {
                case "Compras":
                    painelCategoria.BackColor = Color.Crimson;
                    lbCategoria.ForeColor = Color.White;
                    break;
                case "Diversão":
                    painelCategoria.BackColor = Color.Green;
                    lbCategoria.ForeColor = Color.White;
                    break;
                case "Estudo":
                    painelCategoria.BackColor = Color.PaleVioletRed;
                    lbCategoria.ForeColor = Color.White;
                    break;
                case "Família":
                    painelCategoria.BackColor = Color.Red;
                    lbCategoria.ForeColor = Color.White;
                    break;
                case "Musculação":
                    painelCategoria.BackColor = Color.Blue;
                    lbCategoria.ForeColor = Color.White;
                    break;
                case "Pesquisa":
                    painelCategoria.BackColor = Color.LightSlateGray;
                    lbCategoria.ForeColor = Color.White;
                    break;
                case "Reunião":
                    painelCategoria.BackColor = Color.Purple;
                    lbCategoria.ForeColor = Color.White;
                    break;
                case "Telefonema":
                    painelCategoria.BackColor = Color.DarkOrange;
                    lbCategoria.ForeColor = Color.White;
                    break;
                case "Trabalho":
                    painelCategoria.BackColor = Color.SaddleBrown;
                    lbCategoria.ForeColor = Color.White;
                    break;
            }
        }
    }
}
