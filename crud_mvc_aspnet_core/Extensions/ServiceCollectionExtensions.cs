using crud_mvc_aspnet_core.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud_mvc_aspnet_core.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection sc)
        {
            sc.AddScoped<IArticleService, ArticleService>();
            sc.AddScoped<ICategoryService, CategoryService>();

            return sc;
        }
    }
}
