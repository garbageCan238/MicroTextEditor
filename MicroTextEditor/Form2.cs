using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroTextEditor
{
    public partial class Form2 : Form
    {
        public static bool isOpened = false;
        private RichTextBox richTextBox = null;
        private int findPos = 0;

        public Form2(Form1 callingForm)
        {
            InitializeComponent();
            isOpened = true;
            richTextBox = callingForm.mainTextBox;
        }

        private void searchNextButton_Click(object sender, EventArgs e)
        {
            try
            {
                selectIfFound();
            }
            catch
            {
                MessageBox.Show("Совпадений не найдено");
                findPos = 0;
            }
        }

        private void selectIfFound()
        {
            if (findPos == richTextBox.Text.Length)
            {
                throw new Exception();
            }
            findPos = richTextBox.Find(searchTextBox.Text, findPos, RichTextBoxFinds.None);
            richTextBox.Select(findPos, searchTextBox.Text.Length);
            findPos += searchTextBox.Text.Length;
        }

        private void replaceButton_Click(object sender, EventArgs e)
        {
            string replacementText = replaceTextBox.Text;
            try
            {
                selectIfFound();
                findPos -= (searchTextBox.Text.Length - replacementText.Length);
                richTextBox.SelectedText = replacementText;
            }
            catch
            {
                MessageBox.Show("Совпадений не найдено");
                findPos = 0;
            }
        }

        private void replaceAllButton_Click(object sender, EventArgs e)
        {
            string replacementText = replaceTextBox.Text;
            findPos = 0;
            while (true)
            {
                try
                {
                    selectIfFound();
                    findPos -= (searchTextBox.Text.Length - replacementText.Length);
                    richTextBox.SelectedText = replacementText;
                }
                catch
                {
                    findPos = 0;
                    return;
                }
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            isOpened = false;
        }
    }
}
