using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(IImagePicker))]
public interface IImagePicker
{
    Task<string> PickImage();
    Task<string> GetImagePathAsync(string fileName);
}