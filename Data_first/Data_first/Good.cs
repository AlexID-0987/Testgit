//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data_first
{
    using System;
    using System.Collections.Generic;
    
    public partial class Good
    {
        public int GoodId { get; set; }
        public string GoodName { get; set; }
        public Nullable<int> ManufacturerId { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public decimal Price { get; set; }
        public decimal GoodCount { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
    }
}
