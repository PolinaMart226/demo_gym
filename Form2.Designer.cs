namespace demo_gym
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Button_adm = new System.Windows.Forms.Button();
            this.Button_tr = new System.Windows.Forms.Button();
            this.Button_k = new System.Windows.Forms.Button();
            this.Button_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_adm
            // 
            this.Button_adm.BackColor = System.Drawing.Color.MistyRose;
            this.Button_adm.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_adm.Location = new System.Drawing.Point(12, 22);
            this.Button_adm.Name = "Button_adm";
            this.Button_adm.Size = new System.Drawing.Size(355, 91);
            this.Button_adm.TabIndex = 0;
            this.Button_adm.Text = "Кнопка для Администратора";
            this.Button_adm.UseVisualStyleBackColor = false;
            this.Button_adm.Click += new System.EventHandler(this.Button_adm_Click);
            // 
            // Button_tr
            // 
            this.Button_tr.BackColor = System.Drawing.Color.MistyRose;
            this.Button_tr.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_tr.Location = new System.Drawing.Point(12, 143);
            this.Button_tr.Name = "Button_tr";
            this.Button_tr.Size = new System.Drawing.Size(355, 91);
            this.Button_tr.TabIndex = 1;
            this.Button_tr.Text = "Кнопка для Тренера";
            this.Button_tr.UseVisualStyleBackColor = false;
            this.Button_tr.Click += new System.EventHandler(this.Button_tr_Click);
            // 
            // Button_k
            // 
            this.Button_k.BackColor = System.Drawing.Color.MistyRose;
            this.Button_k.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_k.Location = new System.Drawing.Point(12, 254);
            this.Button_k.Name = "Button_k";
            this.Button_k.Size = new System.Drawing.Size(355, 91);
            this.Button_k.TabIndex = 2;
            this.Button_k.Text = "Кнопка для Клиента";
            this.Button_k.UseVisualStyleBackColor = false;
            this.Button_k.Click += new System.EventHandler(this.Button_k_Click);
            // 
            // Button_back
            // 
            this.Button_back.BackColor = System.Drawing.Color.MistyRose;
            this.Button_back.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_back.Location = new System.Drawing.Point(894, 513);
            this.Button_back.Name = "Button_back";
            this.Button_back.Size = new System.Drawing.Size(143, 58);
            this.Button_back.TabIndex = 3;
            this.Button_back.Text = "Назад";
            this.Button_back.UseVisualStyleBackColor = false;
            this.Button_back.Click += new System.EventHandler(this.Button_back_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1039, 583);
            this.Controls.Add(this.Button_back);
            this.Controls.Add(this.Button_k);
            this.Controls.Add(this.Button_tr);
            this.Controls.Add(this.Button_adm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная форма";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_adm;
        private System.Windows.Forms.Button Button_tr;
        private System.Windows.Forms.Button Button_k;
        private System.Windows.Forms.Button Button_back;
    }
}