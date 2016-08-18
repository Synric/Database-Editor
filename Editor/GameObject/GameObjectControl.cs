using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;
using DatabaseEditor.Database;
using DatabaseEditor.Editor.Shared;
using DatabaseEditor.Creature.CreatureSmartAI;

namespace DatabaseEditor.Editor.GameObject
{
    public partial class GameObjectControl : EditorControl
    {
        // Bindings
        BindingSource goTemplateBinding;

        // Tables
        gameobject_template goTemplate;

        public GameObjectControl()
        {
            InitializeComponent();
        }

        public override void Initialize()
        {
            SetDataGridViewColumns(SearchDataGrid, new string[] { "entry", "name", "displayId", "type", "flags", "size" });
            SetDataGridViewColumns(LocationDataGrid, new string[] { "guid", "id", "map", "zoneId", "areaId", "position_x", "position_y", "position_z", "orientation", "rotation0", "rotation1", "rotation2", "rotation3", "animprogress", "state", "spawnMask", "phaseMask", "PhaseId", "PhaseGroup", "spawntimesecs" });
            SetDataGridViewColumns(LootDataGrid, new string[] { "Entry", "Item", "Reference", "Chance", "QuestRequired", "LootMode", "GroupId", "MinCount", "MaxCount", "Comment" });
            SetDataGridViewColumns(InvolvedInTabStartsDataGrid, new string[] { "Id", "Title", "Level", "faction", "RewardOrRequiredMoney" });
            SetDataGridViewColumns(InvolvedInTabEndsDataGrid, new string[] { "Id", "Title", "Level", "faction", "RewardOrRequiredMoney" });
            SetDataGridViewColumns(SmartAIDataGrid, new string[] { "entryorguid", "source_type", "id", "link", "event_type", "event_phase_mask", "event_chance", "event_flags", "event_param1", "event_param2", "event_param3", "event_param4", "action_type", "action_param1", "action_param2", "action_param3", "action_param4", "action_param5", "action_param6", "target_type", "target_param1", "target_param2", "target_param3", "target_x", "target_y", "target_z", "target_o", "comment" });
            
            // Bindings
            goTemplate = new gameobject_template(true);

            goTemplateBinding = new BindingSource();
            goTemplateBinding.DataSource = goTemplate;
            goTemplateBinding.ReflectionBinding(this, "EditBox_");
        }

        public override IButtonControl AcceptButton
        {
            get
            {
                if (GameObjectTab.SelectedTab == SearchPage)
                    return BtnSearch;
                else if (GameObjectTab.SelectedTab == EditPage)
                    return BtnEditCode;
                else if (GameObjectTab.SelectedTab == LocationPage)
                    return BtnLocationCode;
                else if (GameObjectTab.SelectedTab == LootPage)
                    return BtnLootCode;
                else if (GameObjectTab.SelectedTab == SmartAIPage)
                    return BtnSmartAICode;
                else if (GameObjectTab.SelectedTab == CodePage)
                    return BtnCodeExecute;

                return null;
            }
        }

        /// GameObject search
        void SearchTypeButton_Click(object sender, EventArgs e)
        {
            DatabaseEditor.GameObject.Edit.Type type = new DatabaseEditor.GameObject.Edit.Type();
            
            if (type.ShowDialog() == DialogResult.OK)
                SearchType.Text = type.ToString();
        }

