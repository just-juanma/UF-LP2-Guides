namespace MultipleWindows
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
            this.btnGoMainForm = new System.Windows.Forms.Button();
            this.btnGoForm1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGoMainForm
            // 
            this.btnGoMainForm.Location = new System.Drawing.Point(31, 35);
            this.btnGoMainForm.Name = "btnGoMainForm";
            this.btnGoMainForm.Size = new System.Drawing.Size(107, 23);
            this.btnGoMainForm.TabIndex = 0;
            this.btnGoMainForm.Text = "Go to Main Form";
            this.btnGoMainForm.UseVisualStyleBackColor = true;
            this.btnGoMainForm.Click += new System.EventHandler(this.btnGoMainForm_Click);
            // 
            // btnGoForm1
            // 
            this.btnGoForm1.Location = new System.Drawing.Point(31, 104);
            this.btnGoForm1.Name = "btnGoForm1";
            this.btnGoForm1.Size = new System.Drawing.Size(107, 23);
            this.btnGoForm1.TabIndex = 1;
            this.btnGoForm1.Text = "Go to Form 1";
            this.btnGoForm1.UseVisualStyleBackColor = true;
            this.btnGoForm1.Click += new System.EventHandler(this.btnGoForm1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(177, 146);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 181);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGoForm1);
            this.Controls.Add(this.btnGoMainForm);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnGoMainForm;
        private Button btnGoForm1;
        private Button btnExit;
    }
}