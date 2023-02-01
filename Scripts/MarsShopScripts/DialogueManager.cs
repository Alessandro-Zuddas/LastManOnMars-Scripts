using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager instance;

    public GameObject panelD1;
    public GameObject panelD2;
    public GameObject panelD3;

    public GameObject box1;
    public GameObject arrow1;
    public GameObject text1;

    public GameObject box2;
    public GameObject arrow2;
    public GameObject text2;

    public GameObject box3;
    public GameObject arrow3;
    public GameObject text3;

    public Animator anim;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        ClosePanels();

        StartCoroutine(StartDialogue());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClosePanels()
    {
        panelD1.SetActive(false);
        panelD2.SetActive(false);
        panelD3.SetActive(false);
    }

    public IEnumerator StartDialogue()
    {
        panelD1.SetActive(true);

        box1.SetActive(true);

        text1.SetActive(true);

        arrow1.SetActive(true);

        yield return new WaitForSeconds(1f);

        ClosePanels();

        panelD2.SetActive(true);

        box2.SetActive(true);

        text2.SetActive(true);

        arrow2.SetActive(true);
    }

    public void EndFunction()
    {
        Debug.Log("End Function!");

        StartCoroutine(EndDialogue());
    }

    public IEnumerator EndDialogue()
    {
        ClosePanels();

        anim.SetBool("isLeaving", true);

        box3.SetActive(true);

        text3.SetActive(true);

        arrow3.SetActive(true);

        Debug.Log("Finita End Coroutine!");

        yield return new WaitForSeconds(1.5f);
    }
    

    public IEnumerator PurcahseCompleted()
    {
        anim.SetBool("wasPurchased", true);

        yield return new WaitForSeconds(2.5f);

        anim.SetBool("wasPurchased", false);
    }

    public IEnumerator PurcahseFailed()
    {
        anim.SetBool("purchaseFailed", true);

        yield return new WaitForSeconds(2.5f);

        anim.SetBool("purchaseFailed", false);
    }
}
