
namespace healthcheckapp
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.healthystatus = new System.Windows.Forms.ToolStripMenuItem();
            this.inputstatus = new System.Windows.Forms.ToolStripMenuItem();
            this.viewstatus = new System.Windows.Forms.ToolStripMenuItem();
            this.connectapp = new System.Windows.Forms.ToolStripMenuItem();
            this.healthnews = new System.Windows.Forms.ToolStripMenuItem();
            this.iprotect = new System.Windows.Forms.ToolStripMenuItem();
            this.bttmmenu = new System.Windows.Forms.MenuStrip();
            this.home = new System.Windows.Forms.ToolStripMenuItem();
            this.health = new System.Windows.Forms.ToolStripMenuItem();
            this.diet = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exercise = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.bttmmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.healthystatus,
            this.connectapp,
            this.healthnews,
            this.iprotect});
            this.menuStrip1.Location = new System.Drawing.Point(0, 66);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(578, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // healthystatus
            // 
            this.healthystatus.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputstatus,
            this.viewstatus});
            this.healthystatus.Image = global::healthcheckapp.Properties.Resources.solidarity;
            this.healthystatus.Name = "healthystatus";
            this.healthystatus.Size = new System.Drawing.Size(151, 29);
            this.healthystatus.Text = "Health status";
            // 
            // inputstatus
            // 
            this.inputstatus.Image = ((System.Drawing.Image)(resources.GetObject("inputstatus.Image")));
            this.inputstatus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.inputstatus.Name = "inputstatus";
            this.inputstatus.Size = new System.Drawing.Size(261, 34);
            this.inputstatus.Text = "Input health status";
            this.inputstatus.Click += new System.EventHandler(this.inputstatus_Click);
            // 
            // viewstatus
            // 
            this.viewstatus.Image = ((System.Drawing.Image)(resources.GetObject("viewstatus.Image")));
            this.viewstatus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.viewstatus.Name = "viewstatus";
            this.viewstatus.Size = new System.Drawing.Size(261, 34);
            this.viewstatus.Text = "View health status";
            this.viewstatus.Click += new System.EventHandler(this.viewstatus_Click);
            // 
            // connectapp
            // 
            this.connectapp.Image = global::healthcheckapp.Properties.Resources.running;
            this.connectapp.Name = "connectapp";
            this.connectapp.Size = new System.Drawing.Size(149, 29);
            this.connectapp.Text = "Connect app";
            this.connectapp.Click += new System.EventHandler(this.connectapp_Click);
            // 
            // healthnews
            // 
            this.healthnews.Image = global::healthcheckapp.Properties.Resources.copy;
            this.healthnews.Name = "healthnews";
            this.healthnews.Size = new System.Drawing.Size(144, 29);
            this.healthnews.Text = "Health news";
            this.healthnews.Click += new System.EventHandler(this.healthnews_Click);
            // 
            // iprotect
            // 
            this.iprotect.BackColor = System.Drawing.SystemColors.Control;
            this.iprotect.Image = global::healthcheckapp.Properties.Resources.verified;
            this.iprotect.Name = "iprotect";
            this.iprotect.Size = new System.Drawing.Size(124, 29);
            this.iprotect.Text = "iPROTECT";
            this.iprotect.Click += new System.EventHandler(this.iprotect_Click);
            // 
            // bttmmenu
            // 
            this.bttmmenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bttmmenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bttmmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.home,
            this.health,
            this.diet,
            this.exercise});
            this.bttmmenu.Location = new System.Drawing.Point(0, 657);
            this.bttmmenu.Name = "bttmmenu";
            this.bttmmenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.bttmmenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bttmmenu.Size = new System.Drawing.Size(631, 33);
            this.bttmmenu.TabIndex = 1;
            this.bttmmenu.Text = "health";
            // 
            // home
            // 
            this.home.Image = global::healthcheckapp.Properties.Resources.home;
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(97, 29);
            this.home.Text = "Home";
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // health
            // 
            this.health.Image = global::healthcheckapp.Properties.Resources.heart_shape_outline_with_lifeline;
            this.health.Name = "health";
            this.health.Size = new System.Drawing.Size(96, 29);
            this.health.Text = "health";
            this.health.Click += new System.EventHandler(this.health_Click);
            // 
            // diet
            // 
            this.diet.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem1,
            this.optionsToolStripMenuItem1});
            this.diet.Image = global::healthcheckapp.Properties.Resources.diet;
            this.diet.Name = "diet";
            this.diet.Size = new System.Drawing.Size(78, 29);
            this.diet.Text = "diet";
            this.diet.Click += new System.EventHandler(this.diet_Click);
            // 
            // customizeToolStripMenuItem1
            // 
            this.customizeToolStripMenuItem1.Name = "customizeToolStripMenuItem1";
            this.customizeToolStripMenuItem1.Size = new System.Drawing.Size(197, 34);
            this.customizeToolStripMenuItem1.Text = "&Customize";
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(197, 34);
            this.optionsToolStripMenuItem1.Text = "&Options";
            // 
            // exercise
            // 
            this.exercise.Image = global::healthcheckapp.Properties.Resources.fitness;
            this.exercise.Name = "exercise";
            this.exercise.Size = new System.Drawing.Size(109, 29);
            this.exercise.Text = "exercise";
            this.exercise.Click += new System.EventHandler(this.exercise_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::healthcheckapp.Properties.Resources.user1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(124, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Health Checking Daily App";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 105);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(631, 546);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::healthcheckapp.Properties.Resources.icons8_lock_26;
            this.button1.Location = new System.Drawing.Point(587, 657);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(535, 651);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 690);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.bttmmenu);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.bttmmenu.ResumeLayout(false);
            this.bttmmenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem healthystatus;
        private System.Windows.Forms.ToolStripMenuItem inputstatus;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectapp;
        private System.Windows.Forms.ToolStripMenuItem healthnews;
        private System.Windows.Forms.ToolStripMenuItem iprotect;
        private System.Windows.Forms.MenuStrip bttmmenu;
        private System.Windows.Forms.ToolStripMenuItem home;
        private System.Windows.Forms.ToolStripMenuItem health;
        private System.Windows.Forms.ToolStripMenuItem diet;
        private System.Windows.Forms.ToolStripMenuItem exercise;
        private System.Windows.Forms.ToolStripMenuItem viewstatus;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}