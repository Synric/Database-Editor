using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;

namespace DatabaseEditor.Creature
{
    public partial class CreatureControl : EditorControl
    {
        // Bindings
        BindingSource cTemplateBinding;
        BindingSource cEquipTemplateBinding;
        BindingSource cTemplateAddonBinding;
        BindingSource cAddonBinding;
        BindingSource cOnKillReputationBinding;

        // Tables
        creature_template cTemplate;
        creature_equip_template cEquipTemplate;
        creature_template_addon cTemplateAddon;
        creature_addon cAddon;
        creature_onkill_reputation cOnKillReputation;

        public CreatureControl()
        {
            InitializeComponent();
        }

        public override void Initialize()
        {
            SetDataGridViewColumns(SearchDataGrid, new string[] { "entry", "name", "subname", "minlevel", "maxlevel", "npcflag" });
            SetDataGridViewColumns(LocationDataGrid, new string[] { "guid", "id", "map", "spawnMask", "phaseMask", "modelid", "equipment_id", "position_x", "position_y", "position_z", "orientation", "spawntimesecs", "spawndist", "currentwaypoint", "curhealth", "curmana", "MovementType", "npcflag", "unit_flags", "dynamicflags" });
            SetDataGridViewColumns(ModelInfoDataGrid, new string[] { "modelid", "bounding_radius", "combat_reach", "gender", "modelid_other_gender" });
            SetDataGridViewColumns(LootDataGrid, new string[] { "Entry", "Item", "Reference", "Chance", "QuestRequired", "LootMode", "GroupId", "MinCount", "MaxCount", "Comment" });
            SetDataGridViewColumns(PickPocketLootDataGrid, new string[] { "Entry", "Item", "Reference", "Chance", "QuestRequired", "LootMode", "GroupId", "MinCount", "MaxCount", "Comment" });
            SetDataGridViewColumns(SkinningLootDataGrid, new string[] { "Entry", "Item", "Reference", "Chance", "QuestRequired", "LootMode", "GroupId", "MinCount", "MaxCount", "Comment" });
            SetDataGridViewColumns(InvolvedInTabStartsDataGrid, new string[] { "Id", "Title", "Level", "faction", "RewardOrRequiredMoney" });
            SetDataGridViewColumns(InvolvedInTabEndsDataGrid, new string[] { "Id", "Title", "Level", "faction", "RewardOrRequiredMoney" });
            SetDataGridViewColumns(SmartAIDataGrid, new string[] { "entryorguid", "source_type", "id", "link", "event_type", "event_phase_mask", "event_chance", "event_flags", "event_param1", "event_param2", "event_param3", "event_param4", "action_type", "action_param1", "action_param2", "action_param3", "action_param4", "action_param5", "action_param6", "target_type", "target_param1", "target_param2", "target_param3", "target_x", "target_y", "target_z", "target_o", "comment" });

            // Bindings
            cTemplate = new creature_template(true);
            cEquipTemplate = new creature_equip_template();
            cTemplateAddon = new creature_template_addon();
            cAddon = new creature_addon();
            cOnKillReputation = new creature_onkill_reputation();

            cTemplateBinding = new BindingSource();
            cTemplateBinding.DataSource = cTemplate;
            cTemplateBinding.ReflectionBinding(this, "EditBox_");

            cEquipTemplateBinding = new BindingSource();
            cEquipTemplateBinding.DataSource = cEquipTemplate;
            cEquipTemplateBinding.ReflectionBinding(this, "EquipTemplateBox_");

            cTemplateAddonBinding = new BindingSource();
            cTemplateAddonBinding.DataSource = cTemplateAddon;
            cTemplateAddonBinding.ReflectionBinding(this, "TemplateAddonBox_");

            cAddonBinding = new BindingSource();
            cAddonBinding.DataSource = cAddon;
            cAddonBinding.ReflectionBinding(this, "AddonBox_");

            cOnKillReputationBinding = new BindingSource();
            cOnKillReputationBinding.DataSource = cOnKillReputation;
            cOnKillReputationBinding.ReflectionBinding(this, "OKRBox_");
        }

        public IButtonControl AcceptButton
        {
            get
            {
                if (CreatureTab.SelectedTab == SearchPage)
                    return BtnSearch;
                else if (CreatureTab.SelectedTab == EditPage)
                    return BtnEditCode;
                else if (CreatureTab.SelectedTab == LocationPage)
                    return BtnLocationCode;
                else if (CreatureTab.SelectedTab == ModelInfoPage)
                    return BtnModelInfoCode;
                else if (CreatureTab.SelectedTab == LootPage)
                    return BtnLootCode;
                else if (CreatureTab.SelectedTab == PickPocketPage)
                    return BtnPickPocketLootCode;
                else if (CreatureTab.SelectedTab == SkinningPage)
                    return BtnSkinningLootCode;
                else if (CreatureTab.SelectedTab == OtherPage)
                    return BtnOtherCode;
                else if (CreatureTab.SelectedTab == SmartAIPage)
                    return BtnSmartAICode;
                else if (CreatureTab.SelectedTab == CodePage)
                    return BtnCodeExecute;

                return null;
            }
        }
        
