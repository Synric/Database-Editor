using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;
using DatabaseEditor.Database;
using DatabaseEditor.Editor.Shared;
using System.Collections.Generic;
using DatabaseEditor.Editor.Creature.Edit;
using DatabaseEditor.CreatureLocation;
using DatabaseEditor.Editor.Item.Edit;
using System.Drawing;

namespace DatabaseEditor.Editor.Item
{
    public partial class ItemControl : EditorControl
    {
        // Bindings
        BindingSource iTemplateBinding;

        // Tables
        item_template iTemplate;

        public ItemControl()
        {
            InitializeComponent();
        }

        public override void Initialize()
        {
            SetDataGridViewColumns(SearchDataGrid, new string[] { "entry", "name" });
            SetDataGridViewColumns(LootDataGrid, new string[] { "Entry", "Item", "Reference", "Chance", "QuestRequired", "LootMode", "GroupId", "MinCount", "MaxCount", "Comment" });
            SetDataGridViewColumns(DisenchantDataGrid, new string[] { "Entry", "Item", "Reference", "Chance", "QuestRequired", "LootMode", "GroupId", "MinCount", "MaxCount", "Comment" });
            SetDataGridViewColumns(ProspectingDataGrid, new string[] { "Entry", "Item", "Reference", "Chance", "QuestRequired", "LootMode", "GroupId", "MinCount", "MaxCount", "Comment" });
            SetDataGridViewColumns(MillingDataGrid, new string[] { "Entry", "Item", "Reference", "Chance", "QuestRequired", "LootMode", "GroupId", "MinCount", "MaxCount", "Comment" });
            SetDataGridViewColumns(InvolvedInTabStartsDataGrid, new string[] { "Id", "Title", "Level", "faction", "RewardOrRequiredMoney" });
            SetDataGridViewColumns(InvolvedInTabEndsDataGrid, new string[] { "Id", "Title", "Level", "faction", "RewardOrRequiredMoney" });

            // Combo boxs binding
            qualityBS.DataSource = new ComboBoxBasicDB[] {
                new ComboBoxBasicDB { Text = "Poor", Value = 0, ForeColor = Brushes.Gray },
                new ComboBoxBasicDB { Text = "Common", Value = 1, },
                new ComboBoxBasicDB { Text = "Uncommon", Value = 2, ForeColor = Brushes.Green },
                new ComboBoxBasicDB { Text = "Rare", Value = 3, ForeColor = Brushes.Blue },
                new ComboBoxBasicDB { Text = "Epic", Value = 4, ForeColor = Brushes.Purple },
                new ComboBoxBasicDB { Text = "Legendary", Value = 5, ForeColor = Brushes.Orange },
                new ComboBoxBasicDB { Text = "Artifact", Value = 6, ForeColor = Brushes.Red },
                new ComboBoxBasicDB { Text = "Bind to Account", Value = 7, ForeColor = Brushes.Gold }
            };

            EditBox_Quality.DifferentTextColor = true;
            EditBox_Quality.SelectedIndex = 1;

            classBS.DataSource = new ComboBoxBasicDB[] {
                new ComboBoxBasicDB { Text = "Consumable", Value = 0 },
                new ComboBoxBasicDB { Text = "Container", Value = 1 },
                new ComboBoxBasicDB { Text = "Weapon", Value = 2 },
                new ComboBoxBasicDB { Text = "Gem", Value = 3 },
                new ComboBoxBasicDB { Text = "Armor", Value = 4 },
                new ComboBoxBasicDB { Text = "Reagent", Value = 5 },
                new ComboBoxBasicDB { Text = "Projectile", Value = 6 },
                new ComboBoxBasicDB { Text = "Trade Goods", Value = 7 },
                new ComboBoxBasicDB { Text = "Generic", Value = 8 },
                new ComboBoxBasicDB { Text = "Recipe", Value = 9 },
                new ComboBoxBasicDB { Text = "Money", Value = 10 },
                new ComboBoxBasicDB { Text = "Quiver", Value = 11 },
                new ComboBoxBasicDB { Text = "Quest", Value = 12 },
                new ComboBoxBasicDB { Text = "Key", Value = 13 },
                new ComboBoxBasicDB { Text = "Permanent", Value = 14 },
                new ComboBoxBasicDB { Text = "Miscellaneous", Value = 15 },
                new ComboBoxBasicDB { Text = "Glyph", Value = 16 }
            };
            
            inventoryBS.DataSource = new ComboBoxBasicDB[] {
                new ComboBoxBasicDB { Text = "Non equipable", Value = 0 },
                new ComboBoxBasicDB { Text = "Head", Value = 1 },
                new ComboBoxBasicDB { Text = "Neck", Value = 2 },
                new ComboBoxBasicDB { Text = "Shoulder", Value = 3 },
                new ComboBoxBasicDB { Text = "Shirt", Value = 4 },
                new ComboBoxBasicDB { Text = "Chest", Value = 5 },
                new ComboBoxBasicDB { Text = "Waist", Value = 6 },
                new ComboBoxBasicDB { Text = "Legs", Value = 7 },
                new ComboBoxBasicDB { Text = "Feet", Value = 8 },
                new ComboBoxBasicDB { Text = "Wrists", Value = 9 },
                new ComboBoxBasicDB { Text = "Hands", Value = 10 },
                new ComboBoxBasicDB { Text = "Finger", Value = 11 },
                new ComboBoxBasicDB { Text = "Trinket", Value = 12 },
                new ComboBoxBasicDB { Text = "Weapon", Value = 13 },
                new ComboBoxBasicDB { Text = "Shield", Value = 14 },
                new ComboBoxBasicDB { Text = "Ranged", Value = 15 },
                new ComboBoxBasicDB { Text = "Back", Value = 16 },
                new ComboBoxBasicDB { Text = "Two-Hand", Value = 17 },
                new ComboBoxBasicDB { Text = "Bag", Value = 18 },
                new ComboBoxBasicDB { Text = "Tabard", Value = 19 },
                new ComboBoxBasicDB { Text = "Robe", Value = 20 },
                new ComboBoxBasicDB { Text = "Main hand", Value = 21 },
                new ComboBoxBasicDB { Text = "Off hand", Value = 22 },
                new ComboBoxBasicDB { Text = "Holdable", Value = 23 },
                new ComboBoxBasicDB { Text = "Ammo", Value = 24 },
                new ComboBoxBasicDB { Text = "Thrown", Value = 25 },
                new ComboBoxBasicDB { Text = "Ranged right", Value = 26 },
                new ComboBoxBasicDB { Text = "Quiver", Value = 27 },
                new ComboBoxBasicDB { Text = "Relic", Value = 28 }
            };

            repRankBS.DataSource = new ComboBoxBasicDB[] {
                new ComboBoxBasicDB { Text = "Hated", Value = 0 },
                new ComboBoxBasicDB { Text = "Hostile", Value = 1 },
                new ComboBoxBasicDB { Text = "Unfriendly", Value = 2 },
                new ComboBoxBasicDB { Text = "Neutral", Value = 3 },
                new ComboBoxBasicDB { Text = "Friendly", Value = 4 },
                new ComboBoxBasicDB { Text = "Honored", Value = 5 },
                new ComboBoxBasicDB { Text = "Revered", Value = 6 },
                new ComboBoxBasicDB { Text = "Exalted", Value = 7 }
            };
            
            ComboBoxBasicDB[] spellTriggers = new ComboBoxBasicDB[] {
                new ComboBoxBasicDB { Text = "Use", Value = 0 },
                new ComboBoxBasicDB { Text = "On Equip", Value = 1 },
                new ComboBoxBasicDB { Text = "Chance on Hit", Value = 2 },
                new ComboBoxBasicDB { Text = "Soulstone", Value = 4 },
                new ComboBoxBasicDB { Text = "Use with no delay", Value = 5 },
                new ComboBoxBasicDB { Text = "Learn Spell ID", Value = 6 }
            };

            spellTriggerBS.DataSource = spellTriggers;
            spellTriggerBS2.DataSource = spellTriggers;
            spellTriggerBS3.DataSource = spellTriggers;
            spellTriggerBS4.DataSource = spellTriggers;
            spellTriggerBS5.DataSource = spellTriggers;

            bondingBS.DataSource = new ComboBoxBasicDB[]
            {
                new ComboBoxBasicDB { Text = "No bounds", Value = 0 },
                new ComboBoxBasicDB { Text = "BoP", Value = 1 },
                new ComboBoxBasicDB { Text = "BoE", Value = 2 },
                new ComboBoxBasicDB { Text = "BoU", Value = 3 },
                new ComboBoxBasicDB { Text = "Quest item", Value = 4 },
                new ComboBoxBasicDB { Text = "Quest Item1", Value = 5 }
            };

            materialBS.DataSource = new ComboBoxBasicDB[]
            {
                new ComboBoxBasicDB { Text = "Consumables", Value = -1 },
                new ComboBoxBasicDB { Text = "Not Defined", Value = 0 },
                new ComboBoxBasicDB { Text = "Metal", Value = 1 },
                new ComboBoxBasicDB { Text = "Wood", Value = 2 },
                new ComboBoxBasicDB { Text = "Liquid", Value = 3 },
                new ComboBoxBasicDB { Text = "Jewelry", Value = 4 },
                new ComboBoxBasicDB { Text = "Chain", Value = 5 },
                new ComboBoxBasicDB { Text = "Plate", Value = 6 },
                new ComboBoxBasicDB { Text = "Cloth", Value = 7 },
                new ComboBoxBasicDB { Text = "Leather", Value = 8 }
            };

            sheathBS.DataSource = new ComboBoxBasicDB[]
            {
                new ComboBoxBasicDB { Text = "Two Handed Weapon", Value = 1 },
                new ComboBoxBasicDB { Text = "Staff", Value = 2 },
                new ComboBoxBasicDB { Text = "One Handed", Value = 3 },
                new ComboBoxBasicDB { Text = "Shield", Value = 4 },
                new ComboBoxBasicDB { Text = "Enchanter's Rod", Value = 5 },
                new ComboBoxBasicDB { Text = "Off hand", Value = 6 }
            };

            ComboBoxBasicDB[] statType = new ComboBoxBasicDB[] {
                new ComboBoxBasicDB { Text = "Mana", Value = 0 },
                new ComboBoxBasicDB { Text = "Health", Value = 1 },
                new ComboBoxBasicDB { Text = "Agility", Value = 2 },
                new ComboBoxBasicDB { Text = "Strength", Value = 4 },
                new ComboBoxBasicDB { Text = "Intellect", Value = 5 },
                new ComboBoxBasicDB { Text = "Spirit", Value = 6 },
                new ComboBoxBasicDB { Text = "Stamina", Value = 7 },/*
                new ComboBoxBasicDB { Text = "On Equip", Value = 8 },
                new ComboBoxBasicDB { Text = "Chance on Hit", Value = 9 },
                new ComboBoxBasicDB { Text = "Soulstone", Value = 10 },
                new ComboBoxBasicDB { Text = "Use with no delay", Value = 11 },*/
                new ComboBoxBasicDB { Text = "Defense", Value = 12 },
                new ComboBoxBasicDB { Text = "Dodge", Value = 13 },
                new ComboBoxBasicDB { Text = "Parry", Value = 14 },
                new ComboBoxBasicDB { Text = "Block rating", Value = 15 },
                new ComboBoxBasicDB { Text = "Hit melee", Value = 16 },
                new ComboBoxBasicDB { Text = "Hit ranged", Value = 17 },
                new ComboBoxBasicDB { Text = "Hit spell", Value = 18 },
                new ComboBoxBasicDB { Text = "Crit melee", Value = 19 },
                new ComboBoxBasicDB { Text = "Crit ranged", Value = 20 },
                new ComboBoxBasicDB { Text = "Crit spell", Value = 21 },
                new ComboBoxBasicDB { Text = "Hit taken melee", Value = 22 },
                new ComboBoxBasicDB { Text = "Hit taken ranged", Value = 23 },
                new ComboBoxBasicDB { Text = "Hit taken spell", Value = 24 },
                new ComboBoxBasicDB { Text = "Crit taken melee", Value = 25 },
                new ComboBoxBasicDB { Text = "Crit taken ranged", Value = 26 },
                new ComboBoxBasicDB { Text = "Crit taken spell", Value = 27 },
                new ComboBoxBasicDB { Text = "Haste melee", Value = 28 },
                new ComboBoxBasicDB { Text = "Haste ranged", Value = 29 },
                new ComboBoxBasicDB { Text = "Haste spell", Value = 30 },
                new ComboBoxBasicDB { Text = "Hit", Value = 31 },
                new ComboBoxBasicDB { Text = "Crit", Value = 32 },
                new ComboBoxBasicDB { Text = "Hit taken", Value = 33 },
                new ComboBoxBasicDB { Text = "Crit taken", Value = 34 },
                new ComboBoxBasicDB { Text = "Resilience", Value = 35 },
                new ComboBoxBasicDB { Text = "Haste", Value = 36 },
                new ComboBoxBasicDB { Text = "Expertise", Value = 37 },
                new ComboBoxBasicDB { Text = "Attack power", Value = 38 },
                new ComboBoxBasicDB { Text = "Ranged attack power", Value = 39 },
                new ComboBoxBasicDB { Text = "Feral attack power", Value = 40 },
                new ComboBoxBasicDB { Text = "Spell healing done", Value = 41 },
                new ComboBoxBasicDB { Text = "Spell damage done", Value = 42 },
                new ComboBoxBasicDB { Text = "Mana regen", Value = 43 },
                new ComboBoxBasicDB { Text = "Armor penetration", Value = 44 },
                new ComboBoxBasicDB { Text = "spell power", Value = 45 },
                new ComboBoxBasicDB { Text = "Health regen", Value = 46 },
                new ComboBoxBasicDB { Text = "Spell penetration", Value = 47 },
                new ComboBoxBasicDB { Text = "Block value", Value = 48 }
            };

            statBS.DataSource = statType;
            statBS2.DataSource = statType;
            statBS3.DataSource = statType;
            statBS4.DataSource = statType;
            statBS5.DataSource = statType;
            statBS6.DataSource = statType;
            statBS7.DataSource = statType;
            statBS8.DataSource = statType;
            statBS9.DataSource = statType;
            statBS10.DataSource = statType;

            // Bindings
            iTemplate = new item_template(true);

            iTemplateBinding = new BindingSource();
            iTemplateBinding.DataSource = iTemplate;
            iTemplateBinding.ReflectionBinding(this, "EditBox_");
        }

