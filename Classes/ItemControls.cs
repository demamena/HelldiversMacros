using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelldiversMacro.Classes
{
	internal static class ItemControls
	{
		public static List<Item> GetItems()
		{
			var items = JsonConvert.DeserializeObject<List<Item>>(File.ReadAllText("items.json"));
            return items;
        }

		public static string ConvertKeyToArrow(string key)
		{
			switch (key)
			{
				case "W":
					return "↑";
				case "A":
					return "←";
				case "S":
					return "↓";
				case "D":
					return "→";
				default:
					return "";
			}
		}

		public static string ConvertArrowToKey(string arrow)
		{
            switch (arrow)
            {
                case "↑":
                    return "W";
                case "←":
                    return "A";
                case "↓":
                    return "S";
                case "→":
                    return "D";
                default:
                    return "";
            }
        }

		public static Keys KeybindToKeys(string keybind)
		{
            Keys key;
            Enum.TryParse(keybind, out key);

			return key;
        }

		public static void WriteItemsToJson(List<Item> items)
		{
			for (int i = 0; i < items.Count; i++)
				items[i].keys = ArrowsToString(items[i].keys);

            string json = JsonConvert.SerializeObject(items, Formatting.Indented);
            File.WriteAllText("items.json", json);
        }

		public static List<string> ArrowsToString(List<string> keys)
		{
			for (int i = 0; i < keys.Count; i++)
			{	
				if (keys[i] == "")
					continue;

				keys[i] = ConvertArrowToKey(keys[i]) != "" ? ConvertArrowToKey(keys[i]) : keys[i];
            }
			return keys;
        }
	}
}
