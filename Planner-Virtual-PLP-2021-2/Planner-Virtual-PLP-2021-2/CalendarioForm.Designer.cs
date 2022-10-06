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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.painelTitulo = new System.Windows.Forms.FlowLayoutPanel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnVoltarData = new System.Windows.Forms.Button();
            this.BtnProximaData = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.painelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // painelDeDias
            // 
            this.painelDeDias.BackColor = System.Drawing.Color.Transparent;
            this.painelDeDias.Location = new System.Drawing.Point(50, 108);
            this.painelDeDias.Name = "painelDeDias";
            this.painelDeDias.Size = new System.Drawing.Size(917, 531);
            this.painelDeDias.TabIndex = 0;
            // 
            // BtnToRelatorio
            // 
            this.BtnToRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnToRelatorio.Font = new System.Drawing.Font("Sofia Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnToRelatorio.Location = new System.Drawing.Point(753, 643);
            this.BtnToRelatorio.Name = "BtnToRelatorio";
            this.BtnToRelatorio.Size = new System.Drawing.Size(215, 58);
            this.BtnToRelatorio.TabIndex = 0;
            this.BtnToRelatorio.Text = "Gerar relatórios de dados";
            this.BtnToRelatorio.UseVisualStyleBackColor = true;
            this.BtnToRelatorio.Click += new System.EventHandler(this.BtnToRelatorio_Click);
            // 
            // BtnToLista
            // 
            this.BtnToLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnToLista.Font = new System.Drawing.Font("Sofia Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnToLista.Location = new System.Drawing.Point(532, 643);
            this.BtnToLista.Name = "BtnToLista";
            this.BtnToLista.Size = new System.Drawing.Size(215, 58);
            this.BtnToLista.TabIndex = 1;
            this.BtnToLista.Text = "Listar tudo que foi registrado";
            this.BtnToLista.UseVisualStyleBackColor = true;
            this.BtnToLista.Click += new System.EventHandler(this.BtnListarTudo_Click);
            // 
            // lbMes
            // 
            this.lbMes.AutoSize = true;
            this.lbMes.Font = new System.Drawing.Font("Oswald", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMes.Location = new System.Drawing.Point(415, 68);
            this.lbMes.Name = "lbMes";
            this.lbMes.Size = new System.Drawing.Size(53, 36);
            this.lbMes.TabIndex = 9;
            this.lbMes.Text = "Mês";
            // 
            // lbAno
            // 
            this.lbAno.AutoSize = true;
            this.lbAno.Font = new System.Drawing.Font("Oswald", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAno.Location = new System.Drawing.Point(536, 68);
            this.lbAno.Name = "lbAno";
            this.lbAno.Size = new System.Drawing.Size(50, 36);
            this.lbAno.TabIndex = 10;
            this.lbAno.Text = "Ano";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sofia Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Obs: para interagir com as datas, clique em seu cabeçalho.";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(50, 643);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(476, 67);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sofia Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(427, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Para interagir com os eventos em tela, basta clicar neles.";
            // 
            // painelTitulo
            // 
            this.painelTitulo.BackColor = System.Drawing.Color.RoyalBlue;
            this.painelTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.painelTitulo.Controls.Add(this.pictureBox1);
            this.painelTitulo.Controls.Add(this.lbTitulo);
            this.painelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelTitulo.ForeColor = System.Drawing.Color.White;
            this.painelTitulo.Location = new System.Drawing.Point(0, 0);
            this.painelTitulo.Name = "painelTitulo";
            this.painelTitulo.Size = new System.Drawing.Size(1016, 57);
            this.painelTitulo.TabIndex = 13;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Oswald", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(62, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(256, 60);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Planner Virtual";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Planner_Virtual_PLP_2021_2.Properties.Resources.icone_minimizar_blue;
            this.pictureBox3.Location = new System.Drawing.Point(904, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 53);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Planner_Virtual_PLP_2021_2.Properties.Resources.icone_fechar_blue;
            this.pictureBox2.Location = new System.Drawing.Point(960, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Planner_Virtual_PLP_2021_2.Properties.Resources.icone_calendario_blue;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // BtnVoltarData
            // 
            this.BtnVoltarData.BackColor = System.Drawing.Color.Transparent;
            this.BtnVoltarData.BackgroundImage = global::Planner_Virtual_PLP_2021_2.Properties.Resources.seta_esq;
            this.BtnVoltarData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnVoltarData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVoltarData.FlatAppearance.BorderSize = 0;
            this.BtnVoltarData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVoltarData.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnVoltarData.Location = new System.Drawing.Point(6, 337);
            this.BtnVoltarData.Name = "BtnVoltarData";
            this.BtnVoltarData.Size = new System.Drawing.Size(40, 75);
            this.BtnVoltarData.TabIndex = 10;
            this.BtnVoltarData.UseVisualStyleBackColor = false;
            this.BtnVoltarData.Click += new System.EventHandler(this.BtnVoltarData_Click);
            // 
            // BtnProximaData
            // 
            this.BtnProximaData.BackgroundImage = global::Planner_Virtual_PLP_2021_2.Properties.Resources.seta_dir;
            this.BtnProximaData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnProximaData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProximaData.FlatAppearance.BorderSize = 0;
            this.BtnProximaData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProximaData.Location = new System.Drawing.Point(971, 337);
            this.BtnProximaData.Name = "BtnProximaData";
            this.BtnProximaData.Size = new System.Drawing.Size(40, 75);
            this.BtnProximaData.TabIndex = 9;
            this.BtnProximaData.UseVisualStyleBackColor = false;
            this.BtnProximaData.Click += new System.EventHandler(this.BtnProximaData_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sofia Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "O dia atual está destacado em azul escuro.";
            // 
            // Calendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1016, 713);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.painelTitulo);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lbMes);
            this.Controls.Add(this.BtnVoltarData);
            this.Controls.Add(this.lbAno);
            this.Controls.Add(this.BtnProximaData);
            this.Controls.Add(this.BtnToLista);
            this.Controls.Add(this.BtnToRelatorio);
            this.Controls.Add(this.painelDeDias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calendario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Datas - Calendário Interativo";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.painelTitulo.ResumeLayout(false);
            this.painelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel painelTitulo;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}

