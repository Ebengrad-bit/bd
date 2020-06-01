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
    public partial class ContForm : Form
    {
        public ContForm()
        {
            InitializeComponent();
        }

        public Dictionary<int, string> MeanData
        {
            set
            {
                Ab.DataSource = value.ToArray();
                Ab.DisplayMember = "Value";
            }
        }

        public int AbId
        {
            get { return ((KeyValuePair<int, string>)Ab.SelectedItem).Key; }
            set
            {
                int idx = 0;
                foreach (KeyValuePair<int, string> item in Ab.Items)
                {
                    if (item.Key == value) break;
                    idx++;
                }
                Ab.SelectedIndex = idx;
            }
        }
        public Dictionary<int, string> PhoneData
        {
            set
            {
                Phone.DataSource = value.ToArray();
                Phone.DisplayMember = "Value";
            }
        }

        public int PhoneId
        {
            get { return ((KeyValuePair<int, string>)Phone.SelectedItem).Key; }
            set
            {
                int idx = 0;
                foreach (KeyValuePair<int, string> item in Phone.Items)
                {
                    if (item.Key == value) break;
                    idx++;
                }
                Phone.SelectedIndex = idx;
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Phone_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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
