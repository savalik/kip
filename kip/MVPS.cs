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
    
    public partial class MVPS
    {
        public System.Guid Id { get; set; }
        public string number { get; set; }
        public string series { get; set; }
    
        public virtual MVPSRole MVPSRole { get; set; }
        public virtual MVPSType MVPSType { get; set; }
        public virtual EquipmentRule EquipmentRule { get; set; }
    }
}
