namespace RealView
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.edKeyword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboxProvider = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.imgView = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.comboxPages = new System.Windows.Forms.ComboBox();
            this.resourcesListbox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.edKeyword);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboxProvider);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(967, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Provider 和关键词";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(807, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(123, 40);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "开车！";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // edKeyword
            // 
            this.edKeyword.Location = new System.Drawing.Point(259, 38);
            this.edKeyword.Name = "edKeyword";
            this.edKeyword.Size = new System.Drawing.Size(526, 23);
            this.edKeyword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "关键词：";
            // 
            // comboxProvider
            // 
            this.comboxProvider.FormattingEnabled = true;
            this.comboxProvider.Location = new System.Drawing.Point(26, 38);
            this.comboxProvider.Name = "comboxProvider";
            this.comboxProvider.Size = new System.Drawing.Size(152, 25);
            this.comboxProvider.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.imgView);
            this.groupBox2.Controls.Add(this.btnNext);
            this.groupBox2.Controls.Add(this.btnPrev);
            this.groupBox2.Controls.Add(this.comboxPages);
            this.groupBox2.Controls.Add(this.resourcesListbox);
            this.groupBox2.Location = new System.Drawing.Point(10, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(969, 522);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "资源";
            // 
            // imgView
            // 
            this.imgView.Location = new System.Drawing.Point(254, 26);
            this.imgView.Name = "imgView";
            this.imgView.Size = new System.Drawing.Size(698, 484);
            this.imgView.TabIndex = 4;
            this.imgView.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(180, 485);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(58, 23);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(16, 485);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(58, 23);
            this.btnPrev.TabIndex = 2;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // comboxPages
            // 
            this.comboxPages.FormattingEnabled = true;
            this.comboxPages.Location = new System.Drawing.Point(94, 485);
            this.comboxPages.Name = "comboxPages";
            this.comboxPages.Size = new System.Drawing.Size(70, 25);
            this.comboxPages.TabIndex = 1;
            // 
            // resourcesListbox
            // 
            this.resourcesListbox.FormattingEnabled = true;
            this.resourcesListbox.ItemHeight = 17;
            this.resourcesListbox.Location = new System.Drawing.Point(16, 26);
            this.resourcesListbox.Name = "resourcesListbox";
            this.resourcesListbox.Size = new System.Drawing.Size(222, 446);
            this.resourcesListbox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 648);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "RealView - 老司机与你同在";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboxProvider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edKeyword;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboxPages;
        private System.Windows.Forms.ListBox resourcesListbox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.PictureBox imgView;
    }
}

