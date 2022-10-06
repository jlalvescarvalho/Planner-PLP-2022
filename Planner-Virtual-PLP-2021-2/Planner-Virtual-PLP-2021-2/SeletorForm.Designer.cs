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
            this.BtnToMeta = new System.Windows.Forms.Button();
            this.BtnToTarefa = new System.Windows.Forms.Button();
            this.BtnToLista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnToMeta
            // 
            this.BtnToMeta.Location = new System.Drawing.Point(12, 12);
            this.BtnToMeta.Name = "BtnToMeta";
            this.BtnToMeta.Size = new System.Drawing.Size(214, 23);
            this.BtnToMeta.TabIndex = 0;
            this.BtnToMeta.Text = "Adicionar uma Meta até esta Data";
            this.BtnToMeta.UseVisualStyleBackColor = true;
            this.BtnToMeta.Click += new System.EventHandler(this.BtnToMeta_Click);
            // 
            // BtnToTarefa
            // 
            this.BtnToTarefa.Location = new System.Drawing.Point(12, 41);
            this.BtnToTarefa.Name = "BtnToTarefa";
            this.BtnToTarefa.Size = new System.Drawing.Size(214, 23);
            this.BtnToTarefa.TabIndex = 1;
            this.BtnToTarefa.Text = "Adicionar uma Tarefa à esta Data";
            this.BtnToTarefa.UseVisualStyleBackColor = true;
            this.BtnToTarefa.Click += new System.EventHandler(this.BtnToTarefa_Click);
            // 
            // BtnToLista
            // 
            this.BtnToLista.Location = new System.Drawing.Point(12, 70);
            this.BtnToLista.Name = "BtnToLista";
            this.BtnToLista.Size = new System.Drawing.Size(214, 23);
            this.BtnToLista.TabIndex = 3;
            this.BtnToLista.Text = "Listar todos os eventos desta Data";
            this.BtnToLista.UseVisualStyleBackColor = true;
            this.BtnToLista.Click += new System.EventHandler(this.BtnToLista_Click);
            // 
            // SeletorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 106);
            this.Controls.Add(this.BtnToLista);
            this.Controls.Add(this.BtnToTarefa);
            this.Controls.Add(this.BtnToMeta);
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

        private System.Windows.Forms.Button BtnToMeta;
        private System.Windows.Forms.Button BtnToTarefa;
        private System.Windows.Forms.Button BtnToLista;
    }
}