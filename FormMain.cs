using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using HelldiversMacro.Classes;
using HelldiversMacro.UserControls;

namespace HelldiversMacro
{
	public partial class FormMain : Form
	{
        [DllImport("User32.dll")]
        private static extern int RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")] 
		private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        
		public FormMain()
		{
			InitializeComponent();
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
            CreateItemUserControls();
        }

		private void CreateItemUserControls()
        {
            foreach (var item in ItemControls.GetItems()) 
			{
				AddItemUserControl(item);
			}
			RegisterItemControls();
        }

		private void RegisterItemControls()
		{
            UnregisterAllHotKeys();
			for (int i = 0; i < panel_items.Controls.Count; i++)
			{
				var item = (panel_items.Controls[i] as ItemUserControl).item;
                Keys key = ItemControls.KeybindToKeys(item.keybind);
                if (item.isActive && key != Keys.None)
                    RegisterHotKey(Handle, i, 0, (int)key);

                panel_items.Controls[i].Tag = i;
            }
        }

		private ItemUserControl AddItemUserControl(Item item)
		{
			var userControl = new ItemUserControl(item) { Dock = DockStyle.Top };
            panel_items.Controls.Add(userControl);

			return userControl;
        }

        private void button_addItem_Click(object sender, EventArgs e)
        {
			var new_item = new Item("Name");
			AddItemUserControl(new_item);
			UpdateItems();
        }

		private List<Item> GetLocalItems()
		{
			var items = new List<Item>();
			foreach (var itemUserControl in panel_items.Controls)
			{
                items.Add((itemUserControl as ItemUserControl).item);
			}

			return items;
		}

		public void UpdateItems()
		{
			ItemControls.WriteItemsToJson(GetLocalItems());
            RegisterItemControls();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
			UpdateItems();
        }

		protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312)
            {
                int hotkeyId = m.WParam.ToInt32();
                var itemControl = panel_items.Controls.OfType<ItemUserControl>()
					.FirstOrDefault(ctrl => ctrl.Tag.ToString() == hotkeyId.ToString());

				if (!itemControl.item.isActive)
					return;

				Macros.UseMacro(itemControl.item.keys);
            }
            base.WndProc(ref m);
        }

        private void UnregisterAllHotKeys()
		{ 
			for (int id = 0; id < 100; id++)
			{ 
				UnregisterHotKey(Handle, id); 
			} 
		}
    }
}
