namespace HangulCharToSound
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
            this.richTextBoxStrInput = new System.Windows.Forms.RichTextBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxStrInput
            // 
            this.richTextBoxStrInput.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxStrInput.Name = "richTextBoxStrInput";
            this.richTextBoxStrInput.Size = new System.Drawing.Size(445, 426);
            this.richTextBoxStrInput.TabIndex = 0;
            this.richTextBoxStrInput.Text = "";
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(464, 13);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(172, 110);
            this.buttonConvert.TabIndex = 1;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.richTextBoxStrInput);
            this.Name = "MainForm";
            this.Text = "Hangul To Sound Character Converter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxStrInput;
        private System.Windows.Forms.Button buttonConvert;
    }
}

