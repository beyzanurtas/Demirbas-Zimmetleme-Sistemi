using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemirbasZimmet
{
    public partial class PersonelListesi : Form
    {
        bool personelSecildi = false;
        public PersonelListesi()
        {
            InitializeComponent();
            dgvPersonelListesi.DataSource = Veritabani.SELECTCalistir($"select * from Personel");
        }
        public string personelBul()
        {
            personelSecildi = false;
            ShowDialog();
            if (personelSecildi)
                return dgvPersonelListesi.SelectedRows[0].Cells["SicilNumarası"].Value.ToString();
            else return null;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvPersonelListesi.SelectedRows.Count < 1)
            {
                MessageBox.Show("Önce satır seçin");
                return;
            }
            personelSecildi = true;
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   }
    }
}
