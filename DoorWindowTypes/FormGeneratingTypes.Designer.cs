namespace DoorWindowTypes
{
    partial class FormGeneratingTypes
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
            this.checkBoxPorog = new System.Windows.Forms.CheckBox();
            this.ListBoxDWTypes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // checkBoxPorog
            // 
            this.checkBoxPorog.AutoSize = true;
            this.checkBoxPorog.Location = new System.Drawing.Point(329, 152);
            this.checkBoxPorog.Name = "checkBoxPorog";
            this.checkBoxPorog.Size = new System.Drawing.Size(107, 17);
            this.checkBoxPorog.TabIndex = 0;
            this.checkBoxPorog.Text = "Наличие порога";
            this.checkBoxPorog.UseVisualStyleBackColor = true;
            this.checkBoxPorog.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // ListBoxDWTypes
            // 
            this.ListBoxDWTypes.FormattingEnabled = true;
            this.ListBoxDWTypes.Location = new System.Drawing.Point(12, 12);
            this.ListBoxDWTypes.Name = "ListBoxDWTypes";
            this.ListBoxDWTypes.Size = new System.Drawing.Size(194, 420);
            this.ListBoxDWTypes.Sorted = true;
            this.ListBoxDWTypes.TabIndex = 1;
            // 
            // FormGeneratingTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 541);
            this.Controls.Add(this.ListBoxDWTypes);
            this.Controls.Add(this.checkBoxPorog);
            this.Name = "FormGeneratingTypes";
            this.ShowIcon = false;
            this.Text = "Генератор типоразмеров";
            this.Load += new System.EventHandler(this.FormGeneratingTypes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxPorog;
        private System.Windows.Forms.ListBox ListBoxDWTypes;
    }
}