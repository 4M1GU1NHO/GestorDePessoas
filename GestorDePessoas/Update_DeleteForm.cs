using MySql.Data.MySqlClient;
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

namespace GestorDePessoas
{
    public partial class Update_DeleteForm : Form
    {
        public Update_DeleteForm()
        {
            InitializeComponent();
        }

        Estudante estudante = new Estudante();

        MeuBancoDeDados meuBancoDeDados = new MeuBancoDeDados();
        private void buttonSendPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog searchPhoto = new OpenFileDialog();

            searchPhoto.Filter = "Escolha a foto (*.jpg;*.png;*.jpeg;*.gif)|*.jpg;*.png;*.jpeg;*.gif";

            if (searchPhoto.ShowDialog() == DialogResult.OK)
            {
                pictureBoxStudent.Image = Image.FromFile(searchPhoto.FileName);

            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            
            
            int id = Convert.ToInt32(textBoxID.Text);
            string nome = textBoxName.Text;
            string sobrenome = textBoxSurname.Text;
            DateTime nascimento = dateTimePickerBirthday.Value;
            string telefone = textBoxTelephone.Text;
            string endereco = textBoxAdress.Text;
            string genero = "Outro";

            if (radioButtonMasc.Checked == true)
            {
                genero = "Masculino";
            }
            else if (radioButtonFem.Checked == true)
            {
                genero = "Feminino";
            }

            MemoryStream foto = new MemoryStream();

            int Birthday = dateTimePickerBirthday.Value.Year;
            int todayDate = DateTime.Now.Year;

            if ((todayDate - todayDate) < 10 || (todayDate - Birthday) > 100)
            {
                MessageBox.Show("Idade do aluno inválida.", "Data de nascimento inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Verify())
            {
                pictureBoxStudent.Image.Save(foto, pictureBoxStudent.Image.RawFormat);
                if (estudante.uptadeStudent(id, nome, sobrenome, nascimento, telefone, genero, endereco, foto))
                {
                    MessageBox.Show("Informações alteradas com sucesso", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Falha no salvamento", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Informações inválidas", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool Verify()
        {
            if ((textBoxName.Text.Trim() == "") ||
                (textBoxSurname.Text.Trim() == "") ||
                (textBoxTelephone.Text.Trim() == "") ||
                (textBoxAdress.Text.Trim() == "") ||
                (pictureBoxStudent.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonErase_Click(object sender, EventArgs e)
        {
            int StudentID = Convert.ToInt32(textBoxName.Text);
            if (MessageBox.Show("Tem certeza que deseja apagar seus dados?","Deletar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(estudante.deleteStudent(StudentID))
                { 
                    MessageBox.Show("Estudante apagado com sucesso.","Apagar");
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(textBoxID.Text);
                MySqlCommand comando = new MySqlCommand("SELECT `id`, `nome`, `sobrenome`, `nascimento`, `genero`, `telefone`, `endereco`, `foto` FROM `estudantes` WHERE `id`=@id", meuBancoDeDados.getConexao);

                DataTable tabela = estudante.getStudent(comando);

                comando.Parameters.Add("@ID", MySqlDbType.Int32).Value = ID;

                if (tabela.Rows.Count > 0)
                {

                    textBoxName.Text = tabela.Rows[0]["nome"].ToString();
                    textBoxSurname.Text = tabela.Rows[0]["sobrenome"].ToString();
                    textBoxTelephone.Text = tabela.Rows[0]["telefone"].ToString();
                    textBoxAdress.Text = tabela.Rows[0]["endereco"].ToString();
                    dateTimePickerBirthday.Value = (DateTime)tabela.Rows[0]["nascimento"];

                    if (tabela.Rows[0]["genero"].ToString() == "Masculino")
                    {
                        radioButtonMasc.Checked = true;
                    }
                    else if (tabela.Rows[0]["genero"].ToString() == "Feminino")
                    {
                        radioButtonFem.Checked = true;
                    }
                    else
                    {
                        radioButtonOther.Checked = true;
                    }

                    byte[] photo = (byte[])tabela.Rows[0]["foto"];
                    MemoryStream photoStudent = new MemoryStream(photo);
                    pictureBoxStudent.Image = Image.FromStream(photoStudent);
                }
            } catch (Exception exeption)
              { 
                MessageBox.Show("Digite uma ID válida.", "ID Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.MyChar))
            {
                e.Handled = true;
            }
        }
    }
}
