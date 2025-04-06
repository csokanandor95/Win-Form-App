namespace Win_Form_App
{
    public partial class Form1 : Form
    {
        public Form1() //konstruktor
        {
            InitializeComponent(); //lefutnak a fõ kódfájlból ez ehhez tartozó komponensek
            //tehetek hozzá a konstruktorba mást is, de fontos h az InitializeC. után jöjjön
            checkBox1.CheckedChanged += CheckBoxes_CheckedChanged;
            checkBox2.CheckedChanged += CheckBoxes_CheckedChanged;
            checkBox3.CheckedChanged += CheckBoxes_CheckedChanged;
            checkBox4.CheckedChanged += CheckBoxes_CheckedChanged;
            checkBox5.CheckedChanged += CheckBoxes_CheckedChanged;

            Assay.SelectedIndexChanged += Assay_SelectedIndexChanged;

            button1.Enabled = false;
            button2.Enabled = true;

            UpdateButtons(); //kezdeti állapot beállítása
        }

        private void Assay_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;

            UpdateButtons();
        }

        private void button1_Click(object sender, EventArgs e) //eseménykezelõ metódus
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
