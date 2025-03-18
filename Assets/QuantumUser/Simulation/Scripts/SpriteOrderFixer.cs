using UnityEngine;

namespace Quantum
{
    public class SpriteOrderFixer : MonoBehaviour
    {
        private SpriteRenderer spriteRenderer;
        private void Awake()
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
        }

        // Update is called once per frame
        void Update()
        {
            spriteRenderer.sortingOrder = -(int)(transform.position.y * 100);
        }
    }
}
