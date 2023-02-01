using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvManager : MonoBehaviour
{
    public Text gameText;
    public Image appStoreImage;
    public Image googleStoreImage;

    public float fadeSpeed = 1.5f;

    // Start is called before the first frame update
    void Start()
    {    
        StartCoroutine(CanvasCo());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator CanvasCo()
    {
        yield return new WaitForSeconds(3f);

        gameText.color = new Color(gameText.color.r, gameText.color.g, gameText.color.b, 0.25f);

        yield return new WaitForSeconds(0.05f);

        gameText.color = new Color(gameText.color.r, gameText.color.g, gameText.color.b, 0.5f);

        yield return new WaitForSeconds(0.05f);

        gameText.color = new Color(gameText.color.r, gameText.color.g, gameText.color.b, 0.75f);

        yield return new WaitForSeconds(0.05f);

        gameText.color = new Color(gameText.color.r, gameText.color.g, gameText.color.b, 1f);

        yield return new WaitForSeconds(0.05f);

        appStoreImage.color = new Color(appStoreImage.color.r, appStoreImage.color.g, appStoreImage.color.b, 0.25f);
        googleStoreImage.color = new Color(googleStoreImage.color.r, googleStoreImage.color.g, googleStoreImage.color.b, 0.25f);

        yield return new WaitForSeconds(0.05f);

        appStoreImage.color = new Color(appStoreImage.color.r, appStoreImage.color.g, appStoreImage.color.b, 0.5f);
        googleStoreImage.color = new Color(googleStoreImage.color.r, googleStoreImage.color.g, googleStoreImage.color.b, 0.5f);

        yield return new WaitForSeconds(0.05f);

        appStoreImage.color = new Color(appStoreImage.color.r, appStoreImage.color.g, appStoreImage.color.b, 0.75f);
        googleStoreImage.color = new Color(googleStoreImage.color.r, googleStoreImage.color.g, googleStoreImage.color.b, 0.75f);

        yield return new WaitForSeconds(0.05f);

        appStoreImage.color = new Color(appStoreImage.color.r, appStoreImage.color.g, appStoreImage.color.b, 1f);
        googleStoreImage.color = new Color(googleStoreImage.color.r, googleStoreImage.color.g, googleStoreImage.color.b, 1f);
    }
}
