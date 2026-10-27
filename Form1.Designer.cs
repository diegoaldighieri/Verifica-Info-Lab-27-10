namespace MinecraftManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTipo = new Label();
            cmbTipo = new ComboBox();
            lblNome = new Label();
            txtNome = new TextBox();
            lblValore = new Label();
            txtValore = new TextBox();
            lblRarita = new Label();
            cmbRarita = new ComboBox();
            lblToolType = new Label();
            cmbToolType = new ComboBox();
            lblDurabilita = new Label();
            txtDurabilita = new TextBox();
            lblStackable = new Label();
            chkStackable = new CheckBox();
            lblDurezza = new Label();
            txtDurezza = new TextBox();
            btnAggiungi = new Button();
            btnCrafta = new Button();
            dgvInventario = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNome = new DataGridViewTextBoxColumn();
            colDettagli = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            SuspendLayout();
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(20, 23);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(36, 20);
            lblTipo.TabIndex = 0;
            lblTipo.Text = "Tipo";
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Tool", "Block" });
            cmbTipo.Location = new Point(130, 20);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(160, 28);
            cmbTipo.TabIndex = 1;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(20, 58);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 20);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(130, 55);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(160, 27);
            txtNome.TabIndex = 3;
            // 
            // lblValore
            // 
            lblValore.AutoSize = true;
            lblValore.Location = new Point(20, 93);
            lblValore.Name = "lblValore";
            lblValore.Size = new Size(84, 20);
            lblValore.TabIndex = 4;
            lblValore.Text = "Valore (XP)";
            // 
            // txtValore
            // 
            txtValore.Location = new Point(130, 90);
            txtValore.Name = "txtValore";
            txtValore.Size = new Size(160, 27);
            txtValore.TabIndex = 5;
            // 
            // lblRarita
            // 
            lblRarita.AutoSize = true;
            lblRarita.Location = new Point(20, 128);
            lblRarita.Name = "lblRarita";
            lblRarita.Size = new Size(50, 20);
            lblRarita.TabIndex = 6;
            lblRarita.Text = "Rarità";
            // 
            // cmbRarita
            // 
            cmbRarita.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRarita.FormattingEnabled = true;
            cmbRarita.Location = new Point(130, 125);
            cmbRarita.Name = "cmbRarita";
            cmbRarita.Size = new Size(160, 28);
            cmbRarita.TabIndex = 7;
            // 
            // lblToolType
            // 
            lblToolType.AutoSize = true;
            lblToolType.Location = new Point(20, 163);
            lblToolType.Name = "lblToolType";
            lblToolType.Size = new Size(98, 20);
            lblToolType.TabIndex = 8;
            lblToolType.Text = "Tipo attrezzo";
            // 
            // cmbToolType
            // 
            cmbToolType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbToolType.FormattingEnabled = true;
            cmbToolType.Location = new Point(130, 160);
            cmbToolType.Name = "cmbToolType";
            cmbToolType.Size = new Size(160, 28);
            cmbToolType.TabIndex = 9;
            // 
            // lblDurabilita
            // 
            lblDurabilita.AutoSize = true;
            lblDurabilita.Location = new Point(20, 198);
            lblDurabilita.Name = "lblDurabilita";
            lblDurabilita.Size = new Size(79, 20);
            lblDurabilita.TabIndex = 10;
            lblDurabilita.Text = "Durabilità";
            // 
            // txtDurabilita
            // 
            txtDurabilita.Location = new Point(130, 195);
            txtDurabilita.Name = "txtDurabilita";
            txtDurabilita.Size = new Size(160, 27);
            txtDurabilita.TabIndex = 11;
            // 
            // lblStackable
            // 
            lblStackable.AutoSize = true;
            lblStackable.Location = new Point(20, 233);
            lblStackable.Name = "lblStackable";
            lblStackable.Size = new Size(77, 20);
            lblStackable.TabIndex = 12;
            lblStackable.Text = "Stackabile";
            // 
            // chkStackable
            // 
            chkStackable.AutoSize = true;
            chkStackable.Location = new Point(130, 235);
            chkStackable.Name = "chkStackable";
            chkStackable.Size = new Size(18, 17);
            chkStackable.TabIndex = 13;
            chkStackable.UseVisualStyleBackColor = true;
            // 
            // lblDurezza
            // 
            lblDurezza.AutoSize = true;
            lblDurezza.Location = new Point(20, 268);
            lblDurezza.Name = "lblDurezza";
            lblDurezza.Size = new Size(64, 20);
            lblDurezza.TabIndex = 14;
            lblDurezza.Text = "Durezza";
            // 
            // txtDurezza
            // 
            txtDurezza.Location = new Point(130, 265);
            txtDurezza.Name = "txtDurezza";
            txtDurezza.Size = new Size(160, 27);
            txtDurezza.TabIndex = 15;
            // 
            // btnAggiungi
            // 
            btnAggiungi.Location = new Point(20, 310);
            btnAggiungi.Name = "btnAggiungi";
            btnAggiungi.Size = new Size(120, 35);
            btnAggiungi.TabIndex = 16;
            btnAggiungi.Text = "Aggiungi";
            btnAggiungi.UseVisualStyleBackColor = true;
            btnAggiungi.Click += btnAggiungi_Click;
            // 
            // btnCrafta
            // 
            btnCrafta.Location = new Point(150, 310);
            btnCrafta.Name = "btnCrafta";
            btnCrafta.Size = new Size(140, 35);
            btnCrafta.TabIndex = 17;
            btnCrafta.Text = "Crafta selezionato";
            btnCrafta.UseVisualStyleBackColor = true;
            btnCrafta.Click += btnCrafta_Click;
            // 
            // dgvInventario
            // 
            dgvInventario.AllowUserToAddRows = false;
            dgvInventario.AllowUserToDeleteRows = false;
            dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Columns.AddRange(new DataGridViewColumn[] { colId, colNome, colDettagli });
            dgvInventario.Location = new Point(310, 20);
            dgvInventario.MultiSelect = false;
            dgvInventario.Name = "dgvInventario";
            dgvInventario.ReadOnly = true;
            dgvInventario.RowHeadersVisible = false;
            dgvInventario.RowHeadersWidth = 51;
            dgvInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventario.Size = new Size(600, 390);
            dgvInventario.TabIndex = 18;
            // 
            // colId
            // 
            colId.FillWeight = 40F;
            colId.HeaderText = "Id";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colNome
            // 
            colNome.FillWeight = 80F;
            colNome.HeaderText = "Nome";
            colNome.MinimumWidth = 6;
            colNome.Name = "colNome";
            colNome.ReadOnly = true;
            // 
            // colDettagli
            // 
            colDettagli.FillWeight = 300F;
            colDettagli.HeaderText = "Dettagli";
            colDettagli.MinimumWidth = 6;
            colDettagli.Name = "colDettagli";
            colDettagli.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 430);
            Controls.Add(dgvInventario);
            Controls.Add(btnCrafta);
            Controls.Add(btnAggiungi);
            Controls.Add(txtDurezza);
            Controls.Add(lblDurezza);
            Controls.Add(chkStackable);
            Controls.Add(lblStackable);
            Controls.Add(txtDurabilita);
            Controls.Add(lblDurabilita);
            Controls.Add(cmbToolType);
            Controls.Add(lblToolType);
            Controls.Add(cmbRarita);
            Controls.Add(lblRarita);
            Controls.Add(txtValore);
            Controls.Add(lblValore);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(cmbTipo);
            Controls.Add(lblTipo);
            Name = "Form1";
            Text = "Minecraft Resource & Crafting Manager";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTipo;
        private ComboBox cmbTipo;
        private Label lblNome;
        private TextBox txtNome;
        private Label lblValore;
        private TextBox txtValore;
        private Label lblRarita;
        private ComboBox cmbRarita;
        private Label lblToolType;
        private ComboBox cmbToolType;
        private Label lblDurabilita;
        private TextBox txtDurabilita;
        private Label lblStackable;
        private CheckBox chkStackable;
        private Label lblDurezza;
        private TextBox txtDurezza;
        private Button btnAggiungi;
        private Button btnCrafta;
        private DataGridView dgvInventario;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colDettagli;
    }
}
