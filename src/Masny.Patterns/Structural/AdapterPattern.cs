using Masny.Core;
using System;
using System.Text.RegularExpressions;

namespace Masny.Patterns.Structural.Adapter
{
    interface IAdapter
    {
        string ConvertToFirstFormat(string input);
        string ConvertToSecondFormat(string input);
    }

    class Adapter : IAdapter
    {
        public string ConvertToFirstFormat(string input)
        {
            return Regex.Replace(input, "[^0-9.]", "");
        }

        public string ConvertToSecondFormat(string input)
        {
            return Regex.Replace(input, @"[\d-]", string.Empty);
        }
    }

    class AnotherService
    {
        public void Request(object data)
        {
            Console.WriteLine($"Request '{data}'..");
        }
    }

    public class AdapterPattern : IExample
    {
        public void Start()
        {
            var guid = Guid.NewGuid().ToString();
            Console.WriteLine($"Data to convert '{guid}'.");

            IAdapter adapter = new Adapter();
            var firstFormat = adapter.ConvertToFirstFormat(guid);

            var anotherService = new AnotherService();
            anotherService.Request(firstFormat);
        }
    }
}
