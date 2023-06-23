namespace FlashScreen
{
    partial class Start
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            cdColors = new ColorDialog();
            lblColor1 = new Label();
            lblColor2 = new Label();
            lblTitle = new Label();
            pColor1 = new Panel();
            pColor2 = new Panel();
            btnChoose1 = new Button();
            btnChoose2 = new Button();
            btnOpen = new Button();
            SuspendLayout();
            // 
            // cdColors
            // 
            cdColors.AnyColor = true;
            cdColors.Color = Color.White;
            cdColors.FullOpen = true;
            cdColors.SolidColorOnly = true;
            // 
            // lblColor1
            // 
            lblColor1.AutoSize = true;
            lblColor1.Location = new Point(21, 66);
            lblColor1.Name = "lblColor1";
            lblColor1.Size = new Size(48, 15);
            lblColor1.TabIndex = 0;
            lblColor1.Text = "Color 1:";
            // 
            // lblColor2
            // 
            lblColor2.AutoSize = true;
            lblColor2.Location = new Point(21, 126);
            lblColor2.Name = "lblColor2";
            lblColor2.Size = new Size(48, 15);
            lblColor2.TabIndex = 0;
            lblColor2.Text = "Color 2:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(7, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(186, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Flash Screen";
            // 
            // pColor1
            // 
            pColor1.Location = new Point(85, 66);
            pColor1.Name = "pColor1";
            pColor1.Size = new Size(40, 40);
            pColor1.TabIndex = 0;
            // 
            // pColor2
            // 
            pColor2.Location = new Point(85, 126);
            pColor2.Name = "pColor2";
            pColor2.Size = new Size(40, 40);
            pColor2.TabIndex = 0;
            // 
            // btnChoose1
            // 
            btnChoose1.Location = new Point(143, 74);
            btnChoose1.Name = "btnChoose1";
            btnChoose1.Size = new Size(75, 23);
            btnChoose1.TabIndex = 0;
            btnChoose1.Text = "Choose";
            btnChoose1.UseVisualStyleBackColor = true;
            btnChoose1.Click += btnChoose1_Click;
            // 
            // btnChoose2
            // 
            btnChoose2.Location = new Point(143, 134);
            btnChoose2.Name = "btnChoose2";
            btnChoose2.Size = new Size(75, 23);
            btnChoose2.TabIndex = 1;
            btnChoose2.Text = "Choose";
            btnChoose2.UseVisualStyleBackColor = true;
            btnChoose2.Click += btnChoose2_Click;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(64, 192);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(113, 23);
            btnOpen.TabIndex = 2;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(239, 231);
            Controls.Add(btnOpen);
            Controls.Add(btnChoose2);
            Controls.Add(btnChoose1);
            Controls.Add(pColor2);
            Controls.Add(pColor1);
            Controls.Add(lblTitle);
            Controls.Add(lblColor2);
            Controls.Add(lblColor1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Start";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FlashScreen";
            Load += Start_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ColorDialog cdColors;
        private Label lblColor1;
        private Label lblColor2;
        private Label lblTitle;
        private Panel pColor1;
        private Panel pColor2;
        private Button btnChoose1;
        private Button btnChoose2;
        private Button btnOpen;
    }
}