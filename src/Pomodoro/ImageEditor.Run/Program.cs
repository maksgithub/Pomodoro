using System;
using SkiaSharp;

using System.IO;

namespace ImageEditor.Run
{
    class Program
    {
        static void Main(string[] args)
        {
            const int size = 150;
            const int quality = 75;

            using (var input = File.OpenRead(@"C:\Photos\RAW+JPG\IMG_0001.cr2"))
            {
                using (var inputStream = new SKManagedStream(input))
                {
                    using (var original = SKBitmap.Decode(inputStream))
                    {
                        int width, height;
                        if (original.Width > original.Height)
                        {
                            width = size;
                            height = original.Height * size / original.Width;
                        }
                        else
                        {
                            width = original.Width * size / original.Height;
                            height = size;
                        }

                        //    using (var resized = original
                        //           .Resize(new SKImageInfo(width, height), SKBitmapResizeMethod.Lanczos3))
                        //    {
                        //        if (resized == null) return;

                        //        using (var image = SKImage.FromBitmap(resized))
                        //        {
                        //            using (var output =
                        //                   File.OpenWrite(OutputPath(path, outputDirectory, SkiaSharpBitmap)))
                        //            {
                        //                image.Encode(SKImageEncodeFormat.Jpeg, Quality)
                        //                    .SaveTo(output);
                        //            }
                        //        }
                        //    }
                        //}
                    }
                }

                Console.WriteLine("Hello World!");
            }
        }
    }
}