        /// Creature search
        void SearchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchEntry.Text) && string.IsNullOrWhiteSpace(SearchName.Text) && string.IsNullOrWhiteSpace(SearchSubName.Text))
            {
                MessageBox.Show("Need to add value to one of column!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            IQueryable<creature_template> query = world.creature_template;

            if (!string.IsNullOrWhiteSpace(SearchEntry.Text))
                query = query.Where(x => x.entry.ToString() == SearchEntry.Text);
            if (!string.IsNullOrWhiteSpace(SearchName.Text))
                query = query.Where(x => x.name.Contains(SearchName.Text.Replace("'", "''")));
            if (!string.IsNullOrWhiteSpace(SearchSubName.Text))
                query = query.Where(x => x.subname.Contains(SearchSubName.Text.Replace("'", "''")));

            var result = query.Select(x => new { x.entry, x.name, x.subname, x.minlevel, x.maxlevel, x.npcflag }).ToList();

            SearchDataGrid.Load(result);
        }

        void SearchDataGrid_DoubleClick(object sender, EventArgs e)
        {
            if (SearchDataGrid.Rows.Count < 1)
                return;

            int query_id = Convert.ToInt32(SearchDataGrid.Rows[SearchDataGrid.CurrentCell.RowIndex].Cells[0].Value.ToString());

            //// EDIT PAGE
            creature_template query = world.creature_template.Where(x => x.entry == query_id).Single();

            cTemplate = query;
            cTemplateBinding.DataSource = cTemplate;

            // Location
            var query_location = world.creature.Where(x => x.id == query_id).Select(x => new { x.guid, x.id, x.map, x.position_x, x.position_y, x.position_z, x.orientation, x.spawnMask, x.phaseMask, x.modelid, x.equipment_id, x.spawntimesecs, x.spawndist, x.currentwaypoint, x.curhealth, x.curmana, x.MovementType, x.npcflag, x.unit_flags, x.dynamicflags }).ToList();

            LocationDataGrid.Load(query_location);

            // Model info
            var query_modelInfo = world.creature_model_info.Where(x => (new string[] { EditBox_modelid1.Text, EditBox_modelid2.Text, EditBox_modelid3.Text, EditBox_modelid4.Text }).Contains(x.modelid.ToString())).Select(x => new { x.modelid, x.bounding_radius, x.combat_reach, x.gender, x.modelid_other_gender }).ToList();

            ModelInfoDataGrid.Load(query_modelInfo);

            // Loot
            var query_loot = world.creature_loot_template.Where(x => x.Entry.ToString() == EditBox_lootid.Text).Select(x => new { x.Entry, x.Item, x.Reference, x.Chance, x.QuestRequired, x.LootMode, x.GroupId, x.MinCount, x.MaxCount, x.Comment }).ToList();

            LootDataGrid.Load(query_loot);

            // Pick pocket
            var query_pickPocket = world.pickpocketing_loot_template.Where(x => x.Entry.ToString() == EditBox_pickpocketloot.Text).Select(x => new { x.Entry, x.Item, x.Reference, x.Chance, x.QuestRequired, x.LootMode, x.GroupId, x.MinCount, x.MaxCount, x.Comment }).ToList();

            PickPocketLootDataGrid.Load(query_pickPocket);

            // Skinning
            var query_skinning = world.skinning_loot_template.Where(x => x.Entry.ToString() == EditBox_skinloot.Text).Select(x => new { x.Entry, x.Item, x.Reference, x.Chance, x.QuestRequired, x.LootMode, x.GroupId, x.MinCount, x.MaxCount, x.Comment }).ToList();

            SkinningLootDataGrid.Load(query_skinning);

            // Equip template
            var query_equip = world.creature_equip_template.Where(x => x.entry.ToString() == EditBox_equipment_id.Text).SingleOrDefault();//.Select(x => new { x.entry, x.id, x.itemEntry1, x.itemEntry2, x.itemEntry3 }).SingleOrDefault();

            cEquipTemplate = query_equip ?? new creature_equip_template();
            cEquipTemplateBinding.DataSource = cEquipTemplate;

            // Template addon
            var query_templateAddon = world.creature_template_addon.Where(x => x.entry == query_id).SingleOrDefault();

            cTemplateAddon = query_templateAddon ?? new creature_template_addon();
            cTemplateAddonBinding.DataSource = cTemplateAddon;

            // Addon
            cAddon = new creature_addon();
            cAddonBinding.DataSource = cAddon;

            // On kill reputation
            var query_onKillReputation = world.creature_onkill_reputation.Where(x => x.creature_id == query_id).SingleOrDefault();

            cOnKillReputation = query_onKillReputation ?? new creature_onkill_reputation();
            cOnKillReputationBinding.DataSource = cOnKillReputation;

            // Involved in
            var query_questStarter = world.creature_queststarter.Where(x => x.id == query_id).ToList();
            var query_questEnder = world.creature_questender.Where(x => x.id == query_id).ToList();

            InvolvedInTabStartsDataGrid.Reset();
            InvolvedInTabEndsDataGrid.Reset();

            if (query_questStarter.Count > 1)
                InvolvedInTabStartsDataGrid.Rows.Add(query_questStarter.Count - 1);

            if (query_questEnder.Count > 1)
                InvolvedInTabEndsDataGrid.Rows.Add(query_questEnder.Count - 1);

            /* start quests */
            for (int i = 0; i < query_questStarter.Count; i++)
            {
                int quest = query_questStarter[i].quest;

                var query_startQuest = world.quest_template.Where(x => x.Id == quest).SingleOrDefault();

                if (query_startQuest == null)
                    continue;

                InvolvedInTabStartsDataGrid.Rows[i].Cells[0].Value = query_startQuest.Id;
                InvolvedInTabStartsDataGrid.Rows[i].Cells[1].Value = query_startQuest.Title;
                InvolvedInTabStartsDataGrid.Rows[i].Cells[2].Value = query_startQuest.Level;

                if (query_startQuest.RewardOrRequiredMoney != 0)
                    InvolvedInTabStartsDataGrid.Rows[i].Cells[4].Value = $"{query_startQuest.RewardOrRequiredMoney} Min coppers, {query_startQuest.RewardMoneyMaxLevel} Max level coppers.";
                else
                    InvolvedInTabStartsDataGrid.Rows[i].Cells[4].Value = $"{query_startQuest.RewardMoneyMaxLevel} at Max level coppers.";

                bool QuestIsAlliance = false;
                bool QuestIsHorde = false;

                string QuestFaction = String.Empty;

                string binary = Convert.ToString(query_startQuest.RequiredRaces, 2).PadLeft(22, '0');

                for (int k = binary.Length - 1; k >= 0; k--)
                {
                    if (binary[k] == '1' && WoW.Common.AllianceRaces.Contains(k))
                        QuestIsAlliance = true;
                    else if (binary[k] == '1' && WoW.Common.HordeRaces.Contains(k))
                        QuestIsHorde = true;
                }

                if (QuestIsAlliance)
                    QuestFaction = "Alliance";
                if (QuestIsHorde)
                    QuestFaction = "Horde";
                if (QuestIsAlliance && QuestIsHorde)
                    QuestFaction = "Neutral";

                InvolvedInTabStartsDataGrid.Rows[i].Cells[3].Value = QuestFaction;
            }

            /* end quests */
            for (int i = 0; i < query_questEnder.Count; i++)
            {
                int quest = query_questEnder[i].quest;

                var query_endQuest = world.quest_template.Where(x => x.Id == quest).SingleOrDefault();

                if (query_endQuest == null)
                    continue;

                InvolvedInTabEndsDataGrid.Rows[i].Cells[0].Value = query_endQuest.Id;
                InvolvedInTabEndsDataGrid.Rows[i].Cells[1].Value = query_endQuest.Title;
                InvolvedInTabEndsDataGrid.Rows[i].Cells[2].Value = query_endQuest.Level;

                if (query_endQuest.RewardOrRequiredMoney != 0)
                    InvolvedInTabEndsDataGrid.Rows[i].Cells[4].Value = $"{query_endQuest.RewardOrRequiredMoney} Min coppers, {query_endQuest.RewardMoneyMaxLevel} Max level coppers.";
                else
                    InvolvedInTabEndsDataGrid.Rows[i].Cells[4].Value = $"{query_endQuest.RewardMoneyMaxLevel} at Max level coppers.";

                bool QuestIsAlliance = false;
                bool QuestIsHorde = false;

                string QuestFaction = String.Empty;

                string binary = Convert.ToString(query_endQuest.RequiredRaces, 2).PadLeft(22, '0');

                for (int k = binary.Length - 1; k >= 0; k--)
                {
                    if (binary[k] == '1' && WoW.Common.AllianceRaces.Contains(k))
                        QuestIsAlliance = true;
                    else if (binary[k] == '1' && WoW.Common.HordeRaces.Contains(k))
                        QuestIsHorde = true;
                }

                if (QuestIsAlliance)
                    QuestFaction = "Alliance";
                if (QuestIsHorde)
                    QuestFaction = "Horde";
                if (QuestIsAlliance && QuestIsHorde)
                    QuestFaction = "Neutral";

                InvolvedInTabEndsDataGrid.Rows[i].Cells[3].Value = QuestFaction;
            }

            // Smart AI
            SmartAIDataGrid.Reset();

            var query_smartAI_guids = world.creature.Where(x => x.id == query_id).ToList();
            var query_smartAI_entry = world.smart_scripts.Where(x => x.entryorguid == query_id && x.source_type == 0).ToList();
            
            if (query_smartAI_guids.Count > 1)
                SmartAIDataGrid.Rows.Add(query_smartAI_guids.Count - 1);

            /* based on entry */
            SmartAIDataGrid.Load(query_smartAI_entry);

            /* based on guid */
            for (int i = 0; i < query_smartAI_guids.Count; i++)
            {
                var guid = -query_smartAI_guids[i].guid;

                var query_smartAI = world.smart_scripts.Where(x => x.entryorguid == guid && x.source_type == 0).ToList();

                for (int j = 0; j < query_smartAI.Count; j++)
                {
                    PropertyInfo[] properties = query_smartAI[j].GetType().GetProperties(); // get properties name

                    foreach (PropertyInfo property in properties) // bind property.Name and property.Value to target column
                        SmartAIDataGrid.SetColumnValue(j + query_smartAI_entry.Count, DisplayColumnName(property.Name), property.GetValue(query_smartAI[j]));
                }
            }

            CreatureTab.SelectedTab = EditPage;
        }

        void SearchCreateCopyButton_Click(object sender, EventArgs e)
        {
            if (SearchDataGrid.Rows.Count < 0)
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

            creature_template query = world.creature_template.Where(x => x.entry == query_id).SingleOrDefault();
            
            Editor.Copy copyNPC = new Editor.Copy("Copy NPC");

            if (copyNPC.ShowDialog() != DialogResult.OK)
                return;

            cTemplate = query;
            cTemplateBinding.DataSource = cTemplate;

            EditBox_entry.Text = copyNPC.Entry.ToString();

            CreatureTab.SelectedTab = EditPage;
        }

        void EditCodeButton_Click(object sender, EventArgs e)
        {
            if (CodeBox.Text == String.Empty)
                BtnCodeExecute.Enabled = true;

            CodeBox.Text += $"{DatabaseHelper.Insert(cTemplate)}\n\n";

            CreatureTab.SelectedTab = CodePage;
        }

        void EditShowImmuneMaskButton_Click(object sender, EventArgs e)
        {
            CreatureEdit.ImmuneMask immune_mask = new CreatureEdit.ImmuneMask(Convert.ToInt32(EditBox_mechanic_immune_mask.Text));

            if (immune_mask.ShowDialog() == DialogResult.OK)
                EditBox_mechanic_immune_mask.Text = immune_mask.ToString();
        }

        void EditShowDynamicFlagsButton_Click(object sender, EventArgs e)
        {
            CreatureEdit.DynamicFlags dynamic_flags = new CreatureEdit.DynamicFlags(Convert.ToInt32(EditBox_dynamicflags.Text));

            if (dynamic_flags.ShowDialog() == DialogResult.OK)
                EditBox_dynamicflags.Text = dynamic_flags.ToString();
        }

        void EditShowInhabitTypeButton_Click(object sender, EventArgs e)
        {
            CreatureEdit.InhabitType inhabit_type = new CreatureEdit.InhabitType(Convert.ToInt32(EditBox_InhabitType.Text));

            if (inhabit_type.ShowDialog() == DialogResult.OK)
                EditBox_InhabitType.Text = inhabit_type.ToString();
        }

        void EditShowMovementTypeButton_Click(object sender, EventArgs e)
        {
            CreatureEdit.MovementType movement_type = new CreatureEdit.MovementType(Convert.ToInt32(EditBox_MovementType.Text));

            if (movement_type.ShowDialog() == DialogResult.OK)
                EditBox_MovementType.Text = movement_type.ToString();
        }

        void EditShowTrainerTypeButton_Click(object sender, EventArgs e)
        {
            CreatureEdit.TrainerType trainer_type = new CreatureEdit.TrainerType(Convert.ToInt32(EditBox_trainer_type.Text));

            if (trainer_type.ShowDialog() == DialogResult.OK)
                EditBox_trainer_type.Text = trainer_type.ToString();
        }

        void EditShowTrainerRaceButton_Click(object sender, EventArgs e)
        {
            CreatureEdit.TrainerRace trainer_race = new CreatureEdit.TrainerRace(Convert.ToInt32(EditBox_trainer_race.Text));

            if (trainer_race.ShowDialog() == DialogResult.OK)
                EditBox_trainer_race.Text = trainer_race.ToString();
        }

        void EditShowTrainerClassButton_Click(object sender, EventArgs e)
        {
            CreatureEdit.TrainerClass trainer_class = new CreatureEdit.TrainerClass(Convert.ToInt32(EditBox_trainer_class.Text));

            if (trainer_class.ShowDialog() == DialogResult.OK)
                EditBox_trainer_class.Text = trainer_class.ToString();
        }

        void EditShowRankButton_Click(object sender, EventArgs e)
        {
            CreatureEdit.Rank rank = new CreatureEdit.Rank(Convert.ToInt32(EditBox_rank.Text));

            if (rank.ShowDialog() == DialogResult.OK)
                EditBox_rank.Text = rank.ToString();
        }

        void EditShowTypeButton_Click(object sender, EventArgs e)
        {
            CreatureEdit.Type type = new CreatureEdit.Type(Convert.ToInt32(EditBox_type.Text));

            if (type.ShowDialog() == DialogResult.OK)
                EditBox_type.Text = type.ToString();
        }

        void EditShowNPCFlagButton_Click(object sender, EventArgs e)
        {
            CreatureEdit.NPCFlags npc_flags = new CreatureEdit.NPCFlags(Convert.ToInt32(EditBox_npcflag.Text));

            if (npc_flags.ShowDialog() == DialogResult.OK)
                EditBox_npcflag.Text = npc_flags.ToString();
        }

        void EditShowUnitFlagsButton_Click(object sender, EventArgs e)
        {
            CreatureEdit.UnitFlags unit_flags = new CreatureEdit.UnitFlags(Convert.ToInt32(EditBox_unit_flags.Text));

            if (unit_flags.ShowDialog() == DialogResult.OK)
                EditBox_unit_flags.Text = unit_flags.ToString();
        }

        void EditShowTypeFlagsButton_Click(object sender, EventArgs e)
        {
            CreatureEdit.TypeFlags type_flags = new CreatureEdit.TypeFlags(Convert.ToInt32(EditBox_type_flags.Text));

            if (type_flags.ShowDialog() == DialogResult.OK)
                EditBox_type_flags.Text = type_flags.ToString();
        }

        void EditShowTrainerSpellButton_Click(object sender, EventArgs e)
        {
            CreatureEdit.TrainerSpell trainer_spell = new CreatureEdit.TrainerSpell();

            if (trainer_spell.ShowDialog() == DialogResult.OK)
                EditBox_trainer_spell.Text = trainer_spell.ToString();
        }

        void EditShowFamilyButton_Click(object sender, EventArgs e)
        {
            CreatureEdit.Family family = new CreatureEdit.Family();

            if (family.ShowDialog() == DialogResult.OK)
                EditBox_family.Text = family.ToString();
        }

        void EditShowAllianceFactionButton_Click(object sender, EventArgs e)
        {
            CreatureEdit.Faction faction = new CreatureEdit.Faction();

            if (faction.ShowDialog() == DialogResult.OK)
                EditBox_faction.Text = faction.ToString();
        }

        void EditShowHordeFactionButton_Click(object sender, EventArgs e)
        {
            CreatureEdit.Faction faction = new CreatureEdit.Faction();

            if (faction.ShowDialog() == DialogResult.OK)
                EditBox_type_flags2.Text = faction.ToString();
        }

        //// Creature - Location \\\\
        string location_delete = String.Empty;

        void LocationMapButton_Click(object sender, EventArgs e)
        {
            if (LocationDataGrid.SelectedCells.Count == 0)
                MessageBox.Show("Error: Row is not selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                CreatureLocation.Map map = new CreatureLocation.Map();

                if (map.ShowDialog() == DialogResult.OK)
                    LocationDataGrid.Rows[LocationDataGrid.CurrentCell.RowIndex].Cells[2].Value = map.ToString();
            }
        }

        void LocationNPCFlagsButton_Click(object sender, EventArgs e)
        {
            if (LocationDataGrid.SelectedCells.Count == 0)
                MessageBox.Show("Error: Row is not selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int current_flags = 0;

                if (LocationDataGrid.Rows[LocationDataGrid.CurrentCell.RowIndex].Cells[17].Value != null)
                    current_flags = Convert.ToInt32(LocationDataGrid.Rows[LocationDataGrid.CurrentCell.RowIndex].Cells[17].Value.ToString());

                CreatureEdit.NPCFlags npc_flags = new CreatureEdit.NPCFlags(current_flags);

                if (npc_flags.ShowDialog() == DialogResult.OK)
                    LocationDataGrid.Rows[LocationDataGrid.CurrentCell.RowIndex].Cells[17].Value = npc_flags.ToString();
            }
        }

        void LocationUnitFlagsButton_Click(object sender, EventArgs e)
        {
            if (LocationDataGrid.SelectedCells.Count == 0)
                MessageBox.Show("Error: Row is not selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int current_flags = 0;

                if (LocationDataGrid.Rows[LocationDataGrid.CurrentCell.RowIndex].Cells[18].Value != null)
                    current_flags = Convert.ToInt32(LocationDataGrid.Rows[LocationDataGrid.CurrentCell.RowIndex].Cells[18].Value.ToString());

                CreatureEdit.UnitFlags unit_flags = new CreatureEdit.UnitFlags(current_flags);

                if (unit_flags.ShowDialog() == DialogResult.OK)
                    LocationDataGrid.Rows[LocationDataGrid.CurrentCell.RowIndex].Cells[18].Value = unit_flags.ToString();
            }
        }

        void LocationDynamicFlagsButton_Click(object sender, EventArgs e)
        {
            if (LocationDataGrid.SelectedCells.Count == 0)
                MessageBox.Show("Error: Row is not selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int current_flags = 0;

                if (LocationDataGrid.Rows[LocationDataGrid.CurrentCell.RowIndex].Cells[19].Value != null)
                    current_flags = Convert.ToInt32(LocationDataGrid.Rows[LocationDataGrid.CurrentCell.RowIndex].Cells[19].Value.ToString());

                CreatureEdit.DynamicFlags dynamic_flags = new CreatureEdit.DynamicFlags(current_flags);

                if (dynamic_flags.ShowDialog() == DialogResult.OK)
                    LocationDataGrid.Rows[LocationDataGrid.CurrentCell.RowIndex].Cells[19].Value = dynamic_flags.ToString();
            }
        }

        void LocationSpawnMaskButton_Click(object sender, EventArgs e)
        {
            if (LocationDataGrid.SelectedCells.Count == 0)
                MessageBox.Show("Error: Row is not selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int current_spawnMask = 0;

                if (LocationDataGrid.Rows[LocationDataGrid.CurrentCell.RowIndex].Cells[7].Value != null)
                    current_spawnMask = Convert.ToInt32(LocationDataGrid.Rows[LocationDataGrid.CurrentCell.RowIndex].Cells[7].Value.ToString());

                CreatureLocation.SpawnMask spawn_mask = new CreatureLocation.SpawnMask(current_spawnMask);

                if (spawn_mask.ShowDialog() == DialogResult.OK)
                    LocationDataGrid.Rows[LocationDataGrid.CurrentCell.RowIndex].Cells[7].Value = spawn_mask.ToString();
            }
        }

        void LocationDeleteButton_Click(object sender, EventArgs e)
        {
            DeleteLine(LocationDataGrid, location_delete, "-- Creature Location : delete\nDELETE FROM `creature` WHERE `guid`", "DELETE FROM `creature` WHERE `guid`");
        }

        void LocationCodeButton_Click(object sender, EventArgs e)
        {
            string sql = CodeGeneration(location_delete, LocationDataGrid, "`creature` (`guid`, `id`, `map`, `position_x`, `positon_y`, `position_z`, `orientation`, `spawnMask`, `phaseMask`, `modelid`, `equipment_id`, `spawntimesecs`, `spawndist`, `currentwaypoint`, `curhealth`, `curmana`, `MovementType`, `npcflag`, `unit_flags`, `dynamicflags`) VALUES(`{0}`, `{1}`, `{2}`, `{3}`, `{4}`, `{5}`, `{6}`, `{7}`, `{8}`, `{9}`, `{10}`, `{11}`, `{12}`, `{13}`, `{14}`, `{15}`, `{16}`, `{17}`, `{18}`, `{19}`);\n");

            CodeBox.Text += $"-- Creature Location: INSERT code\n{sql}\n";
            BtnCodeExecute.Enabled = true;

            CreatureTab.SelectedTab = CodePage;
        }

        //// Creature - Model Info \\\\
        string modelInfo_delete = String.Empty;

        void ModelInfoDeleteButton_Click(object sender, EventArgs e)
        {
            DeleteLine(ModelInfoDataGrid, modelInfo_delete, "-- Creature Model Info : delete\nDELETE FROM `creature_model_info` WHERE `modelid`", "DELETE FROM `creature_model_info` WHERE `modelid`");
        }

        void ModelInfoCodeButton_Click(object sender, EventArgs e)
        {
            string sql = CodeGeneration(modelInfo_delete, ModelInfoDataGrid, "`creature_model_info` (`modelid`, `bounding_radius`, `combat_reach`, `gender`, `modelid_other_gender`) VALUES(`{0}`, `{1}`, `{2}`, `{3}`, `{4}`);\n");

            CodeBox.Text += $"-- Creature Model Info: INSERT code\n{sql}\n";
            BtnCodeExecute.Enabled = true;

            CreatureTab.SelectedTab = CodePage;
        }

        //// Creature - Loot \\\\
        string Loot_delete = String.Empty;

        void LootItemButton_Click(object sender, EventArgs e)
        {
            LootDialog(LootDataGrid, 1);
        }

        void LootDeleteLineButton_Click(object sender, EventArgs e)
        {
            DeleteLine(LootDataGrid, Loot_delete, "-- Creature Loot : delete\nDELETE FROM `creature_loot_template` WHERE `entry`", "DELETE FROM `creature_loot_template` WHERE `entry`");
        }

        void LootCodeButton_Click(object sender, EventArgs e)
        {
            string sql = CodeGeneration(Loot_delete, LootDataGrid, "`creature_loot_template` (`Entry`, `Item`, `Reference`, `Chance`, `QuestRequired`, `LootMode`, `GroupID`, `MinCount`, `MaxCount`, `Comment`) VALUES(`{0}`, `{1}`, `{2}`, `{3}`, `{4}`, `{5}`, `{6}`, `{7}`, `{8}`, `{9}`);\n");

            CodeBox.Text += $"-- Creature Loot: INSERT code\n{sql}\n";
            BtnCodeExecute.Enabled = true;

            CreatureTab.SelectedTab = CodePage;
        }

        void LootReloadButton_Click(object sender, EventArgs e)
        {
            var query_loot = world.creature_loot_template.Where(x => x.Entry.ToString() == EditBox_lootid.Text).Select(x => new { x.Entry, x.Item, x.Reference, x.Chance, x.QuestRequired, x.LootMode, x.GroupId, x.MinCount, x.MaxCount, x.Comment }).ToList();

            LootDataGrid.Load(query_loot);
        }

        //// Creature - Pick Pocket Loot \\\\
        string PickPocketLoot_delete = String.Empty;

        void PickPocketItemButton_Click(object sender, EventArgs e)
        {
            LootDialog(PickPocketLootDataGrid, 1);
        }

        void PickPocketDeleteButton_Click(object sender, EventArgs e)
        {
            DeleteLine(PickPocketLootDataGrid, PickPocketLoot_delete, "-- Creature Pick Pocket Loot : delete\nDELETE FROM `pickpocketing_loot_template` WHERE `entry`", "DELETE FROM `pickpocketing_loot_template` WHERE `entry`");
        }

        void PickPocketCodeButton_Click(object sender, EventArgs e)
        {
            string sql = CodeGeneration(PickPocketLoot_delete, PickPocketLootDataGrid, "`pickpocketing_loot_template` (`Entry`, `Item`, `Reference`, `Chance`, `QuestRequired`, `LootMode`, `GroupID`, `MinCount`, `MaxCount`, `Comment`) VALUES(`{0}`, `{1}`, `{2}`, `{3}`, `{4}`, `{5}`, `{6}`, `{7}`, `{8}`, `{9}`);\n");

            CodeBox.Text += $"-- Creature Pick Pocket Loot: INSERT code\n{sql}\n";
            BtnCodeExecute.Enabled = true;

            CreatureTab.SelectedTab = CodePage;
        }

        void PickPocketReloadButton_Click(object sender, EventArgs e)
        {
            var query_pickPocket = world.pickpocketing_loot_template.Where(x => x.Entry.ToString() == EditBox_pickpocketloot.Text).Select(x => new { x.Entry, x.Item, x.Reference, x.Chance, x.QuestRequired, x.LootMode, x.GroupId, x.MinCount, x.MaxCount, x.Comment }).ToList();

            PickPocketLootDataGrid.Load(query_pickPocket);
        }

        //// Creature - Skinning Loot \\\\
        string SkinningLoot_delete = String.Empty;

        void SkinningLootItemButton_Click(object sender, EventArgs e)
        {
            LootDialog(SkinningLootDataGrid, 1);
        }

        void SkinningLootDeleteButton_Click(object sender, EventArgs e)
        {
            DeleteLine(SkinningLootDataGrid, SkinningLoot_delete, "-- Creature Skinning Loot : delete\nDELETE FROM `skinning_loot_template` WHERE `entry`", "DELETE FROM `skinning_loot_template` WHERE `entry`");
        }

        void SkinningLootCodeButton_Click(object sender, EventArgs e)
        {
            string sql = CodeGeneration(SkinningLoot_delete, SkinningLootDataGrid, "`skinning_loot_template` (`Entry`, `Item`, `Reference`, `Chance`, `QuestRequired`, `LootMode`, `GroupID`, `MinCount`, `MaxCount`, `Comment`) VALUES(`{0}`, `{1}`, `{2}`, `{3}`, `{4}`, `{5}`, `{6}`, `{7}`, `{8}`, `{9}`);\n");

            CodeBox.Text += $"-- Creature Skinning Loot: INSERT code\n{sql}\n";
            BtnCodeExecute.Enabled = true;

            CreatureTab.SelectedTab = CodePage;
        }

        void SkinningLootReloadButton_Click(object sender, EventArgs e)
        {
            var query_skinning = world.skinning_loot_template.Where(x => x.Entry.ToString() == EditBox_skinloot.Text).Select(x => new { x.Entry, x.Item, x.Reference, x.Chance, x.QuestRequired, x.LootMode, x.GroupId, x.MinCount, x.MaxCount, x.Comment }).ToList();

            SkinningLootDataGrid.Load(query_skinning);
        }

        //// Creature - Other \\\\
        // Equip Template
        void EquipTemplate(TextBox box)
        {
            Loot loot = new Loot(string.IsNullOrWhiteSpace(box.Text) ? 0 : Convert.ToInt32(box.Text));

            if (loot.ShowDialog() == DialogResult.OK)
                box.Text = loot.ToString();
        }

        void OtherEquipTemplateItem1Button_Click(object sender, EventArgs e)
        {
            EquipTemplate(EquipTemplateBox_itemEntry1);
        }

        void OtherEquipTemplateItem2Button_Click(object sender, EventArgs e)
        {
            EquipTemplate(EquipTemplateBox_itemEntry2);
        }

        void OtherEquipTemplateItem3Button_Click(object sender, EventArgs e)
        {
            EquipTemplate(EquipTemplateBox_itemEntry3);
        }

        string OtherEquipTemplate()
        {
            if (cEquipTemplate.IsAllNullOrEmpty())
                return String.Empty;

            return $"{DatabaseHelper.Insert(cEquipTemplate)}\n";
        }

        // Template Addon
        void OtherTemplateAddonEmoteButton_Click(object sender, EventArgs e)
        {
            Emote emotes = new Emote();

            if (emotes.ShowDialog() == DialogResult.OK)
                TemplateAddonBox_emote.Text = emotes.ToString();
        }

        string OtherTemplateAddon()
        {
            if (cTemplateAddon.IsAllNullOrEmpty())
                return String.Empty;

            return $"{DatabaseHelper.Insert(cTemplateAddon)}\n";
        }

        // Addon
        void OtherAddonEmoteButton_Click(object sender, EventArgs e)
        {
            Emote emotes = new Emote();

            if (emotes.ShowDialog() == DialogResult.OK)
                AddonBox_emote.Text = emotes.ToString();
        }

        string OtherAddon()
        {
            if (cAddon.IsAllNullOrEmpty())
                return String.Empty;

            return $"{DatabaseHelper.Insert(cAddon)}\n";
        }

        // On Kill Reputation
        void OtherOnKillReputationFactionButton_Click(object sender, EventArgs e)
        {
            CreatureEdit.Faction faction = new CreatureEdit.Faction();

            if (faction.ShowDialog() == DialogResult.OK)
                OKRBox_RewOnKillRepFaction1.Text = faction.ToString();
        }

        void OtherOnKillReputationFaction2Button_Click(object sender, EventArgs e)
        {
            CreatureEdit.Faction faction = new CreatureEdit.Faction();

            if (faction.ShowDialog() == DialogResult.OK)
                OKRBox_RewOnKillRepFaction2.Text = faction.ToString();
        }

        void OtherOnKillReputationMaxStandingButton_Click(object sender, EventArgs e)
        {
            int current_standing = string.IsNullOrWhiteSpace(OKRBox_MaxStanding1.Text) ? 0 : Convert.ToInt32(OKRBox_MaxStanding1.Text);

            RepMaxStanding maxStanding = new RepMaxStanding(current_standing);

            if (maxStanding.ShowDialog() == DialogResult.OK)
                OKRBox_MaxStanding1.Text = maxStanding.ToString();
        }

        void OtherOnKillReputationMaxStanding2Button_Click(object sender, EventArgs e)
        {
            int current_standing = string.IsNullOrWhiteSpace(OKRBox_MaxStanding2.Text) ? 0 : Convert.ToInt32(OKRBox_MaxStanding2.Text);

            RepMaxStanding maxStanding = new RepMaxStanding(current_standing);

            if (maxStanding.ShowDialog() == DialogResult.OK)
                OKRBox_MaxStanding2.Text = maxStanding.ToString();
        }

        string OtherOnKillReputation()
        {
            if (cOnKillReputation.IsAllNullOrEmpty())
                return String.Empty;

            return $"{DatabaseHelper.Insert(cOnKillReputation)}\n";
        }

        // Code Button
        void OtherCodeButton_Click(object sender, EventArgs e)
        {
            string sql = $"{OtherEquipTemplate()}{OtherAddon()}{OtherTemplateAddon()}{OtherOnKillReputation()}";

            if (sql != String.Empty)
            {
                CodeBox.Text += sql + "\n\n";
                BtnCodeExecute.Enabled = true;
            }

            CreatureTab.SelectedTab = CodePage;
        }

        //// Creature - SmartAI \\\\
        string SmartAI_delete = String.Empty;

        void SmartAISourceTypeButton_Click(object sender, EventArgs e)
        {
            SmartAIDialog(SmartAIDataGrid, typeof(CreatureSmartAI.SourceType), 1);
        }

        void SmartAIEventFlagsButton_Click(object sender, EventArgs e)
        {
            if (SmartAIDataGrid.SelectedCells.Count == 0)
                MessageBox.Show("Error: Row is not selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int current_flags = 0;

                if (SmartAIDataGrid.Rows[SmartAIDataGrid.CurrentCell.RowIndex].Cells[7].Value != null)
                    current_flags = Convert.ToInt32(SmartAIDataGrid.Rows[SmartAIDataGrid.CurrentCell.RowIndex].Cells[7].Value.ToString());

                CreatureSmartAI.EventFlags eventFlags = new CreatureSmartAI.EventFlags(current_flags);
                
                if (eventFlags.ShowDialog() == DialogResult.OK)
                    SmartAIDataGrid.Rows[SmartAIDataGrid.CurrentCell.RowIndex].Cells[7].Value = eventFlags.ToString();
            }
        }

        void SmartAIEventTypeButton_Click(object sender, EventArgs e)
        {
            SmartAIDialog(SmartAIDataGrid, typeof(CreatureSmartAI.EventType), 4);
        }

        void SmartAIActionTypeButton_Click(object sender, EventArgs e)
        {
            SmartAIDialog(SmartAIDataGrid, typeof(CreatureSmartAI.ActionType), 12);
        }

        void SmartAITargetTypeButton_Click(object sender, EventArgs e)
        {
            SmartAIDialog(SmartAIDataGrid, typeof(CreatureSmartAI.TargetType), 19);
        }

        void SmartAIDeleteLineButton_Click(object sender, EventArgs e)
        {
            DeleteLine(SmartAIDataGrid, SmartAI_delete, "-- Creature SmartAI : delete\nDELETE FROM `smart_scripts` WHERE `entryorguid`", "DELETE FROM `smart_scripts` WHERE `entryorguid`");
        }

        void SmartAICodeButton_Click(object sender, EventArgs e)
        {
            string sql = CodeGeneration(SmartAI_delete, SmartAIDataGrid, "`smart_scripts` (`entryorguid`,`source_type`,`id`,`link`,`event_type`,`event_phase_mask`,`event_chance`,`event_flags`,`event_param1`,`event_param2`,`event_param3`,`event_param4`,`action_type`,`action_param1`,`action_param2`,`action_param3`,`action_param4`,`action_param5`,`action_param6`,`target_type`,`target_param1`,`target_param2`,`target_param3`,`target_x`,`target_y`,`target_z`,`target_o`,`comment`) VALUES(`{0}`, `{1}`, `{2}`, `{3}`, `{4}`, `{5}`, `{6}`, `{7}`, `{8}`, `{9}`, `{10}`, `{11}`, `{12}`, `{13}`, `{14}`, `{15}`, `{16}`, `{17}`, `{18}`, `{19}`, `{20}`, `{21}`, `{22}`, `{23}`, `{24}`, `{25}`, `{26}`, `{27}`);\n");

            CodeBox.Text += $"-- Creature SmartAI: INSERT code\n{sql}\n";
            BtnCodeExecute.Enabled = true;

            CreatureTab.SelectedTab = CodePage;
        }

        //// Creature - Code \\\\
        void CodeCopyButton_Click(object sender, EventArgs e)
        {
            CodeCopy(CodeBox.Text);
        }

        void CodeSaveButton_Click(object sender, EventArgs e)
        {
            CodeSave(CodeBox.Text);
        }

        void CodeBox_TextChanged(object sender, EventArgs e)
        {
            BtnCodeExecute.Enabled = CodeBox.Text == String.Empty ? false : true;
        }

        void CodeInsertRadioButton_Click(object sender, EventArgs e)
        {
            CodeBox.Text = CodeBox.Text.Replace("REPLACE", "INSERT");
        }

        void CodeReplaceRadioButton_Click(object sender, EventArgs e)
        {
            CodeBox.Text = CodeBox.Text.Replace("INSERT", "REPLACE");
        }

        void CodeExecuteButton_Click(object sender, EventArgs e)
        {
            CodeExecute(CodeBox.Text, BtnCodeExecute);
        }

        string CreatureEditModelType(int column)
        {
            IQueryable<creature_template> query = world.creature_template;

            switch (column)
            {
                case 1:
                    query = query.Where(x => x.modelid1.ToString() == EditBox_modelid1.Text);
                    break;

                case 2:
                    query = query.Where(x => x.modelid2.ToString() == EditBox_modelid2.Text);
                    break;

                case 3:
                    query = query.Where(x => x.modelid3.ToString() == EditBox_modelid3.Text);
                    break;

                case 4:
                    query = query.Where(x => x.modelid4.ToString() == EditBox_modelid4.Text);
                    break;
            }

            string mysql_type = query.Select(x => new { x.type }).Single().type.ToString();
            
            if ((new string[] { "1", "2", "3", "4", "5", "6", "8", "9", "10", "11", "12", "13" }).Any(mysql_type.Contains))
                return "8";
            else if (mysql_type == "7")
                return "32";
            else
                return "8";
        }

        void CreatureEditModelTrackBar_ValueChanged(object sender, EventArgs e)
        {
            switch(CreatureEditModelTrackBar.Value)
            {
                case 0:
                    CreatureEditModel.Url = new Uri("http://test.glararan.eu/test2.php");
                    break;

                case 1:
                    CreatureEditModel.Url = new Uri($"http://test.glararan.eu/test2.php?model={EditBox_modelid1.Text}&type={CreatureEditModelType(1)}");
                    break;

                case 2:
                    CreatureEditModel.Url = new Uri($"http://test.glararan.eu/test2.php?model={EditBox_modelid2.Text}&type={CreatureEditModelType(2)}");
                    break;

                case 3:
                    CreatureEditModel.Url = new Uri($"http://test.glararan.eu/test2.php?model={EditBox_modelid3.Text}&type={CreatureEditModelType(3)}");
                    break;

                case 4:
                    CreatureEditModel.Url = new Uri($"http://test.glararan.eu/test2.php?model={EditBox_modelid4.Text}&type={CreatureEditModelType(4)}");
                    break;
            }
        }
    }
}
