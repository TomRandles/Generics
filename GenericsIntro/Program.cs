using GenericsIntro.Domain;
using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            var buffer = new Buffer<double>();

            ProcessInput(buffer);
            ProcessBuffer(buffer);
        }

        private static void ProcessBuffer(Buffer<double> buffer)
        {
            var sum = 0.0;
            Console.WriteLine("Buffer: ");
            while (!buffer.IsEmpty)
            {
                sum += buffer.Read();
            }
            Console.WriteLine(sum);
        }

        private static void ProcessInput(Buffer<double> buffer)
        {
            while (true)
            {
                var value = 0.0;
                var input = Console.ReadLine();

                if (double.TryParse(input, out value))
                {
                    buffer.Write(value);
                    continue;
                }
                break;
            }
        }
    }
}