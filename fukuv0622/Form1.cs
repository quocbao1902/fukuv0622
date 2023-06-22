namespace fukuv0622
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int[] data = new int[10];
            for (int i = 0; i < data.Length; i++)
                data[i] = rand.Next(101);
            label1.Text = data[0] + ", " + data[1] + ", " + data[2] + ", " + data[3] + ", " + data[4] + ", " + data[5] + ", " + data[6] + ", " + data[7] + ", " + data[8] + ", " + data[9];
            MessageBox.Show(((data[0] + data[1] + data[2] + data[3] + data[4] + data[5] + data[6] + data[7] + data[8] + data[9]) / 10).ToString());
        }
    }
}