        public override IButtonControl AcceptButton
        {
            get
            {
                if (ItemTab.SelectedTab == SearchPage)
                    return BtnSearch;
                else if (ItemTab.SelectedTab == EditPage)
                    return BtnEditCode;
                else if (ItemTab.SelectedTab == LootPage)
                    return BtnLootCode;
                else if (ItemTab.SelectedTab == DisenchantPage)
                    return BtnLootCode;
                else if (ItemTab.SelectedTab == ProspectingPage)
                    return BtnProspectingCode;
                else if (ItemTab.SelectedTab == MillingPage)
                    return BtnLootCode;
                else if (ItemTab.SelectedTab == ReferencePage)
                    return BtnLootCode;
                else if (ItemTab.SelectedTab == CodePage)
                    return BtnCodeExecute;

                return null;
            }
        }

        /// Item search
        void SearchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchEntry.Text) && string.IsNullOrWhiteSpace(SearchName.Text) && string.IsNullOrWhiteSpace(SearchItemLevel.Text))
            {
                MessageBox.Show("Need to add value to one of column!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            IQueryable<item_template> query = world.item_template;

            if (!string.IsNullOrWhiteSpace(SearchEntry.Text))
                query = query.Where(x => x.entry.ToString() == SearchEntry.Text);
            if (!string.IsNullOrWhiteSpace(SearchName.Text))
                query = query.Where(x => x.name.Contains(SearchName.Text.Replace("'", "''")));
            if (!string.IsNullOrWhiteSpace(SearchItemLevel.Text))
                query = query.Where(x => x.ItemLevel == Convert.ToInt32(SearchItemLevel.Text));

            var result = query.Select(x => new { x.entry, x.name }).ToList();

            SearchDataGrid.Load(result);

            var result2 = query.Select(x => new { x.Quality }).ToList();

            // Color
            for(int i = 0; i < result2.Count; i++)
            {
                for (int j = 0; j < SearchDataGrid.ColumnCount; j++)
                {
                    DataGridViewCell cell = SearchDataGrid.Rows[i].Cells[j];

                    switch (result2[i].Quality)
                    {
                        case 0:
                            cell.Style.ForeColor = Color.Gray;
                            break;

                        case 1:
                            cell.Style.ForeColor = Color.Black;
                            break;

                        case 2:
                            cell.Style.ForeColor = Color.Green;
                            break;

                        case 3:
                            cell.Style.ForeColor = Color.Blue;
                            break;

                        case 4:
                            cell.Style.ForeColor = Color.Purple;
                            break;

                        case 5:
                            cell.Style.ForeColor = Color.Orange;
                            break;

                        case 6:
                            cell.Style.ForeColor = Color.Red;
                            break;

                        case 7:
                            cell.Style.ForeColor = Color.Gold;
                            break;
                    }
                }
            }
        }

        void SearchDataGrid_DoubleClick(object sender, EventArgs e)
        {
            if (SearchDataGrid.Rows.Count < 1)
                return;

            int query_id = Convert.ToInt32(SearchDataGrid.Rows[SearchDataGrid.CurrentCell.RowIndex].Cells[0].Value.ToString());

            //// EDIT PAGE
            item_template query = world.item_template.Where(x => x.entry == query_id).Single();

            iTemplate = query;
            iTemplateBinding.DataSource = iTemplate;
            
            // Loot
            var query_loot = world.item_loot_template.Where(x => x.Entry == query_id).Select(x => new { x.Entry, x.Item, x.Reference, x.Chance, x.QuestRequired, x.LootMode, x.GroupId, x.MinCount, x.MaxCount, x.Comment }).ToList();

            LootDataGrid.Load(query_loot);

            // Disenchant
            /*var query_disenchant = world.disenchant_loot_template.Where(x => x.Entry == query.d).Select(x => new { x.Entry, x.Item, x.Reference, x.Chance, x.QuestRequired, x.LootMode, x.GroupId, x.MinCount, x.MaxCount, x.Comment }).ToList();

            DisenchantDataGrid.Load(query_disenchant);*/

            // Prospecting
            var query_prospecting = world.prospecting_loot_template.Where(x => x.Entry == query_id).Select(x => new { x.Entry, x.Item, x.Reference, x.Chance, x.QuestRequired, x.LootMode, x.GroupId, x.MinCount, x.MaxCount, x.Comment }).ToList();

            ProspectingDataGrid.Load(query_prospecting);

            // Milling
            var query_milling = world.milling_loot_template.Where(x => x.Entry == query_id).Select(x => new { x.Entry, x.Item, x.Reference, x.Chance, x.QuestRequired, x.LootMode, x.GroupId, x.MinCount, x.MaxCount, x.Comment }).ToList();

            MillingDataGrid.Load(query_milling);

            // Reference
            List<int> references = new List<int>();

            foreach (var loot in query_loot)
                references.Add(loot.Reference);

            foreach (var prospecting in query_prospecting)
                references.Add(prospecting.Reference);

            foreach (var milling in query_milling)
                references.Add(milling.Reference);

            var query_reference = world.reference_loot_template.Where(x => references.Any(id => id == x.Entry)).Select(x => new { x.Entry, x.Item, x.Reference, x.Chance, x.QuestRequired, x.LootMode, x.GroupId, x.MinCount, x.MaxCount, x.Comment }).ToList();

            MillingDataGrid.Load(query_milling);

            // Enchantment


            // Looted from
            

            ItemTab.SelectedTab = EditPage;
        }

        void SearchCopyButton_Click(object sender, EventArgs e)
        {
            if (SearchDataGrid.Rows.Count == 0)
            {
                MessageBox.Show("Error: Search data are empty! Search first for any creature and select row, after use this button again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            int query_id = Convert.ToInt32(SearchDataGrid.Rows[SearchDataGrid.CurrentCell.RowIndex].Cells["Entry"].Value.ToString());

            if (query_id.ToString() == null)
            {
                MessageBox.Show("Error: You haven't selected row!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            item_template query = world.item_template.Where(x => x.entry == query_id).SingleOrDefault();

            Copy copyItem = new Copy("Copy Item");

            if (copyItem.ShowDialog() != DialogResult.OK)
                return;

            iTemplate = query;
            iTemplateBinding.DataSource = iTemplate;

            EditBox_entry.Text = copyItem.Entry.ToString();

            ItemTab.SelectedTab = EditPage;
        }

        void EditCodeButton_Click(object sender, EventArgs e)
        {
            if (CodeBox.Text == String.Empty)
                BtnCodeExecute.Enabled = true;

            CodeBox.Text += $"{DatabaseHelper.Insert(iTemplate)}\n\n";

            ItemTab.SelectedTab = CodePage;
        }

        void BtnEditSpell1_Click(object sender, EventArgs e)
        {
            TrainerSpell spell = new TrainerSpell();

            if (spell.ShowDialog() == DialogResult.OK)
                EditBox_spellid_1.Text = spell.ToString();
        }

        void BtnEditSpell2_Click(object sender, EventArgs e)
        {
            TrainerSpell spell = new TrainerSpell();

            if (spell.ShowDialog() == DialogResult.OK)
                EditBox_spellid_2.Text = spell.ToString();
        }

        void BtnEditSpell3_Click(object sender, EventArgs e)
        {
            TrainerSpell spell = new TrainerSpell();

            if (spell.ShowDialog() == DialogResult.OK)
                EditBox_spellid_3.Text = spell.ToString();
        }

        void BtnEditSpell4_Click(object sender, EventArgs e)
        {
            TrainerSpell spell = new TrainerSpell();

            if (spell.ShowDialog() == DialogResult.OK)
                EditBox_spellid_4.Text = spell.ToString();
        }

        void BtnEditSpell5_Click(object sender, EventArgs e)
        {
            TrainerSpell spell = new TrainerSpell();

            if (spell.ShowDialog() == DialogResult.OK)
                EditBox_spellid_5.Text = spell.ToString();
        }

        void BtnEditReqSpell_Click(object sender, EventArgs e)
        {
            TrainerSpell spell = new TrainerSpell();

            if (spell.ShowDialog() == DialogResult.OK)
                EditBox_requiredspell.Text = spell.ToString();
        }

        void BtnEditRepFaction_Click(object sender, EventArgs e)
        {
            Faction faction = new Faction();

            if (faction.ShowDialog() == DialogResult.OK)
                EditBox_RequiredReputationFaction.Text = faction.ToString();
        }

        void BtnEditMap_Click(object sender, EventArgs e)
        {
            Map map = new Map();

            if (map.ShowDialog() == DialogResult.OK)
                EditBox_Map.Text = map.ToString();
        }

        void BtnEditTotem_Click(object sender, EventArgs e)
        {
            Totem totem = new Totem();

            if (totem.ShowDialog() == DialogResult.OK)
                EditBox_TotemCategory.Text = totem.ToString();
        }

        void BtnEditFlags_Click(object sender, EventArgs e)
        {
            int currFlags = string.IsNullOrWhiteSpace(EditBox_Flags.Text) ? 0 : Convert.ToInt32(EditBox_Flags.Text);

            ItemFlags flags = new ItemFlags(currFlags);

            if (flags.ShowDialog() == DialogResult.OK)
                EditBox_Flags.Text = flags.ToString();
        }

        void BtnEditLanguage_Click(object sender, EventArgs e)
        {
            Language language = new Language();

            if (language.ShowDialog() == DialogResult.OK)
                EditBox_LanguageID.Text = language.ToString();
        }

        void BtnEditPageMaterial_Click(object sender, EventArgs e)
        {
            PageMaterial pMaterial = new PageMaterial();

            if (pMaterial.ShowDialog() == DialogResult.OK)
                EditBox_PageMaterial.Text = pMaterial.ToString();
        }

        void BtnEditHoliday_Click(object sender, EventArgs e)
        {
            Holiday holiday = new Holiday();

            if (holiday.ShowDialog() == DialogResult.OK)
                EditBox_HolidayId.Text = holiday.ToString();
        }

        void BtnEditReqSkill_Click(object sender, EventArgs e)
        {
            SkillLine skill = new SkillLine();

            if (skill.ShowDialog() == DialogResult.OK)
                EditBox_RequiredSkill.Text = skill.ToString();
        }

        void BtnEditClass_Click(object sender, EventArgs e)
        {
            int currFlags = string.IsNullOrWhiteSpace(EditBox_AllowableClass.Text) ? -1 : Convert.ToInt32(EditBox_AllowableClass.Text);

            Classes classes = new Classes(currFlags);

            if (classes.ShowDialog() == DialogResult.OK)
                EditBox_AllowableClass.Text = classes.ToString();
        }

        void BtnEditRaces_Click(object sender, EventArgs e)
        {
            int currFlags = string.IsNullOrWhiteSpace(EditBox_AllowableRace.Text) ? -1 : Convert.ToInt32(EditBox_AllowableRace.Text);

            Races races = new Races(currFlags);

            if (races.ShowDialog() == DialogResult.OK)
                EditBox_AllowableRace.Text = races.ToString();
        }

        //// Item - Loot \\\\
        string loot_delete = String.Empty;

        void LootItemButton_Click(object sender, EventArgs e)
        {
            LootDialog(LootDataGrid, 1);
        }

        void LootDeleteLineButton_Click(object sender, EventArgs e)
        {
            DeleteLine(LootDataGrid, loot_delete, "-- Item Loot : delete\nDELETE FROM `item_loot_template` WHERE `entry`", "DELETE FROM `item_loot_template` WHERE `entry`");
        }

        void LootCodeButton_Click(object sender, EventArgs e)
        {
            string sql = CodeGeneration(loot_delete, LootDataGrid, "`item_loot_template` (`Entry`, `Item`, `Reference`, `Chance`, `QuestRequired`, `LootMode`, `GroupID`, `MinCount`, `MaxCount`, `Comment`) VALUES(`{0}`, `{1}`, `{2}`, `{3}`, `{4}`, `{5}`, `{6}`, `{7}`, `{8}`, `{9}`);\n");

            CodeBox.Text += $"-- Item Loot: INSERT code\"{sql}\n";
            BtnCodeExecute.Enabled = true;

            ItemTab.SelectedTab = CodePage;
        }

        void LootReloadButton_Click(object sender, EventArgs e)
        {
            var query_loot = world.item_loot_template.Where(x => x.Entry.ToString() == EditBox_entry.ToString()).Select(x => new { x.Entry, x.Item, x.Reference, x.Chance, x.QuestRequired, x.LootMode, x.GroupId, x.MinCount, x.MaxCount, x.Comment }).ToList();

            LootDataGrid.Load(query_loot);
        }

        //// Item - Code \\\\
        void CodeBox_TextChanged(object sender, EventArgs e)
        {
            BtnCodeExecute.Enabled = CodeBox.Text == String.Empty ? false : true;
        }

        void CodeExecuteButton_Click(object sender, EventArgs e)
        {
            CodeExecute(CodeBox.Text, BtnCodeExecute);
        }

        void CodeCopyButton_Click(object sender, EventArgs e)
        {
            CodeCopy(CodeBox.Text);
        }

        void CodeSaveButton_Click(object sender, EventArgs e)
        {
            CodeSave(CodeBox.Text);
        }
    }
}
