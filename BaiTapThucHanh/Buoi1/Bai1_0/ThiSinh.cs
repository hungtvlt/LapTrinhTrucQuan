using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ThiSinh
{
	protected long sbd;
	protected string ht = "";
	protected float m1, m2, m3;

	public virtual void Nhap()
	{

		Console.Write("Nhap so bao danh: ");
		sbd = long.Parse(Console.ReadLine());

		Console.Write("Nhap ho ten: ");
		ht = Console.ReadLine();

		Console.Write("Nhap diem thu nhat: ");
		m1 = float.Parse(Console.ReadLine());

		Console.Write("Nhap diem thu hai: ");
		m2 = float.Parse(Console.ReadLine());

		Console.Write("Nhap diem thu ba: ");
		m3 = float.Parse(Console.ReadLine());

	}

	public virtual void Xuat()
		=> Console.WriteLine($"So bao danh: {sbd}, ho ten: {ht}, diem 1: {m1}, diem 2: {m2}, diem 3: {m3}");

	public virtual float LayTongDiem()
		=> m1 + m2 + m3;
}
