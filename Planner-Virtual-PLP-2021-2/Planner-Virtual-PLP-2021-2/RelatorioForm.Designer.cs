namespace Planner_Virtual_PLP_2021_2
{
    partial class RelatorioForm
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
            this.BtnNAMeta = new System.Windows.Forms.Button();
            this.txCatMeta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txPorMeta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txQtdMeta = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pickDataFinalMeta = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.pickDataInicioMeta = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txTotalMeta = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnNATarefa = new System.Windows.Forms.Button();
            this.txTurnoTarefa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txCatTarefa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txPorTarefa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txQtdTarefa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pickDataFinalTarefa = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.pickDataInicioTarefa = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txTotalTarefa = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txMesProdutivo = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnNAMeta
            // 
            this.BtnNAMeta.Location = new System.Drawing.Point(770, 210);
            this.BtnNAMeta.Name = "BtnNAMeta";
            this.BtnNAMeta.Size = new System.Drawing.Size(107, 23);
            this.BtnNAMeta.TabIndex = 36;
            this.BtnNAMeta.Text = "ou Qualquer data";
            this.BtnNAMeta.UseVisualStyleBackColor = true;
            this.BtnNAMeta.Click += new System.EventHandler(this.BtnNAMeta_Click);
            // 
            // txCatMeta
            // 
            this.txCatMeta.Location = new System.Drawing.Point(297, 281);
            this.txCatMeta.Name = "txCatMeta";
            this.txCatMeta.ReadOnly = true;
            this.txCatMeta.Size = new System.Drawing.Size(168, 20);
            this.txCatMeta.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Categoria de Metas mais Alcançadas:";
            // 
            // txPorMeta
            // 
            this.txPorMeta.Location = new System.Drawing.Point(709, 248);
            this.txPorMeta.Name = "txPorMeta";
            this.txPorMeta.ReadOnly = true;
            this.txPorMeta.Size = new System.Drawing.Size(168, 20);
            this.txPorMeta.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(447, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Porcentagem de Metas Alcançadas:";
            // 
            // txQtdMeta
            // 
            this.txQtdMeta.Location = new System.Drawing.Point(269, 249);
            this.txQtdMeta.Name = "txQtdMeta";
            this.txQtdMeta.ReadOnly = true;
            this.txQtdMeta.Size = new System.Drawing.Size(168, 20);
            this.txQtdMeta.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(245, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "Quantidade de Metas Alcançadas:";
            // 
            // pickDataFinalMeta
            // 
            this.pickDataFinalMeta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickDataFinalMeta.Location = new System.Drawing.Point(666, 212);
            this.pickDataFinalMeta.Name = "pickDataFinalMeta";
            this.pickDataFinalMeta.Size = new System.Drawing.Size(96, 20);
            this.pickDataFinalMeta.TabIndex = 27;
            this.pickDataFinalMeta.ValueChanged += new System.EventHandler(this.UpdateByDataMeta);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(644, 214);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "e";
            // 
            // pickDataInicioMeta
            // 
            this.pickDataInicioMeta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickDataInicioMeta.Location = new System.Drawing.Point(542, 212);
            this.pickDataInicioMeta.Name = "pickDataInicioMeta";
            this.pickDataInicioMeta.Size = new System.Drawing.Size(96, 20);
            this.pickDataInicioMeta.TabIndex = 25;
            this.pickDataInicioMeta.ValueChanged += new System.EventHandler(this.UpdateByDataMeta);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(494, 214);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 16);
            this.label13.TabIndex = 24;
            this.label13.Text = "entre";
            // 
            // txTotalMeta
            // 
            this.txTotalMeta.Location = new System.Drawing.Point(233, 212);
            this.txTotalMeta.Name = "txTotalMeta";
            this.txTotalMeta.ReadOnly = true;
            this.txTotalMeta.Size = new System.Drawing.Size(255, 20);
            this.txTotalMeta.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(11, 214);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(204, 16);
            this.label14.TabIndex = 22;
            this.label14.Text = "Total de Metas Registradas:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(362, 172);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(184, 24);
            this.label15.TabIndex = 37;
            this.label15.Text = "Relatório de Metas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(362, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 24);
            this.label4.TabIndex = 53;
            this.label4.Text = "Relatório de Tarefas";
            // 
            // BtnNATarefa
            // 
            this.BtnNATarefa.Location = new System.Drawing.Point(770, 53);
            this.BtnNATarefa.Name = "BtnNATarefa";
            this.BtnNATarefa.Size = new System.Drawing.Size(107, 23);
            this.BtnNATarefa.TabIndex = 52;
            this.BtnNATarefa.Text = "ou Qualquer data";
            this.BtnNATarefa.UseVisualStyleBackColor = true;
            this.BtnNATarefa.Click += new System.EventHandler(this.BtnNATarefa_Click);
            // 
            // txTurnoTarefa
            // 
            this.txTurnoTarefa.Location = new System.Drawing.Point(658, 124);
            this.txTurnoTarefa.Name = "txTurnoTarefa";
            this.txTurnoTarefa.ReadOnly = true;
            this.txTurnoTarefa.Size = new System.Drawing.Size(219, 20);
            this.txTurnoTarefa.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(475, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 16);
            this.label5.TabIndex = 50;
            this.label5.Text = "Turno mais Aproveitado:";
            // 
            // txCatTarefa
            // 
            this.txCatTarefa.Location = new System.Drawing.Point(297, 124);
            this.txCatTarefa.Name = "txCatTarefa";
            this.txCatTarefa.ReadOnly = true;
            this.txCatTarefa.Size = new System.Drawing.Size(168, 20);
            this.txCatTarefa.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(281, 16);
            this.label6.TabIndex = 48;
            this.label6.Text = "Categoria de Tarefas mais Executadas:";
            // 
            // txPorTarefa
            // 
            this.txPorTarefa.Location = new System.Drawing.Point(709, 91);
            this.txPorTarefa.Name = "txPorTarefa";
            this.txPorTarefa.ReadOnly = true;
            this.txPorTarefa.Size = new System.Drawing.Size(168, 20);
            this.txPorTarefa.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(442, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(261, 16);
            this.label7.TabIndex = 46;
            this.label7.Text = "Porcentagem de Tarefas Cumpridas:";
            // 
            // txQtdTarefa
            // 
            this.txQtdTarefa.Location = new System.Drawing.Point(269, 92);
            this.txQtdTarefa.Name = "txQtdTarefa";
            this.txQtdTarefa.ReadOnly = true;
            this.txQtdTarefa.Size = new System.Drawing.Size(168, 20);
            this.txQtdTarefa.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(256, 16);
            this.label8.TabIndex = 44;
            this.label8.Text = "Quantidade de Tarefas Executadas:";
            // 
            // pickDataFinalTarefa
            // 
            this.pickDataFinalTarefa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickDataFinalTarefa.Location = new System.Drawing.Point(666, 55);
            this.pickDataFinalTarefa.Name = "pickDataFinalTarefa";
            this.pickDataFinalTarefa.Size = new System.Drawing.Size(96, 20);
            this.pickDataFinalTarefa.TabIndex = 43;
            this.pickDataFinalTarefa.ValueChanged += new System.EventHandler(this.UpdateByDataTarefa);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(644, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 16);
            this.label9.TabIndex = 42;
            this.label9.Text = "e";
            // 
            // pickDataInicioTarefa
            // 
            this.pickDataInicioTarefa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickDataInicioTarefa.Location = new System.Drawing.Point(542, 55);
            this.pickDataInicioTarefa.Name = "pickDataInicioTarefa";
            this.pickDataInicioTarefa.Size = new System.Drawing.Size(96, 20);
            this.pickDataInicioTarefa.TabIndex = 41;
            this.pickDataInicioTarefa.ValueChanged += new System.EventHandler(this.UpdateByDataTarefa);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(494, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 16);
            this.label10.TabIndex = 40;
            this.label10.Text = "entre";
            // 
            // txTotalTarefa
            // 
            this.txTotalTarefa.Location = new System.Drawing.Point(233, 55);
            this.txTotalTarefa.Name = "txTotalTarefa";
            this.txTotalTarefa.ReadOnly = true;
            this.txTotalTarefa.Size = new System.Drawing.Size(255, 20);
            this.txTotalTarefa.TabIndex = 39;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(11, 57);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(216, 16);
            this.label16.TabIndex = 38;
            this.label16.Text = "Total de Tarefas Registradas:";
            // 
            // txMesProdutivo
            // 
            this.txMesProdutivo.Location = new System.Drawing.Point(709, 280);
            this.txMesProdutivo.Name = "txMesProdutivo";
            this.txMesProdutivo.ReadOnly = true;
            this.txMesProdutivo.Size = new System.Drawing.Size(168, 20);
            this.txMesProdutivo.TabIndex = 57;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(484, 282);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(220, 16);
            this.label17.TabIndex = 56;
            this.label17.Text = "Mês mais produtivo deste Ano:";
            // 
            // RelatorioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 314);
            this.Controls.Add(this.txMesProdutivo);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnNATarefa);
            this.Controls.Add(this.txTurnoTarefa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txCatTarefa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txPorTarefa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txQtdTarefa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pickDataFinalTarefa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pickDataInicioTarefa);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txTotalTarefa);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.BtnNAMeta);
            this.Controls.Add(this.txCatMeta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txPorMeta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txQtdMeta);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pickDataFinalMeta);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pickDataInicioMeta);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txTotalMeta);
            this.Controls.Add(this.label14);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RelatorioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatórios de Todos os Eventos já Efetuados ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnNAMeta;
        private System.Windows.Forms.TextBox txCatMeta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txPorMeta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txQtdMeta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker pickDataFinalMeta;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker pickDataInicioMeta;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txTotalMeta;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnNATarefa;
        private System.Windows.Forms.TextBox txTurnoTarefa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txCatTarefa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txPorTarefa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txQtdTarefa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker pickDataFinalTarefa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker pickDataInicioTarefa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txTotalTarefa;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txMesProdutivo;
        private System.Windows.Forms.Label label17;
    }
}