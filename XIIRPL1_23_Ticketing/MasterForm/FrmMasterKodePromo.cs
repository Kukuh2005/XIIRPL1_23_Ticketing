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
    public partial class FrmMasterKodePromo : Form
    {
        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;
        public FrmMasterKodePromo()
        {
            InitializeComponent();
        }

        public void view_data()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM db_ticket_xii_rpl_1_23.tbl_kode_promo", koneksi.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "db_ticket_xii_rpl_1_23.tbl_kode_promo");
            dataGridViewKodePromo.DataSource = ds.Tables[0].DefaultView;
        }

        private void FrmMasterKodePromo_Load(object sender, EventArgs e)
        {
            view_data();
            nomor_urut();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            koneksi.conn.Open();
            try
            {
                String sql = "INSERT INTO db_ticket_xii_rpl_1_23.tbl_kode_promo " +
                    "(id,kode,persentase_diskon,maksimum_diskon,berlaku_sampai,deskripsi) " +
                    "VALUES" + "('" + id.Text + "','" + txtKodePromo.Text + "', '" + nudPersentaseDiskon.Text + "', '" + nudMaksimumDiskon.Text + "', '" + dateTimePickerBerlakuSampai.Text + "', '" + txtDeskripsi.Text + "')";
                cmd = new NpgsqlCommand(sql, koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bergasil Simpan Data Bandara");
                koneksi.conn.Close();
                view_data();
                reset_form();
                nomor_urut();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message: " + ex.Message);
                koneksi.conn.Close();
            }
        }

        public void nomor_urut()
        {
            int hitung, nomor;
            koneksi.conn.Open();
            string sql = "SELECT id FROM db_ticket_xii_rpl_1_23.tbl_kode_promo " + "WHERE id in(select max(id) FROM db_ticket_xii_rpl_1_23.tbl_kode_promo) " + "ORDER by id desc";
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
            txtKodePromo.Text = "";
            dateTimePickerBerlakuSampai.Value = DateTime.Now;
            nudPersentaseDiskon.Text = "";
            nudMaksimumDiskon.Text = "";
            txtDeskripsi.Text = "";
            nomor_urut();
            btnSimpan.Enabled = true;
            btnEdit.Enabled = false;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            reset_form();
        }

        private void dataGridViewKodePromo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewKodePromo.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                DialogResult confirm = MessageBox.Show("Ingin Hapus Data?", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    int id;
                    id = Convert.ToInt32(dataGridViewKodePromo.Rows[e.RowIndex].Cells["id"].Value);
                    try
                    {
                        koneksi.conn.Open();
                        string sql = "DELETE FROM db_ticket_xii_rpl_1_23.tbl_Kode_promo WHERE id=@id";
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
                id.Text = Convert.ToString(dataGridViewKodePromo.Rows[e.RowIndex].Cells["id"].Value);
                txtKodePromo.Text = Convert.ToString(dataGridViewKodePromo.Rows[e.RowIndex].Cells["kode"].Value);
                nudPersentaseDiskon.Text = Convert.ToString(dataGridViewKodePromo.Rows[e.RowIndex].Cells["Persentase_diskon"].Value);
                nudMaksimumDiskon.Text = Convert.ToString(dataGridViewKodePromo.Rows[e.RowIndex].Cells["maksimum_diskon"].Value);
                dateTimePickerBerlakuSampai.Value = Convert.ToDateTime(dataGridViewKodePromo.Rows[e.RowIndex].Cells["berlaku_sampai"].Value);
                txtDeskripsi.Text = Convert.ToString(dataGridViewKodePromo.Rows[e.RowIndex].Cells["deskripsi"].Value);

                btnSimpan.Enabled = false;
                btnEdit.Enabled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.conn.Close();
                String update = "UPDATE db_ticket_xii_rpl_1_23.tbl_kode_promo SET kode='" + txtKodePromo.Text + "', persentase_diskon='" + nudPersentaseDiskon.Text + "', maksimum_diskon='" + nudMaksimumDiskon.Text + "', berlaku_sampai='" + dateTimePickerBerlakuSampai.Value + "', deskripsi='" + txtDeskripsi.Text + "'  WHERE id='" + id.Text + "'";
                koneksi.conn.Open();
                cmd = new NpgsqlCommand(update, koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Update Data Kode Promo");
                koneksi.conn.Close();
                view_data();
                reset_form();
                btnSimpan.Enabled = true;
                btnEdit.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                koneksi.conn.Open();
            }
        }
    }
}
