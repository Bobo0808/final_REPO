using ChickenLife.Models.OrderProduct.DTO;
using ClassLibrary;
using ClassLibrary.Enum;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChickenLife.Controllers
{
    [EnableCors("AllowAny")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ChickenDbContext _context;

        public ProductsController(ChickenDbContext context)
        {
            _context = context;
        }

        //// GET: api/Products
        [HttpGet]
        public IEnumerable<ProductDTO> GetProducts()
        {
            //return await _context.Products.ToListAsync();
            return _context.Products.Where(product => product.P_Discontinuted == false).Select(product => new ProductDTO
            {
                P_ID = product.P_ID,
                P_Name = product.P_Name,
                P_Price = product.P_Price,
                P_Image = product.P_Image,
                P_Describe = product.P_Describe,
                P_Instock = product.P_Instock,
                P_Date = product.P_Date,
                P_Discount = product.P_Discount,
            });
        }

        ////// GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ProductDTO> GetProducts(int id)
        {
            var product = await _context.Products.FindAsync(id);

            //return products;
            return new ProductDTO
            {
                P_ID = product.P_ID,
                P_Name = product.P_Name,
                //P_ProductType = product.P_ProductType,
                P_Price = product.P_Price,
                P_Image = product.P_Image,
                P_Describe = product.P_Describe,
                P_Instock = product.P_Instock,
                P_Date = product.P_Date,
                P_Discount = product.P_Discount,
            };
        }
        ////// 篩選
        ////// POST: api/Employees (會發現動詞與下面的POST相同而衝突)
        ////// 需增加參數POST:改為api/Employees/Filter 而url不同區別
        [HttpPost("Filter")]
        public async Task<IEnumerable<ProductDTO>> FilterEmployee([FromBody] ProductDTO productDTO)
        {
            // return null;
            return _context.Products
                .Where(product => product.P_ID == productDTO.P_ID ||
                              product.P_Name.Contains(productDTO.P_Name) ||
                              product.P_Price.ToString().Contains(productDTO.P_Price.ToString()) ||
                              product.P_ProductType.ToString().Contains(productDTO.P_ProductType.ToString()))
                .Select(product => new ProductDTO
                {
                    P_ID = product.P_ID,
                    P_Name = product.P_Name,
                    //P_ProductType = product.P_ProductType,
                    P_Price = product.P_Price,
                    P_Image = product.P_Image,
                    P_Describe = product.P_Describe,
                    P_Instock = product.P_Instock,
                    P_Date = product.P_Date,
                    P_Discount = product.P_Discount,
                });
        }

        ////// 篩選
        ////// POST: api/Employees (會發現動詞與下面的POST相同而衝突)
        ////// 需增加參數POST:改為api/Employees/Filter 而url不同區別
        [HttpPost("FilterProductType")]
        public async Task<IEnumerable<ProductDTO>> FilterProductType([FromBody] ProductDTO productDTO)
        {
            var productType = (ProductType)productDTO.P_ProductType;

            return _context.Products
                .Where(product => ((product.P_ProductType == productType) && (product.P_Discontinuted == false)))
                .Select(product => new ProductDTO
                {
                    P_ID = product.P_ID,
                    P_Name = product.P_Name,
                    P_ProductType = (int)product.P_ProductType,
                    P_Price = product.P_Price,
                    P_Image = product.P_Image,
                    P_Describe = product.P_Describe,
                    P_Instock = product.P_Instock,
                    P_Date = product.P_Date,
                    P_Discount = product.P_Discount,
                });
        }




        private bool ProductsExists(int id)
        {
            return (_context.Products?.Any(e => e.P_ID == id)).GetValueOrDefault();
        }




        //public string GetProductTypeDescription(int productTypeValue)
        //{
        //    try
        //    {
        //        ProductType productTypeEnum = (ProductType)productTypeValue;
        //        return productTypeEnum.ToString();
        //    }
        //    catch (Exception ex)
        //    {
        //        return ex.Message;
        //    }

        //}
    }
}
