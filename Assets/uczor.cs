using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class uczor : MonoBehaviour
{
    public AudioSource[] audios;
    public Sprite[] dogrular;
    public Sprite[] yanlislar;
    public Text TimeText, SkorText;
    public Image I1, I2, I3;

    int skor;
    public Button solb, ortab, sagb;
    float zaman;
    public GameObject carpi_panel, yandin_panel, gectin_panel, tekrar_panel;
    int _1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12;
    void Start()
    {
        _1 = Random.Range(0, 8); _2 = Random.Range(0, 8); while (_1 == _2) { _2 = Random.Range(0, 8); }
        _3 = Random.Range(0, 8); while (_1 == _3 || _3 == _2) { _3 = Random.Range(0, 8); }
        _4 = Random.Range(0, 8); _5 = Random.Range(0, 8); while (_4 == _5) { _5 = Random.Range(0, 8); }
        _6 = Random.Range(0, 8); while (_5 == _6 || _4 == _6) { _6 = Random.Range(0, 8); }
        _7 = Random.Range(0, 8); _8 = Random.Range(0, 8); while (_7 == _8) { _8 = Random.Range(0, 8); }
        _9 = Random.Range(0, 8); while (_8 == _9 || _7 == _9) { _9 = Random.Range(0, 8); }
        _10 = Random.Range(0, 8); _11 = Random.Range(0, 8); while (_10 == _11) { _11 = Random.Range(0, 8); }
        _12 = Random.Range(0, 8); while (11 == _12 || _10 == _12) { _12 = Random.Range(0, 8); }
        carpi_panel.SetActive(false); yandin_panel.SetActive(false); gectin_panel.SetActive(false); tekrar_panel.SetActive(false);
        zaman = 0f;
        skor = 0;
        audios[_1].PlayDelayed(0 * 10 + 1); audios[_2].PlayDelayed(0 * 10 + 3); audios[_3].PlayDelayed(0 * 10 + 5);
        audios[_4 + 8].PlayDelayed(1 * 10 + 1); audios[_5 + 8].PlayDelayed(1 * 10 + 3); audios[_6 + 8].PlayDelayed(1 * 10 + 5);
        audios[_7 + 16].PlayDelayed(2 * 10 + 1); audios[_8 + 16].PlayDelayed(2 * 10 + 3); audios[+16].PlayDelayed(2 * 10 + 5);
        audios[_10 + 24].PlayDelayed(3 * 10 + 1); audios[_11 + 24].PlayDelayed(3 * 10 + 3); audios[_12 + 24].PlayDelayed(3 * 10 + 5);
        solb.onClick.AddListener(solbuton);
        ortab.onClick.AddListener(ortabuton);
        sagb.onClick.AddListener(sagbuton);
    }

    // Update is called once per frame
    void Update()
    {
        zaman += Time.deltaTime;
        TimeText.text = zaman.ToString("F0");
        SkorText.text = "Score: " + skor;
        if (zaman > 5 && zaman < 10)
        {
            I1.sprite = dogrular[_1]; I2.sprite = yanlislar[1]; I3.sprite = yanlislar[0];
        }
        
        else if (zaman > 15 && zaman < 20)
        {
            I1.sprite = yanlislar[3]; I2.sprite = yanlislar[2]; ; I3.sprite = dogrular[_6];
        }
        
        else if (zaman > 25 && zaman < 30)
        {
            I1.sprite = yanlislar[4]; I2.sprite = yanlislar[5]; I3.sprite = dogrular[_9];

        }
        else if (zaman > 35 && zaman < 40)
        {
            I1.sprite = yanlislar[6]; I2.sprite = dogrular[_11]; I3.sprite = yanlislar[7];
        }

        if (zaman >= 40 && skor <= 2) { yandin_panel.SetActive(true); }
        if (zaman >= 40 && skor < 4 && skor > 2) { tekrar_panel.SetActive(true); }
        if (zaman >= 40 && skor >= 4) { gectin_panel.SetActive(true); }
    }
    void solbuton()
    {
        if ((zaman > 5 && zaman < 10))
        {
            skor += 1;
        }
    }
    void ortabuton()
    {
        if ((zaman > 35 && zaman < 40))
        {
            skor += 1;
        }
    }
    void sagbuton()
    {
        if ((zaman > 15 && zaman < 20) || (zaman > 25 && zaman < 30))
        {
            skor += 1;
        }
    }
    public void carpi()
    {
        carpi_panel.SetActive(true);
    }
    public void yeni_bolum_z3()
    {
        SceneManager.LoadScene("z3");
    }
    public void tekrarla_z3()
    {
        SceneManager.LoadScene("z3");
    }
    public void ana_menu()
    {
        SceneManager.LoadScene("anaekran");
    }
    public void eski_z3()
    {
        SceneManager.LoadScene("o3");
    }
}
