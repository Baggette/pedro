namespace pedro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pedro1 = new PictureBox();
            pedro2 = new PictureBox();
            pedro3 = new PictureBox();
            pedro4 = new PictureBox();
            pedrobtn = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            timer4 = new System.Windows.Forms.Timer(components);
            pedro5 = new PictureBox();
            timer5 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pedro1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pedro2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pedro3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pedro4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pedro5).BeginInit();
            SuspendLayout();
            // 
            // pedro1
            // 
            pedro1.Image = (Image)resources.GetObject("pedro1.Image");
            pedro1.Location = new Point(12, 12);
            pedro1.Name = "pedro1";
            pedro1.Size = new Size(383, 202);
            pedro1.SizeMode = PictureBoxSizeMode.StretchImage;
            pedro1.TabIndex = 0;
            pedro1.TabStop = false;
            // 
            // pedro2
            // 
            pedro2.Image = (Image)resources.GetObject("pedro2.Image");
            pedro2.Location = new Point(401, 12);
            pedro2.Name = "pedro2";
            pedro2.Size = new Size(387, 202);
            pedro2.SizeMode = PictureBoxSizeMode.StretchImage;
            pedro2.TabIndex = 1;
            pedro2.TabStop = false;
            // 
            // pedro3
            // 
            pedro3.Image = (Image)resources.GetObject("pedro3.Image");
            pedro3.Location = new Point(12, 220);
            pedro3.Name = "pedro3";
            pedro3.Size = new Size(383, 173);
            pedro3.SizeMode = PictureBoxSizeMode.StretchImage;
            pedro3.TabIndex = 2;
            pedro3.TabStop = false;
            // 
            // pedro4
            // 
            pedro4.Image = (Image)resources.GetObject("pedro4.Image");
            pedro4.Location = new Point(401, 220);
            pedro4.Name = "pedro4";
            pedro4.Size = new Size(387, 173);
            pedro4.SizeMode = PictureBoxSizeMode.StretchImage;
            pedro4.TabIndex = 3;
            pedro4.TabStop = false;
            // 
            // pedrobtn
            // 
            pedrobtn.Location = new Point(12, 399);
            pedrobtn.Name = "pedrobtn";
            pedrobtn.Size = new Size(776, 39);
            pedrobtn.TabIndex = 4;
            pedrobtn.Text = "Pedro-ify me";
            pedrobtn.UseVisualStyleBackColor = true;
            pedrobtn.Click += pedrobtn_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 700;
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Interval = 600;
            timer3.Tick += timer3_Tick;
            // 
            // timer4
            // 
            timer4.Enabled = true;
            timer4.Interval = 800;
            timer4.Tick += timer4_Tick;
            // 
            // pedro5
            // 
            pedro5.Image = (Image)resources.GetObject("pedro5.Image");
            pedro5.Location = new Point(12, 12);
            pedro5.Name = "pedro5";
            pedro5.Size = new Size(776, 381);
            pedro5.SizeMode = PictureBoxSizeMode.StretchImage;
            pedro5.TabIndex = 5;
            pedro5.TabStop = false;
            pedro5.Click += pictureBox1_Click;
            // 
            // timer5
            // 
            timer5.Enabled = true;
            timer5.Interval = 1000;
            timer5.Tick += timer5_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pedro5);
            Controls.Add(pedrobtn);
            Controls.Add(pedro4);
            Controls.Add(pedro3);
            Controls.Add(pedro2);
            Controls.Add(pedro1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pedro1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pedro2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pedro3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pedro4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pedro5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pedro1;
        private PictureBox pedro2;
        private PictureBox pedro3;
        private PictureBox pedro4;
        private Button pedrobtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private PictureBox pedro5;
        private System.Windows.Forms.Timer timer5;
    }
}