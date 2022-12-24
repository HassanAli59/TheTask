namespace mision
{
    public partial class Form1 : Form
    {
        double resultvalue=0;
        string operationperformed = "";
        bool isoprationperformed=false;

        public Form1()
        { 
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || isoprationperformed)
                textBox_Result.Clear();
            isoprationperformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox_Result.Text.Contains("."))
                    textBox_Result.Text = textBox_Result.Text + button.Text;
            }
            else
            textBox_Result.Text = textBox_Result.Text + button.Text;

        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button=(Button)sender;
            if (resultvalue != 0)
            {
                button19.PerformClick();
                operationperformed = button.Text;
                labelcurrentoperation.Text = resultvalue + " " + operationperformed;
                isoprationperformed = true;
            }
            else
            {
                operationperformed = button.Text;
                resultvalue = double.Parse(textBox_Result.Text);
                labelcurrentoperation.Text = resultvalue + " " + operationperformed;
                isoprationperformed = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultvalue = 0;

        }

        private void button19_Click(object sender, EventArgs e)
        {
            switch (operationperformed)
            {
                case "+":
                    textBox_Result.Text = (resultvalue + Double.Parse(textBox_Result.Text)).ToString();
                    break;
                    
                case "-":
                    textBox_Result.Text = (resultvalue - Double.Parse(textBox_Result.Text)).ToString();
                    break;
                    
                case "x":
                    textBox_Result.Text = (resultvalue * Double.Parse(textBox_Result.Text)).ToString();
                    break; 
                
                case "÷":
                    textBox_Result.Text = (resultvalue / Double.Parse(textBox_Result.Text)).ToString();
                    break;
                default:
                    break;

            }
            resultvalue = Double.Parse(textBox_Result.Text);
            labelcurrentoperation.Text = "";
        }
    }
}