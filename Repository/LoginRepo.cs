using FirstWebMvc.Interface;
using FirstWebMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstWebMvc.Repository
{
    public class LoginRepo : ILogin
    {
        private readonly DataDbContext _context;

        public LoginRepo(DataDbContext context)
        {
            this._context = context;
        }

        public async Task<LoginData> AddLoginData(LoginData loginData)
        {
            var result = await _context.LoginData.AddAsync(loginData);
            await _context.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<List<LoginData>> GetLoginDatas()
        {
            return await _context.LoginData.ToListAsync();
        }
        public async Task<LoginData> GetLoginData(int id)
        {
            return await _context.LoginData.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<LoginData> UpdateLoginData(LoginData loginData)
        {
            var result = await _context.LoginData.FirstOrDefaultAsync(e => e.Id == loginData.Id);
            if (result != null)
            {
                result.Username = loginData.Username;
                result.Password = loginData.Password;
                _context.Entry(result).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task DeleteLoginData(int id)
        {
            try
            {
                var result = await _context.LoginData.FindAsync(id);
                if (result != null)
                {
                    _context.LoginData.Remove(result);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}


