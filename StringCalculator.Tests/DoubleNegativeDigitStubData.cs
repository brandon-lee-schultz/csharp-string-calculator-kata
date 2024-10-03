using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator.Tests
{
    public class DoubleNegativeDigitStubData : IEnumerable<object[]>
    {
        private readonly List<object[]> _data =
        [
            ["-1,-2,-3"],
            ["-2,-3,-4"],
            ["-3,-4,-5,-6"],
            ["-9,-10,-12,-22,-12"]
        ];

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
