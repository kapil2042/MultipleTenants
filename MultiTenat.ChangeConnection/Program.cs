using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using MultiTenant.ChangeConnection.Data;
using MultiTenant.ChangeConnection.Repository;
using MultiTenat.ChangeConnection.Services;
using MultiTenat.ChangeConnection.Utils;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpContextAccessor();

builder.Services.AddDbContext<ProductDbContext>();

builder.Services.AddScoped(typeof(IGenericRepo<>), typeof(GenericRepo<>));
builder.Services.AddScoped<ITenantService, TenantService>();
builder.Services.Configure<TenantSettings>(
    builder.Configuration.GetSection(nameof(TenantSettings)));

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
