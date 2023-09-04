﻿using System;
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
#if (DEBUG || Release)
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
            {'p',16},
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
            {'@',27},
            {'`',28 }
#elif (ReleaseFarsi)
            {'ق',19},
            {'س',15},
            {'ر',20},
            {'ع',16},
            {'ت',22},
            {'ی',10},
            {'ش',21},
            {'ط',9},
            {'ظ',27},
            {'ز',7},
            {'غ',28},
            {'ح',8},
            {'چ',30},
            {'ب',2},
            {'پ',29},
            {'ا',1},
            {'ج',3},
            {'ژ',31},
            {'د',4},
            {'گ',32},
            {'و',6},
            {'ض',26},
            {'ه',5},
            {'ذ',25},
            {'ک',11},
            {'ث',23},
            {'ل',12},
            {'خ',24},
            {'ن',14},
            {'ص',18},
            {'م',13},
            {'ف',17},
#endif
        };

        public static Dictionary<char, Rows> MapRow1 { get; set; } = new Dictionary<char, Rows>()
        {
#if (DEBUG || Release)
            {'a',new Rows('a','c','`')},
            {'e',new Rows('e','g','x')},
            {'i',new Rows('i','k','t')},
            {'m',new Rows('m','o','p')},
            {'q',new Rows('q','s','l')},
            {'u',new Rows('u','w','h')},
            {'y',new Rows('y','@','d')},
            {'b',new Rows('b','d','@')},
            {'f',new Rows('f','h','w')},
            {'j',new Rows('j','l','s')},
            {'n',new Rows('n','p','o')},
            {'r',new Rows('r','t','k')},
            {'v',new Rows('v','x','g')},
            {'z',new Rows('z','`','c')},
            // hala bar ax
            {'c',new Rows('c','a','z')},
            {'g',new Rows('g','e','v')},
            {'k',new Rows('k','i','r')},
            {'o',new Rows('o','m','n')},
            {'s',new Rows('s','q','j')},
            {'w',new Rows('w','u','f')},
            {'@',new Rows('@','y','b')},
            {'d',new Rows('d','b','y')},
            {'h',new Rows('h','f','u')},
            {'l',new Rows('l','j','q')},
            {'p',new Rows('p','n','m')},
            {'t',new Rows('t','r','i')},
            {'x',new Rows('x','v','e')},
            {'`',new Rows('`','z','a')},
#elif (ReleaseFarsi)
            {'ض',new Rows('ض','غ','ظ')},
            {'ت',new Rows('ت','خ','ث')},
            {'ص',new Rows('ص','ر','ق')},
            {'ن',new Rows('ن','ع','س')},
            {'ی',new Rows('ی','ل','ک')},
            {'و',new Rows('و','ح','ز')},
            {'ب',new Rows('ب','د','ج')},
            {'ذ',new Rows('ذ','ج','د')},
            {'ش',new Rows('ش','ز','ح')},
            {'ف',new Rows('ف','ک','ل')},
            {'م',new Rows('م','س','ع')},
            {'ط',new Rows('ط','ق','ر')},
            {'ه',new Rows('ه','ث','خ')},
            {'ا',new Rows('ا','ظ','غ')},
            // hala bar ax
            {'غ',new Rows('غ','ض','ا')},
            {'خ',new Rows('خ','ت','ه')},
            {'ر',new Rows('ر','ص','ط')},
            {'ع',new Rows('ع','ن','م')},
            {'ل',new Rows('ل','ی','ف')},
            {'ح',new Rows('ح','و','ش')},
            {'د',new Rows('د','ب','ذ')},
            {'ج',new Rows('ج','ذ','ب')},
            {'ز',new Rows('ز','ش','و')},
            {'ک',new Rows('ک','ف','ی')},
            {'س',new Rows('س','م','ن')},
            {'ق',new Rows('ق','ط','ص')},
            {'ث',new Rows('ث','ه','ت')},
            {'ظ',new Rows('ظ','ا','ض')},
            {'ژ',new Rows('ژ','ش','و')},
            {'چ',new Rows('چ','ذ','ب')},
            {'پ',new Rows('پ','د','ج')},
            {'گ',new Rows('گ','ف','ی')},
#endif
        };
        public static Dictionary<char, Rows> MapRow2 { get; set; } = new Dictionary<char, Rows>()
        {
#if (DEBUG || Release)
            
            {'a',new Rows('a','c','`')},
            {'e',new Rows('e','g','x')},
            {'i',new Rows('i','k','t')},
            {'m',new Rows('m','o','p')},
            {'q',new Rows('q','s','l')},
            {'u',new Rows('u','w','h')},
            {'y',new Rows('y','@','d')},
            {'b',new Rows('b','d','@')},
            {'f',new Rows('f','h','w')},
            {'j',new Rows('j','l','s')},
            {'n',new Rows('n','p','o')},
            {'r',new Rows('r','t','k')},
            {'v',new Rows('v','x','g')},
            {'z',new Rows('z','`','c')},
            // hala bar ax
            {'c',new Rows('c','a','z')},
            {'g',new Rows('g','e','v')},
            {'k',new Rows('k','i','r')},
            {'o',new Rows('o','m','n')},
            {'s',new Rows('s','q','j')},
            {'w',new Rows('w','u','f')},
            {'@',new Rows('@','y','b')},
            {'d',new Rows('d','b','y')},
            {'h',new Rows('h','f','u')},
            {'l',new Rows('l','j','q')},
            {'p',new Rows('p','n','m')},
            {'t',new Rows('t','r','i')},
            {'x',new Rows('x','v','e')},
            {'`',new Rows('`','z','a')},
#elif (ReleaseFarsi)
            {'ض',new Rows('ض','غ','ظ')},
            {'ت',new Rows('ت','خ','ث')},
            {'ص',new Rows('ص','ر','ق')},
            {'ن',new Rows('ن','ع','س')},
            {'ی',new Rows('ی','ل','ک')},
            {'و',new Rows('و','ح','ز')},
            {'ب',new Rows('ب','د','ج')},
            {'ذ',new Rows('ذ','ج','د')},
            {'ش',new Rows('ش','ز','ح')},
            {'ف',new Rows('ف','ک','ل')},
            {'م',new Rows('م','س','ع')},
            {'ط',new Rows('ط','ق','ر')},
            {'ه',new Rows('ه','ث','خ')},
            {'ا',new Rows('ا','ظ','غ')},
            // hala bar ax
            {'غ',new Rows('غ','ض','ا')},
            {'خ',new Rows('خ','ت','ه')},
            {'ر',new Rows('ر','ص','ط')},
            {'ع',new Rows('ع','ن','م')},
            {'ل',new Rows('ل','ی','ف')},
            {'ح',new Rows('ح','و','ش')},
            {'د',new Rows('د','ب','ذ')},
            {'ج',new Rows('ج','ذ','ب')},
            {'ز',new Rows('ز','ش','و')},
            {'ک',new Rows('ک','ف','ی')},
            {'س',new Rows('س','م','ن')},
            {'ق',new Rows('ق','ط','ص')},
            {'ث',new Rows('ث','ه','ت')},
            {'ظ',new Rows('ظ','ا','ض')},
            {'ژ',new Rows('ژ','ش','و')},
            {'چ',new Rows('چ','ذ','ب')},
            {'پ',new Rows('پ','د','ج')},
            {'گ',new Rows('گ','ف','ی')},
#endif
        };
        public static Dictionary<char, Rows> MapRow3 { get; set; } = new Dictionary<char, Rows>()
        {
#if (DEBUG || Release)
            {'a',new Rows('a','c','`')},
            {'e',new Rows('e','g','x')},
            {'i',new Rows('i','k','t')},
            {'m',new Rows('m','o','p')},
            {'q',new Rows('q','s','l')},
            {'u',new Rows('u','w','h')},
            {'y',new Rows('y','@','d')},
            {'b',new Rows('b','d','@')},
            {'f',new Rows('f','h','w')},
            {'j',new Rows('j','l','s')},
            {'n',new Rows('n','p','o')},
            {'r',new Rows('r','t','k')},
            {'v',new Rows('v','x','g')},
            {'z',new Rows('z','`','c')},
            // hala bar ax
            {'c',new Rows('c','a','z')},
            {'g',new Rows('g','e','v')},
            {'k',new Rows('k','i','r')},
            {'o',new Rows('o','m','n')},
            {'s',new Rows('s','q','j')},
            {'w',new Rows('w','u','f')},
            {'@',new Rows('@','y','b')},
            {'d',new Rows('d','b','y')},
            {'h',new Rows('h','f','u')},
            {'l',new Rows('l','j','q')},
            {'p',new Rows('p','n','m')},
            {'t',new Rows('t','r','i')},
            {'x',new Rows('x','v','e')},
            {'`',new Rows('`','z','a')},
#elif (ReleaseFarsi)
            {'ض',new Rows('ض','غ','ظ')},
            {'ت',new Rows('ت','خ','ث')},
            {'ص',new Rows('ص','ر','ق')},
            {'ن',new Rows('ن','ع','س')},
            {'ی',new Rows('ی','ل','ک')},
            {'و',new Rows('و','ح','ز')},
            {'ب',new Rows('ب','د','ج')},
            {'ذ',new Rows('ذ','ج','د')},
            {'ش',new Rows('ش','ز','ح')},
            {'ف',new Rows('ف','ک','ل')},
            {'م',new Rows('م','س','ع')},
            {'ط',new Rows('ط','ق','ر')},
            {'ه',new Rows('ه','ث','خ')},
            {'ا',new Rows('ا','ظ','غ')},
            // hala bar ax
            {'غ',new Rows('غ','ض','ا')},
            {'خ',new Rows('خ','ت','ه')},
            {'ر',new Rows('ر','ص','ط')},
            {'ع',new Rows('ع','ن','م')},
            {'ل',new Rows('ل','ی','ف')},
            {'ح',new Rows('ح','و','ش')},
            {'د',new Rows('د','ب','ذ')},
            {'ج',new Rows('ج','ذ','ب')},
            {'ز',new Rows('ز','ش','و')},
            {'ک',new Rows('ک','ف','ی')},
            {'س',new Rows('س','م','ن')},
            {'ق',new Rows('ق','ط','ص')},
            {'ث',new Rows('ث','ه','ت')},
            {'ظ',new Rows('ظ','ا','ض')},
            {'ژ',new Rows('ژ','ش','و')},
            {'چ',new Rows('چ','ذ','ب')},
            {'پ',new Rows('پ','د','ج')},
            {'گ',new Rows('گ','ف','ی')},
#endif
        };

    }
}

