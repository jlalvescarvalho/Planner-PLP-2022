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
    public partial class Calendario : Form
    {
        int mes, ano;
        public Calendario()
        {
            InitializeComponent();
            MostrarDias();
        }

        private void MostrarDias()
        {
            DateTime dataAtual = DateTime.Now;
            mes = dataAtual.Month;
            ano = dataAtual.Year;

            lbMes.Text = conversorMes(mes.ToString());
            lbAno.Text = ano.ToString();

            int dias = DateTime.DaysInMonth(ano, mes);

            for (int i = 1; i <= dias; i++)
            {
                DateTime novaData = new DateTime(ano, mes, i);
                DiasComponent ucdias = new DiasComponent();
                ucdias.CarregarData(novaData);
                painelDeDias.Controls.Add(ucdias);
            }
        }

        private void BtnVoltarData_Click(object sender, EventArgs e)
        {
            painelDeDias.Controls.Clear();
            mes--;
            if (mes < 1)
            {
                ano--;
                lbAno.Text = ano.ToString();
                mes = 12;
            }
            lbMes.Text = conversorMes(mes.ToString());

            int dias = DateTime.DaysInMonth(ano, mes);
            for (int i = 1; i <= dias; i++)
            {
                DateTime novaData = new DateTime(ano, mes, i);
                DiasComponent ucdias = new DiasComponent();
                ucdias.CarregarData(novaData);
                painelDeDias.Controls.Add(ucdias);
            }

        }

        private void BtnProximaData_Click(object sender, EventArgs e)
        {
            painelDeDias.Controls.Clear();
            mes++;
            if (mes > 12)
            {
                ano++;
                lbAno.Text = ano.ToString();
                mes = 1;
            }
            lbMes.Text = conversorMes(mes.ToString());

            int dias = DateTime.DaysInMonth(ano, mes);
            for (int i = 1; i <= dias; i++)
            {
                DateTime novaData = new DateTime(ano, mes, i);
                DiasComponent ucdias = new DiasComponent();
                ucdias.CarregarData(novaData);
                painelDeDias.Controls.Add(ucdias);
            }
        }

        private void BtnListarTudo_Click(object sender, EventArgs e)
        {
            ListaForm listaForm = new ListaForm();
            listaForm.ShowDialog();
        }

        private void BtnToRelatorio_Click(object sender, EventArgs e)
        {
            RelatorioForm relatorioForm = new RelatorioForm();
            relatorioForm.ShowDialog();
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
                    return "Mês desconhecido!";
            }
        }
    }
}
