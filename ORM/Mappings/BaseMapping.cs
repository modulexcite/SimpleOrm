﻿using System;
using System.Linq.Expressions;

namespace ORM.Mappings
{
    public class BaseMapping<TSource> where TSource : class
    {
        private readonly EntityMappingDefinition _entityMappingDefinition;

        public BaseMapping()
        {
            _entityMappingDefinition = new EntityMappingDefinition(typeof(TSource));
        }

        public EntityMappingDefinition EntityMappingDefinition
        {
            get
            {
                return _entityMappingDefinition;
            }
        }

        protected void MapClassToTable(string tableName)
        {
            _entityMappingDefinition.TableName = tableName;
        }

        protected ColumnDefinition MapProperty<TProperty>(Expression<Func<TSource, TProperty>> expression)
        {
            var propertyName = GetPropertyName(expression);
            var columnDefinition = new ColumnDefinition(propertyName, typeof(TProperty));
            _entityMappingDefinition.ColumnDefinitions.Add(columnDefinition);
            return columnDefinition;
        }

        private static string GetPropertyName<TProperty>(Expression<Func<TSource, TProperty>> expression)
        {
            if (expression.NodeType != ExpressionType.Lambda)
            {
                // TODO : throw the appropriate exception
            }

            var lambdaExpression = (LambdaExpression)expression;
            var lambdaBodyExpression = lambdaExpression.Body;
            if (lambdaBodyExpression.NodeType != ExpressionType.MemberAccess)
            {
                // TODO : throw the appropriate exception
            }

            var memberExpression = (MemberExpression)lambdaBodyExpression;
            var memberName = memberExpression.Member.Name;
            return memberName;

        }
    }
}
