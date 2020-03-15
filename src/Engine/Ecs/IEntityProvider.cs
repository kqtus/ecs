﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Falcon.Engine.Ecs
{
    public interface IEntityProvider
    {
        IEnumerable<Entity> Entities { get; }
        
        TEntity Create<TEntity>() where TEntity : Entity;

        void Add<TEntity>(TEntity entity) where TEntity : Entity;

        Entity Get(int entityId);
        
        TEntity Get<TEntity>(int entityId) where TEntity : Entity;
        
        IEntityQueryBuilder Query();

        IEnumerable<Entity> WithComponents(IEnumerable<Type> componentTypes);
    }
}
