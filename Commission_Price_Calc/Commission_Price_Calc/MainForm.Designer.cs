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
            this.components = new System.ComponentModel.Container();
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
            this.LabelLog = new System.Windows.Forms.Label();
            this.InputTax = new System.Windows.Forms.TextBox();
            this.LabelTax = new System.Windows.Forms.Label();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.ButtonAccept = new System.Windows.Forms.Button();
            this.InputBaseCosts = new System.Windows.Forms.TextBox();
            this.LabelBaseCosts = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ButtonReset = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonLoad = new System.Windows.Forms.Button();
            this.labelProject = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPreferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputHours
            // 
            this.InputHours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InputHours.Location = new System.Drawing.Point(246, 48);
            this.InputHours.Name = "InputHours";
            this.InputHours.Size = new System.Drawing.Size(61, 20);
            this.InputHours.TabIndex = 0;
            this.InputHours.Text = "0";
            // 
            // LabelResult
            // 
            this.LabelResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelResult.Location = new System.Drawing.Point(9, 327);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(277, 23);
            this.LabelResult.TabIndex = 1;
            this.LabelResult.Text = "Result: 0€";
            // 
            // InputWage
            // 
            this.InputWage.Location = new System.Drawing.Point(12, 138);
            this.InputWage.Name = "InputWage";
            this.InputWage.Size = new System.Drawing.Size(57, 20);
            this.InputWage.TabIndex = 2;
            this.InputWage.Text = "10.00";
            // 
            // ButtonCalculate
            // 
            this.ButtonCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCalculate.Location = new System.Drawing.Point(292, 327);
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
            this.LabelHours.Location = new System.Drawing.Point(251, 32);
            this.LabelHours.Name = "LabelHours";
            this.LabelHours.Size = new System.Drawing.Size(35, 13);
            this.LabelHours.TabIndex = 4;
            this.LabelHours.Text = "Hours";
            // 
            // LabelWage
            // 
            this.LabelWage.AutoSize = true;
            this.LabelWage.Location = new System.Drawing.Point(75, 141);
            this.LabelWage.Name = "LabelWage";
            this.LabelWage.Size = new System.Drawing.Size(58, 13);
            this.LabelWage.TabIndex = 5;
            this.LabelWage.Text = "€ Per Hour";
            // 
            // InputMinutes
            // 
            this.InputMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InputMinutes.Location = new System.Drawing.Point(337, 48);
            this.InputMinutes.Name = "InputMinutes";
            this.InputMinutes.Size = new System.Drawing.Size(72, 20);
            this.InputMinutes.TabIndex = 6;
            this.InputMinutes.Text = "0";
            // 
            // LabelMinutes
            // 
            this.LabelMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelMinutes.AutoSize = true;
            this.LabelMinutes.Location = new System.Drawing.Point(342, 32);
            this.LabelMinutes.Name = "LabelMinutes";
            this.LabelMinutes.Size = new System.Drawing.Size(90, 13);
            this.LabelMinutes.TabIndex = 7;
            this.LabelMinutes.Text = "Minutes (max. 59)";
            // 
            // TotalTime
            // 
            this.TotalTime.AutoSize = true;
            this.TotalTime.Location = new System.Drawing.Point(7, 51);
            this.TotalTime.Name = "TotalTime";
            this.TotalTime.Size = new System.Drawing.Size(147, 13);
            this.TotalTime.TabIndex = 8;
            this.TotalTime.Text = "Total Time Worked: 0h 0m 0s";
            // 
            // Add
            // 
            this.Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Add.AutoSize = true;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Location = new System.Drawing.Point(3, 26);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(67, 17);
            this.Add.TabIndex = 9;
            this.Add.TabStop = true;
            this.Add.Text = "Add        ";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // Remove
            // 
            this.Remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Remove.AutoSize = true;
            this.Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove.Location = new System.Drawing.Point(3, 3);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(64, 17);
            this.Remove.TabIndex = 10;
            this.Remove.TabStop = true;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            // 
            // Log
            // 
            this.Log.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Log.Location = new System.Drawing.Point(12, 229);
            this.Log.Multiline = true;
            this.Log.Name = "Log";
            this.Log.ReadOnly = true;
            this.Log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Log.Size = new System.Drawing.Size(420, 92);
            this.Log.TabIndex = 11;
            // 
            // LabelLog
            // 
            this.LabelLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelLog.AutoSize = true;
            this.LabelLog.Location = new System.Drawing.Point(12, 213);
            this.LabelLog.Name = "LabelLog";
            this.LabelLog.Size = new System.Drawing.Size(28, 13);
            this.LabelLog.TabIndex = 12;
            this.LabelLog.Text = "Log:";
            // 
            // InputTax
            // 
            this.InputTax.Location = new System.Drawing.Point(12, 164);
            this.InputTax.Name = "InputTax";
            this.InputTax.Size = new System.Drawing.Size(57, 20);
            this.InputTax.TabIndex = 13;
            this.InputTax.Text = "0.0";
            // 
            // LabelTax
            // 
            this.LabelTax.AutoSize = true;
            this.LabelTax.Location = new System.Drawing.Point(75, 167);
            this.LabelTax.Name = "LabelTax";
            this.LabelTax.Size = new System.Drawing.Size(36, 13);
            this.LabelTax.TabIndex = 14;
            this.LabelTax.Text = "% Tax";
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(10, 70);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(75, 23);
            this.ButtonStart.TabIndex = 15;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ButtonStop
            // 
            this.ButtonStop.Enabled = false;
            this.ButtonStop.Location = new System.Drawing.Point(91, 70);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(75, 23);
            this.ButtonStop.TabIndex = 16;
            this.ButtonStop.Text = "Stop";
            this.ButtonStop.UseVisualStyleBackColor = true;
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // ButtonAccept
            // 
            this.ButtonAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAccept.Location = new System.Drawing.Point(337, 88);
            this.ButtonAccept.Name = "ButtonAccept";
            this.ButtonAccept.Size = new System.Drawing.Size(84, 47);
            this.ButtonAccept.TabIndex = 17;
            this.ButtonAccept.Text = "Accept";
            this.ButtonAccept.UseVisualStyleBackColor = true;
            this.ButtonAccept.Click += new System.EventHandler(this.ButtonAccept_Click);
            // 
            // InputBaseCosts
            // 
            this.InputBaseCosts.Location = new System.Drawing.Point(12, 110);
            this.InputBaseCosts.Name = "InputBaseCosts";
            this.InputBaseCosts.Size = new System.Drawing.Size(57, 20);
            this.InputBaseCosts.TabIndex = 18;
            this.InputBaseCosts.Text = "0.0";
            // 
            // LabelBaseCosts
            // 
            this.LabelBaseCosts.AutoSize = true;
            this.LabelBaseCosts.Location = new System.Drawing.Point(75, 115);
            this.LabelBaseCosts.Name = "LabelBaseCosts";
            this.LabelBaseCosts.Size = new System.Drawing.Size(69, 13);
            this.LabelBaseCosts.TabIndex = 19;
            this.LabelBaseCosts.Text = "€ Base Costs";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.Remove);
            this.flowLayoutPanel1.Controls.Add(this.Add);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(240, 88);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(91, 47);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ButtonReset
            // 
            this.ButtonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonReset.Location = new System.Drawing.Point(240, 157);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(181, 23);
            this.ButtonReset.TabIndex = 21;
            this.ButtonReset.Text = "Reset";
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSave.Location = new System.Drawing.Point(240, 200);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(84, 23);
            this.ButtonSave.TabIndex = 22;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonLoad
            // 
            this.ButtonLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonLoad.Location = new System.Drawing.Point(337, 200);
            this.ButtonLoad.Name = "ButtonLoad";
            this.ButtonLoad.Size = new System.Drawing.Size(84, 23);
            this.ButtonLoad.TabIndex = 23;
            this.ButtonLoad.Text = "Load";
            this.ButtonLoad.UseVisualStyleBackColor = true;
            this.ButtonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // labelProject
            // 
            this.labelProject.AutoSize = true;
            this.labelProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProject.Location = new System.Drawing.Point(9, 30);
            this.labelProject.Name = "labelProject";
            this.labelProject.Size = new System.Drawing.Size(73, 15);
            this.labelProject.TabIndex = 24;
            this.labelProject.Text = "New Project";
            this.labelProject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(444, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveProjectToolStripMenuItem,
            this.loadProjectToolStripMenuItem,
            this.closeProgramToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveProjectToolStripMenuItem
            // 
            this.saveProjectToolStripMenuItem.Name = "saveProjectToolStripMenuItem";
            this.saveProjectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveProjectToolStripMenuItem.Text = "Save Project";
            this.saveProjectToolStripMenuItem.Click += new System.EventHandler(this.saveProjectToolStripMenuItem_Click);
            // 
            // loadProjectToolStripMenuItem
            // 
            this.loadProjectToolStripMenuItem.Name = "loadProjectToolStripMenuItem";
            this.loadProjectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadProjectToolStripMenuItem.Text = "Load Project";
            this.loadProjectToolStripMenuItem.Click += new System.EventHandler(this.loadProjectToolStripMenuItem_Click);
            // 
            // closeProgramToolStripMenuItem
            // 
            this.closeProgramToolStripMenuItem.Name = "closeProgramToolStripMenuItem";
            this.closeProgramToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeProgramToolStripMenuItem.Text = "Close Program";
            this.closeProgramToolStripMenuItem.Click += new System.EventHandler(this.closeProgramToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPreferencesToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // openPreferencesToolStripMenuItem
            // 
            this.openPreferencesToolStripMenuItem.Name = "openPreferencesToolStripMenuItem";
            this.openPreferencesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openPreferencesToolStripMenuItem.Text = "Open Preferences";
            this.openPreferencesToolStripMenuItem.Click += new System.EventHandler(this.openPreferencesToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.ButtonCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 362);
            this.Controls.Add(this.labelProject);
            this.Controls.Add(this.ButtonLoad);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonReset);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.LabelBaseCosts);
            this.Controls.Add(this.InputBaseCosts);
            this.Controls.Add(this.ButtonAccept);
            this.Controls.Add(this.ButtonStop);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.LabelTax);
            this.Controls.Add(this.InputTax);
            this.Controls.Add(this.LabelLog);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.TotalTime);
            this.Controls.Add(this.LabelMinutes);
            this.Controls.Add(this.InputMinutes);
            this.Controls.Add(this.LabelWage);
            this.Controls.Add(this.LabelHours);
            this.Controls.Add(this.ButtonCalculate);
            this.Controls.Add(this.InputWage);
            this.Controls.Add(this.LabelResult);
            this.Controls.Add(this.InputHours);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(460, 360);
            this.Name = "MainForm";
            this.Text = "Commission Price Calculator";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Label LabelLog;
        private System.Windows.Forms.TextBox InputTax;
        private System.Windows.Forms.Label LabelTax;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.Button ButtonAccept;
        private System.Windows.Forms.TextBox InputBaseCosts;
        private System.Windows.Forms.Label LabelBaseCosts;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonLoad;
        private System.Windows.Forms.Label labelProject;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPreferencesToolStripMenuItem;
    }
}

