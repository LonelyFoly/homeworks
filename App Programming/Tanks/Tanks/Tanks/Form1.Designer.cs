
namespace Tanks
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
            this.timer_turn = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label_player = new System.Windows.Forms.Label();
            this.label_enemy = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_health_player = new System.Windows.Forms.Label();
            this.label_health_enemy = new System.Windows.Forms.Label();
            this.label_ap_1 = new System.Windows.Forms.Label();
            this.label_ap_2 = new System.Windows.Forms.Label();
            this.label_ap_3 = new System.Windows.Forms.Label();
            this.label_aa_1 = new System.Windows.Forms.Label();
            this.label_aa_2 = new System.Windows.Forms.Label();
            this.label_aa_3 = new System.Windows.Forms.Label();
            this.pictureBox_Player = new System.Windows.Forms.PictureBox();
            this.pictureBox_Enemy = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Enemy)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_turn
            // 
            this.timer_turn.Interval = 700;
            this.timer_turn.Tick += new System.EventHandler(this.timer_turn_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(666, 615);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Начать игру";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_player
            // 
            this.label_player.AutoSize = true;
            this.label_player.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_player.Location = new System.Drawing.Point(25, 667);
            this.label_player.Name = "label_player";
            this.label_player.Size = new System.Drawing.Size(63, 32);
            this.label_player.TabIndex = 1;
            this.label_player.Text = "Ты:";
            // 
            // label_enemy
            // 
            this.label_enemy.AutoSize = true;
            this.label_enemy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_enemy.Location = new System.Drawing.Point(481, 667);
            this.label_enemy.Name = "label_enemy";
            this.label_enemy.Size = new System.Drawing.Size(90, 32);
            this.label_enemy.TabIndex = 2;
            this.label_enemy.Text = "Враг:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 714);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Здоровье:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(482, 714);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Здоровье:";
            // 
            // label_health_player
            // 
            this.label_health_player.AutoSize = true;
            this.label_health_player.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_health_player.Location = new System.Drawing.Point(173, 714);
            this.label_health_player.Name = "label_health_player";
            this.label_health_player.Size = new System.Drawing.Size(52, 29);
            this.label_health_player.TabIndex = 5;
            this.label_health_player.Text = "100";
            // 
            // label_health_enemy
            // 
            this.label_health_enemy.AutoSize = true;
            this.label_health_enemy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_health_enemy.Location = new System.Drawing.Point(630, 714);
            this.label_health_enemy.Name = "label_health_enemy";
            this.label_health_enemy.Size = new System.Drawing.Size(52, 29);
            this.label_health_enemy.TabIndex = 6;
            this.label_health_enemy.Text = "100";
            // 
            // label_ap_1
            // 
            this.label_ap_1.AutoSize = true;
            this.label_ap_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ap_1.Location = new System.Drawing.Point(12, 787);
            this.label_ap_1.Name = "label_ap_1";
            this.label_ap_1.Size = new System.Drawing.Size(47, 25);
            this.label_ap_1.TabIndex = 7;
            this.label_ap_1.Text = "Mid";
            // 
            // label_ap_2
            // 
            this.label_ap_2.AutoSize = true;
            this.label_ap_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ap_2.Location = new System.Drawing.Point(83, 787);
            this.label_ap_2.Name = "label_ap_2";
            this.label_ap_2.Size = new System.Drawing.Size(47, 25);
            this.label_ap_2.TabIndex = 8;
            this.label_ap_2.Text = "Mid";
            // 
            // label_ap_3
            // 
            this.label_ap_3.AutoSize = true;
            this.label_ap_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ap_3.Location = new System.Drawing.Point(156, 787);
            this.label_ap_3.Name = "label_ap_3";
            this.label_ap_3.Size = new System.Drawing.Size(47, 25);
            this.label_ap_3.TabIndex = 9;
            this.label_ap_3.Text = "Mid";
            // 
            // label_aa_1
            // 
            this.label_aa_1.AutoSize = true;
            this.label_aa_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_aa_1.Location = new System.Drawing.Point(470, 787);
            this.label_aa_1.Name = "label_aa_1";
            this.label_aa_1.Size = new System.Drawing.Size(47, 25);
            this.label_aa_1.TabIndex = 10;
            this.label_aa_1.Text = "Mid";
            // 
            // label_aa_2
            // 
            this.label_aa_2.AutoSize = true;
            this.label_aa_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_aa_2.Location = new System.Drawing.Point(549, 787);
            this.label_aa_2.Name = "label_aa_2";
            this.label_aa_2.Size = new System.Drawing.Size(47, 25);
            this.label_aa_2.TabIndex = 11;
            this.label_aa_2.Text = "Mid";
            // 
            // label_aa_3
            // 
            this.label_aa_3.AutoSize = true;
            this.label_aa_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_aa_3.Location = new System.Drawing.Point(630, 787);
            this.label_aa_3.Name = "label_aa_3";
            this.label_aa_3.Size = new System.Drawing.Size(47, 25);
            this.label_aa_3.TabIndex = 12;
            this.label_aa_3.Text = "Mid";
            // 
            // pictureBox_Player
            // 
            this.pictureBox_Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Player.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_Player.Name = "pictureBox_Player";
            this.pictureBox_Player.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_Player.TabIndex = 13;
            this.pictureBox_Player.TabStop = false;
            // 
            // pictureBox_Enemy
            // 
            this.pictureBox_Enemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Enemy.Location = new System.Drawing.Point(640, 590);
            this.pictureBox_Enemy.Name = "pictureBox_Enemy";
            this.pictureBox_Enemy.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_Enemy.TabIndex = 14;
            this.pictureBox_Enemy.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Light",
            "Middle",
            "Heavy"});
            this.comboBox1.Location = new System.Drawing.Point(749, 150);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 853);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox_Enemy);
            this.Controls.Add(this.pictureBox_Player);
            this.Controls.Add(this.label_aa_3);
            this.Controls.Add(this.label_aa_2);
            this.Controls.Add(this.label_aa_1);
            this.Controls.Add(this.label_ap_3);
            this.Controls.Add(this.label_ap_2);
            this.Controls.Add(this.label_ap_1);
            this.Controls.Add(this.label_health_enemy);
            this.Controls.Add(this.label_health_player);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_enemy);
            this.Controls.Add(this.label_player);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(900, 900);
            this.MinimumSize = new System.Drawing.Size(900, 900);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Enemy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer_turn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_player;
        private System.Windows.Forms.Label label_enemy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_health_player;
        private System.Windows.Forms.Label label_health_enemy;
        private System.Windows.Forms.Label label_ap_1;
        private System.Windows.Forms.Label label_ap_2;
        private System.Windows.Forms.Label label_ap_3;
        private System.Windows.Forms.Label label_aa_1;
        private System.Windows.Forms.Label label_aa_2;
        private System.Windows.Forms.Label label_aa_3;
        private System.Windows.Forms.PictureBox pictureBox_Player;
        private System.Windows.Forms.PictureBox pictureBox_Enemy;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

