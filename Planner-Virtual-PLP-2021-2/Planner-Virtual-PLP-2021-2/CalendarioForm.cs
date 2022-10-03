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
        }

        private void Calendario_Load(object sender, EventArgs e)
        {
            mostrarDias();
        }

        private void mostrarDias()
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
                ucdias.displayData(novaData);
                painelDeDias.Controls.Add(ucdias);
            }

        }

        private void btnVoltarData_Click(object sender, EventArgs e)
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
                ucdias.displayData(novaData);
                painelDeDias.Controls.Add(ucdias);
            }

        }

        private void btnProximaData_Click(object sender, EventArgs e)
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
                ucdias.displayData(novaData);
                painelDeDias.Controls.Add(ucdias);
            }
        }

        private void btnListarTudo_Click(object sender, EventArgs e)
        {

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
