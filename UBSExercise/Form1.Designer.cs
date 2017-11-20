namespace UBSExercise
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
            this.buttonCounts = new System.Windows.Forms.Button();
            this.textBoxSentence = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxDisplayCounts = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonCounts
            // 
            this.buttonCounts.Location = new System.Drawing.Point(993, 364);
            this.buttonCounts.Name = "buttonCounts";
            this.buttonCounts.Size = new System.Drawing.Size(755, 126);
            this.buttonCounts.TabIndex = 0;
            this.buttonCounts.Text = "Generate Counts";
            this.buttonCounts.UseVisualStyleBackColor = true;
            this.buttonCounts.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxSentence
            // 
            this.textBoxSentence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSentence.Location = new System.Drawing.Point(112, 136);
            this.textBoxSentence.Multiline = true;
            this.textBoxSentence.Name = "textBoxSentence";
            this.textBoxSentence.Size = new System.Drawing.Size(3823, 120);
            this.textBoxSentence.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sentence to Analyze";
            // 
            // richTextBoxDisplayCounts
            // 
            this.richTextBoxDisplayCounts.Location = new System.Drawing.Point(168, 544);
            this.richTextBoxDisplayCounts.Name = "richTextBoxDisplayCounts";
            this.richTextBoxDisplayCounts.Size = new System.Drawing.Size(2507, 1118);
            this.richTextBoxDisplayCounts.TabIndex = 3;
            this.richTextBoxDisplayCounts.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(4163, 2831);
            this.Controls.Add(this.richTextBoxDisplayCounts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSentence);
            this.Controls.Add(this.buttonCounts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCounts;
        private System.Windows.Forms.TextBox textBoxSentence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxDisplayCounts;
    }
}

