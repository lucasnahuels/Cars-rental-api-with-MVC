﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrabajoCGB.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BDDAlquilerAutosEntities : DbContext
    {
        public BDDAlquilerAutosEntities()
            : base("name=BDDAlquilerAutosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<alquiler> alquiler { get; set; }
        public DbSet<ciudad> ciudad { get; set; }
        public DbSet<coche> coche { get; set; }
        public DbSet<conductor> conductor { get; set; }
        public DbSet<oficina> oficina { get; set; }
    }
}
