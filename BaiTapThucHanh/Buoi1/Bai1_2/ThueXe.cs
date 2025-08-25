using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ThueXe
{
	string? hoTen;
	Xe? xe;
	long soGio;

	public void Nhap()
	{
		Console.Write("Nhap ho ten: ");
		hoTen = Console.ReadLine();

		int loaiXe = 0;
		Console.Write(
			"""
			Nhap loai xe:
			1. Xe Tai
			2. Xe Du Lich
			Lua chon: 
			"""
			);
		loaiXe = int.Parse(Console.ReadLine());
		switch (loaiXe)
		{
			case 1:
				xe = new XeTai();
				break;
			case 2:
				xe = new XeDuLich();
				break;
			default:
				Console.WriteLine("So khong hop le, mac dinh chon xe tai");
				xe = new XeTai();
				break;

		}

		Console.Write("Nhap so gio: ");
		soGio = long.Parse(Console.ReadLine());
	}

	public void Xuat()
	{
		Console.WriteLine($"Ten: {hoTen}, so gio thue: {soGio}, tong tien: {TinhTien()}");
	}

	public long TinhTien() => xe.TinhTien(soGio);
}
