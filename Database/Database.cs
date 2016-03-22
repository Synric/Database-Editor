using System.Data.Entity;

namespace DatabaseEditor.Database
{
    public partial class WorldDatabase : DbContext
    {
        public WorldDatabase(string connectionString) : base(connectionString)
        {
        }
    }

    // todo
    // char, auth




    /// Tables extensions
    public partial class creature_template
    {
        public creature_template()
        {
        }

        public creature_template(bool template = false)
        {
            if(template)
            {
                entry = 98765;
                name = "Name";
                subname = "Subname";
                Health_mod = Mana_mod = Mana_mod_extra = Armor_mod = RegenHealth = 1;
                exp = exp_unk = 3;
                scale = HoverHeight = 1;
                speed_walk = 1;
                speed_run = 1.14286f;
                faction = 35;
                type = 7;
                mindmg = maxdmg = 10;
                dmg_multiplier = 1;
                baseattacktime = 1000;
                InhabitType = 3;
            }
        }
    }

    public partial class gameobject_template
    {
        public gameobject_template()
        {
        }

        public gameobject_template(bool template = false)
        {
            if(template)
            {
                entry = 98765;
                name = "GO Name";
                size = 1.0f;
                VerifiedBuild = 15595;
            }
        }
    }

    public partial class item_template
    {
        public item_template()
        {
        }

        public item_template(bool template = false)
        {
            if (template)
            {
                entry = 98765;
                name = "Item Name";
                maxcount = BuyCount = 1;
                stackable = 1;
                delay = 1000;
                AllowableClass = AllowableRace = -1;
                WDBVerified = 15595;
            }
        }
    }
}
