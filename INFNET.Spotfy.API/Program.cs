using IdentityServer4.AccessTokenValidation;
using INFNET.Spotfy.Application;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.RegisterApplication(builder.Configuration.GetConnectionString("SpotifyDB"));

builder.Services.AddAuthentication(IdentityServerAuthenticationDefaults.AuthenticationScheme)
    .AddIdentityServerAuthentication(opt =>
    {
        opt.Authority = "https://localhost:5001";
        opt.ApiName = "SpotifyAPI";
        opt.ApiSecret = "RafaelMeAprova";
    });

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("user-policy", p =>
    {
        p.RequireClaim("role", "spotify-user");
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
