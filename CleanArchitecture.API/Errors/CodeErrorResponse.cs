using System;
namespace CleanArchitecture.API.Errors
{
	public class CodeErrorResponse
	{
        public int StatusCode { get; set; }
        public string? Message { get; set; } = string.Empty;

        public CodeErrorResponse(int statusCode, string? message=null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageStatusCode(StatusCode);
        }

        private string GetDefaultMessageStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "The request has one or more errors",
                401 => "You do not have authorization for this resource",
                404 => "The requested resource was not found",
                500 => "Internal server error",
                _   => string.Empty
            };
        }
    }
}

