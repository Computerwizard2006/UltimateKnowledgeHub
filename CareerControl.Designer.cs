namespace UltimateKnowledgeHub
{
    partial class CareerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbldescription = new System.Windows.Forms.Label();
            this.cmbInterest = new System.Windows.Forms.ComboBox();
            this.lstJobs = new System.Windows.Forms.ListBox();
            this.btnFindJobs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Career Path Explorer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbldescription
            // 
            this.lbldescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescription.Location = new System.Drawing.Point(0, 62);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(147, 100);
            this.lbldescription.TabIndex = 1;
            this.lbldescription.Text = "\"Explore various career paths, learn required skills, and plan your future.\"\n";
            this.lbldescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbInterest
            // 
            this.cmbInterest.FormattingEnabled = true;
            this.cmbInterest.Location = new System.Drawing.Point(217, 75);
            this.cmbInterest.Name = "cmbInterest";
            this.cmbInterest.Size = new System.Drawing.Size(121, 21);
            this.cmbInterest.TabIndex = 2;
            // 
            // lstJobs
            // 
            this.lstJobs.FormattingEnabled = true;
            this.lstJobs.Location = new System.Drawing.Point(218, 113);
            this.lstJobs.Name = "lstJobs";
            this.lstJobs.Size = new System.Drawing.Size(120, 95);
            this.lstJobs.TabIndex = 3;
            // 
            // btnFindJobs
            // 
            this.btnFindJobs.Location = new System.Drawing.Point(218, 214);
            this.btnFindJobs.Name = "btnFindJobs";
            this.btnFindJobs.Size = new System.Drawing.Size(75, 23);
            this.btnFindJobs.TabIndex = 4;
            this.btnFindJobs.Text = "Search Jobs";
            this.btnFindJobs.UseVisualStyleBackColor = true;
            this.btnFindJobs.Click += new System.EventHandler(this.btnFindJobs_Click);
            // 
            // CareerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFindJobs);
            this.Controls.Add(this.lstJobs);
            this.Controls.Add(this.cmbInterest);
            this.Controls.Add(this.lbldescription);
            this.Controls.Add(this.label1);
            this.Name = "CareerControl";
            this.Size = new System.Drawing.Size(420, 309);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldescription;
        private System.Windows.Forms.ComboBox cmbInterest;
        private System.Windows.Forms.ListBox lstJobs;
        private System.Windows.Forms.Button btnFindJobs;
    }
}
