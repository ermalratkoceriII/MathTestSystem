using MathTest.Application.Interfaces;
using MathTest.Application.Services;
using MathTest.Engine.Interfaces;
using MathTest.Engine.Services;
using MathTest.Infrastructure.Xml;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IEvaluator, Evaluator>();
builder.Services.AddScoped<IGradingService, GradingService>();
builder.Services.AddScoped<IExamProcessor, ExamProcessor>();
builder.Services.AddScoped<IXmlExamParser, XmlExamParser>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();