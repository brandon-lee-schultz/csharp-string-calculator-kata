using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator.Tests
{
    public class SingleNegativeDigitStubData : IEnumerable<object[]>
    {
        private readonly List<object[]> _data =
        [
            ["-1"],
            ["-2"],
            ["-3"],
            ["-9"]
        ];

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
