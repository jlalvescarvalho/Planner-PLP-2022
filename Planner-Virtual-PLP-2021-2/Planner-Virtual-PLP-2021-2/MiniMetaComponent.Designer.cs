namespace Planner_Virtual_PLP_2021_2
{
    partial class MiniMetaComponent
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
            this.painelCategoria = new System.Windows.Forms.FlowLayoutPanel();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.painelDescricao = new System.Windows.Forms.FlowLayoutPanel();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.painelEstado = new System.Windows.Forms.FlowLayoutPanel();
            this.lbEstado = new System.Windows.Forms.Label();
            this.painelDataFinal = new System.Windows.Forms.FlowLayoutPanel();
            this.lbDataFinal = new System.Windows.Forms.Label();
            this.painelTipo = new System.Windows.Forms.FlowLayoutPanel();
            this.lbTipo = new System.Windows.Forms.Label();
            this.painelCategoria.SuspendLayout();
            this.painelDescricao.SuspendLayout();
            this.painelEstado.SuspendLayout();
            this.painelDataFinal.SuspendLayout();
            this.painelTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelCategoria
            // 
            this.painelCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelCategoria.Controls.Add(this.lbCategoria);
            this.painelCategoria.Location = new System.Drawing.Point(0, 0);
            this.painelCategoria.Name = "painelCategoria";
            this.painelCategoria.Size = new System.Drawing.Size(100, 30);
            this.painelCategoria.TabIndex = 2;
            this.painelCategoria.Click += new System.EventHandler(this.ClickOnMeta);
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoria.Location = new System.Drawing.Point(3, 0);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(61, 13);
            this.lbCategoria.TabIndex = 0;
            this.lbCategoria.Text = "Categoria";
            this.lbCategoria.Click += new System.EventHandler(this.ClickOnMeta);
            // 
            // painelDescricao
            // 
            this.painelDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelDescricao.Controls.Add(this.lbDescricao);
            this.painelDescricao.Location = new System.Drawing.Point(0, 16);
            this.painelDescricao.Name = "painelDescricao";
            this.painelDescricao.Size = new System.Drawing.Size(100, 178);
            this.painelDescricao.TabIndex = 3;
            this.painelDescricao.Click += new System.EventHandler(this.ClickOnMeta);
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Location = new System.Drawing.Point(3, 0);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(58, 13);
            this.lbDescricao.TabIndex = 1;
            this.lbDescricao.Text = "Descrição:";
            this.lbDescricao.Click += new System.EventHandler(this.ClickOnMeta);
            // 
            // painelEstado
            // 
            this.painelEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelEstado.Controls.Add(this.lbEstado);
            this.painelEstado.Location = new System.Drawing.Point(0, 193);
            this.painelEstado.Name = "painelEstado";
            this.painelEstado.Size = new System.Drawing.Size(100, 55);
            this.painelEstado.TabIndex = 4;
            this.painelEstado.Click += new System.EventHandler(this.ClickOnMeta);
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(3, 0);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(43, 13);
            this.lbEstado.TabIndex = 0;
            this.lbEstado.Text = "Estado:";
            this.lbEstado.Click += new System.EventHandler(this.ClickOnMeta);
            // 
            // painelDataFinal
            // 
            this.painelDataFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelDataFinal.Controls.Add(this.lbDataFinal);
            this.painelDataFinal.Location = new System.Drawing.Point(0, 247);
            this.painelDataFinal.Name = "painelDataFinal";
            this.painelDataFinal.Size = new System.Drawing.Size(100, 60);
            this.painelDataFinal.TabIndex = 5;
            this.painelDataFinal.Click += new System.EventHandler(this.ClickOnMeta);
            // 
            // lbDataFinal
            // 
            this.lbDataFinal.AutoSize = true;
            this.lbDataFinal.Location = new System.Drawing.Point(3, 0);
            this.lbDataFinal.Name = "lbDataFinal";
            this.lbDataFinal.Size = new System.Drawing.Size(71, 26);
            this.lbDataFinal.TabIndex = 0;
            this.lbDataFinal.Text = "Deve ser cumprida até:";
            this.lbDataFinal.Click += new System.EventHandler(this.ClickOnMeta);
            // 
            // painelTipo
            // 
            this.painelTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelTipo.Controls.Add(this.lbTipo);
            this.painelTipo.Location = new System.Drawing.Point(0, 306);
            this.painelTipo.Name = "painelTipo";
            this.painelTipo.Size = new System.Drawing.Size(100, 20);
            this.painelTipo.TabIndex = 6;
            this.painelTipo.Click += new System.EventHandler(this.ClickOnMeta);
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(3, 0);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(58, 13);
            this.lbTipo.TabIndex = 0;
            this.lbTipo.Text = "Tipo: Meta";
            this.lbTipo.Click += new System.EventHandler(this.ClickOnMeta);
            // 
            // MiniMetaComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.painelTipo);
            this.Controls.Add(this.painelDataFinal);
            this.Controls.Add(this.painelEstado);
            this.Controls.Add(this.painelDescricao);
            this.Controls.Add(this.painelCategoria);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "MiniMetaComponent";
            this.Size = new System.Drawing.Size(99, 325);
            this.Click += new System.EventHandler(this.ClickOnMeta);
            this.painelCategoria.ResumeLayout(false);
            this.painelCategoria.PerformLayout();
            this.painelDescricao.ResumeLayout(false);
            this.painelDescricao.PerformLayout();
            this.painelEstado.ResumeLayout(false);
            this.painelEstado.PerformLayout();
            this.painelDataFinal.ResumeLayout(false);
            this.painelDataFinal.PerformLayout();
            this.painelTipo.ResumeLayout(false);
            this.painelTipo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel painelCategoria;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.FlowLayoutPanel painelDescricao;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.FlowLayoutPanel painelEstado;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.FlowLayoutPanel painelDataFinal;
        private System.Windows.Forms.Label lbDataFinal;
        private System.Windows.Forms.FlowLayoutPanel painelTipo;
        private System.Windows.Forms.Label lbTipo;
    }
}
