namespace RandomPasswordGenerator
{
    public partial class Form1 : Form
    {
        int currentPasswordLength = 0;
        Random character = new Random();

        private void passwordGenerator(int length)
        {
            string allcharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890!@#$%";
            string randomPassowrd = "";

            for (int i = 0; i < length; i++)
            {
                int randoumNum = character.Next(0, allcharacters.Length);
                randomPassowrd += allcharacters[randoumNum];
            }
            label1.Text = randomPassowrd;
            
        }

        public Form1()
        {           
            InitializeComponent();
            trackBar1.Minimum = 5;
            trackBar1.Maximum = 20;
            passwordGenerator(5);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = "Password Length: " + trackBar1.Value.ToString();
            currentPasswordLength = trackBar1.Value;
            passwordGenerator(currentPasswordLength);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label1.Text);
        }
    }
}