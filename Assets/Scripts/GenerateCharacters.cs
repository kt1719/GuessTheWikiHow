using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateCharacters : MonoBehaviour
{
    string[] characterNames = {"Khayle", "Kevin", "Yuna", "Nelson", "Kacper", "Tom" };
    // Start is called before the first frame update
    List<GameObject> characters = new List<GameObject>();
    public Sprite characterSprite;
    void Start()
    {
        GameObject charGroup = new GameObject();
        charGroup.name = "Players";
        charGroup.transform.SetParent(transform);
        float x = 0.1f;
        float y = 0.25f;
        for(int i = 0; i < characterNames.Length; i++)
        {
            GameObject newChar = new GameObject();
            characters.Add(newChar);
            characters[i].transform.SetParent(charGroup.transform);
            characters[i].name = characterNames[i];
            characters[i].AddComponent<SpriteRenderer>();
            characters[i].GetComponent<SpriteRenderer>().sprite = characterSprite;
            Vector3 pos = Camera.main.ViewportToWorldPoint(new Vector3(x,y,1));
            y += 0.25f;
            if(y > 0.85)
            {
                y = 0.25f;
                x = 0.9f;
            }
            characters[i].transform.position = pos;
        }
    }
}
