
namespace starpatch
{
    partial class FrmPrincipal
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
            this.lblCaminho = new System.Windows.Forms.Label();
            this.txtCaminhoArquivo = new System.Windows.Forms.TextBox();
            this.folderBrowserDialogCaminho = new System.Windows.Forms.FolderBrowserDialog();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.gbControles = new System.Windows.Forms.GroupBox();
            this.btnJsonPatch = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.btnProcurarCaminho = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.tabControlDados = new System.Windows.Forms.TabControl();
            this.tabPageDados = new System.Windows.Forms.TabPage();
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.pnlCarregando = new System.Windows.Forms.Panel();
            this.lblRodando = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.gbControles.SuspendLayout();
            this.tabControlDados.SuspendLayout();
            this.tabPageDados.SuspendLayout();
            this.tabPageLog.SuspendLayout();
            this.pnlCarregando.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCaminho
            // 
            this.lblCaminho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCaminho.AutoSize = true;
            this.lblCaminho.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaminho.Location = new System.Drawing.Point(22, 357);
            this.lblCaminho.Name = "lblCaminho";
            this.lblCaminho.Size = new System.Drawing.Size(186, 24);
            this.lblCaminho.TabIndex = 2;
            this.lblCaminho.Text = "Caminho Raiz Mod";
            // 
            // txtCaminhoArquivo
            // 
            this.txtCaminhoArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCaminhoArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaminhoArquivo.Location = new System.Drawing.Point(214, 352);
            this.txtCaminhoArquivo.MaxLength = 20;
            this.txtCaminhoArquivo.Name = "txtCaminhoArquivo";
            this.txtCaminhoArquivo.Size = new System.Drawing.Size(530, 29);
            this.txtCaminhoArquivo.TabIndex = 3;
            this.txtCaminhoArquivo.TabStop = false;
            this.txtCaminhoArquivo.Text = "C:\\Mod\\Star Alliance Mod\\";
            // 
            // folderBrowserDialogCaminho
            // 
            this.folderBrowserDialogCaminho.RootFolder = System.Environment.SpecialFolder.CommonDocuments;
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.AllowUserToOrderColumns = true;
            this.dgvDados.AllowUserToResizeRows = false;
            this.dgvDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDados.ColumnHeadersHeight = 29;
            this.dgvDados.Location = new System.Drawing.Point(6, 6);
            this.dgvDados.MultiSelect = false;
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.RowHeadersVisible = false;
            this.dgvDados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDados.Size = new System.Drawing.Size(752, 267);
            this.dgvDados.TabIndex = 0;
            // 
            // gbControles
            // 
            this.gbControles.Controls.Add(this.btnJsonPatch);
            this.gbControles.Controls.Add(this.btnCancelar);
            this.gbControles.Controls.Add(this.btnProcessar);
            this.gbControles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbControles.Location = new System.Drawing.Point(0, 384);
            this.gbControles.Name = "gbControles";
            this.gbControles.Size = new System.Drawing.Size(800, 66);
            this.gbControles.TabIndex = 5;
            this.gbControles.TabStop = false;
            // 
            // btnJsonPatch
            // 
            this.btnJsonPatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJsonPatch.Enabled = false;
            this.btnJsonPatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJsonPatch.Image = global::starpatch.Properties.Resources._32_json;
            this.btnJsonPatch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJsonPatch.Location = new System.Drawing.Point(528, 14);
            this.btnJsonPatch.Name = "btnJsonPatch";
            this.btnJsonPatch.Size = new System.Drawing.Size(130, 40);
            this.btnJsonPatch.TabIndex = 1;
            this.btnJsonPatch.Text = "      JSON Patch";
            this.btnJsonPatch.UseVisualStyleBackColor = true;
            this.btnJsonPatch.Click += new System.EventHandler(this.btnJsonPatch_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::starpatch.Properties.Resources._32_fechar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(398, 14);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 40);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "  Fechar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnProcessar
            // 
            this.btnProcessar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcessar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessar.Image = global::starpatch.Properties.Resources._32_fogete;
            this.btnProcessar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcessar.Location = new System.Drawing.Point(658, 14);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(130, 40);
            this.btnProcessar.TabIndex = 2;
            this.btnProcessar.Text = "   Processar";
            this.btnProcessar.UseVisualStyleBackColor = true;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // btnProcurarCaminho
            // 
            this.btnProcurarCaminho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcurarCaminho.Image = global::starpatch.Properties.Resources._16_buscar_pastas;
            this.btnProcurarCaminho.Location = new System.Drawing.Point(750, 353);
            this.btnProcurarCaminho.Name = "btnProcurarCaminho";
            this.btnProcurarCaminho.Size = new System.Drawing.Size(35, 30);
            this.btnProcurarCaminho.TabIndex = 4;
            this.btnProcurarCaminho.UseVisualStyleBackColor = true;
            this.btnProcurarCaminho.Click += new System.EventHandler(this.btnProcurarCaminho_Click);
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(6, 6);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(752, 267);
            this.txtLog.TabIndex = 0;
            this.txtLog.Text = "";
            // 
            // tabControlDados
            // 
            this.tabControlDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlDados.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlDados.Controls.Add(this.tabPageDados);
            this.tabControlDados.Controls.Add(this.tabPageLog);
            this.tabControlDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlDados.Location = new System.Drawing.Point(16, 27);
            this.tabControlDados.Name = "tabControlDados";
            this.tabControlDados.SelectedIndex = 0;
            this.tabControlDados.Size = new System.Drawing.Size(772, 319);
            this.tabControlDados.TabIndex = 1;
            // 
            // tabPageDados
            // 
            this.tabPageDados.Controls.Add(this.dgvDados);
            this.tabPageDados.Location = new System.Drawing.Point(4, 36);
            this.tabPageDados.Name = "tabPageDados";
            this.tabPageDados.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDados.Size = new System.Drawing.Size(764, 279);
            this.tabPageDados.TabIndex = 0;
            this.tabPageDados.Text = "Arquivos";
            this.tabPageDados.UseVisualStyleBackColor = true;
            // 
            // tabPageLog
            // 
            this.tabPageLog.Controls.Add(this.txtLog);
            this.tabPageLog.Location = new System.Drawing.Point(4, 36);
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLog.Size = new System.Drawing.Size(764, 279);
            this.tabPageLog.TabIndex = 1;
            this.tabPageLog.Text = "Log";
            this.tabPageLog.UseVisualStyleBackColor = true;
            // 
            // pnlCarregando
            // 
            this.pnlCarregando.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCarregando.BackColor = System.Drawing.Color.Firebrick;
            this.pnlCarregando.Controls.Add(this.lblRodando);
            this.pnlCarregando.ForeColor = System.Drawing.Color.White;
            this.pnlCarregando.Location = new System.Drawing.Point(0, 0);
            this.pnlCarregando.Name = "pnlCarregando";
            this.pnlCarregando.Size = new System.Drawing.Size(800, 21);
            this.pnlCarregando.TabIndex = 0;
            this.pnlCarregando.Visible = false;
            // 
            // lblRodando
            // 
            this.lblRodando.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRodando.AutoSize = true;
            this.lblRodando.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRodando.Location = new System.Drawing.Point(6, 3);
            this.lblRodando.Name = "lblRodando";
            this.lblRodando.Size = new System.Drawing.Size(94, 15);
            this.lblRodando.TabIndex = 0;
            this.lblRodando.Text = "Carregando...";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlCarregando);
            this.Controls.Add(this.tabControlDados);
            this.Controls.Add(this.gbControles);
            this.Controls.Add(this.lblCaminho);
            this.Controls.Add(this.txtCaminhoArquivo);
            this.Controls.Add(this.btnProcurarCaminho);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Star Patch";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.gbControles.ResumeLayout(false);
            this.tabControlDados.ResumeLayout(false);
            this.tabPageDados.ResumeLayout(false);
            this.tabPageLog.ResumeLayout(false);
            this.pnlCarregando.ResumeLayout(false);
            this.pnlCarregando.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCaminho;
        private System.Windows.Forms.TextBox txtCaminhoArquivo;
        private System.Windows.Forms.Button btnProcurarCaminho;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogCaminho;
        private System.Windows.Forms.DataGridView dgvDados;
        protected System.Windows.Forms.GroupBox gbControles;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnProcessar;
        private System.Windows.Forms.Button btnJsonPatch;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.TabControl tabControlDados;
        private System.Windows.Forms.TabPage tabPageDados;
        private System.Windows.Forms.TabPage tabPageLog;
        private System.Windows.Forms.Panel pnlCarregando;
        private System.Windows.Forms.Label lblRodando;
    }
}

