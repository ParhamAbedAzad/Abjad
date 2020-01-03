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
            //these are var 2 tables!
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
            //these are var 2 tables!
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

    }
}
