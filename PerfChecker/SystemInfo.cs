using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using Microsoft.Win32;

namespace PerfChecker
{
    public static class SystemInfo
    {
        private static CancellationTokenSource tokenSource;

        public delegate void Output(string timeTaken, long totalCPUTicksUsed);
        public static event Output OnOutputResults;

        public delegate void Cancel();
        public static event Cancel CancelT;

        public static string OsName => Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ProductName", "").ToString();
        public static string OsVersion => Environment.OSVersion.ToString();        
        public static bool Os64 => Environment.Is64BitOperatingSystem;
        public static string PcName => Environment.MachineName;
        public static string NumberOfCores => CPUCoreCount();
        public static int NumberOfThreads => Environment.ProcessorCount;        
        public static string RamInfo => GetRAMInfo();
        public static string WindowsFolder => Environment.SystemDirectory;
        public static string[] LogicalDrives => Environment.GetLogicalDrives();
        public static string CPUClockSpeed => GetCPUInfo();

        public static string AllSysInfo()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("Windows OS Name: {0}", OsName).AppendLine();
            output.AppendFormat("Windows OS Version: {0}", OsVersion).AppendLine();            
            output.AppendFormat("64 Bit Operating System? : {0}", Os64 ? "Yes" : "No").AppendLine();
            output.AppendFormat("PC Name : {0}", PcName).AppendLine();
            output.AppendFormat("CPU Clock Speed : {0}", String.Join(", ", CPUClockSpeed)).AppendLine();
            output.AppendFormat("Number of CPU cores : {0}", NumberOfCores).AppendLine();
            output.AppendFormat("Number of CPU threads : {0}", NumberOfThreads).AppendLine();
            output.AppendFormat("Memory info : {0}", RamInfo).AppendLine();
            output.AppendFormat("Windows folder : {0}", WindowsFolder).AppendLine();
            output.AppendFormat("Logical Drives Available : {0}", String.Join(", ", LogicalDrives)
               .Replace("\\", String.Empty)).AppendLine();            
            return output.ToString();
        }
        public static async void RunTests(int arraySize)
        {
            try
            {
                tokenSource = new CancellationTokenSource();

                Process prc = Process.GetCurrentProcess();
                long startCPU = prc.TotalProcessorTime.Ticks;

                List<Task<string>> tasks = new List<Task<string>>();
                //tasks.Add(Task.Run(() => test.sorting.StartSort(test.sorting.SortTypes.BubbleSort, tokenSource.Token)));
                foreach (test.sorting.SortTypes sort in Enum.GetValues(typeof(test.sorting.SortTypes)))
                {
                    tasks.Add(Task.Run(() => test.sorting.StartSort(sort, arraySize, tokenSource.Token)));
                    //HelperClass.Wait(1000);
                }
                TimeSpan results = TimeSpan.Parse("00:00:00");
                Task t = Task.WhenAll(tasks.ToArray());
                try
                {
                    await t;
                }
                catch (OperationCanceledException)
                {
                    throw;
                }

                if (t.Status == TaskStatus.RanToCompletion)
                    Console.WriteLine("All tests succeeded.");
                else if (t.Status == TaskStatus.Faulted)
                    Console.WriteLine("Tests failed");

                for (int i = 0; i < tasks.Count; i++)
                {
                    results += TimeSpan.Parse(tasks[i].Result);
                }

                //string timeTaken = Task.Run(() => test.sorting.StartSort(test.sorting.SortTypes.BubbleSort, tokenSource.Token));
                //timeTaken += await Task.Run(() => test.sorting.StartSort(test.sorting.SortTypes.QuickSort, tokenSource.Token));
                long endCPU = prc.TotalProcessorTime.Ticks;
                long totalCPUTicksUsed = endCPU - startCPU;

                //OnOutputResults?.Invoke(results.ToString(), totalCPUTicksUsed);
                OnOutputResults?.Invoke(results.ToString(), totalCPUTicksUsed);
            }
            catch (OperationCanceledException)
            {
                CancelT?.Invoke();
            }
        }
        public static void CancelTask()
        {
            tokenSource.Cancel();
        }

        private static string GetCPUInfo()
        {
            PerformanceCounter cpuCounter = new PerformanceCounter("Processor Information", "% Processor Performance", "_Total");
            double cpuValue = cpuCounter.NextValue();

            Thread loop = new Thread(() => InfiniteLoop());
            loop.Start();

            Thread.Sleep(1000);
            cpuValue = cpuCounter.NextValue();
            loop.Abort();

            foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT *, Name FROM Win32_Processor").Get())
            {
                double maxSpeed = Convert.ToDouble(obj["MaxClockSpeed"]) / 1000;
                double turboSpeed = maxSpeed * cpuValue / 100;
                return string.Format("{0} Running at {1:0.00}Ghz, Turbo Speed: {2:0.00}Ghz", obj["Name"], maxSpeed, turboSpeed);
            }

            return string.Empty;
        }

        private static void InfiniteLoop()
        {
            int i = 0;

            while (true)
                i = i + 1 - 1;
        }

        public static string CPUCoreCount()
        {
            int coreCount = 0;
            foreach (var item in new ManagementObjectSearcher("Select * from Win32_Processor").Get())
            {
                coreCount += int.Parse(item["NumberOfCores"].ToString());
            }
            return coreCount.ToString();
        }

        public static string GetRAMInfo()
        {
            ObjectQuery winQuery = new ObjectQuery("SELECT * FROM Win32_ComputerSystem");

            ManagementObjectSearcher searcher = new ManagementObjectSearcher(winQuery);

            string totalPhysicalMemory = "0";
            
            foreach (ManagementObject obj in searcher.Get())
            {
                totalPhysicalMemory = $"Total Physical Memory: {Math.Round(Convert.ToDouble(obj["TotalPhysicalMemory"]) / (1024 * 1024 * 1024))} GB";
            }

            return string.Format("{0}", totalPhysicalMemory);
        }
    }
}

