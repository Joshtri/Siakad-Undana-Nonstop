using Siakad_Undana_Nonstop.Base;
using Siakad_Undana_Nonstop.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siakad_Undana_Nonstop.FormsMahasiswa
{
    public partial class FormTambahUbahMahasiswa : BaseFormTambahUbah
    {
        //Students SelectStudent = null;
        public bool Add = false; 
        public FormTambahUbahMahasiswa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 10)
            {
                MessageBox.Show("Panjang NIM harus 10 karakter");

                return;
            }

            long longNim = 0;

            if (long.TryParse(textBox1.Text, out longNim) == false)
            {
                MessageBox.Show("NIM harus angka");

                return;
            }

            if (Add == true)
            {
                Students newMahasiswa = new Students();
                newMahasiswa.Name = textBox1.Text;
                newMahasiswa.NIM = textBox2.Text;
                newMahasiswa.DateYear = textBox2.Text;
                newMahasiswa.Age = textBox4.Text;
                newMahasiswa.JK = bool.Parse(textBox3.Text);
                newMahasiswa.Angkatan = textBox4.Text;

               // FormDaftarMahasiswa.ListStudents.Add(newMahasiswa);
                MessageBox.Show("Data telah ditambahkan");

                this.Close();

            }
            else
            {
                if (true)
                {
                    //var mahasiswaYangMauDiEdit = FormDaftarMahasiswa.ListStudents.Find(x => x.Nim == mahasiswaDipilih.Nim);

                    //if (mahasiswaYangMauDiEdit != null)
                    //{
                    //    mahasiswaYangMauDiEdit.Nama = textBox2.Text;
                    //    mahasiswaYangMauDiEdit.JenisKelamin = bool.Parse(textBox3.Text);
                    //    mahasiswaYangMauDiEdit.Angkatan = int.Parse(textBox4.Text);

                    //    MessageBox.Show("Data telah diubah");
                    //    this.Close();
                    //}
                }

            }
        }
    }
}
