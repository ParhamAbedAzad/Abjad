using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abjad.Code
{
	class Rows
    {
        public char Character { get; set; }
        public int Values { get; set; }
        public char ReCharacter { get; set; }
		public int ReValues { get; set; }
        public char NaCharacter { get; set; }
		public int NaValues { get; set; }

		public Rows(char character,char naCharacter, char reCharacter)
		{
            this.Character = character;
			this.ReCharacter = reCharacter;
			this.ReCharacter = naCharacter;
			this.Values = MapTable.MapScore[Character];
			this.ReValues = MapTable.MapScore[reCharacter];
			this.NaValues = MapTable.MapScore[naCharacter];
		}
	}
}
