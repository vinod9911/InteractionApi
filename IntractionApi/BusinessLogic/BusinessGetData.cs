using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IntractionApi.Models;
using IntractionApi.AppLogic;

namespace IntractionApi.BusinessLogic
{
    public class BusinessGetData
    {
        AppSetData appCode = null;  
        public BusinessGetData()
        {
            appCode = new AppSetData();
        }
        public IList<SampleData> GetData()
        {
           return appCode.SetData();
        }
    }
}