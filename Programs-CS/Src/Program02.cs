using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs_CS.Src
{
    public class Program02
    {
        public Program02()
        {

            Console.WriteLine("\nOutput:");
            File file = File.GetObject(FileType.Picture);
            file.Display(new Picture
            {
                FileName = "123.png",
                Extension = ".png",
                FilePath = @"D:\123.png",
                Length = 123456,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Camera = "MI",
                ISO = 600,
                Resolution = 400
            });

            file = File.GetObject(FileType.Video);
            file.Display(new Video
            {
                FileName = "123.mp4",
                Extension = ".mp4",
                FilePath = @"D:\123.mp4",
                Length = 123456,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                BItRate = 512,
                FramePerSecond = 300
            });
        }

        internal interface IFile
        {
            string FileName { get; set; }
            string Extension { get; set; }
            string FilePath { get; set; }
            long Length { get; set; }
            DateTime CreatedDate { get; set; }
            DateTime ModifiedDate { get; set; }
        }

        internal enum FileType
        {
            Picture = 1,
            Video = 2
        }

        internal class Picture : File, IFile
        {
            public string FileName { get; set; }
            public string Extension { get; set; }
            public string FilePath { get; set; }
            public long Length { get; set; }
            public DateTime CreatedDate { get; set; }
            public DateTime ModifiedDate { get; set; }

            public string Camera { get; set; }
            public int ISO { get; set; }
            public int Resolution { get; set; }

            internal override void Display(IFile file)
            {
                Picture video = file as Picture;
                Console.WriteLine("\nFile Type: Picture");
                Console.WriteLine("FileName: " + video.FileName);
                Console.WriteLine("Extension: " + video.Extension);
                Console.WriteLine("Length: " + video.Length);
                Console.WriteLine("CreatedDate: " + video.CreatedDate);
                Console.WriteLine("ModifiedDate: " + video.ModifiedDate);
                Console.WriteLine("Camera: " + video.Camera);
                Console.WriteLine("ISO: " + video.ISO);
                Console.WriteLine("Resolution: " + video.Resolution);
            }
        }

        internal class Video : File, IFile
        {
            public string FileName { get; set; }
            public string Extension { get; set; }
            public string FilePath { get; set; }
            public long Length { get; set; }
            public DateTime CreatedDate { get; set; }
            public DateTime ModifiedDate { get; set; }
            public int FramePerSecond { get; set; }
            public int BItRate { get; set; }

            internal override void Display(IFile file)
            {
                Video video = file as Video;
                Console.WriteLine("\nFile Type: Video");
                Console.WriteLine("FileName: " + video.FileName);
                Console.WriteLine("Extension: " + video.Extension);
                Console.WriteLine("Length: " + video.Length);
                Console.WriteLine("CreatedDate: " + video.CreatedDate);
                Console.WriteLine("ModifiedDate: " + video.ModifiedDate);
                Console.WriteLine("FramePerSecond: " + video.FramePerSecond);
                Console.WriteLine("BItRate: " + video.BItRate);
            }
        }

        internal abstract class File
        {
            internal static File GetObject(FileType fileType)
            {
                switch (fileType)
                {
                    case FileType.Picture:
                        return new Picture();
                    case FileType.Video:
                        return new Video();
                    default:
                        return null;
                }
            }

            internal abstract void Display(IFile file);

        }
    }

    
}
