using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage.Json;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T data, string message):base(data, true, message)
        {
            
        }

        public SuccessDataResult(T data):base(data, true)
        {
            
        }

        public SuccessDataResult(string message) : base(default, false, message)
        {

        }

        public SuccessDataResult():base(default, true)
        {
            
        }
    }
}
