using NetBlog.Back.Models.Domain;

namespace NetBlog.Back.Repositories.Interface
{
    public interface ICategoryRepository
    {
        
        Task<Category> CreateAsync(Category category);
    }
}
