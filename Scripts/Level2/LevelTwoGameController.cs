using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelTwoGameController : MonoBehaviour
{
    public GameObject WhiteCube;
    public GameObject BlackCube;

    public GameObject CubePosition;

    public Button whiteButtonFormTwo;
    public Button blackButtonFormTwo;
    public Text matchText;

    Rigidbody whiteCube;
    Rigidbody blackCube;

    public int whiteButtonCount = 0;
    public int blackButtonCount = 0;

    void Start()
    {
        whiteCube = WhiteCube.GetComponent<Rigidbody>();
        blackCube = BlackCube.GetComponent<Rigidbody>();

		whiteButtonFormTwo.onClick.AddListener(whiteButtonTwo);
		blackButtonFormTwo.onClick.AddListener(blackButtonTwo);

	}

    void whiteButtonTwo()
    {
    
        Instantiate(WhiteCube, CubePosition.transform.position, Quaternion.identity);
        whiteButtonCount++;

        StartCoroutine(MatchCount());

    }

	void blackButtonTwo()
	{
		Instantiate(BlackCube, CubePosition.transform.position, Quaternion.identity);
		blackButtonCount++;

		StartCoroutine(MatchCount());

	}

	IEnumerator MatchCount()
    {
        if (whiteButtonCount == 2 && blackButtonCount == 2)
        {
            yield return new WaitForSeconds(1.5f);
            if (whiteButtonCount == 2 && blackButtonCount == 2)
                matchText.text = "Eşleşme Oranı : %100  \n Tebrikler!";

        }

        else if (whiteButtonCount == 4 && blackButtonCount == 0)
        {
            yield return new WaitForSeconds(1.5f);
            if (whiteButtonCount == 4 && blackButtonCount == 0)
                matchText.text = "Eşleşme Oranı : %50";

        }

        else if (whiteButtonCount == 0 && blackButtonCount == 4)
        {
            yield return new WaitForSeconds(1.5f);
            if (whiteButtonCount == 0 && blackButtonCount == 4)
                matchText.text = "Eşleşme Oranı : %50";

        }

        if (whiteButtonCount > 2 || blackButtonCount > 2)
        {
            yield return new WaitForSeconds(1.5f);
            if (whiteButtonCount > 2 || blackButtonCount > 2)
                matchText.text = "Eşleşme Oranı : %25";

        }


    }

}

