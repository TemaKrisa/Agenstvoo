//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NavigationDrawerPopUpMenu2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Otdel
    {
        public int IdOtdel { get; set; }
        public int ZadachaID { get; set; }
        public Nullable<int> SotrydnikiId { get; set; }
        public Nullable<int> menegerid { get; set; }
        public string naimenovanie { get; set; }
    
        public virtual Meneger Meneger { get; set; }
        public virtual Sotrydniki Sotrydniki { get; set; }
        public virtual Zadacha Zadacha { get; set; }
    }
}
