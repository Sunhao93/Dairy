﻿namespace DiaryManager
{
    partial class frmMain
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_bold = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Italic = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_underline = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBox_style = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBox_size = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton_color = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_alignLeft = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_alignMiddle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_alignRight = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建日记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读取日记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.退出XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.撤销ZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重做ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.剪切CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于日记管理器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.未登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.获取最新日记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上传当前日记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workspace = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.addNewMan = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.weather = new System.Windows.Forms.Label();
            this.buttonCheckManage = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openJPGDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_bold,
            this.toolStripButton_Italic,
            this.toolStripButton_underline,
            this.toolStripComboBox_style,
            this.toolStripComboBox_size,
            this.toolStripButton_color,
            this.toolStripSeparator1,
            this.toolStripButton_alignLeft,
            this.toolStripButton_alignMiddle,
            this.toolStripButton_alignRight,
            this.toolStripSeparator2,
            this.toolStripButton1});
            this.toolStrip.Location = new System.Drawing.Point(0, 25);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1056, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            this.toolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip_ItemClicked);
            // 
            // toolStripButton_bold
            // 
            this.toolStripButton_bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_bold.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_bold.Image")));
            this.toolStripButton_bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_bold.Name = "toolStripButton_bold";
            this.toolStripButton_bold.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_bold.Text = "加粗";
            this.toolStripButton_bold.Click += new System.EventHandler(this.toolStripButton_bold_Click);
            // 
            // toolStripButton_Italic
            // 
            this.toolStripButton_Italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Italic.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Italic.Image")));
            this.toolStripButton_Italic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Italic.Name = "toolStripButton_Italic";
            this.toolStripButton_Italic.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Italic.Text = "斜体";
            this.toolStripButton_Italic.Click += new System.EventHandler(this.toolStripButton_Italic_Click);
            // 
            // toolStripButton_underline
            // 
            this.toolStripButton_underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_underline.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_underline.Image")));
            this.toolStripButton_underline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_underline.Name = "toolStripButton_underline";
            this.toolStripButton_underline.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_underline.Text = "下划线";
            this.toolStripButton_underline.Click += new System.EventHandler(this.toolStripButton_underline_Click);
            // 
            // toolStripComboBox_style
            // 
            this.toolStripComboBox_style.Name = "toolStripComboBox_style";
            this.toolStripComboBox_style.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBox_style.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox_style_SelectedIndexChanged);
            this.toolStripComboBox_style.Click += new System.EventHandler(this.toolStripComboBox_style_Click);
            // 
            // toolStripComboBox_size
            // 
            this.toolStripComboBox_size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_size.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.toolStripComboBox_size.Name = "toolStripComboBox_size";
            this.toolStripComboBox_size.Size = new System.Drawing.Size(75, 25);
            this.toolStripComboBox_size.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox_size_SelectedIndexChanged);
            this.toolStripComboBox_size.Click += new System.EventHandler(this.toolStripComboBox_size_Click);
            // 
            // toolStripButton_color
            // 
            this.toolStripButton_color.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_color.Image = global::DiaryManager.Properties.Resources.TextFillColorPicker;
            this.toolStripButton_color.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_color.Name = "toolStripButton_color";
            this.toolStripButton_color.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_color.Text = "更改颜色";
            this.toolStripButton_color.Click += new System.EventHandler(this.toolStripButton_color_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_alignLeft
            // 
            this.toolStripButton_alignLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_alignLeft.Image = global::DiaryManager.Properties.Resources.AlignLeft;
            this.toolStripButton_alignLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_alignLeft.Name = "toolStripButton_alignLeft";
            this.toolStripButton_alignLeft.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_alignLeft.Text = "左对齐";
            this.toolStripButton_alignLeft.Click += new System.EventHandler(this.toolStripButton_alignLeft_Click);
            // 
            // toolStripButton_alignMiddle
            // 
            this.toolStripButton_alignMiddle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_alignMiddle.Image = global::DiaryManager.Properties.Resources.AlignCenter;
            this.toolStripButton_alignMiddle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_alignMiddle.Name = "toolStripButton_alignMiddle";
            this.toolStripButton_alignMiddle.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_alignMiddle.Text = "居中";
            this.toolStripButton_alignMiddle.Click += new System.EventHandler(this.toolStripButton_alignMiddle_Click);
            // 
            // toolStripButton_alignRight
            // 
            this.toolStripButton_alignRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_alignRight.Image = global::DiaryManager.Properties.Resources.AlignRight;
            this.toolStripButton_alignRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_alignRight.Name = "toolStripButton_alignRight";
            this.toolStripButton_alignRight.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_alignRight.Text = "右对齐";
            this.toolStripButton_alignRight.Click += new System.EventHandler(this.toolStripButton_alignRight_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "插入图片";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.未登录ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1056, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建日记ToolStripMenuItem,
            this.读取日记ToolStripMenuItem,
            this.保存ToolStripMenuItem1,
            this.保存ToolStripMenuItem,
            this.toolStripMenuItem3,
            this.退出XToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.文件ToolStripMenuItem.Text = "文件(&F)";
            // 
            // 新建日记ToolStripMenuItem
            // 
            this.新建日记ToolStripMenuItem.Name = "新建日记ToolStripMenuItem";
            this.新建日记ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.新建日记ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.新建日记ToolStripMenuItem.Text = "新建(&N)...";
            this.新建日记ToolStripMenuItem.Click += new System.EventHandler(this.新建日记ToolStripMenuItem_Click);
            // 
            // 读取日记ToolStripMenuItem
            // 
            this.读取日记ToolStripMenuItem.Name = "读取日记ToolStripMenuItem";
            this.读取日记ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.读取日记ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.读取日记ToolStripMenuItem.Text = "打开(&O)...";
            this.读取日记ToolStripMenuItem.Click += new System.EventHandler(this.读取日记ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem1
            // 
            this.保存ToolStripMenuItem1.Name = "保存ToolStripMenuItem1";
            this.保存ToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.保存ToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.保存ToolStripMenuItem1.Text = "保存(&S)";
            this.保存ToolStripMenuItem1.Click += new System.EventHandler(this.保存ToolStripMenuItem1_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.保存ToolStripMenuItem.Text = "另存为(&A)...";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(171, 6);
            // 
            // 退出XToolStripMenuItem
            // 
            this.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem";
            this.退出XToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.退出XToolStripMenuItem.Text = "退出(&X)";
            this.退出XToolStripMenuItem.Click += new System.EventHandler(this.退出XToolStripMenuItem_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.撤销ZToolStripMenuItem,
            this.重做ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.剪切CToolStripMenuItem,
            this.复制ToolStripMenuItem,
            this.粘贴VToolStripMenuItem});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.编辑ToolStripMenuItem.Text = "编辑(&E)";
            this.编辑ToolStripMenuItem.Click += new System.EventHandler(this.编辑ToolStripMenuItem_Click);
            // 
            // 撤销ZToolStripMenuItem
            // 
            this.撤销ZToolStripMenuItem.Name = "撤销ZToolStripMenuItem";
            this.撤销ZToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.撤销ZToolStripMenuItem.Text = "撤销(&Z)";
            this.撤销ZToolStripMenuItem.Click += new System.EventHandler(this.撤销ZToolStripMenuItem_Click);
            // 
            // 重做ToolStripMenuItem
            // 
            this.重做ToolStripMenuItem.Name = "重做ToolStripMenuItem";
            this.重做ToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.重做ToolStripMenuItem.Text = "重做(&U)";
            this.重做ToolStripMenuItem.Click += new System.EventHandler(this.重做ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(114, 6);
            // 
            // 剪切CToolStripMenuItem
            // 
            this.剪切CToolStripMenuItem.Name = "剪切CToolStripMenuItem";
            this.剪切CToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.剪切CToolStripMenuItem.Text = "剪切(&X)";
            this.剪切CToolStripMenuItem.Click += new System.EventHandler(this.剪切CToolStripMenuItem_Click);
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.复制ToolStripMenuItem.Text = "复制(&C)";
            this.复制ToolStripMenuItem.Click += new System.EventHandler(this.复制ToolStripMenuItem_Click);
            // 
            // 粘贴VToolStripMenuItem
            // 
            this.粘贴VToolStripMenuItem.Name = "粘贴VToolStripMenuItem";
            this.粘贴VToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.粘贴VToolStripMenuItem.Text = "粘贴(&V)";
            this.粘贴VToolStripMenuItem.Click += new System.EventHandler(this.粘贴VToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于日记管理器ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助ToolStripMenuItem.Text = "帮助(&H)";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.格式ToolStripMenuItem_Click);
            // 
            // 关于日记管理器ToolStripMenuItem
            // 
            this.关于日记管理器ToolStripMenuItem.Name = "关于日记管理器ToolStripMenuItem";
            this.关于日记管理器ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.关于日记管理器ToolStripMenuItem.Text = "关于 日记管理器(&A)";
            this.关于日记管理器ToolStripMenuItem.Click += new System.EventHandler(this.关于日记管理器ToolStripMenuItem_Click);
            // 
            // 未登录ToolStripMenuItem
            // 
            this.未登录ToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.未登录ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.登录ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.获取最新日记ToolStripMenuItem,
            this.上传当前日记ToolStripMenuItem});
            this.未登录ToolStripMenuItem.Enabled = false;
            this.未登录ToolStripMenuItem.Name = "未登录ToolStripMenuItem";
            this.未登录ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.未登录ToolStripMenuItem.Text = "（未登录）";
            this.未登录ToolStripMenuItem.Click += new System.EventHandler(this.未登录ToolStripMenuItem_Click);
            // 
            // 登录ToolStripMenuItem
            // 
            this.登录ToolStripMenuItem.Name = "登录ToolStripMenuItem";
            this.登录ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.登录ToolStripMenuItem.Text = "登录(&L)...";
            this.登录ToolStripMenuItem.Visible = false;
            this.登录ToolStripMenuItem.Click += new System.EventHandler(this.登录ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(163, 6);
            // 
            // 获取最新日记ToolStripMenuItem
            // 
            this.获取最新日记ToolStripMenuItem.Name = "获取最新日记ToolStripMenuItem";
            this.获取最新日记ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.获取最新日记ToolStripMenuItem.Text = "获取最新日记(&N)";
            this.获取最新日记ToolStripMenuItem.Click += new System.EventHandler(this.获取最新日记ToolStripMenuItem_Click);
            // 
            // 上传当前日记ToolStripMenuItem
            // 
            this.上传当前日记ToolStripMenuItem.Name = "上传当前日记ToolStripMenuItem";
            this.上传当前日记ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.上传当前日记ToolStripMenuItem.Text = "上传当前日记(&U)";
            this.上传当前日记ToolStripMenuItem.Click += new System.EventHandler(this.上传当前日记ToolStripMenuItem_Click);
            // 
            // workspace
            // 
            this.workspace.Location = new System.Drawing.Point(24, 86);
            this.workspace.Name = "workspace";
            this.workspace.Size = new System.Drawing.Size(872, 591);
            this.workspace.TabIndex = 2;
            this.workspace.Text = "";
            this.workspace.FontChanged += new System.EventHandler(this.workspace_FontChanged);
            this.workspace.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // addNewMan
            // 
            this.addNewMan.Location = new System.Drawing.Point(901, 88);
            this.addNewMan.Margin = new System.Windows.Forms.Padding(2);
            this.addNewMan.Name = "addNewMan";
            this.addNewMan.Size = new System.Drawing.Size(144, 30);
            this.addNewMan.TabIndex = 4;
            this.addNewMan.Text = "添加新的管理项";
            this.addNewMan.UseVisualStyleBackColor = true;
            this.addNewMan.Click += new System.EventHandler(this.addNewMan_Click);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.date.Location = new System.Drawing.Point(186, 62);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(52, 21);
            this.date.TabIndex = 5;
            this.date.Text = "日期";
            this.date.Click += new System.EventHandler(this.date_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.Location = new System.Drawing.Point(477, 62);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(52, 21);
            this.title.TabIndex = 5;
            this.title.Text = "标题";
            // 
            // weather
            // 
            this.weather.AutoSize = true;
            this.weather.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.weather.Location = new System.Drawing.Point(792, 62);
            this.weather.Name = "weather";
            this.weather.Size = new System.Drawing.Size(52, 21);
            this.weather.TabIndex = 5;
            this.weather.Text = "天气";
            // 
            // buttonCheckManage
            // 
            this.buttonCheckManage.Location = new System.Drawing.Point(901, 141);
            this.buttonCheckManage.Name = "buttonCheckManage";
            this.buttonCheckManage.Size = new System.Drawing.Size(143, 29);
            this.buttonCheckManage.TabIndex = 8;
            this.buttonCheckManage.Text = "查看管理项";
            this.buttonCheckManage.UseVisualStyleBackColor = true;
            this.buttonCheckManage.Click += new System.EventHandler(this.buttonCheckManage_Click);
            // 
            // openJPGDialog
            // 
            this.openJPGDialog.FileName = "openFileDialog2";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 682);
            this.Controls.Add(this.buttonCheckManage);
            this.Controls.Add(this.weather);
            this.Controls.Add(this.title);
            this.Controls.Add(this.date);
            this.Controls.Add(this.addNewMan);
            this.Controls.Add(this.workspace);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "日记管理器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.RichTextBox workspace;
        private System.Windows.Forms.ToolStripMenuItem 新建日记ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_size;
        private System.Windows.Forms.ToolStripButton toolStripButton_bold;
        private System.Windows.Forms.ToolStripButton toolStripButton_Italic;
        private System.Windows.Forms.ToolStripButton toolStripButton_underline;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_style;
        private System.Windows.Forms.ToolStripMenuItem 未登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 获取最新日记ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上传当前日记ToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem 读取日记ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button addNewMan;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label weather;

        
        private System.Windows.Forms.ToolStripMenuItem 剪切CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 撤销ZToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 粘贴VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 退出XToolStripMenuItem;
        private System.Windows.Forms.Button buttonCheckManage;
        private System.Windows.Forms.ToolStripMenuItem 关于日记管理器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重做ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton_color;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripButton toolStripButton_alignLeft;
        private System.Windows.Forms.ToolStripButton toolStripButton_alignMiddle;
        private System.Windows.Forms.ToolStripButton toolStripButton_alignRight;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.OpenFileDialog openJPGDialog;
    }
}

