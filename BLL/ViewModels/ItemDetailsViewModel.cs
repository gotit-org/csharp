﻿using GotIt.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GotIt.BLL.ViewModels
{
    public class ItemDetailsViewModel
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string Content { get; set; }
        public bool IsLost { get; set; }
        public EItemType Type { get; set; }
        public List<string> Images { get; set; }
        public PersonViewModel Person { get; set; }
        public ObjectViewModel Object { get; set; }
        public List<CommentViewModel> Comments { get; set; }
        public UserViewModel User { get; set; }
    }
}