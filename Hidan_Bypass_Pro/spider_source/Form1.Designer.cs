namespace spider_source
{
	// Token: 0x02000005 RID: 5
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000051 RID: 81 RVA: 0x00004890 File Offset: 0x00002A90
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000048C8 File Offset: 0x00002AC8
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Bluestacks = new Siticone.UI.WinForms.SiticoneRadioButton();
            this.GLOOP = new Siticone.UI.WinForms.SiticoneRadioButton();
            this.Timerlabel1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.siticoneLabel1 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneRoundedGradientButton2 = new Siticone.UI.WinForms.SiticoneRoundedGradientButton();
            this.siticoneRoundedGradientButton5 = new Siticone.UI.WinForms.SiticoneRoundedGradientButton();
            this.siticoneRoundedGradientButton3 = new Siticone.UI.WinForms.SiticoneRoundedGradientButton();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.siticoneCustomCheckBox1 = new Siticone.UI.WinForms.SiticoneCustomCheckBox();
            this.pid = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.status = new System.Windows.Forms.Label();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Bluestacks
            // 
            this.Bluestacks.AutoSize = true;
            this.Bluestacks.BackColor = System.Drawing.Color.Transparent;
            this.Bluestacks.CheckedState.BorderColor = System.Drawing.Color.Lime;
            this.Bluestacks.CheckedState.BorderThickness = 0;
            this.Bluestacks.CheckedState.FillColor = System.Drawing.Color.Lime;
            this.Bluestacks.CheckedState.InnerColor = System.Drawing.Color.Red;
            this.Bluestacks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bluestacks.ForeColor = System.Drawing.Color.Gray;
            this.Bluestacks.Location = new System.Drawing.Point(12, 150);
            this.Bluestacks.Name = "Bluestacks";
            this.Bluestacks.Size = new System.Drawing.Size(106, 20);
            this.Bluestacks.TabIndex = 50;
            this.Bluestacks.TabStop = true;
            this.Bluestacks.Text = "GameloopEn";
            this.Bluestacks.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Bluestacks.UncheckedState.BorderThickness = 2;
            this.Bluestacks.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Bluestacks.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.Bluestacks.UseVisualStyleBackColor = false;
            this.Bluestacks.CheckedChanged += new System.EventHandler(this.Bluestacks_CheckedChanged);
            // 
            // GLOOP
            // 
            this.GLOOP.AutoSize = true;
            this.GLOOP.BackColor = System.Drawing.Color.Transparent;
            this.GLOOP.CheckedState.BorderColor = System.Drawing.Color.Lime;
            this.GLOOP.CheckedState.BorderThickness = 0;
            this.GLOOP.CheckedState.FillColor = System.Drawing.Color.Lime;
            this.GLOOP.CheckedState.InnerColor = System.Drawing.Color.Red;
            this.GLOOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GLOOP.ForeColor = System.Drawing.Color.Gray;
            this.GLOOP.Location = new System.Drawing.Point(12, 176);
            this.GLOOP.Name = "GLOOP";
            this.GLOOP.Size = new System.Drawing.Size(105, 20);
            this.GLOOP.TabIndex = 51;
            this.GLOOP.TabStop = true;
            this.GLOOP.Text = "GameloopEx";
            this.GLOOP.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.GLOOP.UncheckedState.BorderThickness = 2;
            this.GLOOP.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.GLOOP.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.GLOOP.UseVisualStyleBackColor = false;
            this.GLOOP.CheckedChanged += new System.EventHandler(this.GLOOP_CheckedChanged);
            // 
            // Timerlabel1
            // 
            this.Timerlabel1.AutoSize = true;
            this.Timerlabel1.BackColor = System.Drawing.Color.Transparent;
            this.Timerlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Timerlabel1.ForeColor = System.Drawing.Color.SpringGreen;
            this.Timerlabel1.Location = new System.Drawing.Point(57, 304);
            this.Timerlabel1.Name = "Timerlabel1";
            this.Timerlabel1.Size = new System.Drawing.Size(26, 15);
            this.Timerlabel1.TabIndex = 53;
            this.Timerlabel1.Text = "N/A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SpringGreen;
            this.label6.Location = new System.Drawing.Point(14, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 52;
            this.label6.Text = "Expiry : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.PowderBlue;
            this.label9.Location = new System.Drawing.Point(68, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 15);
            this.label9.TabIndex = 55;
            this.label9.Text = "#";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.PowderBlue;
            this.label8.Location = new System.Drawing.Point(14, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 15);
            this.label8.TabIndex = 54;
            this.label8.Text = "Login IP :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(14, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 57;
            this.label3.Text = "PID :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siticoneLabel1.Location = new System.Drawing.Point(14, 26);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(51, 17);
            this.siticoneLabel1.TabIndex = 56;
            this.siticoneLabel1.Text = "00:00:00";
            // 
            // siticoneRoundedGradientButton2
            // 
            this.siticoneRoundedGradientButton2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneRoundedGradientButton2.CheckedState.Parent = this.siticoneRoundedGradientButton2;
            this.siticoneRoundedGradientButton2.CustomImages.Parent = this.siticoneRoundedGradientButton2;
            this.siticoneRoundedGradientButton2.FillColor = System.Drawing.Color.Fuchsia;
            this.siticoneRoundedGradientButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.siticoneRoundedGradientButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedGradientButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedGradientButton2.HoveredState.Parent = this.siticoneRoundedGradientButton2;
            this.siticoneRoundedGradientButton2.Location = new System.Drawing.Point(373, 145);
            this.siticoneRoundedGradientButton2.Name = "siticoneRoundedGradientButton2";
            this.siticoneRoundedGradientButton2.PressedColor = System.Drawing.Color.Gray;
            this.siticoneRoundedGradientButton2.ShadowDecoration.Parent = this.siticoneRoundedGradientButton2;
            this.siticoneRoundedGradientButton2.Size = new System.Drawing.Size(150, 39);
            this.siticoneRoundedGradientButton2.TabIndex = 60;
            this.siticoneRoundedGradientButton2.Text = "Start Engine";
            this.siticoneRoundedGradientButton2.TextTransform = Siticone.UI.WinForms.Enums.TextTransform.UpperCase;
            this.siticoneRoundedGradientButton2.Click += new System.EventHandler(this.siticoneRoundedGradientButton2_Click);
            // 
            // siticoneRoundedGradientButton5
            // 
            this.siticoneRoundedGradientButton5.BackColor = System.Drawing.Color.Transparent;
            this.siticoneRoundedGradientButton5.CheckedState.Parent = this.siticoneRoundedGradientButton5;
            this.siticoneRoundedGradientButton5.CustomImages.Parent = this.siticoneRoundedGradientButton5;
            this.siticoneRoundedGradientButton5.FillColor = System.Drawing.Color.MediumPurple;
            this.siticoneRoundedGradientButton5.FillColor2 = System.Drawing.Color.DeepSkyBlue;
            this.siticoneRoundedGradientButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedGradientButton5.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedGradientButton5.HoveredState.Parent = this.siticoneRoundedGradientButton5;
            this.siticoneRoundedGradientButton5.Location = new System.Drawing.Point(373, 199);
            this.siticoneRoundedGradientButton5.Name = "siticoneRoundedGradientButton5";
            this.siticoneRoundedGradientButton5.PressedColor = System.Drawing.Color.Gray;
            this.siticoneRoundedGradientButton5.ShadowDecoration.Parent = this.siticoneRoundedGradientButton5;
            this.siticoneRoundedGradientButton5.Size = new System.Drawing.Size(150, 39);
            this.siticoneRoundedGradientButton5.TabIndex = 61;
            this.siticoneRoundedGradientButton5.Text = "Start Game";
            this.siticoneRoundedGradientButton5.TextTransform = Siticone.UI.WinForms.Enums.TextTransform.UpperCase;
            this.siticoneRoundedGradientButton5.Click += new System.EventHandler(this.siticoneRoundedGradientButton5_Click);
            // 
            // siticoneRoundedGradientButton3
            // 
            this.siticoneRoundedGradientButton3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneRoundedGradientButton3.CheckedState.Parent = this.siticoneRoundedGradientButton3;
            this.siticoneRoundedGradientButton3.CustomImages.Parent = this.siticoneRoundedGradientButton3;
            this.siticoneRoundedGradientButton3.FillColor = System.Drawing.Color.DarkGreen;
            this.siticoneRoundedGradientButton3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.siticoneRoundedGradientButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.siticoneRoundedGradientButton3.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedGradientButton3.HoveredState.Parent = this.siticoneRoundedGradientButton3;
            this.siticoneRoundedGradientButton3.Location = new System.Drawing.Point(373, 253);
            this.siticoneRoundedGradientButton3.Name = "siticoneRoundedGradientButton3";
            this.siticoneRoundedGradientButton3.PressedColor = System.Drawing.Color.Cyan;
            this.siticoneRoundedGradientButton3.ShadowDecoration.Parent = this.siticoneRoundedGradientButton3;
            this.siticoneRoundedGradientButton3.Size = new System.Drawing.Size(150, 39);
            this.siticoneRoundedGradientButton3.TabIndex = 62;
            this.siticoneRoundedGradientButton3.Text = "Safe Exit";
            this.siticoneRoundedGradientButton3.TextTransform = Siticone.UI.WinForms.Enums.TextTransform.UpperCase;
            this.siticoneRoundedGradientButton3.Click += new System.EventHandler(this.siticoneRoundedGradientButton3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(521, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 26);
            this.button4.TabIndex = 63;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(427, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 26);
            this.button1.TabIndex = 64;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // siticoneCustomCheckBox1
            // 
            this.siticoneCustomCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneCustomCheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneCustomCheckBox1.CheckedState.BorderRadius = 2;
            this.siticoneCustomCheckBox1.CheckedState.BorderThickness = 0;
            this.siticoneCustomCheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneCustomCheckBox1.CheckedState.Parent = this.siticoneCustomCheckBox1;
            this.siticoneCustomCheckBox1.CheckMarkColor = System.Drawing.Color.Black;
            this.siticoneCustomCheckBox1.Location = new System.Drawing.Point(12, 225);
            this.siticoneCustomCheckBox1.Name = "siticoneCustomCheckBox1";
            this.siticoneCustomCheckBox1.ShadowDecoration.Color = System.Drawing.Color.White;
            this.siticoneCustomCheckBox1.ShadowDecoration.Parent = this.siticoneCustomCheckBox1;
            this.siticoneCustomCheckBox1.Size = new System.Drawing.Size(49, 45);
            this.siticoneCustomCheckBox1.TabIndex = 65;
            this.siticoneCustomCheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCustomCheckBox1.UncheckedState.BorderRadius = 2;
            this.siticoneCustomCheckBox1.UncheckedState.BorderThickness = 0;
            this.siticoneCustomCheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCustomCheckBox1.UncheckedState.Parent = this.siticoneCustomCheckBox1;
            this.siticoneCustomCheckBox1.CheckedChanged += new System.EventHandler(this.siticoneCustomCheckBox1_CheckedChanged);
            // 
            // pid
            // 
            this.pid.AutoSize = true;
            this.pid.BackColor = System.Drawing.Color.Black;
            this.pid.Location = new System.Drawing.Point(14, 279);
            this.pid.Name = "pid";
            this.pid.Size = new System.Drawing.Size(35, 13);
            this.pid.TabIndex = 66;
            this.pid.Text = "label2";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SMARTGAGA ",
            "GameLoop 32Bit",
            "GameLoop 64 BIT",
            "HD-Player"});
            this.comboBox1.Location = new System.Drawing.Point(12, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 69;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "BGMI"});
            this.comboBox2.Location = new System.Drawing.Point(139, 66);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 70;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.White;
            this.status.Location = new System.Drawing.Point(257, 320);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(66, 16);
            this.status.TabIndex = 71;
            this.status.Text = "Welcome";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Blue;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(116, 3);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(296, 27);
            this.guna2HtmlLabel1.TabIndex = 72;
            this.guna2HtmlLabel1.Text = "Hidan BYPASS MONSTERMC";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(202, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 73;
            this.label1.Text = "status :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(-4, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 74;
            this.label2.Text = "ipad view";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(556, 348);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pid);
            this.Controls.Add(this.siticoneCustomCheckBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.siticoneRoundedGradientButton3);
            this.Controls.Add(this.siticoneRoundedGradientButton5);
            this.Controls.Add(this.siticoneRoundedGradientButton2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.siticoneLabel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Timerlabel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GLOOP);
            this.Controls.Add(this.Bluestacks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hidan_Bypass_Pro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x04000022 RID: 34
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000023 RID: 35
		private global::Siticone.UI.WinForms.SiticoneRadioButton Bluestacks;

		// Token: 0x04000024 RID: 36
		private global::Siticone.UI.WinForms.SiticoneRadioButton GLOOP;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.Label Timerlabel1;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400002A RID: 42
		private global::Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;

		// Token: 0x0400002B RID: 43
		private global::Siticone.UI.WinForms.SiticoneRoundedGradientButton siticoneRoundedGradientButton2;

		// Token: 0x0400002C RID: 44
		private global::Siticone.UI.WinForms.SiticoneRoundedGradientButton siticoneRoundedGradientButton5;

		// Token: 0x0400002D RID: 45
		private global::Siticone.UI.WinForms.SiticoneRoundedGradientButton siticoneRoundedGradientButton3;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.Button button4;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000030 RID: 48
		private global::Siticone.UI.WinForms.SiticoneCustomCheckBox siticoneCustomCheckBox1;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.Label pid;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Forms.ComboBox comboBox1;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.ComboBox comboBox2;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.Label status;

		// Token: 0x04000035 RID: 53
		private global::Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Forms.Label label2;
	}
}
