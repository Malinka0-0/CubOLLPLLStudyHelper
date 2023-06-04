using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CubHelper
{
    public partial class Study : Form
    {
        public Study()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 55); // Генеруємо випадкове число від 1 до 54

            string imagePath = $"D:\\Project\\Programing\\cub\\oll\\{randomNumber}.png"; // Складаємо шлях до випадкового зображення

            pictureBox1.Image = Image.FromFile(imagePath); // Встановлюємо зображення в PictureBox


        }
    }
}
