﻿using BTC.Core.Base.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTC.Model.Entity
{
    public class StaticPages : IEntity
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string Uri { get; set; }
        public string PartialViewName { get; set; }
    }
}
