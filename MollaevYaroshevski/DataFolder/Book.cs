//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MollaevYaroshevski.DataFolder
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            this.BookAndAuthor = new HashSet<BookAndAuthor>();
            this.Instance = new HashSet<Instance>();
        }
    
        public int IdBook { get; set; }
        public string NameBook { get; set; }
        public int IdCity { get; set; }
        public int IdPublisherHouse { get; set; }
        public int YearOfPublication { get; set; }
        public int NumberOfPages { get; set; }
        public decimal TheCostOfTheBook { get; set; }
        public Nullable<int> NumberCopiesBook { get; set; }
    
        public virtual City City { get; set; }
        public virtual PublisherHouse PublisherHouse { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookAndAuthor> BookAndAuthor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Instance> Instance { get; set; }
    }
}
