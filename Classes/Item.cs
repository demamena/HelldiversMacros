using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelldiversMacro.Classes
{
	public class Item
	{
		public string name;
		public List<string> keys;
		public string keybind;
		public bool isActive = true;

		public Item(string name, List<string> keys, string keybind)
		{
			this.name = name;
			this.keys = keys;
			this.keybind = keybind;
		}

        public Item(string name)
        {
            this.name = name;
            this.keys = new List<string>() { "", "", "", "", "", "", "", "" };
        }

		public Item()
		{

		}
    }
}
