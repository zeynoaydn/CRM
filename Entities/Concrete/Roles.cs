using Core.Entities;
using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Entities.Concrete
{
    public partial class Roles : IEntity
    {
        public Roles()
        {
            RolesPermissions = new HashSet<RolesPermissions>();
            UsersRoles = new HashSet<UsersRoles>();
        }

        public int Id { get; set; }
        public string RoleName { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<RolesPermissions> RolesPermissions { get; set; }
        public virtual ICollection<UsersRoles> UsersRoles { get; set; }
    }
}
