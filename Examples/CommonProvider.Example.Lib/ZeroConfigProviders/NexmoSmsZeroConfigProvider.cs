﻿using System.Text;

namespace CommonProvider.Example.Lib.ZeroConfigProviders
{
    public class NexmoSmsZeroConfigProvider : ISmsZeroConfigProvider
    {
        public string SendSms(Message message)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Message sent using NEXMO Zero Config Provider. See details below");
            stringBuilder.AppendLine(string.Format("Text: {0}", message.Text));
            stringBuilder.AppendLine(string.Format("From: {0}", message.Sender));
            stringBuilder.AppendLine(string.Format("To: {0}", message.PhoneNumbers));
            stringBuilder.AppendLine(string.Format("Endpoint: {0}", "http://www.nexmo.test/sendsms"));
            stringBuilder.AppendLine(string.Format("ApiKey: {0}", "54321"));

            return stringBuilder.ToString();
        }
    }
}
