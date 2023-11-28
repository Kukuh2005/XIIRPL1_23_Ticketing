namespace XIIRPL1_23_Ticketing.MasterForm
{
    partial class FrmMasterJadwalPenerbangan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMasterJadwalPenerbangan));
            btnSimpan = new Button();
            btnBatal = new Button();
            label8 = new Label();
            label7 = new Label();
            txtDari = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtKodePenerbangan = new TextBox();
            label3 = new Label();
            dataGridViewJadwalPenerbangan = new DataGridView();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            label2 = new Label();
            label1 = new Label();
            txtKe = new ComboBox();
            txtMaskapai = new ComboBox();
            Tanggal = new DateTimePicker();
            label9 = new Label();
            label10 = new Label();
            txtHargaPerTiket = new NumericUpDown();
            id = new TextBox();
            txtWaktuPenerbangan = new TextBox();
            dateTimePickerWaktuKeberangkatan = new DateTimePicker();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewJadwalPenerbangan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtHargaPerTiket).BeginInit();
            SuspendLayout();
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(655, 455);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 30);
            btnSimpan.TabIndex = 50;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += button2_Click;
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(574, 455);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(75, 30);
            btnBatal.TabIndex = 49;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            btnBatal.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(445, 346);
            label8.Name = "label8";
            label8.Size = new Size(123, 15);
            label8.TabIndex = 48;
            label8.Text = "Waktu Keberangkatan";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(445, 304);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 46;
            label7.Text = "Tanggal";
            // 
            // txtDari
            // 
            txtDari.FormattingEnabled = true;
            txtDari.Location = new Point(144, 340);
            txtDari.Name = "txtDari";
            txtDari.Size = new Size(156, 23);
            txtDari.TabIndex = 45;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 419);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 43;
            label6.Text = "Maskapai";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 384);
            label5.Name = "label5";
            label5.Size = new Size(20, 15);
            label5.TabIndex = 41;
            label5.Text = "Ke";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 343);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 39;
            label4.Text = "Dari";
            // 
            // txtKodePenerbangan
            // 
            txtKodePenerbangan.Location = new Point(144, 301);
            txtKodePenerbangan.Name = "txtKodePenerbangan";
            txtKodePenerbangan.Size = new Size(156, 23);
            txtKodePenerbangan.TabIndex = 38;
            txtKodePenerbangan.Text = "__-__";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 304);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 37;
            label3.Text = "Kode Penerbangan";
            // 
            // dataGridViewJadwalPenerbangan
            // 
            dataGridViewJadwalPenerbangan.AllowUserToAddRows = false;
            dataGridViewJadwalPenerbangan.AllowUserToResizeColumns = false;
            dataGridViewJadwalPenerbangan.AllowUserToResizeRows = false;
            dataGridViewJadwalPenerbangan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewJadwalPenerbangan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewJadwalPenerbangan.BackgroundColor = Color.White;
            dataGridViewJadwalPenerbangan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewJadwalPenerbangan.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dataGridViewJadwalPenerbangan.Location = new Point(31, 76);
            dataGridViewJadwalPenerbangan.Name = "dataGridViewJadwalPenerbangan";
            dataGridViewJadwalPenerbangan.RowTemplate.Height = 25;
            dataGridViewJadwalPenerbangan.Size = new Size(842, 196);
            dataGridViewJadwalPenerbangan.TabIndex = 36;
            dataGridViewJadwalPenerbangan.CellContentClick += dataGridViewJadwalPenerbangan_CellContentClick;
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit";
            Edit.Name = "Edit";
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            Edit.Width = 33;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 46;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 49);
            label2.Name = "label2";
            label2.Size = new Size(259, 15);
            label2.TabIndex = 35;
            label2.Text = "Semua jadwal penerbangan akan muncul di sini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(31, 9);
            label1.Name = "label1";
            label1.Size = new Size(349, 31);
            label1.TabIndex = 34;
            label1.Text = "Master Jadwal Penerbangan";
            // 
            // txtKe
            // 
            txtKe.FormattingEnabled = true;
            txtKe.Location = new Point(144, 381);
            txtKe.Name = "txtKe";
            txtKe.Size = new Size(156, 23);
            txtKe.TabIndex = 51;
            // 
            // txtMaskapai
            // 
            txtMaskapai.FormattingEnabled = true;
            txtMaskapai.Location = new Point(144, 416);
            txtMaskapai.Name = "txtMaskapai";
            txtMaskapai.Size = new Size(156, 23);
            txtMaskapai.TabIndex = 52;
            // 
            // Tanggal
            // 
            Tanggal.Location = new Point(574, 301);
            Tanggal.Name = "Tanggal";
            Tanggal.Size = new Size(156, 23);
            Tanggal.TabIndex = 53;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(445, 382);
            label9.Name = "label9";
            label9.Size = new Size(114, 15);
            label9.TabIndex = 55;
            label9.Text = "Waktu Penerbangan";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(445, 422);
            label10.Name = "label10";
            label10.Size = new Size(87, 15);
            label10.TabIndex = 56;
            label10.Text = "Harga per Tiket";
            // 
            // txtHargaPerTiket
            // 
            txtHargaPerTiket.Location = new Point(574, 419);
            txtHargaPerTiket.Name = "txtHargaPerTiket";
            txtHargaPerTiket.Size = new Size(156, 23);
            txtHargaPerTiket.TabIndex = 57;
            // 
            // id
            // 
            id.Location = new Point(317, 416);
            id.Name = "id";
            id.Size = new Size(100, 23);
            id.TabIndex = 58;
            id.Visible = false;
            // 
            // txtWaktuPenerbangan
            // 
            txtWaktuPenerbangan.Location = new Point(574, 379);
            txtWaktuPenerbangan.Name = "txtWaktuPenerbangan";
            txtWaktuPenerbangan.Size = new Size(156, 23);
            txtWaktuPenerbangan.TabIndex = 54;
            txtWaktuPenerbangan.Text = "_jam_menit";
            // 
            // dateTimePickerWaktuKeberangkatan
            // 
            dateTimePickerWaktuKeberangkatan.Format = DateTimePickerFormat.Time;
            dateTimePickerWaktuKeberangkatan.Location = new Point(574, 338);
            dateTimePickerWaktuKeberangkatan.Name = "dateTimePickerWaktuKeberangkatan";
            dateTimePickerWaktuKeberangkatan.Size = new Size(156, 23);
            dateTimePickerWaktuKeberangkatan.TabIndex = 59;
            // 
            // btnEdit
            // 
            btnEdit.Enabled = false;
            btnEdit.Location = new Point(736, 455);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 30);
            btnEdit.TabIndex = 60;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // FrmMasterJadwalPenerbangan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(905, 505);
            Controls.Add(btnEdit);
            Controls.Add(dateTimePickerWaktuKeberangkatan);
            Controls.Add(id);
            Controls.Add(txtHargaPerTiket);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtWaktuPenerbangan);
            Controls.Add(Tanggal);
            Controls.Add(txtMaskapai);
            Controls.Add(txtKe);
            Controls.Add(btnSimpan);
            Controls.Add(btnBatal);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtDari);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtKodePenerbangan);
            Controls.Add(label3);
            Controls.Add(dataGridViewJadwalPenerbangan);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMasterJadwalPenerbangan";
            Text = "Bromo Airlines - Admin";
            Load += FrmMasterJadwalPenerbangan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewJadwalPenerbangan).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtHargaPerTiket).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSimpan;
        private Button btnBatal;
        private Label label8;
        private Label label7;
        private ComboBox txtDari;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtKodePenerbangan;
        private Label label3;
        private DataGridView dataGridViewJadwalPenerbangan;
        private Label label2;
        private Label label1;
        private ComboBox txtKe;
        private ComboBox txtMaskapai;
        private DateTimePicker Tanggal;
        private Label label9;
        private Label label10;
        private NumericUpDown txtHargaPerTiket;
        private TextBox id;
        private TextBox txtWaktuPenerbangan;
        private DateTimePicker dateTimePickerWaktuKeberangkatan;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Button btnEdit;
    }
}