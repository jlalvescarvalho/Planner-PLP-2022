﻿namespace Planner_Virtual_PLP_2021_2
{
    partial class TarefaForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txDescricao = new System.Windows.Forms.TextBox();
            this.pickHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.pickDataFinal = new System.Windows.Forms.DateTimePicker();
            this.pickHorarioFinal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txDataInicio = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Selecione uma categoria para esta tarefa.";
            // 
            // comboCategoria
            // 
            this.comboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Location = new System.Drawing.Point(12, 49);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(211, 21);
            this.comboCategoria.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Insira uma breve descrição sobre a tarefa.";
            // 
            // txDescricao
            // 
            this.txDescricao.Location = new System.Drawing.Point(14, 99);
            this.txDescricao.Multiline = true;
            this.txDescricao.Name = "txDescricao";
            this.txDescricao.Size = new System.Drawing.Size(202, 167);
            this.txDescricao.TabIndex = 8;
            // 
            // pickHoraInicio
            // 
            this.pickHoraInicio.CustomFormat = "HH:mm";
            this.pickHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickHoraInicio.Location = new System.Drawing.Point(167, 294);
            this.pickHoraInicio.Name = "pickHoraInicio";
            this.pickHoraInicio.ShowUpDown = true;
            this.pickHoraInicio.Size = new System.Drawing.Size(52, 20);
            this.pickHoraInicio.TabIndex = 10;
            this.pickHoraInicio.Value = new System.DateTime(2022, 10, 2, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Defina o início e fim da atividade.";
            // 
            // pickDataFinal
            // 
            this.pickDataFinal.CustomFormat = "";
            this.pickDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickDataFinal.Location = new System.Drawing.Point(62, 320);
            this.pickDataFinal.Name = "pickDataFinal";
            this.pickDataFinal.Size = new System.Drawing.Size(99, 20);
            this.pickDataFinal.TabIndex = 13;
            this.pickDataFinal.Value = new System.DateTime(2022, 10, 15, 9, 22, 0, 0);
            // 
            // pickHorarioFinal
            // 
            this.pickHorarioFinal.CustomFormat = "HH:mm";
            this.pickHorarioFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickHorarioFinal.Location = new System.Drawing.Point(167, 321);
            this.pickHorarioFinal.Name = "pickHorarioFinal";
            this.pickHorarioFinal.ShowUpDown = true;
            this.pickHorarioFinal.Size = new System.Drawing.Size(52, 20);
            this.pickHorarioFinal.TabIndex = 14;
            this.pickHorarioFinal.Value = new System.DateTime(2022, 10, 2, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Início:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Fim:";
            // 
            // txDataInicio
            // 
            this.txDataInicio.Enabled = false;
            this.txDataInicio.Location = new System.Drawing.Point(62, 294);
            this.txDataInicio.Name = "txDataInicio";
            this.txDataInicio.Size = new System.Drawing.Size(99, 20);
            this.txDataInicio.TabIndex = 17;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Location = new System.Drawing.Point(12, 360);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(211, 23);
            this.btnSalvar.TabIndex = 18;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 30);
            this.panel1.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nachlieli CLM", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 32);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tarefa";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Image = global::Planner_Virtual_PLP_2021_2.Properties.Resources.fechar;
            this.btnFechar.Location = new System.Drawing.Point(203, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(25, 25);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFechar.TabIndex = 0;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // TarefaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(231, 395);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txDataInicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pickHorarioFinal);
            this.Controls.Add(this.pickDataFinal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pickHoraInicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txDescricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TarefaForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crie uma nova Tarefa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txDescricao;
        private System.Windows.Forms.DateTimePicker pickHoraInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker pickDataFinal;
        private System.Windows.Forms.DateTimePicker pickHorarioFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txDataInicio;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox btnFechar;
    }
}