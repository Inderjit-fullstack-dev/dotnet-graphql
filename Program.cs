using DotnetWithGraphQL.Data;
using DotnetWithGraphQL.Infrastructure.GQL.Mutation;
using DotnetWithGraphQL.Infrastructure.GQL.Query;
using DotnetWithGraphQL.Infrastructure.GQL.Schema;
using DotnetWithGraphQL.Infrastructure.GQL.Type;
using DotnetWithGraphQL.Services.Contracts;
using DotnetWithGraphQL.Services.Implementations;
using GraphiQl;
using GraphQL.Server;
using GraphQL.Types;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDBContext>(x => 
    x.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

// services
builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.AddTransient<IMenuService, MenuService>();
builder.Services.AddTransient<ISubmenuService, SubmenuService>();
builder.Services.AddTransient<IReservationService, ReservationService>();

// GraphQL
builder.Services.AddScoped<ProductType>();
builder.Services.AddScoped<ProductQuery>();
//builder.Services.AddScoped<ProductMutation>();

// Menu Service Injection
builder.Services.AddScoped<MenuType>();
builder.Services.AddScoped<MenuQuery>();
//builder.Services.AddScoped<MenuMutation>();

builder.Services.AddScoped<RootQuery>();
builder.Services.AddScoped<ISchema, RootSchema>();

builder.Services.AddGraphQL(options => options.EnableMetrics = false).AddSystemTextJson();

var app = builder.Build();

app.UseGraphiQl("/graphql");
app.UseGraphQL<ISchema>();

app.Run();
