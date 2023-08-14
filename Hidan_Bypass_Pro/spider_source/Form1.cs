using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Memory;
using Microsoft.Win32;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;
using spider_source.Properties;

namespace spider_source
{
	
	public partial class Form1 : Form
	{
	
		public Form1()
		{
			this.InitializeComponent();
		}

		
		private void label8_Click(object sender, EventArgs e)
		{
		}

	
		private void button1_Click(object sender, EventArgs e)
		{
		}

		
		private void button4_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		
		[DllImport("KERNEL32.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr CreateToolhelp32Snapshot(uint flags, uint processid);

		
		[DllImport("KERNEL32.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern int Process32First(IntPtr handle, ref Form1.ProcessEntry32 pe);

	 //50
		[DllImport("KERNEL32.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern int Process32Next(IntPtr handle, ref Form1.ProcessEntry32 pe);

	
		[DebuggerStepThrough]
		//private Task PutTaskDelay(int Time)
		//{
		//	Form1.<PutTaskDelay>d__7 <PutTaskDelay>d__ = new Form1.<PutTaskDelay>d__7();
		//	<PutTaskDelay>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
		//	<PutTaskDelay>d__.<>4__this = this;
		//	<PutTaskDelay>d__.Time = Time;
		//	<PutTaskDelay>d__.<>1__state = -1;
		//	<PutTaskDelay>d__.<>t__builder.Start<Form1.<PutTaskDelay>d__7>(ref <PutTaskDelay>d__);
		//	return <PutTaskDelay>d__.<>t__builder.Task;
		//}

	
		[DllImport("kernel32.dll")]
		private static extern IntPtr OpenThread(Form1.ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);


		[DllImport("kernel32.dll")]
		private static extern uint SuspendThread(IntPtr hThread);

	
		[DllImport("kernel32.dll")]
		private static extern int ResumeThread(IntPtr hThread);


		private void Bypass_MouseDown(object sender, MouseEventArgs e)
		{
			this.mouseDown = true;
			this.lastLocation = e.Location;
		}

		
		private void Bypass_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = this.mouseDown;
			if (flag)
			{
				base.Location = new Point(base.Location.X - this.lastLocation.X + e.X, base.Location.Y - this.lastLocation.Y + e.Y);
				base.Update();
			}
		}


		private void Bypass_MouseUp(object sender, MouseEventArgs e)
		{
			this.mouseDown = false;
		}


		protected override void WndProc(ref Message m)
		{
			int msg = m.Msg;
			int num = msg;
			if (num != 132)
			{
				base.WndProc(ref m);
			}
			else
			{
				base.WndProc(ref m);
				bool flag = (int)m.Result == 1;
				if (flag)
				{
					m.Result = (IntPtr)2;
				}
			}
		}


		[DebuggerStepThrough]
		//private Task<IntPtr> GetProcID()
		//{
		//	Form1.<GetProcID>d__35 <GetProcID>d__ = new Form1.<GetProcID>d__35();
		//	<GetProcID>d__.<>t__builder = AsyncTaskMethodBuilder<IntPtr>.Create();
		//	<GetProcID>d__.<>4__this = this;
		//	<GetProcID>d__.<>1__state = -1;
		//	<GetProcID>d__.<>t__builder.Start<Form1.<GetProcID>d__35>(ref <GetProcID>d__);
		//	return <GetProcID>d__.<>t__builder.Task;
		//}


		public static void SuspendProcess(int pid)
		{
			Process processById = Process.GetProcessById(pid);
			bool flag = processById.ProcessName == string.Empty;
			if (!flag)
			{
				foreach (object obj in processById.Threads)
				{
					ProcessThread processThread = (ProcessThread)obj;
					IntPtr intPtr = Imps.OpenThread(Imps.ThreadAccess.SUSPEND_RESUME, false, checked((uint)processThread.Id));
					bool flag2 = !(intPtr == IntPtr.Zero);
					if (flag2)
					{
						Imps.SuspendThread(intPtr);
						Imps.CloseHandle(intPtr);
					}
				}
			}
		}


		public static void ResumeProcess(int pid)
		{
			Process processById = Process.GetProcessById(pid);
			bool flag = processById.ProcessName == string.Empty;
			if (!flag)
			{
				foreach (object obj in processById.Threads)
				{
					ProcessThread processThread = (ProcessThread)obj;
					IntPtr intPtr = Imps.OpenThread(Imps.ThreadAccess.SUSPEND_RESUME, false, checked((uint)processThread.Id));
					bool flag2 = !(intPtr == IntPtr.Zero);
					if (flag2)
					{
						int num;
						do
						{
							num = Imps.ResumeThread(intPtr);
						}
						while (num > 0);
						Imps.CloseHandle(intPtr);
					}
				}
			}
		}

	
		private void ConmardLine(string arg)
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				UseShellExecute = false,
				RedirectStandardOutput = true,
				FileName = Environment.GetFolderPath(Environment.SpecialFolder.SystemX86) + "\\cmd.exe",
				Arguments = "/c" + arg
			};
			process.Start();
			process.WaitForExit();
		}

		[DebuggerStepThrough]
		//public void Rep(string original, string replace)
		//{
		//	Form1.<Rep>d__39 <Rep>d__ = new Form1.<Rep>d__39();
		//	<Rep>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
		//	<Rep>d__.<>4__this = this;
		//	<Rep>d__.original = original;
		//	<Rep>d__.replace = replace;
		//	<Rep>d__.<>1__state = -1;
		//	<Rep>d__.<>t__builder.Start<Form1.<Rep>d__39>(ref <Rep>d__);
		//}

	
		//[DebuggerStepThrough]
		//public void check1()
		//{
		//	Form1.<check1>d__40 <check1>d__ = new Form1.<check1>d__40();
		//	<check1>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
		//	<check1>d__.<>4__this = this;
		//	<check1>d__.<>1__state = -1;
		//	<check1>d__.<>t__builder.Start<Form1.<check1>d__40>(ref <check1>d__);
		//}

	
		//[DebuggerStepThrough]
		//private void ld()
		//{
		//	Form1.<ld>d__41 <ld>d__ = new Form1.<ld>d__41();
		//	<ld>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
		//	<ld>d__.<>4__this = this;
		//	<ld>d__.<>1__state = -1;
		//	<ld>d__.<>t__builder.Start<Form1.<ld>d__41>(ref <ld>d__);
		//}

	
		private void Getpid()
		{
			IntPtr intPtr = IntPtr.Zero;
			uint num = 0U;
			IntPtr intPtr2 = Form1.CreateToolhelp32Snapshot(2U, 0U);
			bool flag = (int)intPtr2 > 0;
			if (flag)
			{
				Form1.ProcessEntry32 processEntry = default(Form1.ProcessEntry32);
				processEntry.dwSize = (uint)Marshal.SizeOf<Form1.ProcessEntry32>(processEntry);
				for (int num2 = Form1.Process32First(intPtr2, ref processEntry); num2 == 1; num2 = Form1.Process32Next(intPtr2, ref processEntry))
				{
					IntPtr intPtr3 = Marshal.AllocHGlobal((int)processEntry.dwSize);
					Marshal.StructureToPtr<Form1.ProcessEntry32>(processEntry, intPtr3, true);
					Form1.ProcessEntry32 processEntry2 = (Form1.ProcessEntry32)Marshal.PtrToStructure(intPtr3, typeof(Form1.ProcessEntry32));
					Marshal.FreeHGlobal(intPtr3);
					bool flag2 = processEntry2.szExeFile.Contains("aow_exe.exe") && processEntry2.cntThreads > num;
					if (flag2)
					{
						num = processEntry2.cntThreads;
						intPtr = (IntPtr)((long)((ulong)processEntry2.th32ProcessID));
					}
				}
				this.pid.Text = Convert.ToString(intPtr);
				////////////////////this.Bypass();
			}
		}

	
		[DebuggerStepThrough]
		//private void Bypass()
		//{
		//	Form1.<Bypass>d__43 <Bypass>d__ = new Form1.<Bypass>d__43();
		//	<Bypass>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
		//	<Bypass>d__.<>4__this = this;
		//	<Bypass>d__.<>1__state = -1;
		//	<Bypass>d__.<>t__builder.Start<Form1.<Bypass>d__43>(ref <Bypass>d__);
		//}


		private void gameloopEx()
		{
			IntPtr intPtr = IntPtr.Zero;
			uint num = 0U;
			IntPtr intPtr2 = Form1.CreateToolhelp32Snapshot(2U, 0U);
			bool flag = (int)intPtr2 > 0;
			if (flag)
			{
				Form1.ProcessEntry32 processEntry = default(Form1.ProcessEntry32);
				processEntry.dwSize = (uint)Marshal.SizeOf<Form1.ProcessEntry32>(processEntry);
				for (int num2 = Form1.Process32First(intPtr2, ref processEntry); num2 == 1; num2 = Form1.Process32Next(intPtr2, ref processEntry))
				{
					IntPtr intPtr3 = Marshal.AllocHGlobal((int)processEntry.dwSize);
					Marshal.StructureToPtr<Form1.ProcessEntry32>(processEntry, intPtr3, true);
					Form1.ProcessEntry32 processEntry2 = (Form1.ProcessEntry32)Marshal.PtrToStructure(intPtr3, typeof(Form1.ProcessEntry32));
					Marshal.FreeHGlobal(intPtr3);
					bool flag2 = processEntry2.szExeFile.Contains("AndroidEmulatorEn.exe") && processEntry2.cntThreads > num;
					if (flag2)
					{
						num = processEntry2.cntThreads;
						intPtr = (IntPtr)((long)((ulong)processEntry2.th32ProcessID));
					}
					bool flag3 = processEntry2.szExeFile.Contains("AndroidEmulatorEx.exe") && processEntry2.cntThreads > num;
					if (flag3)
					{
						num = processEntry2.cntThreads;
						intPtr = (IntPtr)((long)((ulong)processEntry2.th32ProcessID));
					}
				}
				this.pid.Text = Convert.ToString(intPtr);
				this.patch();
			}
		}

		private void patch()
		{
			this.MemLib.OpenProcess(Convert.ToInt32(this.pid.Text));
			this.MemLib.WriteMemory("0x" + 4692853.ToString("X"), "bytes", "C2 08 00", "", null, true);
			this.Smartgaga();
		}

		private void Smartgaga()
		{
			bool flag = this.comboBox2.SelectedIndex == 0;
			if (flag)
			{
				this.ConmardLine("adb kill-server");
				this.ConmardLine("adb shell rm -rf /storage/emulated/0/Android/data/com.pubg.imobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/PufferEifs0");
				this.ConmardLine("adb shell rm -rf /storage/emulated/0/Android/data/com.pubg.imobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/PufferEifs1");
				this.ConmardLine("adb shell rm -rf /storage/emulated/0/Android/data/com.pubg.imobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/PufferEifs0");
				this.ConmardLine("adb shell rm -rf /storage/emulated/0/Android/data/com.pubg.imobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/PufferEifs1");
				this.ConmardLine("adb shell chmod 555 /data/media/0/Android/data/com.pubg.imobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/Paks");
				this.ConmardLine("adb shell chmod 777 /data/media/0/Android/data/com.pubg.imobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/Paks");
				this.ConmardLine("adb shell rm -rf /storage/emulated/0/Android/data/com.pubg.imobile/cache");
				this.ConmardLine("adb shell rm -rf /storage/emulated/0/Android/data/com.pubg.imobile/cache");
				this.ConmardLine("adb shell rm -rf /storage/emulated/0/Android/data/com.pubg.imobile/cache");
				this.ConmardLine("adb shell rm -rf /mnt/shell/emulated/0/Android/data/com.pubg.imobile/cache");
				this.ConmardLine("adb shell rm -rf /mnt/shell/emulated/0/Android/data/com.pubg.imobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/SaveGames/playerprefs.sav");
				this.ConmardLine("adb shell rm -rf /mnt/shell/emulated/0/Android/data/com.pubg.imobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/SaveGames/Cached.sav");
				this.ConmardLine("adb shell rm -rf /mnt/shell/emulated/0/Android/data/com.pubg.imobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/Logs");
				this.ConmardLine("adb shell rm -rf /mnt/shell/emulated/0/Android/data/com.pubg.imobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/PufferTmpDir");
				this.ConmardLine("adb shell rm -rf /storage/emulated/0/Android/data/com.pubg.imobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/SaveGames/playerprefs.sav");
				this.ConmardLine("adb shell rm -rf /storage/emulated/0/Android/data/com.pubg.imobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/SaveGames/Cached.sav");
				this.ConmardLine("adb shell rm -rf /storage/emulated/0/Android/data/com.pubg.imobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/Logs");
				this.ConmardLine("adb shell rm -rf /storage/emulated/0/Android/data/com.pubg.imobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/PufferTmpDir");
				this.ConmardLine("adb shell rm -rf /mnt/shell/emulated/0/Android/data/com.pubg.imobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/PufferTmpDir");
				this.ConmardLine("adb shell rm -rf /storage/emulated/0/Android/data/com.pubg.imobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/PufferTmpDir");
				this.ConmardLine("adb shell rm -rf /storage/emulated/0/Android/data/com.pubg.imobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/SaveGames/Cached.sav");
				this.ConmardLine("adb shell chmod -R 777 /data/data/com.pubg.imobile/lib");
				this.ConmardLine("adb shell chmod -R 777 /data/data/com.pubg.imobile/files");
				this.ConmardLine("adb shell chmod -R 777 /data/data/com.pubg.imobile/cache");
				this.ConmardLine("adb shell monkey -p com.pubg.imobile -c android.intent.category.LAUNCHER 1");
				this.Getpid();
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00004390 File Offset: 0x00002590
		private void siticoneRoundedGradientButton2_Click(object sender, EventArgs e)
		{
			bool flag = this.comboBox1.Text == "";
			if (flag)
			{
				this.status.Text = "Plesoooo!!";
			}
			else
			{
				try
				{
					foreach (Process process in Process.GetProcessesByName("AppMarket"))
					{
						process.Kill();
						process.Kill();
					}
					foreach (Process process2 in Process.GetProcessesByName("AppMarket.exe"))
					{
						process2.Kill();
						process2.Kill();
					}
					foreach (Process process3 in Process.GetProcessesByName("AndroidEmulatorEx.exe"))
					{
						process3.Kill();
						process3.Kill();
					}
					foreach (Process process4 in Process.GetProcessesByName("AndroidEmulatorEx"))
					{
						process4.Kill();
						process4.Kill();
					}
				}
				catch
				{
				}
				bool flag2 = this.comboBox1.SelectedIndex == 1 ^ this.comboBox1.SelectedIndex == 2;
				if (flag2)
				{
					try
					{
						string text = Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\Tencent\\MobileGamePC\\UI", "InstallPath", "").ToString();
						bool @checked = Form1.checkBox2.Checked;
						if (@checked)
						{
							Process.Start(Path.Combine(new string[]
							{
								text
							}) + "/AndroidEmulatorEx.exe", "-vm 100");
						}
						bool checked2 = checkBox1.Checked;
						if (checked2)
						{
							Process.Start(Path.Combine(new string[]
							{
								text
							}) + "/AndroidEmulatorEn.exe", "-vm 100");
						}
						this.status.Text = "Bypassing please Wait...";
						this.status.ForeColor = Color.Green;
					}
					catch
					{
						MessageBox.Show("Emulator not found! Please Start it maunally", "FURIOUS", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						this.status.Text = "NICE WORK ME ";
					}
				}
			}
		}


		private void siticoneRoundedGradientButton5_Click(object sender, EventArgs e)
		{
			bool flag = this.comboBox1.SelectedIndex == 1 ^ this.comboBox1.SelectedIndex == 2;
			if (flag)
			{
				bool @checked = Form1.checkBox2.Checked;
				if (@checked)
				{
					this.gameloopEx();
				}
				else
				{
					this.Smartgaga();
				}
			}
			bool flag2 = this.comboBox1.SelectedIndex == 3 ^ this.comboBox1.SelectedIndex == 4 ^ this.comboBox1.SelectedIndex == 5;
			if (flag2)
			{
				////////////////////this.GetProcID();
			}
		}

	
		private void siticoneRoundedGradientButton3_Click(object sender, EventArgs e)
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = "cmd.exe",
				WindowStyle = ProcessWindowStyle.Hidden,
				Verb = "runas",
				Arguments = "/c taskkill /F /im AndroidEmulatorEn.exe"
			});
			Process.Start(new ProcessStartInfo
			{
				FileName = "cmd.exe",
				WindowStyle = ProcessWindowStyle.Hidden,
				Verb = "runas",
				Arguments = "/c taskkill /F /im AndroidEmulatorEx.exe"
			});
			Application.Exit();
		}

	
		private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
		{
			bool created = this.comboBox1.Created;
			if (created)
			{
				checkBox1.Checked = true;
				Form1.checkBox2.Checked = false;
			}
		}

	
		private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			bool created = this.comboBox2.Created;
			if (created)
			{
				Form1.checkBox2.Checked = true;
				checkBox1.Checked = false;
			}
		}


		private void Form1_Load(object sender, EventArgs e)
		{
			this.ConmardLine("net stop titaaN");
			this.ConmardLine("sc delete titaaN");
			File.WriteAllBytes(this.pathDriver, Resources.Driver);
			this.ConmardLine("sc create titaaN binPath=" + this.pathDriver + " start=demand type=filesys");
			this.ConmardLine("net start titaaN");
			this.ConmardLine("sc start titaaN");
		}

	
		private void Bluestacks_CheckedChanged(object sender, EventArgs e)
		{
			bool created = this.comboBox1.Created;
			if (created)
			{
				checkBox1.Checked = true;
				Form1.checkBox2.Checked = false;
			}
		}

	
		private void GLOOP_CheckedChanged(object sender, EventArgs e)
		{
			bool created = this.comboBox2.Created;
			if (created)
			{
				Form1.checkBox2.Checked = true;
				checkBox1.Checked = false;
			}
		}


		[DebuggerStepThrough]
		//private void getu4()
		//{
		//	Form1.<getu4>d__58 <getu4>d__ = new Form1.<getu4>d__58();
		//	<getu4>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
		//	<getu4>d__.<>4__this = this;
		//	<getu4>d__.<>1__state = -1;
		//	<getu4>d__.<>t__builder.Start<Form1.<getu4>d__58>(ref <getu4>d__);
		//}

	
		private void siticoneCustomCheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			this.MemLib.WriteMemory("0x" + (this.ue4 + 93887252L).ToString("X"), "bytes", "00 00 85 43", "", null, true);
		}

	
		private string sr;

	
		public long enumerable = 0L;

		
		private int x;

	
		public Mem MemLib = new Mem();

	
		private static string string_0;


		private static string string_1;


		private static string string_2;


		private static string string_3;

	
		private static string string_4;
	
		private static string string_5;


		private static string string_6;

	
		private IContainer icontainer_0;

	
		private int timer = 0;

	
		private bool mouseDown;

		
		private Point lastLocation;


		private int correctCounter;

	
		private int notWritten;

	
		private string pathDriver = "C:\\titaaN.sys";


		private long ue4;

	
		public struct ProcessEntry32
		{
	
			public uint dwSize;

			
			public uint cntUsage;

	
			public uint th32ProcessID;

		
			public IntPtr th32DefaultHeapID;

			
			public uint th32ModuleID;

	
			public uint cntThreads;

	
			public uint th32ParentProcessID;

		
			public int pcPriClassBase;

	
			public uint dwFlags;


			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
			public string szExeFile;
		}

	
		public struct ProcessEntry64
		{

			public uint dwSize;

	
			public uint cntUsage;

	
			public uint th64ProcessID;

			
			public IntPtr th32DefaultHeapID;

	
			public uint th64ModuleID;

	
			public uint cntThreads;

		
			public uint th64ParentProcessID;

		
			public int pcPriClassBase;

			public uint dwFlags;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
			public string szExeFile;
		}

		[Flags]
		public enum ThreadAccess
		{
			TERMINATE = 1,
			SUSPEND_RESUME = 2,
			GET_CONTEXT = 8,
			SET_CONTEXT = 16,
			SET_INFORMATION = 32,
			QUERY_INFORMATION = 64,
			SET_THREAD_TOKEN = 128,
			IMPERSONATE = 256,
			DIRECT_IMPERSONATION = 512
		}

		private class checkBox2
		{
			public static bool Checked { get; internal set; }
		}

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
