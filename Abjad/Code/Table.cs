using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abjad.Code
{
    static class MapTable
    {
        public static Dictionary<char, int> MapScore { get; set; } = new Dictionary<char, int>()
        {
            {'c',1},
            {'d',3},
            {'f',4}
        };

        public static Dictionary<char, Rows> MapRow1 { get; set; } = new Dictionary<char, Rows>()
        {
            {'c',new Rows('c','d','f')}
        };
        public static Dictionary<char, Rows> MapRow2 { get; set; } = new Dictionary<char, Rows>()
        {
            {'c',new Rows('c','d','f')}
        };
        public static Dictionary<char, Rows> MapRow3 { get; set; } = new Dictionary<char, Rows>()
        {
            {'c',new Rows('c','d','f')}
        };

    }
}
