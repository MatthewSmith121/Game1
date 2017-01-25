using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEditor;
using System.Collections;

public class BarracksPanel : MonoBehaviour {

    public Text Name;
    public Text Level;
    public Text Class;
    public Text Strength;
    public Text Intelligence;
    public Text Defence;
    public Text Attack;
    public Text Health;
    public Image Helmet;
    public Image Shoulders;
    public Image Chest;
    public Image Hands;
    public Image Legs;
    public Image Feet;
    public Image WeaponLeft;
    public Image WeaponRight;
    public Button Close;
    public GameObject modalPanelObject;

    private UnityAction closePanel;
    private static BarracksPanel barracksPanel;

    void Awake()
    {
        closePanel = new UnityAction(ClosePanel);
        Close.onClick.AddListener(closePanel);
    }

    void ClosePanel()
    {
        modalPanelObject.SetActive(false);
    }

    public static BarracksPanel Instance()
    {
        if (!barracksPanel)
        {
            barracksPanel = FindObjectOfType(typeof(BarracksPanel)) as BarracksPanel;
            if (!barracksPanel)
            {
                Debug.LogError("There needs to be one active ModalPanel script on a GameObject in your scene.");
            }
        }

        return barracksPanel;
    }

    public void CharacterSheet(Employee emp)
    {
        // Set all the values
        modalPanelObject.SetActive(true);
        Name.text = "Name: " + emp.Name;
        Level.text = "Level: " + emp.Level.ToString();
        Class.text = "Class: " + emp.Class;
        Strength.text = "Strength: " + emp.Strength.ToString();
        Intelligence.text = "Intelligence: " + emp.Intelligence.ToString();
        Defence.text = "Defence: " + emp.Defence.ToString();
        Attack.text = "Attack: " + emp.Attack.ToString();
        Health.text =  "Health: " + emp.Health.ToString();
        WeaponLeft.sprite = Resources.Load<Sprite>(emp.WL.Picture);
        Helmet.sprite = Resources.Load<Sprite>(emp.Head.Picture);
        Shoulders.sprite = Resources.Load<Sprite>(emp.Shoulders.Picture);
        Chest.sprite = Resources.Load<Sprite>(emp.Chest.Picture);
        Hands.sprite = Resources.Load<Sprite>(emp.Hands.Picture);
        Legs.sprite = Resources.Load<Sprite>(emp.Legs.Picture);
        Feet.sprite = Resources.Load<Sprite>(emp.Feet.Picture);

        // Set everything to active
        Name.gameObject.SetActive(true);
        Level.gameObject.SetActive(true);
        Class.gameObject.SetActive(true);
        Strength.gameObject.SetActive(true);
        Intelligence.gameObject.SetActive(true);
        Defence.gameObject.SetActive(true);
        Attack.gameObject.SetActive(true);
        Health.gameObject.SetActive(true);
        WeaponLeft.gameObject.SetActive(true);
        Helmet.gameObject.SetActive(true);
        Shoulders.gameObject.SetActive(true);
        Chest.gameObject.SetActive(true);
        Hands.gameObject.SetActive(true);
        Feet.gameObject.SetActive(true);
        Legs.gameObject.SetActive(true);
    }

}
