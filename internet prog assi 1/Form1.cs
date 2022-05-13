namespace internet_prog_assi_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {
            string first_name = textBox1.Text;
            string last_name = textBox2.Text;
            StreamReader suh = new StreamReader(@"C:\Users\sahaj\Desktop\internet prog assi 1\internet prog assi 1\suh.txt");
            string stdata = suh.ReadToEnd();
            suh.Close();
            int index1 = stdata.IndexOf(first_name + " " + last_name);
            int index2 = stdata.IndexOf($"end of {first_name} {last_name} data.---------\n");

            if (stdata.Contains(first_name + " " + last_name))
            {


                richTextBox1.Text = stdata.Substring(index1, index2 - index1);

            }
            else
            {
                MessageBox.Show("Not Found!");
            }
        }





        private void button3_Click(object sender, EventArgs e)
        {
            string first_name, last_name, id, major, phone, email_address;
            first_name = textBox7.Text;
            last_name = textBox8.Text;
            id = textBox3.Text;
            major = textBox4.Text;
            phone = textBox5.Text;
            email_address = textBox6.Text;
            if (first_name == "" || last_name == "" || id == "" || major == "" || phone == "" || email_address == "")
            {
                MessageBox.Show("Plz fill all textboxes xd2009");

            }
            else
            {
                using (StreamWriter sw = File.AppendText(@"C:\Users\sahaj\Desktop\internet prog assi 1\internet prog assi 1\suh.txt"))
                {
                    sw.WriteLine(first_name + " " + last_name);
                    sw.WriteLine(id);
                    sw.WriteLine(major);
                    sw.WriteLine(phone);
                    sw.WriteLine(email_address);
                    sw.WriteLine($"end of {first_name} {last_name} data.---------");
                    sw.Close();
                }
            }

        }

        public void button1_Click(object sender, EventArgs e)
        {
            string first_name = textBox1.Text;
            string last_name = textBox2.Text;
            StreamReader suh = new StreamReader(@"C:\Users\sahaj\Desktop\internet prog assi 1\internet prog assi 1\suh.txt");
            string stdata = suh.ReadToEnd();
            suh.Close();
            string last = "";
            int index1 = stdata.IndexOf(first_name + " " + last_name);
            int index2 = stdata.IndexOf($"end of {first_name} {last_name} data.---------\n");

            if (stdata.Contains(first_name + " " + last_name))
            {

                last = stdata.Substring(0, index1) + stdata.Substring(index2 + 30);

                richTextBox1.Text = last;
                StreamWriter sw = new StreamWriter(@"C:\Users\sahaj\Desktop\internet prog assi 1\internet prog assi 1\suh.txt");
                sw.Write(last);
                sw.Close();

            }
            else
            {
                MessageBox.Show("Not Found!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamReader suh = new StreamReader(@"C:\Users\sahaj\Desktop\internet prog assi 1\internet prog assi 1\suh.txt");
            string stdata = suh.ReadToEnd();
            suh.Close();
            richTextBox1.Text = stdata;
        }
    }
}



