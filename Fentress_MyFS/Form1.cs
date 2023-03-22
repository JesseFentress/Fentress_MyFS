namespace Fentress_MyFS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = !btnAdd.Enabled;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtFileName_TextChanged(object sender, EventArgs e)
        {
            CheckAddEnable();
        }

        private void txtFileSize_TextChanged(object sender, EventArgs e)
        {
            CheckAddEnable();
        }

        private void CheckAddEnable()
        {
            if ((txtFileName.TextLength > 0) && (txtFileSize.TextLength > 0))
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string fileInfo;
            char hiddenChar = 'h';
            char readOnlyChar = 'r';

            if (chckHidden.Checked == true)
            {
                hiddenChar = 'H';
            }

            if (chckReadOnly.Checked == true)
            {
                readOnlyChar = 'R';
            }

            fileInfo = txtFileName.Text + ", " + txtFileSize.Text + ", " + hiddenChar + ", " + readOnlyChar;

            lstSectors.Items.Add(fileInfo);
        }
    }
}