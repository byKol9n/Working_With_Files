using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WorkingWithFiles
{
    public partial class Form2 : Form
    {
        private string jsonFilePath = "C:\\Users\\nikol\\OneDrive\\Рабочий стол\\data.json";

        public Form2()
        {
            InitializeComponent();
        }

        private void buttonWriteJSON_Click(object sender, EventArgs e)
        {

            //Console.WriteLine("Введите данные JSON:");

            // Считываем данные от пользователя

            string jsonData = textBox1.Text;

            try
            {
                // Записываем данные в JSON файл
                File.WriteAllText(jsonFilePath, jsonData);
                MessageBox.Show($"Данные успешно записаны в файл {jsonFilePath}.");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private void buttonReadJSON_Click(object sender, EventArgs e)
        {
            try
            {
                string jsonContent = File.ReadAllText(jsonFilePath);
                string[] substrings = jsonContent.Split(',');

                YourObject yourObject = new YourObject
                {
                    FirstName = substrings[0],
                    LastName = substrings[1],
                    Age = substrings[2]
                };

                string resultJSON = JsonConvert.SerializeObject(yourObject, Newtonsoft.Json.Formatting.Indented);
                MessageBox.Show("Прочитанные данные из файла");
                textBox1.Text= resultJSON;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }
    
            

        private void buttonDelJSON_Click(object sender, EventArgs e)
        {
            try
            {
                //Удаляем файл
                File.Delete(jsonFilePath);
                MessageBox.Show($"Файл {jsonFilePath} успешно удален.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }


        }
    }
    class YourObject
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
    }
}
