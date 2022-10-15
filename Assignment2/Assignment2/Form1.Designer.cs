
namespace Assignment2
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
            this.labelHeading = new System.Windows.Forms.Label();
            this.labelFirstnumber = new System.Windows.Forms.Label();
            this.labelSecondnumber = new System.Windows.Forms.Label();
            this.labelOperator = new System.Windows.Forms.Label();
            this.calculatebutton = new System.Windows.Forms.Button();
            this.firstnumbertextBox = new System.Windows.Forms.TextBox();
            this.secondnumbertextBox = new System.Windows.Forms.TextBox();
            this.operatorcomboBox = new System.Windows.Forms.ComboBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.resulttextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelHeading
            // 
            this.labelHeading.AutoSize = true;
            this.labelHeading.Font = new System.Drawing.Font("Arial Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeading.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelHeading.Location = new System.Drawing.Point(344, 28);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(152, 33);
            this.labelHeading.TabIndex = 0;
            this.labelHeading.Text = "Calculator";
            // 
            // labelFirstnumber
            // 
            this.labelFirstnumber.AutoSize = true;
            this.labelFirstnumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstnumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelFirstnumber.Location = new System.Drawing.Point(56, 106);
            this.labelFirstnumber.Name = "labelFirstnumber";
            this.labelFirstnumber.Size = new System.Drawing.Size(98, 18);
            this.labelFirstnumber.TabIndex = 1;
            this.labelFirstnumber.Text = "First Number";
            // 
            // labelSecondnumber
            // 
            this.labelSecondnumber.AutoSize = true;
            this.labelSecondnumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSecondnumber.Location = new System.Drawing.Point(33, 161);
            this.labelSecondnumber.Name = "labelSecondnumber";
            this.labelSecondnumber.Size = new System.Drawing.Size(121, 18);
            this.labelSecondnumber.TabIndex = 2;
            this.labelSecondnumber.Text = "Second Number";
            // 
            // labelOperator
            // 
            this.labelOperator.AutoSize = true;
            this.labelOperator.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOperator.Location = new System.Drawing.Point(518, 133);
            this.labelOperator.Name = "labelOperator";
            this.labelOperator.Size = new System.Drawing.Size(70, 18);
            this.labelOperator.TabIndex = 3;
            this.labelOperator.Text = "Operator";
            // 
            // calculatebutton
            // 
            this.calculatebutton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatebutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.calculatebutton.Location = new System.Drawing.Point(620, 186);
            this.calculatebutton.Name = "calculatebutton";
            this.calculatebutton.Size = new System.Drawing.Size(97, 30);
            this.calculatebutton.TabIndex = 4;
            this.calculatebutton.Text = "Calculate";
            this.calculatebutton.UseVisualStyleBackColor = true;
            this.calculatebutton.Click += new System.EventHandler(this.calculatebutton_Click);
            // 
            // firstnumbertextBox
            // 
            this.firstnumbertextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.firstnumbertextBox.Location = new System.Drawing.Point(160, 106);
            this.firstnumbertextBox.Name = "firstnumbertextBox";
            this.firstnumbertextBox.Size = new System.Drawing.Size(300, 20);
            this.firstnumbertextBox.TabIndex = 5;
            // 
            // secondnumbertextBox
            // 
            this.secondnumbertextBox.Location = new System.Drawing.Point(160, 161);
            this.secondnumbertextBox.Name = "secondnumbertextBox";
            this.secondnumbertextBox.Size = new System.Drawing.Size(300, 20);
            this.secondnumbertextBox.TabIndex = 6;
            // 
            // operatorcomboBox
            // 
            this.operatorcomboBox.FormattingEnabled = true;
            this.operatorcomboBox.Items.AddRange(new object[] {
            "",
            "+",
            "-",
            "*",
            "/"});
            this.operatorcomboBox.Location = new System.Drawing.Point(594, 133);
            this.operatorcomboBox.Name = "operatorcomboBox";
            this.operatorcomboBox.Size = new System.Drawing.Size(123, 21);
            this.operatorcomboBox.TabIndex = 7;
            this.operatorcomboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(184, 325);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(58, 19);
            this.labelResult.TabIndex = 8;
            this.labelResult.Text = "Result";
            // 
            // resulttextBox
            // 
            this.resulttextBox.Location = new System.Drawing.Point(251, 325);
            this.resulttextBox.Name = "resulttextBox";
            this.resulttextBox.Size = new System.Drawing.Size(300, 20);
            this.resulttextBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resulttextBox);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.operatorcomboBox);
            this.Controls.Add(this.secondnumbertextBox);
            this.Controls.Add(this.firstnumbertextBox);
            this.Controls.Add(this.calculatebutton);
            this.Controls.Add(this.labelOperator);
            this.Controls.Add(this.labelSecondnumber);
            this.Controls.Add(this.labelFirstnumber);
            this.Controls.Add(this.labelHeading);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.Label labelFirstnumber;
        private System.Windows.Forms.Label labelSecondnumber;
        private System.Windows.Forms.Label labelOperator;
        private System.Windows.Forms.Button calculatebutton;
        private System.Windows.Forms.TextBox firstnumbertextBox;
        private System.Windows.Forms.TextBox secondnumbertextBox;
        private System.Windows.Forms.ComboBox operatorcomboBox;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox resulttextBox;
    }
}

