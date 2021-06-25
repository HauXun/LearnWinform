using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinQGUI
{
	public partial class Form1 : Form
	{
		List<Food> foods;
		public Form1()
		{
			InitializeComponent();

			LoadFood();
		}

		void LoadFood()
		{
			foods = new List<Food>();
			foods.Add(new Food("Hai Zụ Dầm Nho", "750000"));
			foods.Add(new Food("Tử hình 2 Zụ", "640000"));
			foods.Add(new Food("Nhúng nước 3 sọc", "150000"));
			foods.Add(new Food("Triệu hồi Chúa Dê Su", "Giá món này đạt mốc ∞"));
			foods.Add(new Food("Thất thủ Phao sần pa lây", "60000"));
			foods.Add(new Food("Thêm ánh hào quang màu hường", "240000"));
			foods.Add(new Food(@"Up Sức mạnh lên +∞", @"Giá món này đạt mốc ∞"));

			comboBoxData.DataSource = foods;
			comboBoxData.DisplayMember = "Name";
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			List<Food> result = new List<Food>();

			//foreach (Food item in foods)
			//{
			//	if (item.Name == textBoxKey.Text)
			//	{
			//		result.Add(item);
			//	}	
			//}

			result = foods.Where(x => x.Name == textBoxKey.Text).ToList();
			//var result2 = foods.Select(x => x.Price).SingleOrDefault();
			//result = foods.Skip(2).Take(2).ToList();
			//result = foods.OrderBy(x => Convert.ToInt32(x.Price)).ToList();

			comboBoxResult.DataSource = result;
			comboBoxResult.DisplayMember = "Price";
		}
	}
}
