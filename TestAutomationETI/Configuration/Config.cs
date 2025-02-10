using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationETI.Helper
{
    public record Endpoints(string GetUsers, string CreateUser);
    public record Config(string Url, Endpoints Endpoints, UIConfig UIConfig);
    public record UIConfig(string Url);

}
