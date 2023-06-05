using DataSource.Models;
using ResourceTypeServices.R5;

namespace DataSource.Services {
    public class OperationOutcomeService {
        private readonly ResponseResource _response;
        public OperationOutcomeService(ResponseResource response) {
            _response = response;
        }
       
    }
}
