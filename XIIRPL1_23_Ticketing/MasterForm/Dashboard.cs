using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace XIIRPL1_23_Ticketing.MasterForm
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            FrmMasterBandara masterBandara = new FrmMasterBandara();
            masterBandara.Size = panelView.Size;
            masterBandara.TopLevel = false;
            panelView.Controls.Add(masterBandara);
            masterBandara.BringToFront();
            masterBandara.Show();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            FrmMasterMaskapai masterMaskapai = new FrmMasterMaskapai();
            masterMaskapai.Size = panelView.Size;
            masterMaskapai.TopLevel = false;
            panelView.Controls.Add(masterMaskapai);
            masterMaskapai.BringToFront();
            masterMaskapai.Show();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            FrmMasterJadwalPenerbangan masterJadwal = new FrmMasterJadwalPenerbangan();
            masterJadwal.Size = panelView.Size;
            masterJadwal.TopLevel = false;
            panelView.Controls.Add(masterJadwal);
            masterJadwal.BringToFront();
            masterJadwal.Show();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            FrmMasterKodePromo masterKode = new FrmMasterKodePromo();
            masterKode.Size = panelView.Size;
            masterKode.TopLevel = false;
            panelView.Controls.Add(masterKode);
            masterKode.BringToFront();
            masterKode.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            FrmMasterBandara masterBandara = new FrmMasterBandara();
            masterBandara.Size = panelView.Size;
            masterBandara.TopLevel = false;
            panelView.Controls.Add(masterBandara);
            masterBandara.BringToFront();
            masterBandara.Show();
        }
    }
}
