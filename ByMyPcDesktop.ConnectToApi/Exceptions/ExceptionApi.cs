using System;
using System.Collections.Generic;
using System.Text;

namespace ByMyPcDesktop.ConnectToApi.Exceptions
{
    public class ExceptionApi : Exception
    {
        public ExceptionApi()
        {
        }

        public ExceptionApi(string? message) : base(message)
        {
        }
    }

    public class ApiGetException : ExceptionApi
    {
        public ApiGetException()
        {
        }

        public ApiGetException(string? message) : base(message)
        {
        }
    }
}
