/*
 * Создано в SharpDevelop.
 * Пользователь: pricklly
 * Дата: 17.11.2024
 * Время: 8:06
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ShortFigther
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int t;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void RadioButton1Enter(object sender, EventArgs e)
		{
			timer.Enabled=true;
			timer.Start();
		}
		void Button1Click(object sender, EventArgs e)
		{
			rtb.AppendText(tb.Text+'\n');
			
		}
		void Button2Click(object sender, EventArgs e)
		{
			rtb.AppendText(tb2.Text+'\n');
		}
		void TimerTick(object sender, EventArgs e)
		{
			t++;
			rtb.AppendText(t.ToString());
		}
	}
}
