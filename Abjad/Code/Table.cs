using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abjad.Code
{
    class Table
    {
        private Dictionary<char, Rows> map = new Dictionary<char, Rows>();
		public Dictionary<char, Rows> Map { get => map; set => map = value; }
		public Table()
		{
			Map.Add('ا' , new Rows('ا',1,1,'ج',3,3));
			Map.Add('ح', new Rows('ح', 8, 8, 'و', 6, 6));
			Map.Add('ط', new Rows('ط', 9, 9, 'ک', 11, 20));
			Map.Add('ع', new Rows('ع', 16, 70, 'ن', 14, 50));
			Map.Add('a', new Rows('ا', 1, 1, 'ج', 3, 3));
		}

	
	}
}
