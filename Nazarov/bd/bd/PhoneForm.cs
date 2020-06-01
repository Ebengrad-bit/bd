using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bd
{
    public partial class PhoneForm : Form
    {
        public PhoneForm()
        {
            InitializeComponent();
        }

        public Dictionary<int, string> ProviderData
        {
            set
            {
                comboBox1.DataSource = value.ToArray();
                comboBox1.DisplayMember = "Value";
            }
        }

        public int ProviderID
        {
            get { return ((KeyValuePair<int, string>)comboBox1.SelectedItem).Key; }
            set
            {
                int idx = 0;
                foreach (KeyValuePair<int, string> item in comboBox1.Items)
                {
                    if (item.Key == value) break;
                    idx++;
                }
                comboBox1.SelectedIndex = idx;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PhoneForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
