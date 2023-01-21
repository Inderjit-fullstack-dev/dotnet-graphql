using DotnetWithGraphQL.Infrastructure.GQL.Type;
using DotnetWithGraphQL.Models;
using DotnetWithGraphQL.Services.Contracts;
using GraphQL;
using GraphQL.Types;

namespace DotnetWithGraphQL.Infrastructure.GQL.Mutation
{
    public class ProductMutation : ObjectGraphType
    {
        public ProductMutation(IProductService productService)
        {
            Field<ProductType>("createProduct", 
                arguments: new QueryArguments 
                { 
                    new QueryArgument<ProductInputType>() { Name = "product" }
                },
                resolve: context => 
                {
                    return productService.AddProduct(context.GetArgument<Product>("product"));
                }    
            );

            Field<ProductType>("updateProduct",
                arguments: new QueryArguments
                {
                    new QueryArgument<LongGraphType>() { Name = "id" },
                    new QueryArgument<ProductInputType>() { Name = "product" }
                },
                resolve: context =>
                {
                    return productService.UpdateProduct(
                        context.GetArgument<long>("id"),
                        context.GetArgument<Product>("product"));
                }
            );

            Field<BooleanGraphType>("deleteProduct",
                arguments: new QueryArguments
                {
                    new QueryArgument<LongGraphType>() { Name = "id" },
                },
                resolve: context =>
                {
                     productService.DeleteProduct(
                        context.GetArgument<long>("id"));
                     return true;
                }
            );
        }
    }
}
