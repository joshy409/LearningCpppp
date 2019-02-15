using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class YouTubeException : Exception
    {
        public YouTubeException(string message, Exception innerException)
            : base (message, innerException)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader("path");
                var content = streamReader.ReadToEnd();
                
            }
            catch (Exception ex)
            {
                throw new YouTubeException("Could not fetch", ex);
                Console.WriteLine("can't divide by 0");
            }
            finally
            {
                if (streamReader != null)
                    streamReader.Dispose();
            }
        }

        static int Divide (int n, int d)
        {
            return n / d;
        }
    }
}
