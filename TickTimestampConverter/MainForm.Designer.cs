namespace TickTimestampConverter
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
            this.uxInsertTimestamp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uxConvertTimeButton = new System.Windows.Forms.Button();
            this.uxOutputDateTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxInsertTimestamp
            // 
            this.uxInsertTimestamp.Location = new System.Drawing.Point(12, 25);
            this.uxInsertTimestamp.Name = "uxInsertTimestamp";
            this.uxInsertTimestamp.Size = new System.Drawing.Size(387, 20);
            this.uxInsertTimestamp.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Paste Timestamp Here:";
            // 
            // uxConvertTimeButton
            // 
            this.uxConvertTimeButton.Location = new System.Drawing.Point(12, 51);
            this.uxConvertTimeButton.Name = "uxConvertTimeButton";
            this.uxConvertTimeButton.Size = new System.Drawing.Size(387, 23);
            this.uxConvertTimeButton.TabIndex = 2;
            this.uxConvertTimeButton.Text = "Click to Convert";
            this.uxConvertTimeButton.UseVisualStyleBackColor = true;
            this.uxConvertTimeButton.Click += new System.EventHandler(this.uxConvertTimeButton_Click);
            // 
            // uxOutputDateTime
            // 
            this.uxOutputDateTime.Location = new System.Drawing.Point(12, 117);
            this.uxOutputDateTime.Name = "uxOutputDateTime";
            this.uxOutputDateTime.Size = new System.Drawing.Size(387, 20);
            this.uxOutputDateTime.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Converted date/time (YearMonthDay-HourMinutesSeconds):";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.SystemColors.Info;
            this.errorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorLabel.Location = new System.Drawing.Point(141, 77);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(130, 13);
            this.errorLabel.TabIndex = 5;
            this.errorLabel.Text = "Cant convert, invalid input";
            this.errorLabel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 156);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxOutputDateTime);
            this.Controls.Add(this.uxConvertTimeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxInsertTimestamp);
            this.Name = "MainForm";
            this.Text = "Tick Timestamp Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxInsertTimestamp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uxConvertTimeButton;
        private System.Windows.Forms.TextBox uxOutputDateTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label errorLabel;
    }
}

