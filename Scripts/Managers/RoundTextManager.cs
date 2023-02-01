using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundTextManager : MonoBehaviour
{
    public GameObject roundText1;
    public GameObject roundText2;
    public GameObject arrow1;
    public GameObject roundText3;
    public GameObject roundText4;
    public GameObject arrow2;
    public GameObject roundText5;
    public GameObject roundText6;


    // Start is called before the first frame update
    void Start()
    {
        roundText1.SetActive(false);
        roundText2.SetActive(false);
        roundText3.SetActive(false);
        roundText4.SetActive(false);
        roundText5.SetActive(false);
        roundText6.SetActive(false);
        arrow1.SetActive(false);
        arrow2.SetActive(false);

        StartCoroutine(RoundTextCo());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator RoundTextCo()
    {
        yield return new WaitForSeconds(1f);

        roundText1.SetActive(true);
        roundText2.SetActive(true);

        yield return new WaitForSeconds(.2f);

        arrow1.SetActive(true);

        yield return new WaitForSeconds(.2f);

        roundText3.SetActive(true);
        roundText4.SetActive(true);

        yield return new WaitForSeconds(.2f);

        arrow2.SetActive(true);

        yield return new WaitForSeconds(.2f);

        roundText5.SetActive(true);
        roundText6.SetActive(true);
    }
}
