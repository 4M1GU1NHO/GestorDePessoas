using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDePessoas
{
    public partial class ManageStudentsForm : Form
    {
        public ManageStudentsForm()
        {
            InitializeComponent();
        }
        Estudante estudante = new Estudante();

        private void ManageStudentsForm_Load(object sender, EventArgs e)
        {
            FillTable(new MySqlCommand("SELECT * FROM `estudantes`"));
        }
        public void FillTable(MySqlCommand comando)
        {
            dataGridViewStudentList.ReadOnly = true;

            DataGridViewImageColumn colunaDeFotos = new DataGridViewImageColumn();
            dataGridViewStudentList.RowTemplate.Height = 80;
            dataGridViewStudentList.DataSource = estudante.getStudent(comando);
            colunaDeFotos = (DataGridViewImageColumn)dataGridViewStudentList.Columns[7];
            colunaDeFotos.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewStudentList.AllowUserToAddRows = false;

            labelStudentsTotal.Text = "Total de Alunos:" + dataGridViewStudentList.Rows.Count;
        }

        private void dataGridViewStudentList_Click(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridViewStudentList.CurrentRow.Cells[0].Value.ToString();
            textBoxName.Text = dataGridViewStudentList.CurrentRow.Cells[1].Value.ToString();
            textBoxSurname.Text = dataGridViewStudentList.CurrentRow.Cells[2].Value.ToString();
            dateTimePickerBirthday.Value = (DateTime)dataGridViewStudentList.CurrentRow.Cells[3].Value;

            if (dataGridViewStudentList.CurrentRow.Cells[4].Value.ToString() == "Masculino")
            {
                radioButtonMasc.Checked = true;
            }
            else if (dataGridViewStudentList.CurrentRow.Cells[4].Value.ToString() == "Feminino")
            {
                radioButtonFem.Checked = true;
            }
            else
            {
                radioButtonOther.Checked = true;
            }
            textBoxTelephone.Text = dataGridViewStudentList.CurrentRow.Cells[5].Value.ToString();
            textBoxAdress.Text = dataGridViewStudentList.CurrentRow.Cells[6].Value.ToString();

            byte[] Photo;
            Photo = (byte[])dataGridViewStudentList.CurrentRow.Cells[7].Value;
            MemoryStream studentPhoto = new MemoryStream(Photo);
            pictureBoxStudent.Image = Image.FromStream(studentPhoto);
        }

        private void buttonRedefine_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            textBoxName.Text = "";
            textBoxSurname.Text = "";
            textBoxAdress.Text = "";
            textBoxTelephone.Text = "";
            radioButtonMasc.Checked = true;
            dateTimePickerBirthday.Value = DateTime.Now;
            pictureBoxStudent.Image = null;
        }

        private void buttonSendPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog searchPhoto = new OpenFileDialog();

            searchPhoto.Filter = "Escolha a foto (*.jpg;*.png;*.jpeg;*.gif)|*.jpg;*.png;*.jpeg;*.gif";

            if (searchPhoto.ShowDialog() == DialogResult.OK)
            {
                pictureBoxStudent.Image = Image.FromFile(searchPhoto.FileName);
            }
        }

        private void buttonDowload_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveArquive = new SaveFileDialog();
            saveArquive.FileName = "Estudante_" + textBoxID.Text;
            if (pictureBoxStudent.Image == null)
            {
                MessageBox.Show("Insira uma foto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            { 
                saveArquive.ShowDialog();
                pictureBoxStudent.Image.Save(saveArquive.FileName + ("." + ImageFormat.Jpeg.ToString()));
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string search = "SELECT * FROM `estudantes` WHERE CONCAT(`nome`,`sobrenome`,`endereco`) LIKE`%"+textBoxSearch.Text+"%'`";
            MySqlCommand comando = new MySqlCommand(search);
            FillTable(comando);
        }
    }
}
