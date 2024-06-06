namespace MicroTextEditor
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.replaceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.replaceButton = new System.Windows.Forms.Button();
            this.replaceAllButton = new System.Windows.Forms.Button();
            this.searchNextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Найти:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(111, 17);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(376, 20);
            this.searchTextBox.TabIndex = 1;
            // 
            // replaceTextBox
            // 
            this.replaceTextBox.Location = new System.Drawing.Point(111, 79);
            this.replaceTextBox.Name = "replaceTextBox";
            this.replaceTextBox.Size = new System.Drawing.Size(376, 20);
            this.replaceTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Заменить на:";
            // 
            // replaceButton
            // 
            this.replaceButton.Location = new System.Drawing.Point(111, 164);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(90, 23);
            this.replaceButton.TabIndex = 4;
            this.replaceButton.Text = "Заменить";
            this.replaceButton.UseVisualStyleBackColor = true;
            this.replaceButton.Click += new System.EventHandler(this.replaceButton_Click);
            // 
            // replaceAllButton
            // 
            this.replaceAllButton.Location = new System.Drawing.Point(207, 164);
            this.replaceAllButton.Name = "replaceAllButton";
            this.replaceAllButton.Size = new System.Drawing.Size(90, 23);
            this.replaceAllButton.TabIndex = 5;
            this.replaceAllButton.Text = "Заменить все";
            this.replaceAllButton.UseVisualStyleBackColor = true;
            this.replaceAllButton.Click += new System.EventHandler(this.replaceAllButton_Click);
            // 
            // searchNextButton
            // 
            this.searchNextButton.Location = new System.Drawing.Point(303, 164);
            this.searchNextButton.Name = "searchNextButton";
            this.searchNextButton.Size = new System.Drawing.Size(90, 23);
            this.searchNextButton.TabIndex = 6;
            this.searchNextButton.Text = "Найти далее";
            this.searchNextButton.UseVisualStyleBackColor = true;
            this.searchNextButton.Click += new System.EventHandler(this.searchNextButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 201);
            this.Controls.Add(this.searchNextButton);
            this.Controls.Add(this.replaceAllButton);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.replaceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(520, 240);
            this.MinimumSize = new System.Drawing.Size(520, 240);
            this.Name = "Form2";
            this.Text = "Найти и заменить";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.TextBox replaceTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button replaceButton;
        private System.Windows.Forms.Button replaceAllButton;
        private System.Windows.Forms.Button searchNextButton;
    }
}