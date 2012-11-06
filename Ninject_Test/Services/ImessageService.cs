using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ninject_Test.Services
{
    public interface IMessageService
    {
        string GetMessage();
        string MonkeyMessage();
    }
}