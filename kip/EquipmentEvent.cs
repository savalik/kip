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
    
    public partial class EquipmentEvent
    {
        public int Id { get; set; }
        public System.DateTime date { get; set; }
        public string description { get; set; }
        public short @event { get; set; }
    
        public virtual Equipment Equipment { get; set; }
    }
}
