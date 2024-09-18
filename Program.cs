using System;

class GiaSuc
{
    protected int sua;
    protected string sound;
    protected int socon;

    public virtual void Tieng()
    {
    }

    public int DeCon()
    {
        Random rand = new Random();
        socon = rand.Next(1, 10); // Sinh con ngẫu nhiên từ 1 đến 100 con
        return socon;
    }
}

class Bo : GiaSuc
{
    public override void Tieng()
    {
        sound = "mooo mooo";
        Console.WriteLine(sound);
    }
}

class Cuu : GiaSuc
{
    public override void Tieng()
    {
        sound = "beee beee";
        Console.WriteLine(sound);
    }
}

class De : GiaSuc
{
    public override void Tieng()
    {
        sound = "burhhhh burhhh";
        Console.WriteLine(sound);
    }
}

class Mana
{
    private int slbo, slde, slcuu, slbon, slden, slcuun, tongsua;
    private Bo[] bo;
    private Cuu[] cuu;
    private De[] de;

    public void Nhap()
    {
        Console.Write("Nhap so luong bo: ");
        slbo = int.Parse(Console.ReadLine());
        bo = new Bo[slbo];
        for (int i = 0; i < slbo; i++) bo[i] = new Bo();

        Console.Write("Nhap so luong cuu: ");
        slcuu = int.Parse(Console.ReadLine());
        cuu = new Cuu[slcuu];
        for (int i = 0; i < slcuu; i++) cuu[i] = new Cuu();

        Console.Write("Nhap so luong de: ");
        slde = int.Parse(Console.ReadLine());
        de = new De[slde];
        for (int i = 0; i < slde; i++) de[i] = new De();
    }

    public void XuatSound()
    {
        for (int i = 0; i < slbo; i++)
        {
            Console.Write($"Bo thu {i + 1}: ");
            bo[i].Tieng();
        }

        for (int i = 0; i < slcuu; i++)
        {
            Console.Write($"Cuu thu {i + 1}: ");
            cuu[i].Tieng();
        }

        for (int i = 0; i < slde; i++)
        {
            Console.Write($"De thu {i + 1}: ");
            de[i].Tieng();
        }
    }

    public void SauSinh()
    {
        slbon = slbo;
        slcuun = slcuu;
        slden = slde;

        Random rand = new Random();

        for (int i = 0; i < slbon; i++)
        {
            int socon = bo[i].DeCon();
            slbo += socon;
        }

        for (int i = 0; i < slcuun; i++)
        {
            int socon = cuu[i].DeCon();
            slcuu += socon;
        }

        for (int i = 0; i < slden; i++)
        {
            int socon = de[i].DeCon();
            slde += socon;
        }
    }

    public void TinhSua()
    {
        tongsua = 0;
        Random rand = new Random();

        for (int i = 0; i < slbo; i++)
        {
            int m = rand.Next(0, 21); // Bò cho từ 0 đến 20 lít sữa
            Console.WriteLine($"Sua cua bo {i + 1}: {m} lít");
            tongsua += m;
        }

        for (int i = 0; i < slcuu; i++)
        {
            int m = rand.Next(0, 6); // Cừu cho từ 0 đến 5 lít sữa
            Console.WriteLine($"Sua cua cuu {i + 1}: {m} lít");
            tongsua += m;
        }

        for (int i = 0; i < slde; i++)
        {
            int m = rand.Next(0, 11); // Dê cho từ 0 đến 10 lít sữa
            Console.WriteLine($"Sua cua de {i + 1}: {m} lít");
            tongsua += m;
        }

        Console.WriteLine($"Tong so sua: {tongsua} lít");
    }
}

class Program
{
    static void Main()
    {
        Mana gs = new Mana();
        gs.Nhap();
        gs.XuatSound();
        gs.SauSinh();
        gs.TinhSua();
    }
}
