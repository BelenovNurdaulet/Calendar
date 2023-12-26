namespace Calendar
{
    partial class UserControlDays
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbdays = new System.Windows.Forms.Label();
            this.lblevent = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbdays
            // 
            this.lbdays.AutoSize = true;
            this.lbdays.Font = new System.Drawing.Font("Monotxt_IV25", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbdays.Location = new System.Drawing.Point(14, 16);
            this.lbdays.Name = "lbdays";
            this.lbdays.Size = new System.Drawing.Size(40, 24);
            this.lbdays.TabIndex = 0;
            this.lbdays.Text = "00";
            // 
            // lblevent
            // 
            this.lblevent.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblevent.Location = new System.Drawing.Point(3, 61);
            this.lblevent.Name = "lblevent";
            this.lblevent.Size = new System.Drawing.Size(164, 51);
            this.lblevent.TabIndex = 1;
            this.lblevent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblevent.Click += new System.EventHandler(this.lbevent_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblevent);
            this.Controls.Add(this.lbdays);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(170, 121);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.Click += new System.EventHandler(this.UserControlDays_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbdays;
        private System.Windows.Forms.Label lblevent;
        private System.Windows.Forms.Timer timer1;
    }
}
