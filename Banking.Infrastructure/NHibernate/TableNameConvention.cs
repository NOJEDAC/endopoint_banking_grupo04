﻿using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;

namespace Banking.Infrastructure.NHibernate
{
    public class TableNameConvention : IClassConvention
    {
        public void Apply(IClassInstance instance)
        {
            instance.Table(Util.GetTableName(instance.EntityType.Name));
        }
    }
}