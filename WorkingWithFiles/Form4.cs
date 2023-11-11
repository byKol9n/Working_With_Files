using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkingWithFiles
{
    public partial class Form4 : Form
    {
        private string zipFilePath = "C:\\Users\\nikol\\OneDrive\\Рабочий стол\\archive.zip";
        private string fileToAdd; // Путь к файлу, который будет добавлен в архив
        private string extractFolder = "C:\\Users\\nikol\\OneDrive\\Рабочий стол\\extracted"; // Папка для разархивированных файлов

        public Form4()
        {
            InitializeComponent();
        }

        private void buttonCreateZIP_Click(object sender, EventArgs e)
        {

            try
            {
                // Шаг 1: Создаем ZIP-архив
                using (var archive = ZipFile.Open(zipFilePath, ZipArchiveMode.Create));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private void buttonAddZIP_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                openFileDialog.Title = "Выберите файл"; // Заголовок диалогового окна
                openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*"; // Фильтр файлов
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // Начальная директория

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileToAdd = openFileDialog.FileName;
                    MessageBox.Show("Выбранный файл: " + fileToAdd);
                }
                using (var archive = new ZipArchive(File.Create(zipFilePath), ZipArchiveMode.Create))
                {
                    if (File.Exists(fileToAdd))
                    {
                        archive.CreateEntryFromFile(fileToAdd, Path.GetFileName(fileToAdd));
                        MessageBox.Show($"Файл {fileToAdd} успешно добавлен в архив {zipFilePath}.");
                    }
                    else
                    {
                        MessageBox.Show($"Файл {fileToAdd} не существует.");
                        return;
                    }
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private void buttonUnzipZIP_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(extractFolder);
            try
            {
                using (var archive = ZipFile.Open(zipFilePath, ZipArchiveMode.Read))
                {
                    foreach (var entry in archive.Entries)
                    {
                        entry.ExtractToFile(Path.Combine(extractFolder, entry.Name), true);
                    }
                }

                // Выводим информацию о разархивированных файлах
                foreach (var file in Directory.GetFiles(extractFolder))
                {
                    FileInfo fileInfo = new FileInfo(file);
                    string ZIPContent = $"Имя файла: {fileInfo.Name}, Размер: {fileInfo.Length} байт";
                    textBox1.Text = ZIPContent;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private void buttonDelZIP_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete(fileToAdd);
                File.Delete(zipFilePath);
                Directory.Delete(extractFolder, true);
                MessageBox.Show($"Файл {fileToAdd}, а также архив {zipFilePath} успешно удалены.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");

            }
        }
    }
}
