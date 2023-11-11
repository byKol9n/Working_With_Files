namespace WorkingWithFiles
{
    partial class Form4
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
            buttonUnzipZIP = new Button();
            buttonAddZIP = new Button();
            buttonCreateZIP = new Button();
            textBox1 = new TextBox();
            buttonDelZIP = new Button();
            SuspendLayout();
            // 
            // buttonUnzipZIP
            // 
            buttonUnzipZIP.Location = new Point(261, 448);
            buttonUnzipZIP.Name = "buttonUnzipZIP";
            buttonUnzipZIP.Size = new Size(284, 46);
            buttonUnzipZIP.TabIndex = 7;
            buttonUnzipZIP.Text = "Разархивировать ZIP";
            buttonUnzipZIP.UseVisualStyleBackColor = true;
            buttonUnzipZIP.Click += buttonUnzipZIP_Click;
            // 
            // buttonAddZIP
            // 
            buttonAddZIP.Location = new Point(301, 384);
            buttonAddZIP.Name = "buttonAddZIP";
            buttonAddZIP.Size = new Size(204, 46);
            buttonAddZIP.TabIndex = 6;
            buttonAddZIP.Text = "Добавить в ZIP";
            buttonAddZIP.UseVisualStyleBackColor = true;
            buttonAddZIP.Click += buttonAddZIP_Click;
            // 
            // buttonCreateZIP
            // 
            buttonCreateZIP.Location = new Point(301, 318);
            buttonCreateZIP.Name = "buttonCreateZIP";
            buttonCreateZIP.Size = new Size(204, 46);
            buttonCreateZIP.TabIndex = 5;
            buttonCreateZIP.Text = "Создать ZIP";
            buttonCreateZIP.UseVisualStyleBackColor = true;
            buttonCreateZIP.Click += buttonCreateZIP_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(10, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(796, 274);
            textBox1.TabIndex = 4;
            // 
            // buttonDelZIP
            // 
            buttonDelZIP.Location = new Point(301, 510);
            buttonDelZIP.Name = "buttonDelZIP";
            buttonDelZIP.Size = new Size(204, 46);
            buttonDelZIP.TabIndex = 8;
            buttonDelZIP.Text = "Удалить ZIP";
            buttonDelZIP.UseVisualStyleBackColor = true;
            buttonDelZIP.Click += buttonDelZIP_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 589);
            Controls.Add(buttonDelZIP);
            Controls.Add(buttonUnzipZIP);
            Controls.Add(buttonAddZIP);
            Controls.Add(buttonCreateZIP);
            Controls.Add(textBox1);
            Name = "Form4";
            Text = "ZIP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonUnzipZIP;
        private Button buttonAddZIP;
        private Button buttonCreateZIP;
        private TextBox textBox1;
        private Button buttonDelZIP;
    }
}