public class DanhSach
{
    TuyenSinh[]? ds = Array.Empty<TuyenSinh>();

    public void Nhap()
    {
        Console.Write("Nhap so luong thi sinh: ");
        int n = int.Parse(Console.ReadLine());

        ds = new TuyenSinh[n];
        for (int i = 0; i < n; i++)
        {
            ds[i] = new();
            ds[i].Nhap();
        }
    }

    public void Xuat()
    {
        for (int i = 0; i < ds.Length; i++)
        {
            ds[i].Xuat();
        }
    }
}
