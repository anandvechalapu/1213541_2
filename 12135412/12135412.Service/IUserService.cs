namespace 12135412.Service
{
    using 12135412.DTO;

    public interface IUserService
    {
        UserDTO GetUser(int id);
        void UpdateUser(UserDTO user);
    }
}