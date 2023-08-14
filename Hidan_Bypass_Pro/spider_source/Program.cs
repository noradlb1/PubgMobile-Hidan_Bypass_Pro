using System;
using System.Windows.Forms;

namespace spider_source
{
	// Token: 0x02000008 RID: 8
	internal static class Program
	{
		// Token: 0x06000062 RID: 98
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form2());
		}
	}
}
