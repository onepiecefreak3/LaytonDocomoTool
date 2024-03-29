﻿using CrossCutting.Core.Contract.Bootstrapping;
using CrossCutting.Core.Contract.Configuration;
using CrossCutting.Core.Contract.DependencyInjection;
using CrossCutting.Core.Contract.EventBrokerage;
using CrossCutting.Core.Contract.Messages;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrossCutting.Core.Contract.DependencyInjection.DataClasses;
using Logic.Domain.Kuriimu2.KomponentAdapter.Contract;
using Logic.Domain.Kuriimu2.KomponentAdapter.InternalContract;

namespace Logic.Domain.Kuriimu2.KomponentAdapter
{
    public class Kuriimu2KomponentActivator : IComponentActivator
    {
        public void Activating()
        {
        }

        public void Activated()
        {
        }

        public void Deactivating()
        {
        }

        public void Deactivated()
        {
        }

        [DynamicDependency(DynamicallyAccessedMemberTypes.PublicConstructors, typeof(BinaryFactory))]
        [DynamicDependency(DynamicallyAccessedMemberTypes.PublicConstructors, typeof(BinaryTypeReader))]
        [DynamicDependency(DynamicallyAccessedMemberTypes.PublicConstructors, typeof(BinaryTypeWriter))]
        [DynamicDependency(DynamicallyAccessedMemberTypes.PublicConstructors, typeof(BinaryTypeSizeMeasurement))]
        [DynamicDependency(DynamicallyAccessedMemberTypes.PublicConstructors, typeof(ValueStorageFactory))]
        [DynamicDependency(DynamicallyAccessedMemberTypes.PublicConstructors, typeof(MemberInfoProvider))]
        [DynamicDependency(DynamicallyAccessedMemberTypes.PublicConstructors, typeof(StreamFactory))]
        [DynamicDependency(DynamicallyAccessedMemberTypes.PublicConstructors, typeof(BinaryReaderX))]
        [DynamicDependency(DynamicallyAccessedMemberTypes.PublicConstructors, typeof(BinaryWriterX))]
        [DynamicDependency(DynamicallyAccessedMemberTypes.PublicConstructors, typeof(ValueStorage))]
        [DynamicDependency(DynamicallyAccessedMemberTypes.PublicConstructors, typeof(Kuriimu2KomponentConfiguration))]
        public void Register(ICoCoKernel kernel)
        {
            kernel.Register<IBinaryFactory, BinaryFactory>(ActivationScope.Unique);
            kernel.Register<IBinaryTypeReader, BinaryTypeReader>(ActivationScope.Unique);
            kernel.Register<IBinaryTypeWriter, BinaryTypeWriter>(ActivationScope.Unique);
            kernel.Register<IBinaryTypeSizeMeasurement, BinaryTypeSizeMeasurement>(ActivationScope.Unique);

            kernel.Register<IValueStorageFactory, ValueStorageFactory>(ActivationScope.Unique);
            kernel.Register<IMemberInfoProvider, MemberInfoProvider>(ActivationScope.Unique);
            kernel.Register<IStreamFactory, StreamFactory>(ActivationScope.Unique);

            kernel.Register<IBinaryReaderX, BinaryReaderX>();
            kernel.Register<IBinaryWriterX, BinaryWriterX>();
            kernel.Register<IValueStorage, ValueStorage>();

            kernel.RegisterConfiguration<Kuriimu2KomponentConfiguration>();
        }

        public void AddMessageSubscriptions(IEventBroker broker)
        {
        }

        public void Configure(IConfigurator configurator)
        {
        }
    }
}
