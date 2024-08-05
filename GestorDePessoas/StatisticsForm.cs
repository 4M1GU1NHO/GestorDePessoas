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
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
        }

        Color colorPanelTotal;
        Color colorPanelMen;
        Color colorPanelWomen;

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            colorPanelTotal = panelTotal.BackColor;
            colorPanelMen = panelMen.BackColor;
            colorPanelWomen = panelWomen.BackColor;
        }

        private void panelTotal_MouseEnter(object sender, EventArgs e)
        {
            panelTotal.BackColor = Color.Gray;
            labelTotal.ForeColor = Color.White;
        }

        private void panelTotal_MouseLeave(object sender, EventArgs e)
        {

        }

        private void panelMen_MouseEnter(object sender, EventArgs e)
        {

        }

        private void panelMen_MouseLeave(object sender, EventArgs e)
        {

        }

        private void panelWomen_MouseEnter(object sender, EventArgs e)
        {

        }

        private void panelWomen_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
