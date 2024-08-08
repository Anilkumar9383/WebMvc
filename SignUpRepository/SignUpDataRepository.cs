using FirstWebMvc.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.Drawing.Printing;

namespace first_mvc.Interface
{
    public class SignUpDataRepository : FirstInterface
    {
        private readonly DataDbContext _context;

        public SignUpDataRepository(DataDbContext context)
        {
            this._context = context;
        }
        public async Task<SignUpData> AddSignUpData(SignUpData signUpData)
        {
            var result = await _context.SignUpData.AddAsync(signUpData);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<SignUpData> GetSignUpData(int id)
        {
            return await _context.SignUpData.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<SignUpData> UpdateSignUpData(SignUpData signUpData)

        {

            var result = await _context.SignUpData.FirstOrDefaultAsync(e => e.Id == signUpData.Id);
            if (result != null)
            {

                result.Fname = signUpData.Fname;

                result.Lname = signUpData.Lname;

                result.Email = signUpData.Email;

                result.Password = signUpData.Password;

                result.gender = signUpData.gender;

                result.mobile = signUpData.mobile;

                result.Address = signUpData.Address;

                _context.Entry(result).State = EntityState.Modified;

                await _context.SaveChangesAsync(); return result;
            }
            return null;
        }
        public async Task<List<SignUpData>> GetSignUpDatas()
        {
            return await _context.SignUpData.ToListAsync();
        }
        public async Task DeleteSignUpData(int id)
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
