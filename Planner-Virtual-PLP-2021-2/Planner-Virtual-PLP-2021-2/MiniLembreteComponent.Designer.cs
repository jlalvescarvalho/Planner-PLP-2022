namespace Planner_Virtual_PLP_2021_2
{
    partial class MiniLembreteComponent
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.painelCabecalho = new System.Windows.Forms.FlowLayoutPanel();
            this.painelDataTarefa = new System.Windows.Forms.FlowLayoutPanel();
            this.painelMensagem = new System.Windows.Forms.FlowLayoutPanel();
            this.lbMensagem = new System.Windows.Forms.Label();
            this.lbDataTarefa = new System.Windows.Forms.Label();
            this.lbLembrete = new System.Windows.Forms.Label();
            this.painelCabecalho.SuspendLayout();
            this.painelDataTarefa.SuspendLayout();
            this.painelMensagem.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelCabecalho
            // 
            this.painelCabecalho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelCabecalho.Controls.Add(this.lbLembrete);
            this.painelCabecalho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.painelCabecalho.Location = new System.Drawing.Point(-1, -1);
            this.painelCabecalho.Name = "painelCabecalho";
            this.painelCabecalho.Size = new System.Drawing.Size(102, 26);
            this.painelCabecalho.TabIndex = 0;
            this.painelCabecalho.Click += new System.EventHandler(this.ClickOnLembrete);
            // 
            // painelDataTarefa
            // 
            this.painelDataTarefa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelDataTarefa.Controls.Add(this.lbDataTarefa);
            this.painelDataTarefa.Location = new System.Drawing.Point(-1, 24);
            this.painelDataTarefa.Name = "painelDataTarefa";
            this.painelDataTarefa.Size = new System.Drawing.Size(102, 47);
            this.painelDataTarefa.TabIndex = 1;
            this.painelDataTarefa.Click += new System.EventHandler(this.ClickOnLembrete);
            // 
            // painelMensagem
            // 
            this.painelMensagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelMensagem.Controls.Add(this.lbMensagem);
            this.painelMensagem.Location = new System.Drawing.Point(-1, 70);
            this.painelMensagem.Name = "painelMensagem";
            this.painelMensagem.Size = new System.Drawing.Size(102, 117);
            this.painelMensagem.TabIndex = 2;
            this.painelMensagem.Click += new System.EventHandler(this.ClickOnLembrete);
            // 
            // lbMensagem
            // 
            this.lbMensagem.AutoSize = true;
            this.lbMensagem.Location = new System.Drawing.Point(3, 0);
            this.lbMensagem.Name = "lbMensagem";
            this.lbMensagem.Size = new System.Drawing.Size(62, 13);
            this.lbMensagem.TabIndex = 0;
            this.lbMensagem.Text = "Mensagem:";
            this.lbMensagem.Click += new System.EventHandler(this.ClickOnLembrete);
            // 
            // lbDataTarefa
            // 
            this.lbDataTarefa.AutoSize = true;
            this.lbDataTarefa.Location = new System.Drawing.Point(3, 0);
            this.lbDataTarefa.Name = "lbDataTarefa";
            this.lbDataTarefa.Size = new System.Drawing.Size(93, 26);
            this.lbDataTarefa.TabIndex = 0;
            this.lbDataTarefa.Text = "Referente a tarefa do dia:";
            this.lbDataTarefa.Click += new System.EventHandler(this.ClickOnLembrete);
            // 
            // lbLembrete
            // 
            this.lbLembrete.AutoSize = true;
            this.lbLembrete.Location = new System.Drawing.Point(3, 0);
            this.lbLembrete.Name = "lbLembrete";
            this.lbLembrete.Size = new System.Drawing.Size(59, 13);
            this.lbLembrete.TabIndex = 0;
            this.lbLembrete.Text = "Lembrete";
            this.lbLembrete.Click += new System.EventHandler(this.ClickOnLembrete);
            // 
            // MiniLembreteComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.painelMensagem);
            this.Controls.Add(this.painelDataTarefa);
            this.Controls.Add(this.painelCabecalho);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "MiniLembreteComponent";
            this.Size = new System.Drawing.Size(100, 187);
            this.Click += new System.EventHandler(this.ClickOnLembrete);
            this.painelCabecalho.ResumeLayout(false);
            this.painelCabecalho.PerformLayout();
            this.painelDataTarefa.ResumeLayout(false);
            this.painelDataTarefa.PerformLayout();
            this.painelMensagem.ResumeLayout(false);
            this.painelMensagem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel painelCabecalho;
        private System.Windows.Forms.Label lbLembrete;
        private System.Windows.Forms.FlowLayoutPanel painelDataTarefa;
        private System.Windows.Forms.Label lbDataTarefa;
        private System.Windows.Forms.FlowLayoutPanel painelMensagem;
        private System.Windows.Forms.Label lbMensagem;
    }
}
