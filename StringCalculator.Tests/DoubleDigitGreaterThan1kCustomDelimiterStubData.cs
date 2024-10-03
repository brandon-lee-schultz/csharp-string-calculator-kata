using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator.Tests
{
    public class DoubleDigitGreaterThan1kCustomDelimiterStubData : IEnumerable<object[]>
    {
        private readonly List<object[]> _data =
        [
            ["//+\n1+2+3+1001+1000+1002", 1006],
            //["//+\n2;3;4", 9],
            //["//+\n3;4,5;6", 18],
            //["//+\n9;10;12;22;12", 65]
        ];

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
