﻿using MSC.Socrata.Device.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var consumer = new Consumer("soda.demo.socrata.com", "YOUR_TOKEN");

            var handle = consumer.GetObjectAsync<Earthquake>("earthquake");
            handle.Wait();
            var result = handle.Result;
            Console.ReadLine();
        }
    }
}