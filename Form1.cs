namespace Win_Form_App
{
    public partial class Form1 : Form
    {
        public Form1() //konstruktor
        {
            InitializeComponent(); //lefutnak a fõ kódfájlból ez ehhez tartozó komponensek
            //tehetek hozzá a konstruktorba mást is, de fontos h az InitializeC. után jöjjön
        }

        private void button1_Click(object sender, EventArgs e) //eseménykezelõ metódus
        {
            Result.Text = "QC Approved";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Result.Text = "QC Rejected";
        }
    }
}
