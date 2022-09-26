using Microsoft.EntityFrameworkCore;
using SciMaterials.Data.Models;
using SciMaterials.Data.Models.Resources;
using File = SciMaterials.Data.Models.Resources.File;

namespace SciMaterials.Data.Contexts
{
    public class SciMaterialsDbContext : DbContext
    {
        public DbSet<File> Files { get; set; }
        public DbSet<HtmlText> HtmlTexts { get; set; }
        public DbSet<UrlAddress> UrlAddresses { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Partition> Partitions { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public SciMaterialsDbContext(DbContextOptions<SciMaterialsDbContext> options) : base(options)
        {
        }
    }
}
