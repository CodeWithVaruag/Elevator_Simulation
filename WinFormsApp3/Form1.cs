using System;
using System.Data;
using System.Data.SQLite;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp3
{


    public partial class Form1 : Form
    {
        int x_doorL_close = 252; // Adjust this value as needed
        int x_doorL_open = 186;


        int y_liftDown = 560;
        int y_liftUp = 222;

        bool moving_up = false;
        bool moving_down = false;

        String LiftStatus = "GroundFloor";
        Connection dbConnection;
        private SQLiteConnection sqliteConnection;


        // Variables to store original door positions
        int originalLeftDoorPosition;
        int originalRightDoorPosition;

        public Form1()
        {
            InitializeComponent();




            // Initialize original door positions
            originalLeftDoorPosition = firstfloor_leftdoor.Left;
            originalRightDoorPosition = firstfloor_rightdoor.Left;
            string connectionString = "Data Source=mydatabase.db;Version=3;";
            sqliteConnection = new SQLiteConnection(connectionString);
            sqliteConnection.Open();

            dbConnection = new Connection();

            // Get the application start time
            DateTime appStartTime = DateTime.Now;

            // Load all data from the database
          

            // Filter the data to show only records after the application start time
           





        }





        public void loadcomponent() => InitializeComponent();

        public delegate void MethodCall();



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Handle pictureBox2 Click Event
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Handle pictureBox3 Click Event
        }

        private void liftbox_inside_Click(object sender, EventArgs e)
        {
            // Handle liftbox_inside Click Event
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            // Handle pictureBox2_Click_1 Event
        }

        private void groundfloor_leftdoor_Click(object sender, EventArgs e)
        {
            // Handle groundfloor_leftdoor Click Event
        }

        private void groundfloor_rightdoor_Click(object sender, EventArgs e)
        {
            // Handle groundfloor_rightdoor Click Event
        }

        private void firstfloor_leftdoor_Click(object sender, EventArgs e)
        {
            // Handle firstfloor_leftdoor Click Event
        }

        private void firstfloor_rightdoor_Click(object sender, EventArgs e)
        {
            // Handle firstfloor_rightdoor Click Event
        }

        private void groundfloor_button_Click(object sender, EventArgs e)
        {
            if (moving_up == false) // if the lift is not moving up
            {
                moving_down = true;
                firstfloor_doorclose.Enabled = true;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Handle pictureBox1 Click Event
        }

        private void firstfloor_dooropen_Tick(object sender, EventArgs e)
        {
            if (firstfloor_leftdoor.Left >= x_doorL_open && firstfloor_doorclose.Enabled != true) // if door is closed
            {
                MethodCall updoor = new MethodCall(updoors_openMethod);
                updoor.Invoke();

            }
            else
            {

                firstfloor_dooropen.Enabled = false;
                timer_close.Enabled = true;
                string actionDescription = "First floor door opened";
                dbConnection.InsertData(DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), actionDescription);


            }
        }

        private void updoors_openMethod() // animate method to open the doors
        {
            firstfloor_leftdoor.Left -= 1;
            firstfloor_rightdoor.Left += 1;
        }

        private void firstfloor_doorclose_Tick(object sender, EventArgs e)
        {
            if (firstfloor_leftdoor.Left <= x_doorL_close && firstfloor_dooropen.Enabled != true) // if the door is open
            {
                MethodCall updoor = new MethodCall(updoors_closeMethod);
                updoor.Invoke();

            }
            else
            {
                firstfloor_doorclose.Enabled = false;
                if (moving_down == true) // if also moving down
                {
                    lift_status_screen.Text = "v";
                    firstfloor_screen.Text = "v";
                    groundfloor_screen.Text = "v";
                    lift_down.Enabled = true;
                    string actionDescription = "First floor door closed";
                    dbConnection.InsertData(DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), actionDescription);

                }
            }
        }

        private void updoors_closeMethod() // animate method to close the doors
        {
            firstfloor_leftdoor.Left += 1;
            firstfloor_rightdoor.Left -= 1;
        }

        private void groundfloor_dooropen_Tick(object sender, EventArgs e)
        {
            if (groundfloor_leftdoor.Left >= x_doorL_open && groundfloor_doorclose.Enabled != true)
            {
                MethodCall downdoor = new MethodCall(downdoors_openMethod);
                downdoor.Invoke();

            }
            else
            {
                groundfloor_dooropen.Enabled = false;
                timer_close.Enabled = true;
                string actionDescription = "Ground floor door opened";
                dbConnection.InsertData(DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), actionDescription);

            }
        }

        private void downdoors_openMethod() // animate method to open down doors
        {
            groundfloor_leftdoor.Left -= 1;
            groundfloor_rightdoor.Left += 1;
        }

        private void groundfloor_doorclose_Tick(object sender, EventArgs e)
        {
            if (groundfloor_leftdoor.Left <= x_doorL_close && groundfloor_dooropen.Enabled != true) // if lift doors are open
            {
                MethodCall downdoor = new MethodCall(downdoors_closeMethod);
                downdoor.Invoke();

            }
            else
            {
                groundfloor_doorclose.Enabled = false;
                if (moving_up == true) // if also moving up
                {
                    lift_status_screen.Text = "^";
                    firstfloor_screen.Text = "^";
                    groundfloor_screen.Text = "^";
                    lift_up.Enabled = true;
                    string actionDescription = "Ground floor door close";
                    dbConnection.InsertData(DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), actionDescription);

                }
            }
        }

        private void downdoors_closeMethod() // animation method to close down doors
        {
            groundfloor_leftdoor.Left += 1;
            groundfloor_rightdoor.Left -= 1;
        }

        private void lift_up_Tick(object sender, EventArgs e)
        {
            if (liftbox_inside.Top != y_liftUp)
            {
                MethodCall movingUp = new MethodCall(liftUp);
                movingUp.Invoke();

            }
            else
            {
                firstfloor_button.BackColor = Color.White;
                moving_up = false;
                lift_status_screen.Text = "1";
                firstfloor_screen.Text = "1";
                groundfloor_screen.Text = "1";
                LiftStatus = "FirstFloor";
                lift_up.Enabled = false;
                firstfloor_dooropen.Enabled = true;
                string actionDescription = "lift going up from ground to first floor";
                dbConnection.InsertData(DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), actionDescription);

            }
        }

        private void liftUp() // method to animate liftbox moving down
        {
            liftbox_inside.Top -= 1;
            liftbox_inside.Image = Properties.Resources.lift_inside;
        }

        private void lift_down_Tick(object sender, EventArgs e)
        {
            if (liftbox_inside.Top != y_liftDown)
            {
                MethodCall movingUp = new MethodCall(liftDown);
                movingUp.Invoke();

            }
            else
            {
                groundfloor_button.BackColor = Color.White;
                moving_down = false;
                liftbox_inside.Image = Properties.Resources.lift_inside;
                lift_status_screen.Text = "G";
                firstfloor_screen.Text = "G";
                groundfloor_screen.Text = "G";
                LiftStatus = "GroundFloor";
                lift_down.Enabled = false;
                groundfloor_dooropen.Enabled = true;
                string actionDescription = "lift going up from ground to first floor";
                dbConnection.InsertData(DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), actionDescription);

            }
        }

        private void liftDown() // method to animate liftbox moving up
        {
            liftbox_inside.Top += 1;
        }

        private void firstfloor_button_Click(object sender, EventArgs e)
        {
            if (moving_down == false && LiftStatus == "GroundFloor")
            {
                moving_up = true;
                groundfloor_doorclose.Enabled = true;
                firstfloor_button.BackColor = Color.Green; // Indicate the selected floor
            }

        }

        private void opendoor_button_Click(object sender, EventArgs e)
        {
            switch (LiftStatus)
            {
                case "GroundFloor":
                    groundfloor_dooropen.Enabled = true;
                    break;
                case "FirstFloor":
                    firstfloor_dooropen.Enabled = true;
                    break;
            }

        }

        private void btn_closedoors_Click(object sender, EventArgs e) // assigning button event 
        {
            closedoor_button.BackColor = Color.Orange;
            switch (LiftStatus)
            {
                case "GroundFloor":
                    groundfloor_doorclose.Enabled = true;
                    break;
                case "FirstFloor":
                    firstfloor_doorclose.Enabled = true;
                    break;
            }

        }

        private void liftdown_button_Click(object sender, EventArgs e)
        {
            if (LiftStatus.Equals("FirstFloor"))
            {
                moving_down = true;
                firstfloor_doorclose.Enabled = true;
            }

        }

        private void liftup_button_Click(object sender, EventArgs e)
        {
            if (LiftStatus.Equals("GroundFloor"))
            {
                moving_up = true;
                groundfloor_doorclose.Enabled = true;
            }

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer_close_Tick(object sender, EventArgs e)
        {
            switch (LiftStatus)
            {
                case "GroundFloor":
                    groundfloor_doorclose.Enabled = true;
                    break;
                case "FirstFloor":
                    firstfloor_doorclose.Enabled = true;
                    break;
            }
            timer_close.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void firstfloor_screen_TextChanged(object sender, EventArgs e)
        {

        }

        private void groundfloor_screen_TextChanged(object sender, EventArgs e)
        {

        }












        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (dbConnection != null)
            {
                dbConnection.CloseConnection();
            }

            base.OnFormClosing(e);

        }



        private void print_button_Click(object sender, EventArgs e)
        {


            DataTable dataTable = dbConnection.GetDataFromDatabase();

            // Get the user's desktop folder path
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Define the file path on the desktop where the data will be saved
            string filePath = Path.Combine(desktopPath, "elevator_data.txt");

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    sw.WriteLine($"{row["date"]}, {row["time"]}, {row["action"]}");
                }
            }

            MessageBox.Show($"Data has been saved to your desktop at: {filePath}", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void exit_button_Click(object sender, EventArgs e)
        {
            LoadDataToTextBox();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }



        private void LoadDataToTextBox()
        {
            // Construct a SQL query to retrieve the data from your database table
            string query = "SELECT * FROM elevator";

            using (SQLiteCommand cmd = new SQLiteCommand(query, sqliteConnection))
            {
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        // Create a StringBuilder to build the text
                        StringBuilder textBuilder = new StringBuilder();

                        // Loop through the rows and append data to the StringBuilder
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                textBuilder.Append(reader[i].ToString());
                                textBuilder.Append("\t"); // Add a tab to separate columns
                            }
                            textBuilder.AppendLine(); // Add a newline for each row
                        }

                        // Set the TextBox text with the data
                        textBox1.Text = textBuilder.ToString();
                    }
                    else
                    {
                        textBox1.Text = "No data found.";
                    }
                }
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
