namespace Commission_Price_Calc
{
    partial class MainForm
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
            this.InputHours = new System.Windows.Forms.TextBox();
            this.LabelResult = new System.Windows.Forms.Label();
            this.InputWage = new System.Windows.Forms.TextBox();
            this.ButtonCalculate = new System.Windows.Forms.Button();
            this.LabelHours = new System.Windows.Forms.Label();
            this.LabelWage = new System.Windows.Forms.Label();
            this.InputMinutes = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputHours
            // 
            this.InputHours.Location = new System.Drawing.Point(12, 33);
            this.InputHours.Name = "InputHours";
            this.InputHours.Size = new System.Drawing.Size(61, 20);
            this.InputHours.TabIndex = 0;
            this.InputHours.Text = "Input Hours";
            // 
            // LabelResult
            // 
            this.LabelResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelResult.Location = new System.Drawing.Point(9, 286);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(288, 23);
            this.LabelResult.TabIndex = 1;
            this.LabelResult.Text = "Please enter Hours and Hourly Wage";
            // 
            // InputWage
            // 
            this.InputWage.Location = new System.Drawing.Point(12, 74);
            this.InputWage.Name = "InputWage";
            this.InputWage.Size = new System.Drawing.Size(148, 20);
            this.InputWage.TabIndex = 2;
            this.InputWage.Text = "Input Hourly Wage";
            // 
            // ButtonCalculate
            // 
            this.ButtonCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCalculate.Location = new System.Drawing.Point(303, 286);
            this.ButtonCalculate.Name = "ButtonCalculate";
            this.ButtonCalculate.Size = new System.Drawing.Size(129, 23);
            this.ButtonCalculate.TabIndex = 3;
            this.ButtonCalculate.Text = "Calculate";
            this.ButtonCalculate.UseVisualStyleBackColor = true;
            this.ButtonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // LabelHours
            // 
            this.LabelHours.AutoSize = true;
            this.LabelHours.Location = new System.Drawing.Point(9, 17);
            this.LabelHours.Name = "LabelHours";
            this.LabelHours.Size = new System.Drawing.Size(73, 13);
            this.LabelHours.TabIndex = 4;
            this.LabelHours.Text = "Hours worked";
            // 
            // LabelWage
            // 
            this.LabelWage.AutoSize = true;
            this.LabelWage.Location = new System.Drawing.Point(166, 77);
            this.LabelWage.Name = "LabelWage";
            this.LabelWage.Size = new System.Drawing.Size(57, 13);
            this.LabelWage.TabIndex = 5;
            this.LabelWage.Text = "€ per Hour";
            // 
            // InputMinutes
            // 
            this.InputMinutes.Location = new System.Drawing.Point(91, 33);
            this.InputMinutes.Name = "InputMinutes";
            this.InputMinutes.Size = new System.Drawing.Size(72, 20);
            this.InputMinutes.TabIndex = 6;
            this.InputMinutes.Text = "Input Minutes";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(88, 17);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(82, 13);
            this.label.TabIndex = 7;
            this.label.Text = "Minutes worked";
            // 
            // MainForm
            // 
            this.AcceptButton = this.ButtonCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 321);
            this.Controls.Add(this.label);
            this.Controls.Add(this.InputMinutes);
            this.Controls.Add(this.LabelWage);
            this.Controls.Add(this.LabelHours);
            this.Controls.Add(this.ButtonCalculate);
            this.Controls.Add(this.InputWage);
            this.Controls.Add(this.LabelResult);
            this.Controls.Add(this.InputHours);
            this.MinimumSize = new System.Drawing.Size(460, 360);
            this.Name = "MainForm";
            this.Text = "Basic Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputHours;
        private System.Windows.Forms.Label LabelResult;
        private System.Windows.Forms.TextBox InputWage;
        private System.Windows.Forms.Button ButtonCalculate;
        private System.Windows.Forms.Label LabelHours;
        private System.Windows.Forms.Label LabelWage;
        private System.Windows.Forms.TextBox InputMinutes;
        private System.Windows.Forms.Label label;
    }
}

