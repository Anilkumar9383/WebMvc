using FirstWebMvc.Models;

namespace first_mvc.Interface
{
    public interface FirstInterface
    {
        Task<List<SignUpData>> GetSignUpDatas();
        Task<SignUpData> GetSignUpData(int id);
        Task<SignUpData> AddSignUpData(SignUpData signUpData);
        Task<SignUpData> UpdateSignUpData(SignUpData signUpData);
        Task DeleteSignUpData(int id);
    }
}
