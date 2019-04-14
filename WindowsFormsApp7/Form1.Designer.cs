namespace WindowsFormsApp7
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
            this.normText = new System.Windows.Forms.TextBox();
            this.encrText = new System.Windows.Forms.TextBox();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.encrBtn = new System.Windows.Forms.Button();
            this.decrBtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // normText
            // 
            this.normText.Location = new System.Drawing.Point(12, 27);
            this.normText.Multiline = true;
            this.normText.Name = "normText";
            this.normText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.normText.Size = new System.Drawing.Size(328, 100);
            this.normText.TabIndex = 0;
            // 
            // encrText
            // 
            this.encrText.Location = new System.Drawing.Point(12, 244);
            this.encrText.Multiline = true;
            this.encrText.Name = "encrText";
            this.encrText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.encrText.Size = new System.Drawing.Size(328, 129);
            this.encrText.TabIndex = 1;
            // 
            // keyBox
            // 
            this.keyBox.Location = new System.Drawing.Point(12, 184);
            this.keyBox.Multiline = true;
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(328, 54);
            this.keyBox.TabIndex = 3;
            // 
            // encrBtn
            // 
            this.encrBtn.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encrBtn.Location = new System.Drawing.Point(12, 133);
            this.encrBtn.Name = "encrBtn";
            this.encrBtn.Size = new System.Drawing.Size(160, 46);
            this.encrBtn.TabIndex = 4;
            this.encrBtn.Text = "Зашифровать";
            this.encrBtn.UseVisualStyleBackColor = true;
            this.encrBtn.Click += new System.EventHandler(this.encrBtn_Click);
            // 
            // decrBtn
            // 
            this.decrBtn.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decrBtn.Location = new System.Drawing.Point(178, 133);
            this.decrBtn.Name = "decrBtn";
            this.decrBtn.Size = new System.Drawing.Size(162, 45);
            this.decrBtn.TabIndex = 5;
            this.decrBtn.Text = "Расшифровать";
            this.decrBtn.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(347, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьФайлToolStripMenuItem,
            this.открытьФайлToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // сохранитьФайлToolStripMenuItem
            // 
            this.сохранитьФайлToolStripMenuItem.Name = "сохранитьФайлToolStripMenuItem";
            this.сохранитьФайлToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьФайлToolStripMenuItem.Text = "Сохранить файл";
            this.сохранитьФайлToolStripMenuItem.Click += new System.EventHandler(this.сохранитьФайлToolStripMenuItem_Click);
            // 
            // открытьФайлToolStripMenuItem
            // 
            this.открытьФайлToolStripMenuItem.Name = "открытьФайлToolStripMenuItem";
            this.открытьФайлToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьФайлToolStripMenuItem.Text = "Открыть файл";
            this.открытьФайлToolStripMenuItem.Click += new System.EventHandler(this.открытьФайлToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 384);
            this.Controls.Add(this.decrBtn);
            this.Controls.Add(this.encrBtn);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.encrText);
            this.Controls.Add(this.normText);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox normText;
        private System.Windows.Forms.TextBox encrText;
        private System.Windows.Forms.TextBox keyBox;
        private System.Windows.Forms.Button encrBtn;
        private System.Windows.Forms.Button decrBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьФайлToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

