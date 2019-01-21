﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HandsOnEFUsingDBFirst.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BooksDBEntities : DbContext
    {
        public BooksDBEntities()
            : base("name=BooksDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Book> Books { get; set; }
    
        public virtual ObjectResult<Book> uspGetBooks()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Book>("uspGetBooks");
        }
    
        public virtual ObjectResult<Book> uspGetBooks(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Book>("uspGetBooks", mergeOption);
        }
    
        public virtual ObjectResult<Book> uspGetBooksById(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Book>("uspGetBooksById", idParameter);
        }
    
        public virtual ObjectResult<Book> uspGetBooksById(Nullable<int> id, MergeOption mergeOption)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Book>("uspGetBooksById", mergeOption, idParameter);
        }
    }
}