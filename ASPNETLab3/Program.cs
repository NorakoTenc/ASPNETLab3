using ASPNETLab3;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<ICalcService, CalcService>().AddTransient<ITimeOfDayService,TimeOfDayService>();

builder.Services.AddControllers();

var app = builder.Build();

app.MapGet("/", () => "(");

app.MapControllers();

app.Run();
