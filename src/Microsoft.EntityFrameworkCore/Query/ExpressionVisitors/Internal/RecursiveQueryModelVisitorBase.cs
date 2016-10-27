// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Linq.Expressions;
using Remotion.Linq.Clauses.Expressions;

namespace Microsoft.EntityFrameworkCore.Query.ExpressionVisitors.Internal
{
    /// <summary>
    ///     This API supports the Entity Framework Core infrastructure and is not intended to be used
    ///     directly from your code. This API may change or be removed in future releases.
    /// </summary>
    public abstract class RecursiveQueryModelVisitorBase : ExpressionTransformingQueryModelVisitor<ExpressionVisitorBase>
    {
        /// <summary>
        ///     This API supports the Entity Framework Core infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public RecursiveQueryModelVisitorBase()
            : base(new SubqueryModelVisitorBase())
        {
            ((SubqueryModelVisitorBase)TransformingVisitor).SetParentVisitor(this);
        }

        private class SubqueryModelVisitorBase : ExpressionVisitorBase
        {
            private RecursiveQueryModelVisitorBase _parentVisitor;

            /// <summary>
            ///     This API supports the Entity Framework Core infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            public void SetParentVisitor(RecursiveQueryModelVisitorBase parentVisitor)
            {
                _parentVisitor = parentVisitor;
            }

            /// <summary>
            ///     This API supports the Entity Framework Core infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            protected override Expression VisitSubQuery(SubQueryExpression expression)
            {
                _parentVisitor.VisitQueryModel(expression.QueryModel);

                return base.VisitSubQuery(expression);
            }
        }
    }
}
