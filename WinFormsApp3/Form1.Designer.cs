namespace WinFormsApp3
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            liftbox_inside = new PictureBox();
            groundfloor_leftdoor = new PictureBox();
            groundfloor_rightdoor = new PictureBox();
            firstfloor_leftdoor = new PictureBox();
            firstfloor_rightdoor = new PictureBox();
            pictureBox2 = new PictureBox();
            lift_status_screen = new TextBox();
            firstfloor_button = new Button();
            groundfloor_button = new Button();
            opendoor_button = new Button();
            closedoor_button = new Button();
            liftdown_button = new Button();
            liftup_button = new Button();
            firstfloor_dooropen = new System.Windows.Forms.Timer(components);
            firstfloor_doorclose = new System.Windows.Forms.Timer(components);
            groundfloor_dooropen = new System.Windows.Forms.Timer(components);
            groundfloor_doorclose = new System.Windows.Forms.Timer(components);
            lift_up = new System.Windows.Forms.Timer(components);
            lift_down = new System.Windows.Forms.Timer(components);
            timer_close = new System.Windows.Forms.Timer(components);
            firstfloor_screen = new TextBox();
            groundfloor_screen = new TextBox();
            clearlog_button = new Button();
            print_button = new Button();
            Refresh = new Button();
            bindingSource1 = new BindingSource(components);
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            ACTION = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)liftbox_inside).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groundfloor_leftdoor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groundfloor_rightdoor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)firstfloor_leftdoor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)firstfloor_rightdoor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.floor;
            pictureBox1.Location = new Point(46, 198);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(586, 317);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.floor1;
            pictureBox3.Location = new Point(46, 537);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(586, 319);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // liftbox_inside
            // 
            liftbox_inside.Image = Properties.Resources.lift_inside;
            liftbox_inside.Location = new Point(256, 562);
            liftbox_inside.Name = "liftbox_inside";
            liftbox_inside.Size = new Size(171, 238);
            liftbox_inside.SizeMode = PictureBoxSizeMode.StretchImage;
            liftbox_inside.TabIndex = 3;
            liftbox_inside.TabStop = false;
            liftbox_inside.Click += liftbox_inside_Click;
            // 
            // groundfloor_leftdoor
            // 
            groundfloor_leftdoor.Image = Properties.Resources.lift_outside_left;
            groundfloor_leftdoor.Location = new Point(256, 562);
            groundfloor_leftdoor.Name = "groundfloor_leftdoor";
            groundfloor_leftdoor.Size = new Size(89, 238);
            groundfloor_leftdoor.SizeMode = PictureBoxSizeMode.StretchImage;
            groundfloor_leftdoor.TabIndex = 4;
            groundfloor_leftdoor.TabStop = false;
            groundfloor_leftdoor.Click += groundfloor_leftdoor_Click;
            // 
            // groundfloor_rightdoor
            // 
            groundfloor_rightdoor.Image = Properties.Resources.lift_outside_right;
            groundfloor_rightdoor.Location = new Point(339, 562);
            groundfloor_rightdoor.Name = "groundfloor_rightdoor";
            groundfloor_rightdoor.Size = new Size(95, 238);
            groundfloor_rightdoor.SizeMode = PictureBoxSizeMode.StretchImage;
            groundfloor_rightdoor.TabIndex = 5;
            groundfloor_rightdoor.TabStop = false;
            groundfloor_rightdoor.Click += groundfloor_rightdoor_Click;
            // 
            // firstfloor_leftdoor
            // 
            firstfloor_leftdoor.Image = Properties.Resources.lift_outside_left;
            firstfloor_leftdoor.Location = new Point(256, 219);
            firstfloor_leftdoor.Name = "firstfloor_leftdoor";
            firstfloor_leftdoor.Size = new Size(89, 240);
            firstfloor_leftdoor.SizeMode = PictureBoxSizeMode.StretchImage;
            firstfloor_leftdoor.TabIndex = 6;
            firstfloor_leftdoor.TabStop = false;
            firstfloor_leftdoor.Click += firstfloor_leftdoor_Click;
            // 
            // firstfloor_rightdoor
            // 
            firstfloor_rightdoor.Image = Properties.Resources.lift_outside_right;
            firstfloor_rightdoor.Location = new Point(340, 219);
            firstfloor_rightdoor.Name = "firstfloor_rightdoor";
            firstfloor_rightdoor.Size = new Size(94, 240);
            firstfloor_rightdoor.SizeMode = PictureBoxSizeMode.StretchImage;
            firstfloor_rightdoor.TabIndex = 7;
            firstfloor_rightdoor.TabStop = false;
            firstfloor_rightdoor.Click += firstfloor_rightdoor_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.button_wall_container;
            pictureBox2.Location = new Point(671, 435);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(160, 319);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // lift_status_screen
            // 
            lift_status_screen.BackColor = SystemColors.InactiveCaptionText;
            lift_status_screen.BorderStyle = BorderStyle.None;
            lift_status_screen.Cursor = Cursors.No;
            lift_status_screen.Enabled = false;
            lift_status_screen.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lift_status_screen.ForeColor = Color.Red;
            lift_status_screen.Location = new Point(685, 453);
            lift_status_screen.Multiline = true;
            lift_status_screen.Name = "lift_status_screen";
            lift_status_screen.ReadOnly = true;
            lift_status_screen.Size = new Size(133, 116);
            lift_status_screen.TabIndex = 9;
            lift_status_screen.TextAlign = HorizontalAlignment.Center;
            // 
            // firstfloor_button
            // 
            firstfloor_button.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            firstfloor_button.ForeColor = SystemColors.ActiveCaptionText;
            firstfloor_button.Location = new Point(685, 603);
            firstfloor_button.Name = "firstfloor_button";
            firstfloor_button.Size = new Size(56, 47);
            firstfloor_button.TabIndex = 10;
            firstfloor_button.Text = "1\r\n";
            firstfloor_button.UseVisualStyleBackColor = true;
            firstfloor_button.Click += firstfloor_button_Click;
            // 
            // groundfloor_button
            // 
            groundfloor_button.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            groundfloor_button.ForeColor = SystemColors.ActiveCaptionText;
            groundfloor_button.Location = new Point(762, 603);
            groundfloor_button.Name = "groundfloor_button";
            groundfloor_button.Size = new Size(56, 47);
            groundfloor_button.TabIndex = 11;
            groundfloor_button.Text = "G";
            groundfloor_button.UseVisualStyleBackColor = true;
            groundfloor_button.Click += groundfloor_button_Click;
            // 
            // opendoor_button
            // 
            opendoor_button.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            opendoor_button.ForeColor = SystemColors.ActiveCaptionText;
            opendoor_button.Location = new Point(685, 670);
            opendoor_button.Name = "opendoor_button";
            opendoor_button.Size = new Size(54, 52);
            opendoor_button.TabIndex = 12;
            opendoor_button.Text = "<||>";
            opendoor_button.UseVisualStyleBackColor = true;
            opendoor_button.Click += opendoor_button_Click;
            // 
            // closedoor_button
            // 
            closedoor_button.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            closedoor_button.ForeColor = SystemColors.ActiveCaptionText;
            closedoor_button.Location = new Point(762, 670);
            closedoor_button.Name = "closedoor_button";
            closedoor_button.Size = new Size(56, 52);
            closedoor_button.TabIndex = 13;
            closedoor_button.Text = ">||<";
            closedoor_button.UseVisualStyleBackColor = true;
            closedoor_button.Click += closedoor_button_Click;
            // 
            // liftdown_button
            // 
            liftdown_button.BackColor = SystemColors.ActiveCaptionText;
            liftdown_button.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            liftdown_button.ForeColor = SystemColors.ButtonHighlight;
            liftdown_button.Location = new Point(536, 276);
            liftdown_button.Name = "liftdown_button";
            liftdown_button.Size = new Size(58, 36);
            liftdown_button.TabIndex = 14;
            liftdown_button.Text = "v";
            liftdown_button.TextAlign = ContentAlignment.BottomCenter;
            liftdown_button.UseVisualStyleBackColor = false;
            liftdown_button.Click += liftdown_button_Click;
            // 
            // liftup_button
            // 
            liftup_button.BackColor = SystemColors.ActiveCaptionText;
            liftup_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            liftup_button.Location = new Point(536, 613);
            liftup_button.Name = "liftup_button";
            liftup_button.Size = new Size(65, 42);
            liftup_button.TabIndex = 15;
            liftup_button.Text = "^";
            liftup_button.UseVisualStyleBackColor = false;
            liftup_button.Click += liftup_button_Click;
            // 
            // firstfloor_dooropen
            // 
            firstfloor_dooropen.Tick += firstfloor_dooropen_Tick;
            // 
            // firstfloor_doorclose
            // 
            firstfloor_doorclose.Tick += firstfloor_doorclose_Tick;
            // 
            // groundfloor_dooropen
            // 
            groundfloor_dooropen.Tick += groundfloor_dooropen_Tick;
            // 
            // groundfloor_doorclose
            // 
            groundfloor_doorclose.Tick += groundfloor_doorclose_Tick;
            // 
            // lift_up
            // 
            lift_up.Interval = 25;
            lift_up.Tick += lift_up_Tick;
            // 
            // lift_down
            // 
            lift_down.Interval = 25;
            lift_down.Tick += lift_down_Tick;
            // 
            // timer_close
            // 
            timer_close.Tick += timer_close_Tick;
            // 
            // firstfloor_screen
            // 
            firstfloor_screen.BackColor = SystemColors.MenuText;
            firstfloor_screen.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            firstfloor_screen.ForeColor = Color.Firebrick;
            firstfloor_screen.Location = new Point(129, 276);
            firstfloor_screen.Multiline = true;
            firstfloor_screen.Name = "firstfloor_screen";
            firstfloor_screen.Size = new Size(50, 39);
            firstfloor_screen.TabIndex = 16;
            firstfloor_screen.TextAlign = HorizontalAlignment.Center;
            firstfloor_screen.TextChanged += firstfloor_screen_TextChanged;
            // 
            // groundfloor_screen
            // 
            groundfloor_screen.BackColor = SystemColors.MenuText;
            groundfloor_screen.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            groundfloor_screen.ForeColor = Color.Firebrick;
            groundfloor_screen.Location = new Point(129, 610);
            groundfloor_screen.Multiline = true;
            groundfloor_screen.Name = "groundfloor_screen";
            groundfloor_screen.Size = new Size(49, 40);
            groundfloor_screen.TabIndex = 17;
            groundfloor_screen.TextAlign = HorizontalAlignment.Center;
            groundfloor_screen.TextChanged += groundfloor_screen_TextChanged;
            // 
            // clearlog_button
            // 
            clearlog_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            clearlog_button.ForeColor = Color.Red;
            clearlog_button.Location = new Point(791, 891);
            clearlog_button.Name = "clearlog_button";
            clearlog_button.Size = new Size(129, 56);
            clearlog_button.TabIndex = 19;
            clearlog_button.Text = "Clear Log";
            clearlog_button.UseVisualStyleBackColor = true;
            clearlog_button.Click += clearlog_button_Click;
            // 
            // print_button
            // 
            print_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            print_button.ForeColor = Color.Red;
            print_button.Location = new Point(943, 891);
            print_button.Name = "print_button";
            print_button.Size = new Size(125, 56);
            print_button.TabIndex = 20;
            print_button.Text = "Print";
            print_button.UseVisualStyleBackColor = true;
            print_button.Click += print_button_Click;
            // 
            // Refresh
            // 
            Refresh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Refresh.ForeColor = Color.Red;
            Refresh.Location = new Point(1092, 891);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(123, 56);
            Refresh.TabIndex = 21;
            Refresh.Text = "Refresh";
            Refresh.UseVisualStyleBackColor = true;
            Refresh.Click += exit_button_Click;
            // 
            // bindingSource1
            // 
            bindingSource1.CurrentChanged += bindingSource1_CurrentChanged;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Column3";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Column4";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "ID";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "DATE";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "TIME";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // ACTION
            // 
            ACTION.HeaderText = "ACTION";
            ACTION.MinimumWidth = 6;
            ACTION.Name = "ACTION";
            ACTION.Width = 125;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(865, 425);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(639, 274);
            textBox1.TabIndex = 23;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1602, 1055);
            Controls.Add(textBox1);
            Controls.Add(Refresh);
            Controls.Add(print_button);
            Controls.Add(clearlog_button);
            Controls.Add(groundfloor_screen);
            Controls.Add(firstfloor_screen);
            Controls.Add(liftup_button);
            Controls.Add(liftdown_button);
            Controls.Add(closedoor_button);
            Controls.Add(opendoor_button);
            Controls.Add(groundfloor_button);
            Controls.Add(firstfloor_button);
            Controls.Add(lift_status_screen);
            Controls.Add(pictureBox2);
            Controls.Add(firstfloor_rightdoor);
            Controls.Add(firstfloor_leftdoor);
            Controls.Add(groundfloor_rightdoor);
            Controls.Add(groundfloor_leftdoor);
            Controls.Add(liftbox_inside);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)liftbox_inside).EndInit();
            ((System.ComponentModel.ISupportInitialize)groundfloor_leftdoor).EndInit();
            ((System.ComponentModel.ISupportInitialize)groundfloor_rightdoor).EndInit();
            ((System.ComponentModel.ISupportInitialize)firstfloor_leftdoor).EndInit();
            ((System.ComponentModel.ISupportInitialize)firstfloor_rightdoor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void clearlog_button_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void closedoor_button_Click(object sender, EventArgs e)
        {
            closedoor_button.Enabled = true;

        }



        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox liftbox_inside;
        private PictureBox groundfloor_leftdoor;
        private PictureBox groundfloor_rightdoor;
        private PictureBox firstfloor_leftdoor;
        private PictureBox firstfloor_rightdoor;
        private PictureBox pictureBox2;
        private TextBox lift_status_screen;
        private Button firstfloor_button;
        private Button groundfloor_button;
        private Button opendoor_button;
        private Button closedoor_button;
        private Button liftdown_button;
        private Button liftup_button;
        private System.Windows.Forms.Timer firstfloor_dooropen;
        private System.Windows.Forms.Timer firstfloor_doorclose;
        private System.Windows.Forms.Timer groundfloor_dooropen;
        private System.Windows.Forms.Timer groundfloor_doorclose;
        private System.Windows.Forms.Timer lift_up;
        private System.Windows.Forms.Timer lift_down;
        private System.Windows.Forms.Timer timer_close;
        private TextBox firstfloor_screen;
        private TextBox groundfloor_screen;
        private Button clearlog_button;
        private Button print_button;
        private Button Refresh;
        private BindingSource bindingSource1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn ACTION;
        private TextBox textBox1;
    }
}