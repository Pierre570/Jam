using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextHandler : MonoBehaviour
{
    public Text names;
    public Text prenom;
    public Text age;
    public Text ddn;
    public Text taille;
    public Text poids;
    public Text nationalite;
    public Text lieu;
    public Text profession;
    public Text permis;
    public Text numero;
    public Text solde;
    public Text banque;
    public Text source;
    public Text depot;
    public Text retrait;
    public Text inf1;
    public Text inf2;
    public Text pseudo;
    public Text abonnés;
    public Text likes;
    public Text certified;
    public GameObject accept;
    public static int i;
    public static int count;
    public int[] tab;
    public static int utile;
    public static int influence;
    public static int rich;
    public Sprite homme;
    public Sprite femme;
    public SpriteRenderer first;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        tab = randomNumber();
        Debug.Log(tab);
    }

    static int[] randomNumber()
    {
        int[] ret = new int[20];
        for (int i = 0; i < 20;)
        {
            int Numero = Random.Range(0, 20);
            bool found = false;
            for (int boule = 0; boule < i; boule++)
            {
                if (ret[boule] == Numero)
                {
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                if (i <= 19)
                    ret[i] = Numero;
                i++;
            }
        }
        for (int i = 0; i < 20;i++)
            Debug.Log(ret[i]);
        return ret;
    }

    public void changeText(int i)
    {
        var list = new List<Dictionary<string, object>>();
        list = reader.ReadCsvFile();
        names.GetComponent<UnityEngine.UI.Text>().text = list[i]["nom"].ToString();
        prenom.GetComponent<UnityEngine.UI.Text>().text = list[i]["prenom"].ToString();
        age.GetComponent<UnityEngine.UI.Text>().text = list[i]["age"].ToString();
        ddn.GetComponent<UnityEngine.UI.Text>().text = list[i]["date de naisance "].ToString();
        taille.GetComponent<UnityEngine.UI.Text>().text = list[i]["taille"].ToString();
        poids.GetComponent<UnityEngine.UI.Text>().text = list[i]["poids"].ToString();
        nationalite.GetComponent<UnityEngine.UI.Text>().text = list[i]["nationaliter"].ToString();
        lieu.GetComponent<UnityEngine.UI.Text>().text = list[i]["ville de naissance"].ToString();
        profession.GetComponent<UnityEngine.UI.Text>().text = list[i]["profession "].ToString();
        permis.GetComponent<UnityEngine.UI.Text>().text = list[i]["permis"].ToString();
        numero.GetComponent<UnityEngine.UI.Text>().text = list[i]["numero de compte"].ToString();
        solde.GetComponent<UnityEngine.UI.Text>().text = list[i]["solde"].ToString();
        banque.GetComponent<UnityEngine.UI.Text>().text = list[i]["nom de la banque"].ToString();
        source.GetComponent<UnityEngine.UI.Text>().text = list[i]["source de revenue"].ToString();
        depot.GetComponent<UnityEngine.UI.Text>().text = list[i]["date du dernier depo"].ToString();
        retrait.GetComponent<UnityEngine.UI.Text>().text = list[i]["date du dernier retrai"].ToString();
        inf1.GetComponent<UnityEngine.UI.Text>().text = list[i]["infraction1"].ToString();
        inf2.GetComponent<UnityEngine.UI.Text>().text = list[i]["infraction2"].ToString();
        pseudo.GetComponent<UnityEngine.UI.Text>().text = list[i]["pseudo"].ToString();
        abonnés.GetComponent<UnityEngine.UI.Text>().text = list[i]["abone"].ToString();
        likes.GetComponent<UnityEngine.UI.Text>().text = list[i]["like"].ToString();
        certified.GetComponent<UnityEngine.UI.Text>().text = list[i]["certifier"].ToString();
        if (list[i]["sex"].ToString() == "1")
        {
            first.sprite = femme;
        }
        else
        {
            first.sprite = homme;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (count < 11 && i < 21)
        {
            changeText(tab[i]);
        }
        else if (influence >= utile && influence >= rich)
        {
            SceneManager.LoadScene("influence end");
        }
        else if (utile >= influence && utile >= rich)
        {
            SceneManager.LoadScene("usefull end");
        }
        else if (rich >= influence && utile <= rich)
        {
            SceneManager.LoadScene("rich end");
        }
    }
}
