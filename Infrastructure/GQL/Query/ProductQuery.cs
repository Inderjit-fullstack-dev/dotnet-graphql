﻿using DotnetWithGraphQL.Infrastructure.GQL.Type;
using DotnetWithGraphQL.Services.Contracts;
using GraphQL;
using GraphQL.Types;

namespace DotnetWithGraphQL.Infrastructure.GQL.Query
{
    public class ProductQuery : ObjectGraphType
    {
        public ProductQuery(IProductService productService)
        {
            Field<ListGraphType<ProductType>>("products", resolve: context => {
                return productService.GetAllProducts();
            });

            Field<ProductType>("product", 
                arguments: new QueryArguments( new QueryArgument<IntGraphType>{ Name = "id" }),
                resolve: context => {
                return productService.GetProductById(context.GetArgument<int>("id"));
            });
        }
    }
}
