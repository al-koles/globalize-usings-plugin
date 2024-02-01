﻿using System.Threading;
using JetBrains.Application.BuildScript.Application.Zones;
using JetBrains.ReSharper.Feature.Services;
using JetBrains.ReSharper.Psi.CSharp;
using JetBrains.ReSharper.TestFramework;
using JetBrains.TestFramework;
using JetBrains.TestFramework.Application.Zones;
using NUnit.Framework;

[assembly: Apartment(ApartmentState.STA)]

namespace ReSharperPlugin.GlobalizeUsingsPlugin.Tests
{
    [ZoneDefinition]
    public class GlobalizeUsingsPluginTestEnvironmentZone : ITestsEnvZone, IRequire<PsiFeatureTestZone>, IRequire<IGlobalizeUsingsPluginZone> { }

    [ZoneMarker]
    public class ZoneMarker : IRequire<ICodeEditingZone>, IRequire<ILanguageCSharpZone>, IRequire<GlobalizeUsingsPluginTestEnvironmentZone> { }

    [SetUpFixture]
    public class GlobalizeUsingsPluginTestsAssembly : ExtensionTestEnvironmentAssembly<GlobalizeUsingsPluginTestEnvironmentZone> { }
}
