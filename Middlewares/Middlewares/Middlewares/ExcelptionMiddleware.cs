﻿using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http.Features;
using Middlewares.Models;
using System.Net;

namespace Middlewares.Middlewares;

/// <summary>
/// Convention Middleware
/// </summary>
public static class ExcelptionMiddleware
{
    public static void ConfigureBuildInException(this IApplicationBuilder app)
    {
        app.UseExceptionHandler(appError =>
        {
            appError.Run(async context =>
            {
                var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                var contextRequest = context.Features.Get<IHttpRequestFeature>();

                context.Response.ContentType = "application/json";

                if (contextRequest != null)
                {
                    var errorString = new ErrorResponseData
                    {
                        ErrorCode = (int)HttpStatusCode.InternalServerError,
                        ErrorMessage = contextFeature.Error.Message,
                        Path = contextRequest.Path
                    }.ToString();

                    await context.Response.WriteAsync(errorString);
                }
            });
        });

    }
}
