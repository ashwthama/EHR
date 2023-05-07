using EHR.Domain.Context;
using EHR.Repo.UserRepo;
using EHR.Service.UserServices;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<EhrContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("ConnStr")));

builder.Services.AddScoped<IUserRepository,UserRepository>();
builder.Services.AddTransient<IUserService,UserService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
