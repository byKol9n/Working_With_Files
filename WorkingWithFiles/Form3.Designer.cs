namespace WorkingWithFiles
{
    partial class Form3
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
            buttonDelXML = new Button();
            buttonReadXML = new Button();
            buttonWriteXML = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // buttonDelXML
            // 
            buttonDelXML.Location = new Point(301, 453);
            buttonDelXML.Name = "buttonDelXML";
            buttonDelXML.Size = new Size(204, 46);
            buttonDelXML.TabIndex = 7;
            buttonDelXML.Text = "Удалить XML";
            buttonDelXML.UseVisualStyleBackColor = true;
            buttonDelXML.Click += buttonDelXML_Click;
            // 
            // buttonReadXML
            // 
            buttonReadXML.Location = new Point(301, 385);
            buttonReadXML.Name = "buttonReadXML";
            buttonReadXML.Size = new Size(204, 46);
            buttonReadXML.TabIndex = 6;
            buttonReadXML.Text = "Вывести XML";
            buttonReadXML.UseVisualStyleBackColor = true;
            buttonReadXML.Click += buttonReadXML_Click;
            // 
            // buttonWriteXML
            // 
            buttonWriteXML.Location = new Point(301, 323);
            buttonWriteXML.Name = "buttonWriteXML";
            buttonWriteXML.Size = new Size(204, 46);
            buttonWriteXML.TabIndex = 5;
            buttonWriteXML.Text = "Записать XML";
            buttonWriteXML.UseVisualStyleBackColor = true;
            buttonWriteXML.Click += buttonWriteXML_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(11, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(796, 274);
            textBox1.TabIndex = 4;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 549);
            Controls.Add(buttonDelXML);
            Controls.Add(buttonReadXML);
            Controls.Add(buttonWriteXML);
            Controls.Add(textBox1);
            Name = "Form3";
            Text = "XML";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDelXML;
        private Button buttonReadXML;
        private Button buttonWriteXML;
        private TextBox textBox1;
    }
}