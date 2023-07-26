/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2021/11/16/周二
 * 时间: 12:35
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Text;
using System.Runtime.InteropServices;
using DSAPI;
using System.Diagnostics;


namespace slide
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		
		[DllImport("user32.dll", EntryPoint = "SystemParametersInfo")]
		public static extern int SystemParametersInfo(
		    int uAction,
		    int uParam,
		    string lpvParam,
		    int fuWinIni
		);
		
		/// <summary>
		///设置这个图片为壁纸
		/// </summary>		
		public void ChangeWallPaper(string filePath){
			SystemParametersInfo(20, 0, filePath, 2);
		}
		
		/// <summary>
		/// 下载图片并存储到临时文件夹下
		/// </summary>
		/// <param name="url">图片URL</param>
		/// <returns>保存下载图片文件的路径</returns>
		private static string DownloadImageAndSaveFile(string url)
		{
		    using (var client = new WebClient())
		    {
		        //创建临时文件目录下的存储必应图片的绝对路径
		        var filePath = Path.Combine(Path.GetTempPath(), "temp.jpg");
		        //将图片下载到这个路径下
		        client.DownloadFile(url, filePath);
		        //返回当前图片路径
		        return filePath;
		    }
		}
		
		/// <summary>
		/// 下载图片到wallpaper文件夹
		/// </summary>
		/// <param name="url"></param>
		/// <returns></returns>
		private static void DownloadImageToWallpaper(string url)
		{
		    using (var client = new WebClient())
		    {
		        //获取wallpaper文件数量
		        string filenum=GetFileNum(Directory.GetCurrentDirectory()+"\\wallpaper").ToString();
		        var filePath = Directory.GetCurrentDirectory()+"\\wallpaper\\"+filenum+".jpg";
		        //将图片下载到这个路径下
		        client.DownloadFile(url, filePath);
		       
		    }
		}
		
		void DlToolStripMenuItemClick(object sender, EventArgs e)
		{
			DownloadImageToWallpaper(picpath);
		}
		
		private static int GetFileNum(string path)
        {
            int count = 0;
            //统计文件的个数
            try
            {
                var files = Directory.GetFiles(path); //String数组类型
                count += files.Length;
                Console.WriteLine(files);

                //遍历文件夹
                var dirs = Directory.GetDirectories(path);
                foreach (var dir in dirs)
                {
                    count += GetFileNum(dir);
                }
               
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            return count;
        }

		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			CreateWallpaperlist();//生成壁纸List
			
			this.Left=SystemInformation.VirtualScreen.Width/5*4; //出现在屏幕5分之4的位置
			
			//获取图包文件夹名称
			string imgpath=Directory.GetCurrentDirectory()+"\\skin\\";
			DirectoryInfo TheFolder=new DirectoryInfo(imgpath);
			string imgfolder="";
			foreach(DirectoryInfo NextFolder  in TheFolder.GetDirectories())
			 {
				imgfolder+=NextFolder.Name+"\n";
			}
		    themelist=imgfolder.Split('\n');
			
		    
		    //初始从图包index=0
			//listnum=0;
			string inipath=Directory.GetCurrentDirectory()+"\\setting.ini"; 
			listnum=int.Parse(iniHelper.Read("Skin","SkinNumber",inipath));
			mode=int.Parse(iniHelper.Read("Mode","ModeNumber",inipath));
			 
			Bitmap B=new Bitmap("skin\\"+themelist[listnum]+"\\0.png");
			控件.Form窗体.透明窗体样式显示图像(this,B,255);
			
			this.Height=B.Height;
			
			//右键菜单皮肤追加
			ToolStripMenuItem skinlist=	skin;
			for (int i = 0; i < themelist.Length-1; i++) {
				skinlist.DropDownItems.Add(themelist[i]);
			}			
			
			 
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		int  y,yy;
		int listnum; //图包index
		int mode; //壁纸来源模式
		string[] themelist;
		string picpath;
	
		void MainFormMouseDown(object sender, MouseEventArgs e)
		{
				y = e.Y; 
				
				if (e. Button == MouseButtons. Left)
				{
				Bitmap B1=new Bitmap("skin\\"+themelist[listnum]+"\\1.png");
				控件.Form窗体.透明窗体样式显示图像(this,B1,255);
				Thread.Sleep(50);
				Bitmap B2=new Bitmap("skin\\"+themelist[listnum]+"\\2.png");
				控件.Form窗体.透明窗体样式显示图像(this,B2,255);
				Thread.Sleep(50);
				Bitmap B3=new Bitmap("skin\\"+themelist[listnum]+"\\3.png");
				控件.Form窗体.透明窗体样式显示图像(this,B3,255);
				Thread.Sleep(50);
				Bitmap B4=new Bitmap("skin\\"+themelist[listnum]+"\\4.png");
				控件.Form窗体.透明窗体样式显示图像(this,B4,255);
				}
			
		}

		
		void MainFormMouseUp(object sender, MouseEventArgs e)
		{
			yy=e.Y;
			switch (mode)
        {
           
            case 1:
				WallPaperChange("list.txt");
                break;
            case 2: 
                if (File.Exists(Directory.GetCurrentDirectory()+"\\wallpaper\\wallpaperlist.txt")) {
                	WallPaperChange(Directory.GetCurrentDirectory()+"\\wallpaper\\wallpaperlist.txt");
                }else{
                	WallPaperChange("list.txt");
                }
                break;
             case 3:
                Random rd = new Random();
            	int i = rd.Next(0,2);
            	//MessageBox.Show(i.ToString());
            	if (i==0) {
            		WallPaperChange("list.txt");
            	}else{
            		if (File.Exists(Directory.GetCurrentDirectory()+"\\wallpaper\\wallpaperlist.txt")) {
                	WallPaperChange(Directory.GetCurrentDirectory()+"\\wallpaper\\wallpaperlist.txt");
	                }else{
	                	WallPaperChange("list.txt");
	                }
            	}
                break;
           
        }
			
		}
		
		public void WallPaperChange(string list){
			string[] line=File.ReadAllLines(list);
			Random rd = new Random();
            int i = rd.Next(0,line.Length);
            picpath=line[i];
			int len=yy-y; 
			if (len>20) {
				if (picpath.Contains("http")) {
					ChangeWallPaper(DownloadImageAndSaveFile(picpath));
				}
				else{
					ChangeWallPaper(picpath);
				}
				Bitmap B=new Bitmap("skin\\"+themelist[listnum]+"\\0.png");
				控件.Form窗体.透明窗体样式显示图像(this,B,255);
			}
			else{
				Bitmap B=new Bitmap("skin\\"+themelist[listnum]+"\\0.png");
				控件.Form窗体.透明窗体样式显示图像(this,B,255);
			}
		}
		
		public void CreateWallpaperlist(){
			string wallpaperpath=Directory.GetCurrentDirectory()+"\\wallpaper";
			string txt="";
			if (Directory.GetFileSystemEntries(wallpaperpath).Length>0) {
				string[] files = Directory.GetFiles(wallpaperpath);
				for (int i = 0; i < files.Length; i++) {
					if (!files[i].Contains("wallpaperlist.txt")) {
						txt+=files[i]+"\n";
					}
				}
				File.WriteAllText(wallpaperpath+"\\wallpaperlist.txt",txt);
			}
		}
		void MainFormMouseClick(object sender, MouseEventArgs e)
		{
			int len=e.Y-y;
			if (len==0) {
				Bitmap B=new Bitmap("skin\\"+themelist[listnum]+"\\0.png");
				控件.Form窗体.透明窗体样式显示图像(this,B,255);
			}
		}
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void BingToolStripMenuItemClick(object sender, EventArgs e)
		{
			ChangeWallPaper(DownloadImageAndSaveFile(GetBingImageUrl()));
		}
		
		/// <summary>
		/// 获取必应图片
		/// </summary>
		/// <returns>必应图片URL</returns>
		private static string GetBingImageUrl()
		{
		    using (var client = new WebClient())
		    {
		        //设置下载的HTML文件的编码为UTF-8
		        client.Encoding = Encoding.UTF8;
		        //下载必应中国的首页HTML文件
		        var html = client.DownloadString("http://www.bing.com/HPImageArchive.aspx?format=js&idx=0&n=1&mkt=en-US");
		        string[] url = html.Split(new string[] { "url\":\"", "\",\"urlbase" }, StringSplitOptions.RemoveEmptyEntries);//
		        return "https://cn.bing.com/"+url[1];
		    }
		}
		void SkinDropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			for (int i = 0; i < skin.DropDownItems.Count; i++) {
				if (skin.DropDownItems[i].Selected) {
					listnum=i;
					Bitmap B=new Bitmap("skin\\"+themelist[listnum]+"\\0.png");
					控件.Form窗体.透明窗体样式显示图像(this,B,255);
					string inipath=Directory.GetCurrentDirectory()+"\\setting.ini"; 
					iniHelper.Write("Skin","SkinNumber",i.ToString(),inipath);
				}
			}
		}
		void LeftToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Left-=50;
			Bitmap B=new Bitmap("skin\\"+themelist[listnum]+"\\0.png");
			控件.Form窗体.透明窗体样式显示图像(this,B,255);
		}
		void RightToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Left+=50;
			Bitmap B=new Bitmap("skin\\"+themelist[listnum]+"\\0.png");
			控件.Form窗体.透明窗体样式显示图像(this,B,255);
		}
		void AboutToolStripMenuItemClick(object sender, EventArgs e)
		{
			MessageBox.Show("喵切 4.1 \nby IFwz1729");
			System.Diagnostics.Process.Start("https://toolkit.gitee.io/cat-switch/");
		}
 			
		
		public void SetDesktopLink(){
			ProcessStartInfo startInfo = new ProcessStartInfo();
			startInfo.FileName  = "wscript.exe";
			startInfo.Arguments = Directory.GetCurrentDirectory()+"\\link.vbs";
			Process.Start(startInfo);
		}
		
		public void AutoRun(){
			SetDesktopLink();
			Thread.Sleep(500);
			string StartupPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.CommonStartup);
			if(!File.Exists(StartupPath+@"\喵切.lnk")){
			File.Move(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+@"\喵切.lnk",StartupPath+@"\喵切.lnk");
			MessageBox.Show("喵切已设置为自启动");
			}
		}
		
		public void NotAutoRun(){
			string StartupPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.CommonStartup);
			if(File.Exists(StartupPath+@"\喵切.lnk")){
				File.Delete(StartupPath+@"\喵切.lnk");
			MessageBox.Show("喵切已解除自启动");
			}
		}
		bool flag = true;
		void AutoRunToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(flag)
			{autoRunToolStripMenuItem.Text="解除开机自启";AutoRun();flag=false;}
			else
			{autoRunToolStripMenuItem.Text="设置开机自启";NotAutoRun();flag=true;}
		}
		void SetDesktopLinkToolStripMenuItemClick(object sender, EventArgs e)
		{
			SetDesktopLink();
		}
		
		//----------------
		public void ChangeSource(string name){
			WebClient web = new WebClient();
			string html = web.DownloadString("https://toolkit.gitee.io/cat-switch/list/"+name+".yml");
			File.WriteAllText(Directory.GetCurrentDirectory()+"\\list.txt",html);
		}
		void LandscapeToolStripMenuItemClick(object sender, EventArgs e)
		{
			ChangeSource("landscape");
		}
		void ZoneToolStripMenuItemClick(object sender, EventArgs e)
		{
			ChangeSource("zone");
		}
		void WlopToolStripMenuItemClick(object sender, EventArgs e)
		{
			ChangeSource("wlop");
		}
		void AnimeToolStripMenuItemClick(object sender, EventArgs e)
		{
			ChangeSource("anime");
		}
		void LouLLArollToolStripMenuItemClick(object sender, EventArgs e)
		{
			ChangeSource("LouLL_Aroll");
		}
		
		
		
		 
	}
}
