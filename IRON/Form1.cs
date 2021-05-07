using IRON.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRON
{
    public partial class Form1 : Form
    {
        TELEFONDal TELEFON = new TELEFONDal();
        public Form1()
        {
            InitializeComponent();
           // DGVTELEFON.DataSource = TELEFON.GetAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DGVTELEFON.DataSource = TELEFON.GetAll();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
