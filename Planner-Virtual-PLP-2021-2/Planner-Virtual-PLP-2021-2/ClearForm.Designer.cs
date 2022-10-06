namespace Planner_Virtual_PLP_2021_2
{
    partial class ClearForm
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
            this.comboConcluir = new System.Windows.Forms.ComboBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.txEstadoAtual = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboConcluir
            // 
            this.comboConcluir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboConcluir.FormattingEnabled = true;
            this.comboConcluir.Location = new System.Drawing.Point(12, 12);
            this.comboConcluir.Name = "comboConcluir";
            this.comboConcluir.Size = new System.Drawing.Size(214, 21);
            this.comboConcluir.TabIndex = 0;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(12, 77);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(214, 23);
            this.BtnSalvar.TabIndex = 1;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // txEstadoAtual
            // 
            this.txEstadoAtual.Enabled = false;
            this.txEstadoAtual.Location = new System.Drawing.Point(13, 45);
            this.txEstadoAtual.Name = "txEstadoAtual";
            this.txEstadoAtual.ReadOnly = true;
            this.txEstadoAtual.Size = new System.Drawing.Size(213, 20);
            this.txEstadoAtual.TabIndex = 2;
            // 
            // ClearForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 112);
            this.Controls.Add(this.txEstadoAtual);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.comboConcluir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClearForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seletor de Conclusão de Eventos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboConcluir;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.TextBox txEstadoAtual;
    }
}