namespace WinFormsApp11
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonClick_Click(object sender, EventArgs e)
        {
            labelCount.Text = "Clicked";
            labelCount.Text = textBoxPlus.Text;
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBoxPlus.Text))
            {
                count++;  
            }
            
            else
            {
                int plusAmount = Convert.ToInt32(textBoxPlus.Text);
                textBoxPlus.Text = "";
                count = count + plusAmount;
                labelCount.Text = count.ToString();
            }
            
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            
           
            if (count >= 0)
            {


                if (String.IsNullOrEmpty(textBoxMinus.Text))
                {
                    count--;
                    labelCount.Text = count.ToString();

                    if (count == -1)
                    {
                        count = 0;
                        labelCount.Text = "0";
                    }
                }

                else
                {               
                    int minusAmount = Convert.ToInt32(textBoxMinus.Text);
                        int newCount = count - minusAmount;

                     if (newCount >= 0)
                     {
                            count = newCount;
                            labelCount.Text = count.ToString();
                     }
                     else
                    {
                        MessageBox.Show("Count deðeri sýfýrdan küçük olamaz", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }
                
            }
            
        }

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{
            
        //}
    }
}