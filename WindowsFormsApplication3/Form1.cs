using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        Newspaper newsp = new Newspaper();
        public Form1()
        {
            InitializeComponent();
            List<Newspaper> listNewspaper = new List<Newspaper>();

            listNewspaper.Add(new Newspaper() { nameNewspaper = "The New Yourk Times", ratingNewspaper = "65 %", numberOfPagesNewspaper = 42 });
            listNewspaper.Add(new Newspaper() { nameNewspaper = "The Wall Street Journal", ratingNewspaper = "48 %", numberOfPagesNewspaper = 53 });
            listNewspaper.Add(new Newspaper() { nameNewspaper = "Los Angeles Times", ratingNewspaper = "39 %", numberOfPagesNewspaper = 37 });
        

            listBox1.DataSource = listNewspaper;
            listBox1.DisplayMember = "nameNewspaper";
            listBox1.ValueMember = "numberOfPagesNewspaper";
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (int)listBox1.SelectedValue;
            Newspaper newspaper = (Newspaper)listBox1.SelectedItem;
            //string name = newsp.nameNewspaper;
            MessageBox.Show(id.ToString() + ". " + newspaper.nameNewspaper);
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
