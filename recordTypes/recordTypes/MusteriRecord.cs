using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recordTypes
{
    public record MusteriRecord
    {
        //1. Eşitlik (Equal) operasyonunu bir değişikliğe gerek olmaksızın yapmak
        //2. Eğer, özellikler değişmiyorsa sadece çalışma zamanında atanıp, okuma işlemi yapılıyorsa
        //   (immutable ise) record kullanılmalı
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TCKimlik { get; set; }
        public string Adres { get; set; }
    }
}
