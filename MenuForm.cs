
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
    public string[] Spliter(string input)
    {
        string[] names = new string[OLL.Length];
        string[] form = new string[OLL.Length];
        for (int i = 0; i < OLL.Length; i++)
        {
            string[] parts = OLL[i].Split('|');
            names[i] = parts[0].Trim();
            form[i] = parts[1].Trim();
        }

        if (input == "names")
        {
            return names;
        }
        else
        {
            return form;
        }
    }

    public object[] Spliter(string input , string input2)
    {
        string[] names = new string[OLL.Length];
        string[] form = new string[OLL.Length];
        for (int i = 0; i < OLL.Length; i++)
        {
            string[] parts = OLL[i].Split('|');
            names[i] = parts[0].Trim();
            form[i] = parts[1].Trim();
        }

        return new object[] { names, form };
    }
    public string Spliter(string input , int index )
    {
        
        string FormsIndex = OLL[index];

        return FormsIndex;
    }

    private string[] OLL = {
        "R U R' R U2' R'" /*Рибка 1 */,
        "R U2' R' U' R U' R'" /*Рибка 2 */,
        "R U2' R2' U' R2 U2' R' U2 R" /*Гвинтокрил */,
        "R U R2 U' R' F R U R U' F' " /*Cкобки 1*/,
        "y R' U' R' F R F' U R" /*Скобки 2 */,
        "Rw U R' U' Rw' F R F'" /*Вуха*/,
        "R' F R U R' U' F'U R " /*Пропейлер 1*/,
        "y2 R U R' F' U' F U R U2 R'" /*Пропейлер 2*/,
        "Повітряний змій | Rw U R' U' Rw' R U R U' R'" /*Повітряний змій*/,
        "Cніжинка | Rw' R U R U R' U' Rw R' M' U R U' Rw'" /*Сніжинка*/,
        "F R U R' U' F'" /*Буква Т 1*/,
        "R U R' U' R' F R F'" /*Буква Т 2*/,
        "Куля в коридорі | R U2' R2' F R F' U2' R' F R F'" /*Куля в коритоді 1*/,
        "Куля в стіну Rw' U' Rw U2' R' U2' R U2' Rw' U Rw" /*Куля в стіну 2*/,
        "Доміно | R U R' U R' F R F' U2' R' F R F'" /*Доміно */,
        "Кома з точкою | Rw' R2 U R' U Rw U2' Rw' U R' Rw" /*Кома з точкою */,
        "Кома з блоком | Rw' R U' Rw U2 Rw' U' R U' R2 Rw" /*Кома з блоком */,
        "R2 D R' U2' R D' R' U2' R'" /*Очі*/,
        "Міккі Маус с бакенбардами | Rw' R U R U R' U' Rw R2 F R F'" /*Міккі Маус з бакенбардами */,
        "Міккі Маус с бородою | Rw U R' U R U2 Rw2 U' R U' R' U2 Rw" /*Міккі Маус з бородою */,
        "R U2 R' U' R U R' U' R U' R'" /*Подвійні очі*/,
        "F U R U' R' U R U' R' F'" /*Палиця 1*/,
        "R' F R U R U' R2 F' R2 U' R' U R U R'" /*Палиця 2*/,
        "Rw' U' Rw U' R' U R U' R' U R Rw' U Rw" /*Палиця 3*/,
        "y' R' F' U' F U' R U R' U R" /*Палиця 4*/,
        "F' Rw U R' U' Rw' F R " /*Вісьмірка*/,
        "Вертолітний майданчик | R U R' U' M'U R U' Rw'" /*вертолітний майданчик*/,
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
        "Ліва близкавка з блоко | Rw U R'U R U2 Rw'" /*Ліва близкавка з блоком*/,
        "Права Близкавка з блоком | R U2 R' U2 R'F R F'" /*Права Близкавка з блоком*/,
        "y R' U' F' U F R" /*М'який знак 1 */,
        "y2 R'U' F U R U' R' F' R" /*М'який знак 2*/,
        "y2 F U R U' R' F'" /*М'який знак 3*/,
        "R U B' U' R' U R B R'" /*М'який знак 4*/,
        "y2 R U R' U R U2 R' F R U R' U' F'" /*Півень 1*/,
        "y2 F R' F R2 U' R' U' R U R' F2" /*Півень 2*/,
        "R' U' R U'R' U2 R F R U R' U' F'" /*Півень 3*/,
        "y R U R' U' R U' R' F' U' F R U R'" /*Півень 4*/,

        "Бумеранг 2-1 | F R U R' U' R U R' U' F'" /*Бумеранг  2-1 */,

        "Бумеранг 3-2 | Rw U' Rw2 U Rw2 U Rw2 U' Rw" /*Бумеранг 3-2 */,

        "Бумеранг 2-3 |  Rw' U Rw2 U' Rw2 U' Rw2 U Rw'" /*Під сходинки 3*/,

        "Бумеранг 1-2 | F' L' U' L U L' U'L U F" /*Бумеранг 1-2 */

    };
    
}
