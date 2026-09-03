namespace GettingStartedLibWebWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            
            string returnString;

            returnString = client.GetData(textBox1.Text) + "   " + client.GetText(textBox2.Text);

            label1.Text = returnString;
        }
    }
}
