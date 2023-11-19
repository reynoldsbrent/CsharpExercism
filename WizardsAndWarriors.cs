using System;

abstract class Character
{
    private string CharacterType;
    
    protected Character(string characterType)
    {
        this.CharacterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        return false;
    }

    public override string ToString()
    {
        return $"Character is a {CharacterType}";
    }
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
        return target.Vulnerable() ? 10 : 6;
    }
}

class Wizard : Character
{
    private bool IsSpellPrepared = false;

    public Wizard() : base("Wizard")
    {
    }

    public override int DamagePoints(Character target)
    {
        return IsSpellPrepared ? 12 : 3;
    }

    public override bool Vulnerable()
	{
		return !IsSpellPrepared;
	}

    public void PrepareSpell()
    {
        IsSpellPrepared = true;
    }
}
