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
                driveList.Add($"��������: {drive.Name}");
                driveList.Add($"���: {drive.DriveType}");
                if (drive.IsReady)
                {
                    driveList.Add($"����� �����: {drive.TotalSize}");
                    driveList.Add($"��������� ������������: {drive.TotalFreeSpace}");
                    driveList.Add($"�����: {drive.VolumeLabel}");
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
                listView1.Items.Add("�����������:");
                string[] dirs = Directory.GetDirectories(dirNameC);
                foreach (string s in dirs)
                {
                    listView1.Items.Add(s);
                }
                listView1.Items.Add("�����:");
                string[] files = Directory.GetFiles(dirNameC);
                foreach (string s in files)
                {
                    listView1.Items.Add(s);
                }
            }
            if (Directory.Exists(dirNameD))
            {
                listView1.Items.Add("�����������:");
                string[] dirs = Directory.GetDirectories(dirNameD);
                foreach (string s in dirs)
                {
                    listView1.Items.Add(s);
                }
                listView1.Items.Add("�����:");
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
                MessageBox.Show($"���� {name} ������� ������.");
            }
            catch (Exception ex)
            {

                MessageBox.Show($"������ ��� �������� �����: {ex.Message}");
            }
        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            path = textBoxPath.Text;
            name = path + "\\" + textBoxNameFile.Text;
            try
            {
                // ������� ������ StreamWriter ��� ������ � ����
                using (StreamWriter writer = new StreamWriter(name))
                {
                    // ���������� ������ � ����
                    string textFromTextBox = textBox1.Text;
                    writer.WriteLine(textFromTextBox);
                }
                MessageBox.Show("������ ������� �������� � ����.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ ��� ������ � ����: {ex.Message}");
            }
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            path = textBoxPath.Text;
            name = path + "\\" + textBoxNameFile.Text;
            try
            {
                // ���������, ���������� �� ����
                if (File.Exists(name))
                {
                    // ������ ������ �� �����
                    string fileContent = File.ReadAllText(name);

                    // ������������� ������ � TextBox
                    textBox1.Text = fileContent;

                    MessageBox.Show("������ �� ����� ������� ���������");
                }
                else
                {
                    MessageBox.Show("���� �� ����������.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ ��� ������ �����: {ex.Message}");
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            path = textBoxPath.Text;
            name = path + "\\" + textBoxNameFile.Text;
            try
            {
                // ���������, ���������� �� ����
                if (File.Exists(name))
                {
                    // ������� ����
                    File.Delete(name);

                    MessageBox.Show("���� ������� ������.");
                }
                else
                {
                    MessageBox.Show("���� �� ����������.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ ��� �������� �����: {ex.Message}");
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
            folderBrowserDialog.Description = "�������� �����";
            folderBrowserDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                path = folderBrowserDialog.SelectedPath;
            }
            textBoxPath.Text = path;
        }
    }
}