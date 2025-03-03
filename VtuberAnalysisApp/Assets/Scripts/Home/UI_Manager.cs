using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class UI_Manager : MonoBehaviour
{
    public List<GameObject> buttons_list;
    private string buttons_name;
    private Button button;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i = 0; i < buttons_list.Count; i++)
        {
            button = buttons_list[i].GetComponent<Button>();
            buttons_name = buttons_list[i].name;
            switch(buttons_name)
            {
                case "Vtuber_Manage":
                    button.onClick.AddListener(Vtuber_Manage_Onclick);
                    break;
                case "Sheet_Manage":
                    button.onClick.AddListener(Sheet_Manage_Onclick);
                    break;
                case "DB_Manage":
                    button.onClick.AddListener(DB_Manage_Onclick);
                    break;
                case "Analysis":
                    button.onClick.AddListener(Analysis_Onclick);
                    break;
            }
        }
    }

    private void Vtuber_Manage_Onclick()
    {
        Debug.Log("Vtuber_Manage_Onclick()");
    }

    private void Sheet_Manage_Onclick()
    {
        Debug.Log("Sheet_Manage_Onclick()");
    }

    private void DB_Manage_Onclick()
    {
        Debug.Log("DB_Manage_Onclick()");
    }

    private void Analysis_Onclick()
    {
        Debug.Log("Analysis_Onclick()");
    }
}
