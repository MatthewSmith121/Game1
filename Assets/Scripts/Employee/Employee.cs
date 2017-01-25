

public class Employee{

    public Employee()
    {

    }

    // Level 1 Employee
    public Employee(string name)
    {
        Name = name;
        Level = 1;
        Class = "Warrior";
        Assigned = false;
        baseStrength = 1;
        baseIntelligence = 1;
        baseDefence = 1;
        baseAttack = 1;
        baseHealth = 1;
        wl = new Sword();
        wr = new Weapon(Level);
        head = new Head();
        feet = new Feet();
        chest = new Chest();
        legs = new Legs();
        hands = new Hands();
        shoulders = new Shoulders();
        arms = new Armor(Level);
    }

    public string Name { get; set; }
    public int Level { get; set; }
    public string Class { get; set; }
    public bool Assigned { get; set; }

    // You can get stats, but can never set the actual stat value.
    // Base stats can be changed but not directly
    public int Strength { get { return getStrength(); } }
    public int Intelligence { get { return getIntelligence(); } }
    public int Defence { get { return getDefence(); } }
    public int Attack { get { return getAttack(); } }
    public int Health { get { return getHealth(); } }

    private int baseStrength;
    private int baseIntelligence;
    private int baseDefence;
    private int baseAttack;
    private int baseHealth;
    private Weapon wl;
    private Weapon wr;
    private Armor head;
    private Armor feet;
    private Armor chest;
    private Armor legs;
    private Armor hands;
    private Armor shoulders;
    private Armor arms;

    public Weapon WL
    {
        get
        {
            return wl;
        }

        set
        {
            if (value.Level <= Level)
            {
                wl = value;
            }
        }
    }

    public Weapon WR
    {
        get
        {
            return wr;
        }

        set
        {
            if (value.Level <= Level)
            {
                wr = value;
            }
        }
    }

    public Armor Head
    {
        get
        {
            return head;
        }

        set
        {
            if (value.Level <= Level)
            {
                head = value;
            }
        }
    }

    public Armor Feet
    {
        get
        {
            return feet;
        }

        set
        {
            if (value.Level <= Level)
            {
                feet = value;
            }
        }
    }

    public Armor Chest
    {
        get
        {
            return chest;
        }

        set
        {
            if (value.Level <= Level)
            {
                chest = value;
            }
        }
    }

    public Armor Legs
    {
        get
        {
            return legs;
        }

        set
        {
            if (value.Level <= Level)
            {
                legs = value;
            }
        }
    }

    public Armor Hands
    {
        get
        {
            return hands;
        }

        set
        {
            if (value.Level <= Level)
            {
                hands = value;
            }
        }
    }

    public Armor Shoulders
    {
        get
        {
            return shoulders;
        }

        set
        {
            if (value.Level <= Level)
            {
                shoulders = value;
            }
        }
    }

    public Armor Arms
    {
        get
        {
            return arms;
        }

        set
        {
            if (value.Level <= Level)
            {
                arms = value;
            }
        }
    }


    /// <summary>
    /// Gets the strength of the employee based on base stat and equipment.
    /// </summary>
    /// <returns></returns>
    private int getStrength()
    {
        return baseStrength + wl.Strength + wr.Strength
            + head.Strength + feet.Strength + chest.Strength + 
            legs.Strength + hands.Strength + shoulders.Strength + arms.Strength;
    }

    /// <summary>
    /// Gets the intelligence of the employee based on base stat and equipment.
    /// </summary>
    /// <returns></returns>
    private int getIntelligence()
    {
        return baseIntelligence + wl.Intelligence + wr.Intelligence
            + head.Intelligence + feet.Intelligence + chest.Intelligence +
            legs.Intelligence + hands.Intelligence + shoulders.Intelligence + arms.Intelligence;
    }

    /// <summary>
    /// Gets the defence of the employee based on base stat and armor (no weapons).
    /// </summary>
    /// <returns></returns>
    private int getDefence()
    {
        return baseDefence + head.Defence + feet.Defence + chest.Defence +
            legs.Defence + hands.Defence + shoulders.Defence + arms.Defence;
    }

    /// <summary>
    /// Gets the health of the employee based on base stat and equipment.
    /// </summary>
    /// <returns></returns>
    private int getHealth()
    {
        return baseHealth + wl.Health + wr.Health
            + head.Health + feet.Health + chest.Health +
            legs.Health + hands.Health + shoulders.Health + arms.Health;
    }

    /// <summary>
    /// Gets the strength of the employee based on base stat and weapons (no armor).
    /// </summary>
    /// <returns></returns>
    private int getAttack()
    {
        return baseAttack + wl.Attack + wr.Attack;
    }


}
