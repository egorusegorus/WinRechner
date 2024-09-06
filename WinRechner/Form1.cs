using System;
using System.Xml.Serialization;
using System.Xml;

namespace WinRechner
{
    public partial class Form1 : Form
    {
        private readonly string xmlPath = "Operations.xml";
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
          
            
            int selectedIndex = listBox2.SelectedIndex;

            // Check if an item is actually selected
            if (selectedIndex >= 0 && selectedIndex < lstOperation.Count)
            {
                // Remove the corresponding object from the list
                lstOperation.RemoveAt(selectedIndex);

                // Refresh the ListBox
                listBox2.Items.Clear();
                foreach (var operation in lstOperation)
                {
                    listBox2.Items.Add(operation.ToString());
                }
            }
            
            /*
            string selectedItem = listBox2.SelectedItem as string;
          
            
            Rechner r = lstOperation.FirstOrDefault(op => op.ToString() == selectedItem);

            if (r != null)
            {
                lstOperation.Remove(r);

                listBox2.Items.Clear();
                foreach (var operation in lstOperation)
                {
                    listBox2.Items.Add(operation.ToString());
                }
            }
        */
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpSpeichern();
        }
    
    private void OpSpeichern()
        {
            try
            {
                using (XmlWriter xmlWriter = XmlWriter.Create(xmlPath))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Rechner>));
                    xmlSerializer.Serialize(xmlWriter, lstOperation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Speichern der Daten: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine(ex);
            }
        }
    }

}
