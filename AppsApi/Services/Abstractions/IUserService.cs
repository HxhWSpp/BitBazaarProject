using AppsApi.DTOs.UserDTOs;

namespace AppsApi.Services.Abstractions
{
    public interface IUserService
    {
        Task<ICollection<UserResponseDTO>> GetUsers();
        Task<string> Login(UserLoginDTO user , IConfigurationSection _jwtSettings);
        Task<bool> Register(UserRegisterDTO userRegister);
        Task<UserDetailResponseDTO> GetUserDetail(string id);
        Task<UserResponseDTO> GetUserById(string id);



        Task<bool> AddAppToLibrary(string userId, int appId);     
        Task<bool> AddAppToWishlist(string userId, int appId);
        Task<bool> RemoveAppFromWishlist(string userId, int appId);

        Task<bool> UpdateUser(UserEditDTO user);

        Task<bool> AddFunds(string userId ,double ammount);

        Task<bool> DeleteUser(string userId);
    }
}
