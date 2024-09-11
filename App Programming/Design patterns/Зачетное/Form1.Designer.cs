namespace Зачетное
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
            this.domainRect = new System.Windows.Forms.DomainUpDown();
            this.domainEllipse = new System.Windows.Forms.DomainUpDown();
            this.domainTracktor = new System.Windows.Forms.DomainUpDown();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Load = new System.Windows.Forms.Button();
            this.button_Info = new System.Windows.Forms.Button();
            this.buttonObjectCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // domainRect
            // 
            this.domainRect.Items.Add("10");
            this.domainRect.Items.Add("9");
            this.domainRect.Items.Add("8");
            this.domainRect.Items.Add("7");
            this.domainRect.Items.Add("6");
            this.domainRect.Items.Add("5");
            this.domainRect.Items.Add("4");
            this.domainRect.Items.Add("3");
            this.domainRect.Items.Add("2");
            this.domainRect.Items.Add("1");
            this.domainRect.Items.Add("0");
            this.domainRect.Location = new System.Drawing.Point(60, 12);
            this.domainRect.Name = "domainRect";
            this.domainRect.Size = new System.Drawing.Size(40, 20);
            this.domainRect.TabIndex = 0;
            this.domainRect.Text = "0";
            this.domainRect.SelectedItemChanged += new System.EventHandler(this.domainRect_SelectedItemChanged);
            // 
            // domainEllipse
            // 
            this.domainEllipse.Items.Add("10");
            this.domainEllipse.Items.Add("9");
            this.domainEllipse.Items.Add("8");
            this.domainEllipse.Items.Add("7");
            this.domainEllipse.Items.Add("6");
            this.domainEllipse.Items.Add("5");
            this.domainEllipse.Items.Add("4");
            this.domainEllipse.Items.Add("3");
            this.domainEllipse.Items.Add("2");
            this.domainEllipse.Items.Add("1");
            this.domainEllipse.Items.Add("0");
            this.domainEllipse.Location = new System.Drawing.Point(60, 52);
            this.domainEllipse.Name = "domainEllipse";
            this.domainEllipse.Size = new System.Drawing.Size(40, 20);
            this.domainEllipse.TabIndex = 1;
            this.domainEllipse.Text = "0";
            this.domainEllipse.SelectedItemChanged += new System.EventHandler(this.domainEllipse_SelectedItemChanged);
            // 
            // domainTracktor
            // 
            this.domainTracktor.Items.Add("10");
            this.domainTracktor.Items.Add("9");
            this.domainTracktor.Items.Add("8");
            this.domainTracktor.Items.Add("7");
            this.domainTracktor.Items.Add("6");
            this.domainTracktor.Items.Add("5");
            this.domainTracktor.Items.Add("4");
            this.domainTracktor.Items.Add("3");
            this.domainTracktor.Items.Add("2");
            this.domainTracktor.Items.Add("1");
            this.domainTracktor.Items.Add("0");
            this.domainTracktor.Location = new System.Drawing.Point(60, 92);
            this.domainTracktor.Name = "domainTracktor";
            this.domainTracktor.Size = new System.Drawing.Size(40, 20);
            this.domainTracktor.TabIndex = 2;
            this.domainTracktor.Text = "0";
            this.domainTracktor.SelectedItemChanged += new System.EventHandler(this.domainTracktor_SelectedItemChanged);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(45, 143);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 3;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Load
            // 
            this.button_Load.Location = new System.Drawing.Point(45, 183);
            this.button_Load.Name = "button_Load";
            this.button_Load.Size = new System.Drawing.Size(75, 23);
            this.button_Load.TabIndex = 4;
            this.button_Load.Text = "Load";
            this.button_Load.UseVisualStyleBackColor = true;
            this.button_Load.Click += new System.EventHandler(this.button_Load_Click);
            // 
            // button_Info
            // 
            this.button_Info.Location = new System.Drawing.Point(45, 221);
            this.button_Info.Name = "button_Info";
            this.button_Info.Size = new System.Drawing.Size(75, 23);
            this.button_Info.TabIndex = 5;
            this.button_Info.Text = "Info";
            this.button_Info.UseVisualStyleBackColor = true;
            this.button_Info.Click += new System.EventHandler(this.button_Info_Click);
            // 
            // buttonObjectCopy
            // 
            this.buttonObjectCopy.Location = new System.Drawing.Point(703, 12);
            this.buttonObjectCopy.Name = "buttonObjectCopy";
            this.buttonObjectCopy.Size = new System.Drawing.Size(75, 23);
            this.buttonObjectCopy.TabIndex = 6;
            this.buttonObjectCopy.Text = "Copy object";
            this.buttonObjectCopy.UseVisualStyleBackColor = true;
            this.buttonObjectCopy.Click += new System.EventHandler(this.buttonObjectCopy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonObjectCopy);
            this.Controls.Add(this.button_Info);
            this.Controls.Add(this.button_Load);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.domainTracktor);
            this.Controls.Add(this.domainEllipse);
            this.Controls.Add(this.domainRect);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DomainUpDown domainRect;
        private System.Windows.Forms.DomainUpDown domainEllipse;
        private System.Windows.Forms.DomainUpDown domainTracktor;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Load;
        private System.Windows.Forms.Button button_Info;
        private System.Windows.Forms.Button buttonObjectCopy;
    }
}

