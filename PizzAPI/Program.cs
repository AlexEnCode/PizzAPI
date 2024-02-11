using Microsoft.EntityFrameworkCore;
using PizzAPI.Data;
using PizzAPI.Repository;
using PizzeriaApi.Extension;

var builder = WebApplication.CreateBuilder(args);



builder.InjectDependancies();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.UseCors(options =>
{
    options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
});

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();