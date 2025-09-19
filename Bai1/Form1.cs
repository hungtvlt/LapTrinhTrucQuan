namespace Bai1
{
    public partial class Form1 : Form
    {
        // TODO: 1,5
        private List<Subject> subjects;
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

        private void Calculate()
        {
            float sumValue = 0;
            float sumPoint = 0;

            foreach (Subject subject in lstMonHoc.Items)
            {
                sumValue += subject.Value;
                sumPoint += subject.Point * subject.Value;
            }

            float avgPoint = sumValue == 0 ? 0 : (sumPoint / sumValue);

            txtTongTinChi.Text = sumValue.ToString();
            txtTongDiem.Text = sumPoint.ToString();
            txtDiemTB.Text = avgPoint.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            subjects = new List<Subject>
            {
                new Subject(){Name = "Tin học đại cương", Value = 2},
                new Subject(){Name = "Giải tích F1", Value = 3},
                new Subject(){Name = "Tiếng Anh A0", Value = 3},
                new Subject(){Name = "Triết học Mác - Lênin", Value = 2},
                new Subject(){Name = "Vật lý F1", Value = 3}
            };

            cbbTenMonHoc.DataSource = subjects;
        }

        private void cbbTenMonHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            Subject subject = (Subject)cbbTenMonHoc.SelectedItem;

            txtSoTinChi.Text = subject.Value.ToString();

            txtDiem.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Subject subject = (Subject)cbbTenMonHoc.SelectedItem;

            try
            {
                float value = float.Parse(txtDiem.Text);

                subject.Point = value;
            }
            catch
            {
                MessageBox.Show("Nhập điểm không đúng", "Lỗi", MessageBoxButtons.OK);
                txtDiem.Text = "";
                return;
            }

            lstMonHoc.Items.Add(new Subject { Name = subject.Name, Value = subject.Value, Point = subject.Point });
        }

        private void btnTinh_Click(object sender, EventArgs e)
            => Calculate();

        private void btnThoat_Click(object sender, EventArgs e)
            => RequestExit();
    }

    public class Subject
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public float Point { get; set; }

        public override string ToString() => Name;
    }

}
