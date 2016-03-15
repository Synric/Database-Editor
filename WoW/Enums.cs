using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEditor.WoW
{
    [Flags]
    enum DynamicFlags : uint
    {
        None = 0,
        Lootable = 1,
        Track_Unit = 2,
        Tapped = 4,
        Tapped_By_Player = 8,
        SpecialInfo = 16,
        Dead = 32,
        Refer_A_Friend = 64,
        Tapped_By_All_Threat_List = 128,
        TOTAL = 255 // 11111111
    }
    
    [Flags]
    enum NPCFlags : uint
    {
        None = 0,
        Gossip = 1,
        QuestGiver = 2,
        Trainer = 16,
        TrainerClass = 32,
        TrainerProfession = 64,
        Vendor = 128,
        VendorAmmo = 256,
        VendorFood = 512,
        VendorPoison = 1024,
        VendorReagent = 2048,
        Repairer = 4096,
        FlightMaster = 8192,
        SpiritHealer = 16384,
        SpiritGuide = 32768,
        Innkeeper = 65536,
        Banker = 131072,
        Petitioner = 262144,
        TabardDesigner = 524288,
        Battlemaster = 1048576,
        Auctioneer = 2097152,
        StableMaster = 4194304,
        GuildBanker = 8388608,
        Spellclick = 16777216,
        Unknown = 33554432,
        Mailbox = 67108864
        //TOTAL = 
    }

    [Flags]
    enum ImmuneMasks : uint
    {
        None = 0,
        Charm = 1,
        Disoriented = 2,
        Disarm = 4,
        Distract = 8,
        Fear = 16,
        Grip = 32,
        Root = 64,
        Pacify = 128,
        Silence = 256,
        Sleep = 512,
        Snare = 1024,
        Stun = 2048,
        Freeze = 4096,
        Knockout = 8192,
        Bleed = 16384,
        Bandage = 32768,
        Polymorph = 65536,
        Banish = 131072,
        Shield = 262144,
        Shackle = 524288,
        Mount = 1048576,
        Infected = 2097152,
        Turn = 4194304,
        Horror = 8388608,
        Invulnerability = 16777216,
        Interrupt = 33554432,
        Daze = 67108864,
        Discovery = 134217728,
        Immune_Shield = 268435456,
        Sapped = 536870912,
        Enraged = 1073741824,
        TOTAL = 2147483647 // 1111111111111111111111111111111 = 31 length
    }

    [Flags]
    enum InhabitTypes : uint
    {
        None = 0,
        Ground = 1,
        Water = 2,
        All = 3,
        Air = 4,
    }

    [Flags]
    enum MovementTypes : uint
    {
        Stay = 0,
        Random = 1,
        Waypoint = 2
    }

    [Flags]
    enum Ranks : uint
    {
        None = 0,
        Elite = 1,
        RareElite = 2,
        WorldBoss = 3,
        Rare = 4,
    }

    [Flags]
    enum Classes : uint
    {
        None = 0,
        Warrior = 1,
        Paladin = 2,
        Hunter = 3,
        Rogue = 4,
        Priest = 5,
        DeathKnight = 6,
        Shaman = 7,
        Mage = 8,
        Warlock = 9,
        Druid = 11
    }

    [Flags]
    enum Races : uint
    {
        None = 0,
        Human = 1,
        Dwarf = 3,
        NightElf = 4,
        Gnome = 7,
        Draenei = 11,
        Orc = 2,
        Undead = 5,
        Tauren = 6,
        Troll = 8,
        BloodElf = 10
    }

    [Flags]
    enum TrainerTypes : uint
    {
        Class = 0,
        Mounts = 1,
        TradeSkills = 2,
        Pets = 3
    }

    [Flags]
    enum Types : uint
    {
        None = 0,
        Beast = 1,
        Dragonkin = 2,
        Demon = 3,
        Elemental = 4,
        Giant = 5,
        Undead = 6,
        Humanoid = 7,
        Critter = 8,
        Mechanical = 9,
        Unknown = 10,
        Totem = 11,
        NonCombatPet = 12,
        GasCloud = 13
    }
    
    [Flags]
    enum TypeFlags : uint
    {
        None = 0,
        Tameable = 1,
        Ghost = 2,
        Unk3 = 4,
        Unk4 = 8,
        Unk5 = 16,
        Unk6 = 32,
        Unk7 = 64,
        DeadInteract = 128,
        HerbLoot = 256,
        MiningLoot = 512,
        Unk11 = 1024,
        MountedCombat = 2048,
        AidPlayers = 4096,
        Unk14 = 8192,
        Unk15 = 16384,
        EngLoot = 32768,
        Exotic = 65536,
        Unk18 = 131072,
        Unk19 = 262144,
        Unk20 = 524288,
        Unk21 = 1048576,
        Unk22 = 2097152,
        Unk23 = 4194304,
        Unk24 = 8388608
    }

    [Flags]
    enum UnitFlags : uint
    {
        None = 0,
        Unk0 = 1,
        NonAttackable = 2,
        DisableMove = 4,
        PvPAttackable = 8,
        Rename = 16,
        Preparation = 32,
        Unk6 = 64,
        NotAttackable = 128,
        ImmuneToPC = 256,
        ImmuneToNPC = 512,
        Looting = 1024,
        PetInCombat = 2048,
        PvP = 4096,
        Silenced = 8192,
        Unk14 = 16384,
        Unk15 = 32768,
        Unk16 = 65536,
        Pacified = 131072,
        Stunned = 262144,
        InCombat = 524288,
        TaxiFlight = 1048576,
        Disarmed = 2097152,
        Confused = 4194304,
        Fleeing = 8388608,
        PlayerControlled = 16777216,
        NotSelectable = 33554432,
        Skinnable = 67108864,
        Mount = 134217728,
        Unk28 = 268435456,
        Unk29 = 536870912,
        Sheathe = 1073741824,
        Unk31 = 2147483648
    }

    [Flags]
    enum Reputations : uint
    {
        Hated = 0,
        Hostile = 1,
        Unfriendly = 2,
        Neutral = 3,
        Friendly = 4,
        Honored = 5,
        Revered = 6,
        Exalted = 7
    }

    /// Game Objects
    [Flags]
    enum GO_Flags : uint
    {
        None = 0,
        InUse = 1,
        Locked = 2,
        Untargetable = 4,
        Transport = 8,
        NotSelectable = 16,
        NoDespawn = 32,
        Damaged = 64,
        Destroyed = 128
    }
}
