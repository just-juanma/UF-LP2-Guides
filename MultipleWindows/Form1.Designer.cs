namespace MultipleWindows
{
    partial class Form1
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGoForm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGoMainForm
            // 
            this.btnGoMainForm.Location = new System.Drawing.Point(35, 30);
            this.btnGoMainForm.Name = "btnGoMainForm";
            this.btnGoMainForm.Size = new System.Drawing.Size(106, 23);
            this.btnGoMainForm.TabIndex = 0;
            this.btnGoMainForm.Text = "Go to Main Form";
            this.btnGoMainForm.UseVisualStyleBackColor = true;
            this.btnGoMainForm.Click += new System.EventHandler(this.btnGoMainForm_Click);
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
            // btnGoForm2
            // 
            this.btnGoForm2.Location = new System.Drawing.Point(35, 98);
            this.btnGoForm2.Name = "btnGoForm2";
            this.btnGoForm2.Size = new System.Drawing.Size(106, 23);
            this.btnGoForm2.TabIndex = 3;
            this.btnGoForm2.Text = "Go to Form 2";
            this.btnGoForm2.UseVisualStyleBackColor = true;
            this.btnGoForm2.Click += new System.EventHandler(this.btnGoForm2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 181);
            this.Controls.Add(this.btnGoForm2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGoMainForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnGoMainForm;
        private Button btnExit;
        private Button btnGoForm2;
    }
}