using OnlineChat_Blazor.Models;

namespace OnlineChat_Blazor.Utilities;

public static class OpenDB
{

    public static void LoadDB(ref List<Message>? messages, ref List<User>? users)
    {

        try
        {
            using (var context = new MyDBContext())
            {
                messages = context.Messages.OrderDescending().Take(10).ToList();
                users = context.Users.ToList();
            }
        }
        catch (Exception ex)
        {
            messages = null;
            users = null;

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"\nChyba připojení k DB: {ex.Message} \n");
            Console.Beep();
        }
    }


    public static bool SaveDB(Message message)
    {
        try
        {
            using (var context = new MyDBContext())
            {
                context.Messages.Add(message);
                context.SaveChanges();
                return true;
            }
        }
        catch (Exception ex)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"\nChyba připojení k DB: {ex.Message} \n");
            Console.Beep();
            return false;
        }
    }






}

