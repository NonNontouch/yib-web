﻿
using Microsoft.EntityFrameworkCore;

namespace my_new_app.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> contextOptions) : base(contextOptions)
        {

        }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<FoodModel> Food { get; set; }
        public DbSet<NotificationModel> Noti { get; set; }
    }
}
