using System.IO;

namespace WorkingWithFiles
{
    public partial class Form1 : Form
    {
        private string path;
        private string name;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDisk_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            DriveInfo[] drives = DriveInfo.GetDrives();
            List<string> driveList = new List<string>();

            foreach (DriveInfo drive in drives)
            {
                driveList.Add($"Название: {drive.Name}");
                driveList.Add($"Тип: {drive.DriveType}");
                if (drive.IsReady)
                {
                    driveList.Add($"Объем диска: {drive.TotalSize}");
                    driveList.Add($"Свободное пространство: {drive.TotalFreeSpace}");
                    driveList.Add($"Метка: {drive.VolumeLabel}");
                }
            }
            foreach (String drive in driveList)
            {
                listView1.Items.Add(drive);
            }
        }

        private void buttonCatalog_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            string dirNameC = "C:\\";
            string dirNameD = "D:\\";

            if (Directory.Exists(dirNameC))
            {
                listView1.Items.Add("Подкаталоги:");
                string[] dirs = Directory.GetDirectories(dirNameC);
                foreach (string s in dirs)
                {
                    listView1.Items.Add(s);
                }
                listView1.Items.Add("Файлы:");
                string[] files = Directory.GetFiles(dirNameC);
                foreach (string s in files)
                {
                    listView1.Items.Add(s);
                }
            }
            if (Directory.Exists(dirNameD))
            {
                listView1.Items.Add("Подкаталоги:");
                string[] dirs = Directory.GetDirectories(dirNameD);
                foreach (string s in dirs)
                {
                    listView1.Items.Add(s);
                }
                listView1.Items.Add("Файлы:");
                string[] files = Directory.GetFiles(dirNameD);
                foreach (string s in files)
                {
                    listView1.Items.Add(s);
                }
            }
        }

        private void buttonCreateFile_Click(object sender, EventArgs e)
        {
            path = textBoxPath.Text;
            name = path + "\\" + textBoxNameFile.Text;
            try
            {
                using (FileStream fileStream = new FileStream(name, FileMode.Create)) { }
                MessageBox.Show($"Файл {name} успешно создан.");
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ошибка при создании файла: {ex.Message}");
            }
        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            path = textBoxPath.Text;
            name = path + "\\" + textBoxNameFile.Text;
            try
            {
                // Создаем объект StreamWriter для записи в файл
                using (StreamWriter writer = new StreamWriter(name))
                {
                    // Записываем данные в файл
                    string textFromTextBox = textBox1.Text;
                    writer.WriteLine(textFromTextBox);
                }
                MessageBox.Show("Данные успешно записаны в файл.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при записи в файл: {ex.Message}");
            }
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            path = textBoxPath.Text;
            name = path + "\\" + textBoxNameFile.Text;
            try
            {
                // Проверяем, существует ли файл
                if (File.Exists(name))
                {
                    // Читаем данные из файла
                    string fileContent = File.ReadAllText(name);

                    // Устанавливаем данные в TextBox
                    textBox1.Text = fileContent;

                    MessageBox.Show("Данные из файла успешно прочитаны");
                }
                else
                {
                    MessageBox.Show("Файл не существует.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при чтении файла: {ex.Message}");
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            path = textBoxPath.Text;
            name = path + "\\" + textBoxNameFile.Text;
            try
            {
                // Проверяем, существует ли файл
                if (File.Exists(name))
                {
                    // Удаляем файл
                    File.Delete(name);

                    MessageBox.Show("Файл успешно удален.");
                }
                else
                {
                    MessageBox.Show("Файл не существует.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении файла: {ex.Message}");
            }
        }

        private void buttonJSON_Click(object sender, EventArgs e)
        {
            Form2 secondForm = new Form2();
            secondForm.Show();
        }

        private void buttonXML_Click(object sender, EventArgs e)
        {
            Form3 Form_3 = new Form3();
            Form_3.Show();
        }

        private void buttonZIP_Click(object sender, EventArgs e)
        {
            Form4 Form_4 = new Form4();
            Form_4.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Выберите папку";
            folderBrowserDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                path = folderBrowserDialog.SelectedPath;
            }
            textBoxPath.Text = path;
        }
    }
}