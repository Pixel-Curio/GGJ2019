using UnityEngine;

namespace PixelCurio
{
    public class Arrow : MonoBehaviour
    {
        public void OnTriggerEnter2D(Collider2D col)
        {
            Debug.Log(col.gameObject.name + " : " + gameObject.name + " : " + Time.time);
        }
    }
}
