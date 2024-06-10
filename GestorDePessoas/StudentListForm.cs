using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        }

        private void dataGridViewStudentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
