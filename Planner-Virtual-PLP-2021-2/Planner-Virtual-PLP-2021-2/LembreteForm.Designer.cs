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
            this.SuspendLayout();
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalvar.Location = new System.Drawing.Point(12, 306);
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
            this.label5.Location = new System.Drawing.Point(9, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Tarefa:";
            // 
            // lbLembrete
            // 
            this.lbLembrete.AutoSize = true;
            this.lbLembrete.Location = new System.Drawing.Point(9, 252);
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
            this.pickHorarioTarefa.Location = new System.Drawing.Point(171, 279);
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
            this.pickDataTarefa.Location = new System.Drawing.Point(66, 278);
            this.pickDataTarefa.Name = "pickDataTarefa";
            this.pickDataTarefa.Size = new System.Drawing.Size(99, 20);
            this.pickDataTarefa.TabIndex = 23;
            this.pickDataTarefa.Value = new System.DateTime(2022, 10, 15, 9, 22, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Defina uma data para este lembrete.";
            // 
            // pickHoraLembrete
            // 
            this.pickHoraLembrete.CustomFormat = "HH:mm";
            this.pickHoraLembrete.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickHoraLembrete.Location = new System.Drawing.Point(171, 252);
            this.pickHoraLembrete.Name = "pickHoraLembrete";
            this.pickHoraLembrete.ShowUpDown = true;
            this.pickHoraLembrete.Size = new System.Drawing.Size(52, 20);
            this.pickHoraLembrete.TabIndex = 21;
            this.pickHoraLembrete.Value = new System.DateTime(2022, 10, 2, 0, 0, 0, 0);
            // 
            // lbAviso
            // 
            this.lbAviso.AutoSize = true;
            this.lbAviso.Location = new System.Drawing.Point(43, 9);
            this.lbAviso.Name = "lbAviso";
            this.lbAviso.Size = new System.Drawing.Size(155, 13);
            this.lbAviso.TabIndex = 20;
            this.lbAviso.Text = "Insira uma mensagem de aviso.";
            // 
            // txMensagem
            // 
            this.txMensagem.Location = new System.Drawing.Point(13, 25);
            this.txMensagem.Multiline = true;
            this.txMensagem.Name = "txMensagem";
            this.txMensagem.Size = new System.Drawing.Size(211, 197);
            this.txMensagem.TabIndex = 19;
            // 
            // pickDataLembrete
            // 
            this.pickDataLembrete.CustomFormat = "";
            this.pickDataLembrete.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickDataLembrete.Location = new System.Drawing.Point(66, 252);
            this.pickDataLembrete.Name = "pickDataLembrete";
            this.pickDataLembrete.Size = new System.Drawing.Size(99, 20);
            this.pickDataLembrete.TabIndex = 29;
            this.pickDataLembrete.Value = new System.DateTime(2022, 10, 15, 9, 22, 0, 0);
            // 
            // LembreteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 341);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LembreteForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crie um novo Lembrete";
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
    }
}