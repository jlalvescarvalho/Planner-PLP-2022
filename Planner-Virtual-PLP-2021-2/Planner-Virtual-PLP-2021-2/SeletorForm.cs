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
    public partial class SeletorForm : Form
    {
        DateTime dataPassada;
        public SeletorForm(DateTime dataEscolhida)
        {
            dataPassada = dataEscolhida;
            InitializeComponent();
        }

        private void btnToMeta_Click(object sender, EventArgs e)
        {
            this.Close();
            MetaForm metaForm = new MetaForm(dataPassada);
            metaForm.ShowDialog();
        }

        private void btnToTarefa_Click(object sender, EventArgs e)
        {
            TarefaForm tarefaForm = new TarefaForm(dataPassada);
            tarefaForm.ShowDialog();
            this.Close();
        }

        private void btnToLembrete_Click(object sender, EventArgs e)
        {
            LembreteForm lembreteForm = new LembreteForm();
            lembreteForm.ShowDialog();
            this.Close();
        }

        private void btnToLista_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
