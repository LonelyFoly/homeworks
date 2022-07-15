
namespace The_Zoo
{
    partial class DialogForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTalk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox = new System.Windows.Forms.TextBox();
            this.buttonType = new System.Windows.Forms.Button();
            this.buttonFly = new System.Windows.Forms.Button();
            this.buttonWalk = new System.Windows.Forms.Button();
            this.buttonSwim = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(20, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // buttonTalk
            // 
            this.buttonTalk.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.buttonTalk.Location = new System.Drawing.Point(64, 14);
            this.buttonTalk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTalk.Name = "buttonTalk";
            this.buttonTalk.Size = new System.Drawing.Size(64, 32);
            this.buttonTalk.TabIndex = 1;
            this.buttonTalk.Text = "Привет";
            this.buttonTalk.UseVisualStyleBackColor = true;
            this.buttonTalk.Click += new System.EventHandler(this.buttonTalk_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.textBox);
            this.panel1.Controls.Add(this.buttonType);
            this.panel1.Controls.Add(this.buttonFly);
            this.panel1.Controls.Add(this.buttonWalk);
            this.panel1.Controls.Add(this.buttonSwim);
            this.panel1.Controls.Add(this.buttonTalk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 279);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 93);
            this.panel1.TabIndex = 2;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(385, 21);
            this.textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(246, 53);
            this.textBox.TabIndex = 6;
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonType
            // 
            this.buttonType.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.buttonType.Location = new System.Drawing.Point(64, 50);
            this.buttonType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonType.Name = "buttonType";
            this.buttonType.Size = new System.Drawing.Size(64, 32);
            this.buttonType.TabIndex = 5;
            this.buttonType.Text = "Ты кто?";
            this.buttonType.UseVisualStyleBackColor = true;
            this.buttonType.Click += new System.EventHandler(this.buttonType_Click);
            // 
            // buttonFly
            // 
            this.buttonFly.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonFly.Location = new System.Drawing.Point(203, 61);
            this.buttonFly.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonFly.Name = "buttonFly";
            this.buttonFly.Size = new System.Drawing.Size(148, 25);
            this.buttonFly.TabIndex = 4;
            this.buttonFly.Text = "Умеешь летать?";
            this.buttonFly.UseVisualStyleBackColor = true;
            this.buttonFly.Click += new System.EventHandler(this.buttonFly_Click);
            // 
            // buttonWalk
            // 
            this.buttonWalk.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonWalk.Location = new System.Drawing.Point(203, 37);
            this.buttonWalk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonWalk.Name = "buttonWalk";
            this.buttonWalk.Size = new System.Drawing.Size(148, 25);
            this.buttonWalk.TabIndex = 3;
            this.buttonWalk.Text = "Умеешь ходить?";
            this.buttonWalk.UseVisualStyleBackColor = true;
            this.buttonWalk.Click += new System.EventHandler(this.buttonWalk_Click);
            // 
            // buttonSwim
            // 
            this.buttonSwim.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSwim.Location = new System.Drawing.Point(203, 14);
            this.buttonSwim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSwim.Name = "buttonSwim";
            this.buttonSwim.Size = new System.Drawing.Size(148, 25);
            this.buttonSwim.TabIndex = 2;
            this.buttonSwim.Text = "Умеешь плавать?";
            this.buttonSwim.UseVisualStyleBackColor = true;
            this.buttonSwim.Click += new System.EventHandler(this.buttonSwim_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(184, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 233);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(652, 33);
            this.panel2.TabIndex = 4;
            // 
            // DialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(652, 372);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(668, 411);
            this.MinimumSize = new System.Drawing.Size(668, 411);
            this.Name = "DialogForm";
            this.Text = "DialogForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DialogForm_FormClosed);
            this.Load += new System.EventHandler(this.DialogForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTalk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonFly;
        private System.Windows.Forms.Button buttonWalk;
        private System.Windows.Forms.Button buttonSwim;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button buttonType;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
    }
}