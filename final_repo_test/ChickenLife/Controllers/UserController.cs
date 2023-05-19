using ChickenLife.Models.Account;
using ChickenLife.Models.OrderProduct;
using ClassLibrary;
using ClassLibrary.Models;
using ClassLibrary.ViewModels.WardrobeViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;

namespace ChickenLife.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ChickenDbContext _context;
        public UserController(ChickenDbContext context) 
        {
            _context = context;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserRegisterRequest request)
        {
            if (_context.Accounts.Any(u => u.A_Email== request.Email))
            {
                return BadRequest("使用者已退出");
            }
            CreatePasswordHash(request.Password,
                out byte[] passwordHash,
                out byte[] passwordSalt);
            var user = new UserAccount
            {
                A_Email = request.Email,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                VerifycationToken = CreateRandomToken()
            };
            _context.Accounts.Add(user);
            await _context.SaveChangesAsync();

            return Ok("使用者成功創建!");
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login(UserLoginRequest request)
        {
            var user = await _context.Accounts.FirstOrDefaultAsync(u => u.A_Email == request.Email);
            if (user == null)
            {
                return BadRequest("找不到使用者");

            }
            if (!VerifyPasswordHash(request.Password, user.PasswordHash, user.PasswordSalt))
            {
                return BadRequest("密碼錯誤");
            }
            if (user.VerifiedAt == null)
            {
                return BadRequest("未驗證");
            }
            return Ok($"歡迎回來,{user.A_Email}!:)");

        }
        [HttpPost("verify")]
        public async Task<IActionResult> Verify(string token)
        {
            var user = await _context.Accounts.FirstOrDefaultAsync(u => u.VerifycationToken == token);
            if (user == null)
            {
                return BadRequest("驗證碼錯誤");

            }
            user.VerifiedAt = DateTime.Now;
            //user.ResetTokenExpries = DateTime.Now.AddDays(1);
            await _context.SaveChangesAsync();


            return Ok("驗證成功");

        }
        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgotPassword(string email)
        {
            var user = await _context.Accounts.FirstOrDefaultAsync(u => u.A_Email == email);
            if (user == null)
            {
                return BadRequest("找不到使用者");

            }
            user.PasswordRestToken = CreateRandomToken();
            user.VerifiedAt = DateTime.Now.AddDays(1);
            await _context.SaveChangesAsync();


            return Ok("你需要重設你的密碼 ");

        }
        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword(ResetPasswordRequest request)
        {
            var user = await _context.Accounts.FirstOrDefaultAsync(u => u.PasswordRestToken == request.Token);
            if (user == null || user.ResetTokenExpries < DateTime.Now)
            {
                return BadRequest("無效驗證");

            }
            CreatePasswordHash(request.Password, out byte[] passwordHash, out byte[] passwordSalt);

            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;
            user.PasswordRestToken = null;
            user.ResetTokenExpries = null;

            await _context.SaveChangesAsync();

            return Ok("密碼成功reset");

        }










        //密碼散列
        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }


        }
        //把out去掉因為他不用輸出了 是接收 所以跟Creat不一樣
        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computeedHash = hmac.
                ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computeedHash.SequenceEqual(passwordHash);
            }

            
        }
        //創建令牌做驗證
        private string CreateRandomToken()
        {
            return Convert.ToHexString(RandomNumberGenerator.GetBytes(64));
        }




        // 變更點數
        // 需增加參數POST:改為api/Accounts/Update/{id}
        [HttpPost("Update/{id}")]
        public async Task<string> PutEmployees(int id, MemberDTO user)
        {
            if (id != user.A_ID)
            {
                // return BadRequest();
                return "讀取紀錄發生錯誤!";
            }
            UserAccount acc = await _context.Accounts.FindAsync(id);
            acc.A_Coin = user.A_Coin;

            _context.Entry(acc).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AccountsExists(id))
                {
                    // return NotFound();
                    return "修改員工紀錄發生錯誤!";
                }
                else
                {
                    throw;
                }
            }

            // return NoContent();  // 只會回傳成功或失敗
            return "修改紀錄成功";
        }
        private bool AccountsExists(int id)
        {
            return (_context.Accounts?.Any(e => e.A_ID == id)).GetValueOrDefault();
        }



        //[HttpGet("details/{id}")]//宇婕測試
        //public async Task<ActionResult<WardrobeViewModel>> GetDetails(int? id)
        //{
        //    //if (id != user.A_ID)
        //    //{
        //    //    return BadRequest("Invalid ID");
        //    //}

        //    var result = await _context.Accounts.Where(x => x.A_ID == id).Include(a => a.Orders).ThenInclude(o => o.OrderDetails).ThenInclude(od => od.Product).Select(x => new { 
        //        userid = x.A_ID, orderid = x.Orders.Select(o => o.O_ID).ToList(), 
        //        productid = x.Orders.Select(o => o.OrderDetails.Select(od => od.P_ID)).ToList(), 
        //        productname = x.Orders.Select(o => o.OrderDetails.Select(od => od.Product).Select(p => p.P_Name)).ToList(), 
        //        productimage = x.Orders.Select(o => o.OrderDetails.Select(od => od.Product).Select(p => p.P_Image)).ToList() 
        //    }).ToListAsync();
        //    WardrobeViewModel wardrobetemp = new WardrobeViewModel() {
        //        UserID = result.First().userid,
        //        OrderID = result.First().orderid,
        //        ProductID = result.First().productid,
        //        ProductName = result.First().productname,
        //        ProductImage = result.First().productimage,

        //    };
        //    if (wardrobetemp == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(wardrobetemp);
        //}


















        //[HttpGet]
        //public async Task<IActionResult> Details(int? id)
        //{
        //    var wardrobeViewModels = await _context.OrderDetails
        //                            .Include(od => od.Order)
        //                            .Include(od => od.Product)
        //                            .Select(od => new WardrobeViewModel
        //                            {
        //                                UserID = od.Order.A_ID,
        //                                OrderID = od.O_ID,
        //                                ProductID = od.P_ID,
        //                                ProductName = od.Product.P_Name,
        //                                ProductImage = od.Product.P_Image
        //                            })
        //.ToListAsync();

        //    if (wardrobeViewModels == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok("成功");
        //    //return View("~/Areas/OrderProduct/Views/Products/Details.cshtml", wardrobeViewModels);
        //}


        //[HttpGet("{userId}/products")]
        //public async Task<ActionResult<List<WardrobeViewModel>>> GetUserProducts(int userId)
        //{
        //    var userProducts = await GetUserProducts(userId);

        //    if (userProducts == null)
        //    {
        //        return NotFound();
        //    }

        //    return userProducts;
        //}

        //private async Task<List<WardrobeViewModel>> GetUserProducts(int userId)
        //{
        //    var userProducts = await _context.OrderDetails
        //        .Include(od => od.Order)
        //            .ThenInclude(o => o.Account)
        //        .Include(od => od.Product)
        //        .Where(od => od.Order.A_ID == userId)
        //        .Select(od => new WardrobeViewModel
        //        {
        //            UserID = od.Order.A_ID,
        //            OrderID = od.Order.O_ID,
        //            ProductID = od.Product.P_ID,
        //            ProductName = od.Product.P_Name,
        //            ProductImage = od.Product.P_Image
        //        })
        //        .ToListAsync();

        //    return userProducts;
        //}















    }
}
