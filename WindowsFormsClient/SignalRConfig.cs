using System;

namespace WinFormsClient
{

    public interface ISignalRConfig
    {
        string GetSignalRUri();
    }

    public class SignalRConfig : ISignalRConfig
    {
        public string GetSignalRUri()
        {
            return "";
        }
    }
}