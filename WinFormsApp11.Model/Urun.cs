using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp11.Model.Enums;

namespace WinFormsApp11.Models
{
    [Table("Urun")]
    public class Urun
    {
        [Key]
        public int Id { get; set; }
        public string stokAdi { get; set; } = "";

        public string barkod { get; set; } = "";

        public double fiyat { get; set; }

        public int kdvOrani { get; set; }

        public ParaBirimi paraBirimi { get; set; }

        public string olcuBirimi{ get; set; } = "";

        public int adet { get; set; }

        public DateTime Tarih { get; set; }

        [Write(false)]
        public double genelToplam { get; set; }

        [Write(false)]
        public double kdvToplam { get; set; }

        

        public string Resim { get; set; } = "";

        // -1 silindi, 0 pasif, 1 aktif.
        public int Durum { get; set; }

        [Write(false)]
        public List<string> Ozellikler { get; set; } = new();

       











    }
}
