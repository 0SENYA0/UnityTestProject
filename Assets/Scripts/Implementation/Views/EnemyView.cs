using UnityEngine;

namespace Implementation.Views
{
	public class EnemyView : MonoBehaviour
	{
		[SerializeField] private Animator _animator;
		private int _attackParametrHash = Animator.StringToHash("IsAttack");

		private void Update()
		{
			if (Input.GetMouseButton(0))
			{
				Vector3 mousePosition = Input.mousePosition;

				Vector2 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

				RaycastHit2D hitInfo = Physics2D.Raycast(worldPosition, Vector2.right);

				if (hitInfo.collider.TryGetComponent(out EnemyView _enemyView))
					PlayAttackAnimation();
			}
		}

		private void PlayAttackAnimation() =>
			_animator.SetBool(_attackParametrHash, true);
	}
}