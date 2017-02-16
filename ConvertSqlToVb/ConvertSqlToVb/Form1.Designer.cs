namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtSql = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFormatedSql = new System.Windows.Forms.RichTextBox();
            this.radVB = new System.Windows.Forms.RadioButton();
            this.radCSHARP = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSql
            // 
            this.txtSql.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtSql.ForeColor = System.Drawing.Color.White;
            this.txtSql.Location = new System.Drawing.Point(12, 41);
            this.txtSql.Name = "txtSql";
            this.txtSql.Size = new System.Drawing.Size(505, 485);
            this.txtSql.TabIndex = 0;
            this.txtSql.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(505, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "Convert To Long String";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFormatedSql
            // 
            this.txtFormatedSql.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtFormatedSql.ForeColor = System.Drawing.Color.White;
            this.txtFormatedSql.Location = new System.Drawing.Point(523, 41);
            this.txtFormatedSql.Name = "txtFormatedSql";
            this.txtFormatedSql.Size = new System.Drawing.Size(496, 485);
            this.txtFormatedSql.TabIndex = 2;
            this.txtFormatedSql.Text = "";
            // 
            // radVB
            // 
            this.radVB.AutoSize = true;
            this.radVB.Checked = true;
            this.radVB.Location = new System.Drawing.Point(523, 11);
            this.radVB.Name = "radVB";
            this.radVB.Size = new System.Drawing.Size(82, 17);
            this.radVB.TabIndex = 3;
            this.radVB.TabStop = true;
            this.radVB.Text = "Visual Basic";
            this.radVB.UseVisualStyleBackColor = true;
            // 
            // radCSHARP
            // 
            this.radCSHARP.AutoSize = true;
            this.radCSHARP.Location = new System.Drawing.Point(611, 11);
            this.radCSHARP.Name = "radCSHARP";
            this.radCSHARP.Size = new System.Drawing.Size(39, 17);
            this.radCSHARP.TabIndex = 4;
            this.radCSHARP.Text = "C#";
            this.radCSHARP.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(656, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 24);
            this.button2.TabIndex = 5;
            this.button2.Text = "Copy to clipboard";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 546);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.radCSHARP);
            this.Controls.Add(this.radVB);
            this.Controls.Add(this.txtFormatedSql);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSql);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SQL STRING CONVERTER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtSql;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txtFormatedSql;
        private System.Windows.Forms.RadioButton radVB;
        private System.Windows.Forms.RadioButton radCSHARP;
        private System.Windows.Forms.Button button2;
    }
}

