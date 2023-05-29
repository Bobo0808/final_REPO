using ClassLibrary;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
// 定義CORS Policy
string MyAllowSpecificOrigins = "AllowAny";
builder.Services.AddCors(options =>
{
    options.AddPolicy(
            name: MyAllowSpecificOrigins,
            policy => policy.WithOrigins("*")
                            .WithHeaders("*")
                            .WithMethods("*"));   // localhost:7029不接斜線(全接就打*)
});

builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ChickenDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), x => x.MigrationsAssembly("ChickenLife"));
});
var app = builder.Build();

// <snippet_UseWebSockets>
var webSocketOptions = new WebSocketOptions
{
    KeepAliveInterval = TimeSpan.FromMinutes(2)
};

app.UseWebSockets(webSocketOptions);
// </snippet_UseWebSockets>

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}
// 套用CORS策略(這邊是影響所有的controllers)
// app.UseCors(MyAllowSpecificOrigins);
// 套用但須各個controllers去指定策略
app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
