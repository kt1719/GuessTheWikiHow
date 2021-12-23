using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MISC
{
    public class CharacterFloat : MonoBehaviour
    {
        // Start is called before the first frame update
        public float length = -0.2f;
        public float speed = 0.1f;

        int going_backwards = -1;

        float original_y;
        void Start()
        {
            original_y = transform.position.y;
            float offset = Random.Range(0.0f, 1.0f);
            length += offset;
        }

        // Update is called once per frame
        void Update()
        {
            if (length > 0.2)
            {
                going_backwards *= -1;
                length *= -1;
            }
            else
            {
                length += Time.deltaTime * speed;
            }
            speed = (1.05f - length)/5;
            transform.position = new Vector2(transform.position.x, original_y + (length*going_backwards));
        }
    }
}
