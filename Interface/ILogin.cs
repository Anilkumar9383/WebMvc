using FirstWebMvc.Models;

namespace FirstWebMvc.Interface
{
    public interface ILogin
    {
        Task<LoginData> AddLoginData(LoginData loginData);
        Task<List<LoginData>> GetLoginDatas();
        Task<LoginData> GetLoginData(int id);
        Task<LoginData> UpdateLoginData(LoginData loginData);
        Task DeleteLoginData(int id);
    }
}
