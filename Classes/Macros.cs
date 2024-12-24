using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

namespace HelldiversMacro.Classes
{
	public class Macros
	{
		public const int KEYEVENTF_KEYDOWN = 0x0000; // New definition
		public const int KEYEVENTF_EXTENDEDKEY = 0x0001; //Key down flag
		public const int KEYEVENTF_KEYUP = 0x0002; //Key up flag
		public const int VK_LCONTROL = 0xA2; //Left Control key code

		[DllImport("user32.dll", SetLastError = true)]
		static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

		
		private static void PressKey(int key)
		{
			keybd_event((byte)key, 0, KEYEVENTF_KEYDOWN, 0);
			Thread.Sleep(5);
			keybd_event((byte)key, 0, KEYEVENTF_KEYUP, 0);
            Thread.Sleep(50);
        }

		public static void UseMacro(List<string> keys)
		{
			keybd_event((byte)VK_LCONTROL, 0, KEYEVENTF_KEYDOWN, 0); // KeyDown Left CTRL
            Thread.Sleep(50);
            foreach (string key in ItemControls.ArrowsToString(keys))
			{
				if (key == "")
					continue;

				PressKey((int)ItemControls.KeybindToKeys(key));
			}
			keybd_event((byte)VK_LCONTROL, 0, KEYEVENTF_KEYUP, 0); // KeyUp Left CTRL
		}
	}
}
