using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ikiorta : MonoBehaviour
{
    public AudioSource[] audios;
    public Text SoruText, TimeText, SkorText,text1,text2,text3;
    public GameObject SoruImage;
    public Image I4;
    int r;
    public Sprite aa, bb, cc;
    int skor;
    public Button solb, ortab, sagb;
    float zaman;
    public GameObject carpi_panel, yandin_panel, gectin_panel, tekrar_panel;
    
    void Start()
    {
        carpi_panel.SetActive(false); yandin_panel.SetActive(false); gectin_panel.SetActive(false); tekrar_panel.SetActive(false);
        zaman = 0f;
        skor = 0;

        solb.onClick.AddListener(solbuton);
        ortab.onClick.AddListener(ortabuton);
        sagb.onClick.AddListener(sagbuton);
        r = Random.Range(0, 3);

        if (r == 0)
        {
            audios[0].PlayDelayed(0 * 10 + 1); audios[1].PlayDelayed(0 * 10 + 3); audios[2].PlayDelayed(0 * 10 + 5);
            audios[3].PlayDelayed(1 * 10 + 1); audios[4].PlayDelayed(1 * 10 + 3); audios[5].PlayDelayed(1 * 10 + 5);
            audios[6].PlayDelayed(2 * 10 + 1); audios[7].PlayDelayed(2 * 10 + 3); audios[8].PlayDelayed(2 * 10 + 5);
            audios[9].PlayDelayed(3 * 10 + 1); audios[10].PlayDelayed(3 * 10 + 3); audios[11].PlayDelayed(3 * 10 + 5);
        }
        else if (r == 1)
        {
            audios[12].PlayDelayed(0 * 10 + 1); audios[13].PlayDelayed(0 * 10 + 3); audios[14].PlayDelayed(0 * 10 + 5);
            audios[15].PlayDelayed(1 * 10 + 1); audios[16].PlayDelayed(1 * 10 + 3); audios[17].PlayDelayed(1 * 10 + 5);
            audios[18].PlayDelayed(2 * 10 + 1); audios[19].PlayDelayed(2 * 10 + 3); audios[20].PlayDelayed(2 * 10 + 5);
            audios[21].PlayDelayed(3 * 10 + 1); audios[22].PlayDelayed(3 * 10 + 3); audios[23].PlayDelayed(3 * 10 + 5);
        }
        else if (r == 2)
        {
            audios[24].PlayDelayed(0 * 10 + 1); audios[25].PlayDelayed(0 * 10 + 3); audios[26].PlayDelayed(0 * 10 + 5);
            audios[27].PlayDelayed(1 * 10 + 1); audios[28].PlayDelayed(1 * 10 + 3); audios[29].PlayDelayed(1 * 10 + 5);
            audios[30].PlayDelayed(2 * 10 + 1); audios[31].PlayDelayed(2 * 10 + 3); audios[32].PlayDelayed(2 * 10 + 5);
            audios[33].PlayDelayed(3 * 10 + 1); audios[34].PlayDelayed(3 * 10 + 3); audios[35].PlayDelayed(3 * 10 + 5);
        }
        SoruImage.SetActive(false);
        SoruText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        zaman += Time.deltaTime;
        TimeText.text = zaman.ToString("F0");
        SkorText.text = "Score: " + skor;
        if (r == 0)
        {
            if (zaman%10 > 0 && zaman%10 < 5)
            {

                
                text1.text = " "; text2.text = " "; text3.text = " ";
            }
            
            else
            {
                text1.text = "1"; text2.text = "2"; text3.text = "3";
            }

            if (zaman > 5 && zaman < 10)
            {
                SoruImage.SetActive(true); I4.sprite = aa; SoruText.enabled = true; SoruText.text = "Elma Nerede?";
            }
            else if (zaman > 15 && zaman < 20)
            {
                SoruImage.SetActive(true); I4.sprite = bb; SoruText.enabled = true; SoruText.text = "Armut Nerede?";
            }
            else if (zaman > 25 && zaman < 30)
            {
                SoruImage.SetActive(true); I4.sprite = cc; SoruText.enabled = true; SoruText.text = "Çilek Nerede?";
            }
            else if (zaman > 35 && zaman < 40)
            {
                SoruImage.SetActive(true); I4.sprite = aa; SoruText.enabled = true; SoruText.text = "Elma Nerede?";
            }
            else
            {
                SoruText.enabled = false; SoruImage.SetActive(false);
            }
        }
        else if (r == 1)
        {
            if (zaman % 10 > 0 && zaman % 10 < 5)
            {

                
                text1.text = " "; text2.text = " "; text3.text = " ";
            }

            else
            {
                text1.text = "1"; text2.text = "2"; text3.text = "3";
            }

            if (zaman > 5 && zaman < 10)
            {
                SoruImage.SetActive(true); I4.sprite = cc; SoruText.enabled = true; SoruText.text = "Çilek Nerede?";
            }
            else if (zaman > 15 && zaman < 20)
            {
                SoruText.enabled = true;
                SoruImage.SetActive(true); I4.sprite = bb; SoruText.enabled = true; SoruText.text = "Armut Nerede?";
            }
            else if (zaman > 25 && zaman < 30)
            {
                SoruImage.SetActive(true); I4.sprite = aa; SoruText.enabled = true; SoruText.text = "Elma Nerede?";
            }
            else if (zaman > 35 && zaman < 40)
            {
                SoruImage.SetActive(true); I4.sprite = bb; SoruText.enabled = true; SoruText.text = "Armut Nerede?";
            }
            else
            {
                SoruText.enabled = false; SoruImage.SetActive(false);
            }
        }
        else if (r == 2)
        {
            if (zaman % 10 > 0 && zaman % 10 < 5)
            {

                
                text1.text = " "; text2.text = " "; text3.text = " ";
            }

            else
            {
                text1.text = "1"; text2.text = "2"; text3.text = "3";
            }

            if (zaman > 5 && zaman < 10)
            {
                SoruImage.SetActive(true); I4.sprite = bb; SoruText.enabled = true; SoruText.text = "Armut Nerede?";
            }
            else if (zaman > 15 && zaman < 20)
            {
                SoruText.enabled = true;
                SoruImage.SetActive(true); I4.sprite = cc; SoruText.enabled = true; SoruText.text = "Çilek Nerede?";
            }
            else if (zaman > 25 && zaman < 30)
            {
                SoruImage.SetActive(true); I4.sprite = aa; SoruText.enabled = true; SoruText.text = "Elma Nerede?";
            }
            else if (zaman > 35 && zaman < 40)
            {
                SoruImage.SetActive(true); I4.sprite = aa; SoruText.enabled = true; SoruText.text = "Elma Nerede?";
            }
            else
            {
                SoruText.enabled = false; SoruImage.SetActive(false);
            }
        }
        if (zaman >= 40 && skor <= 2) { yandin_panel.SetActive(true); }
        if (zaman >= 40 && skor < 4 && skor > 2) { tekrar_panel.SetActive(true); }
        if (zaman >= 40 && skor >= 4) { gectin_panel.SetActive(true); }
    }
    void solbuton()
    {
        if (r == 0)
        {
            if ((zaman > 5 && zaman < 10) || (zaman > 15 && zaman < 20) || (zaman > 25 && zaman < 30))
            {
                skor += 1;
            }
        }
        else if (r == 1)
        {
            if ((zaman > 25 && zaman < 30))
            {
                skor += 1;
            }
        }
        else if (r == 2)
        {
            if ((zaman > 35 && zaman < 40))
            {
                skor += 1;
            }
        }
    }
    void ortabuton()
    {
        if (r == 0)
        {
            if ((zaman > 35 && zaman < 40))
            {
                skor += 1;
            }
        }
        else if (r == 1)
        {
            if ((zaman > 5 && zaman < 10) || (zaman > 35 && zaman < 40))
            {
                skor += 1;
            }
        }
        else if (r == 2)
        {
            if ((zaman > 25 && zaman < 30))
            {
                skor += 1;
            }
        }
    }
    void sagbuton()
    {
        if (r == 1)
        {
            if ((zaman > 15 && zaman < 20))
            {
                skor += 1;
            }
        }
        else if (r == 2)
        {
            if ((zaman > 5 && zaman < 10) || (zaman > 15 && zaman < 20))
            {
                skor += 1;
            }
        }
    }
    public void carpi()
    {
        carpi_panel.SetActive(true);
    }
    public void yeni_bolum_o2()
    {
        SceneManager.LoadScene("z2");
    }
    public void tekrarla_o2()
    {
        SceneManager.LoadScene("o2");
    }
    public void ana_menu()
    {
        SceneManager.LoadScene("anaekran");
    }
    public void eski_o2()
    {
        SceneManager.LoadScene("k2");
    }
}
