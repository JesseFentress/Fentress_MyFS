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
    }
}