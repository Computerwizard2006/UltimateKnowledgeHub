namespace UltimateKnowledgeHub
{
    partial class PoliticsControl
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
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.rtbUpdate = new System.Windows.Forms.RichTextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
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
            this.label1.Text = "Welcome to  World politics \n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbldescription
            // 
            this.lbldescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescription.Location = new System.Drawing.Point(16, 75);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(159, 142);
            this.lbldescription.TabIndex = 1;
            this.lbldescription.Text = "\"World Politics: Get insights into global political events, leaders, and diplomat" +
    "ic relations.\"\n";
            this.lbldescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbCountry
            // 
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(207, 93);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(195, 21);
            this.cmbCountry.TabIndex = 2;
            this.cmbCountry.SelectedIndexChanged += new System.EventHandler(this.cmbCountry_SelectedIndexChanged);
            // 
            // rtbUpdate
            // 
            this.rtbUpdate.Location = new System.Drawing.Point(207, 131);
            this.rtbUpdate.Name = "rtbUpdate";
            this.rtbUpdate.Size = new System.Drawing.Size(195, 96);
            this.rtbUpdate.TabIndex = 3;
            this.rtbUpdate.Text = "";
            this.rtbUpdate.TextChanged += new System.EventHandler(this.rtbUpdate_TextChanged);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(207, 247);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Search";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(207, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select A Country";
            // 
            // PoliticsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.rtbUpdate);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.lbldescription);
            this.Controls.Add(this.label1);
            this.Name = "PoliticsControl";
            this.Size = new System.Drawing.Size(420, 309);
            this.Load += new System.EventHandler(this.PoliticsControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldescription;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.RichTextBox rtbUpdate;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label2;
    }
}
