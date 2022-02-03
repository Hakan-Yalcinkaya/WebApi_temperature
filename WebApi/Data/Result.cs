using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Model;

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
            if(dataObject != null)
            {
                return JsonConvert.SerializeObject(dataObject);
            }

            ErrorModel error = new ErrorModel();
            error.message = "Nesne örneği alınamadı!";
            error.success = false;
            return JsonConvert.SerializeObject(error);
        }


    }
}
