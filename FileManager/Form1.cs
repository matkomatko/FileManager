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

namespace FileManager
{
    public partial class FileManager : Form
    {
        public FileManager()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void GetFileNamesIntoListbox(string path, ListBox listbox, Button button,Label label)
        {
            string[] filePaths = Directory.GetFiles(path);
            foreach (string item in filePaths)
            {
                listbox.Items.Add(item.Remove(0, path.Count() + 1));
            }
            button.Enabled = false;
            label.Text = listbox.Items.Count.ToString();
        }
        public void FindDuplicates(ListBox listbox1, ListBox listbox2, ListBox listbox3)
        {
            foreach (string item in listbox1.Items)
            {
                foreach (string item2 in FilesFromB.Items)
                {
                    if (item == item2) Duplicates.Items.Add(item);
                }
            }
            DuplicateCount.Text = listbox3.Items.Count.ToString();
        }
        public void DeleteDuplicates(DialogResult result, TextBox path)
        {
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                foreach (string item in Duplicates.Items)
                {
                    if (File.Exists(Path.Combine(path.Text, item)))
                    {
                        File.Delete(Path.Combine(path.Text, item));
                    }
                }
                ResetAll();
            }
        }
        public void ResetAll()
        {
            FilesFromA.Items.Clear();
            FilesFromB.Items.Clear();
            Duplicates.Items.Clear();
            ReadA.Enabled = true;
            PathA.Enabled = true;
            ReadB.Enabled = true;
            PathB.Enabled = true;
            DeleteA.Enabled = false;
            DeleteB.Enabled = false;
            DuplicateCount.Text = "";
            FilesFromACount.Text = "";
            FilesFromBCount.Text = "";
        }

        private void ReadA_Click(object sender, EventArgs e)
        {
            GetFileNamesIntoListbox(@PathA.Text, FilesFromA, ReadA,FilesFromACount);
            PathA.Enabled = false;
            ReadA.Enabled = false;
        }

        private void ReadB_Click(object sender, EventArgs e)
        {
            GetFileNamesIntoListbox(@PathB.Text, FilesFromB, ReadB, FilesFromBCount);
            PathB.Enabled = false;
            ReadB.Enabled = false;
        }

        private void DeleteA_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Do you want to delete files in directory A that appear in both directory A and B?", "Delete Files?", MessageBoxButtons.YesNo);
            DeleteDuplicates(result, PathA);
        }

        private void DeleteB_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Do you want to delete files in directory B that appear in both directory A and B?", "Delete Files?", MessageBoxButtons.YesNo);
            DeleteDuplicates(result, PathB);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

        private void FindDupButton_Click(object sender, EventArgs e)
        {
            Duplicates.Items.Clear();
            FindDuplicates(FilesFromA, FilesFromB, Duplicates);
            DeleteA.Enabled = true;
            DeleteB.Enabled = true;
        }
    }
}
