using Microsoft.VisualStudio.TestTools.UnitTesting;
using Secondlab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Secondlab.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void ThereAreSuitableSides()
        {
            var triples = new List<List<int>>{
            new List<int> { 6, 4, 8 },
            new List<int> { 2, 2, 3 },
            new List<int> { 3, 2, 9 }
            };

            var cntValidSide = Logic.SearchingForTriplesForTriangle(triples);
            Assert.AreEqual(2, cntValidSide);
        }
        [TestMethod()]
        public void ThereAreNoSuitableSides()
        {
            var triples = new List<List<int>>{
            new List<int> { 1, 4, 8 },
            new List<int> { 2, 2, 7 },
            new List<int> { 3, 2, 9 }
            };

            var cntValidSide = Logic.SearchingForTriplesForTriangle(triples);
            Assert.AreEqual(0, cntValidSide);
        }
        [TestMethod()]
        public void EmptySides()
        {
            var triples = new List<List<int>>();

            var cntValidSide = Logic.SearchingForTriplesForTriangle(triples);
            Assert.AreEqual(0, cntValidSide);
        }
        [TestMethod()]
        public void AllSidesAreSuitable()
        {
            var triples = new List<List<int>>{
            new List<int> { 5, 4, 8 },
            new List<int> { 2, 2, 2 },
            new List<int> { 3, 6, 8 }
            };

            var cntValidSide = Logic.SearchingForTriplesForTriangle(triples);
            Assert.AreEqual(3, cntValidSide);
        }


    }
}