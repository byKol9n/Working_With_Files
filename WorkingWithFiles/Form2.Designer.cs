namespace WorkingWithFiles
{
    partial class Form2
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
            textBox1 = new TextBox();
            buttonWriteJSON = new Button();
            buttonReadJSON = new Button();
            buttonDelJSON = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(796, 274);
            textBox1.TabIndex = 0;
            // 
            // buttonWriteJSON
            // 
            buttonWriteJSON.Location = new Point(311, 309);
            buttonWriteJSON.Name = "buttonWriteJSON";
            buttonWriteJSON.Size = new Size(204, 46);
            buttonWriteJSON.TabIndex = 1;
            buttonWriteJSON.Text = "Записать JSON";
            buttonWriteJSON.UseVisualStyleBackColor = true;
            buttonWriteJSON.Click += buttonWriteJSON_Click;
            // 
            // buttonReadJSON
            // 
            buttonReadJSON.Location = new Point(311, 378);
            buttonReadJSON.Name = "buttonReadJSON";
            buttonReadJSON.Size = new Size(204, 46);
            buttonReadJSON.TabIndex = 2;
            buttonReadJSON.Text = "Вывести JSON";
            buttonReadJSON.UseVisualStyleBackColor = true;
            buttonReadJSON.Click += buttonReadJSON_Click;
            // 
            // buttonDelJSON
            // 
            buttonDelJSON.Location = new Point(311, 448);
            buttonDelJSON.Name = "buttonDelJSON";
            buttonDelJSON.Size = new Size(204, 46);
            buttonDelJSON.TabIndex = 3;
            buttonDelJSON.Text = "Удалить JSON";
            buttonDelJSON.UseVisualStyleBackColor = true;
            buttonDelJSON.Click += buttonDelJSON_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 578);
            Controls.Add(buttonDelJSON);
            Controls.Add(buttonReadJSON);
            Controls.Add(buttonWriteJSON);
            Controls.Add(textBox1);
            Name = "Form2";
            Text = "JSON";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button buttonWriteJSON;
        private Button buttonReadJSON;
        private Button buttonDelJSON;
    }
}