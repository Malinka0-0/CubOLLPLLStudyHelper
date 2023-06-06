
namespace CubHelper
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            Test test = new Test();
            test.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Repet repet = new Repet();
            repet.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Study study = new Study();
            study.Show();
            this.Hide();
        }
    }
    
}
public class Formulas
{
    public static string[] OLL = {
        "R U R' R U2' R'" /*Рибка 1 */,
        "R U2' R' U' R U' R'" /*Рибка 2 */,
        "R U2' R2' U' R2 U2' R' U2 R" /*Гвинтокрил */,
        "R U R2 U' R' F R U R U' F' " /*Cкобки 1*/,
        "y R' U' R' F R F' U R" /*Скобки 2 */, 
        "Rw U R' U' Rw' F R F'" /*Вуха*/,
        "R' F R U R' U' F'U R " /*Пропейлер 1*/,
        "y2 R U R' F' U' F U R U2 R'" /*Пропейлер 2*/,
        "Rw U R' U' Rw' R U R U' R'" /*Повітряний змій*/,
        "Rw' R U R U R' U' Rw R' M' U R U' Rw'" /*Сніжинка*/,
        "F R U R' U' F'" /*Буква Т 1*/,
        "R U R' U' R' F R F'" /*Буква Т 2*/,
        "R U2' R2' F R F' U2' R' F R F'" /*Крапка 1*/,
        "Rw' U' Rw U2' R' U2' R U2' Rw' U Rw" /*Крапка 2*/,
        "R U R' U R' F R F' U2' R' F R F'" /*Диагональ*/,
        "Rw' R2 U R' U Rw U2' Rw' U R' Rw" /*Кома 1*/,
        "Rw' R U' Rw U2 Rw' U' R U' R2 Rw" /*Кома 2*/,
        "R2 D R' U2' R D' R' U2' R'" /*Очі*/,
        "Rw' R U R U R' U' Rw R2 F R F'" /*Мікі Маус 1*/,
        "Rw U R' U R U2 Rw2 U' R U' R' U2 Rw" /*Мікі Маус 2*/,
        "R U2 R' U' R U R' U' R U' R'" /*Подвійні очі*/,
        "F U R U' R' U R U' R' F'" /*Палиця 1*/,
        "R' F R U R U' R2 F' R2 U' R' U R U R'" /*Палиця 2*/,
        "Rw' U' Rw U' R' U R U' R' U R Rw' U Rw" /*Палиця 3*/,
        "y' R' F' U' F U' R U R' U R" /*Палиця 4*/,
        "F' Rw U R' U' Rw' F R " /*Вісьмірка*/,
        "R U R' U' M'U R U' Rw'" /*Буква Н*/,
        "Rw U Rw' R U R' U' Rw U'" /*Буква Г 1*/,
        "y2 F U R U' R2 F' R U R U' R'" /*Буква Г 2*/,
        "y2 Rw' U' Rw R' U' R U Rw' U Rw" /*Буква Г 3*/,
        "Rw' U Rw U Rw' U' Rw B U' B'" /*Буква Г 4*/,
        "Rw U2 R' U' R U' Rw'" /*Квадрат 1*/,
        "y2 Rw' U2 R U R' U Rw" /*Квадрат 2*/,
        "y2 R U2' R2 F R F' R U2' R'" /*Краватка 1*/,
        "F R U' R' U' R U R' F'" /*Краватка 2*/,
        "R U R' U R U' R'U' R' F R F'" /*Буква М 1*/,
        "L' U' L U' L'U L U Rw U' Rw' F" /*Буква M 2*/,
        "R U R' U' R' F R2 U R' U' F" /*Рюмка 1*/,
        "y2 R U R' U R' F R F' R U2' R'" /*Рюмка 2*/,
        "Rw U R'U R U2 Rw'" /*Близкавка 1*/,
        "R U2 R' U2 R'F R F'" /*Близкавка 2*/,
        "y R' U' F' U F R" /*М'який знак 1 */,
        "y2 R'U' F U R U' R' F' R" /*М'який знак 2*/,
        "y2 F U R U' R' F'" /*М'який знак 3*/,
        "R U B' U' R' U R B R'" /*М'який знак 4*/,
        "y2 R U R' U R U2 R' F R U R' U' F'" /*Півень 1*/,
        "y2 F R' F R2 U' R' U' R U R' F2" /*Півень 2*/,
        "R' U' R U'R' U2 R F R U R' U' F'" /*Півень 3*/,
        "y R U R' U' R U' R' F' U' F R U R'" /*Півень 4*/,
        "F R U R' U' R U R' U' F'" /*Під сходинки 1 */,
        "Rw U' Rw2 U Rw2 U Rw2 U' Rw" /*Під сходинки 2*/,
        "y Rw' U Rw2 U' Rw2 U' Rw2 U Rw'" /*Під сходинки 3*/,
        "F' L' U' L U L' U'L U F" /*Під сходинки 4*/
    };
}