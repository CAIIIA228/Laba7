
namespace manager
{
    partial class Mgr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mgr));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.fileTypeLabel = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.cutButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.goButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(9, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя Файла";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(9, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тип файла";
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.filePathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filePathTextBox.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.filePathTextBox.Location = new System.Drawing.Point(42, 12);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(707, 20);
            this.filePathTextBox.TabIndex = 2;
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fileNameLabel.Location = new System.Drawing.Point(82, 399);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(0, 13);
            this.fileNameLabel.TabIndex = 5;
            // 
            // fileTypeLabel
            // 
            this.fileTypeLabel.AutoSize = true;
            this.fileTypeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fileTypeLabel.Location = new System.Drawing.Point(82, 428);
            this.fileTypeLabel.Name = "fileTypeLabel";
            this.fileTypeLabel.Size = new System.Drawing.Size(0, 13);
            this.fileTypeLabel.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.listView1.ForeColor = System.Drawing.SystemColors.Info;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.iconList;
            this.listView1.Location = new System.Drawing.Point(12, 38);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(691, 358);
            this.listView1.SmallImageList = this.iconList;
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "3d.ico");
            this.iconList.Images.SetKeyName(1, "accessibility.ico");
            this.iconList.Images.SetKeyName(2, "account.ico");
            this.iconList.Images.SetKeyName(3, "alert.ico");
            this.iconList.Images.SetKeyName(4, "appearance.ico");
            this.iconList.Images.SetKeyName(5, "archive 1.ico");
            this.iconList.Images.SetKeyName(6, "archive 2.ico");
            this.iconList.Images.SetKeyName(7, "cd 1.ico");
            this.iconList.Images.SetKeyName(8, "cd 2.ico");
            this.iconList.Images.SetKeyName(9, "contacts.ico");
            this.iconList.Images.SetKeyName(10, "control panel.ico");
            this.iconList.Images.SetKeyName(11, "desktop.ico");
            this.iconList.Images.SetKeyName(12, "documents.ico");
            this.iconList.Images.SetKeyName(13, "downloads.ico");
            this.iconList.Images.SetKeyName(14, "drive net off.ico");
            this.iconList.Images.SetKeyName(15, "drive net.ico");
            this.iconList.Images.SetKeyName(16, "drive os.ico");
            this.iconList.Images.SetKeyName(17, "drive server.ico");
            this.iconList.Images.SetKeyName(18, "drive unknown.ico");
            this.iconList.Images.SetKeyName(19, "drive.ico");
            this.iconList.Images.SetKeyName(20, "dvd 1.ico");
            this.iconList.Images.SetKeyName(21, "dvd 2.ico");
            this.iconList.Images.SetKeyName(22, "explorer.ico");
            this.iconList.Images.SetKeyName(23, "favorites.ico");
            this.iconList.Images.SetKeyName(24, "file 1.ico");
            this.iconList.Images.SetKeyName(25, "file 2.ico");
            this.iconList.Images.SetKeyName(26, "file 3.ico");
            this.iconList.Images.SetKeyName(27, "file 4.ico");
            this.iconList.Images.SetKeyName(28, "folder 1.ico");
            this.iconList.Images.SetKeyName(29, "folder 2.ico");
            this.iconList.Images.SetKeyName(30, "folder 3.ico");
            this.iconList.Images.SetKeyName(31, "folder 4.ico");
            this.iconList.Images.SetKeyName(32, "games.ico");
            this.iconList.Images.SetKeyName(33, "hardware 2.ico");
            this.iconList.Images.SetKeyName(34, "internet.ico");
            this.iconList.Images.SetKeyName(35, "libraries 1.ico");
            this.iconList.Images.SetKeyName(36, "libraries 2.ico");
            this.iconList.Images.SetKeyName(37, "links.ico");
            this.iconList.Images.SetKeyName(38, "music.ico");
            this.iconList.Images.SetKeyName(39, "network.ico");
            this.iconList.Images.SetKeyName(40, "notes.ico");
            this.iconList.Images.SetKeyName(41, "pc.ico");
            this.iconList.Images.SetKeyName(42, "pictures 1.ico");
            this.iconList.Images.SetKeyName(43, "pictures 2.ico");
            this.iconList.Images.SetKeyName(44, "programs.ico");
            this.iconList.Images.SetKeyName(45, "quick access 1.ico");
            this.iconList.Images.SetKeyName(46, "quick access 2.ico");
            this.iconList.Images.SetKeyName(47, "script.ico");
            this.iconList.Images.SetKeyName(48, "search.ico");
            this.iconList.Images.SetKeyName(49, "system 1.ico");
            this.iconList.Images.SetKeyName(50, "time.ico");
            this.iconList.Images.SetKeyName(51, "trash empty.ico");
            this.iconList.Images.SetKeyName(52, "trash.ico");
            this.iconList.Images.SetKeyName(53, "usb 1.ico");
            this.iconList.Images.SetKeyName(54, "usb 4.ico");
            this.iconList.Images.SetKeyName(55, "user.ico");
            this.iconList.Images.SetKeyName(56, "video.ico");
            // 
            // cutButton
            // 
            this.cutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cutButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cutButton.Location = new System.Drawing.Point(709, 143);
            this.cutButton.Name = "cutButton";
            this.cutButton.Size = new System.Drawing.Size(79, 28);
            this.cutButton.TabIndex = 12;
            this.cutButton.Text = "Переместить";
            this.cutButton.UseVisualStyleBackColor = true;
            this.cutButton.Click += new System.EventHandler(this.cutButton_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(709, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Буфер обмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // insertButton
            // 
            this.insertButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.insertButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.insertButton.Location = new System.Drawing.Point(709, 109);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(79, 28);
            this.insertButton.TabIndex = 10;
            this.insertButton.Text = "Вставить";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.copyButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.copyButton.Location = new System.Drawing.Point(709, 75);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(79, 28);
            this.copyButton.TabIndex = 9;
            this.copyButton.Text = "Копировать";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteButton.Location = new System.Drawing.Point(709, 41);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(79, 28);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // goButton
            // 
            this.goButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.goButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.goButton.Location = new System.Drawing.Point(755, 9);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(33, 26);
            this.goButton.TabIndex = 4;
            this.goButton.Text = "GO";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // backButton
            // 
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.backButton.Location = new System.Drawing.Point(12, 9);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(24, 26);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "<-";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::manager.Properties.Resources._715a3d6dcdd4225528d79f104e2e0785;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(802, 451);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Mgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BackgroundImage = global::manager.Properties.Resources.original_gif_50ac6fff75ae29a33d56ebbe7496d429;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cutButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.fileTypeLabel);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mgr";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Mgr_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label fileTypeLabel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cutButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

