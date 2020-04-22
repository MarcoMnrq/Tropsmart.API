using System.Collections.Generic;
using TropsmartAPI.Domain.Models;

namespace TropsmartAPI.Domain.Services
{
    public interface ICarrierService
    {
        public List<Carrier> GetCarriers();
        public Carrier AddCarrier(Carrier carrier);
        public Carrier UpdateCarrier(int id, Carrier carrier);
        public int DeleteCarrier(int id);
    }
}
