using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Data.SqlClient.DataClassification;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        public string label_username { get; set; }

        private string connectionString = "Data Source=DESKTOP-VIJ33BO\\SQLEXPRESS; Initial Catalog=Mellowdy;Integrated Security=True";
        private string TblName = "Profiles";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string teacherUsername = label_username; // Dapat ito ay string
            string teacherName = TeacherInfoRetriever.GetTeacherNameFromUsername(teacherUsername);

            if (!string.IsNullOrEmpty(teacherName))
            {
                label1.Text = teacherName;
            }
            else
            {
                label1.Text = "Teacher not found";
            }

            AvatarPicbx.Image = AvatarPicbx.Image;


            AvatarRetriever();
            label10.Text = "Do you want to logout?";


        }

        public class TeacherInfoRetriever
        {
            private static string connectionString = "Data Source=DESKTOP-VIJ33BO\\SQLEXPRESS; Initial Catalog=Mellowdy;Integrated Security=True";

            public static string GetTeacherNameFromUsername(string teacherUsername)
            {
                string teacherName = null;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Teacher_Name FROM Profiles WHERE Teacher_Username = @Username";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", teacherUsername);

                        // ExecuteScalar returns the first column of the first row as an object
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            teacherName = result.ToString();
                        }
                    }
                }

                return teacherName;
            }
        }

        private void AvatarRetriever()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string teachernname = label1.Text;
                    string query = "SELECT Teacher_Avatar FROM Profiles WHERE Teacher_Name = @Teachernname";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Teachernname", teachernname);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                byte[] imageBytes = (byte[])reader["Teacher_Avatar"];

                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    Image image = Image.FromStream(ms);

                                    // Ilagay ang larawan sa PictureBox
                                    AvatarPicbx.Image = image;
                                }
                            }
                            else
                            {
                                // Walang natagpuang resulta
                                MessageBox.Show("Walang natagpuang guro na may pangalang " + teachernname);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // I-handle ang mga database-related na error
                MessageBox.Show("May naganap na error: " + ex.Message);
            }
        }

        private void AvatarPicbx_Click(object sender, EventArgs e)
        {
            AvatarUpdtPnl.BringToFront();

        }

        private void UpdtAvatarPicBx_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.ico|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                AvatarPicbx.Image = new System.Drawing.Bitmap(imagePath);
            }
        }

        private void Update_avatarbtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    byte[] imageBytes;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        UpdtAvatarPicBx.Image.Save(ms, UpdtAvatarPicBx.Image.RawFormat);
                        imageBytes = ms.ToArray();
                    }

                    string teacherName = label1.Text; // Kunin ang pangalan mula sa Label control
                    string query = "UPDATE Profiles SET Teacher_Avatar = @Image WHERE Teacher_Name = @TeacherName";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TeacherName", teacherName); // Gamitin ang teacherName variable
                        command.Parameters.AddWithValue("@Image", imageBytes);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Successfully Updated");
                            AvatarUpdtPnl.SendToBack();
                            AvatarRetriever();
                        }
                        else
                        {
                            MessageBox.Show("No rows were updated. Teacher name not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating profile: " + ex.Message);
            }
        }

        private void avatar1_Btn_Click(object sender, EventArgs e)
        {
            UpdtAvatarPicBx.Image = avatar1_Btn.BackgroundImage;
        }

        private void avatar2_Btn_Click(object sender, EventArgs e)
        {
            UpdtAvatarPicBx.Image = avatar2_Btn.BackgroundImage;
        }


        private void avatar3_Btn_Click(object sender, EventArgs e)
        {
            UpdtAvatarPicBx.Image = avatar3_Btn.BackgroundImage;
        }

        private void avatar5_Btn_Click(object sender, EventArgs e)
        {
            UpdtAvatarPicBx.Image = avatar5_Btn.BackgroundImage;
        }

        private void avatar6_Btn_Click(object sender, EventArgs e)
        {
            UpdtAvatarPicBx.Image = avatar6_Btn.BackgroundImage;
        }

        private void avatar4_Btn_Click(object sender, EventArgs e)
        {
            UpdtAvatarPicBx.Image = avatar4_Btn.BackgroundImage;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Close();

            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrmptPnl.SendToBack();
        }

        private void CLosed_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimize_Btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Back_Btn_Click(object sender, EventArgs e)
        {
            PrmptPnl.BringToFront();
        }
    }
}
