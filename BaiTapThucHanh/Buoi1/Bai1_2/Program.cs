ThueXe[] ds;

Console.Write("Nhap so luong: ");

ds = new ThueXe[int.Parse(Console.ReadLine())];

for(int i =0; i < ds.Length; ++i)
{
	ds[i] = new ThueXe();

	ds[i].Nhap();
}

Console.WriteLine("Thong tin:");

foreach (var i in ds)
	i.Xuat();
