namespace Planner_Virtual_PLP_2021_2
{
    partial class ListaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.painelDeMetas = new System.Windows.Forms.FlowLayoutPanel();
            this.painelDeTarefas = new System.Windows.Forms.FlowLayoutPanel();
            this.painelDeLembretes = new System.Windows.Forms.FlowLayoutPanel();
            this.lbMetas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // painelDeMetas
            // 
            this.painelDeMetas.Location = new System.Drawing.Point(5, 38);
            this.painelDeMetas.Name = "painelDeMetas";
            this.painelDeMetas.Size = new System.Drawing.Size(261, 407);
            this.painelDeMetas.TabIndex = 5;
            // 
            // painelDeTarefas
            // 
            this.painelDeTarefas.Location = new System.Drawing.Point(272, 38);
            this.painelDeTarefas.Name = "painelDeTarefas";
            this.painelDeTarefas.Size = new System.Drawing.Size(261, 407);
            this.painelDeTarefas.TabIndex = 6;
            // 
            // painelDeLembretes
            // 
            this.painelDeLembretes.Location = new System.Drawing.Point(539, 38);
            this.painelDeLembretes.Name = "painelDeLembretes";
            this.painelDeLembretes.Size = new System.Drawing.Size(261, 407);
            this.painelDeLembretes.TabIndex = 6;
            // 
            // lbMetas
            // 
            this.lbMetas.AutoSize = true;
            this.lbMetas.Location = new System.Drawing.Point(77, 22);
            this.lbMetas.Name = "lbMetas";
            this.lbMetas.Size = new System.Drawing.Size(114, 13);
            this.lbMetas.TabIndex = 7;
            this.lbMetas.Text = "Lista de Metas Criadas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lista de Tarefas Criadas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(607, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lista de Lembretes Criados";
            // 
            // ListaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMetas);
            this.Controls.Add(this.painelDeLembretes);
            this.Controls.Add(this.painelDeTarefas);
            this.Controls.Add(this.painelDeMetas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListaForm";
            this.ShowIcon = false;
            this.Text = "ListaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel painelDeMetas;
        private System.Windows.Forms.FlowLayoutPanel painelDeTarefas;
        private System.Windows.Forms.FlowLayoutPanel painelDeLembretes;
        private System.Windows.Forms.Label lbMetas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}