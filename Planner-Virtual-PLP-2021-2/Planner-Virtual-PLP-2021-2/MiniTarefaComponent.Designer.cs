namespace Planner_Virtual_PLP_2021_2
{
    partial class MiniTarefaComponent
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
            this.lbCategoria = new System.Windows.Forms.Label();
            this.painelCategoria = new System.Windows.Forms.FlowLayoutPanel();
            this.painelDescricao = new System.Windows.Forms.FlowLayoutPanel();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.lbEstado = new System.Windows.Forms.Label();
            this.lbDataFinal = new System.Windows.Forms.Label();
            this.painelTipo = new System.Windows.Forms.FlowLayoutPanel();
            this.lbTipo = new System.Windows.Forms.Label();
            this.painelDataFinal = new System.Windows.Forms.FlowLayoutPanel();
            this.painelEstado = new System.Windows.Forms.FlowLayoutPanel();
            this.painelCategoria.SuspendLayout();
            this.painelDescricao.SuspendLayout();
            this.painelTipo.SuspendLayout();
            this.painelDataFinal.SuspendLayout();
            this.painelEstado.SuspendLayout();
            this.SuspendLayout();
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
            // 
            // painelCategoria
            // 
            this.painelCategoria.Controls.Add(this.lbCategoria);
            this.painelCategoria.Location = new System.Drawing.Point(0, 0);
            this.painelCategoria.Name = "painelCategoria";
            this.painelCategoria.Size = new System.Drawing.Size(100, 18);
            this.painelCategoria.TabIndex = 1;
            // 
            // painelDescricao
            // 
            this.painelDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelDescricao.Controls.Add(this.lbDescricao);
            this.painelDescricao.Location = new System.Drawing.Point(0, 16);
            this.painelDescricao.Name = "painelDescricao";
            this.painelDescricao.Size = new System.Drawing.Size(100, 178);
            this.painelDescricao.TabIndex = 2;
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Location = new System.Drawing.Point(3, 0);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(58, 13);
            this.lbDescricao.TabIndex = 1;
            this.lbDescricao.Text = "Descrição:";
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(3, 0);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(43, 13);
            this.lbEstado.TabIndex = 0;
            this.lbEstado.Text = "Estado:";
            // 
            // lbDataFinal
            // 
            this.lbDataFinal.AutoSize = true;
            this.lbDataFinal.Location = new System.Drawing.Point(3, 0);
            this.lbDataFinal.Name = "lbDataFinal";
            this.lbDataFinal.Size = new System.Drawing.Size(48, 13);
            this.lbDataFinal.TabIndex = 0;
            this.lbDataFinal.Text = "Término:";
            // 
            // painelTipo
            // 
            this.painelTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelTipo.Controls.Add(this.lbTipo);
            this.painelTipo.Location = new System.Drawing.Point(0, 323);
            this.painelTipo.Name = "painelTipo";
            this.painelTipo.Size = new System.Drawing.Size(100, 19);
            this.painelTipo.TabIndex = 3;
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(3, 0);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(65, 13);
            this.lbTipo.TabIndex = 0;
            this.lbTipo.Text = "Tipo: Tarefa";
            // 
            // painelDataFinal
            // 
            this.painelDataFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelDataFinal.Controls.Add(this.lbDataFinal);
            this.painelDataFinal.Location = new System.Drawing.Point(0, 260);
            this.painelDataFinal.Name = "painelDataFinal";
            this.painelDataFinal.Size = new System.Drawing.Size(100, 57);
            this.painelDataFinal.TabIndex = 2;
            // 
            // painelEstado
            // 
            this.painelEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelEstado.Controls.Add(this.lbEstado);
            this.painelEstado.Location = new System.Drawing.Point(0, 199);
            this.painelEstado.Name = "painelEstado";
            this.painelEstado.Size = new System.Drawing.Size(100, 55);
            this.painelEstado.TabIndex = 2;
            // 
            // MiniTarefaComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.painelTipo);
            this.Controls.Add(this.painelEstado);
            this.Controls.Add(this.painelDataFinal);
            this.Controls.Add(this.painelDescricao);
            this.Controls.Add(this.painelCategoria);
            this.Name = "MiniTarefaComponent";
            this.Size = new System.Drawing.Size(98, 341);
            this.painelCategoria.ResumeLayout(false);
            this.painelCategoria.PerformLayout();
            this.painelDescricao.ResumeLayout(false);
            this.painelDescricao.PerformLayout();
            this.painelTipo.ResumeLayout(false);
            this.painelTipo.PerformLayout();
            this.painelDataFinal.ResumeLayout(false);
            this.painelDataFinal.PerformLayout();
            this.painelEstado.ResumeLayout(false);
            this.painelEstado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.FlowLayoutPanel painelCategoria;
        private System.Windows.Forms.FlowLayoutPanel painelDescricao;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.Label lbDataFinal;
        private System.Windows.Forms.FlowLayoutPanel painelTipo;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.FlowLayoutPanel painelDataFinal;
        private System.Windows.Forms.FlowLayoutPanel painelEstado;
    }
}
