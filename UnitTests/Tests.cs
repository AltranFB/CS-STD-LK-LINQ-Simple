using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;
using System.Collections.Generic;

namespace Project
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void LanguagKnowledge1()
        {
            var strings = new List<string>();
            var filteredStrings = new Solution().Filter(strings);
            strings.Add("Gurt");
            strings.Add("Lobster");
            strings.Add("Litch");
            strings.Add("Doe");
            
            Check.That(filteredStrings).Contains("Litch");
            Check.That(filteredStrings).Contains("Lobster");
            Check.That(filteredStrings).Not.Contains("Gurt");
            Check.That(filteredStrings).Not.Contains("Doe");
        }

        [TestMethod]
        public void LanguagKnowledge2()
        {
            var strings = new List<string>();
            var filteredStrings = new Solution().Filter(strings);
            strings.Add("Gurt");
            strings.Add("Lobster");
            strings.Add("Litch");
            strings.Add("Doe");

            var expected = new List<string>();
            foreach (var str in filteredStrings)
                expected.Add(str);
            Check.That(expected[0]).Equals("Litch");
            Check.That(expected[1]).Equals("Lobster");
        }
    }
}