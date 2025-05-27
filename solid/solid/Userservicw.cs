public class Userservice
{

    public void Register(User user)
    {
        Emailsender em = new Emailsender();
        em.SendEmail(user.Email, "Welcome to our email");
    }
}