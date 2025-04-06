namespace Win_Form_App
{
    public partial class Form1 : Form
    {
        public Form1() //konstruktor
        {
            InitializeComponent(); //lefutnak a f� k�df�jlb�l ez ehhez tartoz� komponensek
            //tehetek hozz� a konstruktorba m�st is, de fontos h az InitializeC. ut�n j�jj�n
            checkBox1.CheckedChanged += CheckBoxes_CheckedChanged;
            checkBox2.CheckedChanged += CheckBoxes_CheckedChanged;
            checkBox3.CheckedChanged += CheckBoxes_CheckedChanged;
            checkBox4.CheckedChanged += CheckBoxes_CheckedChanged;
            checkBox5.CheckedChanged += CheckBoxes_CheckedChanged;

            button1.Enabled = false;
            button2.Enabled = true;

            UpdateButtons(); //kezdeti �llapot be�ll�t�sa
        }

        private void button1_Click(object sender, EventArgs e) //esem�nykezel� met�dus
        {
            Result.Text = "QC Approved";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Result.Text = "QC Rejected";
        }

        private void CheckBoxes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateButtons();
        }

        private void UpdateButtons()
        {
            bool allChecked = checkBox1.Checked &&
                              checkBox2.Checked &&
                              checkBox3.Checked &&
                              checkBox4.Checked &&
                              checkBox5.Checked;

            button1.Enabled = allChecked;
            button2.Enabled = !allChecked;
        }


    }
}
