namespace GetPostDeletePutFunctions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");

            //Map function works with get,post,delete,put if you only use map then it work
            // automatically with get function

            //app.Map("/Home", ()=> "Hello World");
            app.UseRouting();


            //app.MapGet("/Home", () => "Hello World-get");
            //app.MapPost("/Home", () => "Hello World-post");
            //app.MapDelete("/Home", () => "Hello World-delete");
            //app.MapPut("/Home", () => "Hello World-put");

            app.UseEndpoints(endpoints => {
                endpoints.MapGet("/Home", async context =>
                {
                    await context.Response.WriteAsync("helloeworld-get");
                });
                endpoints.MapPost("/Home", async context =>
                {
                    await context.Response.WriteAsync("helloeworld-post");
                });
                endpoints.MapDelete("/Home", async context =>
                {
                    await context.Response.WriteAsync("helloeworld-delete");
                });
            });


            app.Run();
        }
    }
}
