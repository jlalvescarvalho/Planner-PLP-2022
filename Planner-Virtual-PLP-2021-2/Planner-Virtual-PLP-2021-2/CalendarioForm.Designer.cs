namespace Planner_Virtual_PLP_2021_2
{
    partial class Calendario
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendario));
            this.painelDeDias = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnToRelatorio = new System.Windows.Forms.Button();
            this.BtnToLista = new System.Windows.Forms.Button();
            this.BtnProximaData = new System.Windows.Forms.Button();
            this.BtnVoltarData = new System.Windows.Forms.Button();
            this.lbMes = new System.Windows.Forms.Label();
            this.lbAno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // painelDeDias
            // 
            this.painelDeDias.BackColor = System.Drawing.Color.Transparent;
            this.painelDeDias.Location = new System.Drawing.Point(58, 49);
            this.painelDeDias.Name = "painelDeDias";
            this.painelDeDias.Size = new System.Drawing.Size(917, 531);
            this.painelDeDias.TabIndex = 0;
            // 
            // BtnToRelatorio
            // 
            this.BtnToRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnToRelatorio.Location = new System.Drawing.Point(836, 589);
            this.BtnToRelatorio.Name = "BtnToRelatorio";
            this.BtnToRelatorio.Size = new System.Drawing.Size(139, 44);
            this.BtnToRelatorio.TabIndex = 0;
            this.BtnToRelatorio.Text = "Gerar relatórios de dados";
            this.BtnToRelatorio.UseVisualStyleBackColor = true;
            this.BtnToRelatorio.Click += new System.EventHandler(this.BtnToRelatorio_Click);
            // 
            // BtnToLista
            // 
            this.BtnToLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnToLista.Location = new System.Drawing.Point(639, 589);
            this.BtnToLista.Name = "BtnToLista";
            this.BtnToLista.Size = new System.Drawing.Size(191, 44);
            this.BtnToLista.TabIndex = 1;
            this.BtnToLista.Text = "Listar todas as Tarefas Registradas";
            this.BtnToLista.UseVisualStyleBackColor = true;
            this.BtnToLista.Click += new System.EventHandler(this.BtnListarTudo_Click);
            // 
            // BtnProximaData
            // 
            this.BtnProximaData.Location = new System.Drawing.Point(992, 259);
            this.BtnProximaData.Name = "BtnProximaData";
            this.BtnProximaData.Size = new System.Drawing.Size(20, 94);
            this.BtnProximaData.TabIndex = 9;
            this.BtnProximaData.Text = "próxima";
            this.BtnProximaData.UseVisualStyleBackColor = true;
            this.BtnProximaData.Click += new System.EventHandler(this.BtnProximaData_Click);
            // 
            // BtnVoltarData
            // 
            this.BtnVoltarData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVoltarData.Location = new System.Drawing.Point(12, 259);
            this.BtnVoltarData.Name = "BtnVoltarData";
            this.BtnVoltarData.Size = new System.Drawing.Size(20, 94);
            this.BtnVoltarData.TabIndex = 10;
            this.BtnVoltarData.Text = "voltar";
            this.BtnVoltarData.UseVisualStyleBackColor = true;
            this.BtnVoltarData.Click += new System.EventHandler(this.BtnVoltarData_Click);
            // 
            // lbMes
            // 
            this.lbMes.AutoSize = true;
            this.lbMes.Font = new System.Drawing.Font("Minion Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMes.Location = new System.Drawing.Point(416, 9);
            this.lbMes.Name = "lbMes";
            this.lbMes.Size = new System.Drawing.Size(55, 33);
            this.lbMes.TabIndex = 9;
            this.lbMes.Text = "Mês";
            // 
            // lbAno
            // 
            this.lbAno.AutoSize = true;
            this.lbAno.Font = new System.Drawing.Font("Minion Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAno.Location = new System.Drawing.Point(539, 9);
            this.lbAno.Name = "lbAno";
            this.lbAno.Size = new System.Drawing.Size(59, 33);
            this.lbAno.TabIndex = 10;
            this.lbAno.Text = "Ano";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 583);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Obs: para interagir com as datas, clique no cabeçalho dos quadradinhos.";
            // 
            // Calendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1024, 645);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMes);
            this.Controls.Add(this.BtnVoltarData);
            this.Controls.Add(this.lbAno);
            this.Controls.Add(this.BtnProximaData);
            this.Controls.Add(this.BtnToLista);
            this.Controls.Add(this.BtnToRelatorio);
            this.Controls.Add(this.painelDeDias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calendario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Datas - Calendário Interativo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel painelDeDias;
        private System.Windows.Forms.Button BtnToRelatorio;
        private System.Windows.Forms.Button BtnToLista;
        private System.Windows.Forms.Button BtnProximaData;
        private System.Windows.Forms.Button BtnVoltarData;
        private System.Windows.Forms.Label lbMes;
        private System.Windows.Forms.Label lbAno;
        private System.Windows.Forms.Label label1;
    }
}

