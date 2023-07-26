/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2021/11/16/周二
 * 时间: 12:35
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace slide
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem bingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem skin;
		private System.Windows.Forms.ToolStripMenuItem leftToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rightToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem autoRunToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem setDesktopLinkToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sourceToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem landscapeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem animeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem zoneToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem wlopToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dlToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem louLLArollToolStripMenuItem;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.skin = new System.Windows.Forms.ToolStripMenuItem();
			this.bingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.landscapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.wlopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.animeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.zoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.leftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.autoRunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.setDesktopLinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.louLLArollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.skin,
			this.bingToolStripMenuItem,
			this.sourceToolStripMenuItem,
			this.dlToolStripMenuItem,
			this.toolStripSeparator1,
			this.leftToolStripMenuItem,
			this.rightToolStripMenuItem,
			this.toolStripSeparator3,
			this.autoRunToolStripMenuItem,
			this.setDesktopLinkToolStripMenuItem,
			this.toolStripSeparator2,
			this.aboutToolStripMenuItem,
			this.exitToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(173, 264);
			// 
			// skin
			// 
			this.skin.Name = "skin";
			this.skin.Size = new System.Drawing.Size(172, 22);
			this.skin.Text = "皮肤";
			this.skin.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.SkinDropDownItemClicked);
			// 
			// bingToolStripMenuItem
			// 
			this.bingToolStripMenuItem.Name = "bingToolStripMenuItem";
			this.bingToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
			this.bingToolStripMenuItem.Text = "必应壁纸";
			this.bingToolStripMenuItem.Click += new System.EventHandler(this.BingToolStripMenuItemClick);
			// 
			// sourceToolStripMenuItem
			// 
			this.sourceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.landscapeToolStripMenuItem,
			this.animeToolStripMenuItem,
			this.zoneToolStripMenuItem,
			this.wlopToolStripMenuItem,
			this.louLLArollToolStripMenuItem});
			this.sourceToolStripMenuItem.Name = "sourceToolStripMenuItem";
			this.sourceToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
			this.sourceToolStripMenuItem.Text = "切换壁纸源";
			// 
			// landscapeToolStripMenuItem
			// 
			this.landscapeToolStripMenuItem.Name = "landscapeToolStripMenuItem";
			this.landscapeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.landscapeToolStripMenuItem.Text = "风景";
			this.landscapeToolStripMenuItem.Click += new System.EventHandler(this.LandscapeToolStripMenuItemClick);
			// 
			// wlopToolStripMenuItem
			// 
			this.wlopToolStripMenuItem.Name = "wlopToolStripMenuItem";
			this.wlopToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.wlopToolStripMenuItem.Text = "wlop";
			this.wlopToolStripMenuItem.Click += new System.EventHandler(this.WlopToolStripMenuItemClick);
			// 
			// animeToolStripMenuItem
			// 
			this.animeToolStripMenuItem.Name = "animeToolStripMenuItem";
			this.animeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.animeToolStripMenuItem.Text = "二次元";
			this.animeToolStripMenuItem.Click += new System.EventHandler(this.AnimeToolStripMenuItemClick);
			// 
			// zoneToolStripMenuItem
			// 
			this.zoneToolStripMenuItem.Name = "zoneToolStripMenuItem";
			this.zoneToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.zoneToolStripMenuItem.Text = "分区壁纸";
			this.zoneToolStripMenuItem.Click += new System.EventHandler(this.ZoneToolStripMenuItemClick);
			// 
			// dlToolStripMenuItem
			// 
			this.dlToolStripMenuItem.Name = "dlToolStripMenuItem";
			this.dlToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
			this.dlToolStripMenuItem.Text = "下载当前壁纸";
			this.dlToolStripMenuItem.Click += new System.EventHandler(this.DlToolStripMenuItemClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
			// 
			// leftToolStripMenuItem
			// 
			this.leftToolStripMenuItem.Name = "leftToolStripMenuItem";
			this.leftToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
			this.leftToolStripMenuItem.Text = "左移";
			this.leftToolStripMenuItem.Click += new System.EventHandler(this.LeftToolStripMenuItemClick);
			// 
			// rightToolStripMenuItem
			// 
			this.rightToolStripMenuItem.Name = "rightToolStripMenuItem";
			this.rightToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
			this.rightToolStripMenuItem.Text = "右移";
			this.rightToolStripMenuItem.Click += new System.EventHandler(this.RightToolStripMenuItemClick);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(169, 6);
			// 
			// autoRunToolStripMenuItem
			// 
			this.autoRunToolStripMenuItem.Name = "autoRunToolStripMenuItem";
			this.autoRunToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
			this.autoRunToolStripMenuItem.Text = "设置开机自启";
			this.autoRunToolStripMenuItem.Click += new System.EventHandler(this.AutoRunToolStripMenuItemClick);
			// 
			// setDesktopLinkToolStripMenuItem
			// 
			this.setDesktopLinkToolStripMenuItem.Name = "setDesktopLinkToolStripMenuItem";
			this.setDesktopLinkToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
			this.setDesktopLinkToolStripMenuItem.Text = "添加桌面快捷方式";
			this.setDesktopLinkToolStripMenuItem.Click += new System.EventHandler(this.SetDesktopLinkToolStripMenuItemClick);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(169, 6);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
			this.aboutToolStripMenuItem.Text = "关于";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
			this.exitToolStripMenuItem.Text = "退出";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// louLLArollToolStripMenuItem
			// 
			this.louLLArollToolStripMenuItem.Name = "louLLArollToolStripMenuItem";
			this.louLLArollToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.louLLArollToolStripMenuItem.Text = "LouLL_Aroll";
			this.louLLArollToolStripMenuItem.Click += new System.EventHandler(this.LouLLArollToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(30, 30);
			this.ContextMenuStrip = this.contextMenuStrip1;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(30, 30);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(30, 30);
			this.Name = "MainForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "喵切";
			this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainFormMouseClick);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainFormMouseDown);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainFormMouseUp);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
