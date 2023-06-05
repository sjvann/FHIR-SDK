using ResourceTypeBased;

namespace DataSource.Services {
    public interface IResourceService<T> where T : DomainResource  {
        public T GetContentById(int id);
        public T GetContentByName(string name);
        public IEnumerable<T> GetContentByQuery(IDictionary<string, object> query);
        public IEnumerable<T> GetContents(long pageIndex, int pageSize, out long totalItems);

        public int SaveContent(T source);
        public bool DeleteContent(int id);
        public int UpdateContent(int id, T source);

    }
}
