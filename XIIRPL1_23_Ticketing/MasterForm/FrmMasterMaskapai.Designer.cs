namespace XIIRPL1_23_Ticketing.MasterForm
{
    partial class FrmMasterMaskapai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMasterMaskapai));
            label1 = new Label();
            label2 = new Label();
            dataGridViewMasterMaskapai = new DataGridView();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            label3 = new Label();
            txtNama = new TextBox();
            txtPerusahaan = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtDeskripsi = new TextBox();
            txtJumlahKru = new NumericUpDown();
            label8 = new Label();
            btnBatal = new Button();
            btnSimpan = new Button();
            id = new TextBox();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMasterMaskapai).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtJumlahKru).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(34, 23);
            label1.Name = "label1";
            label1.Size = new Size(220, 31);
            label1.TabIndex = 0;
            label1.Text = "Master Maskapai";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 63);
            label2.Name = "label2";
            label2.Size = new Size(279, 15);
            label2.TabIndex = 1;
            label2.Text = "Semua maskapai yang terdaftar akan muncul di sini";
            // 
            // dataGridViewMasterMaskapai
            // 
            dataGridViewMasterMaskapai.AllowUserToAddRows = false;
            dataGridViewMasterMaskapai.AllowUserToDeleteRows = false;
            dataGridViewMasterMaskapai.AllowUserToOrderColumns = true;
            dataGridViewMasterMaskapai.AllowUserToResizeColumns = false;
            dataGridViewMasterMaskapai.AllowUserToResizeRows = false;
            dataGridViewMasterMaskapai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMasterMaskapai.BackgroundColor = Color.White;
            dataGridViewMasterMaskapai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMasterMaskapai.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dataGridViewMasterMaskapai.Location = new Point(34, 90);
            dataGridViewMasterMaskapai.Name = "dataGridViewMasterMaskapai";
            dataGridViewMasterMaskapai.RowTemplate.Height = 25;
            dataGridViewMasterMaskapai.Size = new Size(610, 196);
            dataGridViewMasterMaskapai.TabIndex = 2;
            dataGridViewMasterMaskapai.CellContentClick += dataGridViewMasterMaskapai_CellContentClick;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 315);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 3;
            label3.Text = "Nama";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(108, 312);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(156, 23);
            txtNama.TabIndex = 4;
            // 
            // txtPerusahaan
            // 
            txtPerusahaan.Location = new Point(108, 351);
            txtPerusahaan.Name = "txtPerusahaan";
            txtPerusahaan.Size = new Size(156, 23);
            txtPerusahaan.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 354);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 5;
            label4.Text = "Perusahaan";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 395);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 7;
            label5.Text = "Jumlah Kru";
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(455, 312);
            txtDeskripsi.Multiline = true;
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(189, 98);
            txtDeskripsi.TabIndex = 10;
            // 
            // txtJumlahKru
            // 
            txtJumlahKru.Location = new Point(108, 393);
            txtJumlahKru.Name = "txtJumlahKru";
            txtJumlahKru.Size = new Size(156, 23);
            txtJumlahKru.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(383, 315);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 14;
            label8.Text = "Deskripsi";
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(407, 422);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(75, 30);
            btnBatal.TabIndex = 15;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            btnBatal.Click += btnBatal_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(569, 422);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 30);
            btnSimpan.TabIndex = 16;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // id
            // 
            id.Location = new Point(283, 392);
            id.Name = "id";
            id.Size = new Size(100, 23);
            id.TabIndex = 17;
            id.Visible = false;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(488, 422);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 30);
            btnEdit.TabIndex = 19;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // FrmMasterMaskapai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(684, 476);
            Controls.Add(btnEdit);
            Controls.Add(id);
            Controls.Add(btnSimpan);
            Controls.Add(btnBatal);
            Controls.Add(label8);
            Controls.Add(txtJumlahKru);
            Controls.Add(txtDeskripsi);
            Controls.Add(label5);
            Controls.Add(txtPerusahaan);
            Controls.Add(label4);
            Controls.Add(txtNama);
            Controls.Add(label3);
            Controls.Add(dataGridViewMasterMaskapai);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMasterMaskapai";
            Text = "Bromo Airlines - Admin";
            Load += FrmMasterMaskapai_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMasterMaskapai).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtJumlahKru).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataGridViewMasterMaskapai;
        private Label label3;
        private TextBox txtNama;
        private TextBox txtPerusahaan;
        private Label label4;
        private Label label5;
        private TextBox txtDeskripsi;
        private NumericUpDown txtJumlahKru;
        private Label label8;
        private Button btnBatal;
        private Button btnSimpan;
        private TextBox id;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Button btnEdit;
    }
}