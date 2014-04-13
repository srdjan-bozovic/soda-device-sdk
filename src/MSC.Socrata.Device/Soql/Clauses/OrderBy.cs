﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSC.Socrata.Device.Soql.Clauses
{
    public class OrderBy : ImmutableClause
    {
        public override string Build()
        {
            var expressions = Expressions;
            return expressions.Length == 0 ? "" : string.Format("order by {0}", string.Join(", ", Expression.BuildAll(expressions)));
        }
    }
}
