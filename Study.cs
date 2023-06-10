using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CubHelper
{
    public partial class Study : Form
    {

        public Study()
        {
            InitializeComponent();
            string[] options = { "Option 1", "Option 2", "Option 3" };
            comboBox1.Items.AddRange(options);
        }

        private void Study_Load(object sender, EventArgs e)
        {
            Formulas formulas = new Formulas();
            pictureBox1.Image = Image.FromFile($"D:\\Project\\Programing\\cub\\oll\\1.png"); // Встановлюємо зображення в PictureBox
            label1.Text = formulas.OLL[0];
        }
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Formulas formulas = new Formulas();

            pictureBox1.Image = Image.FromFile($"D:\\Project\\Programing\\cub\\oll\\{comboBox1.SelectedIndex + 1}.png"); // Встановлюємо зображення в PictureBox
            label1.Text = formulas.OLL[comboBox1.SelectedIndex];
        }



    }
}
