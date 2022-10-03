namespace Planner_Virtual_PLP_2021_2
{
    partial class SeletorForm
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
            this.btnToMeta = new System.Windows.Forms.Button();
            this.btnToTarefa = new System.Windows.Forms.Button();
            this.btnToLembrete = new System.Windows.Forms.Button();
            this.btnToLista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToMeta
            // 
            this.btnToMeta.Location = new System.Drawing.Point(12, 12);
            this.btnToMeta.Name = "btnToMeta";
            this.btnToMeta.Size = new System.Drawing.Size(214, 23);
            this.btnToMeta.TabIndex = 0;
            this.btnToMeta.Text = "Adicionar uma Meta até esta Data";
            this.btnToMeta.UseVisualStyleBackColor = true;
            this.btnToMeta.Click += new System.EventHandler(this.btnToMeta_Click);
            // 
            // btnToTarefa
            // 
            this.btnToTarefa.Location = new System.Drawing.Point(12, 41);
            this.btnToTarefa.Name = "btnToTarefa";
            this.btnToTarefa.Size = new System.Drawing.Size(214, 23);
            this.btnToTarefa.TabIndex = 1;
            this.btnToTarefa.Text = "Adicionar uma Tarefa à esta Data";
            this.btnToTarefa.UseVisualStyleBackColor = true;
            this.btnToTarefa.Click += new System.EventHandler(this.btnToTarefa_Click);
            // 
            // btnToLembrete
            // 
            this.btnToLembrete.Location = new System.Drawing.Point(12, 70);
            this.btnToLembrete.Name = "btnToLembrete";
            this.btnToLembrete.Size = new System.Drawing.Size(214, 23);
            this.btnToLembrete.TabIndex = 2;
            this.btnToLembrete.Text = "Adicionar um Lembrete à esta Data";
            this.btnToLembrete.UseVisualStyleBackColor = true;
            this.btnToLembrete.Click += new System.EventHandler(this.btnToLembrete_Click);
            // 
            // btnToLista
            // 
            this.btnToLista.Location = new System.Drawing.Point(12, 99);
            this.btnToLista.Name = "btnToLista";
            this.btnToLista.Size = new System.Drawing.Size(214, 23);
            this.btnToLista.TabIndex = 3;
            this.btnToLista.Text = "Listar todos os eventos desta Data";
            this.btnToLista.UseVisualStyleBackColor = true;
            this.btnToLista.Click += new System.EventHandler(this.btnToLista_Click);
            // 
            // SeletorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 134);
            this.Controls.Add(this.btnToLista);
            this.Controls.Add(this.btnToLembrete);
            this.Controls.Add(this.btnToTarefa);
            this.Controls.Add(this.btnToMeta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SeletorForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecione uma ação abaixo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToMeta;
        private System.Windows.Forms.Button btnToTarefa;
        private System.Windows.Forms.Button btnToLembrete;
        private System.Windows.Forms.Button btnToLista;
    }
}