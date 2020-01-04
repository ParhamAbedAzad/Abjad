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
            {'a',1},
            {'u',21},
            {'b',2},
            {'v',22},
            {'h',8},
            {'t',20},
            {'g',7},
            {'s',19},
            {'i',9},
            {'m',13},
            {'j',10},
            {'n',14},
            {'p',17},
            {'l',12},
            {'o',15},
            {'k',11},
            {'q',17},
            {'e',5},
            {'r',18},
            {'f',6},
            {'x',24},
            {'d',4},
            {'w',23},
            {'c',3},
            {'y',25},
            {'z',26},
        };

        public static Dictionary<char, Rows> MapRow1 { get; set; } = new Dictionary<char, Rows>()
        {
            {'a',new Rows('a','r','t')},
            {'h',new Rows('h','c','u')},
            {'y',new Rows('y','f','m')},
            {'i',new Rows('i','k','l')},
            {'p',new Rows('p','n','e')},
            {'x',new Rows('x','v','d')},
            {'q',new Rows('q','s','s')},
            {'b',new Rows('b','d','v')},
            {'g',new Rows('g','e','n')},
            {'z',new Rows('z','l','k')},
            {'j',new Rows('j','m','f')},
            {'o',new Rows('o','u','c')},
            {'w',new Rows('w','t','r')},
            {'r',new Rows('r','a','w')},
            {'c',new Rows('c','h','o')},
            {'f',new Rows('f','y','j')},
            {'k',new Rows('k','i','z')},
            {'n',new Rows('n','p','g')},
            {'v',new Rows('v','x','b')},
            {'s',new Rows('s','q','q')},
            {'d',new Rows('d','b','x')},
            {'e',new Rows('e','g','p')},
            {'l',new Rows('l','z','i')},
            {'m',new Rows('m','j','y')},
            {'u',new Rows('u','o','h')},
            {'t',new Rows('t','w','a')},
        };
        public static Dictionary<char, Rows> MapRow2 { get; set; } = new Dictionary<char, Rows>()
        {
            {'a',new Rows('a','l','z')},
            {'u',new Rows('u','o','y')},
            {'b',new Rows('b','k','c')},
            {'v',new Rows('v','q','w')},
            {'h',new Rows('h','e','d')},
            {'t',new Rows('t','r','x')},
            {'g',new Rows('g','f','f')},
            {'s',new Rows('s','x','r')},
            {'i',new Rows('i','d','e')},
            {'m',new Rows('m','w','q')},
            {'j',new Rows('j','c','k')},
            {'n',new Rows('n','y','o')},
            {'p',new Rows('p','z','l')},
            {'l',new Rows('l','a','p')},
            {'o',new Rows('o','u','n')},
            {'k',new Rows('k','b','j')},
            {'q',new Rows('q','v','m')},
            {'e',new Rows('e','h','i')},
            {'r',new Rows('r','t','s')},
            {'f',new Rows('f','g','g')},
            {'x',new Rows('x','s','t')},
            {'d',new Rows('d','i','h')},
            {'w',new Rows('w','m','v')},
            {'c',new Rows('c','j','b')},
            {'y',new Rows('y','n','u')},
            {'z',new Rows('z','p','a')},
        };
        public static Dictionary<char, Rows> MapRow3 { get; set; } = new Dictionary<char, Rows>()
        {
            {'a',new Rows('a','l','z')},
            {'x',new Rows('x','n','y')},
            {'b',new Rows('b','k','c')},
            {'w',new Rows('w','q','v')},
            {'e',new Rows('e','h','d')},
            {'t',new Rows('t','r','u')},
            {'f',new Rows('f','g','g')},
            {'s',new Rows('s','u','r')},
            {'i',new Rows('i','d','h')},
            {'p',new Rows('p','v','q')},
            {'j',new Rows('j','c','k')},
            {'o',new Rows('o','y','n')},
            {'m',new Rows('m','z','l')},
            {'l',new Rows('l','a','m')},
            {'n',new Rows('n','x','o')},
            {'k',new Rows('k','b','j')},
            {'q',new Rows('q','w','p')},
            {'h',new Rows('h','e','i')},
            {'r',new Rows('r','t','s')},
            {'g',new Rows('g','f','f')},
            {'u',new Rows('u','s','t')},
            {'d',new Rows('d','i','e')},
            {'v',new Rows('v','p','w')},
            {'c',new Rows('c','j','b')},
            {'y',new Rows('y','o','x')},
            {'z',new Rows('z','m','a')},
        };

    }
}
