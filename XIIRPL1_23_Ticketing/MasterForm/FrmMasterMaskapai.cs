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
    public partial class FrmMasterMaskapai : Form
    {
        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;
        public FrmMasterMaskapai()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.conn.Open();
                String insert = "INSERT INTO db_ticket_xii_rpl_1_23.tbl_maskapai " +
                    "(id,nama,perusahaan,jumlah_kru,deskripsi) " +
                    "VALUES" + "('" + id.Text + "','" + txtNama.Text + "', '" + txtPerusahaan.Text + "', '" + txtJumlahKru.Text + "', '" + txtDeskripsi.Text + "')";
                cmd = new NpgsqlCommand(insert, koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bergasil Simpan Data Bandara");
                koneksi.conn.Close();
                view_data();
                reset_form();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message: " + ex.Message);
            }
            koneksi.conn.Close();
        }

        public void view_data()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM db_ticket_xii_rpl_1_23.tbl_maskapai", koneksi.conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewMasterMaskapai.DataSource = dt;
            dataGridViewMasterMaskapai.Columns[2].HeaderText = "ID";
            dataGridViewMasterMaskapai.Columns[3].HeaderText = "Nama";
            dataGridViewMasterMaskapai.Columns[4].HeaderText = "Perusahaan";
            dataGridViewMasterMaskapai.Columns[5].HeaderText = "Jumlah Kru";
            dataGridViewMasterMaskapai.Columns[6].HeaderText = "Deskripsi";
        }

        public void nomor_urut()
        {
            int hitung, nomor;
            koneksi.conn.Open();
            string sql = "SELECT id FROM db_ticket_xii_rpl_1_23.tbl_maskapai " + "WHERE id in(select max(id) FROM db_ticket_xii_rpl_1_23.tbl_maskapai) " + "ORDER by id desc";
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

        public void reset_form()
        {
            id.Text = "";
            txtNama.Text = "";
            txtPerusahaan.Text = "";
            txtJumlahKru.Value = 0;
            txtDeskripsi.Text = "";
        }

        private void FrmMasterMaskapai_Load(object sender, EventArgs e)
        {
            nomor_urut();
            view_data();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            reset_form();
        }

        private void dataGridViewMasterMaskapai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewMasterMaskapai.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                DialogResult confirm = MessageBox.Show("Ingin Hapus Data?", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    int id;
                    id = Convert.ToInt32(dataGridViewMasterMaskapai.Rows[e.RowIndex].Cells["id"].Value);
                    try
                    {
                        koneksi.conn.Open();
                        string sql = "DELETE FROM db_ticket_xii_rpl_1_23.tbl_maskapai WHERE id=@id";
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
                id.Text = dataGridViewMasterMaskapai.Rows[rowIndex].Cells[2].Value.ToString();
                txtNama.Text = dataGridViewMasterMaskapai.Rows[rowIndex].Cells[3].Value.ToString();
                txtPerusahaan.Text = dataGridViewMasterMaskapai.Rows[rowIndex].Cells[4].Value.ToString();
                txtJumlahKru.Text = dataGridViewMasterMaskapai.Rows[rowIndex].Cells[5].Value.ToString();
                txtDeskripsi.Text = dataGridViewMasterMaskapai.Rows[rowIndex].Cells[6].Value.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.conn.Close();
                String update = "UPDATE db_ticket_xii_rpl_1_23.tbl_maskapai SET nama='" + txtNama.Text + "', perusahaan='" + txtPerusahaan.Text + "', jumlah_kru='" + txtJumlahKru.Text + "', deskripsi='" + txtDeskripsi.Text + "'WHERE id='" + id.Text + "'";
                koneksi.conn.Open();
                cmd = new NpgsqlCommand(update, koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Update Data Maskapai");
                koneksi.conn.Close();
                view_data();
                reset_form();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error Message: " + ex.Message);
            }
            koneksi.conn.Close();
        }
    }
}
