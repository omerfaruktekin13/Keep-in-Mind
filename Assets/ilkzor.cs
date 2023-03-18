using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ilkzor : MonoBehaviour
{
    public AudioSource[] audios;
    public Button solyukari, sagyukari, solasagi, sagasagi, CheckButton;
    public Text TimeText, ScoreText, IlkText,IkinciText, UcuncuText, DorduncuText;
    public Image Isolyukari, Isagyukari, Isolasagi, Isagasagi;
    public Sprite[] nums;
    public Sprite Sbos;
    int score;
    List<int> list_1 = new List<int>();//0-10 arasý Sayýlar
    float zaman;
    public GameObject carpi_panel, yandin_panel, gectin_panel, tekrar_panel;

    void Start()
    {
        zaman = 0f;
        carpi_panel.SetActive(false); yandin_panel.SetActive(false); gectin_panel.SetActive(false); tekrar_panel.SetActive(false);
        score = 0;
        IlkText.text = " "; IkinciText.text = " "; UcuncuText.text = " "; DorduncuText.text = " ";
        solyukari.onClick.AddListener(taskonclick_SolUst);
        sagyukari.onClick.AddListener(taskonclick_SagUst);
        solasagi.onClick.AddListener(taskonclick_SolAlt);
        sagasagi.onClick.AddListener(taskonclick_SagAlt);
        CheckButton.onClick.AddListener(taskon_check);
        GenerateRandom();
        audios[list_1[0]].PlayDelayed(0 * 15 + 2); audios[list_1[1]].PlayDelayed(0 * 15 + 4); audios[list_1[2]].PlayDelayed(0 * 15 + 6); audios[list_1[3]].PlayDelayed(0 * 15 + 8);
        audios[list_1[4]].PlayDelayed(1 * 15 + 2); audios[list_1[5]].PlayDelayed(1 * 15 + 4); audios[list_1[6]].PlayDelayed(1 * 15 + 6); audios[list_1[7]].PlayDelayed(1 * 15 + 8);
        audios[list_1[8]].PlayDelayed(2 * 15 + 2); audios[list_1[9]].PlayDelayed(2 * 15 + 4); audios[list_1[10]].PlayDelayed(2 * 15 + 6); audios[list_1[11]].PlayDelayed(2 * 15 + 8);
        audios[list_1[12]].PlayDelayed(3 * 15 + 2); audios[list_1[13]].PlayDelayed(3 * 15 + 4); audios[list_1[14]].PlayDelayed(3 * 15 + 6); audios[list_1[15]].PlayDelayed(3 * 15 + 8);
        audios[list_1[16]].PlayDelayed(4 * 15 + 2); audios[list_1[17]].PlayDelayed(4 * 15 + 4); audios[list_1[18]].PlayDelayed(4 * 15 + 6); audios[list_1[19]].PlayDelayed(4 * 15 + 8);
        audios[list_1[20]].PlayDelayed(5 * 15 + 2); audios[list_1[21]].PlayDelayed(5 * 15 + 4); audios[list_1[22]].PlayDelayed(5 * 15 + 6); audios[list_1[23]].PlayDelayed(5 * 15 + 8);
        audios[list_1[24]].PlayDelayed(6 * 15 + 2); audios[list_1[25]].PlayDelayed(6 * 15 + 4); audios[list_1[26]].PlayDelayed(6 * 15 + 6); audios[list_1[27]].PlayDelayed(6 * 15 + 8);
        audios[list_1[28]].PlayDelayed(7 * 15 + 2); audios[list_1[29]].PlayDelayed(7 * 15 + 4); audios[list_1[30]].PlayDelayed(7 * 15 + 6); audios[list_1[31]].PlayDelayed(7 * 15 + 8);
        audios[list_1[32]].PlayDelayed(8 * 15 + 2); audios[list_1[33]].PlayDelayed(8 * 15 + 4); audios[list_1[34]].PlayDelayed(8 * 15 + 6); audios[list_1[35]].PlayDelayed(8 * 15 + 8);
        audios[list_1[36]].PlayDelayed(9 * 15 + 2); audios[list_1[37]].PlayDelayed(9 * 15 + 4); audios[list_1[38]].PlayDelayed(9 * 15 + 6); audios[list_1[39]].PlayDelayed(9 * 15 + 8);
    }

    // Update is called once per frame
    void Update()
    {
        zaman += Time.deltaTime;
        ScoreText.text = "Score: " + score.ToString();
        if (zaman % 15 > 0 && zaman % 15 < 5)
        {
            IlkText.text = " ";
            IkinciText.text = " ";
            UcuncuText.text = " ";
            DorduncuText.text = " ";
        }
        if (zaman > 5 && (zaman < 15))
        {
            /*SolYukariButonT.text = list_1[0].ToString();
            SolAsagiButonT.text = (list_1[1].ToString());
            SagYukariButonT.text = (list_1[2].ToString());
            SagAsagiButonT.text = (list_1[3].ToString());*/
            Isolyukari.sprite = nums[list_1[0]];
            Isolasagi.sprite = nums[list_1[1]];
            Isagyukari.sprite = nums[list_1[2]];
            Isagasagi.sprite = nums[list_1[3]];
        }
        else if (zaman > 20 && (zaman < 30))
        {
            /*SolYukariButonT.text = list_1[4].ToString();
            SolAsagiButonT.text = (list_1[7].ToString());
            SagYukariButonT.text = (list_1[6].ToString());
            SagAsagiButonT.text = (list_1[5].ToString());*/
            Isolyukari.sprite = nums[list_1[4]];
            Isolasagi.sprite = nums[list_1[7]];
            Isagyukari.sprite = nums[list_1[6]];
            Isagasagi.sprite = nums[list_1[5]];

        }
        else if (zaman > 35 && (zaman < 45))
        {
            /*SolYukariButonT.text = list_1[8].ToString();
            SolAsagiButonT.text = (list_1[11].ToString());
            SagYukariButonT.text = (list_1[9].ToString());
            SagAsagiButonT.text = (list_1[10].ToString());*/
            Isolyukari.sprite = nums[list_1[8]];
            Isolasagi.sprite = nums[list_1[11]];
            Isagyukari.sprite = nums[list_1[9]];
            Isagasagi.sprite = nums[list_1[10]];
        }
        else if (zaman > 50 && (zaman < 60))
        {
            /*SolYukariButonT.text = list_1[14].ToString();
            SolAsagiButonT.text = (list_1[12].ToString());
            SagYukariButonT.text = (list_1[15].ToString());
            SagAsagiButonT.text = (list_1[13].ToString());*/
            Isolyukari.sprite = nums[list_1[14]];
            Isolasagi.sprite = nums[list_1[12]];
            Isagyukari.sprite = nums[list_1[15]];
            Isagasagi.sprite = nums[list_1[13]];
        }
        else if (zaman > 65 && (zaman < 75))
        {
            /*SolYukariButonT.text = list_1[17].ToString();
            SolAsagiButonT.text = (list_1[19].ToString());
            SagYukariButonT.text = (list_1[16].ToString());
            SagAsagiButonT.text = (list_1[18].ToString());*/
            Isolyukari.sprite = nums[list_1[17]];
            Isolasagi.sprite = nums[list_1[19]];
            Isagyukari.sprite = nums[list_1[16]];
            Isagasagi.sprite = nums[list_1[18]];
        }
        else if (zaman > 80 && (zaman < 90))
        {
            /*SolYukariButonT.text = list_1[21].ToString();
            SolAsagiButonT.text = (list_1[22].ToString());
            SagYukariButonT.text = (list_1[23].ToString());
            SagAsagiButonT.text = (list_1[20].ToString());*/
            Isolyukari.sprite = nums[list_1[21]];
            Isolasagi.sprite = nums[list_1[22]];
            Isagyukari.sprite = nums[list_1[23]];
            Isagasagi.sprite = nums[list_1[20]];
        }
        else if (zaman > 95 && (zaman < 105))
        {
            /*SolYukariButonT.text = list_1[27].ToString();
            SolAsagiButonT.text = (list_1[25].ToString());
            SagYukariButonT.text = (list_1[26].ToString());
            SagAsagiButonT.text = (list_1[24].ToString());*/
            Isolyukari.sprite = nums[list_1[27]];
            Isolasagi.sprite = nums[list_1[25]];
            Isagyukari.sprite = nums[list_1[26]];
            Isagasagi.sprite = nums[list_1[24]];
        }
        else if (zaman > 110 && (zaman < 120))
        {
            /*SolYukariButonT.text = list_1[28].ToString();
            SolAsagiButonT.text = (list_1[29].ToString());
            SagYukariButonT.text = (list_1[31].ToString());
            SagAsagiButonT.text = (list_1[30].ToString());*/
            Isolyukari.sprite = nums[list_1[28]];
            Isolasagi.sprite = nums[list_1[29]];
            Isagyukari.sprite = nums[list_1[31]];
            Isagasagi.sprite = nums[list_1[30]];
        }
        else if (zaman > 125 && (zaman < 135))
        {
            /*SolYukariButonT.text = list_1[33].ToString();
            SolAsagiButonT.text = (list_1[34].ToString());
            SagYukariButonT.text = (list_1[32].ToString());
            SagAsagiButonT.text = (list_1[35].ToString());*/
            Isolyukari.sprite = nums[list_1[33]];
            Isolasagi.sprite = nums[list_1[34]];
            Isagyukari.sprite = nums[list_1[32]];
            Isagasagi.sprite = nums[list_1[35]];
        }
        else if (zaman > 140 && (zaman < 150))
        {
            /*SolYukariButonT.text = list_1[38].ToString();
            SolAsagiButonT.text = (list_1[37].ToString());
            SagYukariButonT.text = (list_1[39].ToString());
            SagAsagiButonT.text = (list_1[36].ToString());*/
            Isolyukari.sprite = nums[list_1[38]];
            Isolasagi.sprite = nums[list_1[37]];
            Isagyukari.sprite = nums[list_1[39]];
            Isagasagi.sprite = nums[list_1[36]];
        }
        else
        {
            Isolyukari.sprite = Sbos;
            Isolasagi.sprite = Sbos;
            Isagyukari.sprite = Sbos;
            Isagasagi.sprite = Sbos;
        }
        if (zaman >= 150 && score <= 3) { yandin_panel.SetActive(true); }
        if (zaman >= 150 && score < 7 && score > 3) { tekrar_panel.SetActive(true); }
        if (zaman >= 150 && score >= 7) { gectin_panel.SetActive(true); }
    }
    void GenerateRandom()
    {
        for (int j = 0; j < 40; j++)
        {
            int Rand = Random.Range(0, 40);
            while (list_1.Contains(Rand))
            {
                Rand = Random.Range(0, 40);
            }
            list_1.Add(Rand);

        }

    }
    public void taskonclick_SolUst()
    {

        if (IlkText.text == " " && IkinciText.text == " " && UcuncuText.text == " " && DorduncuText.text == " ")
        {
            if (zaman > 5 && (zaman < 15)) { IlkText.text = (((list_1[0]) % 9) + 1).ToString(); }
            else if (zaman > 20 && (zaman < 30)) { IlkText.text = (((list_1[4]) % 9) + 1).ToString(); }
            else if (zaman > 35 && (zaman < 45)) { IlkText.text = (((list_1[8]) % 9) + 1).ToString(); }
            else if (zaman > 50 && (zaman < 60)) { IlkText.text = (((list_1[14]) % 9) + 1).ToString(); }
            else if (zaman > 65 && (zaman < 75)) { IlkText.text = (((list_1[17]) % 9) + 1).ToString(); }
            else if (zaman > 80 && (zaman < 90)) { IlkText.text = (((list_1[21]) % 9) + 1).ToString(); }
            else if (zaman > 95 && (zaman < 105)) { IlkText.text = (((list_1[27]) % 9) + 1).ToString(); }
            else if (zaman > 110 && (zaman < 120)) { IlkText.text = (((list_1[28]) % 9) + 1).ToString(); }
            else if (zaman > 125 && (zaman < 135)) { IlkText.text = (((list_1[33]) % 9) + 1).ToString(); }
            else if (zaman > 140 && (zaman < 150)) { IlkText.text = (((list_1[38]) % 9) + 1).ToString(); }
        }
        else if (IlkText.text != " " && IkinciText.text == " " && UcuncuText.text == " " && DorduncuText.text == " ")
        {
            if (zaman > 5 && (zaman < 15)) { IkinciText.text = (((list_1[0]) % 9) + 1).ToString(); }
            else if (zaman > 20 && (zaman < 30)) { IkinciText.text = (((list_1[4]) % 9) + 1).ToString(); }
            else if (zaman > 35 && (zaman < 45)) { IkinciText.text = (((list_1[8]) % 9) + 1).ToString(); }
            else if (zaman > 50 && (zaman < 60)) { IkinciText.text = (((list_1[14]) % 9) + 1).ToString(); }
            else if (zaman > 65 && (zaman < 75)) { IkinciText.text = (((list_1[17]) % 9) + 1).ToString(); }
            else if (zaman > 80 && (zaman < 90)) { IkinciText.text = (((list_1[21]) % 9) + 1).ToString(); }
            else if (zaman > 95 && (zaman < 105)) { IkinciText.text = (((list_1[27]) % 9) + 1).ToString(); }
            else if (zaman > 110 && (zaman < 120)) { IkinciText.text = (((list_1[28]) % 9) + 1).ToString(); }
            else if (zaman > 125 && (zaman < 135)) { IkinciText.text = (((list_1[33]) % 9) + 1).ToString(); }
            else if (zaman > 140 && (zaman < 150)) { IkinciText.text = (((list_1[38]) % 9) + 1).ToString(); }
        }
        else if (IlkText.text != " " && IkinciText.text != " " && UcuncuText.text == " " && DorduncuText.text == " ")
        {
            if (zaman > 5 && (zaman < 15)) { UcuncuText.text = (((list_1[0]) % 9) + 1).ToString(); }
            else if (zaman > 20 && (zaman < 30)) { UcuncuText.text = (((list_1[4]) % 9) + 1).ToString(); }
            else if (zaman > 35 && (zaman < 45)) { UcuncuText.text = (((list_1[8]) % 9) + 1).ToString(); }
            else if (zaman > 50 && (zaman < 60)) { UcuncuText.text = (((list_1[14]) % 9) + 1).ToString(); }
            else if (zaman > 65 && (zaman < 75)) { UcuncuText.text = (((list_1[17]) % 9) + 1).ToString(); }
            else if (zaman > 80 && (zaman < 90)) { UcuncuText.text = (((list_1[21]) % 9) + 1).ToString(); }
            else if (zaman > 95 && (zaman < 105)) { UcuncuText.text = (((list_1[27]) % 9) + 1).ToString(); }
            else if (zaman > 110 && (zaman < 120)) { UcuncuText.text = (((list_1[28]) % 9) + 1).ToString(); }
            else if (zaman > 125 && (zaman < 135)) { UcuncuText.text = (((list_1[33]) % 9) + 1).ToString(); }
            else if (zaman > 140 && (zaman < 150)) { UcuncuText.text = (((list_1[38]) % 9) + 1).ToString(); }
        }
        else if (IlkText.text != " " && IkinciText.text != " " && UcuncuText.text != " " && DorduncuText.text == " ")
        {
            if (zaman > 5 && (zaman < 15)) { DorduncuText.text = (((list_1[0]) % 9) + 1).ToString(); }
            else if (zaman > 20 && (zaman < 30)) { DorduncuText.text = (((list_1[4]) % 9) + 1).ToString(); }
            else if (zaman > 35 && (zaman < 45)) { DorduncuText.text = (((list_1[8]) % 9) + 1).ToString(); }
            else if (zaman > 50 && (zaman < 60)) { DorduncuText.text = (((list_1[14]) % 9) + 1).ToString(); }
            else if (zaman > 65 && (zaman < 75)) { DorduncuText.text = (((list_1[17]) % 9) + 1).ToString(); }
            else if (zaman > 80 && (zaman < 90)) { DorduncuText.text = (((list_1[21]) % 9) + 1).ToString(); }
            else if (zaman > 95 && (zaman < 105)) { DorduncuText.text = (((list_1[27]) % 9) + 1).ToString(); }
            else if (zaman > 110 && (zaman < 120)) { DorduncuText.text = (((list_1[28]) % 9) + 1).ToString(); }
            else if (zaman > 125 && (zaman < 135)) { DorduncuText.text = (((list_1[33]) % 9) + 1).ToString(); }
            else if (zaman > 140 && (zaman < 150)) { DorduncuText.text = (((list_1[38]) % 9) + 1).ToString(); }
        }
    }
    public void taskonclick_SagUst()
    {

        if (IlkText.text == " " && IkinciText.text == " " && UcuncuText.text == " " && DorduncuText.text == " ")
        {
            if (zaman > 5 && (zaman < 15)) { IlkText.text = (((list_1[1]) % 9) + 1).ToString(); }
            else if (zaman > 20 && (zaman < 30)) { IlkText.text = (((list_1[7]) % 9) + 1).ToString(); }
            else if (zaman > 35 && (zaman < 45)) { IlkText.text = (((list_1[11]) % 9) + 1).ToString(); }
            else if (zaman > 50 && (zaman < 60)) { IlkText.text = (((list_1[12]) % 9) + 1).ToString(); }
            else if (zaman > 65 && (zaman < 75)) { IlkText.text = (((list_1[19]) % 9) + 1).ToString(); }
            else if (zaman > 80 && (zaman < 90)) { IlkText.text = (((list_1[22]) % 9) + 1).ToString(); }
            else if (zaman > 95 && (zaman < 105)) { IlkText.text = (((list_1[25]) % 9) + 1).ToString(); }
            else if (zaman > 110 && (zaman < 120)) { IlkText.text = (((list_1[29]) % 9) + 1).ToString(); }
            else if (zaman > 125 && (zaman < 135)) { IlkText.text = (((list_1[34]) % 9) + 1).ToString(); }
            else if (zaman > 140 && (zaman < 150)) { IlkText.text = (((list_1[37]) % 9) + 1).ToString(); }
        }
        else if (IlkText.text != " " && IkinciText.text == " " && UcuncuText.text == " " && DorduncuText.text == " ")
        {
            if (zaman > 5 && (zaman < 15)) { IkinciText.text = (((list_1[1]) % 9) + 1).ToString(); }
            else if (zaman > 20 && (zaman < 30)) { IkinciText.text = (((list_1[7]) % 9) + 1).ToString(); }
            else if (zaman > 35 && (zaman < 45)) { IkinciText.text = (((list_1[11]) % 9) + 1).ToString(); }
            else if (zaman > 50 && (zaman < 60)) { IkinciText.text = (((list_1[12]) % 9) + 1).ToString(); }
            else if (zaman > 65 && (zaman < 75)) { IkinciText.text = (((list_1[19]) % 9) + 1).ToString(); }
            else if (zaman > 80 && (zaman < 90)) { IkinciText.text = (((list_1[22]) % 9) + 1).ToString(); }
            else if (zaman > 95 && (zaman < 105)) { IkinciText.text = (((list_1[25]) % 9) + 1).ToString(); }
            else if (zaman > 110 && (zaman < 120)) { IkinciText.text = (((list_1[29]) % 9) + 1).ToString(); }
            else if (zaman > 125 && (zaman < 135)) { IkinciText.text = (((list_1[34]) % 9) + 1).ToString(); }
            else if (zaman > 140 && (zaman < 150)) { IkinciText.text = (((list_1[37]) % 9) + 1).ToString(); }
        }
        else if (IlkText.text != " " && IkinciText.text != " " && UcuncuText.text == " " && DorduncuText.text == " ")
        {
            if (zaman > 5 && (zaman < 15)) { UcuncuText.text = (((list_1[1]) % 9) + 1).ToString(); }
            else if (zaman > 20 && (zaman < 30)) { UcuncuText.text = (((list_1[7]) % 9) + 1).ToString(); }
            else if (zaman > 35 && (zaman < 45)) { UcuncuText.text = (((list_1[11]) % 9) + 1).ToString(); }
            else if (zaman > 50 && (zaman < 60)) { UcuncuText.text = (((list_1[12]) % 9) + 1).ToString(); }
            else if (zaman > 65 && (zaman < 75)) { UcuncuText.text = (((list_1[19]) % 9) + 1).ToString(); }
            else if (zaman > 80 && (zaman < 90)) { UcuncuText.text = (((list_1[22]) % 9) + 1).ToString(); }
            else if (zaman > 95 && (zaman < 105)) { UcuncuText.text = (((list_1[25]) % 9) + 1).ToString(); }
            else if (zaman > 110 && (zaman < 120)) { UcuncuText.text = (((list_1[29]) % 9) + 1).ToString(); }
            else if (zaman > 125 && (zaman < 135)) { UcuncuText.text = (((list_1[34]) % 9) + 1).ToString(); }
            else if (zaman > 140 && (zaman < 150)) { UcuncuText.text = (((list_1[37]) % 9) + 1).ToString(); }
        }
        else if (IlkText.text != " " && IkinciText.text != " " && UcuncuText.text != " " && DorduncuText.text == " ")
        {
            if (zaman > 5 && (zaman < 15)) { DorduncuText.text = (((list_1[1]) % 9) + 1).ToString(); }
            else if (zaman > 20 && (zaman < 30)) { DorduncuText.text = (((list_1[7]) % 9) + 1).ToString(); }
            else if (zaman > 35 && (zaman < 45)) { DorduncuText.text = (((list_1[11]) % 9) + 1).ToString(); }
            else if (zaman > 50 && (zaman < 60)) { DorduncuText.text = (((list_1[12]) % 9) + 1).ToString(); }
            else if (zaman > 65 && (zaman < 75)) { DorduncuText.text = (((list_1[19]) % 9) + 1).ToString(); }
            else if (zaman > 80 && (zaman < 90)) { DorduncuText.text = (((list_1[22]) % 9) + 1).ToString(); }
            else if (zaman > 95 && (zaman < 105)) { DorduncuText.text = (((list_1[25]) % 9) + 1).ToString(); }
            else if (zaman > 110 && (zaman < 120)) { DorduncuText.text = (((list_1[29]) % 9) + 1).ToString(); }
            else if (zaman > 125 && (zaman < 135)) { DorduncuText.text = (((list_1[34]) % 9) + 1).ToString(); }
            else if (zaman > 140 && (zaman < 150)) { DorduncuText.text = (((list_1[37]) % 9) + 1).ToString(); }
        }
    }
    public void taskonclick_SolAlt()
    {

        if (IlkText.text == " " && IkinciText.text == " " && UcuncuText.text == " " && DorduncuText.text == " ")
        {
            if (zaman > 5 && (zaman < 15)) { IlkText.text = (((list_1[2]) % 9) + 1).ToString(); }
            else if (zaman > 20 && (zaman < 30)) { IlkText.text = (((list_1[6]) % 9) + 1).ToString(); }
            else if (zaman > 35 && (zaman < 45)) { IlkText.text = (((list_1[9]) % 9) + 1).ToString(); }
            else if (zaman > 50 && (zaman < 60)) { IlkText.text = (((list_1[15]) % 9) + 1).ToString(); }
            else if (zaman > 65 && (zaman < 75)) { IlkText.text = (((list_1[16]) % 9) + 1).ToString(); }
            else if (zaman > 80 && (zaman < 90)) { IlkText.text = (((list_1[23]) % 9) + 1).ToString(); }
            else if (zaman > 95 && (zaman < 105)) { IlkText.text = (((list_1[26]) % 9) + 1).ToString(); }
            else if (zaman > 110 && (zaman < 120)) { IlkText.text = (((list_1[31]) % 9) + 1).ToString(); }
            else if (zaman > 125 && (zaman < 135)) { IlkText.text = (((list_1[32]) % 9) + 1).ToString(); }
            else if (zaman > 140 && (zaman < 150)) { IlkText.text = (((list_1[39]) % 9) + 1).ToString(); }
        }
        else if (IlkText.text != " " && IkinciText.text == " " && UcuncuText.text == " " && DorduncuText.text == " ")
        {
            if (zaman > 5 && (zaman < 15)) { IkinciText.text = (((list_1[2]) % 9) + 1).ToString(); }
            else if (zaman > 20 && (zaman < 30)) { IkinciText.text = (((list_1[6]) % 9) + 1).ToString(); }
            else if (zaman > 35 && (zaman < 45)) { IkinciText.text = (((list_1[9]) % 9) + 1).ToString(); }
            else if (zaman > 50 && (zaman < 60)) { IkinciText.text = (((list_1[15]) % 9) + 1).ToString(); }
            else if (zaman > 65 && (zaman < 75)) { IkinciText.text = (((list_1[16]) % 9) + 1).ToString(); }
            else if (zaman > 80 && (zaman < 90)) { IkinciText.text = (((list_1[23]) % 9) + 1).ToString(); }
            else if (zaman > 95 && (zaman < 105)) { IkinciText.text = (((list_1[26]) % 9) + 1).ToString(); }
            else if (zaman > 110 && (zaman < 120)) { IkinciText.text = (((list_1[31]) % 9) + 1).ToString(); }
            else if (zaman > 125 && (zaman < 135)) { IkinciText.text = (((list_1[32]) % 9) + 1).ToString(); }
            else if (zaman > 140 && (zaman < 150)) { IkinciText.text = (((list_1[39]) % 9) + 1).ToString(); }
        }
        else if (IlkText.text != " " && IkinciText.text != " " && UcuncuText.text == " " && DorduncuText.text == " ")
        {
            if (zaman > 5 && (zaman < 15)) { UcuncuText.text = (((list_1[2]) % 9) + 1).ToString(); }
            else if (zaman > 20 && (zaman < 30)) { UcuncuText.text = (((list_1[6]) % 9) + 1).ToString(); }
            else if (zaman > 35 && (zaman < 45)) { UcuncuText.text = (((list_1[9]) % 9) + 1).ToString(); }
            else if (zaman > 50 && (zaman < 60)) { UcuncuText.text = (((list_1[15]) % 9) + 1).ToString(); }
            else if (zaman > 65 && (zaman < 75)) { UcuncuText.text = (((list_1[16]) % 9) + 1).ToString(); }
            else if (zaman > 80 && (zaman < 90)) { UcuncuText.text = (((list_1[23]) % 9) + 1).ToString(); }
            else if (zaman > 95 && (zaman < 105)) { UcuncuText.text = (((list_1[26]) % 9) + 1).ToString(); }
            else if (zaman > 110 && (zaman < 120)) { UcuncuText.text = (((list_1[31]) % 9) + 1).ToString(); }
            else if (zaman > 125 && (zaman < 135)) { UcuncuText.text = (((list_1[32]) % 9) + 1).ToString(); }
            else if (zaman > 140 && (zaman < 150)) { UcuncuText.text = (((list_1[39]) % 9) + 1).ToString(); }
        }
        else if (IlkText.text != " " && IkinciText.text != " " && UcuncuText.text != " " && DorduncuText.text == " ")
        {
            if (zaman > 5 && (zaman < 15)) { DorduncuText.text = (((list_1[2]) % 9) + 1).ToString(); }
            else if (zaman > 20 && (zaman < 30)) { DorduncuText.text = (((list_1[6]) % 9) + 1).ToString(); }
            else if (zaman > 35 && (zaman < 45)) { DorduncuText.text = (((list_1[9]) % 9) + 1).ToString(); }
            else if (zaman > 50 && (zaman < 60)) { DorduncuText.text = (((list_1[15]) % 9) + 1).ToString(); }
            else if (zaman > 65 && (zaman < 75)) { DorduncuText.text = (((list_1[16]) % 9) + 1).ToString(); }
            else if (zaman > 80 && (zaman < 90)) { DorduncuText.text = (((list_1[23]) % 9) + 1).ToString(); }
            else if (zaman > 95 && (zaman < 105)) { DorduncuText.text = (((list_1[26]) % 9) + 1).ToString(); }
            else if (zaman > 110 && (zaman < 120)) { DorduncuText.text = (((list_1[31]) % 9) + 1).ToString(); }
            else if (zaman > 125 && (zaman < 135)) { DorduncuText.text = (((list_1[32]) % 9) + 1).ToString(); }
            else if (zaman > 140 && (zaman < 150)) { DorduncuText.text = (((list_1[39]) % 9) + 1).ToString(); }
        }
    }
    public void taskonclick_SagAlt()
    {

        if (IlkText.text == " " && IkinciText.text == " " && UcuncuText.text == " " && DorduncuText.text == " ")
        {
            if (zaman > 5 && (zaman < 15)) { IlkText.text = (((list_1[3]) % 9) + 1).ToString(); }
            else if (zaman > 20 && (zaman < 30)) { IlkText.text = (((list_1[5]) % 9) + 1).ToString(); }
            else if (zaman > 35 && (zaman < 45)) { IlkText.text = (((list_1[10]) % 9) + 1).ToString(); }
            else if (zaman > 50 && (zaman < 60)) { IlkText.text = (((list_1[13]) % 9) + 1).ToString(); }
            else if (zaman > 65 && (zaman < 75)) { IlkText.text = (((list_1[18]) % 9) + 1).ToString(); }
            else if (zaman > 80 && (zaman < 90)) { IlkText.text = (((list_1[20]) % 9) + 1).ToString(); }
            else if (zaman > 95 && (zaman < 105)) { IlkText.text = (((list_1[24]) % 9) + 1).ToString(); }
            else if (zaman > 110 && (zaman < 120)) { IlkText.text = (((list_1[30]) % 9) + 1).ToString(); }
            else if (zaman > 125 && (zaman < 135)) { IlkText.text = (((list_1[35]) % 9) + 1).ToString(); }
            else if (zaman > 140 && (zaman < 150)) { IlkText.text = (((list_1[36]) % 9) + 1).ToString(); }
        }
        else if (IlkText.text != " " && IkinciText.text == " " && UcuncuText.text == " " && DorduncuText.text == " ")
        {
            if (zaman > 5 && (zaman < 15)) { IkinciText.text = (((list_1[3]) % 9) + 1).ToString(); }
            else if (zaman > 20 && (zaman < 30)) { IkinciText.text = (((list_1[5]) % 9) + 1).ToString(); }
            else if (zaman > 35 && (zaman < 45)) { IkinciText.text = (((list_1[10]) % 9) + 1).ToString(); }
            else if (zaman > 50 && (zaman < 60)) { IkinciText.text = (((list_1[13]) % 9) + 1).ToString(); }
            else if (zaman > 65 && (zaman < 75)) { IkinciText.text = (((list_1[18]) % 9) + 1).ToString(); }
            else if (zaman > 80 && (zaman < 90)) { IkinciText.text = (((list_1[20]) % 9) + 1).ToString(); }
            else if (zaman > 95 && (zaman < 105)) { IkinciText.text = (((list_1[24]) % 9) + 1).ToString(); }
            else if (zaman > 110 && (zaman < 120)) { IkinciText.text = (((list_1[30]) % 9) + 1).ToString(); }
            else if (zaman > 125 && (zaman < 135)) { IkinciText.text = (((list_1[35]) % 9) + 1).ToString(); }
            else if (zaman > 140 && (zaman < 150)) { IkinciText.text = (((list_1[36]) % 9) + 1).ToString(); }
        }
        else if (IlkText.text != " " && IkinciText.text != " " && UcuncuText.text == " " && DorduncuText.text == " ")
        {
            if (zaman > 5 && (zaman < 15)) { UcuncuText.text = (((list_1[3]) % 9) + 1).ToString(); }
            else if (zaman > 20 && (zaman < 30)) { UcuncuText.text = (((list_1[5]) % 9) + 1).ToString(); }
            else if (zaman > 35 && (zaman < 45)) { UcuncuText.text = (((list_1[10]) % 9) + 1).ToString(); }
            else if (zaman > 50 && (zaman < 60)) { UcuncuText.text = (((list_1[13]) % 9) + 1).ToString(); }
            else if (zaman > 65 && (zaman < 75)) { UcuncuText.text = (((list_1[18]) % 9) + 1).ToString(); }
            else if (zaman > 80 && (zaman < 90)) { UcuncuText.text = (((list_1[20]) % 9) + 1).ToString(); }
            else if (zaman > 95 && (zaman < 105)) { UcuncuText.text = (((list_1[24]) % 9) + 1).ToString(); }
            else if (zaman > 110 && (zaman < 120)) { UcuncuText.text = (((list_1[30]) % 9) + 1).ToString(); }
            else if (zaman > 125 && (zaman < 135)) { UcuncuText.text = (((list_1[35]) % 9) + 1).ToString(); }
            else if (zaman > 140 && (zaman < 150)) { UcuncuText.text = (((list_1[36]) % 9) + 1).ToString(); }
        }
        else if (IlkText.text != " " && IkinciText.text != " " && UcuncuText.text != " " && DorduncuText.text == " ")
        {
            if (zaman > 5 && (zaman < 15)) { DorduncuText.text = (((list_1[3]) % 9) + 1).ToString(); }
            else if (zaman > 20 && (zaman < 30)) { DorduncuText.text = (((list_1[5]) % 9) + 1).ToString(); }
            else if (zaman > 35 && (zaman < 45)) { DorduncuText.text = (((list_1[10]) % 9) + 1).ToString(); }
            else if (zaman > 50 && (zaman < 60)) { DorduncuText.text = (((list_1[13]) % 9) + 1).ToString(); }
            else if (zaman > 65 && (zaman < 75)) { DorduncuText.text = (((list_1[18]) % 9) + 1).ToString(); }
            else if (zaman > 80 && (zaman < 90)) { DorduncuText.text = (((list_1[20]) % 9) + 1).ToString(); }
            else if (zaman > 95 && (zaman < 105)) { DorduncuText.text = (((list_1[24]) % 9) + 1).ToString(); }
            else if (zaman > 110 && (zaman < 120)) { DorduncuText.text = (((list_1[30]) % 9) + 1).ToString(); }
            else if (zaman > 125 && (zaman < 135)) { DorduncuText.text = (((list_1[35]) % 9) + 1).ToString(); }
            else if (zaman > 140 && (zaman < 150)) { DorduncuText.text = (((list_1[36]) % 9) + 1).ToString(); }
        }
    }
    public void taskon_check()
    {
        if (zaman > 5 && (zaman < 15) && IlkText.text == (((list_1[0]) % 9) + 1).ToString() && IkinciText.text == (((list_1[1]) % 9) + 1).ToString() && UcuncuText.text == (((list_1[2]) % 9) + 1).ToString() && DorduncuText.text == (((list_1[3]) % 9) + 1).ToString())
        {
            score += 1;
        }
        else if (zaman > 20 && (zaman < 30) && IlkText.text == (((list_1[4]) % 9) + 1).ToString() && IkinciText.text == (((list_1[5]) % 9) + 1).ToString() && UcuncuText.text == (((list_1[6]) % 9) + 1).ToString() && DorduncuText.text == (((list_1[7]) % 9) + 1).ToString())
        {
            score += 1;
        }
        else if (zaman > 35 && (zaman < 45) && IlkText.text == (((list_1[8]) % 9) + 1).ToString() && IkinciText.text == (((list_1[9]) % 9) + 1).ToString() && UcuncuText.text == (((list_1[10]) % 9) + 1).ToString() && DorduncuText.text == (((list_1[11]) % 9) + 1).ToString())
        {
            score += 1;
        }
        else if (zaman > 50 && (zaman < 60) && IlkText.text == (((list_1[12]) % 9) + 1).ToString() && IkinciText.text == (((list_1[13]) % 9) + 1).ToString() && UcuncuText.text == (((list_1[14]) % 9) + 1).ToString() && DorduncuText.text == (((list_1[15]) % 9) + 1).ToString())
        {
            score += 1;
        }
        else if (zaman > 65 && (zaman < 75) && IlkText.text == (((list_1[16]) % 9) + 1).ToString() && IkinciText.text == (((list_1[17]) % 9) + 1).ToString() && UcuncuText.text == (((list_1[18]) % 9) + 1).ToString() && DorduncuText.text == (((list_1[19]) % 9) + 1).ToString())
        {
            score += 1;
        }
        else if (zaman > 80 && (zaman < 90) && IlkText.text == (((list_1[20]) % 9) + 1).ToString() && IkinciText.text == (((list_1[21]) % 9) + 1).ToString() && UcuncuText.text == (((list_1[22]) % 9) + 1).ToString() && DorduncuText.text == (((list_1[23]) % 9) + 1).ToString())
        {
            score += 1;
        }
        else if (zaman > 95 && (zaman < 105) && IlkText.text == (((list_1[24]) % 9) + 1).ToString() && IkinciText.text == (((list_1[25]) % 9) + 1).ToString() && UcuncuText.text == (((list_1[26]) % 9) + 1).ToString() && DorduncuText.text == (((list_1[27]) % 9) + 1).ToString())
        {
            score += 1;
        }
        else if (zaman > 110 && (zaman < 120) && IlkText.text == (((list_1[28]) % 9) + 1).ToString() && IkinciText.text == (((list_1[29]) % 9) + 1).ToString() && UcuncuText.text == (((list_1[30]) % 9) + 1).ToString() && DorduncuText.text == (((list_1[31]) % 9) + 1).ToString())
        {
            score += 1;
        }
        else if (zaman > 125 && (zaman < 135) && IlkText.text == (((list_1[32]) % 9) + 1).ToString() && IkinciText.text == (((list_1[33]) % 9) + 1).ToString() && UcuncuText.text == (((list_1[34]) % 9) + 1).ToString() && DorduncuText.text == (((list_1[35]) % 9) + 1).ToString())
        {
            score += 1;
        }
        else if (zaman > 140 && (zaman < 150) && IlkText.text == (((list_1[36]) % 9) + 1).ToString() && IkinciText.text == (((list_1[37]) % 9) + 1).ToString() && UcuncuText.text == (((list_1[38]) % 9) + 1).ToString() && DorduncuText.text == (((list_1[39]) % 9) + 1).ToString())
        {
            score += 1;
        }
        else
        {
            score -= 1;
        }
    }
    public void carpi()
    {
        carpi_panel.SetActive(true);
    }
    public void yeni_bolum_z1()
    {
        SceneManager.LoadScene("k2");
    }
    public void tekrarla_z1()
    {
        SceneManager.LoadScene("z1");
    }
    public void eski_z1()
    {
        SceneManager.LoadScene("o1");
    }
    public void ana_menu()
    {
        SceneManager.LoadScene("anaekran");
    }
}
