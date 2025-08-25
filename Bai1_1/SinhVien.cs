public class SinhVien
{
    string hoTen = "";
    string ngaySinh = "";
    float diemLapTrinh;
    float diemCSDL;
    float diemThietKeWeb;


    public void Nhap()
    {
        Console.Write("Nhap ho ten: ");
        hoTen = Console.ReadLine();

        Console.Write("Nhap ngay sinh: ");
        ngaySinh = Console.ReadLine();

        Console.Write("Nhap diem lap trinh: ");
        diemLapTrinh = float.Parse(Console.ReadLine());

        Console.Write("Nhap diem CSDL: ");
        diemCSDL = float.Parse(Console.ReadLine());

        Console.Write("Nhap diem thiet ke web: ");
        diemThietKeWeb = float.Parse(Console.ReadLine());
    }
    
    public bool DuocLamKhoaLuan()
    {
        bool dieuKienDiemTrungBinh = (diemLapTrinh + diemCSDL + diemThietKeWeb) / 3 >= 8;
        bool dieuKienDiemCacMon = !(diemLapTrinh < 5 || diemCSDL < 5 || diemThietKeWeb < 5);
        return dieuKienDiemTrungBinh && dieuKienDiemCacMon;
    }

    public bool DuocLamChuyenDeTotNghiep()
    {
        return !(diemLapTrinh < 5 || diemCSDL < 5 || diemThietKeWeb < 5);
    }
}
