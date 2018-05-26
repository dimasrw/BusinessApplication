using System.Configuration;

namespace BusinessApplication.Core
{
    public class BusinessService
    {        
        private IDataAccessComponent _dataAccessComponent;
        private IWebServiceProxy _webServiceProxy;
        private ILoggingComponent _loggingComponent;        

        public BusinessService(ILoggingComponent loggingComponent,
                                IWebServiceProxy webServiceProxy,
                                IDataAccessComponent dataAccessComponent)
        {
           _loggingComponent = loggingComponent;
            _webServiceProxy = webServiceProxy;
            _dataAccessComponent = dataAccessComponent;
        }
    }

}
