using System.Drawing.Printing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.CodeDom;
using System.IO;
using System.Linq;
using System.Data;
using System.ComponentModel;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private int groupBoxCount = 2;
        private int newButton3Count = 2;
        private int delButtonCount = 2;
        private int modiButtonCount = 2;
        private int newlabelcount = 2;
        private int newLabelCountnewpanel = 2;
        private GroupBox currentGroupBox = null;
        private Panel currentModProfileMenu = null;
        public Form1()
        {
            InitializeComponent();
        }

        private string connectionString = "Data Source=DESKTOP-VIJ33BO\\SQLEXPRESS; Initial Catalog=Mellowdy;Integrated Security=True";
        private string TblName = "profiles";
        private string LoginPn_username;
        private string LoginPn_password;
        private void Form1_Load(object sender, EventArgs e)
        {
            //profilePanel.Location = new Point((this.ClientSize.Width - profilePanel.Width) / 2, (this.ClientSize.Height - profilePanel.Height) / 2);

            profilePanel.BringToFront();

            AddProfilePnl.Cursor = Cursors.Hand;
            pictureBox1.Cursor = Cursors.Hand;

            // Retrieve teacher's avatar
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Teacher_Avatar, Teacher_Username FROM Profiles WHERE Teacher_Username IS NOT NULL";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string teacherName = reader.GetString(reader.GetOrdinal("Teacher_Username"));
                            byte[] imageBytes = (byte[])reader["Teacher_Avatar"];

                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                Image image = Image.FromStream(ms);
                                Avatar_Picbox.Image = image;
                            }
                        }
                    }
                }
            }


            if (currentModProfileMenu != null)
            {
                currentModProfileMenu.Visible = false;
                currentModProfileMenu = null;
            }


            flowLayoutPanel1.AutoScroll = true;
            CreateNewPanel();

        }

        private void CreateNewPanel()
        {
            string tableName = TblName;
            string columnName = "Teacher_Name";

            int columnCount = 0;

            string query = $"SELECT COUNT(*) FROM {tableName} WHERE {columnName} IS NOT NULL";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    columnCount = (int)command.ExecuteScalar();
                }

                query = $"SELECT {columnName}, Teacher_Avatar FROM {tableName} WHERE {columnName} IS NOT NULL ORDER BY TeacherID ASC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int panelCount = 0;

                        while (reader.Read() && panelCount < columnCount)
                        {
                            string teachersName = reader.GetString(0);
                            byte[] imageBytes = (byte[])reader["Teacher_Avatar"];

                            Panel newPanel = new Panel();

                            newPanel.Name = string.Format("panel{0}", panelCount);
                            newPanel.Cursor = Cursors.Hand;
                            newPanel.Height = 200;
                            newPanel.Width = 150;
                            newPanel.BackgroundImage = Properties.Resources.usr_gb_bgg22;
                            newPanel.BackgroundImageLayout = ImageLayout.Stretch;
                            newPanel.Click += NewPanel_Click;

                            Label ProfileNameLabel = new Label();
                            ProfileNameLabel.Text = teachersName;
                            ProfileNameLabel.Location = new Point(55, 160);
                            ProfileNameLabel.AutoSize = true;

                            newPanel.Controls.Add(ProfileNameLabel);

                            Button newButton2 = new Button();
                            newButton2.Name = string.Format("delButton{0}", delButtonCount);
                            newButton2.Text = "Delete";
                            newButton2.Size = new Size(75, 23);
                            newButton2.Click += newButton2_Click;

                            Button newButton1 = new Button();
                            newButton1.Name = string.Format("modiButton{0}", modiButtonCount);
                            newButton1.Text = "Modify";
                            newButton1.Size = new Size(75, 23);
                            newButton1.Location = new Point(10, 70);
                            newButton1.Click += ModBtn_Click;

                            Panel profilemenu = new Panel();
                            profilemenu.Location = new Point(27, 50);
                            profilemenu.Controls.Add(newButton1);
                            profilemenu.Controls.Add(newButton2);

                            newButton1.Location = new Point(10, 10);
                            newButton2.Location = new Point(10, 40);
                            profilemenu.Size = new Size(100, 80);
                            profilemenu.BorderStyle = BorderStyle.FixedSingle;
                            profilemenu.Visible = false;

                            PictureBox dotPictureBox = new PictureBox();
                            dotPictureBox.Name = string.Format("newButton{0}", newButton3Count);
                            //dotPictureBox.BackgroundImage = Properties.Resources.dot_btn2;
                            dotPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
                            dotPictureBox.Size = new Size(40, 25);
                            dotPictureBox.Location = new Point(80, 10);
                            dotPictureBox.Click += dotPictureBox_Click;
                            dotPictureBox.Cursor = Cursors.Hand;

                            Button newButton4 = new Button();
                            newButton4.Name = string.Format("newButton{0}", newButton3Count);
                            newButton4.Text = "Login";
                            newButton4.Size = new Size(55, 23);
                            newButton4.Location = new Point(40, 150);

                            PictureBox avatarpictureBox = new PictureBox();
                            avatarpictureBox.Image = Image.FromStream(new MemoryStream(imageBytes));
                            avatarpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                            avatarpictureBox.BorderStyle = BorderStyle.None;
                            avatarpictureBox.Location = new Point(30, 52);
                            avatarpictureBox.Size = new Size(80, 80);
                            avatarpictureBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                            avatarpictureBox.Click += Avatar_PictureBox_Click;


                            //avatarpictureBox();
                            newPanel.Controls.Add(avatarpictureBox);
                            //newPanel.Controls.Add(dotPictureBox);
                            newPanel.Controls.Add(profilemenu);
                            flowLayoutPanel1.Controls.Add(newPanel);

                            ProfileNameLabel.SendToBack();

                            panelCount++;
                        }
                    }
                }
            }


            int panelIndex = flowLayoutPanel1.Controls.IndexOf(AddProfilePnl);
            if (panelIndex != -1)
            {
                flowLayoutPanel1.Controls.SetChildIndex(flowLayoutPanel1.Controls[panelIndex], flowLayoutPanel1.Controls.Count - 1);
            }
        }
        private void CreateNewPanel2()
        {
            string tableName = TblName;
            string columnName = "Teacher_Name";

            int columnCount = 0;

            string query = $"SELECT COUNT(*) FROM {tableName} WHERE {columnName} IS NOT NULL";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    columnCount = (int)command.ExecuteScalar();
                }

                query = $"SELECT {columnName}, Teacher_Avatar FROM {tableName} WHERE {columnName} IS NOT NULL ORDER BY TeacherID ASC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int panelCount = 0;

                        while (reader.Read() && panelCount < columnCount)
                        {
                            string teachersName = reader.GetString(0);
                            byte[] imageBytes = (byte[])reader["Teacher_Avatar"];

                            Panel newPanel = new Panel();

                            newPanel.Name = string.Format("panel{0}", panelCount);
                            newPanel.Cursor = Cursors.Hand;
                            newPanel.Height = 200;
                            newPanel.Width = 150;
                            newPanel.BackgroundImage = Properties.Resources.usr_gb_bgg22;
                            newPanel.BackgroundImageLayout = ImageLayout.Stretch;
                            newPanel.Click += NewPanel_Click;

                            Label ProfileNameLabel = new Label();
                            ProfileNameLabel.Text = teachersName;
                            ProfileNameLabel.Location = new Point(55, 160);
                            ProfileNameLabel.AutoSize = true;

                            newPanel.Controls.Add(ProfileNameLabel);

                            Button newButton2 = new Button();
                            newButton2.Name = string.Format("delButton{0}", delButtonCount);
                            newButton2.Text = "Delete";
                            newButton2.Size = new Size(75, 23);
                            newButton2.Click += newButton2_Click;

                            Button newButton1 = new Button();
                            newButton1.Name = string.Format("modiButton{0}", modiButtonCount);
                            newButton1.Text = "Modify";
                            newButton1.Size = new Size(75, 23);
                            newButton1.Location = new Point(10, 70);
                            newButton1.Click += ModBtn_Click;

                            Panel profilemenu = new Panel();
                            profilemenu.Location = new Point(27, 50);
                            profilemenu.Controls.Add(newButton1);
                            profilemenu.Controls.Add(newButton2);

                            newButton1.Location = new Point(10, 10);
                            newButton2.Location = new Point(10, 40);
                            profilemenu.Size = new Size(100, 80);
                            profilemenu.BorderStyle = BorderStyle.FixedSingle;
                            profilemenu.Visible = false;

                            PictureBox dotPictureBox = new PictureBox();
                            dotPictureBox.Name = string.Format("newButton{0}", newButton3Count);
                            dotPictureBox.BackgroundImage = Properties.Resources.dot_btn2;
                            dotPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
                            dotPictureBox.Size = new Size(40, 25);
                            dotPictureBox.Location = new Point(80, 10);
                            dotPictureBox.Click += dotPictureBox_Click;
                            dotPictureBox.Cursor = Cursors.Hand;

                            Button newButton4 = new Button();
                            newButton4.Name = string.Format("newButton{0}", newButton3Count);
                            newButton4.Text = "Login";
                            newButton4.Size = new Size(55, 23);
                            newButton4.Location = new Point(40, 150);

                            PictureBox avatarpictureBox = new PictureBox();
                            avatarpictureBox.Image = Image.FromStream(new MemoryStream(imageBytes));
                            avatarpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                            avatarpictureBox.BorderStyle = BorderStyle.None;
                            avatarpictureBox.Location = new Point(30, 52);
                            avatarpictureBox.Size = new Size(80, 80);
                            avatarpictureBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                            avatarpictureBox.Click += Avatar_PictureBox_Click;


                            //avatarpictureBox();
                            newPanel.Controls.Add(avatarpictureBox);
                            newPanel.Controls.Add(dotPictureBox);
                            newPanel.Controls.Add(profilemenu);
                            flowLayoutPanel1.Controls.Add(newPanel);

                            ProfileNameLabel.SendToBack();

                            panelCount++;
                        }
                    }
                }
            }


            int panelIndex = flowLayoutPanel1.Controls.IndexOf(AddProfilePnl);
            if (panelIndex != -1)
            {
                flowLayoutPanel1.Controls.SetChildIndex(flowLayoutPanel1.Controls[panelIndex], flowLayoutPanel1.Controls.Count - 1);
            }
        }
        private void NewPanel_Click(object sender, EventArgs e)
        {
            FocusTblPnl.BringToFront();

            Panel clickedPanel = (Panel)sender;
            Label profileNameLabel = clickedPanel.Controls.OfType<Label>().FirstOrDefault();

            Username_Lbl.Text = profileNameLabel.Text;
            FocusPnlLabel.Text = profileNameLabel.Text;

            focuspicbox();
        }

        private void openpanel()
        {
            if (currentModProfileMenu != null)
            {
                currentModProfileMenu.Visible = false;
                currentModProfileMenu = null;
            }

            SubmitBtn.Visible = true;
            Update_Btn.Visible = false;

            profilePanel.Show();
            TeacherNametxtBox.Visible = true;
            TeachersNameLbl.Visible = false;

            UsernameLbl.Text = "Username";
            PasswordLbl.Text = "Password";

            Avatar_Picbox.Image = null;
            UsernameTxtBox.Clear();
            PasswordTxtbox.Clear();
            TeacherNametxtBox.Clear();
        }

        private void ModBtn_Click(object sender, EventArgs e)
        {
            if (currentModProfileMenu != null)
            {
                currentModProfileMenu.Visible = false;
                currentModProfileMenu = null;
            }

            UsernameLbl.Text = "Current Username";
            PasswordLbl.Text = "Current Password";

            SubmitBtn.Visible = false;
            Update_Btn.Visible = true;
            TeacherNametxtBox.Visible = false;
            TeachersNameLbl.Visible = true;

            Button delButton = (Button)sender;
            Panel panel = (Panel)delButton.Parent.Parent;

            if (panel != null)
            {
                Label profileNameLabel = panel.Controls.OfType<Label>().FirstOrDefault();

                if (profileNameLabel != null)
                {
                    string teachername = profileNameLabel.Text;

                    string tableName = TblName;
                    string columnName = "Teacher_Name";
                    string query = $"SELECT * FROM {tableName} WHERE Teacher_Name = @TeacherName";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@TeacherName", teachername);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                // Check kung may result
                                if (reader.Read())
                                {
                                    // Makuha ang iba pang impormasyon tulad ng Username at Password
                                    string username = reader["Teacher_Username"].ToString();
                                    string password = reader["Teacher_Password"].ToString();
                                    string teacherName = reader["Teacher_Name"].ToString(); // Ito ang Teacher_Name

                                    // Kunin ang ProfilePanel mula sa parent ng GroupBox
                                    Panel profilePanel = (Panel)panel.Parent;

                                    // Kunin ang mga TextBox para sa Username at Password mula sa ProfilePanel
                                    TextBox usernameTextBox = profilePanel.Controls.OfType<TextBox>().FirstOrDefault(c => c.Name == "UsernameTextBox");
                                    TextBox passwordTextBox = profilePanel.Controls.OfType<TextBox>().FirstOrDefault(c => c.Name == "PasswordTextBox");

                                    if (TeachersNameLbl != null)
                                    {
                                        // Ipapakita ang Teacher_Name sa TextBox
                                        TeachersNameLbl.Text = teacherName;
                                    }
                                    else
                                    {
                                        MessageBox.Show("TeacherName TextBox not found or is null.");
                                    }

                                    if (UsernameTxtBox != null)
                                    {
                                        // Ipapakita ang Username sa TextBox
                                        UsernameTxtBox.Text = username;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Username TextBox not found or is null.");
                                    }

                                    if (PasswordTxtbox != null)
                                    {
                                        // Ipapakita ang Password sa TextBox
                                        PasswordTxtbox.Text = password;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Password TextBox not found or is null.");
                                    }

                                    query = $"SELECT {columnName}, Teacher_Avatar FROM {tableName} WHERE {columnName} IS NOT NULL";
                                    byte[] avatarBytes = (byte[])reader["Teacher_Avatar"];
                                    if (avatarBytes != null)
                                    {
                                        Image avatarImage = Image.FromStream(new MemoryStream(avatarBytes));
                                        Avatar_Picbox.Image = avatarImage;
                                    }
                                }
                            }
                        }
                    }
                }

                else
                {
                    MessageBox.Show("ProfileNameLabel not found or is null.");
                }
            }
            else
            {
                MessageBox.Show("GroupBox not found or is null.");
            }

            profilePanel.Show();
            profilePanel.BringToFront();

        }

        private void newButton2_Click(object sender, EventArgs e)
        {
            if (currentModProfileMenu != null)
            {
                currentModProfileMenu.Visible = false;
                currentModProfileMenu = null;
            }

            Button delButton = (Button)sender;
            Panel panel = (Panel)delButton.Parent.Parent;

            // Kunin ang ProfileNameLabel galing sa collection of controls ng GroupBox 
            Label profileNameLabel = panel.Controls.OfType<Label>().FirstOrDefault();

            // Kunin ang Teacher_Username galing sa ProfileNameLabel
            string teacherName = profileNameLabel.Text;

            // idedelete ang same na row sa database gamit ang Teacher_Username
            string tableName = TblName;
            string columnName = "Teacher_Name";

            string query = $"DELETE FROM {tableName} WHERE {columnName} = @TeacherName";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TeacherName", teacherName); // binago ang parameter name dito
                    command.ExecuteNonQuery();
                }
            }

            // Alisin ang GroupBox mula sa flowLayoutPanel1
            flowLayoutPanel1.Controls.Remove(panel);
        }

        private void focuspicbox()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string teacherUsernameToFind = FocusPnlLabel.Text;
                    string query = "SELECT Teacher_Avatar FROM Profiles WHERE Teacher_Name = @Teacher_Name";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Corrected parameter name to match the SQL query
                        command.Parameters.AddWithValue("@Teacher_Name", teacherUsernameToFind);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                byte[] imageBytes = (byte[])reader["Teacher_Avatar"];

                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    Image image = Image.FromStream(ms);

                                    // Set the image to the PictureBox
                                    FocusPnlPicbox.Image = image;
                                }
                            }
                            else
                            {
                                // No teacher found
                                MessageBox.Show("Walang natagpuang guro na may pangalang " + teacherUsernameToFind);
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                // Handle database-related errors
                MessageBox.Show("May naganap na error: " + ex.Message);
            }

        }

        private void dotPictureBox_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = (PictureBox)sender;
            Panel panel = (Panel)pictureBox.Parent;

            Panel modProfileMenu = panel.Controls.OfType<Panel>().FirstOrDefault();

            if (modProfileMenu != null)
            {
                if (currentModProfileMenu != null && currentModProfileMenu != modProfileMenu)
                {
                    currentModProfileMenu.Visible = false;
                }

                currentModProfileMenu = modProfileMenu;

                modProfileMenu.Visible = !modProfileMenu.Visible;

                if (modProfileMenu.Visible)
                {
                    modProfileMenu.BringToFront();
                }
            }

        }


        private void Avatar_PictureBox_Click(object sender, EventArgs e)
        {
            FocusTblPnl.BringToFront();

            PictureBox clickedPictureBox = sender as PictureBox;
            Panel parentPanel = clickedPictureBox.Parent as Panel;
            Label profileNameLabel = parentPanel.Controls.OfType<Label>().FirstOrDefault();

            FocusPnlLabel.Text = profileNameLabel.Text;
            focuspicbox();

        }

        private void AddProfilePnl_Click(object sender, EventArgs e)
        {
            openpanel();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {

            if (Avatar_Picbox.Image == null)
            {
                MessageBox.Show("Please select an avatar image.");
                return;
            }

            if (string.IsNullOrEmpty(UsernameTxtBox.Text) || string.IsNullOrEmpty(PasswordTxtbox.Text))
            {
                MessageBox.Show("Please enter a username and password.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // ikoconvert ang pictureBox na image to byte array
                    byte[] imageBytes;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        Avatar_Picbox.Image.Save(ms, Avatar_Picbox.Image.RawFormat);
                        imageBytes = ms.ToArray();
                    }

                    string query = "INSERT INTO Profiles (Teacher_Name,Teacher_Username, Teacher_Password, Teacher_Avatar) VALUES (@TeacherName, @Username, @Password, @Image)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TeacherName", TeacherNametxtBox.Text);
                        command.Parameters.AddWithValue("@Username", UsernameTxtBox.Text);
                        command.Parameters.AddWithValue("@Password", PasswordTxtbox.Text);
                        command.Parameters.AddWithValue("@Image", imageBytes);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Successfully Added");

                        //pictureBox2.Image = pictureBox1.Image;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions or log the error message
                MessageBox.Show("Error inserting image: " + ex.Message);
            }

            newButton3Count++;
            delButtonCount++;
            UsernameTxtBox.Clear(); // iclear ang laman ng usernameTextBox
            PasswordTxtbox.Clear(); // iclear ang laman ng passwordTextBox
            TeacherNametxtBox.Clear();
            profilePanel.Hide();

            flowLayoutPanel1.Controls.Clear(); // Alisin ang lahat na existing na groupbox
            CreateNewPanel(); // gumawa ulit ng groupbox
            flowLayoutPanel1.Controls.Add(AddProfilePnl);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                PasswordTxtbox_LoginPnl.UseSystemPasswordChar = false;
            }

            else
            {
                PasswordTxtbox_LoginPnl.UseSystemPasswordChar = true;
            }
        }

        private void avatar1_Btn_Click(object sender, EventArgs e)
        {
            Avatar_Picbox.Image = avatar1_Btn.BackgroundImage;
        }

        private void avatar2_Btn_Click(object sender, EventArgs e)
        {
            Avatar_Picbox.Image = avatar2_Btn.BackgroundImage;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openpanel();
        }

        private void AddProfilePnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admin_LoginBtn_Click(object sender, EventArgs e)
        {
            FocusPnlLabel.Text = "Admin";
            AdminLoginBtn.BringToFront();
            FocusTblPnl.BringToFront();
            flowLayoutPanel1.BringToFront();
            AddProfilePnl.Visible = false;
        }

        private void AdminLoginBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameTxtBox_LoginPnl.Text;
            string password = PasswordTxtbox_LoginPnl.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Admin WHERE Username = @Username AND Password = @Password";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            if (dataTable.Rows.Count > 0)
                            {
                                FocusTblPnl.SendToBack();
                                flowLayoutPanel1.Controls.Clear();
                                CreateNewPanel2();
                                flowLayoutPanel1.Controls.Remove(AddProfilePnl);
                            }
                            else
                            {
                                MessageBox.Show("Incorrect admin details");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }


        private void LoginPnl_Button_Click(object sender, EventArgs e)
        {

            LoginPn_username = UsernameTxtBox_LoginPnl.Text;

            LoginPn_password = PasswordTxtbox_LoginPnl.Text;

            try
            {
                string querry = "SELECT * FROM Profiles WHERE Teacher_Username = '" + UsernameTxtBox_LoginPnl.Text + "' AND Teacher_Password = '" + PasswordTxtbox_LoginPnl.Text + "'";

                SqlDataAdapter sda = new SqlDataAdapter(querry, connectionString);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {

                    Form2 form2 = new Form2();

                    // I-set ang property o variable sa Form3 na naglalaman ng label
                    form2.label_username = UsernameTxtBox_LoginPnl.Text;

                    // Ipakita ang Form3
                    form2.Show();

                    // Itago ang Form1 (kung kinakailangan)
                    this.Hide();

                }

                else
                {
                    MessageBox.Show("Inccorect Details");
                }

            }


            catch
            {
                MessageBox.Show("Error");
            }

        }

        private void PasswordTxtbox_LoginPnl_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsernameTxtBox_LoginPnl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PasswordTxtbox_LoginPnl.Focus();
            }
        }

        private void PasswordTxtbox_LoginPnl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (PasswordTxtbox_LoginPnl.Text == "admin")
                {
                    AdminLoginBtn.PerformClick();
                }
                else
                {
                    LoginPnl_Button.PerformClick();
                }
            }
        }

        private void CLosed_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimize_Btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Update_Btn_Click(object sender, EventArgs e)
        {
            if (Avatar_Picbox.Image == null)
            {
                MessageBox.Show("Please select an avatar image.");
                return;
            }

            if (string.IsNullOrEmpty(UsernameTxtBox.Text) || string.IsNullOrEmpty(PasswordTxtbox.Text))
            {
                MessageBox.Show("Please enter a teacher name, username, and password.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    byte[] imageBytes;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        Avatar_Picbox.Image.Save(ms, Avatar_Picbox.Image.RawFormat);
                        imageBytes = ms.ToArray();
                    }

                    string query = "UPDATE profiles SET Teacher_Username = @Username, Teacher_Password = @Password, Teacher_Avatar = @Image WHERE Teacher_Name = @TeacherName";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@TeacherName", TeachersNameLbl.Text);
                        command.Parameters.AddWithValue("@Username", UsernameTxtBox.Text);
                        command.Parameters.AddWithValue("@Password", PasswordTxtbox.Text);
                        command.Parameters.AddWithValue("@Image", imageBytes);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Successfully Updated");
                        }
                        else
                        {
                            MessageBox.Show("No rows were updated. Username not found.");
                        }

                    }

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error updating profile: " + ex.Message);
            }

            profilePanel.Hide();

            flowLayoutPanel1.Controls.Clear();
            CreateNewPanel2();
            flowLayoutPanel1.Controls.Add(AddProfilePnl);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            profilePanel.SendToBack();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FocusTblPnl.SendToBack();
        }
    }
}