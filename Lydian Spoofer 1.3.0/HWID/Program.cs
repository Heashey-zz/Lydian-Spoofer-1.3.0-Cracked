using System;
using System.Collections.Generic;
using System.Globalization;
using System.Management;
using System.Security.Cryptography;
using System.Text;

namespace HWID
{
	internal class Program
	{
		public static void Main2()
		{
			Console.WriteLine(Program.Value());
		}

		private static string Value()
		{
			if (string.IsNullOrEmpty(Program._fingerPrint))
			{
				Program._fingerPrint = Program.GetHash(string.Concat(new string[]
				{
					"CPU >> ",
					Program.CpuId(),
					"\nBIOS >> ",
					Program.BiosId(),
					"\nBASE >> ",
					Program.BaseId(),
					"\nDISK >> ",
					Program.DiskId(),
					"\nVIDEO >> ",
					Program.VideoId(),
					"\nMAC >> ",
					Program.MacId()
				}));
			}
			return Program._fingerPrint;
		}

		private static string GetHash(string s)
		{
			MD5 md = new MD5CryptoServiceProvider();
			byte[] bytes = Encoding.ASCII.GetBytes(s);
			return Program.GetHexString(md.ComputeHash(bytes));
		}

		private static string GetHexString(IList<byte> bt)
		{
			string text = string.Empty;
			for (int i = 0; i < bt.Count; i++)
			{
				byte b = bt[i];
				int num = (int)b;
				int num2 = num & 15;
				int num3 = num >> 4 & 15;
				if (num3 > 9)
				{
					text += ((char)(num3 - 10 + 65)).ToString(CultureInfo.InvariantCulture);
				}
				else
				{
					text += num3.ToString(CultureInfo.InvariantCulture);
				}
				if (num2 > 9)
				{
					text += ((char)(num2 - 10 + 65)).ToString(CultureInfo.InvariantCulture);
				}
				else
				{
					text += num2.ToString(CultureInfo.InvariantCulture);
				}
				if (i + 1 != bt.Count && (i + 1) % 2 == 0)
				{
					text += "-";
				}
			}
			return text;
		}

		private static string Identifier(string wmiClass, string wmiProperty, string wmiMustBeTrue)
		{
			string text = "";
			ManagementClass managementClass = new ManagementClass(wmiClass);
			ManagementObjectCollection instances = managementClass.GetInstances();
			foreach (ManagementBaseObject managementBaseObject in instances)
			{
				if (!(managementBaseObject[wmiMustBeTrue].ToString() != "True") && !(text != ""))
				{
					try
					{
						text = managementBaseObject[wmiProperty].ToString();
						break;
					}
					catch
					{
					}
				}
			}
			return text;
		}

		private static string Identifier(string wmiClass, string wmiProperty)
		{
			string text = "";
			ManagementClass managementClass = new ManagementClass(wmiClass);
			ManagementObjectCollection instances = managementClass.GetInstances();
			foreach (ManagementBaseObject managementBaseObject in instances)
			{
				if (!(text != ""))
				{
					try
					{
						text = managementBaseObject[wmiProperty].ToString();
						break;
					}
					catch
					{
					}
				}
			}
			return text;
		}

		private static string CpuId()
		{
			string text = Program.Identifier("Win32_Processor", "UniqueId");
			string result;
			if (text != "")
			{
				result = text;
			}
			else
			{
				text = Program.Identifier("Win32_Processor", "ProcessorId");
				if (text != "")
				{
					result = text;
				}
				else
				{
					text = Program.Identifier("Win32_Processor", "Name");
					if (text == "")
					{
						text = Program.Identifier("Win32_Processor", "Manufacturer");
					}
					text += Program.Identifier("Win32_Processor", "MaxClockSpeed");
					result = text;
				}
			}
			return result;
		}

		private static string BiosId()
		{
			return string.Concat(new string[]
			{
				Program.Identifier("Win32_BIOS", "Manufacturer"),
				Program.Identifier("Win32_BIOS", "SMBIOSBIOSVersion"),
				Program.Identifier("Win32_BIOS", "IdentificationCode"),
				Program.Identifier("Win32_BIOS", "SerialNumber"),
				Program.Identifier("Win32_BIOS", "ReleaseDate"),
				Program.Identifier("Win32_BIOS", "Version")
			});
		}

		public static string DiskId()
		{
			return Program.Identifier("Win32_DiskDrive", "Model") + Program.Identifier("Win32_DiskDrive", "Manufacturer") + Program.Identifier("Win32_DiskDrive", "Signature") + Program.Identifier("Win32_DiskDrive", "TotalHeads");
		}

		private static string BaseId()
		{
			return Program.Identifier("Win32_BaseBoard", "Model") + Program.Identifier("Win32_BaseBoard", "Manufacturer") + Program.Identifier("Win32_BaseBoard", "Name") + Program.Identifier("Win32_BaseBoard", "SerialNumber");
		}

		private static string VideoId()
		{
			return Program.Identifier("Win32_VideoController", "DriverVersion") + Program.Identifier("Win32_VideoController", "Name");
		}

		private static string MacId()
		{
			return Program.Identifier("Win32_NetworkAdapterConfiguration", "MACAddress", "IPEnabled");
		}

		private static string _fingerPrint = string.Empty;
	}
}
