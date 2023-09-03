﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Business.Results
{
    public class DataResult<T>: Result , IDataResult<T>
    {
        public DataResult(T data , bool success  ,  string message):base(success , message)
        {
            Data = data;
        }
        public DataResult(T data  , bool success) : base(success)
        {
            Data = data;
        }
        public T Data { get; }
    }
}
