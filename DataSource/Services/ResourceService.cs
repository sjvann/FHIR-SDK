using ResourceTypeBased;
using Umbraco.Cms.Core.Services;

namespace DataSource.Services {
    public class ResourceService<T> : IResourceService<T> where T : DomainResource {

        private readonly IContentService _cs;
        public ResourceService(IContentService service) {
            _cs = service;

        }
        public bool DeleteContent(int id) {
            var content = _cs.GetById(id);
            bool flag = false;
            if(content != null) {
                var result = _cs.Delete(content);
                if(result.Success) {
                    flag = true;
                }
            }
            return flag;
        }

        public T GetContentById(int id) {
             throw new NotImplementedException();
        }

        public T GetContentByName(string name) {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetContentByQuery(IDictionary<string, object> query) {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetContents(long pageIndex, int pageSize, out long totalItems) {
            throw new NotImplementedException();
        }

        public int SaveContent(T source) {
            throw new NotImplementedException();
        }

        public int UpdateContent(int id, T source) {
            throw new NotImplementedException();
        }
    }
}
