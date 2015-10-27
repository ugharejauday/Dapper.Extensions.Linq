﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper.Extensions.Linq.Mapper;
using Dapper.Extensions.Linq.Test.Entities;

namespace DapperExtensions.Test.Maps
{
    public class ExternallyMappedMap
    {
        public class ExternallyMappedMapper : ClassMapper<ExternallyMapped>
        {
            public ExternallyMappedMapper()
            {
                Table("External");
                Map(x => x.Id).Column("ExternalId");
                AutoMap();
            }
        } 
    }
}