using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    // Start is called before the first frame update
    void Start()
    {
        changeText();
    }

    public void changeText()
    {
        var list = new List<Dictionary<string, object>>();
        list = reader.ReadCsvFile();
        Debug.Log(list[0]["poids"].ToString());
        names.GetComponent<UnityEngine.UI.Text>().text = list[0]["nom"].ToString();
        prenom.GetComponent<UnityEngine.UI.Text>().text = list[0]["prenom"].ToString();
        age.GetComponent<UnityEngine.UI.Text>().text = list[0]["age"].ToString();
        ddn.GetComponent<UnityEngine.UI.Text>().text = list[0]["date_de_naisance "].ToString();
        taille.GetComponent<UnityEngine.UI.Text>().text = list[0]["taille"].ToString();
        poids.GetComponent<UnityEngine.UI.Text>().text = list[0]["poids"].ToString();
        nationalite.GetComponent<UnityEngine.UI.Text>().text = list[0]["nationaliter"].ToString();
        lieu.GetComponent<UnityEngine.UI.Text>().text = list[0]["ville de naisance"].ToString();
        profession.GetComponent<UnityEngine.UI.Text>().text = list[0]["profession"].ToString();
        permis.GetComponent<UnityEngine.UI.Text>().text = list[0]["permis"].ToString();
        numero.GetComponent<UnityEngine.UI.Text>().text = list[0]["numero de compte"].ToString();
        solde.GetComponent<UnityEngine.UI.Text>().text = list[0]["solde"].ToString();
        banque.GetComponent<UnityEngine.UI.Text>().text = list[0]["nom de la banque"].ToString();
        source.GetComponent<UnityEngine.UI.Text>().text = list[0]["source de revenue"].ToString();
        depot.GetComponent<UnityEngine.UI.Text>().text = list[0]["date du dernier depo"].ToString();
        retrait.GetComponent<UnityEngine.UI.Text>().text = list[0]["date du dernier retrai"].ToString();
        inf1.GetComponent<UnityEngine.UI.Text>().text = list[0]["infraction1"].ToString();
        inf2.GetComponent<UnityEngine.UI.Text>().text = list[0]["infraction2"].ToString();
        pseudo.GetComponent<UnityEngine.UI.Text>().text = list[0]["pseudo"].ToString();
        abonnés.GetComponent<UnityEngine.UI.Text>().text = list[0]["abone"].ToString();
        likes.GetComponent<UnityEngine.UI.Text>().text = list[0]["like"].ToString();
        certified.GetComponent<UnityEngine.UI.Text>().text = list[0]["certifier"].ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
