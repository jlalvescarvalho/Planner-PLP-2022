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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnToMeta
            // 
            this.BtnToMeta.Location = new System.Drawing.Point(12, 41);
            this.BtnToMeta.Name = "BtnToMeta";
            this.BtnToMeta.Size = new System.Drawing.Size(214, 23);
            this.BtnToMeta.TabIndex = 0;
            this.BtnToMeta.Text = "Adicionar uma Meta até esta Data";
            this.BtnToMeta.UseVisualStyleBackColor = true;
            this.BtnToMeta.Click += new System.EventHandler(this.BtnToMeta_Click);
            // 
            // BtnToTarefa
            // 
            this.BtnToTarefa.Location = new System.Drawing.Point(12, 70);
            this.BtnToTarefa.Name = "BtnToTarefa";
            this.BtnToTarefa.Size = new System.Drawing.Size(214, 23);
            this.BtnToTarefa.TabIndex = 1;
            this.BtnToTarefa.Text = "Adicionar uma Tarefa à esta Data";
            this.BtnToTarefa.UseVisualStyleBackColor = true;
            this.BtnToTarefa.Click += new System.EventHandler(this.BtnToTarefa_Click);
            // 
            // BtnToLista
            // 
            this.BtnToLista.Location = new System.Drawing.Point(12, 99);
            this.BtnToLista.Name = "BtnToLista";
            this.BtnToLista.Size = new System.Drawing.Size(214, 23);
            this.BtnToLista.TabIndex = 3;
            this.BtnToLista.Text = "Listar todos os eventos desta Data";
            this.BtnToLista.UseVisualStyleBackColor = true;
            this.BtnToLista.Click += new System.EventHandler(this.BtnToLista_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 26);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione uma ação";
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Image = global::Planner_Virtual_PLP_2021_2.Properties.Resources.fechar;
            this.btnFechar.Location = new System.Drawing.Point(210, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(25, 25);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFechar.TabIndex = 3;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // SeletorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(238, 128);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnToLista);
            this.Controls.Add(this.BtnToTarefa);
            this.Controls.Add(this.BtnToMeta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SeletorForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecione uma ação abaixo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnToMeta;
        private System.Windows.Forms.Button BtnToTarefa;
        private System.Windows.Forms.Button BtnToLista;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnFechar;
    }
}