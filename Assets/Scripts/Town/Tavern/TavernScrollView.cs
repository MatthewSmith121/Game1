using UnityEngine;

public class TavernScrollView : MonoBehaviour {

    public GameObject Button_Template;
    public Tavern tavern;

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < tavern.Patrons.Count; i++)
        {
            GameObject go = Instantiate(Button_Template) as GameObject;
            go.SetActive(true);
            TavernScrollButton TB = go.GetComponent<TavernScrollButton>();
            TB.SetName(tavern.Patrons[i], i);
            go.transform.SetParent(Button_Template.transform.parent);
        }
    }

    public void ButtonClicked(Employee emp, int patronId)
    {
        Debug.Log(emp.Name + " button clicked.");
        TavernPanel tp = TavernPanel.Instance();
        tp.CharacterSheet(emp, patronId);
    }
}
