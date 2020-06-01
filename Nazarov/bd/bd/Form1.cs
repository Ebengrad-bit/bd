using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bd
{
    public partial class Form1 : Form
    {
        //DataGridView gr_phone, gr_contact, gr_provider, gr_phone_list;
        private string address_and_else = global::bd.Properties.Settings.Default.Database1ConnectionString;

        public Form1()
        {
            InitializeComponent();
            //AppdateSQL();
        }
        void UpdateAbonent()
        {
            var request = "SELECT * FROM Nazarov_Abonent";
            var adopter = new SqlDataAdapter(request, address_and_else);
            var abonent_table = new DataTable();
            adopter.Fill(abonent_table);
            dgrv_contact.DataSource = abonent_table;
            //request = "SELECT * FROM Nazarov_Phone";
            dgrv_contact.Columns["Id"].Visible = false;
            dgrv_contact.Columns["name"].HeaderText = "Имя";
            dgrv_contact.Columns["second name"].HeaderText = "Фамилия";
            dgrv_contact.Columns["third name"].HeaderText = "Отчество";
            dgrv_contact.Columns["birthday"].HeaderText = "Дата Рождения";
            dgrv_contact.Columns["comment"].HeaderText = "Комментарий";
            dgrv_contact.Columns["address"].HeaderText = "Адрес";
        }
        void UpdateProvider()
        {
            var request = "SELECT * FROM Nazarov_Provider";
            var adopter = new SqlDataAdapter(request, address_and_else);
            var abonent_table = new DataTable();
            adopter.Fill(abonent_table);
            dgrv_provider.DataSource = abonent_table;
            dgrv_provider.Columns["Id"].Visible = false;
            dgrv_provider.Columns["name"].HeaderText = "Название";
            dgrv_provider.Columns["score"].HeaderText = "Оценка";
        }
        void UpdateContact()
        {
            var request = "SELECT * FROM Nazarov_Contact LEFT JOIN Nazarov_Provider ON Nazarov_Contact.povider_id=Nazarov_Provider.id";
            var adopter = new SqlDataAdapter(request, address_and_else);
            var abonent_table = new DataTable();
            adopter.Fill(abonent_table);
            dgrv_phone.DataSource = abonent_table;
            dgrv_phone.Columns["Id"].Visible = false;
            dgrv_phone.Columns["phone"].HeaderText = "Номер";
            dgrv_phone.Columns["type"].HeaderText = "Тип";
            dgrv_phone.Columns["povider_id"].Visible = false;
            dgrv_phone.Columns["Id1"].Visible = false;
            dgrv_phone.Columns["name"].HeaderText = "Название";
            dgrv_phone.Columns["score"].HeaderText = "Оценка";
        }
        void UpdateMB()
        {
            var request = "SELECT * FROM Nazarov_Abonent RIGHT JOIN Nazarov_Abon_Contact_Buff ON Nazarov_Abonent.Id=Nazarov_Abon_Contact_Buff.abon_id LEFT JOIN Nazarov_Contact ON Nazarov_Contact.Id=Nazarov_Abon_Contact_Buff.cont_id LEFT JOIN Nazarov_Provider ON Nazarov_Contact.povider_id=Nazarov_Provider.Id";
            var adopter = new SqlDataAdapter(request, address_and_else);
            var abonent_table = new DataTable();
            adopter.Fill(abonent_table);
            dgrv_phone_list.DataSource = abonent_table;
            dgrv_phone_list.Columns["Id"].Visible = false;
            dgrv_phone_list.Columns["abon_id"].Visible = false;
            dgrv_phone_list.Columns["cont_id"].Visible = false;
            dgrv_phone_list.Columns["Id1"].Visible = false;
            dgrv_phone_list.Columns["Id2"].Visible = false;
            dgrv_phone_list.Columns["name"].HeaderText = "Имя";
            dgrv_phone_list.Columns["second name"].HeaderText = "Фамилия";
            dgrv_phone_list.Columns["third name"].HeaderText = "Отчество";
            dgrv_phone_list.Columns["birthday"].HeaderText = "Дата Рождения";
            dgrv_phone_list.Columns["comment"].HeaderText = "Комментарий";
            dgrv_phone_list.Columns["address"].HeaderText = "Адрес";
            dgrv_phone_list.Columns["phone"].HeaderText = "Номер";
            dgrv_phone_list.Columns["type"].HeaderText = "Тип";
            dgrv_phone_list.Columns["povider_id"].Visible = false;
            dgrv_phone_list.Columns["name1"].HeaderText = "Провайдер";
            dgrv_phone_list.Columns["score"].Visible = false;
        }
        private void AppdateSQL()
        {
            SqlConnection sqlc = new SqlConnection();
            sqlc.ConnectionString = address_and_else;
            sqlc.Open();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateAbonent();
            UpdateContact();
            UpdateProvider();
            UpdateMB();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = global::bd.Properties.Settings.Default.Database1ConnectionString;
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            com.CommandText = "SELECT * From Nazarov_Abonent";
            SqlDataReader reader = com.ExecuteReader();
            string names = "";
            while (reader.Read())
            {
                names += reader["name"].ToString() + " ";
            }
            MessageBox.Show(names);
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new AbForm();
            var res = form.ShowDialog();
            if (res == DialogResult.OK)
            {
                var fname = form.Name_.Text;
                var sname = form.sName.Text;
                var tname = form.tName.Text;
                var date = Convert.ToDateTime(form.Birthday.Text);
                var comment = form.Comment.Text;
                var addres = form.Address.Text;
                var connection = new SqlConnection(address_and_else);
                connection.Open();
                var reqiest = "INSERT INTO Nazarov_Abonent (name,\"second name\", \"third name\", comment, address) VALUES ('" + fname + "' ,'" + sname + "' ,'" + tname + "' ,'" + comment + "' ,'" + addres + "')";
                var command = new SqlCommand(reqiest, connection);
                command.ExecuteNonQuery();
                connection.Close();
                UpdateAbonent();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var rov = dgrv_contact.SelectedRows.Count > 0 ? dgrv_contact.SelectedRows[0] : null;
            if(rov==null)
            {
                MessageBox.Show("Строчку выбери", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var form = new AbForm();
            form.Name_.Text = rov.Cells["name"].Value.ToString();
            form.sName.Text = rov.Cells["second name"].Value.ToString();
            form.tName.Text = rov.Cells["third name"].Value.ToString();
            form.Comment.Text = rov.Cells["comment"].Value.ToString();
            form.Address.Text = rov.Cells["address"].Value.ToString();

            var res = form.ShowDialog();
            if (res == DialogResult.OK)
            {
                var fname = form.Name_.Text;
                var sname = form.sName.Text;
                var tname = form.tName.Text;
                var comment = form.Comment.Text;
                var addres = form.Address.Text;
                var connection = new SqlConnection(address_and_else);
                var id = rov.Cells["Id"].Value.ToString();
                connection.Open();
                var reqiest = "UPDATE Nazarov_Abonent SET name ='" + fname + "', \"second name\"='" + sname + "', \"third name\"='" + tname + "', comment='" + comment + "', address='" + addres + "' WHERE Id=" + id + ";";
                var command = new SqlCommand(reqiest, connection);
                command.ExecuteNonQuery();
                connection.Close();
                UpdateAbonent();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var rov = dgrv_contact.SelectedRows.Count > 0 ? dgrv_contact.SelectedRows[0] : null;
            if (rov == null)
            {
                MessageBox.Show("Строчку выбери", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var connection = new SqlConnection(address_and_else);
            var id = rov.Cells["Id"].Value.ToString();
            connection.Open();
            var reqiest = "DELETE FROM Nazarov_Abonent WHERE Id=" + id;
            var command = new SqlCommand(reqiest, connection);
            command.ExecuteNonQuery();
            connection.Close();
            UpdateAbonent();
        }

        private void Serch()
        {
            var request = @"SELECT *FROM Nazarov_Abonent JOIN  Nazarov_Abon_Contact_Buff ON Nazarov_Abonent.Id= Nazarov_Abon_Contact_Buff.abon_id 
            JOIN Nazarov_Contact ON Nazarov_Contact.Id= Nazarov_Abon_Contact_Buff.cont_id LEFT JOIN Nazarov_Provider ON Nazarov_Provider.Id=Nazarov_Contact.povider_id ";

            if (textBox1.Text != "")
            {
                request += " WHERE  Nazarov_Contact.phone LIKE+'%" + textBox1.Text + "%'";

            }

            if (textBox2.Text != "")
            {
                request += " WHERE Nazarov_Abonent.\"second name\"+' '   +Nazarov_Abonent.\"third name\"+' ' +Nazarov_Abonent.name  LIKE+'%" + textBox2.Text + "%'";
            }

            var adapter = new SqlDataAdapter(request, address_and_else);
            var abonTable = new DataTable();
            adapter.Fill(abonTable);
            dgrv_phone_list.DataSource = abonTable;

            dgrv_phone_list.Columns["Id"].Visible = false;
            dgrv_phone_list.Columns["abon_id"].Visible = false;
            dgrv_phone_list.Columns["cont_id"].Visible = false;
            dgrv_phone_list.Columns["Id1"].Visible = false;
            dgrv_phone_list.Columns["Id2"].Visible = false;
            dgrv_phone_list.Columns["name"].HeaderText = "Имя";
            dgrv_phone_list.Columns["second name"].HeaderText = "Фамилия";
            dgrv_phone_list.Columns["third name"].HeaderText = "Отчество";
            dgrv_phone_list.Columns["birthday"].HeaderText = "Дата Рождения";
            dgrv_phone_list.Columns["comment"].HeaderText = "Комментарий";
            dgrv_phone_list.Columns["address"].HeaderText = "Адрес";
            dgrv_phone_list.Columns["phone"].HeaderText = "Номер";
            dgrv_phone_list.Columns["type"].HeaderText = "Тип";
            dgrv_phone_list.Columns["povider_id"].Visible = false;
            dgrv_phone_list.Columns["name1"].HeaderText = "Провайдер";
            dgrv_phone_list.Columns["score"].Visible = false;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Serch();
            //UpdateAbonent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Serch();
            //UpdateAbonent();
        }

        private void tab_contat_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var rov = dgrv_contact.SelectedRows.Count > 0 ? dgrv_contact.SelectedRows[0] : null;
            if (rov == null)
            {
                MessageBox.Show("Строчку выбери", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var form = new AbForm();
            form.Name_.Text = rov.Cells["name"].Value.ToString();
            form.sName.Text = rov.Cells["second name"].Value.ToString();
            form.tName.Text = rov.Cells["third name"].Value.ToString();
            form.Comment.Text = rov.Cells["comment"].Value.ToString();
            form.Address.Text = rov.Cells["address"].Value.ToString();

            var res = form.ShowDialog();
            if (res == DialogResult.OK)
            {
                var fname = form.Name_.Text;
                var sname = form.sName.Text;
                var tname = form.tName.Text;
                var comment = form.Comment.Text;
                var addres = form.Address.Text;
                var connection = new SqlConnection(address_and_else);
                var id = rov.Cells["Id"].Value.ToString();
                connection.Open();
                var reqiest = "UPDATE Nazarov_Abonent SET name ='" + fname + "', \"second name\"='" + sname + "', \"third name\"='" + tname + "', comment='" + comment + "', address='" + addres + "' WHERE Id=" + id + ";";
                var command = new SqlCommand(reqiest, connection);
                command.ExecuteNonQuery();
                connection.Close();
                UpdateAbonent();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            var rov = dgrv_contact.SelectedRows.Count > 0 ? dgrv_contact.SelectedRows[0] : null;
            if (rov == null)
            {
                MessageBox.Show("Строчку выбери", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var connection = new SqlConnection(address_and_else);
            var id = rov.Cells["Id"].Value.ToString();
            connection.Open();
            var reqiest = "DELETE FROM Nazarov_Abonent WHERE Id=" + id;
            var command = new SqlCommand(reqiest, connection);
            command.ExecuteNonQuery();
            connection.Close();
            UpdateAbonent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var form = new AbForm();
            var res = form.ShowDialog();
            if (res == DialogResult.OK)
            {
                var fname = form.Name_.Text;
                var sname = form.sName.Text;
                var tname = form.tName.Text;
                var date = Convert.ToDateTime(form.Birthday.Text);
                var comment = form.Comment.Text;
                var addres = form.Address.Text;
                var connection = new SqlConnection(address_and_else);
                connection.Open();
                var reqiest = "INSERT INTO Nazarov_Abonent (name,\"second name\", \"third name\", comment, address) VALUES ('" + fname + "' ,'" + sname + "' ,'" + tname + "' ,'" + comment + "' ,'" + addres + "')";
                var command = new SqlCommand(reqiest, connection);
                command.ExecuteNonQuery();
                connection.Close();
                UpdateAbonent();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            var form = new ProvForm();
            var res = form.ShowDialog();
            if (res == DialogResult.OK)
            {
                var name = form.Name_.Text;
                var score = form.chir.Text;
                var connection = new SqlConnection(address_and_else);
                connection.Open();
                //var reqiest = "INSERT INTO Nazarov_Abonent (name,\"second name\", \"third name\", comment, address) VALUES ('" + fname + "' ,'" + sname + "' ,'" + tname + "' ,'" + comment + "' ,'" + addres + "')";
                var reqiest = "INSERT INTO Nazarov_Provider (name, score) VALUES ('" + name + "' ,'" + score + "')";
                var command = new SqlCommand(reqiest, connection);
                command.ExecuteNonQuery();
                connection.Close();
                UpdateProvider();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var rov = dgrv_provider.SelectedRows.Count > 0 ? dgrv_contact.SelectedRows[0] : null;
            if (rov == null)
            {
                MessageBox.Show("Строчку выбери", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var connection = new SqlConnection(address_and_else);
            var id = rov.Cells["Id"].Value.ToString();
            connection.Open();
            var reqiest = "DELETE FROM Nazarov_Provider WHERE Id=" + id;
            var command = new SqlCommand(reqiest, connection);
            command.ExecuteNonQuery();
            connection.Close();
            UpdateProvider();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var rov = dgrv_provider.SelectedRows.Count > 0 ? dgrv_contact.SelectedRows[0] : null;
            if (rov == null)
            {
                MessageBox.Show("Строчку выбери", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var form = new ProvForm();
            form.Name_.Text = rov.Cells["name"].Value.ToString();
            form.chir.Text = rov.Cells["score"].Value.ToString();

            var res = form.ShowDialog();
            if (res == DialogResult.OK)
            {
                var name = form.Name_.Text;
                var score = form.chir.Text;
                var connection = new SqlConnection(address_and_else);
                connection.Open();
                //var reqiest = "INSERT INTO Nazarov_Abonent (name,\"second name\", \"third name\", comment, address) VALUES ('" + fname + "' ,'" + sname + "' ,'" + tname + "' ,'" + comment + "' ,'" + addres + "')";
                var reqiest = "INSERT INTO Nazarov_Provider (name, score) VALUES ('" + name + "' ,'" + score + "')";
                var command = new SqlCommand(reqiest, connection);
                command.ExecuteNonQuery();
                connection.Close();
                UpdateProvider();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var form = new PhoneForm();
            {
                var getReq = "SELECT *FROM Nazarov_Provider";
                var contactAdapter = new SqlDataAdapter(getReq, address_and_else);
                var dict = new Dictionary<int, string>();
                var providerTbl = new DataTable();
                contactAdapter.Fill(providerTbl);

                foreach (DataRow row in providerTbl.Rows)
                {
                    dict.Add((int)row["Id"], row["name"].ToString());
                }
                form.ProviderData = dict;
            }

            var res = form.ShowDialog();
            if (res == DialogResult.OK)
            {
                var phone = form.Phone.Text;
                var type = form.type.Text;
                var provider_id = form.ProviderID;
                var connection = new SqlConnection(address_and_else);
                connection.Open();
                var request = "INSERT INTO Nazarov_Contact (phone, type, povider_id) VALUES ('" + phone + "', '" + type + "', '" + provider_id.ToString() + "')";
                var command = new SqlCommand(request, connection);
                command.ExecuteNonQuery(); //выполняет комманду не требуя что-то взамен и ничего не возвращающий
                connection.Close();
                UpdateContact();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var rov = dgrv_phone.SelectedRows.Count > 0 ? dgrv_contact.SelectedRows[0] : null;
            if (rov == null)
            {
                MessageBox.Show("Строчку выбери", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var connection = new SqlConnection(address_and_else);
            var id = rov.Cells["Id"].Value.ToString();
            connection.Open();
            var reqiest = "DELETE FROM Nazarov_Contact WHERE Id=" + id;
            var command = new SqlCommand(reqiest, connection);
            command.ExecuteNonQuery();
            connection.Close();
            UpdateContact();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var rov = dgrv_phone.SelectedRows.Count > 0 ? dgrv_contact.SelectedRows[0] : null;
            if (rov == null)
            {
                MessageBox.Show("Строчку выбери", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var form = new PhoneForm();
            form.Phone.Text = rov.Cells["phone"].Value.ToString();
            form.type.Text = rov.Cells["type"].Value.ToString();
            {
                var getReq = "SELECT *FROM Nazarov_Provider";
                var contactAdapter = new SqlDataAdapter(getReq, address_and_else);
                var dict = new Dictionary<int, string>();
                var providerTbl = new DataTable();
                contactAdapter.Fill(providerTbl);

                foreach (DataRow row in providerTbl.Rows)
                {
                    dict.Add((int)row["Id"], row["name"].ToString());
                }
                form.ProviderData = dict;
            }

            var res = form.ShowDialog();
            if (res == DialogResult.OK)
            {
                var phone = form.Phone.Text;
                var type = form.type.Text;
                var provider_id = form.ProviderID;
                var id = rov.Cells["Id"].Value.ToString();
                var connection = new SqlConnection(address_and_else);
                connection.Open();
                var request = "UPDATE Nazarov_Contact SET phone ='" + phone + "', type ='" + type + "', povider_id ='" + provider_id.ToString() + "' WHERE Id=" + id + ";";
                var command = new SqlCommand(request, connection);
                command.ExecuteNonQuery(); //выполняет комманду не требуя что-то взамен и ничего не возвращающий
                connection.Close();
                UpdateContact();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var form = new ContForm();
            {
                var getReq = "SELECT * FROM Nazarov_Abonent";
                var contactAdapter = new SqlDataAdapter(getReq, address_and_else);
                var dict = new Dictionary<int, string>();
                var providerTbl = new DataTable();
                contactAdapter.Fill(providerTbl);

                foreach (DataRow row in providerTbl.Rows)
                {
                    string s = row["name"].ToString() + row["second name"].ToString() + row["third name"].ToString();
                    dict.Add((int)row["Id"], s);
                }
                form.MeanData = dict;
            }
            {
                var getReq = "SELECT * FROM Nazarov_Contact";
                var Adapter = new SqlDataAdapter(getReq, address_and_else);
                var dict = new Dictionary<int, string>();
                var Tbl = new DataTable();
                Adapter.Fill(Tbl);

                foreach (DataRow row in Tbl.Rows)
                {
                    dict.Add((int)row["Id"], row["phone"].ToString());
                }
                form.PhoneData = dict;
            }
            if (form.ShowDialog() == DialogResult.OK)
            {
                var conn = new SqlConnection(address_and_else);
                conn.Open();

                var request = "INSERT INTO Nazarov_Abon_Contact_Buff" + "(abon_id, cont_id)" + " VALUES " + "('" + form.AbId+ "', '" + form.PhoneId + "')";
                var com = new SqlCommand(request, conn);
                com.ExecuteNonQuery();

                conn.Close();

                UpdateContact();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

            var rov = dgrv_phone_list.SelectedRows.Count > 0 ? dgrv_contact.SelectedRows[0] : null;
            if (rov == null)
            {
                MessageBox.Show("Строчку выбери", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var connection = new SqlConnection(address_and_else);
            var abid = rov.Cells["abon_id"].Value.ToString();
            var conid = rov.Cells["cont_id"].Value.ToString();
            connection.Open();
            var reqiest = "DELETE FROM Nazarov_Abon_Contact_Buff WHERE abon_id=" + abid + ", cont_id=" + conid;
            var command = new SqlCommand(reqiest, connection);
            command.ExecuteNonQuery();
            connection.Close();
            UpdateContact();
       
        }
    }
}
