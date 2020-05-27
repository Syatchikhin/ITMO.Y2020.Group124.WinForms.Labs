namespace ITMO.WinForms2020.Syatc00M.Lab03.Exersice2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.customControlTimer22 = new ITMO.WinForms2020.Syatc00M.Lab03.Exersice2.CustomControlTimer2();
            this.SuspendLayout();
            // 
            // customControlTimer22
            // 
            this.customControlTimer22.Location = new System.Drawing.Point(38, 31);
            this.customControlTimer22.Name = "customControlTimer22";
            this.customControlTimer22.Size = new System.Drawing.Size(55, 19);
            this.customControlTimer22.TabIndex = 1;
            this.customControlTimer22.Text = "customControlTimer22";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 450);
            this.Controls.Add(this.customControlTimer22);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControlTimer2 customControlTimer22;
    }
}

