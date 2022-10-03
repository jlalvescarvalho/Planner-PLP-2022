using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planner_Virtual_PLP_2021_2
{
    public partial class MiniTarefaComponent : UserControl
    {
        String id, descricao, nome_categoria, estado_de_conclusao, data_de_inicio, data_de_finalizacao;
        public MiniTarefaComponent(String id, String descricao, String nome_categoria,
            String estado_de_conclusao, String data_de_inicio, String data_de_finalizacao)
        {
            this.id = id;
            this.descricao = descricao;
            this.nome_categoria = nome_categoria;
            this.estado_de_conclusao = estado_de_conclusao;
            this.data_de_inicio = data_de_inicio;
            this.data_de_finalizacao = data_de_finalizacao;
            InitializeComponent();
            lbCategoria.Text = nome_categoria;
            lbDescricao.Text = lbDescricao.Text + " " + descricao;
            lbEstado.Text = lbEstado.Text + " " + estado_de_conclusao;
            lbDataFinal.Text = lbDataFinal.Text + " " + data_de_finalizacao;
            ChangeComponentColor(nome_categoria);
        }

        //Abre uma Outra Tela com os Dados mais bem Detalhados
        //sendo possível editá-los a partir da mesma.
        private void ClickOnComponent()
        {

        }

        //Procedimento que muda as cores de cada cabeçalho de componente de acordo
        //com a categoria do mesmo.
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
                    painelCategoria.BackColor = Color.Gold;
                    lbCategoria.ForeColor = Color.White;
                    painelDescricao.BackColor = Color.BlanchedAlmond;
                    break;
                case "Família":
                    painelCategoria.BackColor = Color.Red;
                    lbCategoria.ForeColor = Color.White;
                    painelDescricao.BackColor = Color.Ivory;
                    
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
                    painelCategoria.BackColor = Color.Yellow;
                    break;
                case "Trabalho":
                    painelCategoria.BackColor = Color.SaddleBrown;
                    lbCategoria.ForeColor = Color.White;
                    break;
            }
                
        }
    }
}
