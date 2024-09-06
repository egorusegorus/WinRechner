using System;

namespace WinRechner
{
    public partial class Form1 : Form
    {
        private List<Rechner> lstOperation = new List<Rechner>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string? text1 = textBox1.Text;
            string? text2 = textBox2.Text;
            double a = Convert.ToDouble(text1);
            double b = Convert.ToDouble(text2);




            Rechner r = new Rechner(a, b);


            lstOperation.Add(r);


            listBox2.Items.Clear();
            foreach (var operation in lstOperation)
            {
                listBox2.Items.Add(operation.ToString());
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string selectedItem = listBox2.SelectedItem as string;
            Rechner r = lstOperation.FirstOrDefault(op => op.ToString() == selectedItem);

            if (r != null) {
                lstOperation.Remove(r);

                listBox2.Items.Clear();
                foreach (var operation in lstOperation)
                {
                    listBox2.Items.Add(operation.ToString()); 
                }
            }
        }
    }

}
