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
    
    public partial class ReaderCardFile
    {
        public int IdReaderCardFile { get; set; }
        public int IdReader { get; set; }
        public System.DateTime DateIssueBook { get; set; }
        public System.DateTime ReturnDate { get; set; }
        public int IdInstance { get; set; }
    
        public virtual Instance Instance { get; set; }
        public virtual Reader Reader { get; set; }
    }
}