﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nlayer.Core.DTOs
{
    public abstract class BaseDto
    {
        public string Id { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
