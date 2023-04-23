using BspAcademy.Core.Repositories;
using BspAcademy.Core.Services;
using BspAcademy.Core.UnitOfWorks;
using BspAcademy.Repository.Context;
using BspAcademy.Repository.Repositories;
using BspAcademy.Repository.UnitOfWorks;
using BspAcademy.Service.Mapping;
using BspAcademy.Service.Services;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddScoped<IUnitOfWorks, UnitOfWorks>();

// Repository Layer Dependency Injection
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IUserTestRepository), typeof(UserTestRepository));
builder.Services.AddScoped(typeof(ICityRepository), typeof(CityRepository));
builder.Services.AddScoped(typeof(ICategoryRepository), typeof(CategoryRepository));
builder.Services.AddScoped(typeof(IAidNoticeRepository), typeof(AidNoticeRepository));



// Service Layer Dependency Injection
//builder.Services.AddScoped(typeof(IGenericService<TEntity, TDto>), typeof(GenericService<>));
builder.Services.AddScoped(typeof(IUserTestService), typeof(UserTestService));
builder.Services.AddScoped(typeof(ICityService), typeof(CityService));
builder.Services.AddScoped(typeof(ICategoryService), typeof(CategoryService));
builder.Services.AddScoped(typeof(IAidNoticeService), typeof(AidNoticeService));

builder.Services.AddAutoMapper(typeof(MapProfile));


builder.Services.AddDbContext<AppDbContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlServerDbContext"), option =>
    {
        option.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);
    });
});



builder.Services.AddControllers().AddNewtonsoftJson(opt=>opt.SerializerSettings.ReferenceLoopHandling =Newtonsoft.Json.ReferenceLoopHandling.Ignore);
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
