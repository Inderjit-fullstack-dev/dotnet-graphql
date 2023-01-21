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

//builder.Services.AddControllers();
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDBContext>(x => 
    x.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

// GraphQL
builder.Services.AddSingleton<ProductType>();
builder.Services.AddSingleton<ProductQuery>();
builder.Services.AddSingleton<ProductMutation>();
builder.Services.AddSingleton<ISchema, ProductSchema>();

builder.Services.AddGraphQL(options => options.EnableMetrics = false).AddSystemTextJson();
// services
builder.Services.AddTransient<IProductService, ProductService>();

var app = builder.Build();

//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}
//app.UseAuthorization();
//app.MapControllers();

app.UseGraphiQl("/graphql");
app.UseGraphQL<ISchema>();

app.Run();
