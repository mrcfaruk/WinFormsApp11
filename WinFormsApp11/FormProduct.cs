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
using WinFormsApp11.Model.Enums;
using WinFormsApp11.Models;

namespace WinFormsApp11
{
    public partial class FormProduct : Form
    {
        FormProductList? _formProductList;
        Urun _urun = new();
        public FormProduct(FormProductList? formProductList =null, int id = 0) 
        {
            InitializeComponent();
            if (id != 0)
            {
                _formProductList = formProductList;
                _urun = new UrunManager().Get(id);
                textBoxName.Text = _urun.stokAdi;
                textBoxBarkod.Text = _urun.barkod;
                textBoxAdet.Text = _urun.adet.ToString();
                textBoxPrice.Text = Convert.ToString(_urun.fiyat);
                
                

                int kdvIndex = comboBoxKDV.FindStringExact($"%{_urun.kdvOrani}");
                comboBoxKDV.SelectedIndex = kdvIndex;

                int olcuBirimiIndex = comboBoxBirim.FindStringExact(_urun.olcuBirimi);
                comboBoxBirim.SelectedIndex = olcuBirimiIndex;

                if (!string.IsNullOrEmpty(_urun.Resim))
                {
                    Image image = Image.FromFile($"Images/{_urun.Resim}");
                    pictureBox1.Image = image;
                }
                

                switch (_urun.paraBirimi)
                {
                    case ParaBirimi.TRY:
                        radioButtonTRY.Checked = true;
                        break;

                    case ParaBirimi.EUR:
                        radioButtonEUR.Checked = true;
                        break;
                    default:
                        radioButtonUSD.Checked = true;
                        break;
                }

                GenelToplamHesapla();

                KdvTutarHesapla();
            }

            
        }

        private void GenelToplamHesapla()
        {
            try
            {
                double fiyat = Convert.ToDouble(textBoxPrice.Text);
                int adet = Convert.ToInt32(textBoxAdet.Text);
                double genelToplam = fiyat * adet;
                textBoxGenelToplam.Text = genelToplam.ToString();
            }
            catch (Exception)
            {

                textBoxGenelToplam.Text = "";
            }
        }

        private void KdvTutarHesapla()
        {
            try
            {
                double genelToplam = Convert.ToDouble(textBoxGenelToplam.Text);
                string kdv = comboBoxKDV.SelectedItem.ToString().Replace("%", "");
                double kdvOrani = Convert.ToInt32(kdv);
                double kdvTutar = genelToplam * (kdvOrani / 100);
                textBoxKDVDahilToplam.Text = kdvTutar.ToString();
            }
            catch (Exception)
            {

                
            }
         
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                e.Handled = false;
                return;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && textBoxPrice.Text.Contains("."))
            {
                e.Handled = true; //birden fazla nokta koyulmasını engellemek için kullanılır.
            }

            if (e.KeyChar == '.' && string.IsNullOrEmpty(textBoxPrice.Text))
            {
                textBoxPrice.Text = "0.";
                textBoxPrice.SelectionStart = textBoxPrice.Text.Length; //. koyulduğunda başına 0 ekleyip imleci sağa kaydırmaya yarar.
                //textBoxPrice.Select(textBoxPrice.Text.Length, 0); farklı bir yöntemidir.
                e.Handled = true;
                MessageBox.Show("Başa nokta koyulamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            string[] price = textBoxPrice.Text.Split('.');
            if (price.Length == 2 && price[1].Length >= 2)
            {
                e.Handled = true;

            }
            

        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            comboBoxBirim.DropDownStyle = ComboBoxStyle.DropDownList;
            
            comboBoxKDV.DropDownStyle = ComboBoxStyle.DropDownList;
            checkBoxAktif.Checked = true;


            if (_urun == null)
            {
                radioButtonTRY.Checked = true;
                comboBoxKDV.SelectedIndex = 3;
                comboBoxBirim.SelectedIndex = 0;
            }
            
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog file = new())
            {
                file.Filter = "Görsel(*.png; *.jpg; *.jpeg)|*,png; *.jpg; *.jpeg";
                file.Title = "Görsel Seç";

                if (file.ShowDialog() == DialogResult.OK)
                {
                    string filepath = file.FileName;
                    pictureBox1.Image = Image.FromFile(filepath);
                }
            }

        }

