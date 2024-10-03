using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator.Tests
{
    public class DoubleDigitStubData : IEnumerable<object[]>
    {
        private readonly List<object[]> _data =
        [
            ["1,2,3", 6],
            ["2,3,4", 9],
            ["3,4,5,6", 18],
            ["9,10,12,22,12", 65]
        ];

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
