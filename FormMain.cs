namespace eProdavnica
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            UserControl1 userControl = new UserControl1();
            userControl.Dock = DockStyle.Fill;
            userControl.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            tableLayoutPanel1.Controls.Add(userControl, 1, 0); // Assuming the second column is at index 1


        }
    }
}