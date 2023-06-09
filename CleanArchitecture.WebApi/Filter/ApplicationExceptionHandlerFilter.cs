﻿using CleanArchitecture.Domain.Shared.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CleanArchitecture.WebApi.Filter;

public class ApplicationExceptionHandlerFilter : ExceptionFilterAttribute
{
    public override void OnException(ExceptionContext context)
    {
        if (context.Exception is MyApplicationException exception)
        {
            context.Result = new ObjectResult(new { exception.Message })
            {
                StatusCode = (int?)exception.StatusCode
            };

            context.ExceptionHandled = true;
        }
        else
        {
            base.OnException(context);
        }
    }
}