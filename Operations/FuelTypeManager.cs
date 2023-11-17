using EntityFrameworkProject.Contexts;
using EntityFrameworkProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProject.Operations
{
    public class FuelTypeManager:BaseRepository<FuelType,MyDbContext>
    {
    }
}
