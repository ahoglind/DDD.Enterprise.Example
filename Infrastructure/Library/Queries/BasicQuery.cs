﻿using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Library.Queries
{
    public class BasicQuery : ICommand
    {
        public ISet<String> Fields { get; set; }
        public IDictionary<String, Int32> Claims { get; set; }
    }
}