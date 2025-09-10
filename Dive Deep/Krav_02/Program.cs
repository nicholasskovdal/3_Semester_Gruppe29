namespace Krav_02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews(); //1
            var app = builder.Build();

            app.UseRouting(); //2

            app.MapControllerRoute( //2
                name: "default",
                pattern: "{controller=home}/{action=Index}/{id?}"
                );
            app.UseStaticFiles(); //4

            app.Run();
        }
    }
}
