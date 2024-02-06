using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Implementation.Views
{
	public class SceneSwitcher : MonoBehaviour
	{
		[SerializeField] private Button _button;

		private void OnEnable() =>
			_button.onClick.AddListener(SwitchScene);

		private void OnDisable() =>
			_button.onClick.RemoveListener(SwitchScene);

		private void SwitchScene()
		{
			if (SceneManager.GetActiveScene().name == "Main_Scene")
				SceneManager.LoadScene("Main_Scene_2");
			else
				SceneManager.LoadScene("Main_Scene");
		}
	}
}