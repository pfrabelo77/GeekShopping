using AutoMapper;
using GeekShopping.ProductApi.Data.ValueObjects;
using GeekShopping.ProductApi.Model;
using GeekShopping.ProductApi.Model.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductApi.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly MySQLServerContext _context;
        private IMapper _mapper;

        public ProductRepository(MySQLServerContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }



        public async Task<IEnumerable<ProductVO>> FindAll()
        {
            var products = await _context.Products.ToListAsync() ;
            return _mapper.Map<IEnumerable<ProductVO>>(products);
        }

        public async Task<ProductVO> FindById(long id)
        {
            var product = await _context.Products.Where(p => p.Id == id).FirstOrDefaultAsync(); 
            return _mapper.Map<ProductVO>(product);
        }
        public async Task<ProductVO> Create(ProductVO productVO)
        {
            Product product = _mapper.Map<Product>(productVO);
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return productVO;
        }
        public async Task<ProductVO> Update(ProductVO productVO)
        {
            Product product = _mapper.Map<Product>(productVO);
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
            return productVO;
        }

        public async Task<bool> Delete(long id)
        {
            try
            {
                Product? product = await _context.Products.Where(p => p.Id == id).FirstOrDefaultAsync();
                if (product == null)
                {
                    return false;
                }
                else
                {
                    _context.Products.Remove(product);
                    await _context.SaveChangesAsync();
                    return true;

                }
            }
            catch (Exception)
            {

                return false;
            }

        }


    }
}
