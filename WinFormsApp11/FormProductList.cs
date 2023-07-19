using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsapp11.Bussiness;
using WinFormsApp11.Models;

namespace WinFormsApp11
{
    public partial class FormProductList : Form
    {
        public FormProductList()
        {
            InitializeComponent();
        }
        public void UrunlerGetir()
        {
            dataGridViewUrunler.Rows.Clear();
            IEnumerable<Urun> urunler = new UrunManager().GetAll(); //veriyi çek ve işle


            
            urunler.ToList().ForEach(urun =>
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewUrunler);
                row.Cells[dataGridViewUrunler.Columns["Id"].Index].Value = urun.Id;
                row.Cells[dataGridViewUrunler.Columns["StokAdi"].Index].Value = urun.stokAdi;
                row.Cells[dataGridViewUrunler.Columns["Fiyat"].Index].Value = urun.fiyat;
                row.Cells[dataGridViewUrunler.Columns["KdvOrani"].Index].Value = urun.kdvOrani;
                row.Cells[dataGridViewUrunler.Columns["ParaBirimi"].Index].Value = urun.paraBirimi;
                row.Cells[dataGridViewUrunler.Columns["OlcuBirimi"].Index].Value = urun.olcuBirimi;
                row.Cells[dataGridViewUrunler.Columns["Adet"].Index].Value = urun.adet;
                row.Cells[dataGridViewUrunler.Columns["Barkod"].Index].Value = urun.barkod;


                dataGridViewUrunler.Rows.Add(row);


            });
        }

        private void FormProductList_Load(object sender, EventArgs e)
        {

            UrunlerGetir();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridViewUrunler.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewUrunler.Rows[selectedRowIndex];

            int id = Convert.ToInt32(selectedRow.Cells["Id"].Value.ToString());

            DialogResult result =MessageBox.Show("Ürün Silinecek. Emin misin?", "Ürünü Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if(result == DialogResult.Yes)
            {
                new UrunManager().Delete(id);
                dataGridViewUrunler.Rows.Remove(selectedRow);

            }
        }

        private void buttonDuzenle_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridViewUrunler.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewUrunler.Rows[selectedRowIndex];
            int id = Convert.ToInt32(selectedRow.Cells["Id"].Value.ToString());
            
            FormProduct formProduct = new(this,id);
            formProduct.ShowDialog();
        }
    }
}
