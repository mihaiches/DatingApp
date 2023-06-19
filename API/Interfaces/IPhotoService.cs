using CloudinaryDotNet.Actions;
using System.Threading.Tasks;

namespace API.Interfaces
{
    public interface IPhotoService
    {
        Task<ImageUploadResult> AddPhotoAsync (IFormFile file);
        Task<DeletionResult> DeletePhotoAsync (string publicId);
    }
}