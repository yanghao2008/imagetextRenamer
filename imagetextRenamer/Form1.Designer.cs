namespace imagetextRenamer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panImage = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rename_button = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.sort_button = new System.Windows.Forms.Button();
            this.cov_button = new System.Windows.Forms.Button();
            this.bok_button = new System.Windows.Forms.Button();
            this.leg_button = new System.Windows.Forms.Button();
            this.fow_button = new System.Windows.Forms.Button();
            this.con_button = new System.Windows.Forms.Button();
            this.txt_button = new System.Windows.Forms.Button();
            this.txtreset_button = new System.Windows.Forms.Button();
            this.ins_button = new System.Windows.Forms.Button();
            this.att_button = new System.Windows.Forms.Button();
            this.bac_button = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.openFolder_button = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.folderBrowserDialog1 = new imagetextRenamer.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Location = new System.Drawing.Point(12, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(323, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox1_DragDrop);
            this.textBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox1_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "需更名的文件所在的文件夹：";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 88);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(353, 445);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "源";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "格式";
            this.columnHeader2.Width = 50;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "类型";
            this.columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "目标";
            this.columnHeader4.Width = 100;
            // 
            // panImage
            // 
            this.panImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panImage.Location = new System.Drawing.Point(389, 46);
            this.panImage.Name = "panImage";
            this.panImage.Size = new System.Drawing.Size(384, 514);
            this.panImage.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox2.Location = new System.Drawing.Point(13, 539);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(353, 21);
            this.textBox2.TabIndex = 0;
            this.textBox2.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox1_DragDrop);
            this.textBox2.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox1_DragEnter);
            // 
            // rename_button
            // 
            this.rename_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rename_button.Image = ((System.Drawing.Image)(resources.GetObject("rename_button.Image")));
            this.rename_button.Location = new System.Drawing.Point(749, 11);
            this.rename_button.Name = "rename_button";
            this.rename_button.Size = new System.Drawing.Size(24, 24);
            this.rename_button.TabIndex = 4;
            this.rename_button.UseVisualStyleBackColor = true;
            this.rename_button.Click += new System.EventHandler(this.rename_button_Click);
            this.rename_button.MouseEnter += new System.EventHandler(this.rename_button_MouseEnter);
            this.rename_button.MouseLeave += new System.EventHandler(this.rename_button_MouseLeave);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(95, 12);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(25, 23);
            this.btnLast.TabIndex = 10;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(68, 12);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(25, 23);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(41, 12);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(25, 23);
            this.btnPrevious.TabIndex = 8;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(14, 12);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(25, 23);
            this.btnFirst.TabIndex = 7;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // sort_button
            // 
            this.sort_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sort_button.Image = ((System.Drawing.Image)(resources.GetObject("sort_button.Image")));
            this.sort_button.Location = new System.Drawing.Point(719, 12);
            this.sort_button.Name = "sort_button";
            this.sort_button.Size = new System.Drawing.Size(24, 24);
            this.sort_button.TabIndex = 4;
            this.sort_button.UseVisualStyleBackColor = true;
            this.sort_button.Click += new System.EventHandler(this.sort_button_Click);
            this.sort_button.MouseEnter += new System.EventHandler(this.sort_button_MouseEnter);
            this.sort_button.MouseLeave += new System.EventHandler(this.sort_button_MouseLeave);
            // 
            // cov_button
            // 
            this.cov_button.Location = new System.Drawing.Point(160, 12);
            this.cov_button.Name = "cov_button";
            this.cov_button.Size = new System.Drawing.Size(37, 23);
            this.cov_button.TabIndex = 11;
            this.cov_button.Text = "cov";
            this.cov_button.UseVisualStyleBackColor = true;
            this.cov_button.Click += new System.EventHandler(this.cov_button_Click);
            // 
            // bok_button
            // 
            this.bok_button.Location = new System.Drawing.Point(198, 12);
            this.bok_button.Name = "bok_button";
            this.bok_button.Size = new System.Drawing.Size(37, 23);
            this.bok_button.TabIndex = 11;
            this.bok_button.Text = "bok";
            this.bok_button.UseVisualStyleBackColor = true;
            this.bok_button.Click += new System.EventHandler(this.bok_button_Click);
            // 
            // leg_button
            // 
            this.leg_button.Location = new System.Drawing.Point(236, 12);
            this.leg_button.Name = "leg_button";
            this.leg_button.Size = new System.Drawing.Size(37, 23);
            this.leg_button.TabIndex = 11;
            this.leg_button.Text = "leg";
            this.leg_button.UseVisualStyleBackColor = true;
            this.leg_button.Click += new System.EventHandler(this.leg_button_Click);
            // 
            // fow_button
            // 
            this.fow_button.Location = new System.Drawing.Point(274, 12);
            this.fow_button.Name = "fow_button";
            this.fow_button.Size = new System.Drawing.Size(37, 23);
            this.fow_button.TabIndex = 11;
            this.fow_button.Text = "fow";
            this.fow_button.UseVisualStyleBackColor = true;
            this.fow_button.Click += new System.EventHandler(this.fow_button_Click);
            // 
            // con_button
            // 
            this.con_button.Location = new System.Drawing.Point(312, 12);
            this.con_button.Name = "con_button";
            this.con_button.Size = new System.Drawing.Size(37, 23);
            this.con_button.TabIndex = 11;
            this.con_button.Text = "!";
            this.con_button.UseVisualStyleBackColor = true;
            this.con_button.Click += new System.EventHandler(this.con_button_Click);
            // 
            // txt_button
            // 
            this.txt_button.Location = new System.Drawing.Point(350, 12);
            this.txt_button.Name = "txt_button";
            this.txt_button.Size = new System.Drawing.Size(37, 23);
            this.txt_button.TabIndex = 11;
            this.txt_button.Text = "00";
            this.txt_button.UseVisualStyleBackColor = true;
            this.txt_button.Click += new System.EventHandler(this.txt_button_Click);
            // 
            // txtreset_button
            // 
            this.txtreset_button.Location = new System.Drawing.Point(388, 12);
            this.txtreset_button.Name = "txtreset_button";
            this.txtreset_button.Size = new System.Drawing.Size(37, 23);
            this.txtreset_button.TabIndex = 11;
            this.txtreset_button.Text = "00±";
            this.txtreset_button.UseVisualStyleBackColor = true;
            this.txtreset_button.Click += new System.EventHandler(this.txtreset_button_Click);
            // 
            // ins_button
            // 
            this.ins_button.Location = new System.Drawing.Point(426, 12);
            this.ins_button.Name = "ins_button";
            this.ins_button.Size = new System.Drawing.Size(37, 23);
            this.ins_button.TabIndex = 11;
            this.ins_button.Text = "ins";
            this.ins_button.UseVisualStyleBackColor = true;
            this.ins_button.Click += new System.EventHandler(this.ins_button_Click);
            // 
            // att_button
            // 
            this.att_button.Location = new System.Drawing.Point(464, 12);
            this.att_button.Name = "att_button";
            this.att_button.Size = new System.Drawing.Size(37, 23);
            this.att_button.TabIndex = 11;
            this.att_button.Text = "att";
            this.att_button.UseVisualStyleBackColor = true;
            this.att_button.Click += new System.EventHandler(this.att_button_Click);
            // 
            // bac_button
            // 
            this.bac_button.Location = new System.Drawing.Point(502, 12);
            this.bac_button.Name = "bac_button";
            this.bac_button.Size = new System.Drawing.Size(37, 23);
            this.bac_button.TabIndex = 11;
            this.bac_button.Text = "bac";
            this.bac_button.UseVisualStyleBackColor = true;
            this.bac_button.Click += new System.EventHandler(this.bac_button_Click);
            // 
            // close_button
            // 
            this.close_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_button.Image = ((System.Drawing.Image)(resources.GetObject("close_button.Image")));
            this.close_button.Location = new System.Drawing.Point(689, 12);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(24, 24);
            this.close_button.TabIndex = 12;
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            this.close_button.MouseEnter += new System.EventHandler(this.close_button_MouseEnter);
            this.close_button.MouseLeave += new System.EventHandler(this.close_button_MouseLeave);
            // 
            // openFolder_button
            // 
            this.openFolder_button.Image = ((System.Drawing.Image)(resources.GetObject("openFolder_button.Image")));
            this.openFolder_button.Location = new System.Drawing.Point(341, 58);
            this.openFolder_button.Name = "openFolder_button";
            this.openFolder_button.Size = new System.Drawing.Size(24, 24);
            this.openFolder_button.TabIndex = 4;
            this.openFolder_button.UseVisualStyleBackColor = true;
            this.openFolder_button.Click += new System.EventHandler(this.openFolder_button_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.DirectoryPath = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(791, 577);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.bac_button);
            this.Controls.Add(this.att_button);
            this.Controls.Add(this.ins_button);
            this.Controls.Add(this.txtreset_button);
            this.Controls.Add(this.txt_button);
            this.Controls.Add(this.con_button);
            this.Controls.Add(this.fow_button);
            this.Controls.Add(this.leg_button);
            this.Controls.Add(this.bok_button);
            this.Controls.Add(this.cov_button);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.rename_button);
            this.Controls.Add(this.sort_button);
            this.Controls.Add(this.openFolder_button);
            this.Controls.Add(this.panImage);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "imagetextRenamer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel panImage;
        private System.Windows.Forms.Button openFolder_button;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button rename_button;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button sort_button;
        private System.Windows.Forms.Button cov_button;
        private System.Windows.Forms.Button bok_button;
        private System.Windows.Forms.Button leg_button;
        private System.Windows.Forms.Button fow_button;
        private System.Windows.Forms.Button con_button;
        private System.Windows.Forms.Button txt_button;
        private System.Windows.Forms.Button txtreset_button;
        private System.Windows.Forms.Button ins_button;
        private System.Windows.Forms.Button att_button;
        private System.Windows.Forms.Button bac_button;
        private System.Windows.Forms.Button close_button;
        private FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

