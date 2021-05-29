﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.Common
{
    public class ApiErrorResult<T> : ApiResult<T>
    {
        public string[] ValidationError { get; set; }
        public ApiErrorResult()
        {

        }
        public ApiErrorResult(string message)
        {
            IsSuccessed = false;
            Message = message;
        }

        public ApiErrorResult(string[] validationError)
        {
            IsSuccessed = false;
            ValidationError = validationError;
        }
    }
}