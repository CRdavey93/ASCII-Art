using ImageMagick;
using System;
using System.IO;

namespace ASCII_Art
{
    class Program
    {
        private static string RunningPath = AppDomain.CurrentDomain.BaseDirectory;

        static void Main(string[] args)
        {
            Console.WriteLine(RunningPath);
            var image = GetImage(GetFilePath("ff_type0.jpg"));
            Console.WriteLine(image.Width);
            Console.WriteLine(image.Height);
        }

        private static MagickImage GetImage(string path)
        {
            var image = new MagickImage(path);
            return image;
        }

        private static string GetFilePath(string fileName)
        {
            var FilePath = string.Format("{0}Resources\\" + fileName, Path.GetFullPath(Path.Combine(RunningPath, @"..\..\..\")));

            return FilePath;
        }

        //private static void PrintImageInfo(MagickImage image)
        //{
        //    var info = new MagickImageInfo()
        //}
    }

}
