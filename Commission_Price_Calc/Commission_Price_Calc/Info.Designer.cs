namespace Commission_Price_Calc
{
    partial class Info
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
            this.buttonSourceCode = new System.Windows.Forms.Button();
            this.buttonBugs = new System.Windows.Forms.Button();
            this.buttonTumblr = new System.Windows.Forms.Button();
            this.labelText = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSourceCode
            // 
            this.buttonSourceCode.Location = new System.Drawing.Point(12, 61);
            this.buttonSourceCode.Name = "buttonSourceCode";
            this.buttonSourceCode.Size = new System.Drawing.Size(160, 23);
            this.buttonSourceCode.TabIndex = 0;
            this.buttonSourceCode.Text = "Source Code";
            this.buttonSourceCode.UseVisualStyleBackColor = true;
            this.buttonSourceCode.Click += new System.EventHandler(this.buttonSourceCode_Click);
            // 
            // buttonBugs
            // 
            this.buttonBugs.Location = new System.Drawing.Point(12, 90);
            this.buttonBugs.Name = "buttonBugs";
            this.buttonBugs.Size = new System.Drawing.Size(160, 23);
            this.buttonBugs.TabIndex = 1;
            this.buttonBugs.Text = "Report Bugs";
            this.buttonBugs.UseVisualStyleBackColor = true;
            this.buttonBugs.Click += new System.EventHandler(this.buttonBugs_Click);
            // 
            // buttonTumblr
            // 
            this.buttonTumblr.Location = new System.Drawing.Point(12, 119);
            this.buttonTumblr.Name = "buttonTumblr";
            this.buttonTumblr.Size = new System.Drawing.Size(160, 23);
            this.buttonTumblr.TabIndex = 2;
            this.buttonTumblr.Text = "Tumblr";
            this.buttonTumblr.UseVisualStyleBackColor = true;
            this.buttonTumblr.Click += new System.EventHandler(this.buttonTumblr_Click);
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(12, 9);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(328, 13);
            this.labelText.TabIndex = 3;
            this.labelText.Text = "This Program is made by Sleepycharlyy. Commission Price Calculator";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(278, 119);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 155);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.buttonTumblr);
            this.Controls.Add(this.buttonBugs);
            this.Controls.Add(this.buttonSourceCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Info";
            this.Text = "Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSourceCode;
        private System.Windows.Forms.Button buttonBugs;
        private System.Windows.Forms.Button buttonTumblr;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Button buttonOK;
    }
}