using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Xe
{
	protected long giaGioDau;
	protected long giaGioTiepTheo;

	public Xe(long giaGioDau, long giaGioTiepTheo)
	{
		this.giaGioDau = giaGioDau;
		this.giaGioTiepTheo = giaGioTiepTheo;
	}

	public long TinhTien(long gio)
	{
		if (gio == 0) return 0;

		if(gio == 1) return giaGioDau;

		return giaGioDau + giaGioTiepTheo * (gio - 1);
	}
}
