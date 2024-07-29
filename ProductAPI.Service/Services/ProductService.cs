using AutoMapper;
using ProductAPI.Core.DTOs;
using ProductAPI.Core.Entities;
using ProductAPI.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPI.Service.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<bool> UpdateProductStockAsync(ProductUpdateDto productUpdateDto)
        {
            var product = await _productRepository.GetProductByIdAsync(productUpdateDto.Id);
            if (product == null) return false;

            return await _productRepository.UpdateProductStockAsync(productUpdateDto.Id, productUpdateDto.Stock);
        }
    }
}
