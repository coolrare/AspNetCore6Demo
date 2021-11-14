using MinimalAsp6;

var app = WebApplication.Create(args);

app.MapGet("/", () => new Hello() { Id = 1, Name = "Will" });

app.Run();