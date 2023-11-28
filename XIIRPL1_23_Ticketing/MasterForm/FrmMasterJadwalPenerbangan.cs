using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XIIRPL1_23_Ticketing.MasterForm
{
    public partial class FrmMasterJadwalPenerbangan : Form
    {
        ComboBoxFunction cb = new ComboBoxFunction();
        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;
        public FrmMasterJadwalPenerbangan()
        {
            InitializeComponent();
        }

        public void view_data()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT db_ticket_xii_rpl_1_23.tbl_jadwal_penerbangan.id, db_ticket_xii_rpl_1_23.tbl_jadwal_penerbangan.kode_penerbangan, db_ticket_xii_rpl_1_23.tbl_jadwal_penerbangan.bandara_keberangkatan_id, db_ticket_xii_rpl_1_23.tbl_jadwal_penerbangan.bandara_tujuan_id, db_ticket_xii_rpl_1_23.tbl_maskapai.nama AS maskapai_id, db_ticket_xii_rpl_1_23.tbl_jadwal_penerbangan.tanggal_keberangkatan, db_ticket_xii_rpl_1_23.tbl_jadwal_penerbangan.durasi_penerbangan, db_ticket_xii_rpl_1_23.tbl_jadwal_penerbangan.harga_per_tiket, db_ticket_xii_rpl_1_23.tbl_jadwal_penerbangan.waktu_keberangkatan FROM db_ticket_xii_rpl_1_23.tbl_jadwal_penerbangan INNER JOIN db_ticket_xii_rpl_1_23.tbl_maskapai ON db_ticket_xii_rpl_1_23.tbl_jadwal_penerbangan.maskapai_id = db_ticket_xii_rpl_1_23.tbl_maskapai.id", koneksi.conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewJadwalPenerbangan.DataSource = dt;
            dataGridViewJadwalPenerbangan.Columns[2].HeaderText = "ID";
            dataGridViewJadwalPenerbangan.Columns[3].HeaderText = "Kode Penerbangan";
            dataGridViewJadwalPenerbangan.Columns[4].HeaderText = "Bandara Keberangkatan";
            dataGridViewJadwalPenerbangan.Columns[5].HeaderText = "Bandara Tujuan";
            dataGridViewJadwalPenerbangan.Columns[6].HeaderText = "Maskapai";
            dataGridViewJadwalPenerbangan.Columns[7].HeaderText = "Tanggal";
            dataGridViewJadwalPenerbangan.Columns[8].HeaderText = "Durasi";
            dataGridViewJadwalPenerbangan.Columns[9].HeaderText = "Harga";
            dataGridViewJadwalPenerbangan.Columns[10].HeaderText = "Waktu";
        }

        private void FrmMasterJadwalPenerbangan_Load(object sender, EventArgs e)
        {
            view_data();
            nomor_urut();
            bandara();
            maskapai();
        }

        public void bandara()
        {
            //Menampilkan Data Bandara dari database dan dimasukkan ke combobox
            string query = "SELECT * FROM db_ticket_xii_rpl_1_23.tbl_bandara";

            txtKe.DataSource = cb.getData(query);
            txtKe.DisplayMember = "nama";
            txtKe.ValueMember = "id";

            txtDari.DataSource = cb.getData(query);
            txtDari.DisplayMember = "nama";
            txtDari.ValueMember = "id";
        }

        public void maskapai()
        {
            //Menampilkan Data maskapai dari database dan dimasukkan ke combobox
            string query = "SELECT * FROM db_ticket_xii_rpl_1_23.tbl_maskapai";

            txtMaskapai.DataSource = cb.getData(query);
            txtMaskapai.DisplayMember = "nama";
            txtMaskapai.ValueMember = "id";
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.conn.Open();
                String insert = "INSERT INTO db_ticket_xii_rpl_1_23.tbl_jadwal_penerbangan " +
                    "(id,kode_penerbangan,bandara_keberangkatan_id,bandara_tujuan_id,maskapai_id,tanggal_keberangkatan,durasi_penerbangan, harga_per_tiket,waktu_keberangkatan) " +
                    "VALUES" + "('" + id.Text + "','" + txtKodePenerbangan.Text + "','" + txtDari.SelectedValue + "', '" + txtKe.SelectedValue + "', '" + txtMaskapai.SelectedValue + "', '" + Tanggal.Value.ToString() + "','" + txtWaktuPenerbangan.Text + "', '" + txtHargaPerTiket.Text + "', '" + dateTimePickerWaktuKeberangkatan.Value + "')";
                cmd = new NpgsqlCommand(insert, koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Simpan Data Jadwal Penerbangan");
                koneksi.conn.Close();
                view_data();
                reset_form();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message: " + ex.Message);
                koneksi.conn.Close();
            }
        }

        public void reset_form()
        {
            txtKodePenerbangan.Text = "";
            txtDari.Text = "";
            txtKe.Text = "";
            txtMaskapai.Text = "";
            Tanggal.Value = DateTime.Now;
            dateTimePickerWaktuKeberangkatan.Value = DateTime.Now;
            txtWaktuPenerbangan.Text = "";
            txtHargaPerTiket.Value = 0;
            nomor_urut();
            btnSimpan.Enabled = true;
            btnEdit.Enabled = false;
        }

        public void nomor_urut()
        {
            int hitung, nomor;
            koneksi.conn.Open();
            string sql = "SELECT id FROM db_ticket_xii_rpl_1_23.tbl_jadwal_penerbangan " + "WHERE id in(select max(id) FROM db_ticket_xii_rpl_1_23.tbl_jadwal_penerbangan) " + "ORDER by id desc";
            cmd = new NpgsqlCommand(sql, koneksi.conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                nomor = Convert.ToInt32(dr[0]);
                hitung = nomor + 1;
            }
            else
            {
                hitung = 1;
            }
            dr.Close();
            id.Text = Convert.ToString(hitung);
            koneksi.conn.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            reset_form();
        }

        private void dataGridViewJadwalPenerbangan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewJadwalPenerbangan.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                DialogResult confirm = MessageBox.Show("Ingin Hapus Data?", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    int id;
                    id = Convert.ToInt32(dataGridViewJadwalPenerbangan.Rows[e.RowIndex].Cells["id"].Value);
                    try
                    {
                        koneksi.conn.Open();
                        string sql = "DELETE FROM db_ticket_xii_rpl_1_23.tbl_jadwal_penerbangan WHERE id=@id";
                        cmd = new NpgsqlCommand(sql, koneksi.conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Data Berhasil Dihapus");
                            view_data();
                        }
                        else
                        {
                            MessageBox.Show("Data Tidak Berhasil Dihapus");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        koneksi.conn.Close();
                    }
                }
            }
            else
            {
                // Dapatkan indeks baris yang diklik
                int rowIndex = e.RowIndex;

                // Dapatkan data pada baris yang sesuai
                id.Text = dataGridViewJadwalPenerbangan.Rows[rowIndex].Cells[2].Value.ToString();
                txtKodePenerbangan.Text = dataGridViewJadwalPenerbangan.Rows[rowIndex].Cells[3].Value.ToString();
                txtDari.Text = dataGridViewJadwalPenerbangan.Rows[rowIndex].Cells[4].Value.ToString();
                txtKe.Text = dataGridViewJadwalPenerbangan.Rows[rowIndex].Cells[5].Value.ToString();
                txtMaskapai.Text = dataGridViewJadwalPenerbangan.Rows[rowIndex].Cells[6].Value.ToString();
                Tanggal.Text = dataGridViewJadwalPenerbangan.Rows[rowIndex].Cells[7].Value.ToString();
                txtWaktuPenerbangan.Text = dataGridViewJadwalPenerbangan.Rows[rowIndex].Cells[8].Value.ToString();
                txtHargaPerTiket.Text = dataGridViewJadwalPenerbangan.Rows[rowIndex].Cells[9].Value.ToString();

                string waktu_keberangkatan = dataGridViewJadwalPenerbangan.Rows[rowIndex].Cells[10].Value.ToString();
                dateTimePickerWaktuKeberangkatan.Value = DateTime.Parse(waktu_keberangkatan);

                btnSimpan.Enabled = false;
                btnEdit.Enabled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.conn.Close();
                String update = "UPDATE db_ticket_xii_rpl_1_23.tbl_jadwal_penerbangan SET kode_penerbangan='" + txtKodePenerbangan.Text + "', bandara_keberangkatan_id='" + txtDari.SelectedValue + "', bandara_tujuan_id='" + txtKe.SelectedValue + "', maskapai_id='" + txtMaskapai.SelectedValue + "', tanggal_keberangkatan='" + Tanggal.Value + "', durasi_penerbangan='" + txtWaktuPenerbangan.Text + "', harga_per_tiket='" + txtHargaPerTiket.Value + "', waktu_keberangkatan='" + dateTimePickerWaktuKeberangkatan.Value + "' WHERE id='" + id.Text + "'";
                koneksi.conn.Open();
                cmd = new NpgsqlCommand(update, koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Update Data Jadwal Penerbangan");
                koneksi.conn.Close();
                view_data();
                reset_form();
                btnSimpan.Enabled = true;
                btnEdit.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
