namespace spider_source
{
	// Token: 0x02000007 RID: 7
	public partial class Form2 : global::System.Windows.Forms.Form
	{
		// Token: 0x0600005F RID: 95 RVA: 0x00006078 File Offset: 0x00004278
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000060B0 File Offset: 0x000042B0
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::spider_source.Form2));
			this.status = new global::System.Windows.Forms.Label();
			this.key = new global::System.Windows.Forms.Label();
			this.guna2ControlBox1 = new global::Guna.UI2.WinForms.Guna2ControlBox();
			this.guna2GradientButton1 = new global::Guna.UI2.WinForms.Guna2GradientButton();
			this.guna2GradientButton2 = new global::Guna.UI2.WinForms.Guna2GradientButton();
			this.textBox1 = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.guna2HtmlLabel1 = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			base.SuspendLayout();
			this.status.AutoSize = true;
			this.status.BackColor = global::System.Drawing.Color.Transparent;
			this.status.Font = new global::System.Drawing.Font("Tahoma", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.status.ForeColor = global::System.Drawing.Color.Cyan;
			this.status.Location = new global::System.Drawing.Point(3, 311);
			this.status.Name = "status";
			this.status.Size = new global::System.Drawing.Size(45, 23);
			this.status.TabIndex = 3;
			this.status.Text = "Key";
			this.key.AutoSize = true;
			this.key.BackColor = global::System.Drawing.Color.Transparent;
			this.key.Font = new global::System.Drawing.Font("Tahoma", 18f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.key.ForeColor = global::System.Drawing.Color.Cyan;
			this.key.Location = new global::System.Drawing.Point(43, 166);
			this.key.Name = "key";
			this.key.Size = new global::System.Drawing.Size(55, 29);
			this.key.TabIndex = 4;
			this.key.Text = "key";
			this.guna2ControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.guna2ControlBox1.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2ControlBox1.IconColor = global::System.Drawing.Color.White;
			this.guna2ControlBox1.Location = new global::System.Drawing.Point(518, 0);
			this.guna2ControlBox1.Name = "guna2ControlBox1";
			this.guna2ControlBox1.Size = new global::System.Drawing.Size(65, 40);
			this.guna2ControlBox1.TabIndex = 5;
			this.guna2ControlBox1.Click += new global::System.EventHandler(this.guna2ControlBox1_Click);
			this.guna2GradientButton1.BorderColor = global::System.Drawing.Color.Cyan;
			this.guna2GradientButton1.BorderRadius = 20;
			this.guna2GradientButton1.BorderThickness = 2;
			this.guna2GradientButton1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientButton1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientButton1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientButton1.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientButton1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2GradientButton1.FillColor = global::System.Drawing.Color.Black;
			this.guna2GradientButton1.FillColor2 = global::System.Drawing.Color.Black;
			this.guna2GradientButton1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2GradientButton1.ForeColor = global::System.Drawing.Color.White;
			this.guna2GradientButton1.Location = new global::System.Drawing.Point(31, 224);
			this.guna2GradientButton1.Name = "guna2GradientButton1";
			this.guna2GradientButton1.Size = new global::System.Drawing.Size(136, 45);
			this.guna2GradientButton1.TabIndex = 6;
			this.guna2GradientButton1.Text = "LOGIN";
			this.guna2GradientButton1.Click += new global::System.EventHandler(this.guna2GradientButton1_Click);
			this.guna2GradientButton2.BorderColor = global::System.Drawing.Color.Cyan;
			this.guna2GradientButton2.BorderRadius = 20;
			this.guna2GradientButton2.BorderThickness = 2;
			this.guna2GradientButton2.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientButton2.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientButton2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientButton2.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientButton2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2GradientButton2.FillColor = global::System.Drawing.Color.Black;
			this.guna2GradientButton2.FillColor2 = global::System.Drawing.Color.Black;
			this.guna2GradientButton2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2GradientButton2.ForeColor = global::System.Drawing.Color.White;
			this.guna2GradientButton2.Location = new global::System.Drawing.Point(413, 224);
			this.guna2GradientButton2.Name = "guna2GradientButton2";
			this.guna2GradientButton2.Size = new global::System.Drawing.Size(135, 45);
			this.guna2GradientButton2.TabIndex = 7;
			this.guna2GradientButton2.Text = "Discord";
			this.guna2GradientButton2.Click += new global::System.EventHandler(this.guna2GradientButton2_Click);
			this.textBox1.BorderColor = global::System.Drawing.Color.Cyan;
			this.textBox1.BorderRadius = 20;
			this.textBox1.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.textBox1.DefaultText = "";
			this.textBox1.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.textBox1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.textBox1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.textBox1.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.textBox1.FillColor = global::System.Drawing.Color.Black;
			this.textBox1.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.textBox1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.textBox1.ForeColor = global::System.Drawing.Color.Cyan;
			this.textBox1.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.textBox1.Location = new global::System.Drawing.Point(115, 166);
			this.textBox1.Name = "textBox1";
			this.textBox1.PasswordChar = '\0';
			this.textBox1.PlaceholderForeColor = global::System.Drawing.Color.Black;
			this.textBox1.PlaceholderText = "";
			this.textBox1.SelectedText = "";
			this.textBox1.Size = new global::System.Drawing.Size(308, 36);
			this.textBox1.TabIndex = 8;
			this.guna2HtmlLabel1.BackColor = global::System.Drawing.Color.Black;
			this.guna2HtmlLabel1.Font = new global::System.Drawing.Font("Tahoma", 36f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2HtmlLabel1.ForeColor = global::System.Drawing.Color.Blue;
			this.guna2HtmlLabel1.Location = new global::System.Drawing.Point(158, 12);
			this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
			this.guna2HtmlLabel1.Size = new global::System.Drawing.Size(253, 60);
			this.guna2HtmlLabel1.TabIndex = 9;
			this.guna2HtmlLabel1.Text = "Hidan KEY";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			//this.BackgroundImage = global::spider_source.Properties.Resources.sp_memory_page;
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			base.ClientSize = new global::System.Drawing.Size(572, 358);
			base.Controls.Add(this.guna2HtmlLabel1);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.guna2GradientButton2);
			base.Controls.Add(this.guna2GradientButton1);
			base.Controls.Add(this.guna2ControlBox1);
			base.Controls.Add(this.key);
			base.Controls.Add(this.status);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			//base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Form2";
			this.Text = "Login_Key";
			base.Load += new global::System.EventHandler(this.Form3_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400003E RID: 62
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.Label status;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.Label key;

		// Token: 0x04000041 RID: 65
		private global::Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;

		// Token: 0x04000042 RID: 66
		private global::Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;

		// Token: 0x04000043 RID: 67
		private global::Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;

		// Token: 0x04000044 RID: 68
		private global::Guna.UI2.WinForms.Guna2TextBox textBox1;

		// Token: 0x04000045 RID: 69
		private global::Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
	}
}
