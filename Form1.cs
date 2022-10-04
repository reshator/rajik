namespace sred
{
    public partial class Form1 : Form
    {
        int round = 2;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            try
            {
                double five = Convert.ToInt32(fivesBox.Text);
                double four = Convert.ToInt32(foursBox.Text);
                double three = Convert.ToInt32(threesBox.Text);
                double two = Convert.ToInt32(twosBox.Text);
                var sum = five + four + three + two;
                var sum1 = five * 5 + four * 4 + three * 3 + two * 2;
                var average = Math.Round(sum1 / sum, round);


                MessageBox.Show($"Средний балл в классе {average}", "", MessageBoxButtons.OK);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка ввода (поля должны быть не пустыми)", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
          

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            round = Convert.ToInt32(comboBox1.Text);
        }
    }
}