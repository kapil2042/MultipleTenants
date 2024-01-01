using Microsoft.EntityFrameworkCore;
using MultipleTenants.Data;
using MultipleTenants.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpContextAccessor();

builder.Services.AddDbContext<UserDbContext>(option => option.UseSqlServer(
                builder.Configuration.GetConnectionString("UserConnection")
            ));
builder.Services.AddDbContext<ProductDbContext>(option => option.UseSqlServer(
                builder.Configuration.GetConnectionString("ProductConnection")
            ));

builder.Services.AddScoped(typeof(IUserGenericRepo<>), typeof(UserGenericRepo<>));
builder.Services.AddScoped(typeof(IProductGenericRepo<>), typeof(ProductGenericRepo<>));


var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
