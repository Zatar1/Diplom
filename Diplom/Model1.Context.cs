﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Diplom
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DiplomEntities : DbContext
    {
        private static DiplomEntities _context;
        public DiplomEntities()
            : base("name=DiplomEntities")
        {
        }
        public static DiplomEntities GetContext()
        {

            if (_context == null)
                _context = new DiplomEntities();

            return _context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<SalesItems> SalesItems { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TClients> TClients { get; set; }
        public virtual DbSet<TItems> TItems { get; set; }
        public virtual DbSet<TItemsTypes> TItemsTypes { get; set; }
        public virtual DbSet<TMark> TMark { get; set; }
        public virtual DbSet<TOrders> TOrders { get; set; }
        public virtual DbSet<TOrdersTypes> TOrdersTypes { get; set; }
        public virtual DbSet<TSales> TSales { get; set; }
        public virtual DbSet<TUsers> TUsers { get; set; }
        public virtual DbSet<TUsersRoles> TUsersRoles { get; set; }
    }
}
