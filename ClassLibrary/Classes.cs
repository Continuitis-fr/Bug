namespace ClassLibrary
{
    public class MyDtoItem : DtoItem
    {

    }

    public class MyRepo : IRepository<MyDtoItem> 
    {
        public Task CreateAsync(MyDtoItem element)
        {
            throw new NotImplementedException();
        }

        public Task EditAsync(MyDtoItem element)
        {
            throw new NotImplementedException();
        }

        public Task<MyDtoItem?> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MyDtoItem>?> GetElementsAsync()
        {
            throw new NotImplementedException();
        }
    }
}