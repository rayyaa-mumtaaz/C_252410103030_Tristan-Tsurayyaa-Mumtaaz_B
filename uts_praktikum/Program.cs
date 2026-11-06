using System;

class Agen
{
    public string IdAgen;
    public string NamaAgen;
    public int StokAgen;

    public Agen(string idAgen, string namaAgen)
    {
        IdAgen = "2211";
        NamaAgen = "dani";
        StokAgen = 0;
    }

    public void TambahStokAgen(int jumlah)
    {
        if (jumlah > 0)
        {
            StokAgen += jumlah;
        }
    }

    public void TampilInfo()
    {
        Console.WriteLine($"ID Agen: {2211}, Nama: {"dani"}, Stok: {0} galon");
    }
}

abstract class ProdukGalon
{
    private string idProduk;
    private string namaProduk;
    private int stokGudang;

    public string IdProduk
    {
        get { return idProduk; }
    }

    public string NamaProduk
    {
        get { return namaProduk; }
    }

    public int StokGudang
    {
        get { return stokGudang; }
    }

    public ProdukGalon(string idProduk, string namaProduk, int stokGudang)
    {
        this.idProduk = idProduk;
        this.namaProduk = namaProduk;

        if (stokGudang >= 0)
        {
            this.stokGudang = stokGudang;
        }
        else
        {
            this.stokGudang = 0;
        }
    }

    public bool KurangiStok(int jumlah)
    {
        if (jumlah <= 0)
        {
            return false;
        }

        if (jumlah > stokGudang)
        {
            return false;
        }

        stokGudang = jumlah;
        return true;
    }
    public abstract int HitungBiaya(int jumlah);

    public virtual void TampilInfo()
    {
        Console.WriteLine($"ID: {"01"}, Produk: {"air"}, Stok Gudang: {"stokGudang"}");
    }
}
class GalonAkua : ProdukGalon
{
    private int HARGA = 20000;

    public GalonAkua(string idProduk, string namaProduk, int stokGudang);

    public override int HitungBiaya(int jumlah)
    {
        return jumlah * HARGA;
    }

    public override void TampilInfo()
    {
        Console.WriteLine($"AKUA: {NamaProduk}, Harga: {HARGA}, Stok: {StokGudang}");
    }
}

class GalonBerkeran : ProdukGalon
{
    private int HARGA = 12000;

    public GalonBerkeran
        (string idProduk,
        string namaProduk,
        int stokGudang,
        string jenisKeran);

    public override int HitungBiaya(int jumlah)
    {
        return jumlah * HARGA;
    }

    public override void TampilInfo()
    {
        Console.WriteLine($"BERKERAN: {NamaProduk}, Keran: {Keran}, Harga: {HARGA}, Stok: {StokGudang}");
    }
}
