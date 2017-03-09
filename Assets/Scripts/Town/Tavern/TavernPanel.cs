using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class TavernPanel : MonoBehaviour {

    public Text Name;
    public Text Level;
    public Text Class;
    public Text Strength;
    public Text Intelligence;
    public Text Defence;
    public Text Attack;
    public Text Health;
    public Button Close;
    public Button Hire;
    public GameObject modalPanelObject;
    public Tavern tavern;

    private UnityAction closePanel;
    private UnityAction hireEmployee;
    private static TavernPanel tavernPanel;
    private int activePatron = -1;

    void Awake()
    {
        closePanel = new UnityAction(ClosePanel);
        Close.onClick.AddListener(closePanel);
        hireEmployee = new UnityAction(Hire_Click);
        Hire.onClick.AddListener(hireEmployee);
    }

    void ClosePanel()
    {
        modalPanelObject.SetActive(false);
    }

    void Hire_Click()
    {
        tavern.HireEmployee(activePatron);
    }

    public static TavernPanel Instance()
    {
        if (!tavernPanel)
        {
            tavernPanel = FindObjectOfType(typeof(TavernPanel)) as TavernPanel;
            if (!tavernPanel)
            {
                Debug.LogError("There needs to be one active ModalPanel script on a GameObject in your scene.");
            }
        }

        return tavernPanel;
    }

    public void CharacterSheet(Employee emp, int patronId)
    {
        // Set active patron to patronId (the index in the Patron array)
        activePatron = patronId;

        // Set all the values
        modalPanelObject.SetActive(true);
        Name.text = "Name: " + emp.Name;
        Level.text = "Level: " + emp.Level.ToString();
        Class.text = "Class: " + emp.Class;
        Strength.text = "Strength: " + emp.Strength.ToString();
        Intelligence.text = "Intelligence: " + emp.Intelligence.ToString();
        Defence.text = "Defence: " + emp.Defence.ToString();
        Attack.text = "Attack: " + emp.Attack.ToString();
        Health.text = "Health: " + emp.Health.ToString();

        // Set everything to active
        Name.gameObject.SetActive(true);
        Level.gameObject.SetActive(true);
        Class.gameObject.SetActive(true);
        Strength.gameObject.SetActive(true);
        Intelligence.gameObject.SetActive(true);
        Defence.gameObject.SetActive(true);
        Attack.gameObject.SetActive(true);
        Health.gameObject.SetActive(true);
    }
}
