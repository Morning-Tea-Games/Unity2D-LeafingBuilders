using DG.Tweening;
using Entities;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Tutorial
{
    public class EndScreen : MonoBehaviour
    {
        [SerializeField]
        Image _image;

        [SerializeField]
        private TMP_Text _msgField;

        [SerializeField]
        private TunnelTransition _endTunnel;

        private void OnEnable() => _endTunnel.OnEndGame += EndGame;

        private void OnDisable() => _endTunnel.OnEndGame -= EndGame;

        private void Start()
        {
            _image.DOFade(0f, 0f);
            _msgField.DOFade(0f, 0f);
        }

        public void EndGame(string endMassage)
        {
            _image.DOFade(1f, 1f);
            _msgField.DOFade(1f, 1f).OnComplete(() => Invoke(nameof(EndScene), 2f));
            _msgField.text = endMassage;
        }

        private void EndScene()
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
