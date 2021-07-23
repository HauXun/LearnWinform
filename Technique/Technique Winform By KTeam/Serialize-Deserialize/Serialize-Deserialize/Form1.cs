using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Serialize_Deserialize
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		Random random = new Random();
		List<Button> buttons = new List<Button>();
		private void btnAdd_Click(object sender, EventArgs e)
		{
			Button newButton = new Button() { Text = "MLG", Width = 400, Height = 100 };
			newButton.Location = new Point(random.Next(this.Size.Width), random.Next(this.Size.Height));
			this.Controls.Add(newButton);
			buttons.Add(newButton);
		}

		void Serialize()
		{
			StreamWriter sw = new StreamWriter(new FileStream("Setting.oke", FileMode.Create));
			XmlSerializer seriItem = new XmlSerializer(typeof(int));
			seriItem.Serialize(sw, buttons.Count);
			foreach (var item in buttons)
			{
				SettingInfo settingInfo = new SettingInfo();
				settingInfo.Text = item.Text;
				settingInfo.Width = item.Width;	
				settingInfo.Height = item.Height;
				settingInfo.Location = item.Location;
				XmlSerializer serializer = new XmlSerializer(typeof(SettingInfo));
				serializer.Serialize(sw, settingInfo);
			}
			sw.Close();
		}

		void Deserialize()
		{
			buttons.Clear();
			StreamReader sr = new StreamReader(new FileStream("Setting.oke", FileMode.Create));
			XmlSerializer seriItem = new XmlSerializer(typeof(int));

			for (int i = 0; i < (int)seriItem.Deserialize(sr); i++)
			{
				XmlSerializer serializer = new XmlSerializer(typeof(SettingInfo));
				SettingInfo settingInfo = new SettingInfo();
				settingInfo = (SettingInfo)seriItem.Deserialize(sr);

				Button button = new Button();
				button.Text = settingInfo.Text;
				button.Width = settingInfo.Width;
				button.Height = settingInfo.Height;
				button.Location = settingInfo.Location;

				buttons.Add(button);
				this.Controls.Add(button);
			}

			sr.Close();
		}

		private void btnSerialize_Click(object sender, EventArgs e)
		{
			Serialize();
		}

		private void btnDesrialize_Click(object sender, EventArgs e)
		{

		}
	}
}
