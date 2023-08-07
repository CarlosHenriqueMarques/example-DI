public class Program
{
    public static void Main(String[] args)
    {
        // Create instances of Logger and UserService
        Logger logger = new();
        UserService userService = new UserService(logger);

        // Register a user
        userService.RegisterUser("Carlos");

        //Output: [LOG] User 'Carlos' registered.

    }

    //Logger class that will be injected to client class
    public class Logger { 
        public void Log (string msg)
        {
            Console.WriteLine($"LOG {msg}");
        }
    }

    public class UserService
    {
        private Logger _logger;
        
        // Constructor injection: Logger is injected through the constructor
        public UserService(Logger logger) {
            _logger = logger;
        }
        public void RegisterUser (string username)
        {
            //Logic to regist user
            _logger.Log($"User {username} registered");
        }
    }
}