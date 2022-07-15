
namespace Series
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_GlobalInfo = new System.Windows.Forms.TextBox();
            this.textBox_Talk = new System.Windows.Forms.TextBox();
            this.portretBox = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Load = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Birthday = new System.Windows.Forms.Label();
            this.label_Town = new System.Windows.Forms.Label();
            this.label_Hobby = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portretBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(31, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(174, 384);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label_Hobby);
            this.panel1.Controls.Add(this.label_Town);
            this.panel1.Controls.Add(this.label_Birthday);
            this.panel1.Controls.Add(this.label_Name);
            this.panel1.Controls.Add(this.textBox_GlobalInfo);
            this.panel1.Controls.Add(this.textBox_Talk);
            this.panel1.Controls.Add(this.portretBox);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(235, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 391);
            this.panel1.TabIndex = 1;
            // 
            // textBox_GlobalInfo
            // 
            this.textBox_GlobalInfo.Enabled = false;
            this.textBox_GlobalInfo.Location = new System.Drawing.Point(29, 198);
            this.textBox_GlobalInfo.Multiline = true;
            this.textBox_GlobalInfo.Name = "textBox_GlobalInfo";
            this.textBox_GlobalInfo.Size = new System.Drawing.Size(463, 90);
            this.textBox_GlobalInfo.TabIndex = 4;
            this.textBox_GlobalInfo.Visible = false;
            // 
            // textBox_Talk
            // 
            this.textBox_Talk.Enabled = false;
            this.textBox_Talk.Location = new System.Drawing.Point(185, 313);
            this.textBox_Talk.Multiline = true;
            this.textBox_Talk.Name = "textBox_Talk";
            this.textBox_Talk.Size = new System.Drawing.Size(307, 55);
            this.textBox_Talk.TabIndex = 2;
            this.textBox_Talk.Visible = false;
            // 
            // portretBox
            // 
            this.portretBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.portretBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.portretBox.Location = new System.Drawing.Point(29, 15);
            this.portretBox.Name = "portretBox";
            this.portretBox.Size = new System.Drawing.Size(201, 169);
            this.portretBox.TabIndex = 1;
            this.portretBox.TabStop = false;
            this.portretBox.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Salmon;
            this.button3.BackgroundImage = global::Series.Properties.Resources.pencil_edit_icon_5;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(29, 313);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 55);
            this.button3.TabIndex = 0;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.Tomato;
            this.button_Save.Location = new System.Drawing.Point(324, 422);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(151, 59);
            this.button_Save.TabIndex = 2;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Load
            // 
            this.button_Load.BackColor = System.Drawing.Color.Tomato;
            this.button_Load.Location = new System.Drawing.Point(576, 422);
            this.button_Load.Name = "button_Load";
            this.button_Load.Size = new System.Drawing.Size(151, 59);
            this.button_Load.TabIndex = 3;
            this.button_Load.Text = "Загрузить";
            this.button_Load.UseVisualStyleBackColor = false;
            this.button_Load.Click += new System.EventHandler(this.button_Load_Click);
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.Tomato;
            this.button_Add.Location = new System.Drawing.Point(42, 422);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(151, 59);
            this.button_Add.TabIndex = 4;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Enabled = false;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label_Name.Location = new System.Drawing.Point(410, 51);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(56, 18);
            this.label_Name.TabIndex = 5;
            this.label_Name.Text = "          1";
            this.label_Name.Click += new System.EventHandler(this.label_Name_Click);
            // 
            // label_Birthday
            // 
            this.label_Birthday.AutoSize = true;
            this.label_Birthday.Enabled = false;
            this.label_Birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label_Birthday.Location = new System.Drawing.Point(410, 88);
            this.label_Birthday.Name = "label_Birthday";
            this.label_Birthday.Size = new System.Drawing.Size(56, 18);
            this.label_Birthday.TabIndex = 6;
            this.label_Birthday.Text = "          2";
            this.label_Birthday.Click += new System.EventHandler(this.label_Birthday_Click);
            // 
            // label_Town
            // 
            this.label_Town.AutoSize = true;
            this.label_Town.Enabled = false;
            this.label_Town.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label_Town.Location = new System.Drawing.Point(410, 120);
            this.label_Town.Name = "label_Town";
            this.label_Town.Size = new System.Drawing.Size(56, 18);
            this.label_Town.TabIndex = 7;
            this.label_Town.Text = "          3";
            this.label_Town.Click += new System.EventHandler(this.label_Town_Click);
            // 
            // label_Hobby
            // 
            this.label_Hobby.AutoSize = true;
            this.label_Hobby.Enabled = false;
            this.label_Hobby.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label_Hobby.Location = new System.Drawing.Point(410, 152);
            this.label_Hobby.Name = "label_Hobby";
            this.label_Hobby.Size = new System.Drawing.Size(56, 18);
            this.label_Hobby.TabIndex = 8;
            this.label_Hobby.Text = "          4";
            this.label_Hobby.Click += new System.EventHandler(this.label_Hobby_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(256, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "          1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(256, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "          2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(256, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "          3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(256, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "          4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Load);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portretBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_Talk;
        private System.Windows.Forms.PictureBox portretBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Load;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.TextBox textBox_GlobalInfo;
        private System.Windows.Forms.Label label_Town;
        private System.Windows.Forms.Label label_Birthday;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Hobby;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

