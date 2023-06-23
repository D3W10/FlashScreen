namespace FlashScreen
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            RefreshPanelColors();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Program.Continue = true;
            Close();
        }

        private void btnChoose1_Click(object sender, EventArgs e)
        {
            if (cdColors.ShowDialog() == DialogResult.OK)
            {
                Program.Color1 = cdColors.Color;
                RefreshPanelColors();
            }
        }

        private void btnChoose2_Click(object sender, EventArgs e)
        {
            if (cdColors.ShowDialog() == DialogResult.OK)
            {
                Program.Color2 = cdColors.Color;
                RefreshPanelColors();
            }
        }

        private void RefreshPanelColors()
        {
            pColor1.BackColor = Program.Color1;
            pColor2.BackColor = Program.Color2;
        }
    }
}