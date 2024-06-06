namespace MicroTextEditor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textStatusStrip = new System.Windows.Forms.StatusStrip();
            this.wordCountStatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.cursorPosStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainTextBox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontsStripButton = new System.Windows.Forms.ToolStripButton();
            this.undoStripButton = new System.Windows.Forms.ToolStripButton();
            this.redoStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.copyStripButton = new System.Windows.Forms.ToolStripButton();
            this.insertStripButton = new System.Windows.Forms.ToolStripButton();
            this.cutStripButton = new System.Windows.Forms.ToolStripButton();
            this.searchStripButton = new System.Windows.Forms.ToolStripButton();
            this.textToolStrip = new System.Windows.Forms.ToolStrip();
            openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.textStatusStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.textToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            openToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            openToolStripMenuItem.Text = "Открыть";
            openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(932, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.SaveAsToolStripMenuItem,
            this.printToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.createToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.createToolStripMenuItem.Text = "Создать";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.CreateToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.SaveAsToolStripMenuItem.Text = "Сохранить как";
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.printToolStripMenuItem.Text = "Печать";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.PrintToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.infoToolStripMenuItem.Text = "Справка";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // textStatusStrip
            // 
            this.textStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordCountStatusBar,
            this.cursorPosStripStatusLabel});
            this.textStatusStrip.Location = new System.Drawing.Point(0, 392);
            this.textStatusStrip.Name = "textStatusStrip";
            this.textStatusStrip.Size = new System.Drawing.Size(932, 22);
            this.textStatusStrip.TabIndex = 1;
            this.textStatusStrip.Text = "statusStrip1";
            // 
            // wordCountStatusBar
            // 
            this.wordCountStatusBar.Name = "wordCountStatusBar";
            this.wordCountStatusBar.Size = new System.Drawing.Size(47, 17);
            this.wordCountStatusBar.Text = "Слов: 0";
            // 
            // cursorPosStripStatusLabel
            // 
            this.cursorPosStripStatusLabel.Name = "cursorPosStripStatusLabel";
            this.cursorPosStripStatusLabel.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.cursorPosStripStatusLabel.Size = new System.Drawing.Size(139, 17);
            this.cursorPosStripStatusLabel.Text = "Строка 1, столбец 1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mainTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 2, 10, 10);
            this.panel1.Size = new System.Drawing.Size(932, 341);
            this.panel1.TabIndex = 4;
            // 
            // mainTextBox
            // 
            this.mainTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainTextBox.ContextMenuStrip = this.contextMenuStrip1;
            this.mainTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mainTextBox.HideSelection = false;
            this.mainTextBox.Location = new System.Drawing.Point(10, 2);
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.Size = new System.Drawing.Size(912, 329);
            this.mainTextBox.TabIndex = 0;
            this.mainTextBox.Text = "";
            this.mainTextBox.SelectionChanged += new System.EventHandler(this.MainTextBox_SelectionChanged);
            this.mainTextBox.TextChanged += new System.EventHandler(this.MainTextBox_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.вырезатьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 70);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.ShowShortcutKeys = false;
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.ShowShortcutKeys = false;
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.вставитьToolStripMenuItem_Click);
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.ShowShortcutKeys = false;
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.вырезатьToolStripMenuItem.Text = "Вырезать";
            this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.вырезатьToolStripMenuItem_Click);
            // 
            // fontsStripButton
            // 
            this.fontsStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fontsStripButton.Image = global::MicroTextEditor.Properties.Resources.font_light;
            this.fontsStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fontsStripButton.Name = "fontsStripButton";
            this.fontsStripButton.Size = new System.Drawing.Size(23, 22);
            this.fontsStripButton.Text = "Шрифт";
            this.fontsStripButton.Click += new System.EventHandler(this.FontsStripButton_Click);
            // 
            // undoStripButton
            // 
            this.undoStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.undoStripButton.Image = global::MicroTextEditor.Properties.Resources.undo_light;
            this.undoStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.undoStripButton.Name = "undoStripButton";
            this.undoStripButton.Size = new System.Drawing.Size(23, 22);
            this.undoStripButton.Text = "Отменить";
            this.undoStripButton.Click += new System.EventHandler(this.UndoStripButton_Click);
            // 
            // redoStripButton
            // 
            this.redoStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.redoStripButton.Image = global::MicroTextEditor.Properties.Resources.unundo_light;
            this.redoStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.redoStripButton.Name = "redoStripButton";
            this.redoStripButton.Size = new System.Drawing.Size(23, 22);
            this.redoStripButton.Text = "Восстановить";
            this.redoStripButton.Click += new System.EventHandler(this.RedoStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // copyStripButton
            // 
            this.copyStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyStripButton.Image = global::MicroTextEditor.Properties.Resources.copy_light;
            this.copyStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyStripButton.Name = "copyStripButton";
            this.copyStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyStripButton.Text = "Копировать";
            this.copyStripButton.Click += new System.EventHandler(this.CopyStripButton_Click);
            // 
            // insertStripButton
            // 
            this.insertStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.insertStripButton.Image = global::MicroTextEditor.Properties.Resources.paste_light;
            this.insertStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.insertStripButton.Name = "insertStripButton";
            this.insertStripButton.Size = new System.Drawing.Size(23, 22);
            this.insertStripButton.Text = "Вставить";
            this.insertStripButton.Click += new System.EventHandler(this.PasteStripButton_Click);
            // 
            // cutStripButton
            // 
            this.cutStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutStripButton.Image = global::MicroTextEditor.Properties.Resources.scissor_light;
            this.cutStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutStripButton.Name = "cutStripButton";
            this.cutStripButton.Size = new System.Drawing.Size(23, 22);
            this.cutStripButton.Text = "Вырезать";
            this.cutStripButton.Click += new System.EventHandler(this.CutStripButton_Click);
            // 
            // searchStripButton
            // 
            this.searchStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.searchStripButton.Image = global::MicroTextEditor.Properties.Resources.search_light;
            this.searchStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchStripButton.Name = "searchStripButton";
            this.searchStripButton.Size = new System.Drawing.Size(23, 22);
            this.searchStripButton.Text = "Поиск";
            this.searchStripButton.Click += new System.EventHandler(this.SearchStripButton_Click);
            // 
            // textToolStrip
            // 
            this.textToolStrip.BackColor = System.Drawing.SystemColors.Control;
            this.textToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textToolStrip.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textToolStrip.GripMargin = new System.Windows.Forms.Padding(10);
            this.textToolStrip.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.textToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontsStripButton,
            this.undoStripButton,
            this.redoStripButton,
            this.toolStripSeparator1,
            this.copyStripButton,
            this.insertStripButton,
            this.cutStripButton,
            this.searchStripButton});
            this.textToolStrip.Location = new System.Drawing.Point(0, 24);
            this.textToolStrip.Name = "textToolStrip";
            this.textToolStrip.Padding = new System.Windows.Forms.Padding(0, 2, 1, 0);
            this.textToolStrip.Size = new System.Drawing.Size(932, 27);
            this.textToolStrip.TabIndex = 3;
            this.textToolStrip.Text = "Панель управления";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(932, 414);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textStatusStrip);
            this.Controls.Add(this.textToolStrip);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "Form1";
            this.Text = "Micro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Resize += new System.EventHandler(this.MainTextBox_SelectionChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.textStatusStrip.ResumeLayout(false);
            this.textStatusStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.textToolStrip.ResumeLayout(false);
            this.textToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.StatusStrip textStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel wordCountStatusBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton fontsStripButton;
        private System.Windows.Forms.ToolStripButton undoStripButton;
        private System.Windows.Forms.ToolStripButton redoStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton copyStripButton;
        private System.Windows.Forms.ToolStripButton insertStripButton;
        private System.Windows.Forms.ToolStripButton cutStripButton;
        private System.Windows.Forms.ToolStripButton searchStripButton;
        private System.Windows.Forms.ToolStrip textToolStrip;
        private System.Windows.Forms.ToolStripStatusLabel cursorPosStripStatusLabel;
        public System.Windows.Forms.RichTextBox mainTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
    }
}

