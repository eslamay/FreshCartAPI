
using FreshCart.Data;
using FreshCart.Mappings;
using FreshCart.Repository;
using FreshCart.Repository.IRepository;
using FreshCart.Repository.SqlRepository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

namespace FreshCart
{
	public class Program
	{
		public static async Task Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			builder.Services.AddDbContext<ApplicationDbContext>(options =>
			options.UseSqlServer(builder.Configuration.GetConnectionString("constr")));

			builder.Services.AddIdentity<IdentityUser, IdentityRole>()
					  .AddEntityFrameworkStores<ApplicationDbContext>()
					   .AddDefaultTokenProviders();
			// Add services to the container.

			builder.Services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new OpenApiInfo { Title = "FreshCart API", Version = "v1" });

				c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
				{
					In = ParameterLocation.Header,
					Description = "Please enter JWT with Bearer into field",
					Name = "Authorization",
					Type = SecuritySchemeType.ApiKey,
					Scheme = "Bearer"
				});

				c.AddSecurityRequirement(new OpenApiSecurityRequirement
	{
		{
			new OpenApiSecurityScheme
			{
				Reference = new OpenApiReference
				{
					Type = ReferenceType.SecurityScheme,
					Id = "Bearer"
				}
			},
			new string[] { }
		}
	});
			});

			builder.Services.AddAutoMapper(typeof(AutoMapperProfiles));
			builder.Services.AddHttpContextAccessor();

			builder.Services.AddScoped<ICategoryRepository, SqlCategoryRepository>();
			builder.Services.AddScoped<ISubCategoryRepository, SqlSubCategoryRepository>();
			builder.Services.AddScoped<IBrandRepository, SqlBrandRepository>();
			builder.Services.AddScoped<IProductRepository, SqlProductRepository>();
			builder.Services.AddScoped<ITokenRepository, TokenRepository>();
			builder.Services.AddScoped<IWishlistRepository, WishlistRepository>();
			builder.Services.AddScoped<IAddressRepository, AddressRepository>();
			builder.Services.AddScoped<ICartRepository,CartRepository>();
			builder.Services.AddScoped<IOrderRepository, OrderRepository>();

			builder.Services.AddAuthentication(options => {
				options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
				options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
				options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
			})
		.AddJwtBearer(options =>
		{
			options.TokenValidationParameters = new TokenValidationParameters
			{
				ValidateIssuer = true,
				ValidateAudience = true,
				ValidateLifetime = true,
				ValidateIssuerSigningKey = true,
				ValidIssuer = builder.Configuration["Jwt:Issuer"],
				ValidAudience = builder.Configuration["Jwt:Audience"],
				IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
			};
			options.RequireHttpsMetadata = false; 
			options.SaveToken = true;
		});

			builder.Services.AddAuthorization();

			var app = builder.Build();
			// تهيئة الأدوار
			using (var scope = app.Services.CreateScope())
			{
				var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
				var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

				// إنشاء الأدوار إذا لم تكن موجودة
				string[] roleNames = { "User", "Admin" };
				foreach (var roleName in roleNames)
				{
					if (!await roleManager.RoleExistsAsync(roleName))
					{
						await roleManager.CreateAsync(new IdentityRole(roleName));
					}
				}

				// إنشاء Admin افتراضي إذا لم يكن موجودًا
				var adminEmail = "admin@admin.com";
				if (await userManager.FindByEmailAsync(adminEmail) == null)
				{
					var adminUser = new IdentityUser
					{
						UserName = "Admin",
						Email = adminEmail,
						PhoneNumber = "01000000000"
					};
					await userManager.CreateAsync(adminUser, "Admin123!");
					await userManager.AddToRoleAsync(adminUser, "Admin");
				}
			}
		


			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseStaticFiles();
			app.UseAuthentication();
			app.UseAuthorization();
			app.MapControllers();

			app.Run();
		}
	}
}	
