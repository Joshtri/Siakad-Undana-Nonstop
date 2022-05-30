using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Siakad_Undana_Nonstop
{
    public partial class LoginOfficer : Form
    {
        LoginOfficer Instance; 
        public LoginOfficer()
        {
            InitializeComponent();
            Instance = this;
        }

        public String Username;
        public String Password; //PK

        private SqlConnection connecting = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SiakadDB;Integrated Security=True");

        public void button1_Click(object sender, EventArgs e)
        {
            Siakad_Menu siakad_Menu = new Siakad_Menu();
            

            Username = NameTextbox.Text;
            Password = PasswordBox.Text;

            try
            {
                String querry = "SELECT * FROM Table_1 WHERE username = '" + NameTextbox.Text + "' AND password =  '" + PasswordBox.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, connecting);

                DataTable dtable = new DataTable();

                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    Username = NameTextbox.Text;
                    Password = PasswordBox.Text;

                    Siakad_Menu frm = new Siakad_Menu();

                    frm.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Fill the correct Data !", ":)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NameTextbox.Clear();
                    PasswordBox.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                connecting.Close();
            }

            //if (NameTextbox.Text == Username && PasswordBox.Text == NIM_PK)
            //{
            //    MessageBox.Show("You're Corrected, welcome");

            //    if (true)
            //    {
            //        Siakad_Menu ob = new Siakad_Menu();
            //        Hide();
            //        ob.Show();
            //    }
            //}

            //else if (NameTextbox.Text == "" || PasswordBox.Text == "")
            //{
            //    MessageBox.Show("Fill The empty data!");
            //}

            //else
            //{
            //    MessageBox.Show("Input the correct data");
            //}
        }
    }
}