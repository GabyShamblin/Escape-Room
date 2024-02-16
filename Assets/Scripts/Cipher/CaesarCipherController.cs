using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class CaesarCipherController : MonoBehaviour
{
    int shiftValue;

    public string decryptedText;
    bool isSolved = false;
    string Encrypt()
    {
        string encryptedText = "";

        foreach (char c in decryptedText)
        {
            if (char.IsLetter(c))
            {
                char encryptedChar = (char)(((c - 'A' + shiftValue) % 26) + 'A');
                encryptedText += encryptedChar;
            }
            else
            {
                encryptedText += c;
            }
        }

        return encryptedText;
    }
    // Start is called before the first frame update
    void Start()
    {
        shiftValue = Random.Range(1, 26);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
