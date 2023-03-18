using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ikizor : MonoBehaviour
{
    public AudioSource[] audios;
    public Text SoruText, TimeText, SkorText, text1, text2, text3,text4;
    public GameObject SoruImage;
    public Image I4;
    int r;
    public Sprite aa, bb, cc,dd;
    int skor;
    public Button solb, ortab, sagb,sonb;
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
        sonb.onClick.AddListener(sonbuton);
        r = Random.Range(0, 3);

        if (r == 0)
        {
            audios[0].PlayDelayed(0 * 10 + 1); audios[1].PlayDelayed(0 * 10 + 2.5f); audios[2].PlayDelayed(0 * 10 + 4); audios[3].PlayDelayed(0 * 10 + 5.5f);
            audios[4].PlayDelayed(1 * 10 + 1); audios[5].PlayDelayed(1 * 10 + 2.5f); audios[6].PlayDelayed(1 * 10 + 4); audios[7].PlayDelayed(1 * 10 + 5.5f);
            audios[8].PlayDelayed(2 * 10 + 1); audios[9].PlayDelayed(2 * 10 + 2.5f); audios[10].PlayDelayed(2 * 10 + 4); audios[11].PlayDelayed(2 * 10 + 5.5f);
            audios[12].PlayDelayed(3 * 10 + 1); audios[13].PlayDelayed(3 * 10 + 2.5f); audios[14].PlayDelayed(3 * 10 + 4); audios[15].PlayDelayed(3 * 10 + 5.5f);
        }
        else if (r == 1)
        {
            audios[16].PlayDelayed(0 * 10 + 1); audios[17].PlayDelayed(0 * 10 + 2.5f); audios[18].PlayDelayed(0 * 10 + 4); audios[19].PlayDelayed(0 * 10 + 5.5f);
            audios[20].PlayDelayed(1 * 10 + 1); audios[21].PlayDelayed(1 * 10 + 2.5f); audios[22].PlayDelayed(1 * 10 + 4); audios[23].PlayDelayed(1 * 10 + 5.5f);
            audios[24].PlayDelayed(2 * 10 + 1); audios[25].PlayDelayed(2 * 10 + 2.5f); audios[26].PlayDelayed(2 * 10 + 4); audios[27].PlayDelayed(2 * 10 + 5.5f);
            audios[28].PlayDelayed(3 * 10 + 1); audios[29].PlayDelayed(3 * 10 + 2.5f); audios[30].PlayDelayed(3 * 10 + 4); audios[31].PlayDelayed(3 * 10 + 5.5f);
        }
        else if (r == 2)
        {
            audios[32].PlayDelayed(0 * 10 + 1); audios[33].PlayDelayed(0 * 10 + 2.5f); audios[34].PlayDelayed(0 * 10 + 4); audios[35].PlayDelayed(0 * 10 + 5.5f);
            audios[36].PlayDelayed(1 * 10 + 1); audios[37].PlayDelayed(1 * 10 + 2.5f); audios[38].PlayDelayed(1 * 10 + 4); audios[39].PlayDelayed(1 * 10 + 5.5f);
            audios[40].PlayDelayed(2 * 10 + 1); audios[41].PlayDelayed(2 * 10 + 2.5f); audios[42].PlayDelayed(2 * 10 + 4); audios[43].PlayDelayed(2 * 10 + 5.5f);
            audios[44].PlayDelayed(3 * 10 + 1); audios[45].PlayDelayed(3 * 10 + 2.5f); audios[46].PlayDelayed(3 * 10 + 4); audios[47].PlayDelayed(3 * 10 + 5.5f);
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
            if (zaman % 10 > 0 && zaman % 10 < 5)
            {


                text1.text = " "; text2.text = " "; text3.text = " "; text4.text = " ";
            }

            else
            {
                text1.text = "1"; text2.text = "2"; text3.text = "3"; text4.text = "4";
            }

            if (zaman > 5 && zaman < 10)
            {
                SoruImage.SetActive(true); I4.sprite = aa; SoruText.enabled = true; SoruText.text = "Erik Nerede?";
            }
            else if (zaman > 15 && zaman < 20)
            {
                SoruImage.SetActive(true); I4.sprite = bb; SoruText.enabled = true; SoruText.text = "Karpuz Nerede?";
            }
            else if (zaman > 25 && zaman < 30)
            {
                SoruImage.SetActive(true); I4.sprite = cc; SoruText.enabled = true; SoruText.text = "Kavun Nerede?";
            }
            else if (zaman > 35 && zaman < 40)
            {
                SoruImage.SetActive(true); I4.sprite = dd; SoruText.enabled = true; SoruText.text = "Kiraz Nerede?";
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
                SoruImage.SetActive(true); I4.sprite = bb; SoruText.enabled = true; SoruText.text = "Karpuz Nerede?";
            }
            else if (zaman > 15 && zaman < 20)
            {
                SoruText.enabled = true;
                SoruImage.SetActive(true); I4.sprite = aa; SoruText.enabled = true; SoruText.text = "Erik Nerede?";
            }
            else if (zaman > 25 && zaman < 30)
            {
                SoruImage.SetActive(true); I4.sprite = cc; SoruText.enabled = true; SoruText.text = "Kavun Nerede?";
            }
            else if (zaman > 35 && zaman < 40)
            {
                SoruImage.SetActive(true); I4.sprite = dd; SoruText.enabled = true; SoruText.text = "Kiraz Nerede?";
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
                SoruImage.SetActive(true); I4.sprite = dd; SoruText.enabled = true; SoruText.text = "Kiraz Nerede?";
            }
            else if (zaman > 15 && zaman < 20)
            {
                SoruText.enabled = true;
                SoruImage.SetActive(true); I4.sprite = cc; SoruText.enabled = true; SoruText.text = "Kavun Nerede?";
            }
            else if (zaman > 25 && zaman < 30)
            {
                SoruImage.SetActive(true); I4.sprite = bb; SoruText.enabled = true; SoruText.text = "Karpuz Nerede?";
            }
            else if (zaman > 35 && zaman < 40)
            {
                SoruImage.SetActive(true); I4.sprite = aa; SoruText.enabled = true; SoruText.text = "Erik Nerede?";
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
        
    }
    void ortabuton()
    {
        
        if (r == 1)
        {
            if ((zaman > 5 && zaman < 10) || (zaman > 15 && zaman < 20) || (zaman > 25 && zaman < 30)|| (zaman > 35 && zaman < 40))
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
       
        if (r == 2)
        {
            if ((zaman > 15 && zaman < 20)|| (zaman > 25 && zaman < 30))
            {
                skor += 1;
            }
        }
    }
    void sonbuton()
    {
        if (r == 0)
        {
            if (zaman > 25 && zaman < 30)
            {
                skor += 1;
            }
        }
        else if (r == 1)
        {
            if ((zaman > 35 && zaman < 0))
            {
                skor += 1;
            }
        }
        else if (r == 2)
        {
            if ((zaman > 5 && zaman < 10))
            {
                skor += 1;
            }
        }
    }
    public void carpi()
    {
        carpi_panel.SetActive(true);
    }
    public void yeni_bolum_z2()
    {
        SceneManager.LoadScene("k3");
    }
    public void tekrarla_z2()
    {
        SceneManager.LoadScene("z2");
    }
    public void ana_menu()
    {
        SceneManager.LoadScene("anaekran");
    }
    public void eski_z2()
    {
        SceneManager.LoadScene("o2");
    }
}
