namespace demo_gym
{
    partial class Form12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPartner = new System.Windows.Forms.Label();
            this.comboBoxSessions = new System.Windows.Forms.ComboBox();
            this.sessionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbgymDataSet = new demo_gym.dbgymDataSet();
            this.Btn_Sessions = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Button_back = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.dbgymDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sessionsTableAdapter = new demo_gym.dbgymDataSetTableAdapters.sessionsTableAdapter();
            this.Button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgymDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgymDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(841, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 203;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(157, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(636, 39);
            this.label1.TabIndex = 202;
            this.label1.Text = "Список занятий на определенную дату";
            // 
            // labelPartner
            // 
            this.labelPartner.AutoSize = true;
            this.labelPartner.BackColor = System.Drawing.Color.Transparent;
            this.labelPartner.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.labelPartner.Location = new System.Drawing.Point(60, 98);
            this.labelPartner.Name = "labelPartner";
            this.labelPartner.Size = new System.Drawing.Size(167, 31);
            this.labelPartner.TabIndex = 204;
            this.labelPartner.Text = "Выберите дату";
            // 
            // comboBoxSessions
            // 
            this.comboBoxSessions.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sessionsBindingSource, "date", true));
            this.comboBoxSessions.FormattingEnabled = true;
            this.comboBoxSessions.Items.AddRange(new object[] {
            "12.12.2024",
            "01.03.2025",
            "17.02.2025",
            "01.09.2024",
            "03.10.2024",
            "27.02.2024",
            "03.03.2025"});
            this.comboBoxSessions.Location = new System.Drawing.Point(245, 105);
            this.comboBoxSessions.Name = "comboBoxSessions";
            this.comboBoxSessions.Size = new System.Drawing.Size(210, 24);
            this.comboBoxSessions.TabIndex = 205;
            // 
            // sessionsBindingSource
            // 
            this.sessionsBindingSource.DataMember = "sessions";
            this.sessionsBindingSource.DataSource = this.dbgymDataSet;
            // 
            // dbgymDataSet
            // 
            this.dbgymDataSet.DataSetName = "dbgymDataSet";
            this.dbgymDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Btn_Sessions
            // 
            this.Btn_Sessions.BackColor = System.Drawing.Color.MistyRose;
            this.Btn_Sessions.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Sessions.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Sessions.Location = new System.Drawing.Point(478, 87);
            this.Btn_Sessions.Name = "Btn_Sessions";
            this.Btn_Sessions.Size = new System.Drawing.Size(336, 55);
            this.Btn_Sessions.TabIndex = 206;
            this.Btn_Sessions.Text = "Показать список занятий";
            this.Btn_Sessions.UseVisualStyleBackColor = false;
            this.Btn_Sessions.Click += new System.EventHandler(this.Btn_Sessions_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1007, 357);
            this.dataGridView1.TabIndex = 207;
            // 
            // Button_back
            // 
            this.Button_back.BackColor = System.Drawing.Color.MistyRose;
            this.Button_back.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_back.Location = new System.Drawing.Point(884, 521);
            this.Button_back.Name = "Button_back";
            this.Button_back.Size = new System.Drawing.Size(143, 58);
            this.Button_back.TabIndex = 209;
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
            this.BtnExit.Location = new System.Drawing.Point(546, 534);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(159, 41);
            this.BtnExit.TabIndex = 208;
            this.BtnExit.Text = "Закрыть";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // BtnPrint
            // 
            this.BtnPrint.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnPrint.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrint.Image")));
            this.BtnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrint.Location = new System.Drawing.Point(20, 525);
            this.BtnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(159, 41);
            this.BtnPrint.TabIndex = 210;
            this.BtnPrint.Text = "Печать";
            this.BtnPrint.UseVisualStyleBackColor = false;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // dbgymDataSetBindingSource
            // 
            this.dbgymDataSetBindingSource.DataSource = this.dbgymDataSet;
            this.dbgymDataSetBindingSource.Position = 0;
            // 
            // sessionsTableAdapter
            // 
            this.sessionsTableAdapter.ClearBeforeFill = true;
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.MistyRose;
            this.Button1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button1.Location = new System.Drawing.Point(722, 521);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(143, 58);
            this.Button1.TabIndex = 221;
            this.Button1.Text = "Назад_т";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1047, 591);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.Button_back);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_Sessions);
            this.Controls.Add(this.comboBoxSessions);
            this.Controls.Add(this.labelPartner);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form12";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр списка занятий на определенную дату";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgymDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgymDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPartner;
        private System.Windows.Forms.ComboBox comboBoxSessions;
        private System.Windows.Forms.Button Btn_Sessions;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Button_back;
        private System.Windows.Forms.Button BtnExit;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.BindingSource dbgymDataSetBindingSource;
        private dbgymDataSet dbgymDataSet;
        private System.Windows.Forms.BindingSource sessionsBindingSource;
        private dbgymDataSetTableAdapters.sessionsTableAdapter sessionsTableAdapter;
        private System.Windows.Forms.Button Button1;
    }
}