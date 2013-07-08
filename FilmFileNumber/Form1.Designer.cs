namespace FilmFileNumber
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
            this.lblCurrentPFNTag = new System.Windows.Forms.Label();
            this.lblNewPFN = new System.Windows.Forms.Label();
            this.txtNewPFN = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnJobnumber = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCurrentPFN = new System.Windows.Forms.Label();
            this.lblJobNumber = new System.Windows.Forms.Label();
            this.lblJobNumberReflect = new System.Windows.Forms.Label();
            this.txtJobNumber = new System.Windows.Forms.TextBox();
            this.lblJobNumberLookup = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDescriptionLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.changeServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCurrentPFNTag
            // 
            this.lblCurrentPFNTag.AutoSize = true;
            this.lblCurrentPFNTag.Location = new System.Drawing.Point(120, 130);
            this.lblCurrentPFNTag.Name = "lblCurrentPFNTag";
            this.lblCurrentPFNTag.Size = new System.Drawing.Size(78, 13);
            this.lblCurrentPFNTag.TabIndex = 3;
            this.lblCurrentPFNTag.Text = "Current Plate #";
            // 
            // lblNewPFN
            // 
            this.lblNewPFN.AutoSize = true;
            this.lblNewPFN.Location = new System.Drawing.Point(21, 223);
            this.lblNewPFN.Name = "lblNewPFN";
            this.lblNewPFN.Size = new System.Drawing.Size(66, 13);
            this.lblNewPFN.TabIndex = 5;
            this.lblNewPFN.Text = "New Plate #";
            // 
            // txtNewPFN
            // 
            this.txtNewPFN.Location = new System.Drawing.Point(24, 236);
            this.txtNewPFN.Name = "txtNewPFN";
            this.txtNewPFN.Size = new System.Drawing.Size(81, 20);
            this.txtNewPFN.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Location = new System.Drawing.Point(123, 232);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 24);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnJobnumber
            // 
            this.btnJobnumber.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJobnumber.Location = new System.Drawing.Point(123, 89);
            this.btnJobnumber.Name = "btnJobnumber";
            this.btnJobnumber.Size = new System.Drawing.Size(84, 23);
            this.btnJobnumber.TabIndex = 2;
            this.btnJobnumber.Text = "&Load";
            this.btnJobnumber.UseVisualStyleBackColor = true;
            this.btnJobnumber.Click += new System.EventHandler(this.btnJobnumber_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(24, 262);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(183, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "&Cancel/Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(5, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(226, 33);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Update Plate File Number";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCurrentPFN
            // 
            this.lblCurrentPFN.BackColor = System.Drawing.SystemColors.Control;
            this.lblCurrentPFN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCurrentPFN.Location = new System.Drawing.Point(123, 143);
            this.lblCurrentPFN.Name = "lblCurrentPFN";
            this.lblCurrentPFN.Size = new System.Drawing.Size(84, 20);
            this.lblCurrentPFN.TabIndex = 12;
            // 
            // lblJobNumber
            // 
            this.lblJobNumber.BackColor = System.Drawing.SystemColors.Control;
            this.lblJobNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblJobNumber.Location = new System.Drawing.Point(24, 143);
            this.lblJobNumber.Name = "lblJobNumber";
            this.lblJobNumber.Size = new System.Drawing.Size(84, 20);
            this.lblJobNumber.TabIndex = 14;
            // 
            // lblJobNumberReflect
            // 
            this.lblJobNumberReflect.AutoSize = true;
            this.lblJobNumberReflect.Location = new System.Drawing.Point(21, 130);
            this.lblJobNumberReflect.Name = "lblJobNumberReflect";
            this.lblJobNumberReflect.Size = new System.Drawing.Size(34, 13);
            this.lblJobNumberReflect.TabIndex = 13;
            this.lblJobNumberReflect.Text = "Job #";
            // 
            // txtJobNumber
            // 
            this.txtJobNumber.Location = new System.Drawing.Point(24, 91);
            this.txtJobNumber.Name = "txtJobNumber";
            this.txtJobNumber.Size = new System.Drawing.Size(84, 20);
            this.txtJobNumber.TabIndex = 1;
            // 
            // lblJobNumberLookup
            // 
            this.lblJobNumberLookup.AutoSize = true;
            this.lblJobNumberLookup.Location = new System.Drawing.Point(21, 75);
            this.lblJobNumberLookup.Name = "lblJobNumberLookup";
            this.lblJobNumberLookup.Size = new System.Drawing.Size(61, 13);
            this.lblJobNumberLookup.TabIndex = 16;
            this.lblJobNumberLookup.Text = "Load Job #";
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.SystemColors.Control;
            this.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDescription.Location = new System.Drawing.Point(24, 187);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(183, 20);
            this.lblDescription.TabIndex = 20;
            // 
            // lblDescriptionLabel
            // 
            this.lblDescriptionLabel.AutoSize = true;
            this.lblDescriptionLabel.Location = new System.Drawing.Point(21, 174);
            this.lblDescriptionLabel.Name = "lblDescriptionLabel";
            this.lblDescriptionLabel.Size = new System.Drawing.Size(80, 13);
            this.lblDescriptionLabel.TabIndex = 19;
            this.lblDescriptionLabel.Text = "Job Description";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeServerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(237, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // changeServerToolStripMenuItem
            // 
            this.changeServerToolStripMenuItem.Name = "changeServerToolStripMenuItem";
            this.changeServerToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.changeServerToolStripMenuItem.Text = "&Change Server";
            this.changeServerToolStripMenuItem.Click += new System.EventHandler(this.changeServerToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(237, 297);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblDescriptionLabel);
            this.Controls.Add(this.lblJobNumberLookup);
            this.Controls.Add(this.txtJobNumber);
            this.Controls.Add(this.lblJobNumber);
            this.Controls.Add(this.lblJobNumberReflect);
            this.Controls.Add(this.lblCurrentPFN);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnJobnumber);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblNewPFN);
            this.Controls.Add(this.txtNewPFN);
            this.Controls.Add(this.lblCurrentPFNTag);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Plate File Tracking";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentPFNTag;
        private System.Windows.Forms.Label lblNewPFN;
        private System.Windows.Forms.TextBox txtNewPFN;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnJobnumber;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCurrentPFN;
        private System.Windows.Forms.Label lblJobNumber;
        private System.Windows.Forms.Label lblJobNumberReflect;
        private System.Windows.Forms.TextBox txtJobNumber;
        private System.Windows.Forms.Label lblJobNumberLookup;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDescriptionLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem changeServerToolStripMenuItem;
    }
}

