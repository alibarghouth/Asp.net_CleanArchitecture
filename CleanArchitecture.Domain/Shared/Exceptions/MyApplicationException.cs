﻿using System.Net;

namespace CleanArchitecture.Domain.Shared.Exceptions;

public  class MyApplicationException : Exception
{
    public HttpStatusCode StatusCode { get; set; }
    public string Message { get; set; }
}