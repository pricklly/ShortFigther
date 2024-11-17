/*
 * Создано в SharpDevelop.
 * Пользователь: pricklly
 * Дата: 17.11.2024
 * Время: 8:06
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace ShortFigther
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.RichTextBox rtb;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.TextBox tb;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox tb2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		
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
			this.rtb = new System.Windows.Forms.RichTextBox();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.tb = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tb2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// rtb
			// 
			this.rtb.Location = new System.Drawing.Point(1, 5);
			this.rtb.Name = "rtb";
			this.rtb.Size = new System.Drawing.Size(308, 218);
			this.rtb.TabIndex = 0;
			this.rtb.Text = "";
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(329, 12);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(104, 24);
			this.radioButton1.TabIndex = 1;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Start Are Time";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.Enter += new System.EventHandler(this.RadioButton1Enter);
			// 
			// timer
			// 
			this.timer.Interval = 1000;
			this.timer.Tick += new System.EventHandler(this.TimerTick);
			// 
			// tb
			// 
			this.tb.Location = new System.Drawing.Point(7, 246);
			this.tb.Name = "tb";
			this.tb.Size = new System.Drawing.Size(302, 20);
			this.tb.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(234, 286);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 37);
			this.button1.TabIndex = 3;
			this.button1.Text = "Send";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Location = new System.Drawing.Point(329, 65);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(103, 119);
			this.panel1.TabIndex = 4;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(3, 3);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(99, 115);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Location = new System.Drawing.Point(409, 221);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(48, 118);
			this.panel2.TabIndex = 5;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(44, 114);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// tb2
			// 
			this.tb2.Location = new System.Drawing.Point(349, 286);
			this.tb2.Name = "tb2";
			this.tb2.Size = new System.Drawing.Size(54, 20);
			this.tb2.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(315, 251);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 23);
			this.label1.TabIndex = 7;
			this.label1.Text = "Get are number";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(341, 312);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(62, 37);
			this.button2.TabIndex = 8;
			this.button2.Text = "Kick";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(482, 365);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tb2);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tb);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.rtb);
			this.Name = "MainForm";
			this.Text = "ShortFigther";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
