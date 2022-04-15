using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DemirbasZimmet
{
    public partial class BölümListesi : Form
    {
        bool bolumSecildi = false;
        public BölümListesi()
        {
            InitializeComponent();

            dgvBolum.DataSource = Veritabani.SELECTCalistir($"select * from Bölüm");
        }
            public string bolumBul()
        {
            bolumSecildi = false;
            ShowDialog();
            if (bolumSecildi)
                return dgvBolum.SelectedRows[0].Cells["BölümKodu"].Value.ToString();
            else return null;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvBolum.SelectedRows.Count < 1)
            {
                MessageBox.Show("Önce satır seçin");
                return;
            }
            bolumSecildi = true;
            Close();
        }
        private void dgvBolum_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }
       
    }
}
