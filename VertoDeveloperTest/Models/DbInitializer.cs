namespace VertoDeveloperTest.Models
{
    public class DbInitializer
    {
        public static void Initialize(iOTAContext context)
        {

            context.Database.EnsureCreated();

        }
    }
}
