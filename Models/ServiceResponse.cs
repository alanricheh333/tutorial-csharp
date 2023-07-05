using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using start_csharp.Models;

namespace tutorial_csharp.Models
{
    public class ServiceResponse<T>
    {
        public T? Data { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; } = string.Empty;

        public static implicit operator ServiceResponse<T>(ServiceResponse<Company> v)
        {
            throw new NotImplementedException();
        }
    }
}