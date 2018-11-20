using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace VeeqoRepository.Models
{
    class VeeqoContextFactory : IDesignTimeDbContextFactory<VeeqoDevContext>
    {
        public VeeqoDevContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<VeeqoDevContext>();
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Veeqo-dev;Trusted_Connection=True;MultipleActiveResultSets=true");//Could maybe use deafult connection variable instead

            return new VeeqoDevContext(optionsBuilder.Options);
        }
    }
}


//api.veeqo.com/orders?page_size=25&page=1&status=awaiting_fulfillment&created_at_min=2018-03-01