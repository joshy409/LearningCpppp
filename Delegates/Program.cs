using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    

    public class Photo
    {
        public void save()
        {
            Console.WriteLine("saved");
        }
    }

    public class PhotoProcessor
    {
        //public delegate void PhotoFilterHander(Photo photo);
        public void Process (string path, 
            Action<Photo> filterHandler)
        {
            
            var photo = new Photo();

            var filters = new PhotoFilters();
            filterHandler(photo);

            photo.save();
        }
    }

    internal class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Brightness");
        }
        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Contrast");
        }
        public void Resize(Photo photo)
        {
            Console.WriteLine("Resize");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var pho = new PhotoProcessor();
            var filters = new PhotoFilters();
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEye;
            pho.Process("asdf", filterHandler);
        }

        static void RemoveRedEye (Photo photo)
        {
            Console.WriteLine("remove red eye");
        }
    }
}
