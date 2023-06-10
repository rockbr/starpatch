
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.lblPastaMod = new System.Windows.Forms.Label();
            this.txtPastaMod = new System.Windows.Forms.TextBox();
            this.folderBrowserDialogCaminho = new System.Windows.Forms.FolderBrowserDialog();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.gbControles = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.tabControlDados = new System.Windows.Forms.TabControl();
            this.tabPageDados = new System.Windows.Forms.TabPage();
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblPath10 = new System.Windows.Forms.Label();
            this.txtPath10 = new System.Windows.Forms.TextBox();
            this.lblPath09 = new System.Windows.Forms.Label();
            this.txtPath09 = new System.Windows.Forms.TextBox();
            this.lblPath08 = new System.Windows.Forms.Label();
            this.txtPath08 = new System.Windows.Forms.TextBox();
            this.lblPath07 = new System.Windows.Forms.Label();
            this.txtPath07 = new System.Windows.Forms.TextBox();
            this.lblPath06 = new System.Windows.Forms.Label();
            this.txtPath06 = new System.Windows.Forms.TextBox();
            this.lblPath05 = new System.Windows.Forms.Label();
            this.txtPath05 = new System.Windows.Forms.TextBox();
            this.lblPath04 = new System.Windows.Forms.Label();
            this.txtPath04 = new System.Windows.Forms.TextBox();
            this.lblPath03 = new System.Windows.Forms.Label();
            this.txtPath03 = new System.Windows.Forms.TextBox();
            this.lblPath02 = new System.Windows.Forms.Label();
            this.txtPath02 = new System.Windows.Forms.TextBox();
            this.lblPath01 = new System.Windows.Forms.Label();
            this.txtPath01 = new System.Windows.Forms.TextBox();
            this.lblPastaSaida = new System.Windows.Forms.Label();
            this.txtPastaSaida = new System.Windows.Forms.TextBox();
            this.pnlCarregando = new System.Windows.Forms.Panel();
            this.lblRodando = new System.Windows.Forms.Label();
            this.btnPath10 = new System.Windows.Forms.Button();
            this.btnPath09 = new System.Windows.Forms.Button();
            this.btnPath08 = new System.Windows.Forms.Button();
            this.btnPath07 = new System.Windows.Forms.Button();
            this.btnPath06 = new System.Windows.Forms.Button();
            this.btnPath05 = new System.Windows.Forms.Button();
            this.btnPath04 = new System.Windows.Forms.Button();
            this.btnPath03 = new System.Windows.Forms.Button();
            this.btnPath02 = new System.Windows.Forms.Button();
            this.btnPath01 = new System.Windows.Forms.Button();
            this.btnPastaSaida = new System.Windows.Forms.Button();
            this.btnPastaMod = new System.Windows.Forms.Button();
            this.btnJsonPatch = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.gbControles.SuspendLayout();
            this.tabControlDados.SuspendLayout();
            this.tabPageDados.SuspendLayout();
            this.tabPageLog.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlCarregando.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPastaMod
            // 
            this.lblPastaMod.AutoSize = true;
            this.lblPastaMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPastaMod.Location = new System.Drawing.Point(6, 8);
            this.lblPastaMod.Name = "lblPastaMod";
            this.lblPastaMod.Size = new System.Drawing.Size(107, 24);
            this.lblPastaMod.TabIndex = 0;
            this.lblPastaMod.Text = "Pasta Mod";
            // 
            // txtPastaMod
            // 
            this.txtPastaMod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPastaMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPastaMod.Location = new System.Drawing.Point(130, 6);
            this.txtPastaMod.Name = "txtPastaMod";
            this.txtPastaMod.Size = new System.Drawing.Size(586, 29);
            this.txtPastaMod.TabIndex = 1;
            this.txtPastaMod.TabStop = false;
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
            this.dgvDados.Size = new System.Drawing.Size(752, 414);
            this.dgvDados.TabIndex = 0;
            // 
            // gbControles
            // 
            this.gbControles.Controls.Add(this.lblTotal);
            this.gbControles.Controls.Add(this.btnJsonPatch);
            this.gbControles.Controls.Add(this.btnCancelar);
            this.gbControles.Controls.Add(this.btnProcessar);
            this.gbControles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbControles.Location = new System.Drawing.Point(0, 499);
            this.gbControles.Name = "gbControles";
            this.gbControles.Size = new System.Drawing.Size(800, 66);
            this.gbControles.TabIndex = 2;
            this.gbControles.TabStop = false;
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(6, 6);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(752, 414);
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
            this.tabControlDados.Controls.Add(this.tabPage1);
            this.tabControlDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlDados.Location = new System.Drawing.Point(16, 27);
            this.tabControlDados.Name = "tabControlDados";
            this.tabControlDados.SelectedIndex = 0;
            this.tabControlDados.Size = new System.Drawing.Size(772, 466);
            this.tabControlDados.TabIndex = 1;
            // 
            // tabPageDados
            // 
            this.tabPageDados.Controls.Add(this.dgvDados);
            this.tabPageDados.Location = new System.Drawing.Point(4, 36);
            this.tabPageDados.Name = "tabPageDados";
            this.tabPageDados.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDados.Size = new System.Drawing.Size(764, 426);
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
            this.tabPageLog.Size = new System.Drawing.Size(764, 426);
            this.tabPageLog.TabIndex = 1;
            this.tabPageLog.Text = "Log";
            this.tabPageLog.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblPath10);
            this.tabPage1.Controls.Add(this.btnPath10);
            this.tabPage1.Controls.Add(this.txtPath10);
            this.tabPage1.Controls.Add(this.lblPath09);
            this.tabPage1.Controls.Add(this.btnPath09);
            this.tabPage1.Controls.Add(this.txtPath09);
            this.tabPage1.Controls.Add(this.lblPath08);
            this.tabPage1.Controls.Add(this.btnPath08);
            this.tabPage1.Controls.Add(this.txtPath08);
            this.tabPage1.Controls.Add(this.lblPath07);
            this.tabPage1.Controls.Add(this.btnPath07);
            this.tabPage1.Controls.Add(this.txtPath07);
            this.tabPage1.Controls.Add(this.lblPath06);
            this.tabPage1.Controls.Add(this.btnPath06);
            this.tabPage1.Controls.Add(this.txtPath06);
            this.tabPage1.Controls.Add(this.lblPath05);
            this.tabPage1.Controls.Add(this.btnPath05);
            this.tabPage1.Controls.Add(this.txtPath05);
            this.tabPage1.Controls.Add(this.lblPath04);
            this.tabPage1.Controls.Add(this.btnPath04);
            this.tabPage1.Controls.Add(this.txtPath04);
            this.tabPage1.Controls.Add(this.lblPath03);
            this.tabPage1.Controls.Add(this.btnPath03);
            this.tabPage1.Controls.Add(this.txtPath03);
            this.tabPage1.Controls.Add(this.lblPath02);
            this.tabPage1.Controls.Add(this.btnPath02);
            this.tabPage1.Controls.Add(this.txtPath02);
            this.tabPage1.Controls.Add(this.lblPath01);
            this.tabPage1.Controls.Add(this.btnPath01);
            this.tabPage1.Controls.Add(this.txtPath01);
            this.tabPage1.Controls.Add(this.lblPastaSaida);
            this.tabPage1.Controls.Add(this.btnPastaSaida);
            this.tabPage1.Controls.Add(this.txtPastaSaida);
            this.tabPage1.Controls.Add(this.lblPastaMod);
            this.tabPage1.Controls.Add(this.btnPastaMod);
            this.tabPage1.Controls.Add(this.txtPastaMod);
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(764, 426);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Configuração";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblPath10
            // 
            this.lblPath10.AutoSize = true;
            this.lblPath10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath10.Location = new System.Drawing.Point(6, 393);
            this.lblPath10.Name = "lblPath10";
            this.lblPath10.Size = new System.Drawing.Size(79, 24);
            this.lblPath10.TabIndex = 33;
            this.lblPath10.Text = "Path 10";
            // 
            // txtPath10
            // 
            this.txtPath10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath10.Location = new System.Drawing.Point(130, 391);
            this.txtPath10.Name = "txtPath10";
            this.txtPath10.Size = new System.Drawing.Size(586, 29);
            this.txtPath10.TabIndex = 34;
            this.txtPath10.TabStop = false;
            // 
            // lblPath09
            // 
            this.lblPath09.AutoSize = true;
            this.lblPath09.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath09.Location = new System.Drawing.Point(6, 358);
            this.lblPath09.Name = "lblPath09";
            this.lblPath09.Size = new System.Drawing.Size(79, 24);
            this.lblPath09.TabIndex = 30;
            this.lblPath09.Text = "Path 09";
            // 
            // txtPath09
            // 
            this.txtPath09.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath09.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath09.Location = new System.Drawing.Point(130, 356);
            this.txtPath09.Name = "txtPath09";
            this.txtPath09.Size = new System.Drawing.Size(586, 29);
            this.txtPath09.TabIndex = 31;
            this.txtPath09.TabStop = false;
            // 
            // lblPath08
            // 
            this.lblPath08.AutoSize = true;
            this.lblPath08.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath08.Location = new System.Drawing.Point(6, 323);
            this.lblPath08.Name = "lblPath08";
            this.lblPath08.Size = new System.Drawing.Size(79, 24);
            this.lblPath08.TabIndex = 27;
            this.lblPath08.Text = "Path 08";
            // 
            // txtPath08
            // 
            this.txtPath08.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath08.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath08.Location = new System.Drawing.Point(130, 321);
            this.txtPath08.Name = "txtPath08";
            this.txtPath08.Size = new System.Drawing.Size(586, 29);
            this.txtPath08.TabIndex = 28;
            this.txtPath08.TabStop = false;
            // 
            // lblPath07
            // 
            this.lblPath07.AutoSize = true;
            this.lblPath07.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath07.Location = new System.Drawing.Point(6, 288);
            this.lblPath07.Name = "lblPath07";
            this.lblPath07.Size = new System.Drawing.Size(79, 24);
            this.lblPath07.TabIndex = 24;
            this.lblPath07.Text = "Path 07";
            // 
            // txtPath07
            // 
            this.txtPath07.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath07.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath07.Location = new System.Drawing.Point(130, 286);
            this.txtPath07.Name = "txtPath07";
            this.txtPath07.Size = new System.Drawing.Size(586, 29);
            this.txtPath07.TabIndex = 25;
            this.txtPath07.TabStop = false;
            // 
            // lblPath06
            // 
            this.lblPath06.AutoSize = true;
            this.lblPath06.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath06.Location = new System.Drawing.Point(6, 253);
            this.lblPath06.Name = "lblPath06";
            this.lblPath06.Size = new System.Drawing.Size(79, 24);
            this.lblPath06.TabIndex = 21;
            this.lblPath06.Text = "Path 06";
            // 
            // txtPath06
            // 
            this.txtPath06.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath06.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath06.Location = new System.Drawing.Point(130, 251);
            this.txtPath06.Name = "txtPath06";
            this.txtPath06.Size = new System.Drawing.Size(586, 29);
            this.txtPath06.TabIndex = 22;
            this.txtPath06.TabStop = false;
            // 
            // lblPath05
            // 
            this.lblPath05.AutoSize = true;
            this.lblPath05.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath05.Location = new System.Drawing.Point(6, 218);
            this.lblPath05.Name = "lblPath05";
            this.lblPath05.Size = new System.Drawing.Size(79, 24);
            this.lblPath05.TabIndex = 18;
            this.lblPath05.Text = "Path 05";
            // 
            // txtPath05
            // 
            this.txtPath05.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath05.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath05.Location = new System.Drawing.Point(130, 216);
            this.txtPath05.Name = "txtPath05";
            this.txtPath05.Size = new System.Drawing.Size(586, 29);
            this.txtPath05.TabIndex = 19;
            this.txtPath05.TabStop = false;
            // 
            // lblPath04
            // 
            this.lblPath04.AutoSize = true;
            this.lblPath04.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath04.Location = new System.Drawing.Point(6, 183);
            this.lblPath04.Name = "lblPath04";
            this.lblPath04.Size = new System.Drawing.Size(79, 24);
            this.lblPath04.TabIndex = 15;
            this.lblPath04.Text = "Path 04";
            // 
            // txtPath04
            // 
            this.txtPath04.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath04.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath04.Location = new System.Drawing.Point(130, 181);
            this.txtPath04.Name = "txtPath04";
            this.txtPath04.Size = new System.Drawing.Size(586, 29);
            this.txtPath04.TabIndex = 16;
            this.txtPath04.TabStop = false;
            // 
            // lblPath03
            // 
            this.lblPath03.AutoSize = true;
            this.lblPath03.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath03.Location = new System.Drawing.Point(6, 148);
            this.lblPath03.Name = "lblPath03";
            this.lblPath03.Size = new System.Drawing.Size(79, 24);
            this.lblPath03.TabIndex = 12;
            this.lblPath03.Text = "Path 03";
            // 
            // txtPath03
            // 
            this.txtPath03.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath03.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath03.Location = new System.Drawing.Point(130, 146);
            this.txtPath03.Name = "txtPath03";
            this.txtPath03.Size = new System.Drawing.Size(586, 29);
            this.txtPath03.TabIndex = 13;
            this.txtPath03.TabStop = false;
            // 
            // lblPath02
            // 
            this.lblPath02.AutoSize = true;
            this.lblPath02.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath02.Location = new System.Drawing.Point(6, 113);
            this.lblPath02.Name = "lblPath02";
            this.lblPath02.Size = new System.Drawing.Size(79, 24);
            this.lblPath02.TabIndex = 9;
            this.lblPath02.Text = "Path 02";
            // 
            // txtPath02
            // 
            this.txtPath02.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath02.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath02.Location = new System.Drawing.Point(130, 111);
            this.txtPath02.Name = "txtPath02";
            this.txtPath02.Size = new System.Drawing.Size(586, 29);
            this.txtPath02.TabIndex = 10;
            this.txtPath02.TabStop = false;
            // 
            // lblPath01
            // 
            this.lblPath01.AutoSize = true;
            this.lblPath01.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath01.Location = new System.Drawing.Point(6, 78);
            this.lblPath01.Name = "lblPath01";
            this.lblPath01.Size = new System.Drawing.Size(79, 24);
            this.lblPath01.TabIndex = 6;
            this.lblPath01.Text = "Path 01";
            // 
            // txtPath01
            // 
            this.txtPath01.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath01.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath01.Location = new System.Drawing.Point(130, 76);
            this.txtPath01.Name = "txtPath01";
            this.txtPath01.Size = new System.Drawing.Size(586, 29);
            this.txtPath01.TabIndex = 7;
            this.txtPath01.TabStop = false;
            // 
            // lblPastaSaida
            // 
            this.lblPastaSaida.AutoSize = true;
            this.lblPastaSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPastaSaida.Location = new System.Drawing.Point(6, 43);
            this.lblPastaSaida.Name = "lblPastaSaida";
            this.lblPastaSaida.Size = new System.Drawing.Size(118, 24);
            this.lblPastaSaida.TabIndex = 3;
            this.lblPastaSaida.Text = "Pasta Saída";
            // 
            // txtPastaSaida
            // 
            this.txtPastaSaida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPastaSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPastaSaida.Location = new System.Drawing.Point(130, 41);
            this.txtPastaSaida.Name = "txtPastaSaida";
            this.txtPastaSaida.Size = new System.Drawing.Size(586, 29);
            this.txtPastaSaida.TabIndex = 4;
            this.txtPastaSaida.TabStop = false;
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
            // btnPath10
            // 
            this.btnPath10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPath10.Image = global::starpatch.Properties.Resources._16_buscar_pastas;
            this.btnPath10.Location = new System.Drawing.Point(722, 390);
            this.btnPath10.Name = "btnPath10";
            this.btnPath10.Size = new System.Drawing.Size(35, 30);
            this.btnPath10.TabIndex = 35;
            this.btnPath10.UseVisualStyleBackColor = true;
            this.btnPath10.Click += new System.EventHandler(this.btnPastaMod_Click);
            // 
            // btnPath09
            // 
            this.btnPath09.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPath09.Image = global::starpatch.Properties.Resources._16_buscar_pastas;
            this.btnPath09.Location = new System.Drawing.Point(722, 355);
            this.btnPath09.Name = "btnPath09";
            this.btnPath09.Size = new System.Drawing.Size(35, 30);
            this.btnPath09.TabIndex = 32;
            this.btnPath09.UseVisualStyleBackColor = true;
            this.btnPath09.Click += new System.EventHandler(this.btnPastaMod_Click);
            // 
            // btnPath08
            // 
            this.btnPath08.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPath08.Image = global::starpatch.Properties.Resources._16_buscar_pastas;
            this.btnPath08.Location = new System.Drawing.Point(722, 320);
            this.btnPath08.Name = "btnPath08";
            this.btnPath08.Size = new System.Drawing.Size(35, 30);
            this.btnPath08.TabIndex = 29;
            this.btnPath08.UseVisualStyleBackColor = true;
            this.btnPath08.Click += new System.EventHandler(this.btnPastaMod_Click);
            // 
            // btnPath07
            // 
            this.btnPath07.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPath07.Image = global::starpatch.Properties.Resources._16_buscar_pastas;
            this.btnPath07.Location = new System.Drawing.Point(722, 285);
            this.btnPath07.Name = "btnPath07";
            this.btnPath07.Size = new System.Drawing.Size(35, 30);
            this.btnPath07.TabIndex = 26;
            this.btnPath07.UseVisualStyleBackColor = true;
            this.btnPath07.Click += new System.EventHandler(this.btnPastaMod_Click);
            // 
            // btnPath06
            // 
            this.btnPath06.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPath06.Image = global::starpatch.Properties.Resources._16_buscar_pastas;
            this.btnPath06.Location = new System.Drawing.Point(722, 250);
            this.btnPath06.Name = "btnPath06";
            this.btnPath06.Size = new System.Drawing.Size(35, 30);
            this.btnPath06.TabIndex = 23;
            this.btnPath06.UseVisualStyleBackColor = true;
            this.btnPath06.Click += new System.EventHandler(this.btnPastaMod_Click);
            // 
            // btnPath05
            // 
            this.btnPath05.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPath05.Image = global::starpatch.Properties.Resources._16_buscar_pastas;
            this.btnPath05.Location = new System.Drawing.Point(722, 215);
            this.btnPath05.Name = "btnPath05";
            this.btnPath05.Size = new System.Drawing.Size(35, 30);
            this.btnPath05.TabIndex = 20;
            this.btnPath05.UseVisualStyleBackColor = true;
            this.btnPath05.Click += new System.EventHandler(this.btnPastaMod_Click);
            // 
            // btnPath04
            // 
            this.btnPath04.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPath04.Image = global::starpatch.Properties.Resources._16_buscar_pastas;
            this.btnPath04.Location = new System.Drawing.Point(722, 180);
            this.btnPath04.Name = "btnPath04";
            this.btnPath04.Size = new System.Drawing.Size(35, 30);
            this.btnPath04.TabIndex = 17;
            this.btnPath04.UseVisualStyleBackColor = true;
            this.btnPath04.Click += new System.EventHandler(this.btnPastaMod_Click);
            // 
            // btnPath03
            // 
            this.btnPath03.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPath03.Image = global::starpatch.Properties.Resources._16_buscar_pastas;
            this.btnPath03.Location = new System.Drawing.Point(722, 145);
            this.btnPath03.Name = "btnPath03";
            this.btnPath03.Size = new System.Drawing.Size(35, 30);
            this.btnPath03.TabIndex = 14;
            this.btnPath03.UseVisualStyleBackColor = true;
            this.btnPath03.Click += new System.EventHandler(this.btnPastaMod_Click);
            // 
            // btnPath02
            // 
            this.btnPath02.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPath02.Image = global::starpatch.Properties.Resources._16_buscar_pastas;
            this.btnPath02.Location = new System.Drawing.Point(722, 110);
            this.btnPath02.Name = "btnPath02";
            this.btnPath02.Size = new System.Drawing.Size(35, 30);
            this.btnPath02.TabIndex = 11;
            this.btnPath02.UseVisualStyleBackColor = true;
            this.btnPath02.Click += new System.EventHandler(this.btnPastaMod_Click);
            // 
            // btnPath01
            // 
            this.btnPath01.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPath01.Image = global::starpatch.Properties.Resources._16_buscar_pastas;
            this.btnPath01.Location = new System.Drawing.Point(722, 75);
            this.btnPath01.Name = "btnPath01";
            this.btnPath01.Size = new System.Drawing.Size(35, 30);
            this.btnPath01.TabIndex = 8;
            this.btnPath01.UseVisualStyleBackColor = true;
            this.btnPath01.Click += new System.EventHandler(this.btnPastaMod_Click);
            // 
            // btnPastaSaida
            // 
            this.btnPastaSaida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPastaSaida.Image = global::starpatch.Properties.Resources._16_buscar_pastas;
            this.btnPastaSaida.Location = new System.Drawing.Point(722, 40);
            this.btnPastaSaida.Name = "btnPastaSaida";
            this.btnPastaSaida.Size = new System.Drawing.Size(35, 30);
            this.btnPastaSaida.TabIndex = 5;
            this.btnPastaSaida.UseVisualStyleBackColor = true;
            this.btnPastaSaida.Click += new System.EventHandler(this.btnPastaMod_Click);
            // 
            // btnPastaMod
            // 
            this.btnPastaMod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPastaMod.Image = global::starpatch.Properties.Resources._16_buscar_pastas;
            this.btnPastaMod.Location = new System.Drawing.Point(722, 5);
            this.btnPastaMod.Name = "btnPastaMod";
            this.btnPastaMod.Size = new System.Drawing.Size(35, 30);
            this.btnPastaMod.TabIndex = 2;
            this.btnPastaMod.UseVisualStyleBackColor = true;
            this.btnPastaMod.Click += new System.EventHandler(this.btnPastaMod_Click);
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
            this.btnJsonPatch.TabIndex = 2;
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
            this.btnCancelar.TabIndex = 1;
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
            this.btnProcessar.TabIndex = 3;
            this.btnProcessar.Text = "   Processar";
            this.btnProcessar.UseVisualStyleBackColor = true;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(12, 22);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(126, 24);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total Patch: ";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.pnlCarregando);
            this.Controls.Add(this.tabControlDados);
            this.Controls.Add(this.gbControles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Star Patch";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.gbControles.ResumeLayout(false);
            this.gbControles.PerformLayout();
            this.tabControlDados.ResumeLayout(false);
            this.tabPageDados.ResumeLayout(false);
            this.tabPageLog.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.pnlCarregando.ResumeLayout(false);
            this.pnlCarregando.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblPastaMod;
        private System.Windows.Forms.TextBox txtPastaMod;
        private System.Windows.Forms.Button btnPastaMod;
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
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblPath03;
        private System.Windows.Forms.Button btnPath03;
        private System.Windows.Forms.TextBox txtPath03;
        private System.Windows.Forms.Label lblPath02;
        private System.Windows.Forms.Button btnPath02;
        private System.Windows.Forms.TextBox txtPath02;
        private System.Windows.Forms.Label lblPath01;
        private System.Windows.Forms.Button btnPath01;
        private System.Windows.Forms.TextBox txtPath01;
        private System.Windows.Forms.Label lblPastaSaida;
        private System.Windows.Forms.Button btnPastaSaida;
        private System.Windows.Forms.TextBox txtPastaSaida;
        private System.Windows.Forms.Label lblPath10;
        private System.Windows.Forms.Button btnPath10;
        private System.Windows.Forms.TextBox txtPath10;
        private System.Windows.Forms.Label lblPath09;
        private System.Windows.Forms.Button btnPath09;
        private System.Windows.Forms.TextBox txtPath09;
        private System.Windows.Forms.Label lblPath08;
        private System.Windows.Forms.Button btnPath08;
        private System.Windows.Forms.TextBox txtPath08;
        private System.Windows.Forms.Label lblPath07;
        private System.Windows.Forms.Button btnPath07;
        private System.Windows.Forms.TextBox txtPath07;
        private System.Windows.Forms.Label lblPath06;
        private System.Windows.Forms.Button btnPath06;
        private System.Windows.Forms.TextBox txtPath06;
        private System.Windows.Forms.Label lblPath05;
        private System.Windows.Forms.Button btnPath05;
        private System.Windows.Forms.TextBox txtPath05;
        private System.Windows.Forms.Label lblPath04;
        private System.Windows.Forms.Button btnPath04;
        private System.Windows.Forms.TextBox txtPath04;
        private System.Windows.Forms.Label lblTotal;
    }
}

