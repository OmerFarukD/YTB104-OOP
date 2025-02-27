namespace ExceptionHandlingExample;
public class UserData
{
    private List<User> _users = new List<User>()
    {
        new User{Email = "busedogan@gmail.com",Password="Password123"},
        new User{Email="omerdogan@gmail.com",Password="qubit123"}

    };


    public User? GetByEmail(string email)
    {
        return _users.FirstOrDefault(x=>x.Email == email);
    }

}
