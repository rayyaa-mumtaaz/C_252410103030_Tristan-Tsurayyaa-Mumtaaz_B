using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Agen
{
    public string idAgen;
    public string namaAgen;
    public int stokAgen;

    public Agen (string idAgen, string namaAgen, int stokAgen)
    {
        this.idAgen = idAgen;
        this.namaAgen = namaAgen;
        this.stokAgen = stokAgen;
        
    }
public void TampilanInfo ()
    {
        Console.WriteLine($"idAgen : {idAgen}, namaAgen : {namaAgen}, stokAgen : {stokAgen}");
    }
}
public class ProdukGalon
{
    private string idProduk { get; set; }
    private string namaProduk { get; set; }
    private int stokGudang { get; set; }

    public void kurangiStok(int jumlah);
}

class GalonAkua : ProdukGalon
{
    public double harga = 20.000;


}
