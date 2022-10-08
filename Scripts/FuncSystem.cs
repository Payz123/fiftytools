using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text;

public class FuncSystem : MonoBehaviour {

    [SerializeField] private Text doy_itog; //DayOfYear "итог"

    [SerializeField] private InputField vis_year; //Vis. year "год"
    [SerializeField] private Text vis_itog; //Vis. year "итог"

    [SerializeField] private Text rp_itog; //Ran.Pass "итог"
    private string Password = "Пароль не сгенерирован";
    
    public void DayOfYear() {//День в году (1 категория)
        DateTime today = DateTime.Today;
        doy_itog.text = today.DayOfYear + " день в году!";
    }

    public void Vis() {//Високосность года (1 категория)
        int year = int.Parse(vis_year.text);
        bool answer = DateTime.IsLeapYear(year);
        if(answer) 
        {
            vis_itog.text = vis_year.text + "г. високосный!";
        }else
        {
            vis_itog.text = vis_year.text + "г. не високосный";
        }
    }

    public void RandomPass() {//Рандомный пароль (2 категории)
        const string chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!-_=&?%$#.";
        StringBuilder sb = new StringBuilder();
        System.Random rnd = new System.Random();

        for (int i = 0; i < 16; i++)
        {
            int index = rnd.Next(chars.Length);
            sb.Append(chars[index]);
        }
 
        rp_itog.text = sb.ToString();
        Password = sb.ToString();
    }

    public void CopyPassword() {//Копирование рандомного пароля
        GUIUtility.systemCopyBuffer = Password;
    }

}