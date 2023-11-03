using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Search.Application.Interfaces;
using Search.Domain.Dto;
using Search.Domain.Entities;
using Search.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search.Persistance.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public readonly AppDbContext _context;
        public readonly IMapper _mapper;
        public ProductRepository(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<ProductDto> GetAllProducts()
        {
            var response = _context.Products.ToList();
            return _mapper.Map<List<ProductDto>>(response);
        }

        public List<ProductDto> SearchProduct(string keyword)
        {
                var products =  _context.Products
                    .Where(p => p.Name.Contains(keyword) || p.ProductDetails.Contains(keyword)
                    ||p.Location.Contains(keyword))
                    .ToList();

                return _mapper.Map<List<ProductDto>>(products);
        }
    }
}
