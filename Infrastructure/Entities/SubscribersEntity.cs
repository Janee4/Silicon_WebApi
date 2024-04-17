﻿using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities
{
    public class SubscribersEntity
    {
        [Key]
       
        public string Email { get; set; } = null!; //säger att email adressen inte får vara null
    }
}
