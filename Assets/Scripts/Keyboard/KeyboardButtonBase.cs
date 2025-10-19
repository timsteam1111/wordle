using UnityEngine;
using UnityEngine.EventSystems;

namespace Keyboard
{
	public abstract class KeyboardButtonBase : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
	{
		public void OnPointerDown(PointerEventData eventData)
		{
			
		}
		
		public void OnPointerUp(PointerEventData eventData)
		{
			ProcessButtonClick();
		}

		protected abstract void ProcessButtonClick();
	}
}