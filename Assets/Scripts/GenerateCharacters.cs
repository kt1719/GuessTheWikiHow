using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MISC {
    public class GenerateCharacters : MonoBehaviour
    {
        string[] characterNames = { "Khayle", "Kevin", "Yuna", "Nelson", "Kacper", "Tom" };
        public RuntimeAnimatorController control;
        // Start is called before the first frame update
        List<GameObject> characters = new List<GameObject>();
        public Sprite characterSprite;
        void Start()
        {
            GameObject charGroup = new GameObject();
            charGroup.name = "Players";
            charGroup.transform.SetParent(transform);
            float x = 0.1f;
            float y = 0.15f;
            for (int i = 0; i < characterNames.Length; i++)
            {
                GameObject newChar = new GameObject();
                characters.Add(newChar);
                characters[i].transform.SetParent(charGroup.transform);
                characters[i].name = characterNames[i];
                characters[i].transform.localScale = new Vector3(4, 4, 1);
                characters[i].AddComponent<SpriteRenderer>();
                characters[i].GetComponent<SpriteRenderer>().sprite = characterSprite;
                characters[i].AddComponent<CharacterFloat>();
                characters[i].AddComponent<Animator>();
                characters[i].GetComponent<Animator>().runtimeAnimatorController = control as RuntimeAnimatorController;
                characters[i].GetComponent<Animator>().SetFloat("anim_offset", Random.Range(0.0f, 1.0f));
                Vector3 pos = Camera.main.ViewportToWorldPoint(new Vector3(x, y, 1));
                y += 0.30f;
                if (y > 0.85)
                {
                    y = 0.15f;
                    x = 0.9f;
                }
                float halfwidth = characters[i].GetComponent<SpriteRenderer>().bounds.size.x / 2;
                characters[i].transform.position = pos - new Vector3(halfwidth,0,0);
            }
        }
    }
}
