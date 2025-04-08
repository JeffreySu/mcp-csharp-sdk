using AspNetCoreSseServer.Tools;
using ModelContextProtocol.Server;
using System.ComponentModel;

namespace TestServerWithHosting.Tools;

[McpServerToolType]
public sealed class EchoTool(MyData myData)
{
    [McpServerTool, Description("Echoes the input back to the client.")]
    public string Echo(string message)
    {
        return myData.Prefix + message;
    }
}