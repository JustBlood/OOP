namespace ComplexTests
{
    public class Tests
    {

        [Test]
        public void FormatComplexTest()
        {
            complex a = "1 + 3i";
            Assert.That(a.RealPart == 1d, "RealPart invalid");
            Assert.That(a.ImaginaryPart == 3d, "ImaginaryPart invalid");
            Assert.That(a.ToString() == "1 + 3i", "String performance invalid");
        }

        [Test]
        public void OperationsComplexTest()
        {
            complex first = "-1 - 3i";
            complex second = "-3 - 9i";
            var sum = first + second;
            var mul = first * second;
            var mulrev = second * first;
            var diff = first - second;

            Assert.That(mul == mulrev, "Multiplication incorrect! a * b != b * a");
            Assert.That(sum.RealPart == -4, "Sum incorrect at real part");
            Assert.That(sum.ImaginaryPart == -12, "Sum incorrect at imaginary part");
            Assert.That(diff.RealPart == 2, "Diff incorrect at real part");
            Assert.That(diff.ImaginaryPart == 6, $"Diff incorrect at imaginary part");
            Assert.That(mul.RealPart == -24, "Mul incorrect at real part");
            Assert.That(mul.ImaginaryPart == 18, "Mul incorrect at imaginary part");

            var firstCopy = first;
            Assert.That(firstCopy == first, "Same values isn't equals");
            firstCopy = "-1 - 3i";
            Assert.That(firstCopy == first, "Same values isn't equals");
        }
        [Test]
        public void ModTesting()
        {
            var testCases = new[]
            {
                (new complex(78, 3), 78.05767098754613),
                (new complex(34, 13), 36.40054944640259),
                (new complex(14, 13), 19.1049731745428),
                (new complex(9, 23), 24.698178070456937),
                (new complex(90, 89), 126.57408897558773),
            };

            foreach (var test in testCases)
            {
                Assert.That(test.Item1.Mod - test.Item2 < 1e-9, $"Mod isn't correct {test.Item1.Mod}, {test.Item2}");
            }

        }
    }
}