namespace UltimateKnowledgeHub
{
    partial class PlantsControl
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
            this.txtHerb = new System.Windows.Forms.TextBox();
            this.rtbBenefit = new System.Windows.Forms.RichTextBox();
            this.btnFind = new System.Windows.Forms.Button();
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
            this.label1.Text = "Welcome to  Plant &Herb Facts";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbldescription
            // 
            this.lbldescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescription.Location = new System.Drawing.Point(3, 65);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(147, 130);
            this.lbldescription.TabIndex = 1;
            this.lbldescription.Text = "\"Plant & Herb Facts: Basil is a natural anti-inflammatory. Aloe Vera soothes burn" +
    "s and skin irritation.\"";
            this.lbldescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHerb
            // 
            this.txtHerb.Location = new System.Drawing.Point(198, 74);
            this.txtHerb.Name = "txtHerb";
            this.txtHerb.Size = new System.Drawing.Size(100, 20);
            this.txtHerb.TabIndex = 2;
            // 
            // rtbBenefit
            // 
            this.rtbBenefit.Location = new System.Drawing.Point(198, 115);
            this.rtbBenefit.Name = "rtbBenefit";
            this.rtbBenefit.Size = new System.Drawing.Size(100, 96);
            this.rtbBenefit.TabIndex = 3;
            this.rtbBenefit.Text = "";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(198, 233);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // PlantsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.rtbBenefit);
            this.Controls.Add(this.txtHerb);
            this.Controls.Add(this.lbldescription);
            this.Controls.Add(this.label1);
            this.Name = "PlantsControl";
            this.Size = new System.Drawing.Size(420, 309);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldescription;
        private System.Windows.Forms.TextBox txtHerb;
        private System.Windows.Forms.RichTextBox rtbBenefit;
        private System.Windows.Forms.Button btnFind;
    }
}
