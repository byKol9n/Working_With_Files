namespace WorkingWithFiles
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
            listView1 = new ListView();
            buttonDisk = new Button();
            buttonCatalog = new Button();
            buttonCreateFile = new Button();
            buttonWrite = new Button();
            labelPath = new Label();
            textBoxPath = new TextBox();
            buttonRead = new Button();
            textBox1 = new TextBox();
            buttonDel = new Button();
            buttonJSON = new Button();
            buttonXML = new Button();
            buttonZIP = new Button();
            buttonSearch = new Button();
            textBoxNameFile = new TextBox();
            labelNameFile = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 304);
            listView1.Name = "listView1";
            listView1.Size = new Size(509, 412);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            // 
            // buttonDisk
            // 
            buttonDisk.Location = new Point(856, 148);
            buttonDisk.Name = "buttonDisk";
            buttonDisk.Size = new Size(150, 46);
            buttonDisk.TabIndex = 2;
            buttonDisk.Text = "Диск";
            buttonDisk.UseVisualStyleBackColor = true;
            buttonDisk.Click += buttonDisk_Click;
            // 
            // buttonCatalog
            // 
            buttonCatalog.Location = new Point(856, 211);
            buttonCatalog.Name = "buttonCatalog";
            buttonCatalog.Size = new Size(150, 46);
            buttonCatalog.TabIndex = 3;
            buttonCatalog.Text = "Каталог";
            buttonCatalog.UseVisualStyleBackColor = true;
            buttonCatalog.Click += buttonCatalog_Click;
            // 
            // buttonCreateFile
            // 
            buttonCreateFile.Location = new Point(828, 290);
            buttonCreateFile.Name = "buttonCreateFile";
            buttonCreateFile.Size = new Size(211, 46);
            buttonCreateFile.TabIndex = 4;
            buttonCreateFile.Text = "Создать файл";
            buttonCreateFile.UseVisualStyleBackColor = true;
            buttonCreateFile.Click += buttonCreateFile_Click;
            // 
            // buttonWrite
            // 
            buttonWrite.Location = new Point(828, 342);
            buttonWrite.Name = "buttonWrite";
            buttonWrite.Size = new Size(211, 46);
            buttonWrite.TabIndex = 5;
            buttonWrite.Text = "Запись файла";
            buttonWrite.UseVisualStyleBackColor = true;
            buttonWrite.Click += buttonWrite_Click;
            // 
            // labelPath
            // 
            labelPath.AutoSize = true;
            labelPath.Location = new Point(549, 26);
            labelPath.Name = "labelPath";
            labelPath.Size = new Size(65, 32);
            labelPath.TabIndex = 6;
            labelPath.Text = "Путь";
            // 
            // textBoxPath
            // 
            textBoxPath.Enabled = false;
            textBoxPath.Location = new Point(653, 26);
            textBoxPath.Name = "textBoxPath";
            textBoxPath.Size = new Size(422, 39);
            textBoxPath.TabIndex = 7;
            // 
            // buttonRead
            // 
            buttonRead.Location = new Point(828, 394);
            buttonRead.Name = "buttonRead";
            buttonRead.Size = new Size(211, 46);
            buttonRead.TabIndex = 8;
            buttonRead.Text = "Чтение файла";
            buttonRead.UseVisualStyleBackColor = true;
            buttonRead.Click += buttonRead_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(509, 277);
            textBox1.TabIndex = 9;
            // 
            // buttonDel
            // 
            buttonDel.Location = new Point(828, 446);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(211, 46);
            buttonDel.TabIndex = 10;
            buttonDel.Text = "Удаление файла";
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += buttonDel_Click;
            // 
            // buttonJSON
            // 
            buttonJSON.Location = new Point(856, 538);
            buttonJSON.Name = "buttonJSON";
            buttonJSON.Size = new Size(150, 46);
            buttonJSON.TabIndex = 11;
            buttonJSON.Text = "JSON";
            buttonJSON.UseVisualStyleBackColor = true;
            buttonJSON.Click += buttonJSON_Click;
            // 
            // buttonXML
            // 
            buttonXML.Location = new Point(856, 590);
            buttonXML.Name = "buttonXML";
            buttonXML.Size = new Size(150, 46);
            buttonXML.TabIndex = 12;
            buttonXML.Text = "XML";
            buttonXML.UseVisualStyleBackColor = true;
            buttonXML.Click += buttonXML_Click;
            // 
            // buttonZIP
            // 
            buttonZIP.Location = new Point(856, 642);
            buttonZIP.Name = "buttonZIP";
            buttonZIP.Size = new Size(150, 46);
            buttonZIP.TabIndex = 13;
            buttonZIP.Text = "ZIP";
            buttonZIP.UseVisualStyleBackColor = true;
            buttonZIP.Click += buttonZIP_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(1081, 22);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(150, 46);
            buttonSearch.TabIndex = 14;
            buttonSearch.Text = "Поиск";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxNameFile
            // 
            textBoxNameFile.Location = new Point(653, 71);
            textBoxNameFile.Name = "textBoxNameFile";
            textBoxNameFile.Size = new Size(422, 39);
            textBoxNameFile.TabIndex = 15;
            // 
            // labelNameFile
            // 
            labelNameFile.AutoSize = true;
            labelNameFile.Location = new Point(527, 74);
            labelNameFile.Name = "labelNameFile";
            labelNameFile.Size = new Size(120, 32);
            labelNameFile.TabIndex = 16;
            labelNameFile.Text = "Название";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 728);
            Controls.Add(labelNameFile);
            Controls.Add(textBoxNameFile);
            Controls.Add(buttonSearch);
            Controls.Add(buttonZIP);
            Controls.Add(buttonXML);
            Controls.Add(buttonJSON);
            Controls.Add(buttonDel);
            Controls.Add(textBox1);
            Controls.Add(buttonRead);
            Controls.Add(textBoxPath);
            Controls.Add(labelPath);
            Controls.Add(buttonWrite);
            Controls.Add(buttonCreateFile);
            Controls.Add(buttonCatalog);
            Controls.Add(buttonDisk);
            Controls.Add(listView1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Button buttonDisk;
        private Button buttonCatalog;
        private Button buttonCreateFile;
        private Button buttonWrite;
        private Label labelPath;
        private TextBox textBoxPath;
        private Button buttonRead;
        private TextBox textBox1;
        private Button buttonDel;
        private Button buttonJSON;
        private Button buttonXML;
        private Button buttonZIP;
        private Button buttonSearch;
        private TextBox textBoxNameFile;
        private Label labelNameFile;
    }
}