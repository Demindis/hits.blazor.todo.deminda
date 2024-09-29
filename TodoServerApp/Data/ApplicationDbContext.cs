using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TodoServerApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public virtual DbSet<TaskItem> TaskItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<TaskItem>().HasData([
				new TaskItem { Id = 1, Title = "������ 1", Description = "�������� ������ 1", CreatedDate = DateTime.Now },
				new TaskItem { Id = 2, Title = "������ 2", Description = "�������� ������ 2", CreatedDate = DateTime.Now },
				new TaskItem { Id = 3, Title = "������ 3", Description = "�������� ������ 3", CreatedDate= DateTime.Now },
				new TaskItem { Id = 4, Title = "������ 4", Description = "�������� ������ 4", CreatedDate= DateTime.Now },]);
		}
	}
}
