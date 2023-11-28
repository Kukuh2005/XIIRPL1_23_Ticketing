namespace XIIRPL1_23_Ticketing.MasterForm
{
    partial class FrmMasterKodePromo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMasterKodePromo));
            btnSimpan = new Button();
            btnBatal = new Button();
            label8 = new Label();
            nudPersentaseDiskon = new NumericUpDown();
            txtDeskripsi = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtKodePromo = new TextBox();
            label3 = new Label();
            dataGridViewKodePromo = new DataGridView();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            label2 = new Label();
            label1 = new Label();
            dateTimePickerBerlakuSampai = new DateTimePicker();
            nudMaksimumDiskon = new NumericUpDown();
            label6 = new Label();
            id = new TextBox();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)nudPersentaseDiskon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKodePromo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMaksimumDiskon).BeginInit();
            SuspendLayout();
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(544, 416);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 30);
            btnSimpan.TabIndex = 29;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(463, 416);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(75, 30);
            btnBatal.TabIndex = 28;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            btnBatal.Click += btnBatal_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(403, 300);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 27;
            label8.Text = "Deskripsi";
            // 
            // nudPersentaseDiskon
            // 
            nudPersentaseDiskon.Location = new Point(187, 378);
            nudPersentaseDiskon.Name = "nudPersentaseDiskon";
            nudPersentaseDiskon.Size = new Size(156, 23);
            nudPersentaseDiskon.TabIndex = 26;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(463, 297);
            txtDeskripsi.Multiline = true;
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(239, 98);
            txtDeskripsi.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(79, 380);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 24;
            label5.Text = "Persentase Diskon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 339);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 22;
            label4.Text = "Berlaku Sampai";
            // 
            // txtKodePromo
            // 
            txtKodePromo.Location = new Point(187, 297);
            txtKodePromo.Name = "txtKodePromo";
            txtKodePromo.Size = new Size(156, 23);
            txtKodePromo.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 300);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 20;
            label3.Text = "Kode Promo";
            // 
            // dataGridViewKodePromo
            // 
            dataGridViewKodePromo.AllowUserToAddRows = false;
            dataGridViewKodePromo.AllowUserToDeleteRows = false;
            dataGridViewKodePromo.AllowUserToResizeColumns = false;
            dataGridViewKodePromo.AllowUserToResizeRows = false;
            dataGridViewKodePromo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewKodePromo.BackgroundColor = Color.White;
            dataGridViewKodePromo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKodePromo.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dataGridViewKodePromo.Location = new Point(43, 72);
            dataGridViewKodePromo.Name = "dataGridViewKodePromo";
            dataGridViewKodePromo.RowTemplate.Height = 25;
            dataGridViewKodePromo.Size = new Size(714, 196);
            dataGridViewKodePromo.TabIndex = 19;
            dataGridViewKodePromo.CellContentClick += dataGridViewKodePromo_CellContentClick;
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
            label2.Location = new Point(43, 45);
            label2.Name = "label2";
            label2.Size = new Size(294, 15);
            label2.TabIndex = 18;
            label2.Text = "Semua kode promo yang terdaftar akan muncul di sini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(43, 5);
            label1.Name = "label1";
            label1.Size = new Size(252, 31);
            label1.TabIndex = 17;
            label1.Text = "Master Kode Promo";
            // 
            // dateTimePickerBerlakuSampai
            // 
            dateTimePickerBerlakuSampai.Location = new Point(187, 333);
            dateTimePickerBerlakuSampai.Name = "dateTimePickerBerlakuSampai";
            dateTimePickerBerlakuSampai.Size = new Size(156, 23);
            dateTimePickerBerlakuSampai.TabIndex = 30;
            // 
            // nudMaksimumDiskon
            // 
            nudMaksimumDiskon.Location = new Point(187, 414);
            nudMaksimumDiskon.Name = "nudMaksimumDiskon";
            nudMaksimumDiskon.Size = new Size(156, 23);
            nudMaksimumDiskon.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(79, 416);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 31;
            label6.Text = "Maksimum Diskon";
            // 
            // id
            // 
            id.Location = new Point(357, 413);
            id.Name = "id";
            id.Size = new Size(100, 23);
            id.TabIndex = 33;
            id.Visible = false;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(625, 416);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 30);
            btnEdit.TabIndex = 34;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // FrmMasterKodePromo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 468);
            Controls.Add(btnEdit);
            Controls.Add(id);
            Controls.Add(nudMaksimumDiskon);
            Controls.Add(label6);
            Controls.Add(dateTimePickerBerlakuSampai);
            Controls.Add(btnSimpan);
            Controls.Add(btnBatal);
            Controls.Add(label8);
            Controls.Add(nudPersentaseDiskon);
            Controls.Add(txtDeskripsi);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtKodePromo);
            Controls.Add(label3);
            Controls.Add(dataGridViewKodePromo);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMasterKodePromo";
            Text = "Bromo Airlines - Admin";
            Load += FrmMasterKodePromo_Load;
            ((System.ComponentModel.ISupportInitialize)nudPersentaseDiskon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKodePromo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMaksimumDiskon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSimpan;
        private Button btnBatal;
        private Label label8;
        private NumericUpDown nudPersentaseDiskon;
        private TextBox txtDeskripsi;
        private Label label5;
        private Label label4;
        private TextBox txtKodePromo;
        private Label label3;
        private DataGridView dataGridViewKodePromo;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePickerBerlakuSampai;
        private NumericUpDown nudMaksimumDiskon;
        private Label label6;
        private TextBox id;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Button btnEdit;
    }
}