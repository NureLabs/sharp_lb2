namespace sharp_lb2
{
    public partial class Form1 : Form
    {
        Studio studio;
        Studio[] studio_collection = new Studio[0];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox10.Text = "К-сть кімнат: ";
            textBox11.Text = "К-сть робітників: ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            studio_collection[listBox1.SelectedIndex].Add_Recoding_Room();
            textBox10.Text = $"К-сть кімнат: {studio_collection[listBox1.SelectedIndex].Get_Rooms}";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            studio = new Studio(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text),
                double.Parse(textBox4.Text), int.Parse(textBox5.Text),
                double.Parse(textBox6.Text), double.Parse(textBox7.Text),
                int.Parse(textBox8.Text), int.Parse(textBox9.Text));

            Array.Resize(ref studio_collection, studio_collection.Length + 1);
            studio_collection[studio_collection.Length - 1] = studio;
            
            listBox1.Items.Add(studio.Get_Name);

            textBox10.Text = $"К-сть кімнат: {studio.Get_Rooms}";
            textBox11.Text = $"К-сть робітників: {studio.Get_Employees}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            studio_collection[listBox1.SelectedIndex].Remove_Recoding_Room();
            textBox10.Text = $"К-сть кімнат: {studio_collection[listBox1.SelectedIndex].Get_Rooms}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            studio_collection[listBox1.SelectedIndex].Recruit_Employee();
            textBox11.Text = $"К-сть робітників: {studio_collection[listBox1.SelectedIndex].Get_Employees}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            studio_collection[listBox1.SelectedIndex].Fire_Employee();
            textBox11.Text = $"К-сть робітників: {studio_collection[listBox1.SelectedIndex].Get_Employees}";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Studio studio_clone = (Studio)studio_collection[listBox1.SelectedIndex].Clone();
            Array.Resize(ref studio_collection, studio_collection.Length + 1);
            studio_collection[studio_collection.Length - 1] = studio_clone;
            listBox1.Items.Add(studio_clone.Get_Name);
        }
    }
}