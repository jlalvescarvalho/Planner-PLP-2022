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
    public partial class MiniMetaComponent : UserControl
    {
        String id, descricao, nome_categoria, estado_de_conclusao, data_de_efetivacao;
        public MiniMetaComponent(String id, String descricao, String nome_categoria, 
            String estado_de_conclusao, String data_de_efetivacao)
        {
            this.id = id;
            this.descricao = descricao;
            this.nome_categoria = nome_categoria;
            this.estado_de_conclusao = estado_de_conclusao;
            InitializeComponent();
            lbCategoria.Text = nome_categoria;
            lbDescricao.Text = lbDescricao.Text + " " + descricao;
            lbEstado.Text = lbEstado.Text + " " + estado_de_conclusao;
            lbDataFinal.Text = lbDataFinal.Text + " " + data_de_efetivacao;
            //ChangeComponentColor(nome_categoria);
        }
    }
}
