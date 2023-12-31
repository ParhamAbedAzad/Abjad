﻿using System;
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
            Character = character;
			ReCharacter = reCharacter;
			NaCharacter = naCharacter;
			Values = MapTable.MapScore[Character];
			ReValues = MapTable.MapScore[reCharacter];
			NaValues = MapTable.MapScore[naCharacter];
		}
	}
}
