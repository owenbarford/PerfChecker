using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PerfChecker
{
    public static class SystemInfo
    {
        private static CancellationTokenSource tokenSource;
        private static CancellationToken token;

        public delegate void Output(string timeTaken, long totalCPUTicksUsed, string resultsSort);
        public static event Output OnOutputResults;

        public static string OsVersion => Environment.OSVersion.ToString();
        public static bool Os64 => Environment.Is64BitOperatingSystem;
        public static string PcName => Environment.MachineName;
        public static int NumberOfCpus => Environment.ProcessorCount;
        public static string WindowsFolder => Environment.SystemDirectory;
        public static string[] LogicalDrives => Environment.GetLogicalDrives();

        public static string AllSysInfo()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("Windows version: {0}", OsVersion).AppendLine();
            output.AppendFormat("64 Bit operating system? : {0}", Os64 ? "Yes" : "No").AppendLine();
            output.AppendFormat("PC Name : {0}", PcName).AppendLine();
            output.AppendFormat("Number of CPUS : {0}", NumberOfCpus).AppendLine();
            output.AppendFormat("Windows folder : {0}", WindowsFolder).AppendLine();
            output.AppendFormat("Logical Drives Available : {0}", String.Join(", ", LogicalDrives)
               .Replace("\\", String.Empty)).AppendLine();
            return output.ToString();
        }
        public static async void RunTests()
        {
            tokenSource = new CancellationTokenSource();
            token = new CancellationToken();
            await Task.Factory.StartNew(() =>
            {
                Process prc = Process.GetCurrentProcess();
                long startCPU = prc.TotalProcessorTime.Ticks;
                string timeTaken = test.sorting.StartSort(test.sorting.SortTypes.BubbleSort);
                long endCPU = prc.TotalProcessorTime.Ticks;
                long totalCPUTicksUsed = endCPU - startCPU;
                string resultsSort = "Hello";
                OnOutputResults?.Invoke(timeTaken, totalCPUTicksUsed, resultsSort);
            },  token);
        }
        public static void CancelTack()
        {
            tokenSource.Cancel();
        }
    }
}

