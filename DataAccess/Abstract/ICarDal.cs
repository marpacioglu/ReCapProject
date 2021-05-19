using System;
using Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.DTOs;

namespace DataAccess.Abstract
{
     public interface ICarDal:IEntityRepository<Car>
    {
        List<CarDTO> GetCarDetails();

    }
}
