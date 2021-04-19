
namespace CMS
{
    partial class Form3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.userControl31 = new CMS.UserControl3();
            this.userControl21 = new CMS.UserControl2();
            this.userControl11 = new CMS.UserControl1();
            this.userControl41 = new CMS.UserControl4();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 571);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 231);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(127, 26);
            this.button5.TabIndex = 4;
            this.button5.Text = "Req/Cert Manager";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 203);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 30);
            this.button4.TabIndex = 3;
            this.button4.Text = "Request";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "Certification";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Employee";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // userControl31
            // 
            this.userControl31.Location = new System.Drawing.Point(133, 95);
            this.userControl31.Name = "userControl31";
            this.userControl31.Size = new System.Drawing.Size(782, 464);
            this.userControl31.TabIndex = 5;
            // 
            // userControl21
            // 
            this.userControl21.Location = new System.Drawing.Point(133, 95);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(782, 464);
            this.userControl21.TabIndex = 4;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(133, 95);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(782, 464);
            this.userControl11.TabIndex = 3;
            // 
            // userControl41
            // 
            this.userControl41.Location = new System.Drawing.Point(133, 95);
            this.userControl41.Name = "userControl41";
            this.userControl41.Size = new System.Drawing.Size(782, 464);
            this.userControl41.TabIndex = 6;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 571);
            this.Controls.Add(this.userControl41);
            this.Controls.Add(this.userControl31);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private UserControl1 userControl11;
        private UserControl2 userControl21;
        private UserControl3 userControl31;
        private UserControl4 userControl41;
    }
}