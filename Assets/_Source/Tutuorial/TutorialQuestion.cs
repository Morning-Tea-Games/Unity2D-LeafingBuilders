using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Tutorial
{
    public class TutorialQuestion : MonoBehaviour
    {
        [SerializeField]
        private Button _yesButton;

        [SerializeField]
        private Button _noButton;

        [SerializeField]
        private UnityEvent _onYes;

        [SerializeField]
        private UnityEvent _onNo;

        private void Awake()
        {
            gameObject.SetActive(false);
            _yesButton.onClick.AddListener(() => _onYes?.Invoke());
            _noButton.onClick.AddListener(() => _onNo?.Invoke());
        }

        public void Open()
        {
            gameObject.SetActive(true);
        }
    }
}
