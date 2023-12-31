using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialougeController : MonoBehaviour
{

    public TextMeshProUGUI DialougeText;
    public string[] sentences;
    private int index = 0;
    public float DialougeSpeed;
    private Coroutine displayLineCoroutine;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            NextSentence();
        }
        
    }

    void NextSentence()
    {
        if(index <= sentences.Length - 1)
            {
                if (displayLineCoroutine != null)
                {
                    StopCoroutine(displayLineCoroutine);
                }
                DialougeText.text = "";
                displayLineCoroutine = StartCoroutine(WriteSentence());
            }
    }

    IEnumerator WriteSentence()
    {
        foreach(char Character in sentences[index].ToCharArray())
        {
            DialougeText.text +=Character;
            yield return new WaitForSeconds(DialougeSpeed);
        }
        index++;
    }
}
