using GameData;
using Services;
using UnityEngine;

namespace Entities
{
    public class BackgroundParallax : MonoBehaviour
    {
        [SerializeField]
        private Transform _fore;

        [SerializeField]
        private Transform _middle;

        [SerializeField]
        private Transform _back;

        private Transform _target;

        private void Start()
        {
            _target = Camera.main.transform;
        }

        private void Update()
        {
            _fore.position = _target.position / 5f;
            _middle.position = _target.position / 15f;
            _back.position = _target.position / 25f;
        }
    }
}