        void SearchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchEntry.Text) && string.IsNullOrWhiteSpace(SearchName.Text) && string.IsNullOrWhiteSpace(SearchType.Text) && string.IsNullOrWhiteSpace(SearchDisplayID.Text))
            {
                MessageBox.Show("Need to add value to one of column!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            IQueryable<gameobject_template> query = world.gameobject_template;

            if (!string.IsNullOrWhiteSpace(SearchEntry.Text))
                query = query.Where(x => x.entry.ToString() == SearchEntry.Text);
            if (!string.IsNullOrWhiteSpace(SearchName.Text))
                query = query.Where(x => x.name.Contains(SearchName.Text.Replace("'", "''")));
            if (!string.IsNullOrWhiteSpace(SearchType.Text))
                query = query.Where(x => x.type == Convert.ToInt32(SearchType.Text));
            if (!string.IsNullOrWhiteSpace(SearchDisplayID.Text))
                query = query.Where(x => x.displayId == Convert.ToInt32(SearchDisplayID.Text));

            var result = query.Select(x => new { x.entry, x.name, x.displayId, x.type, x.flags, x.size }).ToList();

            SearchDataGrid.Load(result);
        }

        void SearchDataGrid_DoubleClick(object sender, EventArgs e)
        {
            if (SearchDataGrid.Rows.Count < 1)
                return;

            int query_id = Convert.ToInt32(SearchDataGrid.Rows[SearchDataGrid.CurrentCell.RowIndex].Cells[0].Value.ToString());

            //// EDIT PAGE
            gameobject_template query = world.gameobject_template.Where(x => x.entry == query_id).Single();

            goTemplate = query;
            goTemplateBinding.DataSource = goTemplate;

            // Location
            var query_location = world.gameobject.Where(x => x.id == query_id).Select(x => new { x.guid, x.id, x.map, x.zoneId, x.areaId, x.position_x, x.position_y, x.position_z, x.orientation, x.rotation0, x.rotation1, x.rotation2, x.rotation3, x.animprogress, x.state, x.spawnMask, x.phaseMask, x.PhaseId, x.PhaseGroup, x.spawntimesecs }).ToList();

            LocationDataGrid.Load(query_location);

            // Loot
            var query_loot = world.gameobject_loot_template.Where(x => x.Entry.ToString() == query.data1.ToString()).Select(x => new { x.Entry, x.Item, x.Reference, x.Chance, x.QuestRequired, x.LootMode, x.GroupId, x.MinCount, x.MaxCount, x.Comment }).ToList();

            LootDataGrid.Load(query_loot); // type == 3 || 25

            // Involved in
            var query_questStarter = world.gameobject_queststarter.Where(x => x.id == query_id).ToList();
            var query_questEnder = world.gameobject_questender.Where(x => x.id == query_id).ToList();

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

            var query_smartAI_guids = world.gameobject.Where(x => x.id == query_id).ToList();
            var query_smartAI_entry = world.smart_scripts.Where(x => x.entryorguid == query_id && x.source_type == 1).ToList();

            if (query_smartAI_guids.Count > 1)
                SmartAIDataGrid.Rows.Add(query_smartAI_guids.Count - 1);

            /* based on entry */
            SmartAIDataGrid.Load(query_smartAI_entry);

            /* based on guid */
            for (int i = 0; i < query_smartAI_guids.Count; i++)
            {
                var guid = -query_smartAI_guids[i].guid;

                var query_smartAI = world.smart_scripts.Where(x => x.entryorguid == guid && x.source_type == 1).ToList();

                for (int j = 0; j < query_smartAI.Count; j++)
                {
                    PropertyInfo[] properties = query_smartAI[j].GetType().GetProperties(); // get properties name

                    foreach (PropertyInfo property in properties) // bind property.Name and property.Value to target column
                        SmartAIDataGrid.SetColumnValue(j + query_smartAI_entry.Count, DisplayColumnName(property.Name), property.GetValue(query_smartAI[j]));
                }
            }

            GameObjectTab.SelectedTab = EditPage;
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

            gameobject_template query = world.gameobject_template.Where(x => x.entry == query_id).SingleOrDefault();

            Copy copyGO = new Copy("Copy GO");

            if (copyGO.ShowDialog() != DialogResult.OK)
                return;

            goTemplate = query;
            goTemplateBinding.DataSource = goTemplate;

            EditBox_entry.Text = copyGO.Entry.ToString();

            GameObjectTab.SelectedTab = EditPage;
        }

        void EditTypeButton_Click(object sender, EventArgs e)
        {
            DatabaseEditor.GameObject.Edit.Type type = new DatabaseEditor.GameObject.Edit.Type();

            if (type.ShowDialog() == DialogResult.OK)
                EditBox_type.Text = type.ToString();
        }
        
        void EditCodeButton_Click(object sender, EventArgs e)
        {
            if (CodeBox.Text == String.Empty)
                BtnCodeExecute.Enabled = true;

            CodeBox.Text += $"{DatabaseHelper.Insert(goTemplate)}\n\n";

            GameObjectTab.SelectedTab = CodePage;
        }

        void EditFactionButton_Click(object sender, EventArgs e)
        {
            Faction faction = new Faction();
            
            if (faction.ShowDialog() == DialogResult.OK)
                EditBox_faction.Text = faction.ToString();
        }

        void EditFlagsButton_Click(object sender, EventArgs e)
        {
            int current_flags = string.IsNullOrWhiteSpace(EditBox_flags.Text) ? 0 : Convert.ToInt32(EditBox_flags.Text);

            DatabaseEditor.GameObject.Edit.Flags flags = new DatabaseEditor.GameObject.Edit.Flags(current_flags);

            if (flags.ShowDialog() == DialogResult.OK)
                EditBox_flags.Text = flags.ToString();
        }

        //// GameObject - Location \\\\
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

        void LocationSpawnMaskButton_Click(object sender, EventArgs e)
        {
            if (LocationDataGrid.SelectedCells.Count == 0)
                MessageBox.Show("Error: Row is not selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int current_spawnMask = 0;

                if (LocationDataGrid.Rows[LocationDataGrid.CurrentCell.RowIndex].Cells[15].Value != null)
                    current_spawnMask = Convert.ToInt32(LocationDataGrid.Rows[LocationDataGrid.CurrentCell.RowIndex].Cells[15].Value.ToString());

                CreatureLocation.SpawnMask spawn_mask = new CreatureLocation.SpawnMask(current_spawnMask);
                
                if (spawn_mask.ShowDialog() == DialogResult.OK)
                    LocationDataGrid.Rows[LocationDataGrid.CurrentCell.RowIndex].Cells[15].Value = spawn_mask.ToString();
            }
        }

        void LocationDeleteLineButton_Click(object sender, EventArgs e)
        {
            DeleteLine(LocationDataGrid, location_delete, "-- GameObject Location : delete\nDELETE FROM `gameobject` WHERE `guid`", "DELETE FROM `gameobject` WHERE `guid`");
        }

        void LocationCodeButton_Click(object sender, EventArgs e)
        {
            string sql = CodeGeneration(location_delete, LocationDataGrid, "`gameobject` (`guid`, `id`, `map`, `zoneId`, `areaId`, `position_x`, `positon_y`, `position_z`, `orientation`, `rotation0`, `rotation1`, `rotation2`, `rotation3`, `animprogress`, `state`, `spawnMask`, `phaseMask`, `PhaseId`, `PhaseGroup`, `spawntimesecs`) VALUES(`{0}`, `{1}`, `{2}`, `{3}`, `{4}`, `{5}`, `{6}`, `{7}`, `{8}`, `{9}`, `{10}`, `{11}`, `{12}`, `{13}`, `{14}`, `{15}`, `{16}`, `{17}`, `{18}`, `{19}`);\n");

            CodeBox.Text += $"-- GameObject Location: INSERT code\n{sql}\n";
            BtnCodeExecute.Enabled = true;

            GameObjectTab.SelectedTab = CodePage;
        }

        //// GameObject - Loot \\\\
        string loot_delete = String.Empty;

        void LootItemButton_Click(object sender, EventArgs e)
        {
            LootDialog(LootDataGrid, 1);
        }

        void LootDeleteLineButton_Click(object sender, EventArgs e)
        {
            DeleteLine(LootDataGrid, loot_delete, "-- GameObject Loot : delete\nDELETE FROM `gameobject_loot_template` WHERE `entry`", "DELETE FROM `gameobject_loot_template` WHERE `entry`");
        }

        void LootCodeButton_Click(object sender, EventArgs e)
        {
            string sql = CodeGeneration(loot_delete, LootDataGrid, "`gameobject_loot_template` (`Entry`, `Item`, `Reference`, `Chance`, `QuestRequired`, `LootMode`, `GroupID`, `MinCount`, `MaxCount`, `Comment`) VALUES(`{0}`, `{1}`, `{2}`, `{3}`, `{4}`, `{5}`, `{6}`, `{7}`, `{8}`, `{9}`);\n");

            CodeBox.Text += $"-- GameObject Loot: INSERT code\"{sql}\n";
            BtnCodeExecute.Enabled = true;

            GameObjectTab.SelectedTab = CodePage;
        }

        void LootReloadButton_Click(object sender, EventArgs e)
        {
            if (EditBox_type.Text == "3" | EditBox_type.Text == "25")
            {
                var query_loot = world.gameobject_loot_template.Where(x => x.Entry.ToString() == EditBox_data1.ToString()).Select(x => new { x.Entry, x.Item, x.Reference, x.Chance, x.QuestRequired, x.LootMode, x.GroupId, x.MinCount, x.MaxCount, x.Comment }).ToList();

                LootDataGrid.Load(query_loot);
            }
        }
        
        //// GameObject - SmartAI \\\\
        string SmartAI_delete = String.Empty;

        void SmartAISourceTypeButton_Click(object sender, EventArgs e)
        {
            SmartAIDialog(SmartAIDataGrid, typeof(SourceType), 1);
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

                EventFlags eventFlags = new EventFlags(current_flags);
                
                if (eventFlags.ShowDialog() == DialogResult.Retry)
                    SmartAIDataGrid.Rows[SmartAIDataGrid.CurrentCell.RowIndex].Cells[7].Value = eventFlags.ToString();
            }
        }

        void SmartAIEventTypeButton_Click(object sender, EventArgs e)
        {
            SmartAIDialog(SmartAIDataGrid, typeof(EventType), 4);
        }

        void GameObjectSmartAIActionTypeButton_Click(object sender, EventArgs e)
        {
            SmartAIDialog(SmartAIDataGrid, typeof(ActionType), 12);
        }

        void GameObjectSmartAITargetTypeButton_Click(object sender, EventArgs e)
        {
            SmartAIDialog(SmartAIDataGrid, typeof(TargetType), 19);
        }

        void GameObjectSmartAIDeleteLineButton_Click(object sender, EventArgs e)
        {
            DeleteLine(SmartAIDataGrid, SmartAI_delete, "-- GameObject SmartAI : delete\nDELETE FROM `smart_scripts` WHERE `entryorguid`", "DELETE FROM `smart_scripts` WHERE `entryorguid`");
        }

        void GameObjectSmartAICodeButton_Click(object sender, EventArgs e)
        {
            string sql = CodeGeneration(SmartAI_delete, SmartAIDataGrid, "`smart_scripts` (`entryorguid`,`source_type`,`id`,`link`,`event_type`,`event_phase_mask`,`event_chance`,`event_flags`,`event_param1`,`event_param2`,`event_param3`,`event_param4`,`action_type`,`action_param1`,`action_param2`,`action_param3`,`action_param4`,`action_param5`,`action_param6`,`target_type`,`target_param1`,`target_param2`,`target_param3`,`target_x`,`target_y`,`target_z`,`target_o`,`comment`) VALUES(`{0}`, `{1}`, `{2}`, `{3}`, `{4}`, `{5}`, `{6}`, `{7}`, `{8}`, `{9}`, `{10}`, `{11}`, `{12}`, `{13}`, `{14}`, `{15}`, `{16}`, `{17}`, `{18}`, `{19}`, `{20}`, `{21}`, `{22}`, `{23}`, `{24}`, `{25}`, `{26}`, `{27}`);\n");

            CodeBox.Text += $"-- GameObject SmartAI: INSERT code\n{sql}\n";
            BtnCodeExecute.Enabled = true;

            GameObjectTab.SelectedTab = CodePage;
        }

        //// GameObject - Code \\\\
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

        private void GameObjectDataLabel_Click(object sender, EventArgs e)
        {

        }

        private void EditPage_Click(object sender, EventArgs e)
        {

        }

        private void EditBox_type_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (EditBox_type.Text == "0")
                {
                    GameObjectDataLabel.Text = "Start Open";
                    GameObjectData1Label.Text = "Lock.dbc ID";
                    GameObjectData2Label.Text = "Close Time - MS";
                    GameObjectData3Label.Text = "Dmg Immune (0/1)";
                    GameObjectData4Label.Text = "Open Text ID";
                    GameObjectData5Label.Text = "Close Text ID";
                    GameObjectData6Label.Text = "Unused";
                    GameObjectData7Label.Text = "Unused";
                    GameObjectData8Label.Text = "Unused";
                    GameObjectData9Label.Text = "Unused";
                    GameObjectData10Label.Text = "Unused";
                    GameObjectData11Label.Text = "Unused";
                    GameObjectData12Label.Text = "Unused";
                    GameObjectData13Label.Text = "Unused";
                    GameObjectData14Label.Text = "Unused";
                    GameObjectData15Label.Text = "Unused";
                    GameObjectData16Label.Text = "Unused";
                    GameObjectData17Label.Text = "Unused";
                    GameObjectData18Label.Text = "Unused";
                    GameObjectData19Label.Text = "Unused";
                    GameObjectData20Label.Text = "Unused";
                    GameObjectData21Label.Text = "Unused";
                    GameObjectData22Label.Text = "Unused";
                    GameObjectData23Label.Text = "Unused";
                }
                if (EditBox_type.Text == "1")
                {
                    GameObjectDataLabel.Text = "Start Open State";
                    GameObjectData1Label.Text = "Lock.dbc ID";
                    GameObjectData2Label.Text = "Auto Close Flag";
                    GameObjectData3Label.Text = "Trap ID - GO Template";
                    GameObjectData4Label.Text = "Dmg Immune (0/1)";
                    GameObjectData5Label.Text = "Large? (0/1)";
                    GameObjectData6Label.Text = "Open Text ID";
                    GameObjectData7Label.Text = "Close Text ID";
                    GameObjectData8Label.Text = "Line of Sight? (0/1)";
                    GameObjectData9Label.Text = "Unused";
                    GameObjectData10Label.Text = "Unused";
                    GameObjectData11Label.Text = "Unused";
                    GameObjectData12Label.Text = "Unused";
                    GameObjectData13Label.Text = "Unused";
                    GameObjectData14Label.Text = "Unused";
                    GameObjectData15Label.Text = "Unused";
                    GameObjectData16Label.Text = "Unused";
                    GameObjectData17Label.Text = "Unused";
                    GameObjectData18Label.Text = "Unused";
                    GameObjectData19Label.Text = "Unused";
                    GameObjectData20Label.Text = "Unused";
                    GameObjectData21Label.Text = "Unused";
                    GameObjectData22Label.Text = "Unused";
                    GameObjectData23Label.Text = "Unused";
                }
                if (EditBox_type.Text == "2")
                {
                    GameObjectDataLabel.Text = "Lock.dbc ID";
                    GameObjectData1Label.Text = "Quest ID";
                    GameObjectData2Label.Text = "PageMaterial ID";
                    GameObjectData3Label.Text = "Gossip Menu ID";
                    GameObjectData4Label.Text = "Custom Anim (1-4)";
                    GameObjectData5Label.Text = "Dmg Immune? (0/1)";
                    GameObjectData6Label.Text = "Open Text ID";
                    GameObjectData7Label.Text = "Line of Sight? (0/1)";
                    GameObjectData8Label.Text = "Allow Mount? (0/1)";
                    GameObjectData9Label.Text = "Large? (0/1)";
                    GameObjectData10Label.Text = "Unused";
                    GameObjectData11Label.Text = "Unused";
                    GameObjectData12Label.Text = "Unused";
                    GameObjectData13Label.Text = "Unused";
                    GameObjectData14Label.Text = "Unused";
                    GameObjectData15Label.Text = "Unused";
                    GameObjectData16Label.Text = "Unused";
                    GameObjectData17Label.Text = "Unused";
                    GameObjectData18Label.Text = "Unused";
                    GameObjectData19Label.Text = "Unused";
                    GameObjectData20Label.Text = "Unused";
                    GameObjectData21Label.Text = "Unused";
                    GameObjectData22Label.Text = "Unused";
                    GameObjectData23Label.Text = "Unused";
                }
                if (EditBox_type.Text == "3")
                {
                    GameObjectDataLabel.Text = "Lock.dbc ID";
                    GameObjectData1Label.Text = "Loot Template ID";
                    GameObjectData2Label.Text = "Restock Time (Seconds)";
                    GameObjectData3Label.Text = "Consumable? (0/1)";
                    GameObjectData4Label.Text = "Minimum Attempts";
                    GameObjectData5Label.Text = "Maximum Attempts";
                    GameObjectData6Label.Text = "Loot Event";
                    GameObjectData7Label.Text = "Trap ID";
                    GameObjectData8Label.Text = "Required Quest ID";
                    GameObjectData9Label.Text = "Min Level to Loot";
                    GameObjectData10Label.Text = "Line of Sight? (0/1)";
                    GameObjectData11Label.Text = "Leave Loot? (0/1)";
                    GameObjectData12Label.Text = "Lootable in Combat? (0/1)";
                    GameObjectData13Label.Text = "Log Loot? (0/1)";
                    GameObjectData14Label.Text = "Open Text ID";
                    GameObjectData15Label.Text = "Group Loot? (0/1)";
                    GameObjectData16Label.Text = "Unused";
                    GameObjectData17Label.Text = "Unused";
                    GameObjectData18Label.Text = "Unused";
                    GameObjectData19Label.Text = "Unused";
                    GameObjectData20Label.Text = "Unused";
                    GameObjectData21Label.Text = "Unused";
                    GameObjectData22Label.Text = "Unused";
                    GameObjectData23Label.Text = "Unused";
                }
                if (EditBox_type.Text == "4")
                {
                    GameObjectDataLabel.Text = "Unused";
                    GameObjectData1Label.Text = "Unused";
                    GameObjectData2Label.Text = "Unused";
                    GameObjectData3Label.Text = "Unused";
                    GameObjectData4Label.Text = "Unused";
                    GameObjectData5Label.Text = "Unused";
                    GameObjectData6Label.Text = "Unused";
                    GameObjectData7Label.Text = "Unused";
                    GameObjectData8Label.Text = "Unused";
                    GameObjectData9Label.Text = "Unused";
                    GameObjectData10Label.Text = "Unused";
                    GameObjectData11Label.Text = "Unused";
                    GameObjectData12Label.Text = "Unused";
                    GameObjectData13Label.Text = "Unused";
                    GameObjectData14Label.Text = "Unused";
                    GameObjectData15Label.Text = "Unused";
                    GameObjectData16Label.Text = "Unused";
                    GameObjectData17Label.Text = "Unused";
                    GameObjectData18Label.Text = "Unused";
                    GameObjectData19Label.Text = "Unused";
                    GameObjectData20Label.Text = "Unused";
                    GameObjectData21Label.Text = "Unused";
                    GameObjectData22Label.Text = "Unused";
                    GameObjectData23Label.Text = "Unused";
                }
                if (EditBox_type.Text == "5")
                {
                    GameObjectDataLabel.Text = "Floating Tooltip? (0/1)";
                    GameObjectData1Label.Text = "Highlight? (0/1)";
                    GameObjectData2Label.Text = "Server Only? (0)";
                    GameObjectData3Label.Text = "Large? (0/1)";
                    GameObjectData4Label.Text = "Float on Water? (0/1)";
                    GameObjectData5Label.Text = "Required Quest ID";
                    GameObjectData6Label.Text = "Unused";
                    GameObjectData7Label.Text = "Unused";
                    GameObjectData8Label.Text = "Unused";
                    GameObjectData9Label.Text = "Unused";
                    GameObjectData10Label.Text = "Unused";
                    GameObjectData11Label.Text = "Unused";
                    GameObjectData12Label.Text = "Unused";
                    GameObjectData13Label.Text = "Unused";
                    GameObjectData14Label.Text = "Unused";
                    GameObjectData15Label.Text = "Unused";
                    GameObjectData16Label.Text = "Unused";
                    GameObjectData17Label.Text = "Unused";
                    GameObjectData18Label.Text = "Unused";
                    GameObjectData19Label.Text = "Unused";
                    GameObjectData20Label.Text = "Unused";
                    GameObjectData21Label.Text = "Unused";
                    GameObjectData22Label.Text = "Unused";
                    GameObjectData23Label.Text = "Unused";
                }
                if (EditBox_type.Text == "6")
                {
                    GameObjectDataLabel.Text = "Lock.dbc ID";
                    GameObjectData1Label.Text = "Level";
                    GameObjectData2Label.Text = "Diameter";
                    GameObjectData3Label.Text = "Spell ID";
                    GameObjectData4Label.Text = "Type (0-2)";
                    GameObjectData5Label.Text = "Cooldown (Seconds)";
                    GameObjectData6Label.Text = "Unknown";
                    GameObjectData7Label.Text = "Start Delay (Seconds)";
                    GameObjectData8Label.Text = "Server Only? (0)";
                    GameObjectData9Label.Text = "Stealthed? (0/1)";
                    GameObjectData10Label.Text = "Large? (0/1)";
                    GameObjectData11Label.Text = "Affect Stealth? (0/1)";
                    GameObjectData12Label.Text = "Open Text ID";
                    GameObjectData13Label.Text = "Unused";
                    GameObjectData14Label.Text = "Unused";
                    GameObjectData15Label.Text = "Unused";
                    GameObjectData16Label.Text = "Unused";
                    GameObjectData17Label.Text = "Unused";
                    GameObjectData18Label.Text = "Unused";
                    GameObjectData19Label.Text = "Unused";
                    GameObjectData20Label.Text = "Unused";
                    GameObjectData21Label.Text = "Unused";
                    GameObjectData22Label.Text = "Unused";
                    GameObjectData23Label.Text = "Unused";
                }
                if (EditBox_type.Text == "7")
                {
                    GameObjectDataLabel.Text = "Number of Slots";
                    GameObjectData1Label.Text = "Orientation";
                    GameObjectData2Label.Text = "Unused";
                    GameObjectData3Label.Text = "Unused";
                    GameObjectData4Label.Text = "Unused";
                    GameObjectData5Label.Text = "Unused";
                    GameObjectData6Label.Text = "Unused";
                    GameObjectData7Label.Text = "Unused";
                    GameObjectData8Label.Text = "Unused";
                    GameObjectData9Label.Text = "Unused";
                    GameObjectData10Label.Text = "Unused";
                    GameObjectData11Label.Text = "Unused";
                    GameObjectData12Label.Text = "Unused";
                    GameObjectData13Label.Text = "Unused";
                    GameObjectData14Label.Text = "Unused";
                    GameObjectData15Label.Text = "Unused";
                    GameObjectData16Label.Text = "Unused";
                    GameObjectData17Label.Text = "Unused";
                    GameObjectData18Label.Text = "Unused";
                    GameObjectData19Label.Text = "Unused";
                    GameObjectData20Label.Text = "Unused";
                    GameObjectData21Label.Text = "Unused";
                    GameObjectData22Label.Text = "Unused";
                    GameObjectData23Label.Text = "Unused";
                }
                if (EditBox_type.Text == "8")
                {
                    GameObjectDataLabel.Text = "SpellFocusType.dbc ID";
                    GameObjectData1Label.Text = "Diameter";
                    GameObjectData2Label.Text = "Linked Trap ID";
                    GameObjectData3Label.Text = "Server Only? (0)";
                    GameObjectData4Label.Text = "Required Quest ID";
                    GameObjectData5Label.Text = "Large? (0/1)";
                    GameObjectData6Label.Text = "Floating Tooltip? (0/1)";
                    GameObjectData7Label.Text = "Unused";
                    GameObjectData8Label.Text = "Unused";
                    GameObjectData9Label.Text = "Unused";
                    GameObjectData10Label.Text = "Unused";
                    GameObjectData11Label.Text = "Unused";
                    GameObjectData12Label.Text = "Unused";
                    GameObjectData13Label.Text = "Unused";
                    GameObjectData14Label.Text = "Unused";
                    GameObjectData15Label.Text = "Unused";
                    GameObjectData16Label.Text = "Unused";
                    GameObjectData17Label.Text = "Unused";
                    GameObjectData18Label.Text = "Unused";
                    GameObjectData19Label.Text = "Unused";
                    GameObjectData20Label.Text = "Unused";
                    GameObjectData21Label.Text = "Unused";
                    GameObjectData22Label.Text = "Unused";
                    GameObjectData23Label.Text = "Unused";
                }
                if (EditBox_type.Text == "9")
                {
                    GameObjectDataLabel.Text = "Page ID";
                    GameObjectData1Label.Text = "Language";
                    GameObjectData2Label.Text = "Page Material";
                    GameObjectData3Label.Text = "Unused";
                    GameObjectData4Label.Text = "Unused";
                    GameObjectData5Label.Text = "Unused";
                    GameObjectData6Label.Text = "Unused";
                    GameObjectData7Label.Text = "Unused";
                    GameObjectData8Label.Text = "Unused";
                    GameObjectData9Label.Text = "Unused";
                    GameObjectData10Label.Text = "Unused";
                    GameObjectData11Label.Text = "Unused";
                    GameObjectData12Label.Text = "Unused";
                    GameObjectData13Label.Text = "Unused";
                    GameObjectData14Label.Text = "Unused";
                    GameObjectData15Label.Text = "Unused";
                    GameObjectData16Label.Text = "Unused";
                    GameObjectData17Label.Text = "Unused";
                    GameObjectData18Label.Text = "Unused";
                    GameObjectData19Label.Text = "Unused";
                    GameObjectData20Label.Text = "Unused";
                    GameObjectData21Label.Text = "Unused";
                    GameObjectData22Label.Text = "Unused";
                    GameObjectData23Label.Text = "Unused";
                }
                if (EditBox_type.Text == "10")
                {
                    GameObjectDataLabel.Text = "Open ID";
                    GameObjectData1Label.Text = "Required Quest ID";
                    GameObjectData2Label.Text = "Event ID";
                    GameObjectData3Label.Text = "Unknown";
                    GameObjectData4Label.Text = "Custom Anim";
                    GameObjectData5Label.Text = "Consumable? (0/1)";
                    GameObjectData6Label.Text = "Cooldown (Seconds)";
                    GameObjectData7Label.Text = "Page ID";
                    GameObjectData8Label.Text = "Language";
                    GameObjectData9Label.Text = "Material ID";
                    GameObjectData10Label.Text = "Spell ID";
                    GameObjectData11Label.Text = "Dmg Immune? (0/1)";
                    GameObjectData12Label.Text = "Linked Trap ID";
                    GameObjectData13Label.Text = "Large? (0/1)";
                    GameObjectData14Label.Text = "Open Text ID";
                    GameObjectData15Label.Text = "Close Text ID";
                    GameObjectData16Label.Text = "Line of Sight? (0/1)";
                    GameObjectData17Label.Text = "Gossip ID";
                    GameObjectData18Label.Text = "Unused";
                    GameObjectData19Label.Text = "Unused";
                    GameObjectData20Label.Text = "Unused";
                    GameObjectData21Label.Text = "Unused";
                    GameObjectData22Label.Text = "Unused";
                    GameObjectData23Label.Text = "Unused";
                }
                if (EditBox_type.Text == "11")
                {
                    GameObjectDataLabel.Text = "Unused";
                    GameObjectData1Label.Text = "Unused";
                    GameObjectData2Label.Text = "Unused";
                    GameObjectData3Label.Text = "Unused";
                    GameObjectData4Label.Text = "Unused";
                    GameObjectData5Label.Text = "Unused";
                    GameObjectData6Label.Text = "Unused";
                    GameObjectData7Label.Text = "Unused";
                    GameObjectData8Label.Text = "Unused";
                    GameObjectData9Label.Text = "Unused";
                    GameObjectData10Label.Text = "Unused";
                    GameObjectData11Label.Text = "Unused";
                    GameObjectData12Label.Text = "Unused";
                    GameObjectData13Label.Text = "Unused";
                    GameObjectData14Label.Text = "Unused";
                    GameObjectData15Label.Text = "Unused";
                    GameObjectData16Label.Text = "Unused";
                    GameObjectData17Label.Text = "Unused";
                    GameObjectData18Label.Text = "Unused";
                    GameObjectData19Label.Text = "Unused";
                    GameObjectData20Label.Text = "Unused";
                    GameObjectData21Label.Text = "Unused";
                    GameObjectData22Label.Text = "Unused";
                    GameObjectData23Label.Text = "Unused";
                }
                if (EditBox_type.Text == "12")
                {
                    GameObjectDataLabel.Text = "Unused";
                    GameObjectData1Label.Text = "Unused";
                    GameObjectData2Label.Text = "Unused";
                    GameObjectData3Label.Text = "Unused";
                    GameObjectData4Label.Text = "Unused";
                    GameObjectData5Label.Text = "Unused";
                    GameObjectData6Label.Text = "Unused";
                    GameObjectData7Label.Text = "Unused";
                    GameObjectData8Label.Text = "Unused";
                    GameObjectData9Label.Text = "Unused";
                    GameObjectData10Label.Text = "Unused";
                    GameObjectData11Label.Text = "Unused";
                    GameObjectData12Label.Text = "Unused";
                    GameObjectData13Label.Text = "Unused";
                    GameObjectData14Label.Text = "Unused";
                    GameObjectData15Label.Text = "Unused";
                    GameObjectData16Label.Text = "Unused";
                    GameObjectData17Label.Text = "Unused";
                    GameObjectData18Label.Text = "Unused";
                    GameObjectData19Label.Text = "Unused";
                    GameObjectData20Label.Text = "Unused";
                    GameObjectData21Label.Text = "Unused";
                    GameObjectData22Label.Text = "Unused";
                    GameObjectData23Label.Text = "Unused";
                }
                if (EditBox_type.Text == "13")
                {
                    GameObjectDataLabel.Text = "Lock.dbc ID";
                    GameObjectData1Label.Text = "Camera ID";
                    GameObjectData2Label.Text = "Unused";
                    GameObjectData3Label.Text = "Unused";
                    GameObjectData4Label.Text = "Unused";
                    GameObjectData5Label.Text = "Unused";
                    GameObjectData6Label.Text = "Unused";
                    GameObjectData7Label.Text = "Unused";
                    GameObjectData8Label.Text = "Unused";
                    GameObjectData9Label.Text = "Unused";
                    GameObjectData10Label.Text = "Unused";
                    GameObjectData11Label.Text = "Unused";
                    GameObjectData12Label.Text = "Unused";
                    GameObjectData13Label.Text = "Unused";
                    GameObjectData14Label.Text = "Unused";
                    GameObjectData15Label.Text = "Unused";
                    GameObjectData16Label.Text = "Unused";
                    GameObjectData17Label.Text = "Unused";
                    GameObjectData18Label.Text = "Unused";
                    GameObjectData19Label.Text = "Unused";
                    GameObjectData20Label.Text = "Unused";
                    GameObjectData21Label.Text = "Unused";
                    GameObjectData22Label.Text = "Unused";
                    GameObjectData23Label.Text = "Unused";
                }
                if (EditBox_type.Text == "14")
                {
                    GameObjectDataLabel.Text = "Unused";
                    GameObjectData1Label.Text = "Unused";
                    GameObjectData2Label.Text = "Unused";
                    GameObjectData3Label.Text = "Unused";
                    GameObjectData4Label.Text = "Unused";
                    GameObjectData5Label.Text = "Unused";
                    GameObjectData6Label.Text = "Unused";
                    GameObjectData7Label.Text = "Unused";
                    GameObjectData8Label.Text = "Unused";
                    GameObjectData9Label.Text = "Unused";
                    GameObjectData10Label.Text = "Unused";
                    GameObjectData11Label.Text = "Unused";
                    GameObjectData12Label.Text = "Unused";
                    GameObjectData13Label.Text = "Unused";
                    GameObjectData14Label.Text = "Unused";
                    GameObjectData15Label.Text = "Unused";
                    GameObjectData16Label.Text = "Unused";
                    GameObjectData17Label.Text = "Unused";
                    GameObjectData18Label.Text = "Unused";
                    GameObjectData19Label.Text = "Unused";
                    GameObjectData20Label.Text = "Unused";
                    GameObjectData21Label.Text = "Unused";
                    GameObjectData22Label.Text = "Unused";
                    GameObjectData23Label.Text = "Unused";
                }
                if (EditBox_type.Text == "15")
                {
                    GameObjectDataLabel.Text = "Taxi Path ID";
                    GameObjectData1Label.Text = "Movement Speed";
                    GameObjectData2Label.Text = "Acceleration Rate";
                    GameObjectData3Label.Text = "Unknown";
                    GameObjectData4Label.Text = "Unknown";
                    GameObjectData5Label.Text = "Unknown";
                    GameObjectData6Label.Text = "Unknown";
                    GameObjectData7Label.Text = "Unused";
                    GameObjectData8Label.Text = "Unused";
                    GameObjectData9Label.Text = "Unused";
                    GameObjectData10Label.Text = "Unused";
                    GameObjectData11Label.Text = "Unused";
                    GameObjectData12Label.Text = "Unused";
                    GameObjectData13Label.Text = "Unused";
                    GameObjectData14Label.Text = "Unused";
                    GameObjectData15Label.Text = "Unused";
                    GameObjectData16Label.Text = "Unused";
                    GameObjectData17Label.Text = "Unused";
                    GameObjectData18Label.Text = "Unused";
                    GameObjectData19Label.Text = "Unused";
                    GameObjectData20Label.Text = "Unused";
                    GameObjectData21Label.Text = "Unused";
                    GameObjectData22Label.Text = "Unused";
                    GameObjectData23Label.Text = "Unused";
                }
                if (EditBox_type.Text == "16")
                {
                    GameObjectDataLabel.Text = "Unused";
                    GameObjectData1Label.Text = "Unused";
                    GameObjectData2Label.Text = "Unused";
                    GameObjectData3Label.Text = "Unused";
                    GameObjectData4Label.Text = "Unused";
                    GameObjectData5Label.Text = "Unused";
                    GameObjectData6Label.Text = "Unused";
                    GameObjectData7Label.Text = "Unused";
                    GameObjectData8Label.Text = "Unused";
                    GameObjectData9Label.Text = "Unused";
                    GameObjectData10Label.Text = "Unused";
                    GameObjectData11Label.Text = "Unused";
                    GameObjectData12Label.Text = "Unused";
                    GameObjectData13Label.Text = "Unused";
                    GameObjectData14Label.Text = "Unused";
                    GameObjectData15Label.Text = "Unused";
                    GameObjectData16Label.Text = "Unused";
                    GameObjectData17Label.Text = "Unused";
                    GameObjectData18Label.Text = "Unused";
                    GameObjectData19Label.Text = "Unused";
                    GameObjectData20Label.Text = "Unused";
                    GameObjectData21Label.Text = "Unused";
                    GameObjectData22Label.Text = "Unused";
                    GameObjectData23Label.Text = "Unused";
                }
                if (EditBox_type.Text == "17")
                {
                    GameObjectDataLabel.Text = "Unused";
                    GameObjectData1Label.Text = "Unused";
                    GameObjectData2Label.Text = "Unused";
                    GameObjectData3Label.Text = "Unused";
                    GameObjectData4Label.Text = "Unused";
                    GameObjectData5Label.Text = "Unused";
                    GameObjectData6Label.Text = "Unused";
                    GameObjectData7Label.Text = "Unused";
                    GameObjectData8Label.Text = "Unused";
                    GameObjectData9Label.Text = "Unused";
                    GameObjectData10Label.Text = "Unused";
                    GameObjectData11Label.Text = "Unused";
                    GameObjectData12Label.Text = "Unused";
                    GameObjectData13Label.Text = "Unused";
                    GameObjectData14Label.Text = "Unused";
                    GameObjectData15Label.Text = "Unused";
                    GameObjectData16Label.Text = "Unused";
                    GameObjectData17Label.Text = "Unused";
                    GameObjectData18Label.Text = "Unused";
                    GameObjectData19Label.Text = "Unused";
                    GameObjectData20Label.Text = "Unused";
                    GameObjectData21Label.Text = "Unused";
                    GameObjectData22Label.Text = "Unused";
                    GameObjectData23Label.Text = "Unused";
                }
                if (EditBox_type.Text == "18")
                {
                    GameObjectDataLabel.Text = "# of Casters";
                    GameObjectData1Label.Text = "Spell ID";
                    GameObjectData2Label.Text = "Animation Spell ID";
                    GameObjectData3Label.Text = "Channel? (0/1)";
                    GameObjectData4Label.Text = "Spell ID Cast on Target";
                    GameObjectData5Label.Text = "Unknown";
                    GameObjectData6Label.Text = "Casters Grouped? (0/1)";
                    GameObjectData7Label.Text = "Unused";
                    GameObjectData8Label.Text = "Unused";
                    GameObjectData9Label.Text = "Unused";
                    GameObjectData10Label.Text = "Unused";
                    GameObjectData11Label.Text = "Unused";
                    GameObjectData12Label.Text = "Unused";
                    GameObjectData13Label.Text = "Unused";
                    GameObjectData14Label.Text = "Unused";
                    GameObjectData15Label.Text = "Unused";
                    GameObjectData16Label.Text = "Unused";
                    GameObjectData17Label.Text = "Unused";
                    GameObjectData18Label.Text = "Unused";
                    GameObjectData19Label.Text = "Unused";
                    GameObjectData20Label.Text = "Unused";
                    GameObjectData21Label.Text = "Unused";
                    GameObjectData22Label.Text = "Unused";
                    GameObjectData23Label.Text = "Unused";
                }
                if (EditBox_type.Text == "19")
                {
                    GameObjectDataLabel.Text = "Unused";
                    GameObjectData1Label.Text = "Unused";
                    GameObjectData2Label.Text = "Unused";
                    GameObjectData3Label.Text = "Unused";
                    GameObjectData4Label.Text = "Unused";
                    GameObjectData5Label.Text = "Unused";
                    GameObjectData6Label.Text = "Unused";
                    GameObjectData7Label.Text = "Unused";
                    GameObjectData8Label.Text = "Unused";
                    GameObjectData9Label.Text = "Unused";
                    GameObjectData10Label.Text = "Unused";
                    GameObjectData11Label.Text = "Unused";
                    GameObjectData12Label.Text = "Unused";
                    GameObjectData13Label.Text = "Unused";
                    GameObjectData14Label.Text = "Unused";
                    GameObjectData15Label.Text = "Unused";
                    GameObjectData16Label.Text = "Unused";
                    GameObjectData17Label.Text = "Unused";
                    GameObjectData18Label.Text = "Unused";
                    GameObjectData19Label.Text = "Unused";
                    GameObjectData20Label.Text = "Unused";
                    GameObjectData21Label.Text = "Unused";
                    GameObjectData22Label.Text = "Unused";
                    GameObjectData23Label.Text = "Unused";
                }
                if (EditBox_type.Text == "20")
                {
                    GameObjectDataLabel.Text = "Auction House ID";
                    GameObjectData1Label.Text = "Unused";
                    GameObjectData2Label.Text = "Unused";
                    GameObjectData3Label.Text = "Unused";
                    GameObjectData4Label.Text = "Unused";
                    GameObjectData5Label.Text = "Unused";
                    GameObjectData6Label.Text = "Unused";
                    GameObjectData7Label.Text = "Unused";
                    GameObjectData8Label.Text = "Unused";
                    GameObjectData9Label.Text = "Unused";
                    GameObjectData10Label.Text = "Unused";
                    GameObjectData11Label.Text = "Unused";
                    GameObjectData12Label.Text = "Unused";
                    GameObjectData13Label.Text = "Unused";
                    GameObjectData14Label.Text = "Unused";
                    GameObjectData15Label.Text = "Unused";
                    GameObjectData16Label.Text = "Unused";
                    GameObjectData17Label.Text = "Unused";
                    GameObjectData18Label.Text = "Unused";
                    GameObjectData19Label.Text = "Unused";
                    GameObjectData20Label.Text = "Unused";
                    GameObjectData21Label.Text = "Unused";
                    GameObjectData22Label.Text = "Unused";
                    GameObjectData23Label.Text = "Unused";
                }
                if (EditBox_type.Text == "21")
                {
                    GameObjectDataLabel.Text = "Creature ID";
                    GameObjectData1Label.Text = "Unknown";
                    GameObjectData2Label.Text = "Unused";
                    GameObjectData3Label.Text = "Unused";
                    GameObjectData4Label.Text = "Unused";
                    GameObjectData5Label.Text = "Unused";
                    GameObjectData6Label.Text = "Unused";
                    GameObjectData7Label.Text = "Unused";
                    GameObjectData8Label.Text = "Unused";
                    GameObjectData9Label.Text = "Unused";
                    GameObjectData10Label.Text = "Unused";
                    GameObjectData11Label.Text = "Unused";
                    GameObjectData12Label.Text = "Unused";
                    GameObjectData13Label.Text = "Unused";
                    GameObjectData14Label.Text = "Unused";
                    GameObjectData15Label.Text = "Unused";
                    GameObjectData16Label.Text = "Unused";
                    GameObjectData17Label.Text = "Unused";
                    GameObjectData18Label.Text = "Unused";
                    GameObjectData19Label.Text = "Unused";
                    GameObjectData20Label.Text = "Unused";
                    GameObjectData21Label.Text = "Unused";
                    GameObjectData22Label.Text = "Unused";
                    GameObjectData23Label.Text = "Unused";
                }
                if (EditBox_type.Text == "22")
                {
                    GameObjectDataLabel.Text = "Spell ID";
                    GameObjectData1Label.Text = "Charges";
                    GameObjectData2Label.Text = "Party Only? (0/1)";
                    GameObjectData3Label.Text = "Unused";
                    GameObjectData4Label.Text = "Unused";
                    GameObjectData5Label.Text = "Unused";
                    GameObjectData6Label.Text = "Unused";
                    GameObjectData7Label.Text = "Unused";
                    GameObjectData8Label.Text = "Unused";
                    GameObjectData9Label.Text = "Unused";
                    GameObjectData10Label.Text = "Unused";
                    GameObjectData11Label.Text = "Unused";
                    GameObjectData12Label.Text = "Unused";
                    GameObjectData13Label.Text = "Unused";
                    GameObjectData14Label.Text = "Unused";
                    GameObjectData15Label.Text = "Unused";
                    GameObjectData16Label.Text = "Unused";
                    GameObjectData17Label.Text = "Unused";
                    GameObjectData18Label.Text = "Unused";
                    GameObjectData19Label.Text = "Unused";
                    GameObjectData20Label.Text = "Unused";
                    GameObjectData21Label.Text = "Unused";
                    GameObjectData22Label.Text = "Unused";
                    GameObjectData23Label.Text = "Unused";
                }
                if (EditBox_type.Text == "23")
                {
                    GameObjectDataLabel.Text = "Min Level";
                    GameObjectData1Label.Text = "Max Level";
                    GameObjectData2Label.Text = "AreaTable.dbc ID";
                    GameObjectData3Label.Text = "Unused";
                    GameObjectData4Label.Text = "Unused";
                    GameObjectData5Label.Text = "Unused";
                    GameObjectData6Label.Text = "Unused";
                    GameObjectData7Label.Text = "Unused";
                    GameObjectData8Label.Text = "Unused";
                    GameObjectData9Label.Text = "Unused";
                    GameObjectData10Label.Text = "Unused";
                    GameObjectData11Label.Text = "Unused";
                    GameObjectData12Label.Text = "Unused";
                    GameObjectData13Label.Text = "Unused";
                    GameObjectData14Label.Text = "Unused";
                    GameObjectData15Label.Text = "Unused";
                    GameObjectData16Label.Text = "Unused";
                    GameObjectData17Label.Text = "Unused";
                    GameObjectData18Label.Text = "Unused";
                    GameObjectData19Label.Text = "Unused";
                    GameObjectData20Label.Text = "Unused";
                    GameObjectData21Label.Text = "Unused";
                    GameObjectData22Label.Text = "Unused";
                    GameObjectData23Label.Text = "Unused";
                }
                if (EditBox_type.Text == "24")
                {
                    GameObjectDataLabel.Text = "Lock.dbc ID";
                    GameObjectData1Label.Text = "Spell ID on Pickup";
                    GameObjectData2Label.Text = "Radius";
                    GameObjectData3Label.Text = "Aura ID on Return";
                    GameObjectData4Label.Text = "Spell ID on Return";
                    GameObjectData5Label.Text = "Dmg Immune? (0/1)";
                    GameObjectData6Label.Text = "Unknown";
                    GameObjectData7Label.Text = "Line of Sight? (0/1)";
                    GameObjectData8Label.Text = "Unused";
                    GameObjectData9Label.Text = "Unused";
                    GameObjectData10Label.Text = "Unused";
                    GameObjectData11Label.Text = "Unused";
                    GameObjectData12Label.Text = "Unused";
                    GameObjectData13Label.Text = "Unused";
                    GameObjectData14Label.Text = "Unused";
                    GameObjectData15Label.Text = "Unused";
                    GameObjectData16Label.Text = "Unused";
                    GameObjectData17Label.Text = "Unused";
                    GameObjectData18Label.Text = "Unused";
                    GameObjectData19Label.Text = "Unused";
                    GameObjectData20Label.Text = "Unused";
                    GameObjectData21Label.Text = "Unused";
                    GameObjectData22Label.Text = "Unused";
                    GameObjectData23Label.Text = "Unused";
                }
                if (EditBox_type.Text == "25")
                {
                    GameObjectDataLabel.Text = "Radius";
                    GameObjectData1Label.Text = "Loot ID";
                    GameObjectData2Label.Text = "Min Loot to Despawn";
                    GameObjectData3Label.Text = "Max Loot to Despawn";
                    GameObjectData4Label.Text = "Unused";
                    GameObjectData5Label.Text = "Unused";
                    GameObjectData6Label.Text = "Unused";
                    GameObjectData7Label.Text = "Unused";
                    GameObjectData8Label.Text = "Unused";
                    GameObjectData9Label.Text = "Unused";
                    GameObjectData10Label.Text = "Unused";
                    GameObjectData11Label.Text = "Unused";
                    GameObjectData12Label.Text = "Unused";
                    GameObjectData13Label.Text = "Unused";
                    GameObjectData14Label.Text = "Unused";
                    GameObjectData15Label.Text = "Unused";
                    GameObjectData16Label.Text = "Unused";
                    GameObjectData17Label.Text = "Unused";
                    GameObjectData18Label.Text = "Unused";
                    GameObjectData19Label.Text = "Unused";
                    GameObjectData20Label.Text = "Unused";
                    GameObjectData21Label.Text = "Unused";
                    GameObjectData22Label.Text = "Unused";
                    GameObjectData23Label.Text = "Unused";
                }
                if (EditBox_type.Text == "26")
                {
                    GameObjectDataLabel.Text = "Lock.dbc ID";
                    GameObjectData1Label.Text = "Event ID";
                    GameObjectData2Label.Text = "Spell Cast on Pickup";
                    GameObjectData3Label.Text = "Dmg Immune? (0/1)";
                    GameObjectData4Label.Text = "Unused";
                    GameObjectData5Label.Text = "Unused";
                    GameObjectData6Label.Text = "Unused";
                    GameObjectData7Label.Text = "Unused";
                    GameObjectData8Label.Text = "Unused";
                    GameObjectData9Label.Text = "Unused";
                    GameObjectData10Label.Text = "Unused";
                    GameObjectData11Label.Text = "Unused";
                    GameObjectData12Label.Text = "Unused";
                    GameObjectData13Label.Text = "Unused";
                    GameObjectData14Label.Text = "Unused";
                    GameObjectData15Label.Text = "Unused";
                    GameObjectData16Label.Text = "Unused";
                    GameObjectData17Label.Text = "Unused";
                    GameObjectData18Label.Text = "Unused";
                    GameObjectData19Label.Text = "Unused";
                    GameObjectData20Label.Text = "Unused";
                    GameObjectData21Label.Text = "Unused";
                    GameObjectData22Label.Text = "Unused";
                    GameObjectData23Label.Text = "Unused";
                }
                if (EditBox_type.Text == "27")
                {
                    GameObjectDataLabel.Text = "Unused";
                    GameObjectData1Label.Text = "Unused";
                    GameObjectData2Label.Text = "Unused";
                    GameObjectData3Label.Text = "Unused";
                    GameObjectData4Label.Text = "Unused";
                    GameObjectData5Label.Text = "Unused";
                    GameObjectData6Label.Text = "Unused";
                    GameObjectData7Label.Text = "Unused";
                    GameObjectData8Label.Text = "Unused";
                    GameObjectData9Label.Text = "Unused";
                    GameObjectData10Label.Text = "Unused";
                    GameObjectData11Label.Text = "Unused";
                    GameObjectData12Label.Text = "Unused";
                    GameObjectData13Label.Text = "Unused";
                    GameObjectData14Label.Text = "Unused";
                    GameObjectData15Label.Text = "Unused";
                    GameObjectData16Label.Text = "Unused";
                    GameObjectData17Label.Text = "Unused";
                    GameObjectData18Label.Text = "Unused";
                    GameObjectData19Label.Text = "Unused";
                    GameObjectData20Label.Text = "Unused";
                    GameObjectData21Label.Text = "Unused";
                    GameObjectData22Label.Text = "Unused";
                    GameObjectData23Label.Text = "Unused";
                }
                if (EditBox_type.Text == "28")
                {
                    GameObjectDataLabel.Text = "Unused";
                    GameObjectData1Label.Text = "Unused";
                    GameObjectData2Label.Text = "Unused";
                    GameObjectData3Label.Text = "Unused";
                    GameObjectData4Label.Text = "Unused";
                    GameObjectData5Label.Text = "Unused";
                    GameObjectData6Label.Text = "Unused";
                    GameObjectData7Label.Text = "Unused";
                    GameObjectData8Label.Text = "Unused";
                    GameObjectData9Label.Text = "Unused";
                    GameObjectData10Label.Text = "Unused";
                    GameObjectData11Label.Text = "Unused";
                    GameObjectData12Label.Text = "Unused";
                    GameObjectData13Label.Text = "Unused";
                    GameObjectData14Label.Text = "Unused";
                    GameObjectData15Label.Text = "Unused";
                    GameObjectData16Label.Text = "Unused";
                    GameObjectData17Label.Text = "Unused";
                    GameObjectData18Label.Text = "Unused";
                    GameObjectData19Label.Text = "Unused";
                    GameObjectData20Label.Text = "Unused";
                    GameObjectData21Label.Text = "Unused";
                    GameObjectData22Label.Text = "Unused";
                    GameObjectData23Label.Text = "Unused";
                }
                if (EditBox_type.Text == "29")
                {
                    GameObjectDataLabel.Text = "Radius";
                    GameObjectData1Label.Text = "Spell?";
                    GameObjectData2Label.Text = "Worldstate 1";
                    GameObjectData3Label.Text = "Worldstate 2";
                    GameObjectData4Label.Text = "Win Event ID 1";
                    GameObjectData5Label.Text = "Win Event ID 2";
                    GameObjectData6Label.Text = "Contest Event ID 1";
                    GameObjectData7Label.Text = "Contest Event ID 2";
                    GameObjectData8Label.Text = "Progress Event ID 1";
                    GameObjectData9Label.Text = "Progress Event ID 2";
                    GameObjectData10Label.Text = "Neutral Event ID 1";
                    GameObjectData11Label.Text = "Neutral Event ID 2";
                    GameObjectData12Label.Text = "Neutral Percentage";
                    GameObjectData13Label.Text = "Worldstate 3";
                    GameObjectData14Label.Text = "Min Superiority";
                    GameObjectData15Label.Text = "Max Superiority";
                    GameObjectData16Label.Text = "Min Time (Seconds)";
                    GameObjectData17Label.Text = "Max Time (Seconds)";
                    GameObjectData18Label.Text = "Large? (0/1)";
                    GameObjectData19Label.Text = "Unused";
                    GameObjectData20Label.Text = "Unused";
                    GameObjectData21Label.Text = "Unused";
                    GameObjectData22Label.Text = "Unused";
                    GameObjectData23Label.Text = "Unused";
                }
                if (EditBox_type.Text == "30")
                {
                    GameObjectDataLabel.Text = "Start Open (0/1)";
                    GameObjectData1Label.Text = "Radius";
                    GameObjectData2Label.Text = "Aura ID";
                    GameObjectData3Label.Text = "Condition ID";
                    GameObjectData4Label.Text = "Unused";
                    GameObjectData5Label.Text = "Unused";
                    GameObjectData6Label.Text = "Unused";
                    GameObjectData7Label.Text = "Unused";
                    GameObjectData8Label.Text = "Unused";
                    GameObjectData9Label.Text = "Unused";
                    GameObjectData10Label.Text = "Unused";
                    GameObjectData11Label.Text = "Unused";
                    GameObjectData12Label.Text = "Unused";
                    GameObjectData13Label.Text = "Unused";
                    GameObjectData14Label.Text = "Unused";
                    GameObjectData15Label.Text = "Unused";
                    GameObjectData16Label.Text = "Unused";
                    GameObjectData17Label.Text = "Unused";
                    GameObjectData18Label.Text = "Unused";
                    GameObjectData19Label.Text = "Unused";
                    GameObjectData20Label.Text = "Unused";
                    GameObjectData21Label.Text = "Unused";
                    GameObjectData22Label.Text = "Unused";
                    GameObjectData23Label.Text = "Unused";
                }
                if (EditBox_type.Text == "31")
                {
                    GameObjectDataLabel.Text = "Map ID";
                    GameObjectData1Label.Text = "Difficulty";
                    GameObjectData2Label.Text = "Unused";
                    GameObjectData3Label.Text = "Unused";
                    GameObjectData4Label.Text = "Unused";
                    GameObjectData5Label.Text = "Unused";
                    GameObjectData6Label.Text = "Unused";
                    GameObjectData7Label.Text = "Unused";
                    GameObjectData8Label.Text = "Unused";
                    GameObjectData9Label.Text = "Unused";
                    GameObjectData10Label.Text = "Unused";
                    GameObjectData11Label.Text = "Unused";
                    GameObjectData12Label.Text = "Unused";
                    GameObjectData13Label.Text = "Unused";
                    GameObjectData14Label.Text = "Unused";
                    GameObjectData15Label.Text = "Unused";
                    GameObjectData16Label.Text = "Unused";
                    GameObjectData17Label.Text = "Unused";
                    GameObjectData18Label.Text = "Unused";
                    GameObjectData19Label.Text = "Unused";
                    GameObjectData20Label.Text = "Unused";
                    GameObjectData21Label.Text = "Unused";
                    GameObjectData22Label.Text = "Unused";
                    GameObjectData23Label.Text = "Unused";
                }
                if (EditBox_type.Text == "32")
                {
                    GameObjectDataLabel.Text = "Unused";
                    GameObjectData1Label.Text = "Unused";
                    GameObjectData2Label.Text = "Unused";
                    GameObjectData3Label.Text = "Unused";
                    GameObjectData4Label.Text = "Unused";
                    GameObjectData5Label.Text = "Unused";
                    GameObjectData6Label.Text = "Unused";
                    GameObjectData7Label.Text = "Unused";
                    GameObjectData8Label.Text = "Unused";
                    GameObjectData9Label.Text = "Unused";
                    GameObjectData10Label.Text = "Unused";
                    GameObjectData11Label.Text = "Unused";
                    GameObjectData12Label.Text = "Unused";
                    GameObjectData13Label.Text = "Unused";
                    GameObjectData14Label.Text = "Unused";
                    GameObjectData15Label.Text = "Unused";
                    GameObjectData16Label.Text = "Unused";
                    GameObjectData17Label.Text = "Unused";
                    GameObjectData18Label.Text = "Unused";
                    GameObjectData19Label.Text = "Unused";
                    GameObjectData20Label.Text = "Unused";
                    GameObjectData21Label.Text = "Unused";
                    GameObjectData22Label.Text = "Unused";
                    GameObjectData23Label.Text = "Unused";
                }
                if (EditBox_type.Text == "33")
                {
                    GameObjectDataLabel.Text = "Intact for Hits";
                    GameObjectData1Label.Text = "Creature Giving Credit";
                    GameObjectData2Label.Text = "State 1 Name";
                    GameObjectData3Label.Text = "Intact Event";
                    GameObjectData4Label.Text = "Damaged Display ID";
                    GameObjectData5Label.Text = "Damaged for Hits";
                    GameObjectData6Label.Text = "Unused";
                    GameObjectData7Label.Text = "Unused";
                    GameObjectData8Label.Text = "Unused";
                    GameObjectData9Label.Text = "Destroyed Event";
                    GameObjectData10Label.Text = "Destroyed Display ID";
                    GameObjectData11Label.Text = "Unused";
                    GameObjectData12Label.Text = "Unused";
                    GameObjectData13Label.Text = "Unused";
                    GameObjectData14Label.Text = "Destroyed Event";
                    GameObjectData15Label.Text = "Unused";
                    GameObjectData16Label.Text = "Debuild Time (Seconds)";
                    GameObjectData17Label.Text = "Unused";
                    GameObjectData18Label.Text = "Destructible Data";
                    GameObjectData19Label.Text = "Rebuilding Event";
                    GameObjectData20Label.Text = "Unused";
                    GameObjectData21Label.Text = "Unused";
                    GameObjectData22Label.Text = "Damage Event";
                    GameObjectData23Label.Text = "Unused";
                }
                if (EditBox_type.Text == "34")
                {
                    GameObjectDataLabel.Text = "Unused";
                    GameObjectData1Label.Text = "Unused";
                    GameObjectData2Label.Text = "Unused";
                    GameObjectData3Label.Text = "Unused";
                    GameObjectData4Label.Text = "Unused";
                    GameObjectData5Label.Text = "Unused";
                    GameObjectData6Label.Text = "Unused";
                    GameObjectData7Label.Text = "Unused";
                    GameObjectData8Label.Text = "Unused";
                    GameObjectData9Label.Text = "Unused";
                    GameObjectData10Label.Text = "Unused";
                    GameObjectData11Label.Text = "Unused";
                    GameObjectData12Label.Text = "Unused";
                    GameObjectData13Label.Text = "Unused";
                    GameObjectData14Label.Text = "Unused";
                    GameObjectData15Label.Text = "Unused";
                    GameObjectData16Label.Text = "Unused";
                    GameObjectData17Label.Text = "Unused";
                    GameObjectData18Label.Text = "Unused";
                    GameObjectData19Label.Text = "Unused";
                    GameObjectData20Label.Text = "Unused";
                    GameObjectData21Label.Text = "Unused";
                    GameObjectData22Label.Text = "Unused";
                    GameObjectData23Label.Text = "Unused";
                }
                if (EditBox_type.Text == "35")
                {
                    GameObjectDataLabel.Text = "When to Pause";
                    GameObjectData1Label.Text = "Start Open (0/1)";
                    GameObjectData2Label.Text = "Auto Close (MS)";
                    GameObjectData3Label.Text = "Unused";
                    GameObjectData4Label.Text = "Unused";
                    GameObjectData5Label.Text = "Unused";
                    GameObjectData6Label.Text = "Unused";
                    GameObjectData7Label.Text = "Unused";
                    GameObjectData8Label.Text = "Unused";
                    GameObjectData9Label.Text = "Unused";
                    GameObjectData10Label.Text = "Unused";
                    GameObjectData11Label.Text = "Unused";
                    GameObjectData12Label.Text = "Unused";
                    GameObjectData13Label.Text = "Unused";
                    GameObjectData14Label.Text = "Unused";
                    GameObjectData15Label.Text = "Unused";
                    GameObjectData16Label.Text = "Unused";
                    GameObjectData17Label.Text = "Unused";
                    GameObjectData18Label.Text = "Unused";
                    GameObjectData19Label.Text = "Unused";
                    GameObjectData20Label.Text = "Unused";
                    GameObjectData21Label.Text = "Unused";
                    GameObjectData22Label.Text = "Unused";
                    GameObjectData23Label.Text = "Unused";
                }
            }
            catch
            {
                    GameObjectDataLabel.Text = "Unused";
                    GameObjectData1Label.Text = "Unused";
                    GameObjectData2Label.Text = "Unused";
                    GameObjectData3Label.Text = "Unused";
                    GameObjectData4Label.Text = "Unused";
                    GameObjectData5Label.Text = "Unused";
                    GameObjectData6Label.Text = "Unused";
                    GameObjectData7Label.Text = "Unused";
                    GameObjectData8Label.Text = "Unused";
                    GameObjectData9Label.Text = "Unused";
                    GameObjectData10Label.Text = "Unused";
                    GameObjectData11Label.Text = "Unused";
                    GameObjectData12Label.Text = "Unused";
                    GameObjectData13Label.Text = "Unused";
                    GameObjectData14Label.Text = "Unused";
                    GameObjectData15Label.Text = "Unused";
                    GameObjectData16Label.Text = "Unused";
                    GameObjectData17Label.Text = "Unused";
                    GameObjectData18Label.Text = "Unused";
                    GameObjectData19Label.Text = "Unused";
                    GameObjectData20Label.Text = "Unused";
                    GameObjectData21Label.Text = "Unused";
                    GameObjectData22Label.Text = "Unused";
                    GameObjectData23Label.Text = "Unused";
            }
        }
    }
}
