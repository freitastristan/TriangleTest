using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TristanFreitasAssignment2.Test
{
    class TestTriangle
    {
        [Test]
        public void ShouldBeEquilateral()
        {
            TriangleFinder triangleFinder = new TriangleFinder();
            triangleFinder.Analyze(3, 3, 3);
            Assert.AreSame("Equilateral", triangleFinder.triangleType);
        }

        [Test]
        public void ShouldBeIsosceles()
        {
            TriangleFinder triangleFinder = new TriangleFinder();
            triangleFinder.Analyze(6, 6, 10);
            Assert.AreSame("Isosceles", triangleFinder.triangleType);
        }

        [Test]
        public void ShouldBeScalene()
        {
            TriangleFinder triangleFinder = new TriangleFinder();
            triangleFinder.Analyze(5, 7, 10);
            Assert.AreSame("Scalene", triangleFinder.triangleType);
        }

        [Test]
        public void ShouldNotCreateATriangle()
        {
            TriangleFinder triangleFinder = new TriangleFinder();
            triangleFinder.Analyze(2, 70, 2);
            Assert.AreSame("", triangleFinder.triangleType);
        }

        [Test]
        public void OneNegativeShouldNotCreateATriangle()
        {
            TriangleFinder triangleFinder = new TriangleFinder();
            triangleFinder.Analyze(-5, 7, 10);
            Assert.AreSame("", triangleFinder.triangleType);
        }

        [Test]
        public void TwoNegativeShouldNotCreateATriangle()
        {
            TriangleFinder triangleFinder = new TriangleFinder();
            triangleFinder.Analyze(-5, -7, 10);
            Assert.AreSame("", triangleFinder.triangleType);
        }

        [Test]
        public void ThreeNegativesShouldCreateATriangle()
        {
            TriangleFinder triangleFinder = new TriangleFinder();
            triangleFinder.Analyze(-5, -7, -10);
            Assert.AreSame("Scalene", triangleFinder.triangleType);
        }

        [Test]
        public void ZeroAsValueShouldNotMakeTriangle()
        {
            TriangleFinder triangleFinder = new TriangleFinder();
            triangleFinder.Analyze(0, 0, 0);
            Assert.AreSame("", triangleFinder.triangleType);
        }

    }
}
