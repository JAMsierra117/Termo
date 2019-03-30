using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Termo.Generales.Data;

namespace Termo.Generales.API.Config
{
    public static class ServiceGeneralesCollectionExtensions
    {
        public static void AddDataAccessServicesVentas(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<GeneralesContext>(options =>
              options.UseSqlServer(connectionString, x => x.MigrationsHistoryTable(HistoryRepository.DefaultTableName, "Generales")));
        }
    }
}
