using System;

public class TuyenSinh : ThiSinh
{
    int kv;
    public override void Nhap()
    {
        base.Nhap();

        Console.Write("Nhap khu vuc: ");
        kv = int.Parse(Console.ReadLine());
    }

    public override void Xuat()
    {
        Console.WriteLine($"So bao danh: {sbd}, ho ten: {ht}, diem 1: {m1}, diem 2: {m2}, diem 3: {m3}, khu vuc: {kv}");
    }

    public override float LayTongDiem()
    {
        switch (kv)
        {
            case 1:
                return base.LayTongDiem() + 0;
            case 2:
                return base.LayTongDiem() + 1;
            case 3:
                return base.LayTongDiem() + 2;
            default:
                return 0;
        }
    }
}