        private void TextBoxAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }



        }

        private void textBoxAdet_TextChanged(object sender, EventArgs e)
        {
            GenelToplamHesapla();
            KdvTutarHesapla();


        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            GenelToplamHesapla();
            KdvTutarHesapla();
        }

        private void comboBoxKDV_TextChanged(object sender, EventArgs e)
        {
            KdvTutarHesapla();
        }
        private void textBoxozellik_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (e.KeyChar == (char)Keys.Enter && textBoxozellik.Text != "")
            {



                listBoxozellik.Items.Add(textBoxozellik.Text);
                textBoxozellik.Clear();
                return;
            }

            if (e.KeyChar == (char)Keys.Enter && textBoxozellik.Text == "")
            {
                MessageBox.Show("Boş geçilemez", "uYARI", MessageBoxButtons.OK);
            }


        }

        private void textBoxozellik_DoubleClick(object sender, EventArgs e)
        {

        }

        private void listBoxozellik_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxozellik.SelectedItems != null)
            {
                listBoxozellik.Items.Remove(listBoxozellik.SelectedItems);

            }
        }

        private void listBoxozellik_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            
            Urun urun = new()
            {
                Id = _urun.Id,
                stokAdi = textBoxName.Text,
                fiyat = Convert.ToDouble(textBoxPrice.Text),
                barkod = textBoxBarkod.Text,
                kdvOrani =Convert.ToInt32(comboBoxKDV.SelectedItem.ToString().Replace("%", "")),
                adet = Convert.ToInt32(textBoxAdet.Text),
                Tarih = dateTimePickerTarih.Value,
                genelToplam = Convert.ToDouble(textBoxGenelToplam.Text),
                kdvToplam = Convert.ToDouble(textBoxKDVDahilToplam.Text),
                Resim = pictureBox1.ImageLocation,
                Durum = checkBoxAktif.Checked ? 1 : 0,
                olcuBirimi = comboBoxBirim.SelectedItem.ToString(),

            };

            if (radioButtonTRY.Checked) urun.paraBirimi = ParaBirimi.TRY;
            else if (radioButtonUSD.Checked) urun.paraBirimi = ParaBirimi.USD;
            else  urun.paraBirimi = ParaBirimi.EUR;

            if (pictureBox1.Image != null)
            {
                Image image = pictureBox1.Image;
                string gorselYolu = "Images";

                if (!Directory.Exists(gorselYolu))
                {
                    Directory.CreateDirectory(gorselYolu);
                }

                Guid guid = Guid.NewGuid();

                string dosyaAdi = Path.Combine(gorselYolu, $"{guid}.jpg");
                image.Save(dosyaAdi, System.Drawing.Imaging.ImageFormat.Jpeg);

                urun.Resim = $"{guid}.jpg";
            }
            

            foreach(string item in listBoxozellik.Items)
            {
                urun.Ozellikler.Add(item);
            }

            UrunManager urunManager = new UrunManager();


            if (_urun.Id == 0)
            {
                urunManager.Create(urun); //ürün yoksa ekle
                MessageBox.Show("Kayıt başarılı", "Kayıt işlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("Ürün Güncellenecek Emin Misiniz?", "Ürün başarıyla güncellendi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                urunManager.Update(urun); //ürün varsa güncelle
                MessageBox.Show("Ürün Güncellendi", "Ürün başarıyla güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                if(result == DialogResult.Yes)
                {
                    urunManager.Update(urun);
                    _formProductList!.UrunlerGetir();
                    this.Close();
                }
            }



        }

        private void listBoxozellik_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listBoxozellik_DoubleClick_1(object sender, EventArgs e)
        {
            if(listBoxozellik.SelectedItems != null)
            {
                listBoxozellik.Items.Remove(listBoxozellik.SelectedItems);
            }
        }

        private void textBoxozellik_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter && textBoxozellik.Text != "" )
            {
                listBoxozellik.Items.Add(textBoxozellik.Text);
                textBoxozellik.Clear();
                return;
            }

            if(e.KeyChar == (char)Keys.Enter && textBoxozellik.Text == "")
            {
                MessageBox.Show("Boş geçilemez", "Uyarı", MessageBoxButtons.OK);
            }
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxName.TextLength == 50)
            {
                e.Handled = true;
            }
            if (textBoxName.TextLength == 50 && e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                e.Handled = false;
                
            }
            if (textBoxName.TextLength >= 50 && e.KeyChar == '.')
            
                e.Handled = true;
            
        }

            private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            labelStokAdiLimit.Text = (50 - textBoxName.TextLength).ToString();

        }
    }


}

