﻿using System;
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
    public partial class InsertForm : Form
    {
        public InsertForm()
        {
            InitializeComponent();
        }       
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Estudante estudante = new Estudante();
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
                if (estudante.inserirEstudante(nome, sobrenome, nascimento, telefone, genero, endereco, foto))
                {
                    MessageBox.Show("Login criado com sucesso", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Falha no login", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Informações inválidas", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSendPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog searchPhoto = new OpenFileDialog();
            
            searchPhoto.Filter = "Escolha a foto (*.jpg;*.png;*.jpeg;*.gif)|*.jpg;*.png;*.jpeg;*.gif";

            if(searchPhoto.ShowDialog() == DialogResult.OK)
            { 
                pictureBoxStudent.Image = Image.FromFile(searchPhoto.FileName);
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

        private void textBoxSurname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
