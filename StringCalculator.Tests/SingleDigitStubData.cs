using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator.Tests
{
    public class SingleDigitStubData : IEnumerable<object[]>
    {
        private readonly List<object[]> _data =
        [
            ["1", 1],
            ["2", 2],
            ["3", 3],
            ["9", 9],
            ["12", 12]
        ];

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
