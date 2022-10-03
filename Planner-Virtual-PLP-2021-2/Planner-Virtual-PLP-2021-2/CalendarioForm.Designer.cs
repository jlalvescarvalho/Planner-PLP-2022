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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnProximaData = new System.Windows.Forms.Button();
            this.btnVoltarData = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(836, 589);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gerar relatórios de dados";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(639, 589);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Listar todas as Tarefas Registradas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnListarTudo_Click);
            // 
            // btnProximaData
            // 
            this.btnProximaData.Location = new System.Drawing.Point(992, 259);
            this.btnProximaData.Name = "btnProximaData";
            this.btnProximaData.Size = new System.Drawing.Size(20, 94);
            this.btnProximaData.TabIndex = 9;
            this.btnProximaData.Text = "próxima";
            this.btnProximaData.UseVisualStyleBackColor = true;
            this.btnProximaData.Click += new System.EventHandler(this.btnProximaData_Click);
            // 
            // btnVoltarData
            // 
            this.btnVoltarData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltarData.Location = new System.Drawing.Point(12, 259);
            this.btnVoltarData.Name = "btnVoltarData";
            this.btnVoltarData.Size = new System.Drawing.Size(20, 94);
            this.btnVoltarData.TabIndex = 10;
            this.btnVoltarData.Text = "voltar";
            this.btnVoltarData.UseVisualStyleBackColor = true;
            this.btnVoltarData.Click += new System.EventHandler(this.btnVoltarData_Click);
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
            this.label1.Size = new System.Drawing.Size(336, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Obs: para interagir com as datas, clique no escopo dos quadradinhos.";
            // 
            // Calendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1024, 645);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMes);
            this.Controls.Add(this.btnVoltarData);
            this.Controls.Add(this.lbAno);
            this.Controls.Add(this.btnProximaData);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.painelDeDias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calendario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Datas - Calendário Interativo";
            this.Load += new System.EventHandler(this.Calendario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel painelDeDias;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnProximaData;
        private System.Windows.Forms.Button btnVoltarData;
        private System.Windows.Forms.Label lbMes;
        private System.Windows.Forms.Label lbAno;
        private System.Windows.Forms.Label label1;
    }
}

