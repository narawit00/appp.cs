namespace appp.cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to my program", "Message");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you really want to close!!!! ", "Are you sure.. you really want to close...",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCircleArea_Click(object sender, EventArgs e)
        {
            /// input   �Ѻ��Ҩҡ textbox ���� txtRedius (��ŧ��Դ�������� Do)
            double Radius = 0;
            //Redius = Convert.ToSingle(txtRadius.Text);
            if (double.TryParse(txtRadius.Text, out Radius) == false)

            {
                MessageBox.Show("��á�͡���������١��ͧ", " �Դ��ͼԴ��Ҵ�����˭���ǧ Error!!");
                txtRadius.Focus(); // ����� Cursar ��� textBox
                txtRadius.SelectAll();
                return;
            }

            double CircleArea = Math.PI * Math.Pow(Radius, 2);
            //Math.PI  �����  Pi
            //Math.Pow(x,y)

            //output  �����ʴ��ŷ�� lblResult
            lblResult.Text = CircleArea.ToString("0.00");

            txtRadius.Focus();
            txtRadius.SelectAll();
        }

        private void btnTriangleArea_Click(object sender, EventArgs e)
        {
            double Height = 0;
            double Widht = 0;
            if (double.TryParse(txtHeight.Text, out Height) == false)
            {
                MessageBox.Show("Entering incorrect information may result in errors.", "Hey,watchout Error...");
                return;
            }

            if (double.TryParse(txtWidth.Text, out Widht) == false)
            {
                MessageBox.Show("Entering incorrect information may result in errors.", "Hey,watchout Error...");
                return;
            }
            // �ӹǳ��鹷������������
            double triangleArea = 0.5 * Width * Height;
            lblResult.Text = triangleArea.ToString("0.00");
            txtHeight.Focus();
            txtHeight.SelectAll();
        }

        private void btnHexagonArea_Click(object sender, EventArgs e)
        {
            double HexagonWidth = 0;
            if (double.TryParse(txtHexagonWidth.Text, out HexagonWidth) == false)
            {
                MessageBox.Show("��͡���������١��ͧ", "���� Error!!");
                return;
            }
            double hexagonArea = (3 * Math.Sqrt(3) / 2) * Math.Pow(HexagonWidth, 2);
            lblResult.Text = hexagonArea.ToString("0.00");
        }
    }
}
