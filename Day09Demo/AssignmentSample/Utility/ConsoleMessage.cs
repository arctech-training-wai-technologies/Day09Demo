﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09Demo.AssignmentSample.Utility
{
    public static class ConsoleMessage
    {
        public static void ShowError(string message)
        {
            ConsoleTextColor.SetError();
            Console.WriteLine(message);
            ConsoleTextColor.Reset();
        }

        public static void ShowWarning(string message)
        {
            ConsoleTextColor.SetWarning();
            Console.WriteLine(message);
            ConsoleTextColor.Reset();
        }

        public static void ShowHighlight(string message)
        {
            ConsoleTextColor.SetHighlight();
            Console.WriteLine(message);
            ConsoleTextColor.Reset();
        }

        public static void ShowText(string message)
        {
            Console.WriteLine(message);
        }

        internal static void ShowFormTitle(string headerText, int? width = null)
        {
            var line = new string('-', width ?? headerText.Length);

            Console.WriteLine(line);
            Console.WriteLine(headerText);
            Console.WriteLine(line);
        }

        public static T ReadLine<T>(string label)
        {
            Console.Write(label);
            var inputText = Console.ReadLine();

            return (T)Convert.ChangeType(inputText, typeof(T));
        }

        internal static void ShowSubTitle(string titleText, int? width = null)
        {
            var line = new string('-', width ?? titleText.Length);

            Console.WriteLine(titleText);
            Console.WriteLine(line);
        }

        internal static void ShowReportTitle(string titleText, int? width = null)
        {
            int reportWidth = width ?? titleText.Length;
            var line = new string('-', reportWidth);
            var padding = new string(' ', reportWidth - titleText.Length - 2);

            Console.WriteLine(line);
            Console.WriteLine($"|{titleText}{padding}|");
            Console.WriteLine(line);
        }
    }
}