//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace kip
{
    using System;
    using System.Collections.Generic;
    
    public partial class ReplacingLog
    {
        public int Id { get; set; }
        public string description { get; set; }
        public System.DateTime date { get; set; }
        public bool onShedule { get; set; }
    
        public virtual MVPS MVPS { get; set; }
        public virtual Worker Worker { get; set; }
        public virtual Equipment Installed { get; set; }
        public virtual Equipment Removed { get; set; }
    }
}