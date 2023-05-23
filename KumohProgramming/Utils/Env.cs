namespace KumohProgramming.Utils
{
    public class Env
    {
        public static bool IsDevelopment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development" ? true : false;
        public static bool IsProduction = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Production" ? true : false;

        /// <summary>
        /// 
        /// </summary>
        public static IConfiguration Get = new ConfigurationBuilder()
            .AddJsonFile(IsDevelopment ? "appsettings.Development.json" : "appsettings.json", optional: true)
            .Build();

    }
}
