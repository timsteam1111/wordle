using System;
using UnityEngine;

namespace Keyboard
{
	public class KeyboardCharButton : KeyboardButtonBase
	{
		[SerializeField] private char symbol;

		public event Action<char> Pressed;

		protected override void ProcessButtonClick()
		{
			Pressed?.Invoke(symbol);
		}
	}
}