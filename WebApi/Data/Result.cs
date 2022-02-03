using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Data
{
    public class Result<T>
        where T : class
    {
        private T dataObject;

        public Result(T _dataObject)
        {
            dataObject = _dataObject;
        }

        public string result()
        {
            return JsonConvert.SerializeObject(dataObject);
        }


    }
}
