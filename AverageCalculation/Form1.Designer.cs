namespace AverageCalculation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFirstNum = new System.Windows.Forms.TextBox();
            this.txtSecondNum = new System.Windows.Forms.TextBox();
            this.txtThirdNum = new System.Windows.Forms.TextBox();
            this.txtFourthNum = new System.Windows.Forms.TextBox();
            this.txtFifthNum = new System.Windows.Forms.TextBox();
            this.lblDisplayAverage = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grade 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grade 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grade 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Grade 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Grade 5";
            // 
            // txtFirstNum
            // 
            this.txtFirstNum.Location = new System.Drawing.Point(63, 40);
            this.txtFirstNum.Name = "txtFirstNum";
            this.txtFirstNum.Size = new System.Drawing.Size(100, 20);
            this.txtFirstNum.TabIndex = 5;
            // 
            // txtSecondNum
            // 
            this.txtSecondNum.Location = new System.Drawing.Point(63, 66);
            this.txtSecondNum.Name = "txtSecondNum";
            this.txtSecondNum.Size = new System.Drawing.Size(100, 20);
            this.txtSecondNum.TabIndex = 6;
            // 
            // txtThirdNum
            // 
            this.txtThirdNum.Location = new System.Drawing.Point(63, 92);
            this.txtThirdNum.Name = "txtThirdNum";
            this.txtThirdNum.Size = new System.Drawing.Size(100, 20);
            this.txtThirdNum.TabIndex = 7;
            // 
            // txtFourthNum
            // 
            this.txtFourthNum.Location = new System.Drawing.Point(63, 118);
            this.txtFourthNum.Name = "txtFourthNum";
            this.txtFourthNum.Size = new System.Drawing.Size(100, 20);
            this.txtFourthNum.TabIndex = 8;
            // 
            // txtFifthNum
            // 
            this.txtFifthNum.Location = new System.Drawing.Point(63, 144);
            this.txtFifthNum.Name = "txtFifthNum";
            this.txtFifthNum.Size = new System.Drawing.Size(100, 20);
            this.txtFifthNum.TabIndex = 9;
            // 
            // lblDisplayAverage
            // 
            this.lblDisplayAverage.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayAverage.Location = new System.Drawing.Point(169, 40);
            this.lblDisplayAverage.Name = "lblDisplayAverage";
            this.lblDisplayAverage.Size = new System.Drawing.Size(146, 182);
            this.lblDisplayAverage.TabIndex = 10;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(15, 170);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(148, 52);
            this.btnDisplay.TabIndex = 11;
            this.btnDisplay.Text = "Calculate Average";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 284);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.lblDisplayAverage);
            this.Controls.Add(this.txtFifthNum);
            this.Controls.Add(this.txtFourthNum);
            this.Controls.Add(this.txtThirdNum);
            this.Controls.Add(this.txtSecondNum);
            this.Controls.Add(this.txtFirstNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFirstNum;
        private System.Windows.Forms.TextBox txtSecondNum;
        private System.Windows.Forms.TextBox txtThirdNum;
        private System.Windows.Forms.TextBox txtFourthNum;
        private System.Windows.Forms.TextBox txtFifthNum;
        private System.Windows.Forms.Label lblDisplayAverage;
        private System.Windows.Forms.Button btnDisplay;
    }
}

