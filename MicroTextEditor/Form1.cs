using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MicroTextEditor
{
    public partial class Form1 : Form
    {
        private String filePath = null;
        private string lastSavedText = "";
        private String _fileName;
        private String fileName
        {
            get { return _fileName; }
            set
            {
                _fileName = value;
                Text = "Micro" + " - " + _fileName;
            }
        }
        private bool _isSaved = true;
        private bool isSaved
        {
            get
            {
                return _isSaved;
            }
            set
            {
                _isSaved = value;
                if (_isSaved)
                {
                    lastSavedText = mainTextBox.Text;
                    if (Text.Last() == '*')
                        Text = Text.Remove(Text.Length - 1);
                }
                if (!_isSaved)
                {
                    if (Text.Last() != '*')
                        Text += '*';
                }
            }
        }
        private int _wordCount;
        private int wordCount
        {
            get
            {
                return _wordCount;
            }
            set
            {
                _wordCount = value;
                wordCountStatusBar.Text = "Слов: " + _wordCount;
            }
        }


        public Form1()
        {
            InitializeComponent();
            fileName = "Без имени";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isSaved)
            {
                DialogResult exitDialogResult = MessageBox.Show(
                    "Сохранить изменения перед закрытием?",
                    "Файл не сохранен",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);
                switch (exitDialogResult)
                {
                    case DialogResult.Yes:
                        SaveFile();
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files(*.txt)|*.txt|Rich Text files(*.rtf)|*.rtf|All files(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            fileName = openFileDialog.FileName.Split('\\').Last();
            filePath = openFileDialog.FileName;

            if (fileName.Split('.').Last() != "rtf")
                mainTextBox.Text = System.IO.File.ReadAllText(filePath);
            else
                mainTextBox.LoadFile(filePath);

            isSaved = true;
            MessageBox.Show("Файл открыт");
        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileName = "Без имени";
            filePath = null;
            mainTextBox.Text = "";
            isSaved = true;
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void SaveFile()
        {
            if (filePath == null)
                SaveFileAs();
            else if (fileName.Split('.').Last() != "rtf")
                System.IO.File.WriteAllText(filePath, mainTextBox.Text);
            else
                mainTextBox.SaveFile(filePath);
            isSaved = true;
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileAs();
        }

        private void SaveFileAs()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|Rich Text files(*.rtf)|*.rtf|All files(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            fileName = saveFileDialog.FileName.Split('\\').Last();
            filePath = saveFileDialog.FileName;

            if (fileName.Split('.').Last() != "rtf")
                System.IO.File.WriteAllText(filePath, mainTextBox.Text);
            else
                mainTextBox.SaveFile(filePath);
            MessageBox.Show("Файл сохранен");
            isSaved = true;
        }

        private void MainTextBox_TextChanged(object sender, EventArgs e)
        {
            wordCount = mainTextBox.Text.Split(" ,.:;\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Count();
            isSaved = (lastSavedText == mainTextBox.Text ? true : false);
        }

        private void MainTextBox_SelectionChanged(object sender, EventArgs e)
        {
            int selectionPos = mainTextBox.SelectionStart;

            int row = mainTextBox.GetLineFromCharIndex(selectionPos) + 1;
            int column = selectionPos - mainTextBox.GetFirstCharIndexFromLine(row - 1) + 1;

            cursorPosStripStatusLabel.Text = "Строка " + row + ", " + "Столбец " + column;
        }

        private void CopyStripButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Copy();
        }

        private void PasteStripButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Paste();
        }

        private void SearchStripButton_Click(object sender, EventArgs e)
        {
            if (!Form2.isOpened)
            {
                Form2 searchForm = new Form2(this);
                searchForm.Show();
            }
        }

        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument p = new PrintDocument();
            printDialog.Document = p;

            var font = mainTextBox.Font;
            var margins = p.DefaultPageSettings.Margins;
            var layoutArea = new RectangleF(
                margins.Left,
                margins.Top,
                p.DefaultPageSettings.PrintableArea.Width - (margins.Left + margins.Right),
                p.DefaultPageSettings.PrintableArea.Height - (margins.Top + margins.Bottom));
            var layoutSize = layoutArea.Size;
            layoutSize.Height = layoutSize.Height - font.GetHeight();
            var brush = new SolidBrush(Color.Black);

            var remainingText = mainTextBox.Text;

            p.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
            {
                int charsFitted, linesFilled;

                var realsize = e1.Graphics.MeasureString(
                    remainingText,
                    font,
                    layoutSize,
                    StringFormat.GenericDefault,
                    out charsFitted,
                    out linesFilled);

                var fitsOnPage = remainingText.Substring(0, charsFitted); 
                remainingText = remainingText.Substring(charsFitted).Trim();

                e1.Graphics.DrawString(
                    fitsOnPage,
                    font,
                    brush,
                    layoutArea);

                e1.HasMorePages = remainingText.Length > 0;
            };
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                p.Print();
            }
        }

        private void FontsStripButton_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true;
            if (mainTextBox.SelectionLength != 0)
            {
                fontDialog.Color = mainTextBox.SelectionColor;
                fontDialog.Font = mainTextBox.SelectionFont;
            }
            if (fontDialog.ShowDialog() != DialogResult.Cancel)
            {
                mainTextBox.SelectionFont = fontDialog.Font;
                mainTextBox.SelectionColor = fontDialog.Color;
            }
        }

        private void CutStripButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Cut();
        }

        private void UndoStripButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Undo();
        }

        private void RedoStripButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Redo();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программу сделал Ямалиев Рашит, группа 2231117", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyStripButton_Click(sender, e);
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasteStripButton_Click(sender, e);
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CutStripButton_Click(sender, e);
        }
    }
}
