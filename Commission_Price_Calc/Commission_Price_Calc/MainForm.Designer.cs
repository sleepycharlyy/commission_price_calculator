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
            this.LabelMinutes = new System.Windows.Forms.Label();
            this.TotalTime = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.RadioButton();
            this.Remove = new System.Windows.Forms.RadioButton();
            this.Log = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InputTax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.ButtonAccept = new System.Windows.Forms.Button();
            this.InputBaseCosts = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputHours
            // 
            this.InputHours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InputHours.Location = new System.Drawing.Point(270, 48);
            this.InputHours.Name = "InputHours";
            this.InputHours.Size = new System.Drawing.Size(61, 20);
            this.InputHours.TabIndex = 0;
            this.InputHours.Text = "0";
            // 
            // LabelResult
            // 
            this.LabelResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelResult.Location = new System.Drawing.Point(9, 286);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(277, 23);
            this.LabelResult.TabIndex = 1;
            this.LabelResult.Text = "Result: 0€";
            // 
            // InputWage
            // 
            this.InputWage.Location = new System.Drawing.Point(12, 116);
            this.InputWage.Name = "InputWage";
            this.InputWage.Size = new System.Drawing.Size(57, 20);
            this.InputWage.TabIndex = 2;
            this.InputWage.Text = "10.00";
            // 
            // ButtonCalculate
            // 
            this.ButtonCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCalculate.Location = new System.Drawing.Point(292, 286);
            this.ButtonCalculate.Name = "ButtonCalculate";
            this.ButtonCalculate.Size = new System.Drawing.Size(129, 23);
            this.ButtonCalculate.TabIndex = 3;
            this.ButtonCalculate.Text = "Calculate";
            this.ButtonCalculate.UseVisualStyleBackColor = true;
            this.ButtonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // LabelHours
            // 
            this.LabelHours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelHours.AutoSize = true;
            this.LabelHours.Location = new System.Drawing.Point(267, 32);
            this.LabelHours.Name = "LabelHours";
            this.LabelHours.Size = new System.Drawing.Size(35, 13);
            this.LabelHours.TabIndex = 4;
            this.LabelHours.Text = "Hours";
            // 
            // LabelWage
            // 
            this.LabelWage.AutoSize = true;
            this.LabelWage.Location = new System.Drawing.Point(75, 119);
            this.LabelWage.Name = "LabelWage";
            this.LabelWage.Size = new System.Drawing.Size(58, 13);
            this.LabelWage.TabIndex = 5;
            this.LabelWage.Text = "€ Per Hour";
            // 
            // InputMinutes
            // 
            this.InputMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InputMinutes.Location = new System.Drawing.Point(349, 48);
            this.InputMinutes.Name = "InputMinutes";
            this.InputMinutes.Size = new System.Drawing.Size(72, 20);
            this.InputMinutes.TabIndex = 6;
            this.InputMinutes.Text = "0";
            // 
            // LabelMinutes
            // 
            this.LabelMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelMinutes.AutoSize = true;
            this.LabelMinutes.Location = new System.Drawing.Point(346, 32);
            this.LabelMinutes.Name = "LabelMinutes";
            this.LabelMinutes.Size = new System.Drawing.Size(90, 13);
            this.LabelMinutes.TabIndex = 7;
            this.LabelMinutes.Text = "Minutes (max. 59)";
            // 
            // TotalTime
            // 
            this.TotalTime.AutoSize = true;
            this.TotalTime.Location = new System.Drawing.Point(13, 22);
            this.TotalTime.Name = "TotalTime";
            this.TotalTime.Size = new System.Drawing.Size(133, 13);
            this.TotalTime.TabIndex = 8;
            this.TotalTime.Text = "Total Time Worked: 0h 0m";
            // 
            // Add
            // 
            this.Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Add.AutoSize = true;
            this.Add.Location = new System.Drawing.Point(270, 77);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(44, 17);
            this.Add.TabIndex = 9;
            this.Add.TabStop = true;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // Remove
            // 
            this.Remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Remove.AutoSize = true;
            this.Remove.Location = new System.Drawing.Point(270, 100);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(65, 17);
            this.Remove.TabIndex = 10;
            this.Remove.TabStop = true;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            // 
            // Log
            // 
            this.Log.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Log.Location = new System.Drawing.Point(12, 188);
            this.Log.Multiline = true;
            this.Log.Name = "Log";
            this.Log.ReadOnly = true;
            this.Log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Log.Size = new System.Drawing.Size(420, 92);
            this.Log.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Log:";
            // 
            // InputTax
            // 
            this.InputTax.Location = new System.Drawing.Point(12, 142);
            this.InputTax.Name = "InputTax";
            this.InputTax.Size = new System.Drawing.Size(57, 20);
            this.InputTax.TabIndex = 13;
            this.InputTax.Text = "0.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "% Tax";
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(16, 48);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(75, 23);
            this.ButtonStart.TabIndex = 15;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            // 
            // ButtonStop
            // 
            this.ButtonStop.Location = new System.Drawing.Point(106, 48);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(75, 23);
            this.ButtonStop.TabIndex = 16;
            this.ButtonStop.Text = "Stop";
            this.ButtonStop.UseVisualStyleBackColor = true;
            // 
            // ButtonAccept
            // 
            this.ButtonAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAccept.Location = new System.Drawing.Point(349, 83);
            this.ButtonAccept.Name = "ButtonAccept";
            this.ButtonAccept.Size = new System.Drawing.Size(56, 34);
            this.ButtonAccept.TabIndex = 17;
            this.ButtonAccept.Text = "Accept";
            this.ButtonAccept.UseVisualStyleBackColor = true;
            this.ButtonAccept.Click += new System.EventHandler(this.ButtonAccept_Click);
            // 
            // InputBaseCosts
            // 
            this.InputBaseCosts.Location = new System.Drawing.Point(12, 91);
            this.InputBaseCosts.Name = "InputBaseCosts";
            this.InputBaseCosts.Size = new System.Drawing.Size(57, 20);
            this.InputBaseCosts.TabIndex = 18;
            this.InputBaseCosts.Text = "0.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "€ Base Costs";
            // 
            // MainForm
            // 
            this.AcceptButton = this.ButtonCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 321);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InputBaseCosts);
            this.Controls.Add(this.ButtonAccept);
            this.Controls.Add(this.ButtonStop);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InputTax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.TotalTime);
            this.Controls.Add(this.LabelMinutes);
            this.Controls.Add(this.InputMinutes);
            this.Controls.Add(this.LabelWage);
            this.Controls.Add(this.LabelHours);
            this.Controls.Add(this.ButtonCalculate);
            this.Controls.Add(this.InputWage);
            this.Controls.Add(this.LabelResult);
            this.Controls.Add(this.InputHours);
            this.MinimumSize = new System.Drawing.Size(460, 360);
            this.Name = "MainForm";
            this.Text = "Commission Price Calculator";
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
        private System.Windows.Forms.Label LabelMinutes;
        private System.Windows.Forms.Label TotalTime;
        private System.Windows.Forms.RadioButton Add;
        private System.Windows.Forms.RadioButton Remove;
        private System.Windows.Forms.TextBox Log;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputTax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.Button ButtonAccept;
        private System.Windows.Forms.TextBox InputBaseCosts;
        private System.Windows.Forms.Label label3;
    }
}

