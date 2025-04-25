using System;

class Book
{
    public string id;
    public string judul;
    public string penulis;
    public string tahunTerbit;
    public string status;

    public virtual void InfoBuku()
    {
        Console.WriteLine($"ID: {id}\nJudul: {judul}\nPenulis: {penulis}\nTahun Terbit: {tahunTerbit}\nStatus: {status}");
    }
}

class Novel : Book
{
    public override void InfoBuku()
    {
        id = "101";
        judul = "Hujan";
        penulis = "Tere Liye";
        tahunTerbit = "2020";
        status = "Tersedia";

        base.InfoBuku();
    }
}

class Manga : Book
{
    public override void InfoBuku()
    {
        id = "201";
        judul = "One Piece";
        penulis = "Eichiro Oda";
        tahunTerbit = "1999";
        status = "Dipinjam";

        base.InfoBuku();
    }
}


class Perpustakaan
{
    public string namaPerpustakaan;
    public string alamatPerpustakaan;

    public void InfoPerpustakaan()
    {
        namaPerpustakaan = "Pelita Hidup";
        alamatPerpustakaan = "Sumbersari, Jember";

        Console.WriteLine($"Perpustakaan {namaPerpustakaan}");
        Console.WriteLine($"{alamatPerpustakaan}");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Book book = new Book();
        Novel novel = new Novel();
        Manga manga = new Manga();
        Perpustakaan perpustakaan = new Perpustakaan();

        perpustakaan.InfoPerpustakaan();
        Console.Read();
        novel.InfoBuku();
        Console.WriteLine();
        manga.InfoBuku();

    }
}