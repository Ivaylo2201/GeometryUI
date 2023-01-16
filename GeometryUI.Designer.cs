namespace GeometryUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonHome = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.buttonexit = new System.Windows.Forms.Button();
            this.panelSide = new System.Windows.Forms.Panel();
            this.btnSph = new System.Windows.Forms.Button();
            this.btnCone = new System.Windows.Forms.Button();
            this.btnCube = new System.Windows.Forms.Button();
            this.btnCyl = new System.Windows.Forms.Button();
            this.btnPyr = new System.Windows.Forms.Button();
            this.txtCubeSide = new System.Windows.Forms.TextBox();
            this.labelCubeSide = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCubeS = new System.Windows.Forms.Label();
            this.labelCubeV = new System.Windows.Forms.Label();
            this.btnCubeCalc = new System.Windows.Forms.Button();
            this.panelCube = new System.Windows.Forms.Panel();
            this.pictureBoxCube = new System.Windows.Forms.PictureBox();
            this.txtPyrSide = new System.Windows.Forms.TextBox();
            this.labelPyr1 = new System.Windows.Forms.Label();
            this.labelPyr3 = new System.Windows.Forms.Label();
            this.labelPyr4 = new System.Windows.Forms.Label();
            this.lblPyrS = new System.Windows.Forms.Label();
            this.lblPyrV = new System.Windows.Forms.Label();
            this.pyrCalc = new System.Windows.Forms.Button();
            this.txtPyrHeight = new System.Windows.Forms.TextBox();
            this.labelPyr2 = new System.Windows.Forms.Label();
            this.panelPyr = new System.Windows.Forms.Panel();
            this.picPyr = new System.Windows.Forms.PictureBox();
            this.panelCyl = new System.Windows.Forms.Panel();
            this.label3Cyl = new System.Windows.Forms.Label();
            this.txtCylHeight = new System.Windows.Forms.TextBox();
            this.CylCalc = new System.Windows.Forms.Button();
            this.CylPic = new System.Windows.Forms.PictureBox();
            this.labelVCyl = new System.Windows.Forms.Label();
            this.labelSCyl = new System.Windows.Forms.Label();
            this.labelCyl = new System.Windows.Forms.Label();
            this.label7Cyl = new System.Windows.Forms.Label();
            this.label8Cyl = new System.Windows.Forms.Label();
            this.txtCylRadius = new System.Windows.Forms.TextBox();
            this.panelCone = new System.Windows.Forms.Panel();
            this.label3Cone = new System.Windows.Forms.Label();
            this.txtConeHeight = new System.Windows.Forms.TextBox();
            this.calcCone = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblConeV = new System.Windows.Forms.Label();
            this.lblConeS = new System.Windows.Forms.Label();
            this.label6Cone = new System.Windows.Forms.Label();
            this.label7Cone = new System.Windows.Forms.Label();
            this.label8Cone = new System.Windows.Forms.Label();
            this.txtConeRadius = new System.Windows.Forms.TextBox();
            this.panelSphere = new System.Windows.Forms.Panel();
            this.sphCalc = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblV = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8Sphere = new System.Windows.Forms.Label();
            this.txtSphere = new System.Windows.Forms.TextBox();
            this.WelcomePanel = new System.Windows.Forms.Panel();
            this.lblVer = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelSide.SuspendLayout();
            this.panelCube.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCube)).BeginInit();
            this.panelPyr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPyr)).BeginInit();
            this.panelCyl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CylPic)).BeginInit();
            this.panelCone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSphere.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.WelcomePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.panelTop.Controls.Add(this.buttonHome);
            this.panelTop.Controls.Add(this.btnAbout);
            this.panelTop.Controls.Add(this.buttonexit);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(836, 77);
            this.panelTop.TabIndex = 0;
            // 
            // buttonHome
            // 
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Image = global::GeometryUI.Properties.Resources.Capture;
            this.buttonHome.Location = new System.Drawing.Point(314, 15);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(226, 45);
            this.buttonHome.TabIndex = 3;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnAbout
            // 
            this.btnAbout.BackgroundImage = global::GeometryUI.Properties.Resources.White_circle;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Image = global::GeometryUI.Properties.Resources.circle;
            this.btnAbout.Location = new System.Drawing.Point(12, 12);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(54, 51);
            this.btnAbout.TabIndex = 9;
            this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // buttonexit
            // 
            this.buttonexit.BackgroundImage = global::GeometryUI.Properties.Resources.White_circle;
            this.buttonexit.FlatAppearance.BorderSize = 0;
            this.buttonexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonexit.Image = global::GeometryUI.Properties.Resources.circle;
            this.buttonexit.Location = new System.Drawing.Point(770, 12);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(54, 51);
            this.buttonexit.TabIndex = 8;
            this.buttonexit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonexit.UseVisualStyleBackColor = true;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(16)))), ((int)(((byte)(24)))));
            this.panelSide.Controls.Add(this.btnSph);
            this.panelSide.Controls.Add(this.btnCone);
            this.panelSide.Controls.Add(this.btnCube);
            this.panelSide.Controls.Add(this.btnCyl);
            this.panelSide.Controls.Add(this.btnPyr);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 77);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(200, 436);
            this.panelSide.TabIndex = 1;
            // 
            // btnSph
            // 
            this.btnSph.FlatAppearance.BorderSize = 0;
            this.btnSph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSph.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSph.ForeColor = System.Drawing.Color.White;
            this.btnSph.Image = global::GeometryUI.Properties.Resources.gffg;
            this.btnSph.Location = new System.Drawing.Point(-10, 324);
            this.btnSph.Name = "btnSph";
            this.btnSph.Size = new System.Drawing.Size(210, 64);
            this.btnSph.TabIndex = 6;
            this.btnSph.Text = "  Sphere";
            this.btnSph.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSph.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSph.UseVisualStyleBackColor = true;
            this.btnSph.Click += new System.EventHandler(this.btnSph_Click);
            // 
            // btnCone
            // 
            this.btnCone.FlatAppearance.BorderSize = 0;
            this.btnCone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCone.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCone.ForeColor = System.Drawing.Color.White;
            this.btnCone.Image = global::GeometryUI.Properties.Resources.cne;
            this.btnCone.Location = new System.Drawing.Point(-10, 253);
            this.btnCone.Name = "btnCone";
            this.btnCone.Size = new System.Drawing.Size(210, 64);
            this.btnCone.TabIndex = 5;
            this.btnCone.Text = "  Cone";
            this.btnCone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCone.UseVisualStyleBackColor = true;
            this.btnCone.Click += new System.EventHandler(this.btnCone_Click);
            // 
            // btnCube
            // 
            this.btnCube.FlatAppearance.BorderSize = 0;
            this.btnCube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCube.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCube.ForeColor = System.Drawing.Color.White;
            this.btnCube.Image = global::GeometryUI.Properties.Resources.cube4;
            this.btnCube.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCube.Location = new System.Drawing.Point(-10, 39);
            this.btnCube.Name = "btnCube";
            this.btnCube.Size = new System.Drawing.Size(210, 64);
            this.btnCube.TabIndex = 2;
            this.btnCube.Text = "  Cube";
            this.btnCube.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCube.UseVisualStyleBackColor = true;
            this.btnCube.Click += new System.EventHandler(this.btnCube_Click);
            // 
            // btnCyl
            // 
            this.btnCyl.FlatAppearance.BorderSize = 0;
            this.btnCyl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCyl.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCyl.ForeColor = System.Drawing.Color.White;
            this.btnCyl.Image = global::GeometryUI.Properties.Resources.cyl;
            this.btnCyl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCyl.Location = new System.Drawing.Point(-10, 182);
            this.btnCyl.Name = "btnCyl";
            this.btnCyl.Size = new System.Drawing.Size(210, 64);
            this.btnCyl.TabIndex = 4;
            this.btnCyl.Text = "  Cylinder";
            this.btnCyl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCyl.UseVisualStyleBackColor = true;
            this.btnCyl.Click += new System.EventHandler(this.btnCyl_Click);
            // 
            // btnPyr
            // 
            this.btnPyr.FlatAppearance.BorderSize = 0;
            this.btnPyr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPyr.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPyr.ForeColor = System.Drawing.Color.White;
            this.btnPyr.Image = global::GeometryUI.Properties.Resources.Untitled_11;
            this.btnPyr.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPyr.Location = new System.Drawing.Point(-10, 111);
            this.btnPyr.Name = "btnPyr";
            this.btnPyr.Size = new System.Drawing.Size(210, 64);
            this.btnPyr.TabIndex = 3;
            this.btnPyr.Text = " Pyramid";
            this.btnPyr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPyr.UseVisualStyleBackColor = true;
            this.btnPyr.Click += new System.EventHandler(this.btnPyr_Click);
            // 
            // txtCubeSide
            // 
            this.txtCubeSide.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCubeSide.Location = new System.Drawing.Point(242, 50);
            this.txtCubeSide.Multiline = true;
            this.txtCubeSide.Name = "txtCubeSide";
            this.txtCubeSide.Size = new System.Drawing.Size(79, 52);
            this.txtCubeSide.TabIndex = 0;
            // 
            // labelCubeSide
            // 
            this.labelCubeSide.AutoSize = true;
            this.labelCubeSide.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCubeSide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.labelCubeSide.Location = new System.Drawing.Point(132, 66);
            this.labelCubeSide.Name = "labelCubeSide";
            this.labelCubeSide.Size = new System.Drawing.Size(108, 25);
            this.labelCubeSide.TabIndex = 1;
            this.labelCubeSide.Text = "Cube side:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.label1.Location = new System.Drawing.Point(144, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Area:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.label2.Location = new System.Drawing.Point(119, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Volume:";
            // 
            // labelCubeS
            // 
            this.labelCubeS.AutoSize = true;
            this.labelCubeS.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCubeS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.labelCubeS.Location = new System.Drawing.Point(217, 188);
            this.labelCubeS.Name = "labelCubeS";
            this.labelCubeS.Size = new System.Drawing.Size(0, 25);
            this.labelCubeS.TabIndex = 4;
            // 
            // labelCubeV
            // 
            this.labelCubeV.AutoSize = true;
            this.labelCubeV.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCubeV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.labelCubeV.Location = new System.Drawing.Point(217, 240);
            this.labelCubeV.Name = "labelCubeV";
            this.labelCubeV.Size = new System.Drawing.Size(0, 25);
            this.labelCubeV.TabIndex = 5;
            // 
            // btnCubeCalc
            // 
            this.btnCubeCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(16)))), ((int)(((byte)(24)))));
            this.btnCubeCalc.FlatAppearance.BorderSize = 0;
            this.btnCubeCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCubeCalc.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCubeCalc.ForeColor = System.Drawing.Color.White;
            this.btnCubeCalc.Location = new System.Drawing.Point(199, 324);
            this.btnCubeCalc.Name = "btnCubeCalc";
            this.btnCubeCalc.Size = new System.Drawing.Size(210, 64);
            this.btnCubeCalc.TabIndex = 7;
            this.btnCubeCalc.Text = "Calculate";
            this.btnCubeCalc.UseVisualStyleBackColor = false;
            this.btnCubeCalc.Click += new System.EventHandler(this.btnCubeCalc_Click);
            // 
            // panelCube
            // 
            this.panelCube.BackColor = System.Drawing.Color.White;
            this.panelCube.Controls.Add(this.btnCubeCalc);
            this.panelCube.Controls.Add(this.pictureBoxCube);
            this.panelCube.Controls.Add(this.labelCubeV);
            this.panelCube.Controls.Add(this.labelCubeS);
            this.panelCube.Controls.Add(this.label2);
            this.panelCube.Controls.Add(this.label1);
            this.panelCube.Controls.Add(this.labelCubeSide);
            this.panelCube.Controls.Add(this.txtCubeSide);
            this.panelCube.Location = new System.Drawing.Point(200, 77);
            this.panelCube.Name = "panelCube";
            this.panelCube.Size = new System.Drawing.Size(636, 436);
            this.panelCube.TabIndex = 2;
            this.panelCube.Visible = false;
            // 
            // pictureBoxCube
            // 
            this.pictureBoxCube.Image = global::GeometryUI.Properties.Resources.cube;
            this.pictureBoxCube.Location = new System.Drawing.Point(345, 40);
            this.pictureBoxCube.Name = "pictureBoxCube";
            this.pictureBoxCube.Size = new System.Drawing.Size(256, 256);
            this.pictureBoxCube.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCube.TabIndex = 6;
            this.pictureBoxCube.TabStop = false;
            // 
            // txtPyrSide
            // 
            this.txtPyrSide.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPyrSide.Location = new System.Drawing.Point(242, 50);
            this.txtPyrSide.Multiline = true;
            this.txtPyrSide.Name = "txtPyrSide";
            this.txtPyrSide.Size = new System.Drawing.Size(79, 52);
            this.txtPyrSide.TabIndex = 0;
            // 
            // labelPyr1
            // 
            this.labelPyr1.AutoSize = true;
            this.labelPyr1.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPyr1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.labelPyr1.Location = new System.Drawing.Point(103, 66);
            this.labelPyr1.Name = "labelPyr1";
            this.labelPyr1.Size = new System.Drawing.Size(137, 25);
            this.labelPyr1.TabIndex = 1;
            this.labelPyr1.Text = "Pyramid side:";
            // 
            // labelPyr3
            // 
            this.labelPyr3.AutoSize = true;
            this.labelPyr3.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPyr3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.labelPyr3.Location = new System.Drawing.Point(144, 188);
            this.labelPyr3.Name = "labelPyr3";
            this.labelPyr3.Size = new System.Drawing.Size(62, 25);
            this.labelPyr3.TabIndex = 2;
            this.labelPyr3.Text = "Area:";
            // 
            // labelPyr4
            // 
            this.labelPyr4.AutoSize = true;
            this.labelPyr4.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPyr4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.labelPyr4.Location = new System.Drawing.Point(119, 240);
            this.labelPyr4.Name = "labelPyr4";
            this.labelPyr4.Size = new System.Drawing.Size(86, 25);
            this.labelPyr4.TabIndex = 3;
            this.labelPyr4.Text = "Volume:";
            // 
            // lblPyrS
            // 
            this.lblPyrS.AutoSize = true;
            this.lblPyrS.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPyrS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.lblPyrS.Location = new System.Drawing.Point(217, 188);
            this.lblPyrS.Name = "lblPyrS";
            this.lblPyrS.Size = new System.Drawing.Size(0, 25);
            this.lblPyrS.TabIndex = 4;
            // 
            // lblPyrV
            // 
            this.lblPyrV.AutoSize = true;
            this.lblPyrV.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPyrV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.lblPyrV.Location = new System.Drawing.Point(217, 240);
            this.lblPyrV.Name = "lblPyrV";
            this.lblPyrV.Size = new System.Drawing.Size(0, 25);
            this.lblPyrV.TabIndex = 5;
            // 
            // pyrCalc
            // 
            this.pyrCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(16)))), ((int)(((byte)(24)))));
            this.pyrCalc.FlatAppearance.BorderSize = 0;
            this.pyrCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pyrCalc.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pyrCalc.ForeColor = System.Drawing.Color.White;
            this.pyrCalc.Location = new System.Drawing.Point(199, 324);
            this.pyrCalc.Name = "pyrCalc";
            this.pyrCalc.Size = new System.Drawing.Size(210, 64);
            this.pyrCalc.TabIndex = 7;
            this.pyrCalc.Text = "Calculate";
            this.pyrCalc.UseVisualStyleBackColor = false;
            this.pyrCalc.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPyrHeight
            // 
            this.txtPyrHeight.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPyrHeight.Location = new System.Drawing.Point(242, 107);
            this.txtPyrHeight.Multiline = true;
            this.txtPyrHeight.Name = "txtPyrHeight";
            this.txtPyrHeight.Size = new System.Drawing.Size(79, 52);
            this.txtPyrHeight.TabIndex = 8;
            // 
            // labelPyr2
            // 
            this.labelPyr2.AutoSize = true;
            this.labelPyr2.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPyr2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.labelPyr2.Location = new System.Drawing.Point(83, 123);
            this.labelPyr2.Name = "labelPyr2";
            this.labelPyr2.Size = new System.Drawing.Size(157, 25);
            this.labelPyr2.TabIndex = 9;
            this.labelPyr2.Text = "Pyramid height:";
            // 
            // panelPyr
            // 
            this.panelPyr.BackColor = System.Drawing.Color.White;
            this.panelPyr.Controls.Add(this.labelPyr2);
            this.panelPyr.Controls.Add(this.txtPyrHeight);
            this.panelPyr.Controls.Add(this.pyrCalc);
            this.panelPyr.Controls.Add(this.picPyr);
            this.panelPyr.Controls.Add(this.lblPyrV);
            this.panelPyr.Controls.Add(this.lblPyrS);
            this.panelPyr.Controls.Add(this.labelPyr4);
            this.panelPyr.Controls.Add(this.labelPyr3);
            this.panelPyr.Controls.Add(this.labelPyr1);
            this.panelPyr.Controls.Add(this.txtPyrSide);
            this.panelPyr.Location = new System.Drawing.Point(200, 77);
            this.panelPyr.Name = "panelPyr";
            this.panelPyr.Size = new System.Drawing.Size(636, 436);
            this.panelPyr.TabIndex = 2;
            this.panelPyr.Visible = false;
            // 
            // picPyr
            // 
            this.picPyr.Image = global::GeometryUI.Properties.Resources.pyr;
            this.picPyr.Location = new System.Drawing.Point(345, 40);
            this.picPyr.Name = "picPyr";
            this.picPyr.Size = new System.Drawing.Size(256, 256);
            this.picPyr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPyr.TabIndex = 6;
            this.picPyr.TabStop = false;
            // 
            // panelCyl
            // 
            this.panelCyl.BackColor = System.Drawing.Color.White;
            this.panelCyl.Controls.Add(this.label3Cyl);
            this.panelCyl.Controls.Add(this.txtCylHeight);
            this.panelCyl.Controls.Add(this.CylCalc);
            this.panelCyl.Controls.Add(this.CylPic);
            this.panelCyl.Controls.Add(this.labelVCyl);
            this.panelCyl.Controls.Add(this.labelSCyl);
            this.panelCyl.Controls.Add(this.labelCyl);
            this.panelCyl.Controls.Add(this.label7Cyl);
            this.panelCyl.Controls.Add(this.label8Cyl);
            this.panelCyl.Controls.Add(this.txtCylRadius);
            this.panelCyl.Location = new System.Drawing.Point(200, 77);
            this.panelCyl.Name = "panelCyl";
            this.panelCyl.Size = new System.Drawing.Size(636, 436);
            this.panelCyl.TabIndex = 10;
            this.panelCyl.Visible = false;
            // 
            // label3Cyl
            // 
            this.label3Cyl.AutoSize = true;
            this.label3Cyl.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3Cyl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.label3Cyl.Location = new System.Drawing.Point(82, 123);
            this.label3Cyl.Name = "label3Cyl";
            this.label3Cyl.Size = new System.Drawing.Size(158, 25);
            this.label3Cyl.TabIndex = 9;
            this.label3Cyl.Text = "Cylinder height:";
            // 
            // txtCylHeight
            // 
            this.txtCylHeight.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCylHeight.Location = new System.Drawing.Point(242, 107);
            this.txtCylHeight.Multiline = true;
            this.txtCylHeight.Name = "txtCylHeight";
            this.txtCylHeight.Size = new System.Drawing.Size(79, 52);
            this.txtCylHeight.TabIndex = 8;
            // 
            // CylCalc
            // 
            this.CylCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(16)))), ((int)(((byte)(24)))));
            this.CylCalc.FlatAppearance.BorderSize = 0;
            this.CylCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CylCalc.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CylCalc.ForeColor = System.Drawing.Color.White;
            this.CylCalc.Location = new System.Drawing.Point(199, 324);
            this.CylCalc.Name = "CylCalc";
            this.CylCalc.Size = new System.Drawing.Size(210, 64);
            this.CylCalc.TabIndex = 7;
            this.CylCalc.Text = "Calculate";
            this.CylCalc.UseVisualStyleBackColor = false;
            this.CylCalc.Click += new System.EventHandler(this.CylCalc_Click);
            // 
            // CylPic
            // 
            this.CylPic.Image = global::GeometryUI.Properties.Resources.cylinder;
            this.CylPic.Location = new System.Drawing.Point(394, 33);
            this.CylPic.Name = "CylPic";
            this.CylPic.Size = new System.Drawing.Size(150, 260);
            this.CylPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CylPic.TabIndex = 6;
            this.CylPic.TabStop = false;
            // 
            // labelVCyl
            // 
            this.labelVCyl.AutoSize = true;
            this.labelVCyl.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVCyl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.labelVCyl.Location = new System.Drawing.Point(217, 240);
            this.labelVCyl.Name = "labelVCyl";
            this.labelVCyl.Size = new System.Drawing.Size(0, 25);
            this.labelVCyl.TabIndex = 5;
            // 
            // labelSCyl
            // 
            this.labelSCyl.AutoSize = true;
            this.labelSCyl.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSCyl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.labelSCyl.Location = new System.Drawing.Point(217, 188);
            this.labelSCyl.Name = "labelSCyl";
            this.labelSCyl.Size = new System.Drawing.Size(0, 25);
            this.labelSCyl.TabIndex = 4;
            // 
            // labelCyl
            // 
            this.labelCyl.AutoSize = true;
            this.labelCyl.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCyl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.labelCyl.Location = new System.Drawing.Point(119, 240);
            this.labelCyl.Name = "labelCyl";
            this.labelCyl.Size = new System.Drawing.Size(86, 25);
            this.labelCyl.TabIndex = 3;
            this.labelCyl.Text = "Volume:";
            // 
            // label7Cyl
            // 
            this.label7Cyl.AutoSize = true;
            this.label7Cyl.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7Cyl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.label7Cyl.Location = new System.Drawing.Point(144, 188);
            this.label7Cyl.Name = "label7Cyl";
            this.label7Cyl.Size = new System.Drawing.Size(62, 25);
            this.label7Cyl.TabIndex = 2;
            this.label7Cyl.Text = "Area:";
            // 
            // label8Cyl
            // 
            this.label8Cyl.AutoSize = true;
            this.label8Cyl.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8Cyl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.label8Cyl.Location = new System.Drawing.Point(81, 66);
            this.label8Cyl.Name = "label8Cyl";
            this.label8Cyl.Size = new System.Drawing.Size(159, 25);
            this.label8Cyl.TabIndex = 1;
            this.label8Cyl.Text = "Cylinder radius:";
            // 
            // txtCylRadius
            // 
            this.txtCylRadius.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCylRadius.Location = new System.Drawing.Point(242, 50);
            this.txtCylRadius.Multiline = true;
            this.txtCylRadius.Name = "txtCylRadius";
            this.txtCylRadius.Size = new System.Drawing.Size(79, 52);
            this.txtCylRadius.TabIndex = 0;
            // 
            // panelCone
            // 
            this.panelCone.BackColor = System.Drawing.Color.White;
            this.panelCone.Controls.Add(this.label3Cone);
            this.panelCone.Controls.Add(this.txtConeHeight);
            this.panelCone.Controls.Add(this.calcCone);
            this.panelCone.Controls.Add(this.pictureBox1);
            this.panelCone.Controls.Add(this.lblConeV);
            this.panelCone.Controls.Add(this.lblConeS);
            this.panelCone.Controls.Add(this.label6Cone);
            this.panelCone.Controls.Add(this.label7Cone);
            this.panelCone.Controls.Add(this.label8Cone);
            this.panelCone.Controls.Add(this.txtConeRadius);
            this.panelCone.Location = new System.Drawing.Point(200, 77);
            this.panelCone.Name = "panelCone";
            this.panelCone.Size = new System.Drawing.Size(636, 436);
            this.panelCone.TabIndex = 11;
            this.panelCone.Visible = false;
            // 
            // label3Cone
            // 
            this.label3Cone.AutoSize = true;
            this.label3Cone.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3Cone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.label3Cone.Location = new System.Drawing.Point(112, 123);
            this.label3Cone.Name = "label3Cone";
            this.label3Cone.Size = new System.Drawing.Size(128, 25);
            this.label3Cone.TabIndex = 9;
            this.label3Cone.Text = "Cone height:";
            // 
            // txtConeHeight
            // 
            this.txtConeHeight.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtConeHeight.Location = new System.Drawing.Point(242, 107);
            this.txtConeHeight.Multiline = true;
            this.txtConeHeight.Name = "txtConeHeight";
            this.txtConeHeight.Size = new System.Drawing.Size(79, 52);
            this.txtConeHeight.TabIndex = 8;
            // 
            // calcCone
            // 
            this.calcCone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(16)))), ((int)(((byte)(24)))));
            this.calcCone.FlatAppearance.BorderSize = 0;
            this.calcCone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calcCone.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calcCone.ForeColor = System.Drawing.Color.White;
            this.calcCone.Location = new System.Drawing.Point(199, 324);
            this.calcCone.Name = "calcCone";
            this.calcCone.Size = new System.Drawing.Size(210, 64);
            this.calcCone.TabIndex = 7;
            this.calcCone.Text = "Calculate";
            this.calcCone.UseVisualStyleBackColor = false;
            this.calcCone.Click += new System.EventHandler(this.calcCone_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GeometryUI.Properties.Resources.cone;
            this.pictureBox1.Location = new System.Drawing.Point(380, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 290);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblConeV
            // 
            this.lblConeV.AutoSize = true;
            this.lblConeV.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblConeV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.lblConeV.Location = new System.Drawing.Point(217, 240);
            this.lblConeV.Name = "lblConeV";
            this.lblConeV.Size = new System.Drawing.Size(0, 25);
            this.lblConeV.TabIndex = 5;
            // 
            // lblConeS
            // 
            this.lblConeS.AutoSize = true;
            this.lblConeS.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblConeS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.lblConeS.Location = new System.Drawing.Point(217, 188);
            this.lblConeS.Name = "lblConeS";
            this.lblConeS.Size = new System.Drawing.Size(0, 25);
            this.lblConeS.TabIndex = 4;
            // 
            // label6Cone
            // 
            this.label6Cone.AutoSize = true;
            this.label6Cone.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6Cone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.label6Cone.Location = new System.Drawing.Point(119, 240);
            this.label6Cone.Name = "label6Cone";
            this.label6Cone.Size = new System.Drawing.Size(86, 25);
            this.label6Cone.TabIndex = 3;
            this.label6Cone.Text = "Volume:";
            // 
            // label7Cone
            // 
            this.label7Cone.AutoSize = true;
            this.label7Cone.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7Cone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.label7Cone.Location = new System.Drawing.Point(144, 188);
            this.label7Cone.Name = "label7Cone";
            this.label7Cone.Size = new System.Drawing.Size(62, 25);
            this.label7Cone.TabIndex = 2;
            this.label7Cone.Text = "Area:";
            // 
            // label8Cone
            // 
            this.label8Cone.AutoSize = true;
            this.label8Cone.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8Cone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.label8Cone.Location = new System.Drawing.Point(111, 66);
            this.label8Cone.Name = "label8Cone";
            this.label8Cone.Size = new System.Drawing.Size(129, 25);
            this.label8Cone.TabIndex = 1;
            this.label8Cone.Text = "Cone radius:";
            // 
            // txtConeRadius
            // 
            this.txtConeRadius.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtConeRadius.Location = new System.Drawing.Point(242, 50);
            this.txtConeRadius.Multiline = true;
            this.txtConeRadius.Name = "txtConeRadius";
            this.txtConeRadius.Size = new System.Drawing.Size(79, 52);
            this.txtConeRadius.TabIndex = 0;
            // 
            // panelSphere
            // 
            this.panelSphere.BackColor = System.Drawing.Color.White;
            this.panelSphere.Controls.Add(this.sphCalc);
            this.panelSphere.Controls.Add(this.pictureBox2);
            this.panelSphere.Controls.Add(this.lblV);
            this.panelSphere.Controls.Add(this.lblS);
            this.panelSphere.Controls.Add(this.label6);
            this.panelSphere.Controls.Add(this.label7);
            this.panelSphere.Controls.Add(this.label8Sphere);
            this.panelSphere.Controls.Add(this.txtSphere);
            this.panelSphere.Location = new System.Drawing.Point(200, 77);
            this.panelSphere.Name = "panelSphere";
            this.panelSphere.Size = new System.Drawing.Size(636, 436);
            this.panelSphere.TabIndex = 12;
            this.panelSphere.Visible = false;
            // 
            // sphCalc
            // 
            this.sphCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(16)))), ((int)(((byte)(24)))));
            this.sphCalc.FlatAppearance.BorderSize = 0;
            this.sphCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sphCalc.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sphCalc.ForeColor = System.Drawing.Color.White;
            this.sphCalc.Location = new System.Drawing.Point(199, 324);
            this.sphCalc.Name = "sphCalc";
            this.sphCalc.Size = new System.Drawing.Size(210, 64);
            this.sphCalc.TabIndex = 8;
            this.sphCalc.Text = "Calculate";
            this.sphCalc.UseVisualStyleBackColor = false;
            this.sphCalc.Click += new System.EventHandler(this.sphCalc_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GeometryUI.Properties.Resources.Linalg_great_circle;
            this.pictureBox2.Location = new System.Drawing.Point(372, 66);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(202, 202);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // lblV
            // 
            this.lblV.AutoSize = true;
            this.lblV.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.lblV.Location = new System.Drawing.Point(217, 240);
            this.lblV.Name = "lblV";
            this.lblV.Size = new System.Drawing.Size(0, 25);
            this.lblV.TabIndex = 5;
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.lblS.Location = new System.Drawing.Point(217, 188);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(0, 25);
            this.lblS.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.label6.Location = new System.Drawing.Point(119, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Volume:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.label7.Location = new System.Drawing.Point(144, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Area:";
            // 
            // label8Sphere
            // 
            this.label8Sphere.AutoSize = true;
            this.label8Sphere.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8Sphere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.label8Sphere.Location = new System.Drawing.Point(91, 66);
            this.label8Sphere.Name = "label8Sphere";
            this.label8Sphere.Size = new System.Drawing.Size(149, 25);
            this.label8Sphere.TabIndex = 1;
            this.label8Sphere.Text = "Sphere radius:";
            // 
            // txtSphere
            // 
            this.txtSphere.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSphere.Location = new System.Drawing.Point(242, 50);
            this.txtSphere.Multiline = true;
            this.txtSphere.Name = "txtSphere";
            this.txtSphere.Size = new System.Drawing.Size(79, 52);
            this.txtSphere.TabIndex = 0;
            // 
            // WelcomePanel
            // 
            this.WelcomePanel.BackColor = System.Drawing.Color.White;
            this.WelcomePanel.Controls.Add(this.lblVer);
            this.WelcomePanel.Controls.Add(this.pictureBox3);
            this.WelcomePanel.Controls.Add(this.label3);
            this.WelcomePanel.Location = new System.Drawing.Point(200, 77);
            this.WelcomePanel.Name = "WelcomePanel";
            this.WelcomePanel.Size = new System.Drawing.Size(636, 436);
            this.WelcomePanel.TabIndex = 8;
            // 
            // lblVer
            // 
            this.lblVer.AutoSize = true;
            this.lblVer.Font = new System.Drawing.Font("Bahnschrift", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.lblVer.Location = new System.Drawing.Point(270, 373);
            this.lblVer.Name = "lblVer";
            this.lblVer.Size = new System.Drawing.Size(78, 45);
            this.lblVer.TabIndex = 2;
            this.lblVer.Text = "v1.7";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GeometryUI.Properties.Resources._22617888;
            this.pictureBox3.Location = new System.Drawing.Point(178, 94);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(266, 265);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.label3.Location = new System.Drawing.Point(106, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(438, 45);
            this.label3.TabIndex = 0;
            this.label3.Text = "Welcome to Geometry UI!";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 513);
            this.ControlBox = false;
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.WelcomePanel);
            this.Controls.Add(this.panelSphere);
            this.Controls.Add(this.panelPyr);
            this.Controls.Add(this.panelCone);
            this.Controls.Add(this.panelCyl);
            this.Controls.Add(this.panelCube);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geometry UI";
            this.panelTop.ResumeLayout(false);
            this.panelSide.ResumeLayout(false);
            this.panelCube.ResumeLayout(false);
            this.panelCube.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCube)).EndInit();
            this.panelPyr.ResumeLayout(false);
            this.panelPyr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPyr)).EndInit();
            this.panelCyl.ResumeLayout(false);
            this.panelCyl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CylPic)).EndInit();
            this.panelCone.ResumeLayout(false);
            this.panelCone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSphere.ResumeLayout(false);
            this.panelSphere.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.WelcomePanel.ResumeLayout(false);
            this.WelcomePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Button btnSph;
        private System.Windows.Forms.Button btnCone;
        private System.Windows.Forms.Button btnCube;
        private System.Windows.Forms.Button btnCyl;
        private System.Windows.Forms.Button btnPyr;
        private System.Windows.Forms.TextBox txtCubeSide;
        private System.Windows.Forms.Label labelCubeSide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCubeS;
        private System.Windows.Forms.Label labelCubeV;
        private System.Windows.Forms.PictureBox pictureBoxCube;
        private System.Windows.Forms.Button btnCubeCalc;
        private System.Windows.Forms.Panel panelCube;
        private System.Windows.Forms.Panel panelPyr;
        private System.Windows.Forms.Label labelPyr2;
        private System.Windows.Forms.TextBox txtPyrHeight;
        private System.Windows.Forms.Button pyrCalc;
        private System.Windows.Forms.PictureBox picPyr;
        private System.Windows.Forms.Label lblPyrV;
        private System.Windows.Forms.Label lblPyrS;
        private System.Windows.Forms.Label labelPyr4;
        private System.Windows.Forms.Label labelPyr3;
        private System.Windows.Forms.Label labelPyr1;
        private System.Windows.Forms.TextBox txtPyrSide;
        private System.Windows.Forms.Panel panelCyl;
        private System.Windows.Forms.Label label3Cyl;
        private System.Windows.Forms.TextBox txtCylHeight;
        private System.Windows.Forms.Button CylCalc;
        private System.Windows.Forms.PictureBox CylPic;
        private System.Windows.Forms.Label labelVCyl;
        private System.Windows.Forms.Label labelSCyl;
        private System.Windows.Forms.Label labelCyl;
        private System.Windows.Forms.Label label7Cyl;
        private System.Windows.Forms.Label label8Cyl;
        private System.Windows.Forms.TextBox txtCylRadius;
        private System.Windows.Forms.Panel panelCone;
        private System.Windows.Forms.Label label3Cone;
        private System.Windows.Forms.TextBox txtConeHeight;
        private System.Windows.Forms.Button calcCone;
        private System.Windows.Forms.Label lblConeV;
        private System.Windows.Forms.Label lblConeS;
        private System.Windows.Forms.Label label6Cone;
        private System.Windows.Forms.Label label7Cone;
        private System.Windows.Forms.Label label8Cone;
        private System.Windows.Forms.TextBox txtConeRadius;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelSphere;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblV;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8Sphere;
        private System.Windows.Forms.TextBox txtSphere;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Panel WelcomePanel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblVer;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button sphCalc;
    }
}

