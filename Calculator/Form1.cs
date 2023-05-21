using System.Data;
using System.Linq.Expressions;
using System.Runtime.Serialization;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private string expression;
        public Form1()
        {
            expression = "0";
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void expression_press(object sender, MouseEventArgs e)
        {
            if (textbox.Text == "0")
            {
                textbox.Clear();
            }
            Button button = (Button)sender;
            textbox.Text += button.Text;
            expression = textbox.Text;
        }

        private void operator_press(object sender, MouseEventArgs e)
        {
            if (textbox.Text == "0")
            {
                textbox.Clear();
                Button button = (Button)sender;
                textbox.Text += button.Text;
                expression = textbox.Text;
            }

            if (textbox.Text.ToString().Last() != '+' && textbox.Text.ToString().Last() != '-'
                && textbox.Text.ToString().Last() != '*' && textbox.Text.ToString().Last() != '/'
                && textbox.Text.ToString().Last() != '.')
            {
                Button button = (Button)sender;
                textbox.Text += button.Text;
                expression = textbox.Text;
            }
        }

        private void function_press(object sender, MouseEventArgs e)
        {
            if (textbox.Text != "0")
            {
                textbox.Text = "0";
                expression = textbox.Text;
            }
        }

        private void result_press(object sender, MouseEventArgs e)
        {
            if (textbox.Text.ToString().Last() != '+' && textbox.Text.ToString().Last() != '-'
                && textbox.Text.ToString().Last() != '*' && textbox.Text.ToString().Last() != '/'
                && textbox.Text.ToString().Last() != '.')
            {
                DataTable dt = new DataTable();
                try
                {
                    var result = dt.Compute(expression, "");
                    textbox.Text = Convert.ToString(result);
                    expression = textbox.Text;
                }
                catch (SyntaxErrorException)
                {
                    expression = textbox.Text;
                }
            }
        }
    }
}