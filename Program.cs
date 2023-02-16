using Api;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ICodesService, CodesService>();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<Program>());

var app = builder.Build();

app.MapGet("/get_code", async (IMediator mediator) => 
{ 
    var code = await mediator.Send(new GetCodeRequest());
    return Results.Ok(code);
});

app.MapGet("/", async (IMediator mediator) => 
{ 
    var codes = await mediator.Send(new AllCodesRequest());
    return Results.Ok(codes);
});

app.Run();