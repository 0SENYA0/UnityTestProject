using UnityEngine;

namespace Implementation.Views
{
	public class EnemyView2 : MonoBehaviour
	{
		[SerializeField] private SceneSwitcher sceneSwitcher;

		private void Update()
		{
			if (Input.GetMouseButton(0))
			{
				Vector3 mousePosition = Input.mousePosition;

				Vector2 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

				RaycastHit2D hitInfo = Physics2D.Raycast(worldPosition, Vector2.right);

				if (hitInfo.collider.TryGetComponent(out EnemyView2 _button))
					ShowButton();
			}
		}

		private void ShowButton() =>
			sceneSwitcher.gameObject.SetActive(true);
	}
}