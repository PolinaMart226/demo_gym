namespace demo_gym
{
    partial class Form15
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form15));
            this.BtnPrint = new System.Windows.Forms.Button();
            this.Button_back = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.dataGridView_Sessions = new System.Windows.Forms.DataGridView();
            this.Btn_Subscriptions = new System.Windows.Forms.Button();
            this.comboBox_Trainers = new System.Windows.Forms.ComboBox();
            this.labelPartner = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sessions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnPrint
            // 
            this.BtnPrint.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnPrint.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrint.Image")));
            this.BtnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrint.Location = new System.Drawing.Point(20, 524);
            this.BtnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(159, 41);
            this.BtnPrint.TabIndex = 219;
            this.BtnPrint.Text = "Печать";
            this.BtnPrint.UseVisualStyleBackColor = false;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // Button_back
            // 
            this.Button_back.BackColor = System.Drawing.Color.MistyRose;
            this.Button_back.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_back.Location = new System.Drawing.Point(884, 520);
            this.Button_back.Name = "Button_back";
            this.Button_back.Size = new System.Drawing.Size(143, 58);
            this.Button_back.TabIndex = 218;
            this.Button_back.Text = "Назад";
            this.Button_back.UseVisualStyleBackColor = false;
            this.Button_back.Click += new System.EventHandler(this.Button_back_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExit.Location = new System.Drawing.Point(367, 525);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(159, 41);
            this.BtnExit.TabIndex = 217;
            this.BtnExit.Text = "Закрыть";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // dataGridView_Sessions
            // 
            this.dataGridView_Sessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Sessions.Location = new System.Drawing.Point(20, 149);
            this.dataGridView_Sessions.Name = "dataGridView_Sessions";
            this.dataGridView_Sessions.RowHeadersWidth = 51;
            this.dataGridView_Sessions.RowTemplate.Height = 24;
            this.dataGridView_Sessions.Size = new System.Drawing.Size(1007, 357);
            this.dataGridView_Sessions.TabIndex = 216;
            // 
            // Btn_Subscriptions
            // 
            this.Btn_Subscriptions.BackColor = System.Drawing.Color.MistyRose;
            this.Btn_Subscriptions.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Subscriptions.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Subscriptions.Location = new System.Drawing.Point(574, 84);
            this.Btn_Subscriptions.Name = "Btn_Subscriptions";
            this.Btn_Subscriptions.Size = new System.Drawing.Size(336, 55);
            this.Btn_Subscriptions.TabIndex = 215;
            this.Btn_Subscriptions.Text = "Показать список занятий";
            this.Btn_Subscriptions.UseVisualStyleBackColor = false;
            this.Btn_Subscriptions.Click += new System.EventHandler(this.Btn_Subscriptions_Click);
            // 
            // comboBox_Trainers
            // 
            this.comboBox_Trainers.FormattingEnabled = true;
            this.comboBox_Trainers.Location = new System.Drawing.Point(316, 104);
            this.comboBox_Trainers.Name = "comboBox_Trainers";
            this.comboBox_Trainers.Size = new System.Drawing.Size(210, 24);
            this.comboBox_Trainers.TabIndex = 214;
            // 
            // labelPartner
            // 
            this.labelPartner.AutoSize = true;
            this.labelPartner.BackColor = System.Drawing.Color.Transparent;
            this.labelPartner.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.labelPartner.Location = new System.Drawing.Point(60, 97);
            this.labelPartner.Name = "labelPartner";
            this.labelPartner.Size = new System.Drawing.Size(208, 31);
            this.labelPartner.TabIndex = 213;
            this.labelPartner.Text = "Выберите тренера";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(929, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 212;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(884, 39);
            this.label1.TabIndex = 211;
            this.label1.Text = "Просмотр занятий, которые ведет конкретный тренер";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.MistyRose;
            this.Button1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button1.Location = new System.Drawing.Point(720, 521);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(143, 58);
            this.Button1.TabIndex = 220;
            this.Button1.Text = "Назад_т";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.MistyRose;
            this.Button2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button2.Location = new System.Drawing.Point(556, 520);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(143, 58);
            this.Button2.TabIndex = 221;
            this.Button2.Text = "Назад_к";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1047, 591);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.Button_back);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.dataGridView_Sessions);
            this.Controls.Add(this.Btn_Subscriptions);
            this.Controls.Add(this.comboBox_Trainers);
            this.Controls.Add(this.labelPartner);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form15";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр занятий, которые ведет конкретный тренер";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sessions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.Button Button_back;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.DataGridView dataGridView_Sessions;
        private System.Windows.Forms.Button Btn_Subscriptions;
        private System.Windows.Forms.ComboBox comboBox_Trainers;
        private System.Windows.Forms.Label labelPartner;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
    }
}