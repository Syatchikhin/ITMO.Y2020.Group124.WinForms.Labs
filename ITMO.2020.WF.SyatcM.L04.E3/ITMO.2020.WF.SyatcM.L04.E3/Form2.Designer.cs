namespace ITMO._2020.WF.SyatcM.L04.E3
{
    partial class EditPersonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPersonForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.SecondNameTextBox = new System.Windows.Forms.TextBox();
            this.AgeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.AgeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FirstNameTextBox
            // 
            resources.ApplyResources(this.FirstNameTextBox, "FirstNameTextBox");
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            // 
            // SecondNameTextBox
            // 
            resources.ApplyResources(this.SecondNameTextBox, "SecondNameTextBox");
            this.SecondNameTextBox.Name = "SecondNameTextBox";
            // 
            // AgeNumericUpDown
            // 
            resources.ApplyResources(this.AgeNumericUpDown, "AgeNumericUpDown");
            this.AgeNumericUpDown.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.AgeNumericUpDown.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.AgeNumericUpDown.Name = "AgeNumericUpDown";
            this.AgeNumericUpDown.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // EditPersonForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.AgeNumericUpDown);
            this.Controls.Add(this.SecondNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "EditPersonForm";
            ((System.ComponentModel.ISupportInitialize)(this.AgeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox SecondNameTextBox;
        private System.Windows.Forms.NumericUpDown AgeNumericUpDown;
    }
}