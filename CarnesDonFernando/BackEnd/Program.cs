using BackEnd.Middleware;
using Entities;
using Entities.Authentication;
using Entities.Utilities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);


#region ConnectionString

builder.Services.AddDbContext<proyectoCarnesDonFernandoContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
// Add services to the container.
string connString = builder.Configuration.GetConnectionString("DefaultConnection");
Util.ConnectionString = connString;

#endregion



// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Identity
builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options=>
 {
  /*   
   *   revisar si las ocupamos
   *   options.Password.RequiredLength = 5;
     options.Password.RequireNonAlphanumeric = true;
     options.Password.RequireDigit = true;
     options.Password.RequireLowercase = true;
     options.Password.RequireUppercase = true;
  */

}



    )
    .AddEntityFrameworkStores<proyectoCarnesDonFernandoContext>()
    .AddDefaultTokenProviders();
    
    ;

#endregion

#region  JWT

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;

})

    .AddJwtBearer(options =>
    {
        options.SaveToken = true;
        options.RequireHttpsMetadata = false;
        options.TokenValidationParameters = new TokenValidationParameters()
        {
            ValidateIssuer = false,
            ValidateAudience = false,
            ValidAudience = builder.Configuration["JWT:ValidAudience"],
            ValidIssuer = builder.Configuration["JWT:ValidIssuer"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Secret"]))
        };
    });


#endregion 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<ApiKeyMiddleware>();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
