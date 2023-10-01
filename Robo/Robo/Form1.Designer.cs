namespace Robo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            panel2 = new Panel();
            pnlLogin = new Panel();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            panel7 = new Panel();
            panel8 = new Panel();
            label4 = new Label();
            panel9 = new Panel();
            panel10 = new Panel();
            textBox2 = new TextBox();
            pictureBox2 = new PictureBox();
            panel5 = new Panel();
            panel6 = new Panel();
            label3 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            textBox1 = new TextBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pnlLogin.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(17, 53, 71);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1042, 51);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(17, 53, 71);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(322, 501);
            panel2.TabIndex = 1;
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.FromArgb(30, 30, 30);
            pnlLogin.Controls.Add(linkLabel2);
            pnlLogin.Controls.Add(linkLabel1);
            pnlLogin.Controls.Add(button1);
            pnlLogin.Controls.Add(panel7);
            pnlLogin.Controls.Add(pictureBox2);
            pnlLogin.Controls.Add(panel5);
            pnlLogin.Controls.Add(label5);
            pnlLogin.Controls.Add(pictureBox1);
            pnlLogin.Controls.Add(label1);
            pnlLogin.Controls.Add(label2);
            pnlLogin.Dock = DockStyle.Fill;
            pnlLogin.Location = new Point(322, 51);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(720, 501);
            pnlLogin.TabIndex = 2;
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.Red;
            linkLabel2.Anchor = AnchorStyles.None;
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel2.LinkColor = Color.White;
            linkLabel2.Location = new Point(377, 446);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(116, 13);
            linkLabel2.TabIndex = 10;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Criar uma nova conta";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Red;
            linkLabel1.Anchor = AnchorStyles.None;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(386, 340);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(99, 13);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Esqueceu a senha";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.FlatAppearance.BorderColor = Color.GreenYellow;
            button1.FlatAppearance.MouseOverBackColor = Color.Lime;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Lime;
            button1.Location = new Point(319, 383);
            button1.Name = "button1";
            button1.Size = new Size(232, 47);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.None;
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(panel9);
            panel7.Location = new Point(224, 241);
            panel7.Name = "panel7";
            panel7.Size = new Size(385, 84);
            panel7.TabIndex = 8;
            // 
            // panel8
            // 
            panel8.Controls.Add(label4);
            panel8.Location = new Point(0, 40);
            panel8.Name = "panel8";
            panel8.Size = new Size(385, 25);
            panel8.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(96, 19);
            label4.TabIndex = 5;
            label4.Text = "Senha inválida";
            // 
            // panel9
            // 
            panel9.Controls.Add(panel10);
            panel9.Controls.Add(textBox2);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(385, 42);
            panel9.TabIndex = 3;
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.ForeColor = SystemColors.ControlLightLight;
            panel10.Location = new Point(15, 33);
            panel10.Name = "panel10";
            panel10.Size = new Size(339, 1);
            panel10.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(30, 30, 30);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = SystemColors.GrayText;
            textBox2.Location = new Point(15, 13);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(339, 18);
            textBox2.TabIndex = 2;
            textBox2.Text = "Entrar senha";
            textBox2.Click += textBox2_Click;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(78, 241);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(panel3);
            panel5.Location = new Point(224, 120);
            panel5.Name = "panel5";
            panel5.Size = new Size(395, 95);
            panel5.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.None;
            panel6.Controls.Add(label3);
            panel6.Location = new Point(0, 47);
            panel6.Name = "panel6";
            panel6.Size = new Size(395, 45);
            panel6.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(15, 9);
            label3.Name = "label3";
            label3.Size = new Size(165, 19);
            label3.TabIndex = 5;
            label3.Text = "Nome de usuario inválido";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(textBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(395, 44);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.ForeColor = SystemColors.ControlLightLight;
            panel4.Location = new Point(15, 33);
            panel4.Name = "panel4";
            panel4.Size = new Size(339, 1);
            panel4.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(30, 30, 30);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.GrayText;
            textBox1.Location = new Point(15, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(339, 18);
            textBox1.TabIndex = 2;
            textBox1.Text = "Entrar usuario";
            textBox1.Click += textBox1_Click;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(128, 253);
            label5.Name = "label5";
            label5.Size = new Size(67, 19);
            label5.TabIndex = 6;
            label5.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(78, 153);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(360, 24);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(128, 165);
            label2.Name = "label2";
            label2.Size = new Size(77, 19);
            label2.TabIndex = 1;
            label2.Text = "User Name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1042, 552);
            Controls.Add(pnlLogin);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel pnlLogin;
        private Label label1;
        private Label label2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Label label3;
        private Panel panel7;
        private Panel panel8;
        private Label label4;
        private Panel panel9;
        private Panel panel10;
        private TextBox textBox2;
        private PictureBox pictureBox2;
        private Label label5;
        private Button button1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
    }
}