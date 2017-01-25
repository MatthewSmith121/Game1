using System.Collections.Generic;

public class Quest{

    public string Name { get; set; }
    public string Description { get; set; }
    public int Level { get; set; }
    public List<Employee> Assigned = new List<Employee>();
    // Based on player level and quest level, the quest will appear either as 
    // easy, medium, hard, or impossible
    
    public Quest()
    {
        Name = "Tutorial Quest";
        Description = "This is the first Quest";
        Level = 1;
    }

    public Quest(string name, string description, int level)
    {
        Name = name;
        Description = description;
        Level = level;
    }

    public void AssignEmployee(Employee emp)
    {
        Assigned.Add(emp);
        emp.Assigned = true;
    }

    public void UnassignEmployee(Employee emp)
    {
        Assigned.Remove(emp);
        emp.Assigned = false;
    }

    public int GetSuccess()
    {
        double modifier = 0;
        double defenceTotal;
        double levelTotal; 
        GetTotals(Assigned, out defenceTotal,  out levelTotal);
        
        foreach (Employee emp in Assigned)
        {
            // Success Modifier is based on the class stats, for example
            // a warrior is more based on strength than intelligence
            if (emp.Class == "Warrior")
            {
                modifier += emp.Strength * 1.25 + emp.Intelligence;
            }
            else if (emp.Class == "Wizard")
            {
                modifier += emp.Strength + emp.Intelligence * 1.25;
            }
            else
            {
                modifier += emp.Strength * 0.5 + emp.Intelligence * 0.5;
            }

            // Add in defence modifier portion
            modifier += (emp.Level / (levelTotal + Level)) * emp.Defence;

            // Add in attack modifier portion
            modifier += emp.Attack / Level;
        }
        int success = (int)((modifier / (Level * 500)) * 100);
        return (success >= 100) ? 100 : success;       
        //return (int)modifier / Level;
    }

    private void GetTotals(List<Employee> employees, out double defenceTotal, out double levelTotal)
    {
        defenceTotal = 0;
        levelTotal = 0;
        foreach (Employee emp in employees)
        {
            defenceTotal += emp.Defence;
            levelTotal += emp.Level;
        }
    }
}
