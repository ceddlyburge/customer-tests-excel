﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace CustomerTestsExcel
{
    public class EqualityAssertion<T> : BaseAssertion<T>
    {
        public EqualityAssertion(Expression<Func<T, object>> property, object expected)
            : base(property, expected) { }

        protected override AssertionOperator Operator => AssertionOperator.Equality;

        protected override bool InternalPassed(object actual)
        {
            if (actual == null)
            {
                return Expected == null || Expected.ToString().Equals("null", StringComparison.InvariantCultureIgnoreCase);
            }
            else
            {
                return actual.Equals(Expected);
            }
        }
    }
}
