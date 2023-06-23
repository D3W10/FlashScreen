namespace FlashScreen
{
    public partial class Flash : Form
    {
        public Flash()
        {
            InitializeComponent();

            BackColor = Program.Color1;
            WindowState = FormWindowState.Maximized;
        }

        private void Flash_Click(object sender, EventArgs e)
        {
            ColorSwitch();
        }

        private void Flash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                Close();
            else
                ColorSwitch();
        }

        private void ColorSwitch()
        {
            if (BackColor == Program.Color1)
                BackColor = Program.Color2;
            else
                BackColor = Program.Color1;
        }
    }
}