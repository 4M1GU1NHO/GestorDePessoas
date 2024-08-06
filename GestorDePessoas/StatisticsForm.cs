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

        private void labelTotal_MouseEnter(object sender, EventArgs e)
        {
            panelTotal.BackColor = Color.Black;
            labelTotal.ForeColor = colorPanelTotal;

        }

        private void labelTotal_MouseLeave(object sender, EventArgs e)
        {
            panelTotal.BackColor = colorPanelTotal;
            labelTotal.ForeColor = Color.Black;
        }

        private void labelMen_MouseEnter(object sender, EventArgs e)
        {
            panelMen.BackColor = Color.Black;
            labelMen.ForeColor = colorPanelMen;
        }

        private void labelMen_MouseLeave(object sender, EventArgs e)
        {
            panelMen.BackColor = colorPanelMen;
            labelMen.ForeColor = Color.Black;
        }

        private void labelWomen_MouseEnter(object sender, EventArgs e)
        {
            panelWomen.BackColor = Color.Black;
            labelWomen.ForeColor = colorPanelWomen;
        }

        private void labelWomen_MouseLeave(object sender, EventArgs e)
        {
            panelWomen.BackColor = colorPanelWomen;
            labelWomen.ForeColor = Color.Black;
        }
    }
}
