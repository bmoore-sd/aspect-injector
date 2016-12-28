﻿using AspectInjector.Core;
using AspectInjector.Core.Configuration;
using AspectInjector.Core.Mixin;
using AspectInjector.Core.Utils;
using System;

namespace AspectInjector.CommandLine
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var config = ProcessingConfiguration.Default
                .UseMixinInjections()
                //.RegisterAdviceExtractor<MethodCallAdviceExtractor>()
                //.RegisterInjector<MethodCallInjector>()
                ;

            var processor = new Processor(config);

            var resolver = new CachedAssemblyResolver();
            resolver.AddSearchDirectory(@"C:\Users\Oleksandr.Hulyi\Documents\Visual Studio 2015\Projects\InterfacesTests\bin\Debug");

            processor.Process(@"C:\Users\Oleksandr.Hulyi\Documents\Visual Studio 2015\Projects\InterfacesTests\bin\Debug\InterfacesTests.exe", resolver);

            Console.ReadKey();
        }
    }
}