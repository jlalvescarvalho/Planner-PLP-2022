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
            this.lbMes = new System.Windows.Forms.Label();
            this.lbAno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.BtnProximaData = new System.Windows.Forms.PictureBox();
            this.BtnVoltarData = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnProximaData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVoltarData)).BeginInit();
            this.SuspendLayout();
            // 
            // painelDeDias
            // 
            this.painelDeDias.BackColor = System.Drawing.Color.Transparent;
            this.painelDeDias.Location = new System.Drawing.Point(58, 88);
            this.painelDeDias.Name = "painelDeDias";
            this.painelDeDias.Size = new System.Drawing.Size(917, 492);
            this.painelDeDias.TabIndex = 0;
            // 
            // BtnToRelatorio
            // 
            this.BtnToRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnToRelatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
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
            this.BtnToLista.AutoEllipsis = true;
            this.BtnToLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnToLista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnToLista.Location = new System.Drawing.Point(639, 589);
            this.BtnToLista.Name = "BtnToLista";
            this.BtnToLista.Size = new System.Drawing.Size(191, 44);
            this.BtnToLista.TabIndex = 1;
            this.BtnToLista.Text = "Listar todas as Tarefas Registradas";
            this.BtnToLista.UseVisualStyleBackColor = true;
            this.BtnToLista.Click += new System.EventHandler(this.BtnListarTudo_Click);
            // 
            // lbMes
            // 
            this.lbMes.AutoSize = true;
            this.lbMes.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMes.Location = new System.Drawing.Point(398, 45);
            this.lbMes.Name = "lbMes";
            this.lbMes.Size = new System.Drawing.Size(64, 43);
            this.lbMes.TabIndex = 9;
            this.lbMes.Text = "Mês";
            // 
            // lbAno
            // 
            this.lbAno.AutoSize = true;
            this.lbAno.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAno.Location = new System.Drawing.Point(540, 45);
            this.lbAno.Name = "lbAno";
            this.lbAno.Size = new System.Drawing.Size(68, 43);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 33);
            this.panel1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nachlieli CLM", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Planner";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::Planner_Virtual_PLP_2021_2.Properties.Resources.minimizar;
            this.btnMinimizar.Location = new System.Drawing.Point(950, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Image = global::Planner_Virtual_PLP_2021_2.Properties.Resources.fechar;
            this.btnFechar.Location = new System.Drawing.Point(992, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(25, 25);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFechar.TabIndex = 0;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // BtnProximaData
            // 
            this.BtnProximaData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProximaData.Image = global::Planner_Virtual_PLP_2021_2.Properties.Resources.avancar;
            this.BtnProximaData.Location = new System.Drawing.Point(992, 316);
            this.BtnProximaData.Name = "BtnProximaData";
            this.BtnProximaData.Size = new System.Drawing.Size(25, 25);
            this.BtnProximaData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnProximaData.TabIndex = 13;
            this.BtnProximaData.TabStop = false;
            this.BtnProximaData.Click += new System.EventHandler(this.BtnProximaData_Click_1);
            // 
            // BtnVoltarData
            // 
            this.BtnVoltarData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVoltarData.Image = global::Planner_Virtual_PLP_2021_2.Properties.Resources.voltar;
            this.BtnVoltarData.Location = new System.Drawing.Point(9, 316);
            this.BtnVoltarData.Name = "BtnVoltarData";
            this.BtnVoltarData.Size = new System.Drawing.Size(25, 25);
            this.BtnVoltarData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnVoltarData.TabIndex = 3;
            this.BtnVoltarData.TabStop = false;
            this.BtnVoltarData.Click += new System.EventHandler(this.BtnVoltarData_Click_1);
            // 
            // Calendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1024, 645);
            this.Controls.Add(this.BtnProximaData);
            this.Controls.Add(this.BtnVoltarData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMes);
            this.Controls.Add(this.lbAno);
            this.Controls.Add(this.BtnToLista);
            this.Controls.Add(this.BtnToRelatorio);
            this.Controls.Add(this.painelDeDias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calendario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Datas - Calendário Interativo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnProximaData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVoltarData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel painelDeDias;
        private System.Windows.Forms.Button BtnToRelatorio;
        private System.Windows.Forms.Button BtnToLista;
        private System.Windows.Forms.Label lbMes;
        private System.Windows.Forms.Label lbAno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox BtnVoltarData;
        private System.Windows.Forms.PictureBox BtnProximaData;
    }
}

