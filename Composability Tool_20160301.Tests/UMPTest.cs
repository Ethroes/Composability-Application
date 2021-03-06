// <copyright file="UMPTest.cs">Copyright ©  2016</copyright>
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Composability_Tool_20160301;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Composability_Tool_20160301.Tests
{
    /// <summary>This class contains parameterized unit tests for UMP</summary>
    [PexClass(typeof(UMP))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class UMPTest
    {
        /// <summary>Test stub for writeXMLComposedSystemContent(UMP, UMP, ObservableCollection`1&lt;eqVariable&gt;, ObservableCollection`1&lt;eqVariable&gt;, Dictionary`2&lt;String,Double&gt;, Dictionary`2&lt;String,Double&gt;, Dictionary`2&lt;String,Double&gt;, Dictionary`2&lt;String,Double&gt;)</summary>
        [PexMethod]
        public string writeXMLComposedSystemContentTest(
            UMP SourceUMP,
            UMP TargetUMP,
            ObservableCollection<eqVariable> sourceVarList,
            ObservableCollection<eqVariable> targetVarList,
            Dictionary<string, double> sourceSustainabilityMetrics,
            Dictionary<string, double> targetSustainabilityMetrics,
            Dictionary<string, double> allParams,
            Dictionary<string, double> allInternalVars
        )
        {
            string result = UMP.writeXMLComposedSystemContent
                                (SourceUMP, TargetUMP, sourceVarList, targetVarList, 
                                 sourceSustainabilityMetrics, targetSustainabilityMetrics, 
                                 allParams, allInternalVars);
            return result;
            // TODO: add assertions to method UMPTest.writeXMLComposedSystemContentTest(UMP, UMP, ObservableCollection`1<eqVariable>, ObservableCollection`1<eqVariable>, Dictionary`2<String,Double>, Dictionary`2<String,Double>, Dictionary`2<String,Double>, Dictionary`2<String,Double>)
        }
    }
}
