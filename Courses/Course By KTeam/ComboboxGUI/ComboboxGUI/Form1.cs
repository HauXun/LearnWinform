using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboboxGUI
{
	public partial class Form1 : Form
	{
		List<VNCH> listItems;
		List<CBClass> listClass;

		public Form1()
		{
			InitializeComponent();
			listItems = new List<VNCH>() {
			new VNCH() {CongSan = "Hai Zụ", DanChu = "Trần Dần"},
			new VNCH() { CongSan = "VnJat", DanChu = "Tôn" },
			new VNCH() { CongSan = "SickDuck", DanChu = "SuckD*ck" }
			};
			comboBox1.DataSource = listItems;
			comboBox1.DisplayMember = "CongSan";

			AddBinding();

			listClass = new List<CBClass>();
			listClass.Add(
				new CBClass()
				{
					ClassName = "CTK44A",
					ListStudent = new List<string>()
					{
						"Hậu",
						"Thắng",
						"Trang",
						"Vỹ"
					}
				}
				);
			listClass.Add(
				new CBClass()
				{
					ClassName = "CTK44B",
					ListStudent = new List<string>()
					{
						"Yến",
						"Sơn",
						"Long",
						"Sang"
					}
				}
				);
			comboBoxBranch.DataSource = listClass;
			comboBoxBranch.DisplayMember = "ClassName";
			//AddClassBinding();
		}

		void AddClassBinding()
		{
			comboBoxCLass.DataBindings.Add("DataSource", comboBoxBranch.SelectedValue, "ListStudent",
				true, DataSourceUpdateMode.OnPropertyChanged);
		}

		void AddBinding()
		{
			textBox1.DataBindings.Add(new Binding("Text", comboBox1.DataSource, "DanChu"));
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			//ComboBox comboBox = sender as ComboBox;

			//if (comboBox.SelectedValue != null)
			//{
			//	VNCH vnch = comboBox.SelectedValue as VNCH;
			//	textBox1.Text = vnch.DanChu;
			//}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//listItems = new List<VNCH>() {
			//new VNCH() {CongSan = "Hai Zụ", DanChu = "Trần Dần"},
			//new VNCH() { CongSan = "VnJat", DanChu = "Tôn" },
			//new VNCH() { CongSan = "SickDuck", DanChu = "SuckD*ck" }
			//};
			//comboBox1.DataSource = listItems;
			//comboBox1.DisplayMember = "CongSan";
		}

		private void comboBoxBranch_SelectedValueChanged(object sender, EventArgs e)
		{
			ComboBox comboBox = sender as ComboBox;

			if (comboBox.SelectedValue != null)
			{
				CBClass @class = comboBox.SelectedValue as CBClass;
				comboBoxCLass.DataSource = @class.ListStudent;
				//	comboBoxCLass.DisplayMember = "ListStudent";
			}
		}
	}

	class VNCH
	{
		public string CongSan { get; set; }
		public string DanChu { get; set; }
	}
	
	class CBClass
	{
		public string ClassName { get; set; }
		public List<string> ListStudent { get; set; }
	}
}
