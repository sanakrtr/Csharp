using System;

class Program
{
    enum HttpStatusCode
    {
        BadRequest = 400,
        Unauthorized,
        PaymentRequired,
        Forbidden,
        NotFound,
        MethodNotAllowed,
        NotAcceptable,
        ProxyAuthenticationRequired,
        RequestTimeout,
        Conflict,
        Gone
    }

    static void Main()
    {
        Console.Write("Enter error code: ");
        int errorCode = Convert.ToInt32(Console.ReadLine());

        if (Enum.IsDefined(typeof(HttpStatusCode), errorCode))
        {
            string errorName = HttpStatusCode
                .GetName(typeof(HttpStatusCode), errorCode);
            Console.WriteLine(errorName);
        }
        else
        {
            Console.WriteLine($"Error code {errorCode} is invalid.");
        }
    }
}
