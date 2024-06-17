using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestorDePessoas
{
    public partial class StudentList : Form
    {
        public StudentList()
        {
            InitializeComponent();
        }

        Estudante estudante = new Estudante();

        private void StudentList_Load(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand("SELECT * FROM `estudantes`");
            dataGridViewStudentList.ReadOnly = true;

            DataGridViewImageColumn colunaDeFotos = new DataGridViewImageColumn();
            dataGridViewStudentList.RowTemplate.Height = 80;
            dataGridViewStudentList.DataSource = estudante.getStudent(comando);
            colunaDeFotos = (DataGridViewImageColumn)dataGridViewStudentList.Columns[7];
            colunaDeFotos.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewStudentList.AllowUserToAddRows = false;

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

        }
     
        private void dataGridViewStudentList_DoubleClick(object sender, EventArgs e)
        {
            Update_DeleteForm update_DeleteForm = new Update_DeleteForm();

            update_DeleteForm.textBoxID.Text = dataGridViewStudentList.CurrentRow.Cells[0].Value.ToString();
            update_DeleteForm.textBoxName.Text = dataGridViewStudentList.CurrentRow.Cells[1].Value.ToString();
            update_DeleteForm.textBoxSurname.Text = dataGridViewStudentList.CurrentRow.Cells[2].Value.ToString();
            update_DeleteForm.dateTimePickerBirthday.Value = (DateTime)dataGridViewStudentList.CurrentRow.Cells[3].Value;
            if (dataGridViewStudentList.CurrentRow.Cells[4].Value.ToString() == "Feminino")
            {
                update_DeleteForm.radioButtonFem.Checked = true;
            }
            else if (dataGridViewStudentList.CurrentRow.Cells[4].Value.ToString() == "Masculino")
            {
                update_DeleteForm.radioButtonOther.Checked = true;
            }
            else
            {
                update_DeleteForm.radioButtonMasc.Checked = true;
            }
            update_DeleteForm.textBoxTelephone.Text = dataGridViewStudentList.CurrentRow.Cells[5].Value.ToString();
            update_DeleteForm.textBoxAdress.Text = dataGridViewStudentList.CurrentRow.Cells[6].Value.ToString();
            
            byte[] Photo;
            Photo = (byte[])dataGridViewStudentList.CurrentRow.Cells[7].Value;
            MemoryStream StudentPhoto = new MemoryStream(Photo);
            update_DeleteForm.pictureBoxStudent.Image = Image.FromStream(StudentPhoto);

            update_DeleteForm.Show();
        }

        private void dataGridViewStudentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
