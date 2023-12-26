namespace Calendar
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
            this.daycontainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnprevious = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LBDATE = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // daycontainer
            // 
            this.daycontainer.Location = new System.Drawing.Point(16, 114);
            this.daycontainer.Name = "daycontainer";
            this.daycontainer.Size = new System.Drawing.Size(1246, 659);
            this.daycontainer.TabIndex = 0;
            // 
            // btnnext
            // 
            this.btnnext.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnnext.Location = new System.Drawing.Point(1145, 779);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(117, 36);
            this.btnnext.TabIndex = 1;
            this.btnnext.Text = "Вперед";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnprevious
            // 
            this.btnprevious.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprevious.Location = new System.Drawing.Point(1015, 779);
            this.btnprevious.Name = "btnprevious";
            this.btnprevious.Size = new System.Drawing.Size(113, 36);
            this.btnprevious.TabIndex = 2;
            this.btnprevious.Text = "Назад";
            this.btnprevious.UseVisualStyleBackColor = true;
            this.btnprevious.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Пн";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(184, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Вт";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(360, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ср";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(533, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Чт";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(724, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Пт";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(895, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Сб";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(1067, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Вс";
            // 
            // LBDATE
            // 
            this.LBDATE.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBDATE.Location = new System.Drawing.Point(424, 9);
            this.LBDATE.Name = "LBDATE";
            this.LBDATE.Size = new System.Drawing.Size(333, 33);
            this.LBDATE.TabIndex = 10;
            this.LBDATE.Text = "MONTH YEAR";
            this.LBDATE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LBDATE.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 840);
            this.Controls.Add(this.LBDATE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnprevious);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.daycontainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel daycontainer;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnprevious;
        private System.Windows.Forms.Label LBDATE;
    }
}

