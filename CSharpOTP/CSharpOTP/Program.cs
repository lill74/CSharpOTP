using System;
using OTP;

namespace CSharpOTP
{
    class Program
    {
        static void Main(string[] args)
        {
            otp sotp = new otp();
            sotp.time = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            sotp.key = "wow awesome";
            sotp.distance = 30000;

            Console.Write(sotp.generate());
        }

    }
}
