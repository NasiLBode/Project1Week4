
namespace Project1Week4
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.mortgagePay = new System.Windows.Forms.Label();
            this.outStandingAmt = new System.Windows.Forms.Label();
            this.mortgagePayInput = new System.Windows.Forms.TextBox();
            this.outStandPayInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(158, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 85);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mortgagePay
            // 
            this.mortgagePay.AutoSize = true;
            this.mortgagePay.Location = new System.Drawing.Point(12, 65);
            this.mortgagePay.Name = "mortgagePay";
            this.mortgagePay.Size = new System.Drawing.Size(223, 19);
            this.mortgagePay.TabIndex = 1;
            this.mortgagePay.Text = "Monthly Mortgage Payment:";
            this.mortgagePay.Click += new System.EventHandler(this.label1_Click);
            // 
            // outStandingAmt
            // 
            this.outStandingAmt.AutoSize = true;
            this.outStandingAmt.Location = new System.Drawing.Point(60, 123);
            this.outStandingAmt.Name = "outStandingAmt";
            this.outStandingAmt.Size = new System.Drawing.Size(175, 19);
            this.outStandingAmt.TabIndex = 2;
            this.outStandingAmt.Text = "Outstanding Balance:";
            this.outStandingAmt.Click += new System.EventHandler(this.label2_Click);
            // 
            // mortgagePayInput
            // 
            this.mortgagePayInput.Location = new System.Drawing.Point(251, 58);
            this.mortgagePayInput.Name = "mortgagePayInput";
            this.mortgagePayInput.Size = new System.Drawing.Size(199, 26);
            this.mortgagePayInput.TabIndex = 3;
            // 
            // outStandPayInput
            // 
            this.outStandPayInput.Location = new System.Drawing.Point(251, 116);
            this.outStandPayInput.Name = "outStandPayInput";
            this.outStandPayInput.Size = new System.Drawing.Size(199, 26);
            this.outStandPayInput.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(522, 318);
            this.Controls.Add(this.outStandPayInput);
            this.Controls.Add(this.mortgagePayInput);
            this.Controls.Add(this.outStandingAmt);
            this.Controls.Add(this.mortgagePay);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Mortgage Payments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label mortgagePay;
        private System.Windows.Forms.Label outStandingAmt;
        private System.Windows.Forms.TextBox mortgagePayInput;
        private System.Windows.Forms.TextBox outStandPayInput;
    }
}

