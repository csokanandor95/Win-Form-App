using System.CodeDom.Compiler;

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

            Assay.SelectedIndexChanged += Assay_SelectedIndexChanged;

            button1.Enabled = false;
            button2.Enabled = true;

            UpdateButtons(); //kezdeti �llapot be�ll�t�sa
            AssayInitialize(); //kezdeti sz�veg megad�sa
        }

        private void Assay_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool validSelection = Assay.SelectedIndex > 0;

            //akkor valid a checkbox ha t�nyleges assay-t v�lasztottunk

            checkBox1.Enabled = validSelection;
            checkBox2.Enabled = validSelection;
            checkBox3.Enabled = validSelection;
            checkBox4.Enabled = validSelection;
            checkBox5.Enabled = validSelection;

            //checkbox �rt�kek t�rl�se (ha el�z�leg be volt pip�lva)
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;

            UpdateButtons();
            ResultChangedEmpty();
        }

        private void button1_Click(object sender, EventArgs e) //esem�nykezel� met�dus
        {
            Result.Text = "QC Approved";
            Result.BackColor = Color.LightGreen; // approved
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Result.Text = "QC Rejected";
            Result.BackColor = Color.LightCoral; // rejected
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

        private void ResultChangedEmpty()
        {
            Result.Text = "Under QC";
        }

        private void AssayInitialize()
        {
            Assay.SelectedText = "Select an assay type!";
            Assay.SelectedIndex = 0;

            //kezdetben legyen mindegyik checkbox inak�tv

            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;
        }
    }
}
