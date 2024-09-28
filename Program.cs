// Hewan.cs
public class Hewan
{
    public string Nama { get; set; }
    public int Umur { get; set; }

    public Hewan(string nama, int umur)
    {
        Nama = nama;
        Umur = umur;
    }

    public virtual string Suara()
    {
        return "Hewan ini bersuara";
    }

    public string InfoHewan()
    {
        return $"Nama: {Nama}, Umur: {Umur}";
    }
}

// Mamalia.cs
public class Mamalia : Hewan
{
    public int JumlahKaki { get; set; }

    public Mamalia(string nama, int umur, int jumlahKaki)
        : base(nama, umur)
    {
        JumlahKaki = jumlahKaki;
    }
}

// Reptil.cs
public class Reptil : Hewan
{
    public int PanjangTubuh { get; set; }

    public Reptil(string nama, int umur, int panjangTubuh)
        : base(nama, umur)
    {
        PanjangTubuh = panjangTubuh;
    }
}

// Singa.cs
public class Singa : Mamalia
{
    public Singa(string nama, int umur, int jumlahKaki)
        : base(nama, umur, jumlahKaki)
    {
    }

    public override string Suara()
    {
        return "MAUM";
    }

    public void Mengaum()
    {
        Console.WriteLine("Singa mengaum");
    }
}

// Gajah.cs
public class Gajah : Mamalia
{
    public Gajah(string nama, int umur, int jumlahKaki)
        : base(nama, umur, jumlahKaki)
    {
    }

    public override string Suara()
    {
        return "NGOO!";
    }
}

// Ular.cs
public class Ular : Reptil
{
    public Ular(string nama, int umur, int panjangTubuh)
        : base(nama, umur, panjangTubuh)
    {
    }

    public override string Suara()
    {
        return "HUSH";
    }

    public void Merayap()
    {
        Console.WriteLine("Ular merayap");
    }
}

// Buaya.cs
public class Buaya : Reptil
{
    public Buaya(string nama, int umur, int panjangTubuh)
        : base(nama, umur, panjangTubuh)
    {
    }

    public override string Suara()
    {
        return "KALO AKU NGECHAT ADA YANG MARAH NGGA?/ AKU BARU PERTAMA KALI NGERASA SESAYANG INI";
    }
}

// KebunBinatang.cs
public class KebunBinatang
{
    private List<Hewan> hewans = new List<Hewan>();

    public void TambahHewan(Hewan hewan)
    {
        hewans.Add(hewan);
    }

    public void DaftarHewan()
    {
        foreach (var hewan in hewans)
        {
            Console.WriteLine(hewan.InfoHewan());
        }
    }
}

// Program.cs
// Program.cs
class Program
{
    static void Main(string[] args)
    {
        KebunBinatang kebunBinatang = new KebunBinatang();

        Singa singa = new Singa("Singa", 5, 4);
        Gajah gajah = new Gajah("Gajah", 10, 4);
        Ular ular = new Ular("Ular", 3, 10);
        Buaya buaya = new Buaya("Buaya", 7, 15);

        kebunBinatang.TambahHewan(singa);
        kebunBinatang.TambahHewan(gajah);
        kebunBinatang.TambahHewan(ular);
        kebunBinatang.TambahHewan(buaya);

        kebunBinatang.DaftarHewan();

        Console.WriteLine("\nDemonstrasi polymorphism:");
        Console.WriteLine("\n Nomor 1");
        Console.WriteLine($"Gajah: {gajah.Suara()}");
        Console.WriteLine($"Ular: {ular.Suara()}");
        Console.WriteLine("\n Nomor 2");
        singa.Mengaum();
        Console.WriteLine("\n Nomor 3");
        Console.WriteLine($"Nama : {singa.Nama} \nUmur: {singa.Umur} \nJumlah Kaki: {singa.JumlahKaki}");

        Console.WriteLine("\n Nomor 4");
        Console.WriteLine($"{ular.Merayap}");

        Console.WriteLine("\n Nomor 5");
        Reptil reptil = buaya;
        reptil.Suara();
    }
}
