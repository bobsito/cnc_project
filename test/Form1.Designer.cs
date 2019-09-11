namespace test
{
   
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>

        int p = 0;   
        float x = 0;
        float y = 0;
        float z = 0;
        float valX = 0;
        float valY = 0;
        string X;
        string Y;
        string Z;
        string N;

        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SettingButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.PreviewButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.RunButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.YAddButton = new System.Windows.Forms.Button();
            this.YRemButton = new System.Windows.Forms.Button();
            this.XRemButton = new System.Windows.Forms.Button();
            this.XaddButton = new System.Windows.Forms.Button();
            this.ZAddButton = new System.Windows.Forms.Button();
            this.ZRemButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.CloseButton = new System.Windows.Forms.Button();
            this.circularProgressBar2 = new CircularProgressBar.CircularProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.EmgStop = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PauseButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SettingPanel = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SettingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.SettingButton);
            this.panel1.Controls.Add(this.OpenButton);
            this.panel1.Controls.Add(this.ZeroButton);
            this.panel1.Controls.Add(this.PreviewButton);
            this.panel1.Location = new System.Drawing.Point(0, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(72, 398);
            this.panel1.TabIndex = 6;
            // 
            // SettingButton
            // 
            this.SettingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SettingButton.FlatAppearance.BorderSize = 0;
            this.SettingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SettingButton.Location = new System.Drawing.Point(0, 162);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(72, 72);
            this.SettingButton.TabIndex = 42;
            this.SettingButton.Text = "SETTINGS";
            this.SettingButton.UseVisualStyleBackColor = false;
            this.SettingButton.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.OpenButton.FlatAppearance.BorderSize = 0;
            this.OpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.OpenButton.Location = new System.Drawing.Point(0, 6);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(72, 73);
            this.OpenButton.TabIndex = 20;
            this.OpenButton.Text = "OPEN";
            this.OpenButton.UseVisualStyleBackColor = false;
            this.OpenButton.Click += new System.EventHandler(this.button14_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ZeroButton.FlatAppearance.BorderSize = 0;
            this.ZeroButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZeroButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ZeroButton.Location = new System.Drawing.Point(0, 84);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(72, 72);
            this.ZeroButton.TabIndex = 9;
            this.ZeroButton.Text = "ZERO AXIS";
            this.ZeroButton.UseVisualStyleBackColor = false;
            this.ZeroButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // PreviewButton
            // 
            this.PreviewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PreviewButton.FlatAppearance.BorderSize = 0;
            this.PreviewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviewButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PreviewButton.Location = new System.Drawing.Point(0, 240);
            this.PreviewButton.Name = "PreviewButton";
            this.PreviewButton.Size = new System.Drawing.Size(72, 72);
            this.PreviewButton.TabIndex = 11;
            this.PreviewButton.Text = "PREVIEW";
            this.PreviewButton.UseVisualStyleBackColor = false;
            this.PreviewButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.Aqua;
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.HomeButton.Location = new System.Drawing.Point(269, 0);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(72, 72);
            this.HomeButton.TabIndex = 8;
            this.HomeButton.Text = "HOME";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // RunButton
            // 
            this.RunButton.BackColor = System.Drawing.Color.LawnGreen;
            this.RunButton.FlatAppearance.BorderSize = 0;
            this.RunButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RunButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RunButton.Location = new System.Drawing.Point(347, 0);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(72, 73);
            this.RunButton.TabIndex = 7;
            this.RunButton.Text = "RUN";
            this.RunButton.UseVisualStyleBackColor = false;
            this.RunButton.Click += new System.EventHandler(this.button1_Click);
            this.RunButton.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.RunButton.MouseLeave += new System.EventHandler(this.button1_MouseLeave_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(105, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 42);
            this.label2.TabIndex = 13;
            this.label2.Text = "X :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(106, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 42);
            this.label3.TabIndex = 14;
            this.label3.Text = "Y :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(107, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 42);
            this.label4.TabIndex = 15;
            this.label4.Text = "Z :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(160, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 42);
            this.label5.TabIndex = 16;
            this.label5.Text = "0.0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(160, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 42);
            this.label6.TabIndex = 17;
            this.label6.Text = "0.0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(160, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 42);
            this.label7.TabIndex = 18;
            this.label7.Text = "0.0";
            // 
            // YAddButton
            // 
            this.YAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.YAddButton.FlatAppearance.BorderSize = 0;
            this.YAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YAddButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.YAddButton.Location = new System.Drawing.Point(167, 299);
            this.YAddButton.Name = "YAddButton";
            this.YAddButton.Size = new System.Drawing.Size(40, 40);
            this.YAddButton.TabIndex = 19;
            this.YAddButton.Text = "Y+";
            this.YAddButton.UseVisualStyleBackColor = false;
            // 
            // YRemButton
            // 
            this.YRemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.YRemButton.FlatAppearance.BorderSize = 0;
            this.YRemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YRemButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.YRemButton.Location = new System.Drawing.Point(167, 391);
            this.YRemButton.Name = "YRemButton";
            this.YRemButton.Size = new System.Drawing.Size(40, 40);
            this.YRemButton.TabIndex = 20;
            this.YRemButton.Text = "Y-";
            this.YRemButton.UseVisualStyleBackColor = false;
            // 
            // XRemButton
            // 
            this.XRemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.XRemButton.FlatAppearance.BorderSize = 0;
            this.XRemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XRemButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.XRemButton.Location = new System.Drawing.Point(213, 345);
            this.XRemButton.Name = "XRemButton";
            this.XRemButton.Size = new System.Drawing.Size(40, 40);
            this.XRemButton.TabIndex = 21;
            this.XRemButton.Text = "X-";
            this.XRemButton.UseVisualStyleBackColor = false;
            // 
            // XaddButton
            // 
            this.XaddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.XaddButton.FlatAppearance.BorderSize = 0;
            this.XaddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XaddButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.XaddButton.Location = new System.Drawing.Point(121, 345);
            this.XaddButton.Name = "XaddButton";
            this.XaddButton.Size = new System.Drawing.Size(40, 40);
            this.XaddButton.TabIndex = 22;
            this.XaddButton.Text = "X+";
            this.XaddButton.UseVisualStyleBackColor = false;
            // 
            // ZAddButton
            // 
            this.ZAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ZAddButton.FlatAppearance.BorderSize = 0;
            this.ZAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZAddButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ZAddButton.Location = new System.Drawing.Point(270, 299);
            this.ZAddButton.Name = "ZAddButton";
            this.ZAddButton.Size = new System.Drawing.Size(40, 40);
            this.ZAddButton.TabIndex = 23;
            this.ZAddButton.Text = "Z+";
            this.ZAddButton.UseVisualStyleBackColor = false;
            // 
            // ZRemButton
            // 
            this.ZRemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ZRemButton.FlatAppearance.BorderSize = 0;
            this.ZRemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZRemButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ZRemButton.Location = new System.Drawing.Point(270, 391);
            this.ZRemButton.Name = "ZRemButton";
            this.ZRemButton.Size = new System.Drawing.Size(40, 40);
            this.ZRemButton.TabIndex = 24;
            this.ZRemButton.Text = "Z-";
            this.ZRemButton.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel3.Location = new System.Drawing.Point(590, 109);
            this.panel3.Name = "panel3";
            this.panel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel3.Size = new System.Drawing.Size(400, 200);
            this.panel3.TabIndex = 25;
            this.panel3.Visible = false;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.circularProgressBar1.ForeColor = System.Drawing.Color.White;
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(765, 3);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.Aqua;
            this.circularProgressBar1.ProgressWidth = 5;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 2F);
            this.circularProgressBar1.Size = new System.Drawing.Size(70, 70);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TabIndex = 4;
            this.circularProgressBar1.Text = "70";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(5, 6, 10, 10);
            this.circularProgressBar1.Value = 70;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CloseButton.Location = new System.Drawing.Point(917, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(73, 73);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "CLOSE PROGRAM";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.button2_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // circularProgressBar2
            // 
            this.circularProgressBar2.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar2.AnimationSpeed = 500;
            this.circularProgressBar2.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.circularProgressBar2.ForeColor = System.Drawing.Color.White;
            this.circularProgressBar2.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.circularProgressBar2.InnerMargin = 2;
            this.circularProgressBar2.InnerWidth = -1;
            this.circularProgressBar2.Location = new System.Drawing.Point(841, 3);
            this.circularProgressBar2.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar2.Name = "circularProgressBar2";
            this.circularProgressBar2.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.circularProgressBar2.OuterMargin = -25;
            this.circularProgressBar2.OuterWidth = 26;
            this.circularProgressBar2.ProgressColor = System.Drawing.Color.Aqua;
            this.circularProgressBar2.ProgressWidth = 5;
            this.circularProgressBar2.SecondaryFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.circularProgressBar2.Size = new System.Drawing.Size(70, 70);
            this.circularProgressBar2.StartAngle = 270;
            this.circularProgressBar2.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar2.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar2.SubscriptText = "";
            this.circularProgressBar2.SuperscriptColor = System.Drawing.Color.WhiteSmoke;
            this.circularProgressBar2.SuperscriptMargin = new System.Windows.Forms.Padding(5, 15, 0, 0);
            this.circularProgressBar2.SuperscriptText = "%";
            this.circularProgressBar2.TabIndex = 5;
            this.circularProgressBar2.Text = "0";
            this.circularProgressBar2.TextMargin = new System.Windows.Forms.Padding(6, 6, 11, 10);
            this.circularProgressBar2.Value = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("3ds", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "Arnold";
            // 
            // EmgStop
            // 
            this.EmgStop.BackColor = System.Drawing.Color.Firebrick;
            this.EmgStop.FlatAppearance.BorderSize = 0;
            this.EmgStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmgStop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EmgStop.Location = new System.Drawing.Point(503, 0);
            this.EmgStop.Name = "EmgStop";
            this.EmgStop.Size = new System.Drawing.Size(85, 72);
            this.EmgStop.TabIndex = 19;
            this.EmgStop.Text = "EMERGENCY STOP";
            this.EmgStop.UseVisualStyleBackColor = false;
            this.EmgStop.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.circularProgressBar1);
            this.panel2.Controls.Add(this.PauseButton);
            this.panel2.Controls.Add(this.EmgStop);
            this.panel2.Controls.Add(this.RunButton);
            this.panel2.Controls.Add(this.HomeButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.circularProgressBar2);
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(990, 73);
            this.panel2.TabIndex = 12;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // PauseButton
            // 
            this.PauseButton.BackColor = System.Drawing.Color.Orange;
            this.PauseButton.FlatAppearance.BorderSize = 0;
            this.PauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PauseButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PauseButton.Location = new System.Drawing.Point(425, 0);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(72, 73);
            this.PauseButton.TabIndex = 8;
            this.PauseButton.Text = "PAUSE";
            this.PauseButton.UseVisualStyleBackColor = false;
            this.PauseButton.Click += new System.EventHandler(this.button15_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel4.Location = new System.Drawing.Point(78, 313);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(12, 72);
            this.panel4.TabIndex = 26;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel5.Location = new System.Drawing.Point(78, 235);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(12, 72);
            this.panel5.TabIndex = 27;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel6.Location = new System.Drawing.Point(78, 157);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(12, 72);
            this.panel6.TabIndex = 28;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel7.Location = new System.Drawing.Point(78, 79);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(12, 72);
            this.panel7.TabIndex = 29;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel8.Location = new System.Drawing.Point(78, 391);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(12, 72);
            this.panel8.TabIndex = 30;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.DarkGray;
            this.label8.Location = new System.Drawing.Point(96, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 30);
            this.label8.TabIndex = 32;
            this.label8.Text = "POSITION :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.DarkGray;
            this.label9.Location = new System.Drawing.Point(380, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 42);
            this.label9.TabIndex = 33;
            this.label9.Text = "0.0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.DarkGray;
            this.label10.Location = new System.Drawing.Point(380, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 42);
            this.label10.TabIndex = 34;
            this.label10.Text = "0.0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.DarkGray;
            this.label11.Location = new System.Drawing.Point(380, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 42);
            this.label11.TabIndex = 35;
            this.label11.Text = "0.0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.Color.DarkGray;
            this.label12.Location = new System.Drawing.Point(338, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 24);
            this.label12.TabIndex = 36;
            this.label12.Text = "<<";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.Color.DarkGray;
            this.label13.Location = new System.Drawing.Point(338, 143);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 24);
            this.label13.TabIndex = 37;
            this.label13.Text = "<<";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.Color.DarkGray;
            this.label14.Location = new System.Drawing.Point(338, 181);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 24);
            this.label14.TabIndex = 38;
            this.label14.Text = "<<";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.DimGray;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.ForeColor = System.Drawing.Color.LightGray;
            this.richTextBox1.Location = new System.Drawing.Point(697, 73);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(293, 398);
            this.richTextBox1.TabIndex = 39;
            this.richTextBox1.Text = "";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.DarkGray;
            this.label15.Location = new System.Drawing.Point(614, 326);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 13);
            this.label15.TabIndex = 40;
            this.label15.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.ForeColor = System.Drawing.Color.DarkGray;
            this.label16.Location = new System.Drawing.Point(557, 263);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 17);
            this.label16.TabIndex = 41;
            this.label16.Visible = false;
            // 
            // SettingPanel
            // 
            this.SettingPanel.Controls.Add(this.label18);
            this.SettingPanel.Controls.Add(this.comboBox1);
            this.SettingPanel.Controls.Add(this.label17);
            this.SettingPanel.Location = new System.Drawing.Point(96, 73);
            this.SettingPanel.Name = "SettingPanel";
            this.SettingPanel.Size = new System.Drawing.Size(894, 398);
            this.SettingPanel.TabIndex = 42;
            this.SettingPanel.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10"});
            this.comboBox1.Location = new System.Drawing.Point(173, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(26, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(109, 21);
            this.label17.TabIndex = 0;
            this.label17.Text = "Chose Port:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(381, 41);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "label18";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(990, 474);
            this.Controls.Add(this.SettingPanel);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.ZRemButton);
            this.Controls.Add(this.ZAddButton);
            this.Controls.Add(this.XaddButton);
            this.Controls.Add(this.XRemButton);
            this.Controls.Add(this.YRemButton);
            this.Controls.Add(this.YAddButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.98D;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.LightPink;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.SettingPanel.ResumeLayout(false);
            this.SettingPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button PreviewButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ZRemButton;
        private System.Windows.Forms.Button ZAddButton;
        private System.Windows.Forms.Button XaddButton;
        private System.Windows.Forms.Button XRemButton;
        private System.Windows.Forms.Button YRemButton;
        private System.Windows.Forms.Button YAddButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button EmgStop;
        private System.Windows.Forms.Label label1;
        private CircularProgressBar.CircularProgressBar circularProgressBar2;
        private System.Windows.Forms.Button CloseButton;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button SettingButton;
        private System.Windows.Forms.Panel SettingPanel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}

