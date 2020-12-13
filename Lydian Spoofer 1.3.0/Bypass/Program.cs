using System;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Menu;
using SKM.V3;
using SKM.V3.Methods;
using SKM.V3.Models;

namespace Bypass
{
	internal class Program
	{
		[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern void BlockInput([MarshalAs(UnmanagedType.Bool)] [In] bool fBlockIt);

		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern bool AllocConsole();

		[DllImport("kernel32.dll")]
		private static extern IntPtr GetConsoleWindow();

		[DllImport("user32.dll")]
		private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

		public static void ShowConsoleWindow()
		{
			IntPtr consoleWindow = Program.GetConsoleWindow();
			if (consoleWindow == IntPtr.Zero)
			{
				Program.AllocConsole();
			}
			else
			{
				Program.ShowWindow(consoleWindow, 5);
			}
		}

		public static void ConsoleHide()
		{
			IntPtr consoleWindow = Program.GetConsoleWindow();
			Program.ShowWindow(consoleWindow, 0);
		}

		public static void ConsoleShow()
		{
			Console.SetWindowSize(72, 30);
			IntPtr consoleWindow = Program.GetConsoleWindow();
			Program.ShowWindow(consoleWindow, 5);
		}

		private static void Main(string[] args)
		{
			Console.Title = "Lydian Spoofer 1.3.0";
			Console.SetWindowSize(72, 30);
			if (!File.Exists("Lydian Spoofer 1.3.0.exe.config"))
			{
				Console.WriteLine("[+]Downloading settings files...");
				using (WebClient webClient = new WebClient())
				{
					webClient.DownloadFile("https://cdn.discordapp.com/attachments/698964774096076833/698965202296635402/LydianSpoofer.exe.config", "Lydian Spoofer 1.3.0.exe.config");
				}
				Thread.Sleep(500);
				FileInfo fileInfo = new FileInfo("Lydian Spoofer 1.3.0.config");
				fileInfo.Attributes = FileAttributes.Hidden;
				MessageBox.Show("Loader needs to restart");
				Environment.Exit(0);
			}
			foreach (Process process in Process.GetProcessesByName("HWIDBypass"))
			{
				process.Kill();
			}
			if (File.Exists("C:\\Users\\Default\\ERDCFVtyb\\NetFresh.kor"))
			{
				if (File.Exists("C:\\Windows\\PPKR$5\\register.xfr"))
				{
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write("[+]Pc is registred: ");
					Thread.Sleep(500);
					Console.Clear();
					Console.WriteLine("              Welcome to Lydian Spoofer! @ Copyright 2021");
					Thread.Sleep(1000);
					Console.Clear();
					Program2.startSpoof();
				}
				else
				{
					Console.Write("[+]Enter Your Key License: ");
					string key = Console.ReadLine();
					Console.Clear();
					Console.WriteLine("[+]Checking your Key...");
					string rsaPublicKey = "<RSAKeyValue><Modulus>0SQ3RqwNvcGHidLrlufXlI+136Rr9XifuWcr3BbKe/+8s5p9rCASO+qSCYx4X7Rei3lcp3tJLFZQmm5YWEASuIMOYJxq5O2jfgka/6Ieetn30jDfDruA82B/PBpUBprTubB1WU0KBOL+eDnXOKApQ0FAfD/yOoR1pRGNYV6thgcvY9/+LXzWiHtUnOIcTrgpzTp8zuYddfRIuHtmn+8Hn6LR4PHZ2sxeyvo1sJxcJzIKljF3Usn0+QQl/deFYm2+yutKc22Nuk8jMa8/X22HNaXOY0o6YUZB5JWFxhT/IZtBN3g6XtGt6ayaW8D1p/nTREmRMbELl3zArkxODzsPYw==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
					string token = "WyIxNzYxMyIsIjNtLzJtZkxjSEs3TXp0WlNLbjdqZG1xbVAwQUJHNzNiakFHQ2Iyd0kiXQ==";
					KeyInfoResult keyInfoResult = Key.Activate(token, new ActivateModel
					{
						Key = key,
						ProductId = 6070,
						Sign = true,
						MachineCode = Helpers.GetMachineCode()
					});
					if (keyInfoResult == null || keyInfoResult.Result == ResultType.Error || !keyInfoResult.LicenseKey.HasValidSignature(rsaPublicKey).IsValid())
					{
						SystemSounds.Beep.Play();
						DirectoryInfo directoryInfo = new DirectoryInfo("c:\\Users\\Default\\AppData\\Local\\Temp\\Chache");
						if (directoryInfo.Exists)
						{
							directoryInfo.Delete(true);
						}
						Console.Clear();
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("[+]Invalid License or Expired.");
						Thread.Sleep(1500);
						Console.Clear();
						Console.ForegroundColor = ConsoleColor.White;
						Console.WriteLine("[+]You Can buy your Key From our Store:");
						Thread.Sleep(1000);
						Process.Start(new ProcessStartInfo("iexplore.exe")
						{
							Arguments = "https://lydian.selly.store/"
						});
						Thread.Sleep(3500);
						Environment.Exit(0);
					}
					Console.WriteLine("              Welcome to Lydian Spoofer! @ Copyright 2020");
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine("[+]The license is valid: " + keyInfoResult.LicenseKey.DaysLeft() + " Day(s) Left. ");
					Thread.Sleep(2000);
					File.Delete("C:\\Windows\\AMIDEWINx64.exe");
					File.Delete("C:\\Windows\\amifldrv64.sys");
					Program2.startSpoof();
				}
			}
			else
			{
				Console.Write("[+]Enter Your Key License: ");
				string key2 = Console.ReadLine();
				Console.Clear();
				Console.WriteLine("[+]Checking your Key...");
				string rsaPublicKey2 = "<RSAKeyValue><Modulus>0SQ3RqwNvcGHidLrlufXlI+136Rr9XifuWcr3BbKe/+8s5p9rCASO+qSCYx4X7Rei3lcp3tJLFZQmm5YWEASuIMOYJxq5O2jfgka/6Ieetn30jDfDruA82B/PBpUBprTubB1WU0KBOL+eDnXOKApQ0FAfD/yOoR1pRGNYV6thgcvY9/+LXzWiHtUnOIcTrgpzTp8zuYddfRIuHtmn+8Hn6LR4PHZ2sxeyvo1sJxcJzIKljF3Usn0+QQl/deFYm2+yutKc22Nuk8jMa8/X22HNaXOY0o6YUZB5JWFxhT/IZtBN3g6XtGt6ayaW8D1p/nTREmRMbELl3zArkxODzsPYw==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
				string token2 = "WyIxNzYxMyIsIjNtLzJtZkxjSEs3TXp0WlNLbjdqZG1xbVAwQUJHNzNiakFHQ2Iyd0kiXQ==";
				KeyInfoResult keyInfoResult2 = Key.Activate(token2, new ActivateModel
				{
					Key = key2,
					ProductId = 6070,
					Sign = true,
					MachineCode = Helpers.GetMachineCode()
				});
				if (keyInfoResult2 == null || keyInfoResult2.Result == ResultType.Error || !keyInfoResult2.LicenseKey.HasValidSignature(rsaPublicKey2).IsValid())
				{
					SystemSounds.Beep.Play();
					DirectoryInfo directoryInfo2 = new DirectoryInfo("c:\\Users\\Default\\AppData\\Local\\Temp\\Chache");
					if (directoryInfo2.Exists)
					{
						directoryInfo2.Delete(true);
					}
					Console.Clear();
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("[+]Invalid License or Expired.");
					Thread.Sleep(1500);
					Console.Clear();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("[+]You Can buy your Key From our Store:");
					Thread.Sleep(1000);
					Process.Start(new ProcessStartInfo("iexplore.exe")
					{
						Arguments = "https://lydian.selly.store/"
					});
					Thread.Sleep(3500);
					Environment.Exit(0);
				}
				Console.WriteLine("              Welcome to Lydian Spoofer! @ Copyright 2020");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("[+]The license is valid: " + keyInfoResult2.LicenseKey.DaysLeft() + " Day(s) Left. ");
				Thread.Sleep(2000);
				File.Delete("C:\\Windows\\AMIDEWINx64.exe");
				File.Delete("C:\\Windows\\amifldrv64.sys");
				Program2.startSpoof();
			}
		}

		private const int SW_HIDE = 0;

		private const int SW_SHOW = 5;
	}
}
