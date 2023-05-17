using ChickenLife.Models.Account;
using ClassLibrary;
using ClassLibrary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

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
    }
}
