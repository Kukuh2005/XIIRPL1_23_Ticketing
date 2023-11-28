namespace XIIRPL1_23_Ticketing.MasterForm
{
    partial class FrmMasterBandara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMasterBandara));
            btnSimpan = new Button();
            btnBatal = new Button();
            label8 = new Label();
            txtJumlahTerminal = new NumericUpDown();
            label7 = new Label();
            txtNegara = new ComboBox();
            txtAlamat = new TextBox();
            label6 = new Label();
            txtKota = new TextBox();
            label5 = new Label();
            txtKodeIata = new TextBox();
            label4 = new Label();
            txtNama = new TextBox();
            label3 = new Label();
            dataGridViewMasterBandara = new DataGridView();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            label2 = new Label();
            label1 = new Label();
            id = new TextBox();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)txtJumlahTerminal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMasterBandara).BeginInit();
            SuspendLayout();
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(459, 411);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 30);
            btnSimpan.TabIndex = 33;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(621, 411);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(75, 30);
            btnBatal.TabIndex = 32;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            btnBatal.Click += btnBatal_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(429, 343);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 31;
            label8.Text = "Alamat";
            // 
            // txtJumlahTerminal
            // 
            txtJumlahTerminal.Location = new Point(528, 299);
            txtJumlahTerminal.Name = "txtJumlahTerminal";
            txtJumlahTerminal.Size = new Size(168, 23);
            txtJumlahTerminal.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(429, 301);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 29;
            label7.Text = "Jumlah Terminal";
            // 
            // txtNegara
            // 
            txtNegara.FormattingEnabled = true;
            txtNegara.Location = new Point(103, 413);
            txtNegara.Name = "txtNegara";
            txtNegara.Size = new Size(156, 23);
            txtNegara.TabIndex = 28;
            txtNegara.SelectedIndexChanged += txtNegara_SelectedIndexChanged;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(528, 340);
            txtAlamat.Multiline = true;
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(168, 64);
            txtAlamat.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 416);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 26;
            label6.Text = "Negara";
            // 
            // txtKota
            // 
            txtKota.Location = new Point(103, 378);
            txtKota.Name = "txtKota";
            txtKota.Size = new Size(156, 23);
            txtKota.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 381);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 24;
            label5.Text = "Kota";
            // 
            // txtKodeIata
            // 
            txtKodeIata.Location = new Point(103, 337);
            txtKodeIata.Name = "txtKodeIata";
            txtKodeIata.Size = new Size(156, 23);
            txtKodeIata.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 340);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 22;
            label4.Text = "Kode IATA";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(103, 298);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(156, 23);
            txtNama.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 301);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 20;
            label3.Text = "Nama";
            // 
            // dataGridViewMasterBandara
            // 
            dataGridViewMasterBandara.AllowUserToAddRows = false;
            dataGridViewMasterBandara.AllowUserToDeleteRows = false;
            dataGridViewMasterBandara.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMasterBandara.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewMasterBandara.BackgroundColor = Color.White;
            dataGridViewMasterBandara.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMasterBandara.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dataGridViewMasterBandara.Location = new Point(37, 76);
            dataGridViewMasterBandara.Name = "dataGridViewMasterBandara";
            dataGridViewMasterBandara.RowTemplate.Height = 25;
            dataGridViewMasterBandara.Size = new Size(659, 196);
            dataGridViewMasterBandara.TabIndex = 19;
            dataGridViewMasterBandara.CellClick += dataGridViewMasterBandara_CellClick;
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit";
            Edit.Name = "Edit";
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 49);
            label2.Name = "label2";
            label2.Size = new Size(272, 15);
            label2.TabIndex = 18;
            label2.Text = "Semua bandara yang terdaftar akan muncul di sini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(37, 9);
            label1.Name = "label1";
            label1.Size = new Size(206, 31);
            label1.TabIndex = 17;
            label1.Text = "Master Bandara";
            // 
            // id
            // 
            id.Location = new Point(286, 415);
            id.Name = "id";
            id.Size = new Size(108, 23);
            id.TabIndex = 34;
            id.Visible = false;
            // 
            // btnEdit
            // 
            btnEdit.Enabled = false;
            btnEdit.Location = new Point(540, 410);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 30);
            btnEdit.TabIndex = 35;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // FrmMasterBandara
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(736, 466);
            Controls.Add(btnEdit);
            Controls.Add(id);
            Controls.Add(btnSimpan);
            Controls.Add(btnBatal);
            Controls.Add(label8);
            Controls.Add(txtJumlahTerminal);
            Controls.Add(label7);
            Controls.Add(txtNegara);
            Controls.Add(txtAlamat);
            Controls.Add(label6);
            Controls.Add(txtKota);
            Controls.Add(label5);
            Controls.Add(txtKodeIata);
            Controls.Add(label4);
            Controls.Add(txtNama);
            Controls.Add(label3);
            Controls.Add(dataGridViewMasterBandara);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMasterBandara";
            Text = "Bromo Airlines - Admin";
            Load += FrmMasterBandara_Load;
            ((System.ComponentModel.ISupportInitialize)txtJumlahTerminal).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMasterBandara).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSimpan;
        private Button btnBatal;
        private Label label8;
        private NumericUpDown txtJumlahTerminal;
        private Label label7;
        private ComboBox txtNegara;
        private TextBox txtAlamat;
        private Label label6;
        private TextBox txtKota;
        private Label label5;
        private TextBox txtKodeIata;
        private Label label4;
        private TextBox txtNama;
        private Label label3;
        private DataGridView dataGridViewMasterBandara;
        private Label label2;
        private Label label1;
        private TextBox id;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Button btnEdit;
    }
}