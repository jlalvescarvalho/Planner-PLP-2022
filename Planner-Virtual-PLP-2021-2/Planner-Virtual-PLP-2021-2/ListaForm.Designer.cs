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
            this.lbTarefas = new System.Windows.Forms.Label();
            this.lbLembretes = new System.Windows.Forms.Label();
            this.LbAviso = new System.Windows.Forms.Label();
            this.comboMeta = new System.Windows.Forms.ComboBox();
            this.lbFiltroMetas = new System.Windows.Forms.Label();
            this.lbFiltroTarefas = new System.Windows.Forms.Label();
            this.lbFiltroLembretes = new System.Windows.Forms.Label();
            this.comboTarefa = new System.Windows.Forms.ComboBox();
            this.comboLembrete = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // painelDeMetas
            // 
            this.painelDeMetas.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.painelDeMetas.AutoScroll = true;
            this.painelDeMetas.BackColor = System.Drawing.SystemColors.Window;
            this.painelDeMetas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelDeMetas.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.painelDeMetas.Location = new System.Drawing.Point(5, 26);
            this.painelDeMetas.Name = "painelDeMetas";
            this.painelDeMetas.Size = new System.Drawing.Size(261, 407);
            this.painelDeMetas.TabIndex = 5;
            // 
            // painelDeTarefas
            // 
            this.painelDeTarefas.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.painelDeTarefas.AutoScroll = true;
            this.painelDeTarefas.BackColor = System.Drawing.SystemColors.Window;
            this.painelDeTarefas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelDeTarefas.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.painelDeTarefas.Location = new System.Drawing.Point(272, 26);
            this.painelDeTarefas.Name = "painelDeTarefas";
            this.painelDeTarefas.Size = new System.Drawing.Size(261, 407);
            this.painelDeTarefas.TabIndex = 6;
            // 
            // painelDeLembretes
            // 
            this.painelDeLembretes.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.painelDeLembretes.AutoScroll = true;
            this.painelDeLembretes.BackColor = System.Drawing.SystemColors.Window;
            this.painelDeLembretes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelDeLembretes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.painelDeLembretes.Location = new System.Drawing.Point(539, 26);
            this.painelDeLembretes.Name = "painelDeLembretes";
            this.painelDeLembretes.Size = new System.Drawing.Size(261, 407);
            this.painelDeLembretes.TabIndex = 6;
            // 
            // lbMetas
            // 
            this.lbMetas.AutoSize = true;
            this.lbMetas.Font = new System.Drawing.Font("Sofia Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMetas.Location = new System.Drawing.Point(47, 3);
            this.lbMetas.Name = "lbMetas";
            this.lbMetas.Size = new System.Drawing.Size(179, 21);
            this.lbMetas.TabIndex = 7;
            this.lbMetas.Text = "Lista de Metas Criadas";
            // 
            // lbTarefas
            // 
            this.lbTarefas.AutoSize = true;
            this.lbTarefas.Font = new System.Drawing.Font("Sofia Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTarefas.Location = new System.Drawing.Point(313, 3);
            this.lbTarefas.Name = "lbTarefas";
            this.lbTarefas.Size = new System.Drawing.Size(187, 21);
            this.lbTarefas.TabIndex = 8;
            this.lbTarefas.Text = "Lista de Tarefas Criadas";
            // 
            // lbLembretes
            // 
            this.lbLembretes.AutoSize = true;
            this.lbLembretes.Font = new System.Drawing.Font("Sofia Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLembretes.Location = new System.Drawing.Point(570, 3);
            this.lbLembretes.Name = "lbLembretes";
            this.lbLembretes.Size = new System.Drawing.Size(209, 21);
            this.lbLembretes.TabIndex = 9;
            this.lbLembretes.Text = "Lista de Lembretes Criados";
            // 
            // LbAviso
            // 
            this.LbAviso.AutoSize = true;
            this.LbAviso.Location = new System.Drawing.Point(2, 491);
            this.LbAviso.Name = "LbAviso";
            this.LbAviso.Size = new System.Drawing.Size(417, 13);
            this.LbAviso.TabIndex = 10;
            this.LbAviso.Text = "Obs: clique no corpo de algum item para abrir o seu menu de ações e interagir com" +
    " ele.";
            // 
            // comboMeta
            // 
            this.comboMeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMeta.FormattingEnabled = true;
            this.comboMeta.Items.AddRange(new object[] {
            "Listar todas as metas",
            "Listar metas pendentes",
            "Listar metas atingidas com sucesso",
            "Listar metas parcialmente atingidas",
            "Listar metas não atingidas",
            "Listar metas pela categoria \'Compras\'",
            "Listar metas pela categoria \'Diversão\'",
            "Listar metas pela categoria \'Estudo\'",
            "Listar metas pela categoria \'Família\'",
            "Listar metas pela categoria \'Musculação\'",
            "Listar metas pela categoria \'Pesquisa\'",
            "Listar metas pela categoria \'Reunião\'",
            "Listar metas pela categoria \'Telefonema\'",
            "Listar metas pela categoria \'Trabalho\'"});
            this.comboMeta.Location = new System.Drawing.Point(5, 467);
            this.comboMeta.Name = "comboMeta";
            this.comboMeta.Size = new System.Drawing.Size(261, 21);
            this.comboMeta.TabIndex = 11;
            this.comboMeta.SelectedIndexChanged += new System.EventHandler(this.ComboMeta_Update);
            // 
            // lbFiltroMetas
            // 
            this.lbFiltroMetas.AutoSize = true;
            this.lbFiltroMetas.Location = new System.Drawing.Point(12, 444);
            this.lbFiltroMetas.Name = "lbFiltroMetas";
            this.lbFiltroMetas.Size = new System.Drawing.Size(245, 13);
            this.lbFiltroMetas.TabIndex = 12;
            this.lbFiltroMetas.Text = "Selecione um Filtro para listar as Metas no Sistema";
            // 
            // lbFiltroTarefas
            // 
            this.lbFiltroTarefas.AutoSize = true;
            this.lbFiltroTarefas.Location = new System.Drawing.Point(278, 444);
            this.lbFiltroTarefas.Name = "lbFiltroTarefas";
            this.lbFiltroTarefas.Size = new System.Drawing.Size(252, 13);
            this.lbFiltroTarefas.TabIndex = 13;
            this.lbFiltroTarefas.Text = "Selecione um Filtro para listar as Tarefas no Sistema";
            // 
            // lbFiltroLembretes
            // 
            this.lbFiltroLembretes.AutoSize = true;
            this.lbFiltroLembretes.Location = new System.Drawing.Point(536, 444);
            this.lbFiltroLembretes.Name = "lbFiltroLembretes";
            this.lbFiltroLembretes.Size = new System.Drawing.Size(265, 13);
            this.lbFiltroLembretes.TabIndex = 14;
            this.lbFiltroLembretes.Text = "Selecione um Filtro para listar os Lembretes no Sistema";
            // 
            // comboTarefa
            // 
            this.comboTarefa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTarefa.FormattingEnabled = true;
            this.comboTarefa.Items.AddRange(new object[] {
            "Listar todas as tarefas",
            "Listar tarefas pendentes",
            "Listar tarefas executadas",
            "Listar tarefas adiadas",
            "Listar tarefas parcialmente executadas",
            "Listar tarefas pela categoria \'Compras\'",
            "Listar tarefas pela categoria \'Diversão\'",
            "Listar tarefas pela categoria \'Estudo\'",
            "Listar tarefas pela categoria \'Família\'",
            "Listar tarefas pela categoria \'Musculação\'",
            "Listar tarefas pela categoria \'Pesquisa\'",
            "Listar tarefas pela categoria \'Reunião\'",
            "Listar tarefas pela categoria \'Telefonema\'",
            "Listar tarefas pela categoria \'Trabalho\'"});
            this.comboTarefa.Location = new System.Drawing.Point(272, 467);
            this.comboTarefa.Name = "comboTarefa";
            this.comboTarefa.Size = new System.Drawing.Size(261, 21);
            this.comboTarefa.TabIndex = 15;
            this.comboTarefa.SelectedIndexChanged += new System.EventHandler(this.ComboTarefa_Update);
            // 
            // comboLembrete
            // 
            this.comboLembrete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLembrete.FormattingEnabled = true;
            this.comboLembrete.Items.AddRange(new object[] {
            "Listar todos os lembretes"});
            this.comboLembrete.Location = new System.Drawing.Point(539, 467);
            this.comboLembrete.Name = "comboLembrete";
            this.comboLembrete.Size = new System.Drawing.Size(261, 21);
            this.comboLembrete.TabIndex = 16;
            this.comboLembrete.SelectedIndexChanged += new System.EventHandler(this.ComboLembrete_Update);
            // 
            // ListaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 513);
            this.Controls.Add(this.comboLembrete);
            this.Controls.Add(this.comboTarefa);
            this.Controls.Add(this.lbFiltroLembretes);
            this.Controls.Add(this.lbFiltroTarefas);
            this.Controls.Add(this.lbFiltroMetas);
            this.Controls.Add(this.comboMeta);
            this.Controls.Add(this.LbAviso);
            this.Controls.Add(this.lbLembretes);
            this.Controls.Add(this.lbTarefas);
            this.Controls.Add(this.lbMetas);
            this.Controls.Add(this.painelDeLembretes);
            this.Controls.Add(this.painelDeTarefas);
            this.Controls.Add(this.painelDeMetas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListaForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel painelDeMetas;
        private System.Windows.Forms.FlowLayoutPanel painelDeTarefas;
        private System.Windows.Forms.FlowLayoutPanel painelDeLembretes;
        private System.Windows.Forms.Label lbMetas;
        private System.Windows.Forms.Label lbTarefas;
        private System.Windows.Forms.Label lbLembretes;
        private System.Windows.Forms.Label LbAviso;
        private System.Windows.Forms.ComboBox comboMeta;
        private System.Windows.Forms.Label lbFiltroMetas;
        private System.Windows.Forms.Label lbFiltroTarefas;
        private System.Windows.Forms.Label lbFiltroLembretes;
        private System.Windows.Forms.ComboBox comboTarefa;
        private System.Windows.Forms.ComboBox comboLembrete;
    }
}