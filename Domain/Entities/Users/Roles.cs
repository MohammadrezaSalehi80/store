﻿using Store.Domain.Entities.Common;
using System.Collections.Generic;

namespace Store.Domain.Entities.Users
{
    public class Roles : BaseEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public List<UserRoles> UserRoles { get; set; }
    }

}
