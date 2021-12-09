using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Typper : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    public float timeBetweenLetters;

    public string phase;

    private void Awake()
    {
        textMesh.text = "";
    }

    [NaughtyAttributes.Button]
    public void StartType()
    {
        StartCoroutine(Type(phase));  
    }

    IEnumerator Type(string s)
    {
        textMesh.text = "";
        foreach (char l in s.ToCharArray())
        {
            textMesh.text += l;
            yield return new WaitForSeconds(timeBetweenLetters);
        }
    }
}
