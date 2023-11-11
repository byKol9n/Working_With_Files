using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WorkingWithFiles
{
    public partial class Form3 : Form
    {
        private string xmlFilePath = "C:\\Users\\nikol\\OneDrive\\Рабочий стол\\data.xml";
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonWriteXML_Click(object sender, EventArgs e)
        {
            try
            {

                // Шаг 2: Запись новых данных в файл
                string xmlData = textBox1.Text;
                File.WriteAllText(xmlFilePath, xmlData);
                MessageBox.Show($"Данные успешно записаны в файл {xmlFilePath}.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private void buttonReadXML_Click(object sender, EventArgs e)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlFilePath);

                XmlNodeList userNodes = xmlDoc.SelectNodes("/users/user");
                string result = "";

                foreach (XmlNode userNode in userNodes)
                {
                    string username = userNode.Attributes["username"].Value;
                    string company = userNode.SelectSingleNode("company").InnerText;
                    string age = userNode.SelectSingleNode("age").InnerText;

                    result += $"Username: {username}\r\n";
                    result += $"Company: {company}\r\n";
                    result += $"Age: {age}\r\n";
                    result += "\r\n";
                }
                textBox1.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при чтении XML: {ex.Message}");
            }
        }

        private void buttonDelXML_Click(object sender, EventArgs e)
        {
            try
            {
                // Шаг 4: Удаление файла
                File.Delete(xmlFilePath);
                MessageBox.Show($"Файл {xmlFilePath} успешно удален.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }
        class User
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Company { get; set; }
        }
    }
}
