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
#elif (ReleaseFarsi)
            {'ص',new Rows('ص','ر','ج')},
            {'ث',new Rows('ث','ش','و')},
            {'س',new Rows('س','م','چ')},
            {'ی',new Rows('ی','ل','ظ')},
            {'ض',new Rows('ض','غ','ک')},
            {'ژ',new Rows('ژ','پ','ن')},
            {'ز',new Rows('ز','ه','ت')},
            {'ب',new Rows('ب','د','ق')},
            {'ف',new Rows('ف','ق','د')},
            {'خ',new Rows('خ','ت','ه')},
            {'ع',new Rows('ع','ن','پ')},
            {'ط',new Rows('ط','ک','غ')},
            {'ذ',new Rows('ذ','ظ','ل')},
            {'گ',new Rows('گ','چ','م')},
            {'ح',new Rows('ح','و','ش')},
            {'ا',new Rows('ا','ج','ر')},
            {'ر',new Rows('ر','ص','ا')},
            {'ش',new Rows('ش','ث','ح')},
            {'م',new Rows('م','س','گ')},
            {'ل',new Rows('ل','ی','ذ')},
            {'غ',new Rows('غ','ض','ط')},
            {'پ',new Rows('پ','ژ','ع')},
            {'ه',new Rows('ه','ز','خ')},
            {'د',new Rows('د','ب','ف')},
            {'ق',new Rows('ق','ف','ب')},
            {'ت',new Rows('ت','خ','ز')},
            {'ن',new Rows('ن','ع','ژ')},
            {'ک',new Rows('ک','ط','ض')},
            {'ظ',new Rows('ظ','ذ','ی')},
            {'چ',new Rows('چ','گ','س')},
            {'و',new Rows('و','ح','ث')},
            {'ج',new Rows('ج','ا','ص')},
#endif
        };
        public static Dictionary<char, Rows> MapRow2 { get; set; } = new Dictionary<char, Rows>()
        {
#if (DEBUG || Release)
            
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
#elif (ReleaseFarsi)
            {'ق',new Rows('ق','ج','ف')},
            {'س',new Rows('س','ژ','م')},
            {'ر',new Rows('ر','د','ص')},
            {'ع',new Rows('ع','گ','ن')},
            {'ت',new Rows('ت','و','خ')},
            {'ی',new Rows('ی','ض','ل')},
            {'ش',new Rows('ش','ه','ث')},
            {'ط',new Rows('ط','ذ','ک')},
            {'ظ',new Rows('ظ','ک','ذ')},
            {'ز',new Rows('ز','ث','ه')},
            {'غ',new Rows('غ','ل','ض')},
            {'ح',new Rows('ح','خ','و')},
            {'چ',new Rows('چ','ن','گ')},
            {'ب',new Rows('ب','ص','د')},
            {'پ',new Rows('پ','م','ژ')},
            {'ا',new Rows('ا','ف','ج')},
            {'ج',new Rows('ج','ق','ا')},
            {'ژ',new Rows('ژ','س','پ')},
            {'د',new Rows('د','ر','ب')},
            {'گ',new Rows('گ','ع','چ')},
            {'و',new Rows('و','ت','ح')},
            {'ض',new Rows('ض','ی','غ')},
            {'ه',new Rows('ه','ش','ز')},
            {'ذ',new Rows('ذ','ط','ظ')},
            {'ک',new Rows('ک','ظ','ط')},
            {'ث',new Rows('ث','ز','ش')},
            {'ل',new Rows('ل','غ','ی')},
            {'خ',new Rows('خ','ح','ت')},
            {'ن',new Rows('ن','چ','ع')},
            {'ص',new Rows('ص','ب','ر')},
            {'م',new Rows('م','پ','س')},
            {'ف',new Rows('ف','ا','ق')},
#endif
        };
        public static Dictionary<char, Rows> MapRow3 { get; set; } = new Dictionary<char, Rows>()
        {
#if (DEBUG || Release)
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
#elif (ReleaseFarsi)
            {'ق',new Rows('ق','ج','ف')},
            {'ن',new Rows('ن','چ','ع')},
            {'ر',new Rows('ر','د','ص')},
            {'م',new Rows('م','پ','س')},
            {'ث',new Rows('ث','ز','ش')},
            {'ی',new Rows('ی','ض','ل')},
            {'خ',new Rows('خ','ح','ت')},
            {'ط',new Rows('ط','ذ','ک')},
            {'ظ',new Rows('ظ','ک','ذ')},
            {'و',new Rows('و','ت','ح')},
            {'غ',new Rows('غ','ل','ض')},
            {'ه',new Rows('ه','ش','ز')},
            {'ژ',new Rows('ژ','س','پ')},
            {'ب',new Rows('ب','ص','د')},
            {'گ',new Rows('گ','ع','چ')},
            {'ا',new Rows('ا','ف','ج')},
            {'ج',new Rows('ج','ق','ا')},
            {'چ',new Rows('چ','ن','گ')},
            {'د',new Rows('د','ر','ب')},
            {'پ',new Rows('پ','م','ژ')},
            {'ز',new Rows('ز','ث','ه')},
            {'ض',new Rows('ض','ی','غ')},
            {'ه',new Rows('ه','خ','و')},
            {'ذ',new Rows('ذ','ط','ظ')},
            {'ک',new Rows('ک','ظ','ط')},
            {'ت',new Rows('ت','و','خ')},
            {'ل',new Rows('ل','غ','ی')},
            {'ش',new Rows('ش','ه','ث')},
            {'س',new Rows('س','ژ','م')},
            {'ص',new Rows('ص','ب','ر')},
            {'ع',new Rows('ع','گ','ن')},
            {'ف',new Rows('ف','ا','ق')},
#endif
        };

    }
}


