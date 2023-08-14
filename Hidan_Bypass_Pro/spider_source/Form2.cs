using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
//using KeyAuth;
using spider_source.Properties;

namespace spider_source
{
	// Token: 0x02000007 RID: 7
	public partial class Form2 : Form
	{
		// Token: 0x06000056 RID: 86 RVA: 0x00005EDD File Offset: 0x000040DD
		public Form2()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00005EF5 File Offset: 0x000040F5
		private void Bypass_MouseDown(object sender, MouseEventArgs e)
		{
			this.mouseDown = true;
			this.lastLocation = e.Location;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00005F0C File Offset: 0x0000410C
		private void Bypass_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = this.mouseDown;
			if (flag)
			{
				base.Location = new Point(base.Location.X - this.lastLocation.X + e.X, base.Location.Y - this.lastLocation.Y + e.Y);
				base.Update();
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00005F7B File Offset: 0x0000417B
		private void Bypass_MouseUp(object sender, MouseEventArgs e)
		{
			this.mouseDown = false;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00005F88 File Offset: 0x00004188
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

		// Token: 0x0600005B RID: 91 RVA: 0x00005FDA File Offset: 0x000041DA
		private void Form3_Load(object sender, EventArgs e)
		{
			//Form2.KeyAuthApp.init();
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00005FE8 File Offset: 0x000041E8
		private void guna2ControlBox1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00005FF4 File Offset: 0x000041F4
		private void guna2GradientButton1_Click(object sender, EventArgs e)
		{
			//Form2.KeyAuthApp.license(this.textBox1.Text);
			//bool success = Form2.KeyAuthApp.response.success;
			//if (success)
			//{
				Form1 formm = new Form1();
				formm.Show();
				base.Hide();
			//}
			//else
			//{
			//	this.status.Text = "Status: " + Form2.KeyAuthApp.response.message;
			//}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00006068 File Offset: 0x00004268
		private void guna2GradientButton2_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/6uSaegCbjS");
			Process.Start("https://t.me/MONSTERMCSY");
		}

		// Token: 0x04000039 RID: 57
		private bool mouseDown;

		// Token: 0x0400003A RID: 58
		private Point lastLocation;

		// Token: 0x0400003B RID: 59
		private int correctCounter;

		// Token: 0x0400003C RID: 60
		private int notWritten;

		// Token: 0x0400003D RID: 61
		//public static api KeyAuthApp = new api("Dead", "mra2gNo5KK", "079de1f8a2364d2975be2348ba3beac9506aedf699bfd5f41bd6fdfc597be187", "1.0");
	}
}
