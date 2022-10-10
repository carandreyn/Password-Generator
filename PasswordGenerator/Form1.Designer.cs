namespace PasswordGenerator
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
            this.SymbolsCheck = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.UppercaseCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PasswordShowLabel = new System.Windows.Forms.Label();
            this.LowercaseCheck = new System.Windows.Forms.CheckBox();
            this.NumbersCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // SymbolsCheck
            // 
            this.SymbolsCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SymbolsCheck.Checked = true;
            this.SymbolsCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SymbolsCheck.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SymbolsCheck.Location = new System.Drawing.Point(-1, 297);
            this.SymbolsCheck.Name = "SymbolsCheck";
            this.SymbolsCheck.Size = new System.Drawing.Size(332, 34);
            this.SymbolsCheck.TabIndex = 11;
            this.SymbolsCheck.Text = "Include Symbols";
            this.SymbolsCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SymbolsCheck.UseVisualStyleBackColor = true;
            this.SymbolsCheck.CheckedChanged += new System.EventHandler(this.SymbolsCheck_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password Length";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown1.Location = new System.Drawing.Point(253, 120);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(73, 35);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // UppercaseCheck
            // 
            this.UppercaseCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UppercaseCheck.Checked = true;
            this.UppercaseCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UppercaseCheck.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UppercaseCheck.Location = new System.Drawing.Point(-1, 177);
            this.UppercaseCheck.Name = "UppercaseCheck";
            this.UppercaseCheck.Size = new System.Drawing.Size(332, 34);
            this.UppercaseCheck.TabIndex = 3;
            this.UppercaseCheck.Text = "Include Uppercase Letters";
            this.UppercaseCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UppercaseCheck.UseVisualStyleBackColor = true;
            this.UppercaseCheck.CheckedChanged += new System.EventHandler(this.UppercaseCheck_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password Generator";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Image = global::PasswordGenerator.Properties.Resources._2931174_clipboard_copy_paste_analysis_report_icon1;
            this.button1.Location = new System.Drawing.Point(301, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 35);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PasswordShowLabel
            // 
            this.PasswordShowLabel.BackColor = System.Drawing.Color.Black;
            this.PasswordShowLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordShowLabel.ForeColor = System.Drawing.Color.White;
            this.PasswordShowLabel.Location = new System.Drawing.Point(36, 66);
            this.PasswordShowLabel.Name = "PasswordShowLabel";
            this.PasswordShowLabel.Size = new System.Drawing.Size(259, 33);
            this.PasswordShowLabel.TabIndex = 8;
            this.PasswordShowLabel.Text = "Password Length";
            this.PasswordShowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LowercaseCheck
            // 
            this.LowercaseCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LowercaseCheck.Checked = true;
            this.LowercaseCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LowercaseCheck.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LowercaseCheck.Location = new System.Drawing.Point(-1, 217);
            this.LowercaseCheck.Name = "LowercaseCheck";
            this.LowercaseCheck.Size = new System.Drawing.Size(332, 34);
            this.LowercaseCheck.TabIndex = 9;
            this.LowercaseCheck.Text = "Include Lowercase Letters";
            this.LowercaseCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LowercaseCheck.UseVisualStyleBackColor = true;
            this.LowercaseCheck.CheckedChanged += new System.EventHandler(this.LowercaseCheck_CheckedChanged);
            // 
            // NumbersCheck
            // 
            this.NumbersCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NumbersCheck.Checked = true;
            this.NumbersCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NumbersCheck.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumbersCheck.Location = new System.Drawing.Point(-1, 257);
            this.NumbersCheck.Name = "NumbersCheck";
            this.NumbersCheck.Size = new System.Drawing.Size(332, 34);
            this.NumbersCheck.TabIndex = 10;
            this.NumbersCheck.Text = "Include Numbers";
            this.NumbersCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NumbersCheck.UseVisualStyleBackColor = true;
            this.NumbersCheck.CheckedChanged += new System.EventHandler(this.NumbersCheck_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 344);
            this.Controls.Add(this.SymbolsCheck);
            this.Controls.Add(this.NumbersCheck);
            this.Controls.Add(this.LowercaseCheck);
            this.Controls.Add(this.PasswordShowLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UppercaseCheck);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox SymbolsCheck;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private CheckBox UppercaseCheck;
        private Label label1;
        private Button button1;
        private Label PasswordShowLabel;
        private CheckBox LowercaseCheck;
        private CheckBox NumbersCheck;
    }
}