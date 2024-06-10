using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void buttonSendPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog searchPhoto = new OpenFileDialog();

            searchPhoto.Filter = "Escolha a foto (*.jpg;*.png;*.jpeg;*.gif)|*.jpg;*.png;*.jpeg;*.gif";

            if (searchPhoto.ShowDialog() == DialogResult.OK)
            {
                pictureBoxStudent.Image = Image.FromFile(searchPhoto.FileName);

            }
        }
    }
}
