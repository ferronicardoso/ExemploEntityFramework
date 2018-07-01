using System;
using ExemploEntityFramework.DAL.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using System.Linq;
using ExemploEntityFramework.Model.Entities;

namespace ExemploEntityFramework.DAL.Tests
{
    [TestClass]
    public class PostRepositoryTest
    {
        private ApplicationContext applicationContext;
        private StatusRepository statusRepository;
        private AuthorRepository authorRepository;
        private PostRepository postRepository;

        [TestInitialize]
        public void Initialize()
        {
            this.applicationContext = new ApplicationContext();
            this.statusRepository = new StatusRepository(this.applicationContext);
            this.authorRepository = new AuthorRepository(this.applicationContext);
            this.postRepository = new PostRepository(this.applicationContext);

            var status = new Status
            {
                Name = "Published"
            };

            var existStatus = this.statusRepository.Exists(x => x.Name == "Published");
            if (!existStatus)
                this.statusRepository.Add(status);

            var author = new Author
            {
                Name = "Raphael A. F. Cardoso",
            };

            var existAuthor = this.authorRepository.Exists(x => x.Name == "Raphael A. F. Cardoso");
            if (!existAuthor)
                this.authorRepository.Add(author);

            var post = new Post
            {
                Title = "Lorem ipsum dolor sit amet",
                Content = "Vestibulum consequat venenatis efficitur. Phasellus arcu dolor, venenatis sed augue sit amet, consectetur finibus neque. Donec egestas viverra nibh ut porta. Nulla placerat metus at massa iaculis volutpat. Donec vitae pulvinar velit, nec ullamcorper tortor. Donec convallis id lectus sed luctus. Integer et egestas purus, sit amet ultricies ex.",
                Description = "Phasellus arcu dolor, venenatis sed augue sit amet, consectetur finibus neque",
                Author = author,
                DateTimePublish = DateTime.Now,
                Status = status
            };

            var comment = new Comment
            {
                UserName = "João Carlos Silva",
                UserEmail = "jcsilva@server.com",
                DateTimePublish = DateTime.Now,
                Content = "Donec convallis id lectus sed luctus. Integer et egestas purus, sit amet ultricies ex"
            };

            post.Comments.Add(comment);

            this.postRepository.Add(post);
            this.applicationContext.SaveChanges();
        }

        [TestMethod]
        public void Lista_Todas_As_Postagens()
        {
            var posts = this.postRepository.GetAll()
                                           .Include(t => t.Author)
                                           .Include(t => t.Status)
                                           .Include(t => t.Comments)
                                           .Where(t => t.Status.Name == "Published")
                                           .ToList();
            Assert.IsNotNull(posts);
        }

        [TestCleanup]
        public void Cleanup()
        {
            var statusList = this.statusRepository.GetAll().ToList();
            var authorList = this.authorRepository.GetAll().ToList();
            var postList = this.postRepository.GetAll().ToList();

            statusList.ForEach(status =>
            {
                this.statusRepository.Delete(status);
            });
            authorList.ForEach(author =>
            {
                this.authorRepository.Delete(author);
            });
            postList.ForEach(post =>
            {
                this.postRepository.Delete(post);
            });
            this.applicationContext.SaveChanges();
        }
    }
}
