using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator.Tests
{
    public class DoubleDigitCustomLengthDelimiterStubData : IEnumerable<object[]>
    {
        private readonly List<object[]> _data =
        [
            ["//[***]\n1***2***3", 6],
            ["//[***]\n2***3***4", 9],
            ["//[***]\n4***5***6", 15],
            ["//[***]\n9***10***12***22***12", 65]
        ];

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
