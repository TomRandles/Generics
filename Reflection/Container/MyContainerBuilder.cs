using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection.Container
{
    public class MyContainerBuilder
    {
        public MyContainerBuilder(MyContainer container, Type sourceType)
        {
            _container = container;
            _sourceType = sourceType;
        }

        public MyContainerBuilder Use<TDestination>()
        {
            return Use(typeof(TDestination));
        }

        public MyContainerBuilder Use(Type destinationType)
        {
            _container._map.Add(_sourceType, destinationType);
            return this;
        }

        MyContainer _container;
        Type _sourceType;
    }
}