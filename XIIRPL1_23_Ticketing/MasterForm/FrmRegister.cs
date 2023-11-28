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
    public partial class FrmRegister : Form
    {
        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            nomor_urut();
        }

        private void txtLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void FrmRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.conn.Open();
                String insert = "INSERT INTO db_ticket_xii_rpl_1_23.tbl_akun (id,username,password,nama,tgl_lahir,no_telp,is_admin) VALUES" + "('"+ id.Text +"', '" + txtUsername.Text + "','" + txtPassword.Text + "', '" + txtNama.Text + "', '" + txtTglLahir.Value + "', '" + txtNomorTlp.Text + "', '" + 2 + "')";
                cmd = new NpgsqlCommand(insert, koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Daftar. Silahkan Login!");
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

        public void nomor_urut()
        {
            int hitung, nomor;
            koneksi.conn.Open();
            string sql = "SELECT id FROM db_ticket_xii_rpl_1_23.tbl_akun " + "WHERE id in(select max(id) FROM db_ticket_xii_rpl_1_23.tbl_akun) " + "ORDER by id desc";
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
    }
}
