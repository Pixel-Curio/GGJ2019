using UnityEngine;
using DG.Tweening;

namespace PixelCurio.GGJ2019
{
    public class Arrow : MonoBehaviour
    {
        [SerializeField] private RectTransform _parent;

        public void SetPosition(Vector3 position) => _parent.DOMove(position, 1f);
    }
}
