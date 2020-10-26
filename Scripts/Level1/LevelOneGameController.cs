using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelOneGameController : MonoBehaviour
{
    public GameObject WhiteCube;
    public GameObject BlackCube;

    public GameObject CubePosition;
    public GameObject TransactionPosition;

    public Button whiteButtonForm;
    public Button blackButtonForm;
    public Text matchText;
    
    Rigidbody whiteCube;
    Rigidbody blackCube;

    public int whiteButtonCount = 0;
    public int blackButtonCount = 0;

    void Start()
    {
        whiteCube = WhiteCube.GetComponent<Rigidbody>();
        blackCube = BlackCube.GetComponent<Rigidbody>();

        whiteButtonForm.onClick.AddListener(whiteButton);
        blackButtonForm.onClick.AddListener(blackButton);
    }

    void whiteButton()
	{

        Instantiate(WhiteCube, CubePosition.transform.position, Quaternion.identity);
        whiteButtonCount++;

        StartCoroutine(MatchCount());

    }

    void blackButton()
	{
        Instantiate(BlackCube, CubePosition.transform.position, Quaternion.identity);
        blackButtonCount++;

        StartCoroutine(MatchCount());

    }

    IEnumerator MatchCount()
	{
        if (whiteButtonCount == 1 && blackButtonCount == 1)
        {
            yield return new WaitForSeconds(1.5f);
            if (whiteButtonCount == 1 && blackButtonCount == 1)
			{
                matchText.text = "Eşleşme Oranı : %100  Tebrikler!  \n" + "2.Levele Geçiyorsunuz...";  
                StartCoroutine(Transaction());
            }
        }

        else if (whiteButtonCount == 2 && blackButtonCount == 0)
        {
            yield return new WaitForSeconds(1.5f);
            if (whiteButtonCount == 2 && blackButtonCount == 0)
			{
                matchText.text = "Eşleşme Oranı : %50 \n" + "Level Tekrarı...";
                StartCoroutine(TransactionTwo());
            }
        }

        else if (whiteButtonCount == 0 && blackButtonCount == 2)
        {
            yield return new WaitForSeconds(1.5f);
            if (whiteButtonCount == 0 && blackButtonCount == 2)
			{
                matchText.text = "Eşleşme Oranı : %50\n" + "Level Tekrarı...";
                StartCoroutine(TransactionTwo());
            }
        }

        else if (whiteButtonCount > 1 || blackButtonCount > 1)
        {
            yield return new WaitForSeconds(1.5f);
            if (whiteButtonCount > 1 || blackButtonCount > 1)
			{
                matchText.text = "Eşleşme Oranı : %25\n" + "Level Tekrarı...";
                StartCoroutine(TransactionTwo());

            }
        }

    }


    IEnumerator Transaction()
	{
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Level2");

    }

    IEnumerator TransactionTwo()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Level1");

    }

}


