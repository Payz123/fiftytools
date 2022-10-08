using UnityEngine;
using UnityEngine.UI;
using System;

public class Functions : MonoBehaviour
{
    [SerializeField] private InputField rn_ot; //Rand. Number "от"
    [SerializeField] private InputField rn_do; //Rand. Number "до"
    [SerializeField] private Text rn_itog; //Rand. Number "итог"

    [SerializeField] private InputField sn_ot; //Med. Number "от"
    [SerializeField] private InputField sn_do; //Med. Number "до"
    [SerializeField] private Text sn_itog; //Med. Number "итог"

    [SerializeField] private InputField ls_text; //Length s. "текст"
    [SerializeField] private Text ls_itog; //Length s. "итог"

    public void RandNumber() {//Рандомное число (2 категории)
        int rot = int.Parse(rn_ot.text);
        int rdo = int.Parse(rn_do.text);
        int itog = UnityEngine.Random.Range(rot, rdo+1);
        rn_itog.text = itog.ToString();
    }

    public void MediumNumber() {//Среднее число (1 категория)
        float sot = float.Parse(sn_ot.text);
        float sdo = float.Parse(sn_do.text);
        float itog = (sot+sdo)/2;
        sn_itog.text = itog.ToString();
    }

    public void Count() {//Количество символов (1 категория)
    int itog = (ls_text.text).Length;
    ls_itog.text = itog.ToString() + " символов";
    }
}
