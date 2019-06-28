using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OyunKontrol : MonoBehaviour {

    public GameObject Asteroid;
    public Vector3 randomPos;
    public Text text;
    public Text oyunBittiText;
    public Text yenidenBaslaText;
    bool oyunBittiKontrol = false;
    bool yenidenBaslaKontrol = false;

    int score;


	// Use this for initialization
	void Start () {

        score = 0;

        text.text = "Score : " + score;

        StartCoroutine(olustur());
		
	}

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R) && yenidenBaslaKontrol)
        {
            SceneManager.LoadScene("level 1");
        }
    }

    IEnumerator olustur()
    {
        yield return new WaitForSeconds(2);

        while (true)
        {
            for (int i = 0; i<10; i++)
                    {
                          Vector3 vec = new Vector3(Random.Range(-randomPos.x, randomPos.x), 0, randomPos.z);
                          Instantiate(Asteroid, vec, Quaternion.identity);
                          yield return new WaitForSeconds(1);
                    }

            if(oyunBittiKontrol)
            {
                yenidenBaslaText.text = "Press R to Restart";
                yenidenBaslaKontrol = true;
                break;
            }

            yield return new WaitForSeconds(2);

        }

        

        

    }

    public void ScoreArttir(int gelenScore)
    {
        score += gelenScore;
        text.text = "Score : " + score;
    }

    public void OyunBitti ()
    {
        oyunBittiText.text = "Game Over";
        oyunBittiKontrol = true;
    }
	

}
