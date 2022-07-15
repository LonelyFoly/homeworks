
namespace The_Zoo
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_OctoSpawn = new System.Windows.Forms.Button();
            this.button_DuckSpawn = new System.Windows.Forms.Button();
            this.button_CatSpawn = new System.Windows.Forms.Button();
            this.button_BatSpawn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button_OctoSpawn
            // 
            this.button_OctoSpawn.Location = new System.Drawing.Point(61, 75);
            this.button_OctoSpawn.Name = "button_OctoSpawn";
            this.button_OctoSpawn.Size = new System.Drawing.Size(75, 23);
            this.button_OctoSpawn.TabIndex = 0;
            this.button_OctoSpawn.Text = "Octopus";
            this.button_OctoSpawn.UseVisualStyleBackColor = true;
            this.button_OctoSpawn.Click += new System.EventHandler(this.button_OctoSpawn_Click);
            // 
            // button_DuckSpawn
            // 
            this.button_DuckSpawn.Location = new System.Drawing.Point(61, 141);
            this.button_DuckSpawn.Name = "button_DuckSpawn";
            this.button_DuckSpawn.Size = new System.Drawing.Size(75, 23);
            this.button_DuckSpawn.TabIndex = 1;
            this.button_DuckSpawn.Text = "Duck";
            this.button_DuckSpawn.UseVisualStyleBackColor = true;
            this.button_DuckSpawn.Click += new System.EventHandler(this.button_DuckSpawn_Click);
            // 
            // button_CatSpawn
            // 
            this.button_CatSpawn.Location = new System.Drawing.Point(61, 215);
            this.button_CatSpawn.Name = "button_CatSpawn";
            this.button_CatSpawn.Size = new System.Drawing.Size(75, 23);
            this.button_CatSpawn.TabIndex = 2;
            this.button_CatSpawn.Text = "Cat";
            this.button_CatSpawn.UseVisualStyleBackColor = true;
            this.button_CatSpawn.Click += new System.EventHandler(this.button_CatSpawn_Click);
            // 
            // button_BatSpawn
            // 
            this.button_BatSpawn.Location = new System.Drawing.Point(61, 290);
            this.button_BatSpawn.Name = "button_BatSpawn";
            this.button_BatSpawn.Size = new System.Drawing.Size(75, 23);
            this.button_BatSpawn.TabIndex = 3;
            this.button_BatSpawn.Text = "Bat";
            this.button_BatSpawn.UseVisualStyleBackColor = true;
            this.button_BatSpawn.Click += new System.EventHandler(this.button_BatSpawn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Location = new System.Drawing.Point(380, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(5, 700);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gray;
            this.pictureBox2.Location = new System.Drawing.Point(575, -36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(5, 700);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(592, 453);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_BatSpawn);
            this.Controls.Add(this.button_CatSpawn);
            this.Controls.Add(this.button_DuckSpawn);
            this.Controls.Add(this.button_OctoSpawn);
            this.MaximumSize = new System.Drawing.Size(610, 3000);
            this.MinimumSize = new System.Drawing.Size(610, 0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_OctoSpawn;
        private System.Windows.Forms.Button button_DuckSpawn;
        private System.Windows.Forms.Button button_CatSpawn;
        private System.Windows.Forms.Button button_BatSpawn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

