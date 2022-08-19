namespace Area
{
    partial class Area
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Area));
            this.lblBase = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblRadius = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.rbtRectangle = new System.Windows.Forms.RadioButton();
            this.rbtTriangle = new System.Windows.Forms.RadioButton();
            this.rbtCircle = new System.Windows.Forms.RadioButton();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.eprInput = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.eprInput)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(12, 47);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(31, 15);
            this.lblBase.TabIndex = 0;
            this.lblBase.Text = "Base";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(12, 84);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(43, 15);
            this.lblHeight.TabIndex = 1;
            this.lblHeight.Text = "Height";
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(12, 119);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(42, 15);
            this.lblRadius.TabIndex = 2;
            this.lblRadius.Text = "Radius";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(12, 177);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(31, 15);
            this.lblArea.TabIndex = 6;
            this.lblArea.Text = "Area";
            // 
            // rbtRectangle
            // 
            this.rbtRectangle.AutoSize = true;
            this.rbtRectangle.Location = new System.Drawing.Point(211, 48);
            this.rbtRectangle.Name = "rbtRectangle";
            this.rbtRectangle.Size = new System.Drawing.Size(77, 19);
            this.rbtRectangle.TabIndex = 7;
            this.rbtRectangle.Text = "Rectangle";
            this.rbtRectangle.UseVisualStyleBackColor = true;
            this.rbtRectangle.CheckedChanged += new System.EventHandler(this.rbtRectangle_CheckedChanged);
            // 
            // rbtTriangle
            // 
            this.rbtTriangle.AutoSize = true;
            this.rbtTriangle.Location = new System.Drawing.Point(211, 82);
            this.rbtTriangle.Name = "rbtTriangle";
            this.rbtTriangle.Size = new System.Drawing.Size(66, 19);
            this.rbtTriangle.TabIndex = 8;
            this.rbtTriangle.Text = "Triangle";
            this.rbtTriangle.UseVisualStyleBackColor = true;
            this.rbtTriangle.CheckedChanged += new System.EventHandler(this.rbtTriangle_CheckedChanged);
            // 
            // rbtCircle
            // 
            this.rbtCircle.AutoSize = true;
            this.rbtCircle.Location = new System.Drawing.Point(211, 117);
            this.rbtCircle.Name = "rbtCircle";
            this.rbtCircle.Size = new System.Drawing.Size(55, 19);
            this.rbtCircle.TabIndex = 9;
            this.rbtCircle.Text = "Circle";
            this.rbtCircle.UseVisualStyleBackColor = true;
            this.rbtCircle.CheckedChanged += new System.EventHandler(this.rbtCircle_CheckedChanged);
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(61, 44);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 23);
            this.txtBase.TabIndex = 10;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(61, 76);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 23);
            this.txtHeight.TabIndex = 11;
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(61, 116);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 23);
            this.txtRadius.TabIndex = 12;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(61, 174);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(112, 23);
            this.txtArea.TabIndex = 13;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(202, 174);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 14;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // eprInput
            // 
            this.eprInput.ContainerControl = this;
            // 
            // Area
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(322, 224);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.rbtCircle);
            this.Controls.Add(this.rbtTriangle);
            this.Controls.Add(this.rbtRectangle);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblRadius);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblBase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Area";
            this.Text = "Area";
            ((System.ComponentModel.ISupportInitialize)(this.eprInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblBase;
        private Label lblHeight;
        private Label lblRadius;
        private Label lblArea;
        private RadioButton rbtRectangle;
        private RadioButton rbtTriangle;
        private RadioButton rbtCircle;
        private TextBox txtBase;
        private TextBox txtHeight;
        private TextBox txtRadius;
        private TextBox txtArea;
        private Button btnCalculate;
        private ErrorProvider eprInput;
    }
}