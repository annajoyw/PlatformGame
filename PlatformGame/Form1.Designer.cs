namespace PlatformGame
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtScore = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.horizontalPlatform = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.verticalPlatform = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.door = new System.Windows.Forms.PictureBox();
            this.enemyOne = new System.Windows.Forms.PictureBox();
            this.enemyTwo = new System.Windows.Forms.PictureBox();
            this.coin = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.directions = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalPlatform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalPlatform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(406, 9);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(243, 114);
            this.txtScore.TabIndex = 0;
            this.txtScore.Text = "Score: 0";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.Color.PaleGreen;
            this.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBox.Location = new System.Drawing.Point(-8, 531);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(300, 30);
            this.PictureBox.TabIndex = 1;
            this.PictureBox.TabStop = false;
            this.PictureBox.Tag = "platform";
            this.PictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.PaleGreen;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(303, 480);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(228, 30);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "platform";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.PaleGreen;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(162, 412);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(108, 30);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "platform";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.PaleGreen;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Location = new System.Drawing.Point(12, 341);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(108, 30);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "platform";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.PaleGreen;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox5.Location = new System.Drawing.Point(183, 286);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(282, 30);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "platform";
            // 
            // horizontalPlatform
            // 
            this.horizontalPlatform.BackColor = System.Drawing.Color.PaleGreen;
            this.horizontalPlatform.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.horizontalPlatform.Location = new System.Drawing.Point(314, 138);
            this.horizontalPlatform.Name = "horizontalPlatform";
            this.horizontalPlatform.Size = new System.Drawing.Size(228, 30);
            this.horizontalPlatform.TabIndex = 6;
            this.horizontalPlatform.TabStop = false;
            this.horizontalPlatform.Tag = "platform";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.PaleGreen;
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox7.Location = new System.Drawing.Point(12, 200);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(108, 30);
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "platform";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.PaleGreen;
            this.pictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox8.Location = new System.Drawing.Point(-39, 93);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(228, 30);
            this.pictureBox8.TabIndex = 8;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "platform";
            // 
            // verticalPlatform
            // 
            this.verticalPlatform.BackColor = System.Drawing.Color.PaleGreen;
            this.verticalPlatform.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.verticalPlatform.Location = new System.Drawing.Point(554, 394);
            this.verticalPlatform.Name = "verticalPlatform";
            this.verticalPlatform.Size = new System.Drawing.Size(88, 30);
            this.verticalPlatform.TabIndex = 9;
            this.verticalPlatform.TabStop = false;
            this.verticalPlatform.Tag = "platform";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.DarkSlateGray;
            this.player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("player.BackgroundImage")));
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.player.Location = new System.Drawing.Point(40, 485);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(41, 40);
            this.player.TabIndex = 10;
            this.player.TabStop = false;
            // 
            // door
            // 
            this.door.BackColor = System.Drawing.Color.Aquamarine;
            this.door.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.door.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.door.Location = new System.Drawing.Point(12, 12);
            this.door.Name = "door";
            this.door.Size = new System.Drawing.Size(38, 81);
            this.door.TabIndex = 11;
            this.door.TabStop = false;
            // 
            // enemyOne
            // 
            this.enemyOne.BackColor = System.Drawing.Color.Khaki;
            this.enemyOne.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemyOne.BackgroundImage")));
            this.enemyOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.enemyOne.Location = new System.Drawing.Point(406, 249);
            this.enemyOne.Name = "enemyOne";
            this.enemyOne.Size = new System.Drawing.Size(41, 40);
            this.enemyOne.TabIndex = 12;
            this.enemyOne.TabStop = false;
            this.enemyOne.Tag = "enemy";
            // 
            // enemyTwo
            // 
            this.enemyTwo.BackColor = System.Drawing.Color.Khaki;
            this.enemyTwo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemyTwo.BackgroundImage")));
            this.enemyTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.enemyTwo.Location = new System.Drawing.Point(424, 444);
            this.enemyTwo.Name = "enemyTwo";
            this.enemyTwo.Size = new System.Drawing.Size(41, 40);
            this.enemyTwo.TabIndex = 13;
            this.enemyTwo.TabStop = false;
            this.enemyTwo.Tag = "enemy";
            // 
            // coin
            // 
            this.coin.BackColor = System.Drawing.Color.Aquamarine;
            this.coin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.coin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.coin.Location = new System.Drawing.Point(327, 112);
            this.coin.Name = "coin";
            this.coin.Size = new System.Drawing.Size(20, 20);
            this.coin.TabIndex = 14;
            this.coin.TabStop = false;
            this.coin.Tag = "coin";
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Aquamarine;
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox11.Location = new System.Drawing.Point(384, 112);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(20, 20);
            this.pictureBox11.TabIndex = 14;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "coin";
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Aquamarine;
            this.pictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox12.Location = new System.Drawing.Point(498, 112);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(20, 20);
            this.pictureBox12.TabIndex = 14;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "coin";
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.Aquamarine;
            this.pictureBox14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox14.Location = new System.Drawing.Point(406, 260);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(20, 20);
            this.pictureBox14.TabIndex = 15;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Tag = "coin";
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.Aquamarine;
            this.pictureBox15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox15.Location = new System.Drawing.Point(340, 260);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(20, 20);
            this.pictureBox15.TabIndex = 16;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Tag = "coin";
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackColor = System.Drawing.Color.Aquamarine;
            this.pictureBox16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox16.Location = new System.Drawing.Point(272, 260);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(20, 20);
            this.pictureBox16.TabIndex = 17;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.Tag = "coin";
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackColor = System.Drawing.Color.Aquamarine;
            this.pictureBox17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox17.Location = new System.Drawing.Point(209, 260);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(20, 20);
            this.pictureBox17.TabIndex = 18;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.Tag = "coin";
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackColor = System.Drawing.Color.Aquamarine;
            this.pictureBox18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox18.Location = new System.Drawing.Point(496, 454);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(20, 20);
            this.pictureBox18.TabIndex = 19;
            this.pictureBox18.TabStop = false;
            this.pictureBox18.Tag = "coin";
            this.pictureBox18.Click += new System.EventHandler(this.pictureBox18_Click);
            // 
            // pictureBox19
            // 
            this.pictureBox19.BackColor = System.Drawing.Color.Aquamarine;
            this.pictureBox19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox19.Location = new System.Drawing.Point(445, 454);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(20, 20);
            this.pictureBox19.TabIndex = 20;
            this.pictureBox19.TabStop = false;
            this.pictureBox19.Tag = "coin";
            // 
            // pictureBox20
            // 
            this.pictureBox20.BackColor = System.Drawing.Color.Aquamarine;
            this.pictureBox20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox20.Location = new System.Drawing.Point(377, 454);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(20, 20);
            this.pictureBox20.TabIndex = 21;
            this.pictureBox20.TabStop = false;
            this.pictureBox20.Tag = "coin";
            // 
            // pictureBox21
            // 
            this.pictureBox21.BackColor = System.Drawing.Color.Aquamarine;
            this.pictureBox21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox21.Location = new System.Drawing.Point(314, 454);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(20, 20);
            this.pictureBox21.TabIndex = 22;
            this.pictureBox21.TabStop = false;
            this.pictureBox21.Tag = "coin";
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Aquamarine;
            this.pictureBox13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox13.Location = new System.Drawing.Point(445, 112);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(20, 20);
            this.pictureBox13.TabIndex = 14;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Tag = "coin";
            // 
            // pictureBox22
            // 
            this.pictureBox22.BackColor = System.Drawing.Color.Aquamarine;
            this.pictureBox22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox22.Location = new System.Drawing.Point(79, 315);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(20, 20);
            this.pictureBox22.TabIndex = 23;
            this.pictureBox22.TabStop = false;
            this.pictureBox22.Tag = "coin";
            // 
            // pictureBox23
            // 
            this.pictureBox23.BackColor = System.Drawing.Color.Aquamarine;
            this.pictureBox23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox23.Location = new System.Drawing.Point(40, 315);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(20, 20);
            this.pictureBox23.TabIndex = 24;
            this.pictureBox23.TabStop = false;
            this.pictureBox23.Tag = "coin";
            // 
            // pictureBox24
            // 
            this.pictureBox24.BackColor = System.Drawing.Color.Aquamarine;
            this.pictureBox24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox24.Location = new System.Drawing.Point(40, 174);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(20, 20);
            this.pictureBox24.TabIndex = 25;
            this.pictureBox24.TabStop = false;
            this.pictureBox24.Tag = "coin";
            // 
            // pictureBox25
            // 
            this.pictureBox25.BackColor = System.Drawing.Color.Aquamarine;
            this.pictureBox25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox25.Location = new System.Drawing.Point(79, 174);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(20, 20);
            this.pictureBox25.TabIndex = 26;
            this.pictureBox25.TabStop = false;
            this.pictureBox25.Tag = "coin";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Aquamarine;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(583, 210);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "coin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 28;
            // 
            // directions
            // 
            this.directions.AutoSize = true;
            this.directions.BackColor = System.Drawing.Color.Transparent;
            this.directions.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directions.Location = new System.Drawing.Point(60, 17);
            this.directions.Name = "directions";
            this.directions.Size = new System.Drawing.Size(56, 18);
            this.directions.TabIndex = 29;
            this.directions.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(654, 563);
            this.Controls.Add(this.directions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox25);
            this.Controls.Add(this.pictureBox24);
            this.Controls.Add(this.pictureBox22);
            this.Controls.Add(this.pictureBox23);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.pictureBox19);
            this.Controls.Add(this.pictureBox20);
            this.Controls.Add(this.pictureBox21);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.coin);
            this.Controls.Add(this.door);
            this.Controls.Add(this.player);
            this.Controls.Add(this.verticalPlatform);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.horizontalPlatform);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.enemyTwo);
            this.Controls.Add(this.enemyOne);
            this.Name = "Form1";
            this.Text = "PlatformGame";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalPlatform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalPlatform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox horizontalPlatform;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox verticalPlatform;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox door;
        private System.Windows.Forms.PictureBox enemyOne;
        private System.Windows.Forms.PictureBox enemyTwo;
        private System.Windows.Forms.PictureBox coin;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.PictureBox pictureBox21;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox22;
        private System.Windows.Forms.PictureBox pictureBox23;
        private System.Windows.Forms.PictureBox pictureBox24;
        private System.Windows.Forms.PictureBox pictureBox25;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label directions;
    }
}

