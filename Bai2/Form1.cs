namespace Bai2
{
	public partial class Form1 : Form
	{
		// TODO: 5,6
		public Form1()
		{
			InitializeComponent();
		}

		private void RequestExit()
		{
			if (MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				Close();
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			RequestExit();
		}

		private void btnThemMoi_Click(object sender, EventArgs e)
		{
			txtHoTen.Text = "";
			rdoCaNgay.Checked = false;
			rdoNuaNgay.Checked = false;
			txtGiaDuThuyen.Text = "";
			cbbDoUong.SelectedIndex = -1;
			cbbSoLuong.SelectedIndex = -1;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			cbbSoLuong.Items.AddRange(new String[]
			{
				"1","2","3","4","5","6","7","8","9","10"
			});

			cbbDoUong.Items.AddRange(new Drink[]
			{
				new Drink{Name="Coca Cola", Price = 0.5f},
				new Drink{Name="Pepsi", Price = 0.8f},
				new Drink{Name="Seven Up", Price = 1f}
			});
		}

		private void rdoCaNgay_CheckedChanged(object sender, EventArgs e)
		{
			OnCheckChanged();
		}

		private void rdoNuaNgay_CheckedChanged(object sender, EventArgs e)
		{
			OnCheckChanged();
		}

		private void OnCheckChanged()
		{
			if (rdoCaNgay.Checked)
				txtGiaDuThuyen.Text = "200";
			else if (rdoNuaNgay.Checked)
				txtGiaDuThuyen.Text = "100";
			else
				txtGiaDuThuyen.Text = "";

		}

		private void cbbDoUong_SelectedIndexChanged(object sender, EventArgs e)
		{
			CalculatePrice();
		}

		private void cbbSoLuong_SelectedIndexChanged(object sender, EventArgs e)
		{
			CalculatePrice();
		}

		private void CalculatePrice()
		{
			Drink drink = (Drink)cbbDoUong.SelectedItem;
			var countObject = cbbSoLuong.SelectedItem;

			if (drink is not null && countObject is not null)
			{
				int count = int.Parse(countObject.ToString());
				txtTienDoUong.Text = (count * drink.Price).ToString();
			}

			else
			{
				txtTienDoUong.Text = "";
			}

		}

		private void btnThemDS_Click(object sender, EventArgs e)
		{
			String res = txtHoTen.Text + "|";
			if(rdoCaNgay.Checked)
			{
				res += "cả ngày | ";
			}
			else if (rdoNuaNgay.Checked)
			{
				res += "nửa ngày | ";
			}

			if (rdoCaNgay.Checked || rdoNuaNgay.Checked)
				res += txtGiaDuThuyen.Text + "$ | ";

			//if(txtTienDoUong.Text != "")
			//	res += $"Đồ uống {float.Parse(txtTienDoUong.Text)} | Tổng {()}";
			//else if (txtGiaDuThuyen.Text != "")
			//	res += $"Tổng {(float.Parse(txtGiaDuThuyen.Text) + float.Parse(txtTienDoUong.Text))}";
			//else
			//	res += $"Tổng {float.Parse(txtGiaDuThuyen.Text)}";

			float tienGiaDuThuyen = txtGiaDuThuyen.Text == "" ? 0 : float.Parse(txtGiaDuThuyen.Text);
			float tienDoUong = txtTienDoUong.Text == "" ? 0 : float.Parse(txtTienDoUong.Text);

			res += $"Đồ uống {tienDoUong}$ | Tổng tiền {tienGiaDuThuyen + tienDoUong}$";

			lstKhachHang.Items.Add(res);
		}
	}

	public class Order
	{
		public Drink drink { get; set; }
		public int Count { get; set; }
		public override string ToString()
		{
			return drink.ToString();
		}
	}

	public class Drink
	{
		public string Name { get; set; }
		public float Price { get; set; }
		public override string ToString()
		{
			return Name;
		}
	}
}
