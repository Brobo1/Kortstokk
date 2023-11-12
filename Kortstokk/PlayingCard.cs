using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kortstokk {
	public class PlayingCard {
		public int  Suit    { get; set; }
		public int  Value   { get; set; }
		public bool Visible { get; set; }

		public PlayingCard(int suit, int value) {
			Suit  = suit;
			Value = value;
		}
	}
}