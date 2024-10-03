using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator.Tests
{
    public class DoubleDigitNewLineStubData : IEnumerable<object[]>
    {
        private readonly List<object[]> _data =
        [
            ["1,2\n3", 6],
            ["2\n3,4", 9],
            ["3\n4,5\n6", 18],
            ["9\n10\n12\n22\n12", 65]
        ];

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
