namespace Planner_Virtual_PLP_2021_2
{
    partial class DiasComponent
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
            this.lbdias = new System.Windows.Forms.Label();
            this.painelCabecalho = new System.Windows.Forms.FlowLayoutPanel();
            this.painelDeEventos = new System.Windows.Forms.FlowLayoutPanel();
            this.painelCabecalho.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbdias
            // 
            this.lbdias.AutoSize = true;
            this.lbdias.Font = new System.Drawing.Font("Sofia Pro Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdias.ForeColor = System.Drawing.Color.Black;
            this.lbdias.Location = new System.Drawing.Point(3, 0);
            this.lbdias.Name = "lbdias";
            this.lbdias.Size = new System.Drawing.Size(24, 17);
            this.lbdias.TabIndex = 0;
            this.lbdias.Text = "00";
            this.lbdias.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DiasComponent_MouseClick);
            // 
            // painelCabecalho
            // 
            this.painelCabecalho.BackColor = System.Drawing.Color.Transparent;
            this.painelCabecalho.Controls.Add(this.lbdias);
            this.painelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.painelCabecalho.Name = "painelCabecalho";
            this.painelCabecalho.Size = new System.Drawing.Size(125, 22);
            this.painelCabecalho.TabIndex = 1;
            this.painelCabecalho.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DiasComponent_MouseClick);
            // 
            // painelDeEventos
            // 
            this.painelDeEventos.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.painelDeEventos.AutoScroll = true;
            this.painelDeEventos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelDeEventos.Location = new System.Drawing.Point(0, 19);
            this.painelDeEventos.Name = "painelDeEventos";
            this.painelDeEventos.Size = new System.Drawing.Size(124, 80);
            this.painelDeEventos.TabIndex = 2;
            this.painelDeEventos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DiasComponent_MouseClick);
            // 
            // DiasComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.painelDeEventos);
            this.Controls.Add(this.painelCabecalho);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "DiasComponent";
            this.Size = new System.Drawing.Size(123, 98);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DiasComponent_MouseClick);
            this.painelCabecalho.ResumeLayout(false);
            this.painelCabecalho.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbdias;
        private System.Windows.Forms.FlowLayoutPanel painelCabecalho;
        private System.Windows.Forms.FlowLayoutPanel painelDeEventos;
    }
}
