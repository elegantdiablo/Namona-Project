using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Namona.Persistence
{
    public class NamonaDbContext : DbContext
    {
        public DbSet<Users> users { get; set; }
        public DbSet<Clothes> clothes { get; set; }
        public DbSet<Cart> cart { get; set; }
        public DbSet<Orders> orders { get; set; }
        public NamonaDbContext(DbContextOptions<NamonaDbContext> options) : base(options) { }
    }

    public class Clothes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClothingId { get; set; }
        public string Collection { get; set; }
        public string Category { get; set; }
        public string Gender { get; set; }
        public int Stock { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
    }

    public class Cart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CartId { get; set; }
        public int ClothingId { get; set; }
        public int UserId { get; set; }
        [Required]
        public int Amount { get; set; }
        public int PriceSum { get; set; }
    }

    public class Users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        public string Role { get; set; }
    }

    public class Orders
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        public int CartId { get; set; }
        public DateTime TimeSTamp { get; set; }
        [Required]
        public string Address { get; set; }
    }

    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }

    public class Gender
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GenderId { get; set; }
        public string GenderType { get; set; }
    }
}