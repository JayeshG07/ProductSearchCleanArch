using Search.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search.Application.Interfaces
{
    public interface IProductRepository
    {
        public List<ProductDto> GetAllProducts();
        public List<ProductDto> SearchProduct(string keyword);
    }
}
