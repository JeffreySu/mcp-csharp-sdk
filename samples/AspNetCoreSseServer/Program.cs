using AspNetCoreSseServer.Tools;
using TestServerWithHosting.Tools;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<MyData>();

builder.Services.AddMcpServer()
    .WithTools<EchoTool>()
    .WithTools<SampleLlmTool>();

var app = builder.Build();

app.MapMcp();

app.Run();
