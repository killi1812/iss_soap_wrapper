using soap.UserInfoService;
using SoapCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSingleton<IUserInfo, UserInfo>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();
app.UseSoapEndpoint<IUserInfo>("/user-info", new SoapEncoderOptions());
app.Run();