using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSpawn : MonoBehaviour
{
    public GameObject[] characters;

    public void Start()
    {
        if (CharacterSelection.character == "char1")
        {
            Instantiate(characters[0], transform.position, Quaternion.identity);
        }
        if (CharacterSelection.character == "char2")
        {
            Instantiate(characters[1], transform.position, Quaternion.identity);
        }
        if (CharacterSelection.character == "char3")
        {
            Instantiate(characters[2], transform.position, Quaternion.identity);
        }
    }
}
