using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ilkkolay : MonoBehaviour
{
    public AudioSource[] audios;
    public Button solyukari, sagyukari,solasagi,sagasagi,CheckButton;
    public Image Isolyukari, Isagyukari, Isolasagi, Isagasagi;
    public Sprite[] nums;
    public Sprite Sbos;
    public Text TimeText, ScoreText, SolText, SagText;
    int score;
    float zaman;
    List<int> list_1 = new List<int>();//0-10 arasý Sayýlar
    List<int> list_2 = new List<int>();//0-4 arasý Sayýlar
    public GameObject carpi_panel, yandin_panel, gectin_panel, tekrar_panel;
    // Start is called before the first frame update
    void Start()
    {
        carpi_panel.SetActive(false); yandin_panel.SetActive(false); gectin_panel.SetActive(false); tekrar_panel.SetActive(false);
        //Isolyukari.sprite = _1;
        zaman = 0f;
        score = 0;
        Isolyukari.sprite = Sbos;
        Isagyukari.sprite = Sbos;
        Isolasagi.sprite = Sbos;
        Isagasagi.sprite = Sbos;
        solyukari.onClick.AddListener(taskonclick_SolUst);
        sagyukari.onClick.AddListener(taskonclick_SagUst);
        solasagi.onClick.AddListener(taskonclick_SolAlt);
        sagasagi.onClick.AddListener(taskonclick_SagAlt);
        CheckButton.onClick.AddListener(taskon_check);
        GenerateRandom();
        audios[list_1[0]].PlayDelayed(0 * 15 + 2);audios[list_1[1]].PlayDelayed(0 * 15 + 4);
        audios[list_1[2]].PlayDelayed(1 * 15 + 2); audios[list_1[3]].PlayDelayed(1 * 15 + 4);
        audios[list_1[4]].PlayDelayed(2 * 15 + 2); audios[list_1[5]].PlayDelayed(2 * 15 + 4);
        audios[list_1[6]].PlayDelayed(3 * 15 + 2); audios[list_1[7]].PlayDelayed(3 * 15 + 4);
        audios[list_1[8]].PlayDelayed(4 * 15 + 2); audios[list_1[9]].PlayDelayed(4 * 15 + 4);
        audios[list_1[10]].PlayDelayed(5 * 15 + 2); audios[list_1[11]].PlayDelayed(5 * 15 + 4);
        audios[list_1[12]].PlayDelayed(6 * 15 + 2); audios[list_1[13]].PlayDelayed(6 * 15 + 4);
        audios[list_1[14]].PlayDelayed(7 * 15 + 2); audios[list_1[15]].PlayDelayed(7 * 15 + 4);
        audios[list_1[16]].PlayDelayed(8 * 15 + 2); audios[list_1[17]].PlayDelayed(8 * 15 + 4);
        audios[list_1[18]].PlayDelayed(9 * 15 + 2); audios[list_1[19]].PlayDelayed(9 * 15 + 4);

    }

    // Update is called once per frame
    void Update()
    {
        zaman += Time.deltaTime;
        TimeText.text = (zaman%15).ToString("F0");
        ScoreText.text = "Score: " + score.ToString();
        if (zaman % 15 > 0 && zaman % 15 < 5)
        {
            SolText.text = " ";
            SagText.text = " ";
        }
        if (zaman > 5 && (zaman < 15))
        {
            Isolyukari.sprite = nums[list_1[5]];
            Isolasagi.sprite = nums[list_1[0]];
            Isagyukari.sprite = nums[list_1[1]];
            Isagasagi.sprite = nums[list_1[3]];
        }
        else if (zaman > 20 && (zaman < 30))
        {
            Isolyukari.sprite = nums[list_1[2]];
            Isolasagi.sprite = nums[list_1[6]];
            Isagyukari.sprite = nums[list_1[8]];
            Isagasagi.sprite = nums[list_1[3]];
        }
        else if (zaman > 35 && (zaman < 45))
        {
            Isolyukari.sprite = nums[list_1[7]];
            Isolasagi.sprite = nums[list_1[5]];
            Isagyukari.sprite = nums[list_1[2]];
            Isagasagi.sprite = nums[list_1[4]];
        }
        else if (zaman > 50 && (zaman < 60))
        {
            Isolyukari.sprite = nums[list_1[6]];
            Isolasagi.sprite = (nums[list_1[3]]);
            Isagyukari.sprite = (nums[list_1[7]]);
            Isagasagi.sprite = (nums[list_1[1]]);
        }
        else if (zaman > 65 && (zaman < 75))
        {
            Isolyukari.sprite = nums[list_1[8]];
            Isolasagi.sprite = (nums[list_1[5]]);
            Isagyukari.sprite = (nums[list_1[0]]);
            Isagasagi.sprite = (nums[list_1[9]]);
        }
        else if (zaman > 80 && (zaman < 90))
        {
            Isolyukari.sprite = nums[list_1[5]];
            Isolasagi.sprite = (nums[list_1[10]]);
            Isagyukari.sprite = (nums[list_1[1]]);
            Isagasagi.sprite = (nums[list_1[11]]);
        }
        else if (zaman > 95 && (zaman < 105))
        {
            Isolyukari.sprite = nums[list_1[1]];
            Isolasagi.sprite = (nums[list_1[12]]);
            Isagyukari.sprite = (nums[list_1[13]]);
            Isagasagi.sprite = (nums[list_1[8]]);
        }
        else if (zaman > 110 && (zaman < 120))
        {
            Isolyukari.sprite = nums[list_1[14]];
            Isolasagi.sprite = (nums[list_1[15]]);
            Isagyukari.sprite = (nums[list_1[3]]);
            Isagasagi.sprite = (nums[list_1[9]]);
        }
        else if (zaman > 125 && (zaman < 135))
        {
            Isolyukari.sprite = nums[list_1[2]];
            Isolasagi.sprite = (nums[list_1[16]]);
            Isagyukari.sprite = (nums[list_1[17]]);
            Isagasagi.sprite = (nums[list_1[7]]);
        }
        else if (zaman > 140 && (zaman < 150))
        {
            Isolyukari.sprite = nums[list_1[19]];
            Isolasagi.sprite = (nums[list_1[18]]);
            Isagyukari.sprite = (nums[list_1[3]]);
            Isagasagi.sprite = (nums[list_1[7]]);
        }
        else {
            Isolyukari.sprite = Sbos;
            Isolasagi.sprite = Sbos;
            Isagyukari.sprite = Sbos;
            Isagasagi.sprite = Sbos;
        }
        if (zaman >= 150 && score <= 3) { yandin_panel.SetActive(true); }
        if (zaman >= 150 && score < 7&& score > 3) { tekrar_panel.SetActive(true); }
        if (zaman >= 150 && score >= 7) { gectin_panel.SetActive(true); }
    }
    void GenerateRandom()
    {
        for (int j = 0; j < 20; j++)
        {
            int Rand = Random.Range(0, 20);
            while (list_1.Contains(Rand))
            {
                Rand = Random.Range(0, 20);
            }
            list_1.Add(Rand);

        }
        
    }
    public void taskon_check()
    {
        if (zaman > 5 && (zaman < 15) && SolText.text == (((list_1[0])%9)+1).ToString()&&SagText.text == (((list_1[1]) % 9) + 1).ToString())
        {
            score += 1;
        }
        else if (zaman > 20 && (zaman < 30) && SolText.text == (((list_1[2]) % 9) + 1).ToString() && SagText.text == (((list_1[3]) % 9) + 1).ToString())
        {
            score += 1;
        }
        else if (zaman > 35 && (zaman < 45) && SolText.text == (((list_1[4]) % 9) + 1).ToString() && SagText.text == (((list_1[5]) % 9) + 1).ToString())
        {
            score += 1;
        }
        else if (zaman > 50 && (zaman < 60) && SolText.text == (((list_1[6]) % 9) + 1).ToString() && SagText.text == (((list_1[7]) % 9) + 1).ToString())
        {
            score += 1;
        }
        else if (zaman > 65 && (zaman < 75) && SolText.text == (((list_1[8]) % 9) + 1).ToString() && SagText.text == (((list_1[9]) % 9) + 1).ToString())
        {
            score += 1;
        }
        else if (zaman > 80 && (zaman < 90) && SolText.text == (((list_1[10]) % 9) + 1).ToString() && SagText.text == (((list_1[11]) % 9) + 1).ToString())
        {
            score += 1;
        }
        else if (zaman > 95 && (zaman < 105) && SolText.text == (((list_1[12]) % 9) + 1).ToString() && SagText.text == (((list_1[13]) % 9) + 1).ToString())
        {
            score += 1;
        }
        else if (zaman > 110 && (zaman < 120) && SolText.text == (((list_1[14]) % 9) + 1).ToString() && SagText.text == (((list_1[15]) % 9) + 1).ToString())
        {
            score += 1;
        }
        else if (zaman > 125 && (zaman < 135) && SolText.text == (((list_1[16]) % 9) + 1).ToString() && SagText.text == (((list_1[17]) % 9) + 1).ToString())
        {
            score += 1;
        }
        else if (zaman > 140 && (zaman < 150) && SolText.text == (((list_1[18]) % 9) + 1).ToString() && SagText.text == (((list_1[19]) % 9) + 1).ToString())
        {
            score += 1;
        }
        else
        {
            score += -1;
        }
    }
    public void taskonclick_SolUst()
    {
        if(SolText.text==" "&& SagText.text == " ")
        {
            if (zaman > 5 && (zaman < 15)) { SolText.text = (((list_1[5]) % 9) + 1).ToString(); }
            else if (zaman > 20 && (zaman < 30)) { SolText.text = (((list_1[2]) % 9) + 1).ToString(); }
            else if (zaman > 35 && (zaman < 45)) { SolText.text = (((list_1[7]) % 9) + 1).ToString(); }
            else if (zaman > 50 && (zaman < 60)) { SolText.text = (((list_1[6]) % 9) + 1).ToString(); }
            else if (zaman > 65 && (zaman < 75)) { SolText.text = (((list_1[8]) % 9) + 1).ToString(); }
            else if (zaman > 80 && (zaman < 90)) { SolText.text = (((list_1[5]) % 9) + 1).ToString(); }
            else if (zaman > 95 && (zaman < 105)) { SolText.text = (((list_1[1]) % 9) + 1).ToString(); }
            else if (zaman > 110 && (zaman < 120)) { SolText.text = (((list_1[14]) % 9) + 1).ToString(); }
            else if (zaman > 125 && (zaman < 135)) { SolText.text = (((list_1[2]) % 9) + 1).ToString(); }
            else if (zaman > 140 && (zaman < 150)) { SolText.text = (((list_1[19]) % 9) + 1).ToString(); }

        }
        else if(SolText.text != " " && SagText.text == " ")
        {
            if (zaman > 5 && (zaman < 15)) { SagText.text = (((list_1[5]) % 9) + 1).ToString(); }
            else if (zaman > 20 && (zaman < 30)) { SagText.text = (((list_1[2]) % 9) + 1).ToString(); }
            else if (zaman > 35 && (zaman < 45)) { SagText.text = (((list_1[7]) % 9) + 1).ToString(); }
            else if (zaman > 50 && (zaman < 60)) { SagText.text = (((list_1[6]) % 9) + 1).ToString(); }
            else if (zaman > 65 && (zaman < 75)) { SagText.text = (((list_1[8]) % 9) + 1).ToString(); }
            else if (zaman > 80 && (zaman < 90)) { SagText.text = (((list_1[5]) % 9) + 1).ToString(); }
            else if (zaman > 95 && (zaman < 105)) { SagText.text = (((list_1[1]) % 9) + 1).ToString(); }
            else if (zaman > 110 && (zaman < 120)) { SagText.text = (((list_1[14]) % 9) + 1).ToString(); }
            else if (zaman > 125 && (zaman < 135)) { SagText.text = (((list_1[2]) % 9) + 1).ToString(); }
            else if (zaman > 140 && (zaman < 150)) { SagText.text = (((list_1[19]) % 9) + 1).ToString(); }
        }
    }
    public void taskonclick_SagUst()
    {
        if (SolText.text == " " && SagText.text == " ")
        {
            if (zaman > 5 && (zaman < 15)) { SolText.text = (((list_1[1]) % 9) + 1).ToString(); }
            else if (zaman > 20 && (zaman < 30)) { SolText.text = (((list_1[8]) % 9) + 1).ToString(); }
            else if (zaman > 35 && (zaman < 45)) { SolText.text = (((list_1[2]) % 9) + 1).ToString(); }
            else if (zaman > 50 && (zaman < 60)) { SolText.text = (((list_1[7]) % 9) + 1).ToString(); }
            else if (zaman > 65 && (zaman < 75)) { SolText.text = (((list_1[0]) % 9) + 1).ToString(); }
            else if (zaman > 80 && (zaman < 90)) { SolText.text = (((list_1[1]) % 9) + 1).ToString(); }
            else if (zaman > 95 && (zaman < 105)) { SolText.text = (((list_1[13]) % 9) + 1).ToString(); }
            else if (zaman > 110 && (zaman < 120)) { SolText.text = (((list_1[3]) % 9) + 1).ToString(); }
            else if (zaman > 125 && (zaman < 135)) { SolText.text = (((list_1[17]) % 9) + 1).ToString(); }
            else if (zaman > 140 && (zaman < 150)) { SolText.text = (((list_1[3]) % 9) + 1).ToString(); }
        }
        else if (SolText.text != " " && SagText.text == " ")
        {
            if (zaman > 5 && (zaman < 15)) { SagText.text = (((list_1[1]) % 9) + 1).ToString(); }
            else if (zaman > 20 && (zaman < 30)) { SagText.text = (((list_1[8]) % 9) + 1).ToString(); }
            else if (zaman > 35 && (zaman < 45)) { SagText.text = (((list_1[2]) % 9) + 1).ToString(); }
            else if (zaman > 50 && (zaman < 60)) { SagText.text = (((list_1[7]) % 9) + 1).ToString(); }
            else if (zaman > 65 && (zaman < 75)) { SagText.text = (((list_1[0]) % 9) + 1).ToString(); }
            else if (zaman > 80 && (zaman < 90)) { SagText.text = (((list_1[1]) % 9) + 1).ToString(); }
            else if (zaman > 95 && (zaman < 105)) { SagText.text = (((list_1[13]) % 9) + 1).ToString(); }
            else if (zaman > 110 && (zaman < 120)) { SagText.text = (((list_1[3]) % 9) + 1).ToString(); }
            else if (zaman > 125 && (zaman < 135)) { SagText.text = (((list_1[17]) % 9) + 1).ToString(); }
            else if (zaman > 140 && (zaman < 150)) { SagText.text = (((list_1[3]) % 9) + 1).ToString(); }
        }
    }
    public void taskonclick_SolAlt()
    {
        if (SolText.text == " " && SagText.text == " ")
        {
            if (zaman > 5 && (zaman < 15)) { SolText.text = (((list_1[0]) % 9) + 1).ToString(); }
            else if (zaman > 20 && (zaman < 30)) { SolText.text = (((list_1[6]) % 9) + 1).ToString(); }
            else if (zaman > 35 && (zaman < 45)) { SolText.text = (((list_1[5]) % 9) + 1).ToString(); }
            else if (zaman > 50 && (zaman < 60)) { SolText.text = (((list_1[3]) % 9) + 1).ToString(); }
            else if (zaman > 65 && (zaman < 75)) { SolText.text = (((list_1[5]) % 9) + 1).ToString(); }
            else if (zaman > 80 && (zaman < 90)) { SolText.text = (((list_1[10]) % 9) + 1).ToString(); }
            else if (zaman > 95 && (zaman < 105)) { SolText.text = (((list_1[12]) % 9) + 1).ToString(); }
            else if (zaman > 110 && (zaman < 120)) { SolText.text = (((list_1[15]) % 9) + 1).ToString(); }
            else if (zaman > 125 && (zaman < 135)) { SolText.text = (((list_1[16]) % 9) + 1).ToString(); }
            else if (zaman > 140 && (zaman < 150)) { SolText.text = (((list_1[18]) % 9) + 1).ToString(); }
        }
        else if (SolText.text != " " && SagText.text == " ")
        {
            if (zaman > 5 && (zaman < 15)) { SagText.text = (((list_1[0]) % 9) + 1).ToString(); }
            else if (zaman > 20 && (zaman < 30)) { SagText.text = (((list_1[6]) % 9) + 1).ToString(); }
            else if (zaman > 35 && (zaman < 45)) { SagText.text = (((list_1[5]) % 9) + 1).ToString(); }
            else if (zaman > 50 && (zaman < 60)) { SagText.text = (((list_1[3]) % 9) + 1).ToString(); }
            else if (zaman > 65 && (zaman < 75)) { SagText.text = (((list_1[5]) % 9) + 1).ToString(); }
            else if (zaman > 80 && (zaman < 90)) { SagText.text = (((list_1[10]) % 9) + 1).ToString(); }
            else if (zaman > 95 && (zaman < 105)) { SagText.text = (((list_1[12]) % 9) + 1).ToString(); }
            else if (zaman > 110 && (zaman < 120)) { SagText.text = (((list_1[15]) % 9) + 1).ToString(); }
            else if (zaman > 125 && (zaman < 135)) { SagText.text = (((list_1[16]) % 9) + 1).ToString(); }
            else if (zaman > 140 && (zaman < 150)) { SagText.text = (((list_1[18]) % 9) + 1).ToString(); }
        }
    }
    public void taskonclick_SagAlt()
    {
        if (SolText.text == " " && SagText.text == " ")
        {
            if (zaman > 5 && (zaman < 15)) { SolText.text = (((list_1[3]) % 9) + 1).ToString(); }
            else if (zaman > 20 && (zaman < 30)) { SolText.text = (((list_1[3]) % 9) + 1).ToString(); }
            else if (zaman > 35 && (zaman < 45)) { SolText.text = (((list_1[4]) % 9) + 1).ToString(); }
            else if (zaman > 50 && (zaman < 60)) { SolText.text = (((list_1[1]) % 9) + 1).ToString(); }
            else if (zaman > 65 && (zaman < 75)) { SolText.text = (((list_1[9]) % 9) + 1).ToString(); }
            else if (zaman > 80 && (zaman < 90)) { SolText.text = (((list_1[11]) % 9) + 1).ToString(); }
            else if (zaman > 95 && (zaman < 105)) { SolText.text = (((list_1[8]) % 9) + 1).ToString(); }
            else if (zaman > 110 && (zaman < 120)) { SolText.text = (((list_1[9]) % 9) + 1).ToString(); }
            else if (zaman > 125 && (zaman < 135)) { SolText.text = (((list_1[7]) % 9) + 1).ToString(); }
            else if (zaman > 140 && (zaman < 150)) { SolText.text = (((list_1[7]) % 9) + 1).ToString(); }
        }
        else if (SolText.text != " " && SagText.text == " ")
        {
            if (zaman > 5 && (zaman < 15)) { SagText.text = (((list_1[3]) % 9) + 1).ToString(); }
            else if (zaman > 20 && (zaman < 30)) { SagText.text = (((list_1[3]) % 9) + 1).ToString(); }
            else if (zaman > 35 && (zaman < 45)) { SagText.text = (((list_1[4]) % 9) + 1).ToString(); }
            else if (zaman > 50 && (zaman < 60)) { SagText.text = (((list_1[1]) % 9) + 1).ToString(); }
            else if (zaman > 65 && (zaman < 75)) { SagText.text = (((list_1[9]) % 9) + 1).ToString(); }
            else if (zaman > 80 && (zaman < 90)) { SagText.text = (((list_1[11]) % 9) + 1).ToString(); }
            else if (zaman > 95 && (zaman < 105)) { SagText.text = (((list_1[8]) % 9) + 1).ToString(); }
            else if (zaman > 110 && (zaman < 120)) { SagText.text = (((list_1[9]) % 9) + 1).ToString(); }
            else if (zaman > 125 && (zaman < 135)) { SagText.text = (((list_1[7]) % 9) + 1).ToString(); }
            else if (zaman > 140 && (zaman < 150)) { SagText.text = (((list_1[7]) % 9) + 1).ToString(); }
        }
    }
    public void carpi()
    {
        carpi_panel.SetActive(true);
    }
    public void yeni_bolum_k1()
    {
        SceneManager.LoadScene("o1");
    }
    public void tekrarla_k1()
    {
        SceneManager.LoadScene("k1");
    }
    public void ana_menu()
    {
        SceneManager.LoadScene("anaekran");
    }
}
