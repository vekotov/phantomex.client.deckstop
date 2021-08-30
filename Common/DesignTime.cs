using System;
using System.Linq;
using System.Reflection;
using Atomex.Abstract;
using Atomex.Common.Configuration;
using Atomex.Core;
using Microsoft.Extensions.Configuration;

namespace Phantomex.Client.Desktop.Common
{
    public static class DesignTime
    {
        private static Assembly CoreAssembly { get; } = AppDomain.CurrentDomain
            .GetAssemblies()
            .FirstOrDefault(a => a.GetName().Name == "Phantomex.Client.Core");

        private static readonly IConfiguration CurrenciesConfiguration = new ConfigurationBuilder()
            .AddEmbeddedJsonFile(CoreAssembly, "currencies.json")
            .Build()
            .GetSection(Network.TestNet.ToString());

        private static readonly IConfiguration SymbolsConfiguration = new ConfigurationBuilder()
            .AddEmbeddedJsonFile(CoreAssembly, "symbols.json")
            .Build()
            .GetSection(Network.TestNet.ToString());

        public static readonly ICurrencies Currencies 
            = new Currencies(CurrenciesConfiguration);

        public static readonly ISymbols Symbols 
            = new Symbols(SymbolsConfiguration);
    }
}