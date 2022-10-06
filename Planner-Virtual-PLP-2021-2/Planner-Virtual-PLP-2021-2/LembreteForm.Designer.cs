namespace Planner_Virtual_PLP_2021_2
{
    partial class LembreteForm
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
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbLembrete = new System.Windows.Forms.Label();
            this.pickHorarioTarefa = new System.Windows.Forms.DateTimePicker();
            this.pickDataTarefa = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.pickHoraLembrete = new System.Windows.Forms.DateTimePicker();
            this.lbAviso = new System.Windows.Forms.Label();
            this.txMensagem = new System.Windows.Forms.TextBox();
            this.pickDataLembrete = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalvar.Location = new System.Drawing.Point(12, 337);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(211, 23);
            this.BtnSalvar.TabIndex = 28;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Tarefa:";
            // 
            // lbLembrete
            // 
            this.lbLembrete.AutoSize = true;
            this.lbLembrete.Location = new System.Drawing.Point(9, 283);
            this.lbLembrete.Name = "lbLembrete";
            this.lbLembrete.Size = new System.Drawing.Size(54, 13);
            this.lbLembrete.TabIndex = 25;
            this.lbLembrete.Text = "Lembrete:";
            // 
            // pickHorarioTarefa
            // 
            this.pickHorarioTarefa.CustomFormat = "HH:mm";
            this.pickHorarioTarefa.Enabled = false;
            this.pickHorarioTarefa.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickHorarioTarefa.Location = new System.Drawing.Point(171, 310);
            this.pickHorarioTarefa.Name = "pickHorarioTarefa";
            this.pickHorarioTarefa.ShowUpDown = true;
            this.pickHorarioTarefa.Size = new System.Drawing.Size(52, 20);
            this.pickHorarioTarefa.TabIndex = 24;
            this.pickHorarioTarefa.Value = new System.DateTime(2022, 10, 2, 0, 0, 0, 0);
            // 
            // pickDataTarefa
            // 
            this.pickDataTarefa.CustomFormat = "";
            this.pickDataTarefa.Enabled = false;
            this.pickDataTarefa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickDataTarefa.Location = new System.Drawing.Point(66, 309);
            this.pickDataTarefa.Name = "pickDataTarefa";
            this.pickDataTarefa.Size = new System.Drawing.Size(99, 20);
            this.pickDataTarefa.TabIndex = 23;
            this.pickDataTarefa.Value = new System.DateTime(2022, 10, 15, 9, 22, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Defina uma data para este lembrete.";
            // 
            // pickHoraLembrete
            // 
            this.pickHoraLembrete.CustomFormat = "HH:mm";
            this.pickHoraLembrete.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickHoraLembrete.Location = new System.Drawing.Point(171, 283);
            this.pickHoraLembrete.Name = "pickHoraLembrete";
            this.pickHoraLembrete.ShowUpDown = true;
            this.pickHoraLembrete.Size = new System.Drawing.Size(52, 20);
            this.pickHoraLembrete.TabIndex = 21;
            this.pickHoraLembrete.Value = new System.DateTime(2022, 10, 2, 0, 0, 0, 0);
            // 
            // lbAviso
            // 
            this.lbAviso.AutoSize = true;
            this.lbAviso.Location = new System.Drawing.Point(43, 40);
            this.lbAviso.Name = "lbAviso";
            this.lbAviso.Size = new System.Drawing.Size(155, 13);
            this.lbAviso.TabIndex = 20;
            this.lbAviso.Text = "Insira uma mensagem de aviso.";
            // 
            // txMensagem
            // 
            this.txMensagem.Location = new System.Drawing.Point(13, 56);
            this.txMensagem.Multiline = true;
            this.txMensagem.Name = "txMensagem";
            this.txMensagem.Size = new System.Drawing.Size(211, 197);
            this.txMensagem.TabIndex = 19;
            // 
            // pickDataLembrete
            // 
            this.pickDataLembrete.CustomFormat = "";
            this.pickDataLembrete.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickDataLembrete.Location = new System.Drawing.Point(66, 283);
            this.pickDataLembrete.Name = "pickDataLembrete";
            this.pickDataLembrete.Size = new System.Drawing.Size(99, 20);
            this.pickDataLembrete.TabIndex = 29;
            this.pickDataLembrete.Value = new System.DateTime(2022, 10, 15, 9, 22, 0, 0);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 27);
            this.panel1.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(2, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crie um novo lembrete";
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Image = global::Planner_Virtual_PLP_2021_2.Properties.Resources.fechar;
            this.btnFechar.Location = new System.Drawing.Point(210, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(25, 25);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFechar.TabIndex = 2;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // LembreteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(238, 366);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pickDataLembrete);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbLembrete);
            this.Controls.Add(this.pickHorarioTarefa);
            this.Controls.Add(this.pickDataTarefa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pickHoraLembrete);
            this.Controls.Add(this.lbAviso);
            this.Controls.Add(this.txMensagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LembreteForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crie um novo Lembrete";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbLembrete;
        private System.Windows.Forms.DateTimePicker pickHorarioTarefa;
        private System.Windows.Forms.DateTimePicker pickDataTarefa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker pickHoraLembrete;
        private System.Windows.Forms.Label lbAviso;
        private System.Windows.Forms.TextBox txMensagem;
        private System.Windows.Forms.DateTimePicker pickDataLembrete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnFechar;
    }
}