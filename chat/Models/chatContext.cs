using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace chat.Models
{
    public partial class chatContext : DbContext
    {
        public chatContext()
        {
        }

        public chatContext(DbContextOptions<chatContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Chat> Chat { get; set; }
        public virtual DbSet<Todo> Todo { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS01;Database=chat;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Chat>(entity =>
            {
                entity.ToTable("chat");

                entity.HasIndex(e => e.ChatId)
                    .HasName("IX_chat")
                    .IsUnique();

                entity.Property(e => e.ChatId).HasColumnName("chat_id");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Talk)
                    .IsRequired()
                    .HasColumnName("talk")
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Chat)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_chat_user");
            });

            modelBuilder.Entity<Todo>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.TodoId });

                entity.ToTable("todo");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.TodoId)
                    .HasColumnName("todo_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AddDate)
                    .HasColumnName("add_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('2000-01-01 00:00:00')");

                entity.Property(e => e.Complete).HasColumnName("complete");

                entity.Property(e => e.DeleteFlg).HasColumnName("delete_flg");

                entity.Property(e => e.TodoContent)
                    .IsRequired()
                    .HasColumnName("todo_content")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Todo)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_todo_user");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DeleteFlg).HasColumnName("delete_flg");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Pass)
                    .IsRequired()
                    .HasColumnName("pass")
                    .HasMaxLength(30);
            });
        }
    }
}
