using System;

namespace ClassMetotDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.KitapAdi = "Tehlikeli Oyunlar";
            book1.YazarAdi = "Oguz Atay";
            book1.YayinAdi = "Iletisim";
            book1.SayfaSayisi = 478;

            Book book2 = new Book();
            book2.KitapAdi = "Tutunamayanlar";
            book2.YazarAdi = "Oguz Atay";
            book2.YayinAdi = "Iletisim";
            book2.SayfaSayisi = 724;

            Book book3 = new Book();
            book3.KitapAdi = "Huzursuzluk";
            book3.YazarAdi = "Zülfü Livaneli";
            book3.YayinAdi = "DK";
            book3.SayfaSayisi = 154;

            Book book4 = new Book();
            book4.KitapAdi = "İki sehrin hikayesi";
            book4.YazarAdi = "Charles Dickens";
            book4.YayinAdi = "Is Bankasi Kultur Yayinlari";
            book4.SayfaSayisi = 500;

            Book[] books = new Book[] {book1, book2, book3, book4 };

            foreach (Book book in books)
            {
                Console.WriteLine(book.KitapAdi);
                Console.WriteLine(book.YazarAdi);
                Console.WriteLine(book.YayinAdi);
                Console.WriteLine(book.SayfaSayisi);
                Console.WriteLine("              ");

            }

            Console.WriteLine("           Mettotlar        ");

            BookManager bookManager = new BookManager();

            bookManager.Ekle(book1);
            bookManager.Ekle(book2);
            bookManager.Ekle(book3);
            bookManager.Ekle(book4);

            Console.WriteLine("         ");

            bookManager.Cikar(book1);
            bookManager.Cikar(book2);
            bookManager.Cikar(book3);
            bookManager.Cikar(book4);

            Console.WriteLine("              ");

            bookManager.Listele(book1);
            bookManager.Listele(book2);
            bookManager.Listele(book3);
            bookManager.Listele(book4);



        }
    }
}
