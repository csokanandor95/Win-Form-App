namespace Win_Form_App
{
    public partial class Form1 : Form
    {
        public Form1() //konstruktor
        {
            InitializeComponent(); //lefutnak a f� k�df�jlb�l ez ehhez tartoz� komponensek
            //tehetek hozz� a konstruktorba m�st is, de fontos h az InitializeC. ut�n j�jj�n
        }

        private void button1_Click(object sender, EventArgs e) //esem�nykezel� met�dus
        {
            Result.Text = "QC Approved";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Result.Text = "QC Rejected";
        }
    }
}
