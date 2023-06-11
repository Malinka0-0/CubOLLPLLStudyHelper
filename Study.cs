using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CubHelper
{
    public partial class Study : Form
    {

        public Study()
        {
            Formulas formulas = new Formulas();
            InitializeComponent();
           
            comboBox1.Items.AddRange(formulas.Spliter("name"));
        }

        private void Study_Load(object sender, EventArgs e)
        {
            Formulas formulas = new Formulas();
            pictureBox1.Image = Image.FromFile($"D:\\Project\\Programing\\cub\\oll\\1.png"); // Встановлюємо зображення в PictureBox
            label1.Text = formulas.Spliter("form",0);
        }
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Formulas formulas = new Formulas();

            pictureBox1.Image = Image.FromFile($"D:\\Project\\Programing\\cub\\oll\\{comboBox1.SelectedIndex + 1}.png"); // Встановлюємо зображення в PictureBox
            label1.Text = formulas.Spliter("form", comboBox1.SelectedIndex);
        }



    }
}
