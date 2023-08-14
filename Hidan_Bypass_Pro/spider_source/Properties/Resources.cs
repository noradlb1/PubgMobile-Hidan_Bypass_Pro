using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace spider_source.Properties
{
	// Token: 0x02000009 RID: 9
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000063 RID: 99 RVA: 0x00006A0A File Offset: 0x00004C0A
		internal Resources()
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00006A14 File Offset: 0x00004C14
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("spider_source.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00006A5C File Offset: 0x00004C5C
		// (set) Token: 0x06000066 RID: 102 RVA: 0x00006A73 File Offset: 0x00004C73
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00006A7C File Offset: 0x00004C7C
		internal static byte[] Driver
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("Driver", Resources.resourceCulture);
				return (byte[])@object;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00006AAC File Offset: 0x00004CAC
		internal static Bitmap Hidan
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("Hidan", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00006ADC File Offset: 0x00004CDC
		internal static Bitmap sp_memory_page
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("sp memory page", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00006B0C File Offset: 0x00004D0C
		internal static Bitmap spbp_page
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("spbp page", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x04000046 RID: 70
		private static ResourceManager resourceMan;

		// Token: 0x04000047 RID: 71
		private static CultureInfo resourceCulture;
	}
}
