﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace TechFest.Backbone.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class BooksEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new BooksEntities object using the connection string found in the 'BooksEntities' section of the application configuration file.
        /// </summary>
        public BooksEntities() : base("name=BooksEntities", "BooksEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new BooksEntities object.
        /// </summary>
        public BooksEntities(string connectionString) : base(connectionString, "BooksEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new BooksEntities object.
        /// </summary>
        public BooksEntities(EntityConnection connection) : base(connection, "BooksEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Book> Books
        {
            get
            {
                if ((_Books == null))
                {
                    _Books = base.CreateObjectSet<Book>("Books");
                }
                return _Books;
            }
        }
        private ObjectSet<Book> _Books;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Books EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToBooks(Book book)
        {
            base.AddObject("Books", book);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="BooksModel", Name="Book")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Book : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Book object.
        /// </summary>
        /// <param name="id">Initial value of the id property.</param>
        public static Book CreateBook(global::System.Int32 id)
        {
            Book book = new Book();
            book.id = id;
            return book;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int32 _id;
        partial void OnidChanging(global::System.Int32 value);
        partial void OnidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> PageCount
        {
            get
            {
                return _PageCount;
            }
            set
            {
                OnPageCountChanging(value);
                ReportPropertyChanging("PageCount");
                _PageCount = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("PageCount");
                OnPageCountChanged();
            }
        }
        private Nullable<global::System.Int32> _PageCount;
        partial void OnPageCountChanging(Nullable<global::System.Int32> value);
        partial void OnPageCountChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Likes
        {
            get
            {
                return _Likes;
            }
            set
            {
                OnLikesChanging(value);
                ReportPropertyChanging("Likes");
                _Likes = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Likes");
                OnLikesChanged();
            }
        }
        private Nullable<global::System.Int32> _Likes;
        partial void OnLikesChanging(Nullable<global::System.Int32> value);
        partial void OnLikesChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> PubDate
        {
            get
            {
                return _PubDate;
            }
            set
            {
                OnPubDateChanging(value);
                ReportPropertyChanging("PubDate");
                _PubDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("PubDate");
                OnPubDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _PubDate;
        partial void OnPubDateChanging(Nullable<global::System.DateTime> value);
        partial void OnPubDateChanged();

        #endregion
    
    }

    #endregion
    
}
