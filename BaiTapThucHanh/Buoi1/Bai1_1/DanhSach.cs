public class DanhSach
{
    SinhVien[] ds;


    public void Nhap()
    {
        int size;

        Console.Write("Nhap so sinh vien: ");
        size = int.Parse(Console.ReadLine());

        ds = new SinhVien[size];

        for (int i = 0; i < size; i++)
        {
            ds[i] = new SinhVien();

            Console.WriteLine($"Nhap sinh vien thu {i + 1}:");
            ds[i].Nhap();
        }
    }

    public void XuatThongTin()
    {
        Console.WriteLine($"So sinh vien duoc lam khoa luan: {ds.Count(sv => sv.DuocLamKhoaLuan())}");
        Console.WriteLine($"So sinh vien duoc lam chuyen de tot nghiep: {ds.Count(sv => sv.DuocLamChuyenDeTotNghiep())}");
    }
}
