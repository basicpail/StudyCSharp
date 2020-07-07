﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Interface
{
    interface ILogger
    {
        void WriteLog(string message);
    }
    class ConsoleLogger:ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now.ToLocalTime()},{message}");
        }
    }
    class FileLogger: ILogger
    {
        private StreamWriter writer;
        
        public FileLogger(string path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }
        public void WriteLog(string message)
        {
            writer.WriteLine($"{DateTime.Now.ToShortTimeString()},{message}");
        }
    }

    class ClimateMonitor
    {
        private ILogger logger;
        public ClimateMonitor(ILogger logger)
        {
            this.logger = logger;
        }
        public void start()
        {
            while(true)
            {
                Console.WriteLine("온도를 입력해주세요.:");
                string temperature = Console.ReadLine();
                if (temperature == "") break;

                logger.WriteLog("현재 온도: " + temperature);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ClimateMonitor monitor = new ClimateMonitor(new FileLogger("MyLog.txt"));

            monitor.start();
        }
    }
}
