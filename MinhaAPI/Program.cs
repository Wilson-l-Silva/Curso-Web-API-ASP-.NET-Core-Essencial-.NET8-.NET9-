var builder = WebApplication.CreateBuilder(args);

// Add services to the container. --> Seria o ConfigureServices() da classe startup

builder.Services.AddControllers(); 
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();  // -- > Seria o Configure() da classe startup
// constroi o aplicatico conforme as configurações de serviços a cima

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
