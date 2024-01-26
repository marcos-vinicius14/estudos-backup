using Blog.DataContext;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog;

class Program
{
    static async Task Main(string[] args)
    {
         var user = new User 
             {
                  Name = "Marcos",
                  Slug = "marcosvinicius",
                  Email = "marcosvinicius@gmail",
                  Bio = "Desenvolvedor .NET",
                  Image = "https: foto",
                  PasswordHash = "123456",
                  Github = "MarcosVinicius"
            };
        using var context = new BlogDataContext();

        var post = context.Posts
            .Include(x => x.Author)
                .ThenInclude(x => x.Roles)
            .Include(x => x.Category);

        foreach (var tag in post)

        // var posts = await GetPosts(context);

        

        // var post = context.Posts.ToListAsync();
        // var tag = context.Tags.ToListAsync();

        // Console.WriteLine("Teste");

        // context.Users.Add(user);
        // context.SaveChanges();

        // context.Posts.AsNoTracking();

        // using (var context = new BlogDataContext())
        {
            
            // var posts = context
            //             .Posts
            //             .AsNoTracking()
            //             .Include(x => x.Author)
            //             .Include(x => x.Category)
            //             .OrderByDescending(x => x.LastUpdateDate)
            //             .ToList();

            // foreach (var post in posts)
            //     Console.WriteLine($"{ post.Title } escrito por { post.Author.Name } em { post.Category.Name }");

            // var user = new User 
            // {
            //     Name = "Marcos",
            //     Slug = "marcosvinicius",
            //     Email = "marcosvinicius@gmail",
            //     Bio = "Desenvolvedor .NET",
            //     Image = "https: foto",
            //     PasswordHash = "123456"
            // };

            // var category = new Category
            // {
            //     Name = "Backend",
            //     Slug = "backend"
            // };

            // var post = new Post
            // {
            //     Author = user,
            //     Category = category,
            //     Body = "<p>Hello world <p>",
            //     Slug = "comecando-com-ef-core",
            //     Summary = "Neste artigo vamos aprender sobre EF Core",
            //     Title = "Começando com EF Core",
            //     CreateDate = DateTime.Now,
            //     LastUpdateDate = DateTime.Now
            // };
            
            // context.Posts.Add(post);
            // context.SaveChanges();

            // var post = context
            //             .Posts
            //             .Include(x => x.Author)
            //             .Include(x => x.Category)
            //             .OrderByDescending(x => x.LastUpdateDate)
            //             .FirstOrDefault();

            // post.Author.Name = "Marcos Vinicius";

            // context.Posts.Update(post);
            // context.SaveChanges();

            // var user = context.Users.FirstOrDefault();
            // var post = new Post 
            // {
            //     Author = user,
            //     Body = "Post de teste",
            //     Category = new Category
            //     {
            //         Name = "Backend",
            //         Slug = "backend-2"
            //     },
            //     CreateDate = DateTime.Now,
            //     LastUpdateDate = DateTime.Now,
            //     Slug = "Artigo de teste",
            //     Summary = "Neste artigo vamos conferir",
            //     Title = "Relacionamentos EF Core"
            // };

            // context.Posts.Add(post);
            // context.SaveChanges();

        }
    }

    // public static async Task<List<Post>> GetPosts(BlogDataContext context)
    //     => await context.Posts.ToListAsync();

    public static List<Post> GetPosts(BlogDataContext context, int skip = 0, int take = 25)
    {
        var posts = context
            .Posts
            .AsNoTracking()
            .Skip(skip)
            .Take(take)
            .ToList();
        return posts;
    }


}
