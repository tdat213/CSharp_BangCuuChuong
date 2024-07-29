namespace CSharp_BangCuuChuong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtChon_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int so = Convert.ToInt32(txtChon.Text);
            for (int i = 1; i <= 10; i++)
            {
                lblKQ.Text += Environment.NewLine + so.ToString() + " X " + i.ToString() + " = " + (so * i).ToString();
                listBox1.Items.Add(so.ToString() + " X " + i.ToString() + " = " + (so * i).ToString());
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            txtChon.Text = numericUpDown1.Value.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblSo.Text = txtChon.Text = trackBar1.Value.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtChon_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            lblKQ.Text = " ";


            if (rdo2.Checked)
            {
                int so = 2;
                for (int i = 1; i <= 10; i++)
                {
                    lblKQ.Text += Environment.NewLine + so.ToString() + " X " + i.ToString() + " = " + (so * i).ToString();
                    listBox1.Items.Add(so.ToString() + " X " + i.ToString() + " = " + (so * i).ToString());
                }
            }
            

            if (rdo3.Checked)
            {
                int so = 3;
                for (int i = 1; i <= 10; i++)
                {
                    lblKQ.Text += Environment.NewLine + so.ToString() + " X " + i.ToString() + " = " + (so * i).ToString();
                    listBox1.Items.Add(so.ToString() + " X " + i.ToString() + " = " + (so * i).ToString());
                }
            }

            if (rdo4.Checked)
            {
                int so = 4;
                for (int i = 1; i <= 10; i++)
                {
                    lblKQ.Text += Environment.NewLine + so.ToString() + " X " + i.ToString() + " = " + (so * i).ToString();
                    listBox1.Items.Add(so.ToString() + " X " + i.ToString() + " = " + (so * i).ToString());
                }
            }

            if (rdo5.Checked)
            {
                int so = 5;
                for (int i = 1; i <= 10; i++)
                {
                    lblKQ.Text += Environment.NewLine + so.ToString() + " X " + i.ToString() + " = " + (so * i).ToString();
                    listBox1.Items.Add(so.ToString() + " X " + i.ToString() + " = " + (so * i).ToString());
                }
            }

            if (rdo6.Checked)
            {
                int so = 6;
                for (int i = 1; i <= 10; i++)
                {
                    lblKQ.Text += Environment.NewLine + so.ToString() + " X " + i.ToString() + " = " + (so * i).ToString();
                    listBox1.Items.Add(so.ToString() + " X " + i.ToString() + " = " + (so * i).ToString());
                }
            }

            if (rdo7.Checked)
            {
                int so = 7;
                for (int i = 1; i <= 10; i++)
                {
                    lblKQ.Text += Environment.NewLine + so.ToString() + " X " + i.ToString() + " = " + (so * i).ToString();
                    listBox1.Items.Add(so.ToString() + " X " + i.ToString() + " = " + (so * i).ToString());
                }
            }

            if (rdo8.Checked)
            {
                int so = 8;
                for (int i = 1; i <= 10; i++)
                {
                    lblKQ.Text += Environment.NewLine + so.ToString() + " X " + i.ToString() + " = " + (so * i).ToString();
                    listBox1.Items.Add(so.ToString() + " X " + i.ToString() + " = " + (so * i).ToString());
                }
            }

            if (rdo9.Checked)
            {
                int so = 9;
                for (int i = 1; i <= 10; i++)
                {
                    lblKQ.Text += Environment.NewLine + so.ToString() + " X " + i.ToString() + " = " + (so * i).ToString();
                    listBox1.Items.Add(so.ToString() + " X " + i.ToString() + " = " + (so * i).ToString());
                }
            }




        }
    }
}
