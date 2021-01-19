using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo2
{
    class BookManager
    {
        public void Ekle(Book book)
        {
            Console.WriteLine("Tebrikler kitap kütüphaneye eklendi: "+ book.KitapAdi + " " + book.YazarAdi );
        }

        public void Cikar(Book book)
        {
            Console.WriteLine("Tebrikler  kitap kütüphanenizden cikarildi" + book.KitapAdi + " " + book.YazarAdi);

        }

        public void Listele(Book book)
        {
            Console.WriteLine("Tebrikler kitaplar listelendi");
            Console.WriteLine("Kitap adi: " +book.KitapAdi +" Yazar adi: "+ book.YazarAdi +" yayinadi"+ book.YayinAdi + " sayfa sayisi: " +book.SayfaSayisi );

        }
    }
}
