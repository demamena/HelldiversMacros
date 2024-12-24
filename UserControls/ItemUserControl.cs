using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HelldiversMacro.Classes;

namespace HelldiversMacro.UserControls
{
	public partial class ItemUserControl : UserControl
	{
		public Item item;

		public ItemUserControl(Item item)
		{
			InitializeComponent();
			this.item = item;
			SetItemData(item);
		}

		private void SetItemData(Item item)
		{   
			textBox_name.Text = item.name;
			comboBox_keybind.Text = item.keybind;
			checkBox_isActive.Checked = item.isActive;
			SetComboBoxMousewheel();

			for (int i = 0; i < item.keys.Count; i++)
			{
				GetPanelComboBox(i.ToString()).Text = ItemControls.ConvertKeyToArrow(item.keys[i]);
			}
		}

		private void SetComboBoxMousewheel()
		{
			var comboBoxex = new List<ComboBox>() {
				comboBox_key_1, comboBox_key_2, comboBox_key_3,
				comboBox_key_4, comboBox_key_5, comboBox_key_6,
				comboBox_key_7, comboBox_key_8, comboBox_keybind
			};
			foreach (ComboBox comboBox in comboBoxex)
			{
				comboBox.MouseWheel += (sender, e) => { ((HandledMouseEventArgs)e).Handled = true; };
			}
		}

		private ComboBox GetPanelComboBox(string panelNumber)
		{
			switch (panelNumber)
			{
				case "0": return comboBox_key_1;
				case "1": return comboBox_key_2;
				case "2": return comboBox_key_3;
				case "3": return comboBox_key_4;
				case "4": return comboBox_key_5;
				case "5": return comboBox_key_6;
				case "6": return comboBox_key_7;
				case "7": return comboBox_key_8;
				default: return comboBox_keybind;
			}
		}

		private void comboBox_key_SelectedIndexChanged(object sender, EventArgs e)
		{
			var index = (sender as ComboBox).Tag.ToString();
			var comboBox = GetPanelComboBox(index);
			try
			{
				item.keys[Convert.ToInt32(index)] = comboBox.Text;
			} catch
			{
				item.keybind = comboBox.Text;
            }
		}

        private void checkBox_isActive_CheckedChanged(object sender, EventArgs e)
        {
			item.isActive = checkBox_isActive.Checked;
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {
			item.name = textBox_name.Text;
        }
    }
}   
