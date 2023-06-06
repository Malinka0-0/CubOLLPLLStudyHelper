
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
        "R U R' R U2' R'" /*����� 1 */,
        "R U2' R' U' R U' R'" /*����� 2 */,
        "R U2' R2' U' R2 U2' R' U2 R" /*���������� */,
        "R U R2 U' R' F R U R U' F' " /*C����� 1*/,
        "y R' U' R' F R F' U R" /*������ 2 */, 
        "Rw U R' U' Rw' F R F'" /*����*/,
        "R' F R U R' U' F'U R " /*��������� 1*/,
        "y2 R U R' F' U' F U R U2 R'" /*��������� 2*/,
        "Rw U R' U' Rw' R U R U' R'" /*��������� ���*/,
        "Rw' R U R U R' U' Rw R' M' U R U' Rw'" /*�������*/,
        "F R U R' U' F'" /*����� � 1*/,
        "R U R' U' R' F R F'" /*����� � 2*/,
        "R U2' R2' F R F' U2' R' F R F'" /*������ 1*/,
        "Rw' U' Rw U2' R' U2' R U2' Rw' U Rw" /*������ 2*/,
        "R U R' U R' F R F' U2' R' F R F'" /*���������*/,
        "Rw' R2 U R' U Rw U2' Rw' U R' Rw" /*���� 1*/,
        "Rw' R U' Rw U2 Rw' U' R U' R2 Rw" /*���� 2*/,
        "R2 D R' U2' R D' R' U2' R'" /*���*/,
        "Rw' R U R U R' U' Rw R2 F R F'" /*̳� ���� 1*/,
        "Rw U R' U R U2 Rw2 U' R U' R' U2 Rw" /*̳� ���� 2*/,
        "R U2 R' U' R U R' U' R U' R'" /*������ ���*/,
        "F U R U' R' U R U' R' F'" /*������ 1*/,
        "R' F R U R U' R2 F' R2 U' R' U R U R'" /*������ 2*/,
        "Rw' U' Rw U' R' U R U' R' U R Rw' U Rw" /*������ 3*/,
        "y' R' F' U' F U' R U R' U R" /*������ 4*/,
        "F' Rw U R' U' Rw' F R " /*³������*/,
        "R U R' U' M'U R U' Rw'" /*����� �*/,
        "Rw U Rw' R U R' U' Rw U'" /*����� � 1*/,
        "y2 F U R U' R2 F' R U R U' R'" /*����� � 2*/,
        "y2 Rw' U' Rw R' U' R U Rw' U Rw" /*����� � 3*/,
        "Rw' U Rw U Rw' U' Rw B U' B'" /*����� � 4*/,
        "Rw U2 R' U' R U' Rw'" /*������� 1*/,
        "y2 Rw' U2 R U R' U Rw" /*������� 2*/,
        "y2 R U2' R2 F R F' R U2' R'" /*�������� 1*/,
        "F R U' R' U' R U R' F'" /*�������� 2*/,
        "R U R' U R U' R'U' R' F R F'" /*����� � 1*/,
        "L' U' L U' L'U L U Rw U' Rw' F" /*����� M 2*/,
        "R U R' U' R' F R2 U R' U' F" /*����� 1*/,
        "y2 R U R' U R' F R F' R U2' R'" /*����� 2*/,
        "Rw U R'U R U2 Rw'" /*��������� 1*/,
        "R U2 R' U2 R'F R F'" /*��������� 2*/,
        "y R' U' F' U F R" /*�'���� ���� 1 */,
        "y2 R'U' F U R U' R' F' R" /*�'���� ���� 2*/,
        "y2 F U R U' R' F'" /*�'���� ���� 3*/,
        "R U B' U' R' U R B R'" /*�'���� ���� 4*/,
        "y2 R U R' U R U2 R' F R U R' U' F'" /*ϳ���� 1*/,
        "y2 F R' F R2 U' R' U' R U R' F2" /*ϳ���� 2*/,
        "R' U' R U'R' U2 R F R U R' U' F'" /*ϳ���� 3*/,
        "y R U R' U' R U' R' F' U' F R U R'" /*ϳ���� 4*/,
        "F R U R' U' R U R' U' F'" /*ϳ� �������� 1 */,
        "Rw U' Rw2 U Rw2 U Rw2 U' Rw" /*ϳ� �������� 2*/,
        "y Rw' U Rw2 U' Rw2 U' Rw2 U Rw'" /*ϳ� �������� 3*/,
        "F' L' U' L U L' U'L U F" /*ϳ� �������� 4*/
    };
}