using System;

namespace TwilioSMSSender
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find your Account Sid and Token at twilio.com/console
            // DANGER! This is insecure. See http://twil.io/secure
            const string accountSid = "ACa4839667217d26d54c79b316d1886254";
            const string authToken = "593b6c0aa345dd7bd55bb6b1b18f99ea";
            //13232180736
            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: "CerviTech Test Message from Micheal and Toyosi.",
                from: new Twilio.Types.PhoneNumber("+13232180736"),
                to: new Twilio.Types.PhoneNumber("+2348172535234")
            );

            Console.WriteLine(message.Sid);
        }
    }
}
