namespace WinFormsApp2
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
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            CreditsBtn = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            AddProfilePnl = new Panel();
            pictureBox1 = new PictureBox();
            CLosed_Btn = new Button();
            Minimize_Btn = new Button();
            Admin_LoginBtn = new Button();
            FocusPanel = new Panel();
            FocusPnl_ClosedBtn = new Button();
            linkLabel1 = new LinkLabel();
            label6 = new Label();
            checkBox2 = new CheckBox();
            label7 = new Label();
            panel1 = new Panel();
            FocusTblPnl = new TableLayoutPanel();
            panel2 = new Panel();
            button1 = new Button();
            linkLabel2 = new LinkLabel();
            FocusPnlPicbox = new PictureBox();
            UsernameTxtBox_LoginPnl = new TextBox();
            label2 = new Label();
            checkBox1 = new CheckBox();
            PasswordTxtbox_LoginPnl = new TextBox();
            label3 = new Label();
            panel3 = new Panel();
            FocusPnlLabel = new Label();
            label4 = new Label();
            AdminLoginBtn = new Button();
            LoginPnl_Button = new Button();
            profilePanel = new Panel();
            TeachersNameLbl = new Label();
            validation_ChckBox = new CheckBox();
            label5 = new Label();
            TeacherNametxtBox = new TextBox();
            checkBox3 = new CheckBox();
            label8 = new Label();
            button2 = new Button();
            avatar2_Btn = new Button();
            Avatar_Picbox = new PictureBox();
            avatar1_Btn = new Button();
            PasswordLbl = new Label();
            UsernameLbl = new Label();
            PasswordTxtbox = new TextBox();
            UsernameTxtBox = new TextBox();
            SubmitBtn = new Button();
            Update_Btn = new Button();
            Login_Pnl = new Panel();
            button3 = new Button();
            Username_Lbl = new Label();
            Login_Btn = new Button();
            label9 = new Label();
            Passwrod_txtBox = new TextBox();
            label10 = new Label();
            Admin_LogoutBtn = new Button();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            AddProfilePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            FocusPanel.SuspendLayout();
            FocusTblPnl.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FocusPnlPicbox).BeginInit();
            panel3.SuspendLayout();
            profilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Avatar_Picbox).BeginInit();
            Login_Pnl.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Calibri", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 16);
            label1.Name = "label1";
            label1.Size = new Size(1347, 78);
            label1.TabIndex = 3;
            label1.Text = "Mellowdy";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.None;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(CreditsBtn, 0, 2);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Location = new Point(21, 53);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.12367F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 83.87634F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.Size = new Size(1353, 723);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // CreditsBtn
            // 
            CreditsBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CreditsBtn.Location = new Point(3, 697);
            CreditsBtn.Name = "CreditsBtn";
            CreditsBtn.Size = new Size(29, 23);
            CreditsBtn.TabIndex = 15;
            CreditsBtn.Text = "?";
            CreditsBtn.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.None;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(AddProfilePnl);
            flowLayoutPanel1.Location = new Point(132, 141);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1088, 521);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // AddProfilePnl
            // 
            AddProfilePnl.BackgroundImage = Properties.Resources.gb_bgg;
            AddProfilePnl.BackgroundImageLayout = ImageLayout.Stretch;
            AddProfilePnl.Controls.Add(pictureBox1);
            AddProfilePnl.Location = new Point(3, 3);
            AddProfilePnl.Name = "AddProfilePnl";
            AddProfilePnl.Size = new Size(136, 200);
            AddProfilePnl.TabIndex = 4;
            AddProfilePnl.Click += AddProfilePnl_Click;
            AddProfilePnl.Paint += AddProfilePnl_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // CLosed_Btn
            // 
            CLosed_Btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CLosed_Btn.BackColor = Color.Transparent;
            CLosed_Btn.FlatStyle = FlatStyle.Popup;
            CLosed_Btn.Location = new Point(1345, 12);
            CLosed_Btn.Name = "CLosed_Btn";
            CLosed_Btn.Size = new Size(29, 23);
            CLosed_Btn.TabIndex = 14;
            CLosed_Btn.Text = "X";
            CLosed_Btn.UseVisualStyleBackColor = false;
            CLosed_Btn.Click += CLosed_Btn_Click;
            // 
            // Minimize_Btn
            // 
            Minimize_Btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Minimize_Btn.BackColor = Color.Transparent;
            Minimize_Btn.FlatStyle = FlatStyle.Popup;
            Minimize_Btn.Location = new Point(1313, 12);
            Minimize_Btn.Name = "Minimize_Btn";
            Minimize_Btn.Size = new Size(29, 23);
            Minimize_Btn.TabIndex = 13;
            Minimize_Btn.Text = "_";
            Minimize_Btn.UseVisualStyleBackColor = false;
            Minimize_Btn.Click += Minimize_Btn_Click;
            // 
            // Admin_LoginBtn
            // 
            Admin_LoginBtn.FlatStyle = FlatStyle.Popup;
            Admin_LoginBtn.Location = new Point(21, 8);
            Admin_LoginBtn.Name = "Admin_LoginBtn";
            Admin_LoginBtn.Size = new Size(75, 23);
            Admin_LoginBtn.TabIndex = 12;
            Admin_LoginBtn.Text = "Admin";
            Admin_LoginBtn.UseVisualStyleBackColor = true;
            Admin_LoginBtn.Click += Admin_LoginBtn_Click;
            // 
            // FocusPanel
            // 
            FocusPanel.Anchor = AnchorStyles.None;
            FocusPanel.BackColor = Color.Transparent;
            FocusPanel.BackgroundImageLayout = ImageLayout.Stretch;
            FocusPanel.Controls.Add(FocusPnl_ClosedBtn);
            FocusPanel.Controls.Add(linkLabel1);
            FocusPanel.Controls.Add(label6);
            FocusPanel.Controls.Add(checkBox2);
            FocusPanel.Controls.Add(label7);
            FocusPanel.Controls.Add(panel1);
            FocusPanel.Location = new Point(53, 3);
            FocusPanel.Name = "FocusPanel";
            FocusPanel.Size = new Size(94, 485);
            FocusPanel.TabIndex = 0;
            // 
            // FocusPnl_ClosedBtn
            // 
            FocusPnl_ClosedBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FocusPnl_ClosedBtn.Location = new Point(205, 0);
            FocusPnl_ClosedBtn.Name = "FocusPnl_ClosedBtn";
            FocusPnl_ClosedBtn.Size = new Size(29, 23);
            FocusPnl_ClosedBtn.TabIndex = 12;
            FocusPnl_ClosedBtn.Text = "X";
            FocusPnl_ClosedBtn.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.White;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(109, 349);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(94, 15);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forget Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(101, 249);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 3;
            label6.Text = "Username";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = Color.Transparent;
            checkBox2.Location = new Point(207, 325);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(55, 19);
            checkBox2.TabIndex = 10;
            checkBox2.Text = "Show";
            checkBox2.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(101, 307);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 5;
            label7.Text = "Password";
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 13;
            // 
            // FocusTblPnl
            // 
            FocusTblPnl.Anchor = AnchorStyles.None;
            FocusTblPnl.BackColor = Color.Transparent;
            FocusTblPnl.ColumnCount = 3;
            FocusTblPnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0919113F));
            FocusTblPnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.90809F));
            FocusTblPnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            FocusTblPnl.Controls.Add(panel2, 1, 0);
            FocusTblPnl.Location = new Point(149, 84);
            FocusTblPnl.Name = "FocusTblPnl";
            FocusTblPnl.RowCount = 1;
            FocusTblPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            FocusTblPnl.Size = new Size(1088, 578);
            FocusTblPnl.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.usr_gb_bgg21;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(linkLabel2);
            panel2.Controls.Add(FocusPnlPicbox);
            panel2.Controls.Add(UsernameTxtBox_LoginPnl);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(PasswordTxtbox_LoginPnl);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(AdminLoginBtn);
            panel2.Controls.Add(LoginPnl_Button);
            panel2.Location = new Point(374, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(340, 485);
            panel2.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.Close_Btn;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(291, 3);
            button1.Name = "button1";
            button1.Size = new Size(46, 44);
            button1.TabIndex = 19;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.White;
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.Transparent;
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(109, 349);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(94, 15);
            linkLabel2.TabIndex = 11;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Forget Password";
            // 
            // FocusPnlPicbox
            // 
            FocusPnlPicbox.BackgroundImageLayout = ImageLayout.Stretch;
            FocusPnlPicbox.Location = new Point(110, 67);
            FocusPnlPicbox.Name = "FocusPnlPicbox";
            FocusPnlPicbox.Size = new Size(98, 100);
            FocusPnlPicbox.SizeMode = PictureBoxSizeMode.StretchImage;
            FocusPnlPicbox.TabIndex = 1;
            FocusPnlPicbox.TabStop = false;
            // 
            // UsernameTxtBox_LoginPnl
            // 
            UsernameTxtBox_LoginPnl.Location = new Point(110, 267);
            UsernameTxtBox_LoginPnl.Name = "UsernameTxtBox_LoginPnl";
            UsernameTxtBox_LoginPnl.Size = new Size(91, 23);
            UsernameTxtBox_LoginPnl.TabIndex = 2;
            UsernameTxtBox_LoginPnl.KeyDown += UsernameTxtBox_LoginPnl_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(101, 249);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Location = new Point(207, 325);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(55, 19);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Show";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // PasswordTxtbox_LoginPnl
            // 
            PasswordTxtbox_LoginPnl.Location = new Point(110, 323);
            PasswordTxtbox_LoginPnl.Name = "PasswordTxtbox_LoginPnl";
            PasswordTxtbox_LoginPnl.Size = new Size(91, 23);
            PasswordTxtbox_LoginPnl.TabIndex = 3;
            PasswordTxtbox_LoginPnl.UseSystemPasswordChar = true;
            PasswordTxtbox_LoginPnl.TextChanged += PasswordTxtbox_LoginPnl_TextChanged;
            PasswordTxtbox_LoginPnl.KeyDown += PasswordTxtbox_LoginPnl_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(101, 307);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(FocusPnlLabel);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(0, 180);
            panel3.Name = "panel3";
            panel3.Size = new Size(340, 25);
            panel3.TabIndex = 14;
            // 
            // FocusPnlLabel
            // 
            FocusPnlLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            FocusPnlLabel.AutoSize = true;
            FocusPnlLabel.BackColor = Color.Transparent;
            FocusPnlLabel.Location = new Point(145, 4);
            FocusPnlLabel.Name = "FocusPnlLabel";
            FocusPnlLabel.Size = new Size(16, 15);
            FocusPnlLabel.TabIndex = 1;
            FocusPnlLabel.Text = "...";
            FocusPnlLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(145, -33);
            label4.Name = "label4";
            label4.Size = new Size(16, 15);
            label4.TabIndex = 0;
            label4.Text = "...";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AdminLoginBtn
            // 
            AdminLoginBtn.Location = new Point(121, 415);
            AdminLoginBtn.Name = "AdminLoginBtn";
            AdminLoginBtn.Size = new Size(66, 23);
            AdminLoginBtn.TabIndex = 13;
            AdminLoginBtn.Text = "Login";
            AdminLoginBtn.UseVisualStyleBackColor = true;
            AdminLoginBtn.Click += AdminLoginBtn_Click;
            // 
            // LoginPnl_Button
            // 
            LoginPnl_Button.Location = new Point(121, 415);
            LoginPnl_Button.Name = "LoginPnl_Button";
            LoginPnl_Button.Size = new Size(66, 23);
            LoginPnl_Button.TabIndex = 4;
            LoginPnl_Button.Text = "Login";
            LoginPnl_Button.UseVisualStyleBackColor = true;
            LoginPnl_Button.Click += LoginPnl_Button_Click;
            // 
            // profilePanel
            // 
            profilePanel.Anchor = AnchorStyles.None;
            profilePanel.BackColor = Color.Transparent;
            profilePanel.BorderStyle = BorderStyle.FixedSingle;
            profilePanel.Controls.Add(TeachersNameLbl);
            profilePanel.Controls.Add(validation_ChckBox);
            profilePanel.Controls.Add(label5);
            profilePanel.Controls.Add(TeacherNametxtBox);
            profilePanel.Controls.Add(checkBox3);
            profilePanel.Controls.Add(label8);
            profilePanel.Controls.Add(button2);
            profilePanel.Controls.Add(avatar2_Btn);
            profilePanel.Controls.Add(Avatar_Picbox);
            profilePanel.Controls.Add(avatar1_Btn);
            profilePanel.Controls.Add(PasswordLbl);
            profilePanel.Controls.Add(UsernameLbl);
            profilePanel.Controls.Add(PasswordTxtbox);
            profilePanel.Controls.Add(UsernameTxtBox);
            profilePanel.Controls.Add(SubmitBtn);
            profilePanel.Controls.Add(Update_Btn);
            profilePanel.Location = new Point(553, 165);
            profilePanel.Name = "profilePanel";
            profilePanel.Size = new Size(280, 459);
            profilePanel.TabIndex = 16;
            profilePanel.Visible = false;
            // 
            // TeachersNameLbl
            // 
            TeachersNameLbl.AutoSize = true;
            TeachersNameLbl.Location = new Point(103, 233);
            TeachersNameLbl.Name = "TeachersNameLbl";
            TeachersNameLbl.Size = new Size(38, 15);
            TeachersNameLbl.TabIndex = 12;
            TeachersNameLbl.Text = "label6";
            TeachersNameLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // validation_ChckBox
            // 
            validation_ChckBox.AutoSize = true;
            validation_ChckBox.Location = new Point(57, 409);
            validation_ChckBox.Name = "validation_ChckBox";
            validation_ChckBox.Size = new Size(196, 19);
            validation_ChckBox.TabIndex = 1;
            validation_ChckBox.Text = "I Herebly all the details is correct";
            validation_ChckBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(92, 212);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 12;
            label5.Text = "Teacher's name";
            // 
            // TeacherNametxtBox
            // 
            TeacherNametxtBox.Location = new Point(101, 230);
            TeacherNametxtBox.Name = "TeacherNametxtBox";
            TeacherNametxtBox.Size = new Size(91, 23);
            TeacherNametxtBox.TabIndex = 11;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(198, 326);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(55, 19);
            checkBox3.TabIndex = 10;
            checkBox3.Text = "Show";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(103, 113);
            label8.Name = "label8";
            label8.Size = new Size(84, 15);
            label8.TabIndex = 9;
            label8.Text = "Choose Avatar";
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(253, 3);
            button2.Name = "button2";
            button2.Size = new Size(22, 23);
            button2.TabIndex = 8;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // avatar2_Btn
            // 
            avatar2_Btn.BackgroundImage = Properties.Resources._750950;
            avatar2_Btn.BackgroundImageLayout = ImageLayout.Stretch;
            avatar2_Btn.Location = new Point(163, 134);
            avatar2_Btn.Name = "avatar2_Btn";
            avatar2_Btn.Size = new Size(38, 40);
            avatar2_Btn.TabIndex = 7;
            avatar2_Btn.UseVisualStyleBackColor = true;
            avatar2_Btn.Click += avatar2_Btn_Click;
            // 
            // Avatar_Picbox
            // 
            Avatar_Picbox.BackgroundImage = (Image)resources.GetObject("Avatar_Picbox.BackgroundImage");
            Avatar_Picbox.BackgroundImageLayout = ImageLayout.Zoom;
            Avatar_Picbox.Location = new Point(112, 33);
            Avatar_Picbox.Name = "Avatar_Picbox";
            Avatar_Picbox.Size = new Size(75, 77);
            Avatar_Picbox.SizeMode = PictureBoxSizeMode.StretchImage;
            Avatar_Picbox.TabIndex = 1;
            Avatar_Picbox.TabStop = false;
            // 
            // avatar1_Btn
            // 
            avatar1_Btn.BackgroundImage = Properties.Resources._147142;
            avatar1_Btn.BackgroundImageLayout = ImageLayout.Stretch;
            avatar1_Btn.Location = new Point(101, 134);
            avatar1_Btn.Name = "avatar1_Btn";
            avatar1_Btn.Size = new Size(39, 40);
            avatar1_Btn.TabIndex = 6;
            avatar1_Btn.UseVisualStyleBackColor = true;
            avatar1_Btn.Click += avatar1_Btn_Click;
            // 
            // PasswordLbl
            // 
            PasswordLbl.AutoSize = true;
            PasswordLbl.Location = new Point(92, 306);
            PasswordLbl.Name = "PasswordLbl";
            PasswordLbl.Size = new Size(57, 15);
            PasswordLbl.TabIndex = 5;
            PasswordLbl.Text = "Password";
            // 
            // UsernameLbl
            // 
            UsernameLbl.AutoSize = true;
            UsernameLbl.Location = new Point(92, 260);
            UsernameLbl.Name = "UsernameLbl";
            UsernameLbl.Size = new Size(60, 15);
            UsernameLbl.TabIndex = 3;
            UsernameLbl.Text = "Username";
            // 
            // PasswordTxtbox
            // 
            PasswordTxtbox.Location = new Point(101, 322);
            PasswordTxtbox.Name = "PasswordTxtbox";
            PasswordTxtbox.Size = new Size(91, 23);
            PasswordTxtbox.TabIndex = 3;
            PasswordTxtbox.UseSystemPasswordChar = true;
            // 
            // UsernameTxtBox
            // 
            UsernameTxtBox.Location = new Point(101, 278);
            UsernameTxtBox.Name = "UsernameTxtBox";
            UsernameTxtBox.Size = new Size(91, 23);
            UsernameTxtBox.TabIndex = 2;
            // 
            // SubmitBtn
            // 
            SubmitBtn.Location = new Point(112, 427);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(66, 23);
            SubmitBtn.TabIndex = 4;
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = true;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // Update_Btn
            // 
            Update_Btn.Location = new Point(112, 427);
            Update_Btn.Name = "Update_Btn";
            Update_Btn.Size = new Size(66, 23);
            Update_Btn.TabIndex = 4;
            Update_Btn.Text = "Update";
            Update_Btn.UseVisualStyleBackColor = true;
            Update_Btn.Click += Update_Btn_Click;
            // 
            // Login_Pnl
            // 
            Login_Pnl.Anchor = AnchorStyles.None;
            Login_Pnl.BackColor = Color.Transparent;
            Login_Pnl.Controls.Add(button3);
            Login_Pnl.Controls.Add(Username_Lbl);
            Login_Pnl.Controls.Add(Login_Btn);
            Login_Pnl.Controls.Add(label9);
            Login_Pnl.Controls.Add(Passwrod_txtBox);
            Login_Pnl.Controls.Add(label10);
            Login_Pnl.Location = new Point(383, 224);
            Login_Pnl.Name = "Login_Pnl";
            Login_Pnl.Size = new Size(620, 340);
            Login_Pnl.TabIndex = 17;
            // 
            // button3
            // 
            button3.Location = new Point(591, 0);
            button3.Name = "button3";
            button3.Size = new Size(29, 23);
            button3.TabIndex = 9;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = true;
            // 
            // Username_Lbl
            // 
            Username_Lbl.AutoSize = true;
            Username_Lbl.ImageAlign = ContentAlignment.MiddleLeft;
            Username_Lbl.Location = new Point(285, 111);
            Username_Lbl.Name = "Username_Lbl";
            Username_Lbl.Size = new Size(38, 15);
            Username_Lbl.TabIndex = 8;
            Username_Lbl.Text = "label5";
            // 
            // Login_Btn
            // 
            Login_Btn.Location = new Point(266, 181);
            Login_Btn.Name = "Login_Btn";
            Login_Btn.Size = new Size(75, 23);
            Login_Btn.TabIndex = 7;
            Login_Btn.Text = "Login";
            Login_Btn.TextAlign = ContentAlignment.BottomCenter;
            Login_Btn.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(177, 155);
            label9.Name = "label9";
            label9.Size = new Size(63, 15);
            label9.TabIndex = 6;
            label9.Text = "Password: ";
            // 
            // Passwrod_txtBox
            // 
            Passwrod_txtBox.Location = new Point(246, 152);
            Passwrod_txtBox.Name = "Passwrod_txtBox";
            Passwrod_txtBox.Size = new Size(119, 23);
            Passwrod_txtBox.TabIndex = 5;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(257, 17);
            label10.Name = "label10";
            label10.Size = new Size(99, 45);
            label10.TabIndex = 4;
            label10.Text = "Login";
            // 
            // Admin_LogoutBtn
            // 
            Admin_LogoutBtn.FlatStyle = FlatStyle.Popup;
            Admin_LogoutBtn.Location = new Point(21, 8);
            Admin_LogoutBtn.Name = "Admin_LogoutBtn";
            Admin_LogoutBtn.Size = new Size(75, 23);
            Admin_LogoutBtn.TabIndex = 18;
            Admin_LogoutBtn.Text = "Admin";
            Admin_LogoutBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 788);
            Controls.Add(CLosed_Btn);
            Controls.Add(Minimize_Btn);
            Controls.Add(Admin_LoginBtn);
            Controls.Add(Admin_LogoutBtn);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(profilePanel);
            Controls.Add(FocusTblPnl);
            Controls.Add(Login_Pnl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            AddProfilePnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            FocusPanel.ResumeLayout(false);
            FocusPanel.PerformLayout();
            FocusTblPnl.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FocusPnlPicbox).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            profilePanel.ResumeLayout(false);
            profilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Avatar_Picbox).EndInit();
            Login_Pnl.ResumeLayout(false);
            Login_Pnl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button CreditsBtn;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel AddProfilePnl;
        private PictureBox pictureBox1;
        private Button CLosed_Btn;
        private Button Minimize_Btn;
        private Button Admin_LoginBtn;

        private Panel FocusPanel;
        private Button FocusPnl_ClosedBtn;
        private LinkLabel linkLabel1;
        private Label label6;
        private CheckBox checkBox2;
        private Label label7;
        private Panel panel1;
        private TableLayoutPanel FocusTblPnl;
        private Panel panel2;
        private LinkLabel linkLabel2;
        private PictureBox FocusPnlPicbox;
        private TextBox UsernameTxtBox_LoginPnl;
        private Label label2;
        private CheckBox checkBox1;
        private TextBox PasswordTxtbox_LoginPnl;
        private Label label3;
        private Button LoginPnl_Button;
        private Button AdminLoginBtn;
        private Panel panel3;
        private Label label4;
        private Label FocusPnlLabel;
        private Panel profilePanel;
        private Label TeachersNameLbl;
        private CheckBox validation_ChckBox;
        private Label label5;
        private TextBox TeacherNametxtBox;
        private CheckBox checkBox3;
        private Label label8;
        private Button button2;
        private Button avatar2_Btn;
        private PictureBox Avatar_Picbox;
        private Button avatar1_Btn;
        private Label PasswordLbl;
        private Label UsernameLbl;
        private TextBox PasswordTxtbox;
        private TextBox UsernameTxtBox;
        private Button SubmitBtn;
        private Button Update_Btn;
        private Panel Login_Pnl;
        private Button button3;
        private Label Username_Lbl;
        private Button Login_Btn;
        private Label label9;
        private TextBox Passwrod_txtBox;
        private Label label10;
        private Button Admin_LogoutBtn;
        private Button button1;
    }
}