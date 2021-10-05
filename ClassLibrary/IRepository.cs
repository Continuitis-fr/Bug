
namespace ClassLibrary
{
    public interface IRepository<TDtoItem> where TDtoItem : DtoItem
    {
        Task<IEnumerable<TDtoItem>?> GetElementsAsync();
        Task CreateAsync(TDtoItem element);
        Task<TDtoItem?> GetAsync(Guid id);
        Task EditAsync(TDtoItem element);
    }
}
