using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XIIRPL1_23_Ticketing.MasterForm
{
    public partial class FrmMasterBandara : Form
    {
        ComboBoxFunction cb = new ComboBoxFunction();
        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;
        public FrmMasterBandara()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.conn.Open();
                String insert = "INSERT INTO db_ticket_xii_rpl_1_23.tbl_bandara " +
                    "(id,nama,kode_iata,kota,negara_id,jumlah_terminal,alamat) " +
                    "VALUES" + "('" + id.Text + "','" + txtNama.Text + "', '" + txtKodeIata.Text + "', '" + txtKota.Text + "', '" + txtNegara.SelectedValue + "', '" + txtJumlahTerminal.Text + "', '" + txtAlamat.Text + "')";
                cmd = new NpgsqlCommand(insert, koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Simpan Data Bandara");
                koneksi.conn.Close();
                nomor_urut();
                view_data();
                reset_form();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message: " + ex.Message);
                koneksi.conn.Close();
            }
        }

        public void view_data()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT db_ticket_xii_rpl_1_23.tbl_bandara.id, db_ticket_xii_rpl_1_23.tbl_bandara.nama, db_ticket_xii_rpl_1_23.tbl_bandara.kode_iata, db_ticket_xii_rpl_1_23.tbl_bandara.kota, db_ticket_xii_rpl_1_23.tbl_negara.nama, db_ticket_xii_rpl_1_23.tbl_bandara.jumlah_terminal FROM db_ticket_xii_rpl_1_23.tbl_bandara INNER JOIN db_ticket_xii_rpl_1_23.tbl_negara ON db_ticket_xii_rpl_1_23.tbl_bandara.negara_id = db_ticket_xii_rpl_1_23.tbl_negara.id", koneksi.conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewMasterBandara.DataSource = dt;
            dataGridViewMasterBandara.Columns[2].HeaderText = "ID";
            dataGridViewMasterBandara.Columns[3].HeaderText = "Nama Bandara";
            dataGridViewMasterBandara.Columns[4].HeaderText = "Kode IATA";
            dataGridViewMasterBandara.Columns[5].HeaderText = "Kota";
            dataGridViewMasterBandara.Columns[6].HeaderText = "Negara";
            dataGridViewMasterBandara.Columns[7].HeaderText = "Jumlah Terminal";
        }


        private void FrmMasterBandara_Load(object sender, EventArgs e)
        {
            view_data();
            nomor_urut();

            //Menampilkan Data Bandaradari database dan dimasukkan ke combobox
            string query = "SELECT * FROM db_ticket_xii_rpl_1_23.tbl_negara";
            /*ComboBoxFunction.Set_ComboBox(query, "nama", txtNegara);*/
            txtNegara.DataSource = cb.getData(query);
            txtNegara.DisplayMember = "nama";
            txtNegara.ValueMember = "id";
        }

        public void nomor_urut()
        {
            int hitung, nomor;
            koneksi.conn.Open();
            string sql = "SELECT id FROM db_ticket_xii_rpl_1_23.tbl_bandara " + "WHERE id in(select max(id) FROM db_ticket_xii_rpl_1_23.tbl_bandara) " + "ORDER by id desc";
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
            txtNama.Text = "";
            txtKodeIata.Text = "";
            txtKota.Text = "";
            txtNegara.Text = "";
            txtJumlahTerminal.Value = 0;
            txtAlamat.Text = "";
            btnSimpan.Enabled = true;
            btnEdit.Enabled = false;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            reset_form();
        }

        private void dataGridViewMasterBandara_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewMasterBandara.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                DialogResult confirm = MessageBox.Show("Ingin Hapus Data?", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    int id;
                    id = Convert.ToInt32(dataGridViewMasterBandara.Rows[e.RowIndex].Cells["id"].Value);
                    try
                    {
                        koneksi.conn.Open();
                        string sql = "DELETE FROM db_ticket_xii_rpl_1_23.tbl_bandara WHERE id=@id";
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
                id.Text = dataGridViewMasterBandara.Rows[rowIndex].Cells[2].Value.ToString();
                txtNama.Text = dataGridViewMasterBandara.Rows[rowIndex].Cells[3].Value.ToString();
                txtKodeIata.Text = dataGridViewMasterBandara.Rows[rowIndex].Cells[4].Value.ToString();
                txtKota.Text = dataGridViewMasterBandara.Rows[rowIndex].Cells[5].Value.ToString();
                txtNegara.Text = dataGridViewMasterBandara.Rows[rowIndex].Cells[6].Value.ToString();
                txtJumlahTerminal.Text = dataGridViewMasterBandara.Rows[rowIndex].Cells[7].Value.ToString();
                //txtAlamat.Text = dataGridViewMasterBandara.Rows[rowIndex].Cells[8].Value.ToString();
                btnSimpan.Enabled = false;
                btnEdit.Enabled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            koneksi.conn.Close();
            String update = "UPDATE db_ticket_xii_rpl_1_23.tbl_bandara SET nama='" + txtNama.Text + "', kode_iata='" + txtKodeIata.Text + "', kota='" + txtKota.Text + "', negara_id='" + txtNegara.SelectedValue + "', jumlah_terminal='" + txtJumlahTerminal.Text + "', alamat='" + txtAlamat.Text + "'WHERE id='" + id.Text + "'";
            koneksi.conn.Open();
            cmd = new NpgsqlCommand(update, koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil Update Data Bandara");
            koneksi.conn.Close();
            view_data();
            reset_form();
            btnSimpan.Enabled = true;
            btnEdit.Enabled = false;
        }

        private void txtNegara_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
