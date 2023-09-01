using static System.Console;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

string realPath = @"C:\Users\admin\source\repos\Code\Chapter08\WorkingWithImages";

string imagesFolder = Path.Combine(
    realPath, "images");

IEnumerable<string> images =
    Directory.EnumerateFiles(imagesFolder);

foreach (string imagePath in images)
{
    string thumbnailPath = Path.Combine(realPath, "images",Path.GetFileNameWithoutExtension(imagePath) + "-섬네일" + Path.GetExtension(imagePath));
    using(Image image = Image.Load(imagePath))
    {
        image.Mutate(x => x.Resize(image.Width/10, image.Height/10));
        image.Mutate(x => x.Grayscale());
        image.Save(thumbnailPath);
    }
}

WriteLine("이미지 처리 완료! images 폴더를 확인하세요.");