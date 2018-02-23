using MetroFramework;
using MetroFramework.Forms;
using Org.Mentalis.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NextAIPolicyEditor2
{
    public partial class MainForm : MetroForm
    {
        public AIPolicy ai;
        new bool OnLoad = true;
        IniReader ini;

        public MainForm()
        {
            ini = new IniReader(Application.StartupPath + "\\Settings.ini");
            InitializeComponent();
            operation_param.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            operation_param.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            select_lang.DropDownStyle = ComboBoxStyle.DropDownList;
            TargetType.DropDownStyle = ComboBoxStyle.DropDownList;
            rootcondition_center.DropDownStyle = ComboBoxStyle.DropDownList;
            rootcondition_left.DropDownStyle = ComboBoxStyle.DropDownList;
            rootcondition_right.DropDownStyle = ComboBoxStyle.DropDownList;
            operationsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            Lang.Init();
            Operations.Init();
            CustomData.Init();
            foreach (string l in Lang.Langs.Keys)
            {
                select_lang.Items.Add(l);
            }
            select_lang.SelectedIndex = ini.ReadInteger("GENERAL", "Lang", 0);
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ai = new AIFile().Read(ofd.FileName, this);
                LoadData(0);
            }
        }

        public void LoadData(byte type)
        {
            OnLoad = true;
            switch (type)
            {
                case 0:
                    int prev = triggers_list.SelectedIndex;
                    triggers_list.BeginUpdate();
                    triggers_list.Items.Clear();
                    controllers_list.Items.Clear();
                    operations_list.Items.Clear();
                    operation_param.Rows.Clear();
                    disableAll();
                    for (int i = 0; i < ai.controllers.Count; ++i)
                    {
                        triggers_list.Items.Add(ai.controllers[i].ID);
                    }
                    triggers_list.EndUpdate();
                    triggers_list.SelectedIndex = triggers_list.Items.Count > prev ? prev : 0;
                    controllers_list.ClearSelected();
                    break;
                case 1:
                    int prevc = controllers_list.SelectedIndex;
                    controllers_list.BeginUpdate();
                    controllers_list.Items.Clear();
                    operations_list.Items.Clear();
                    operation_param.Rows.Clear();
                    disableAll();
                    controller_box.Text = string.Format(Lang.Translate("controller_box_txt"), ai.controllers[triggers_list.SelectedIndex].version);
                    for (int i = 0; i < ai.controllers[triggers_list.SelectedIndex].CTD.Count; ++i)
                    {
                        controllers_list.Items.Add(string.Format("[{0}] {1}", ai.controllers[triggers_list.SelectedIndex].CTD[i].uID, ai.controllers[triggers_list.SelectedIndex].CTD[i].Name));
                    }
                    controllers_list.EndUpdate();
                    trigger_id.Text = ai.controllers[triggers_list.SelectedIndex].ID.ToString();
                    if (controllers_list.Items.Count > 0) controllers_list.SelectedIndex = controllers_list.Items.Count > prevc ? prevc : 0;
                    string mobs = "Mobs: ";
                    foreach (string s in CustomData.GetAi(ai.controllers[triggers_list.SelectedIndex].ID))
                    {
                        mobs += string.Format("{0}, ", s);
                    }
                    mobs = mobs.Substring(0, mobs.Length - 2);
                    triggers_mobs.Text = mobs;
                    break;
                case 2:
                    operations_list.BeginUpdate();
                    operations_list.Items.Clear();
                    operation_param.Rows.Clear();
                    operation_box.Text = string.Format(Lang.Translate("operation_box_txt"), ai.controllers[triggers_list.SelectedIndex].CTD[controllers_list.SelectedIndex].version);
                    controller_id.Text = ai.controllers[triggers_list.SelectedIndex].CTD[controllers_list.SelectedIndex].uID.ToString();
                    controller_name.Text = ai.controllers[triggers_list.SelectedIndex].CTD[controllers_list.SelectedIndex].Name;
                    bActive.Checked = ai.controllers[triggers_list.SelectedIndex].CTD[controllers_list.SelectedIndex].bActive;
                    bRun.Checked = ai.controllers[triggers_list.SelectedIndex].CTD[controllers_list.SelectedIndex].bRun;
                    bAttackValid.Checked = ai.controllers[triggers_list.SelectedIndex].CTD[controllers_list.SelectedIndex].bAttackValid;
                    for (int i = 0; i < ai.controllers[triggers_list.SelectedIndex].CTD[controllers_list.SelectedIndex].listOperation.Count; ++i)
                    {
                        string op_name = Lang.Translate(Operations.GetInfo(ai.controllers[triggers_list.SelectedIndex].CTD[controllers_list.SelectedIndex].listOperation[i].iType, ai.controllers[triggers_list.SelectedIndex].version).Name);
                        operations_list.Items.Add(string.Format("[{0}] {1}", i, op_name));
                    }
                    operations_list.EndUpdate();
                    LoadCondition(ai.controllers[triggers_list.SelectedIndex].CTD[controllers_list.SelectedIndex].rootConditon);
                    break;
                case 3:
                    CTriggerDataOperation ctdo = ai.controllers[triggers_list.SelectedIndex].CTD[controllers_list.SelectedIndex].listOperation[operations_list.SelectedIndex];
                    operation_param.Rows.Clear();
                    if (ctdo.iType == 2)
                    {
                        DataGridViewComboBoxCell combobox = new DataGridViewComboBoxCell();
                        foreach (string field in Operations.Channels.Values) combobox.Items.Add(Lang.Translate(field));
                        foreach (string field in Operations.GetInfo(ctdo.iType, ai.controllers[triggers_list.SelectedIndex].CTD[controllers_list.SelectedIndex].version).Fields)
                        {
                            operation_param.Rows.Add(Lang.Translate(field), "");
                        }
                        operation_param.Rows[0].Cells[1] = combobox;
                        operation_param.Rows[0].Cells[1].Value = Operations.Channels.Keys.Contains(ctdo.pParam[0].ToString()) ? Operations.Channels[ctdo.pParam[0].ToString()] : Operations.Channels[""];
                        for (int i = 1; i < ctdo.pParam.Length; ++i)
                        {
                            operation_param.Rows[i].Cells[1].Value = ctdo.pParam[i].ToString();
                        }
                    }
                    else
                    {
                        string[] fields = Operations.GetInfo(ctdo.iType, ai.controllers[triggers_list.SelectedIndex].CTD[controllers_list.SelectedIndex].version).Fields;
                        for (int i = 0; i < ctdo.pParam.Length; ++i)
                        {
                            operation_param.Rows.Add(Lang.Translate(fields[i]), ctdo.pParam[i].ToString());
                        }
                    }
                    TargetType.SelectedIndex = ctdo.iTargetType;
                    if (ctdo.iTargetType == 6)
                    {
                        target_param.Visible = true;
                        target_param_txt.Visible = true;
                        target_param.Text = ctdo.pTargetParam.ToString();
                    }
                    else
                    {
                        target_param.Visible = false;
                        target_param_txt.Visible = false;
                    }
                    break;
                default:
                    break;
            }
            OnLoad = false;
        }

        private void SaveData(object sender, EventArgs e)
        {
            if (OnLoad) return;
            Control c = sender as Control;
            try
            {
                switch (c.Name)
                {
                    case "trigger_id":
                        if (triggers_list.SelectedIndex > -1)
                        {
                            ai.controllers[triggers_list.SelectedIndex].ID = Convert.ToInt32(c.Text);
                            triggers_list.SelectedValue = c.Text;
                        }
                        break;
                    case "controller_id":
                        if (controllers_list.SelectedIndex > -1)
                        {
                            ai.controllers[triggers_list.SelectedIndex].CTD[controllers_list.SelectedIndex].uID = Convert.ToInt32(c.Text);
                            LoadData(1);
                        }
                        break;
                    case "controller_name":
                        if (controllers_list.SelectedIndex > -1)
                        {
                            ai.controllers[triggers_list.SelectedIndex].CTD[controllers_list.SelectedIndex].Name = c.Text;
                            LoadData(1);
                        }
                        break;
                    case "bActive":
                        if (controllers_list.SelectedIndex > -1)
                        {
                            CheckBox cb = (CheckBox)sender;
                            ai.controllers[triggers_list.SelectedIndex].CTD[controllers_list.SelectedIndex].bActive = cb.Checked;
                        }
                        break;
                    case "bRun":
                        if (controllers_list.SelectedIndex > -1)
                        {
                            CheckBox cb = (CheckBox)sender;
                            ai.controllers[triggers_list.SelectedIndex].CTD[controllers_list.SelectedIndex].bRun = cb.Checked;
                        }
                        break;
                    case "bAttackValid":
                        if (controllers_list.SelectedIndex > -1)
                        {
                            CheckBox cb = (CheckBox)sender;
                            ai.controllers[triggers_list.SelectedIndex].CTD[controllers_list.SelectedIndex].bAttackValid = cb.Checked;
                        }
                        break;
                    case "TargetType":
                        if (operations_list.SelectedIndex > -1)
                        {
                            ComboBox cb = (ComboBox)sender;
                            ai.controllers[triggers_list.SelectedIndex].CTD[controllers_list.SelectedIndex].listOperation[operations_list.SelectedIndex].iTargetType = cb.SelectedIndex;
                            LoadData(3);
                        }
                        break;
                    case "target_param":
                        if (operations_list.SelectedIndex > -1)
                        {
                            ai.controllers[triggers_list.SelectedIndex].CTD[controllers_list.SelectedIndex].listOperation[operations_list.SelectedIndex].pTargetParam = Convert.ToInt32(c.Text);
                        }
                        break;
                    case "rootcondition_center":
                        if (controllers_list.SelectedIndex > -1)
                        {
                            ai.controllers[triggers_list.SelectedIndex].CTD[controllers_list.SelectedIndex].rootConditon.OperID = rootcondition_center.SelectedIndex;
                            ai.controllers[triggers_list.SelectedIndex].CTD[controllers_list.SelectedIndex].rootConditon.Value = Conditions.CreateEmptyCondition(rootcondition_center.SelectedIndex);
                            ai.controllers[triggers_list.SelectedIndex].CTD[controllers_list.SelectedIndex].rootConditon.Type = Conditions.GetTypeByID(rootcondition_center.SelectedIndex);
                            Conditions.SetSubnoteByID(ref ai.controllers[triggers_list.SelectedIndex].CTD[controllers_list.SelectedIndex].rootConditon);
                            LoadCondition(ai.controllers[triggers_list.SelectedIndex].CTD[controllers_list.SelectedIndex].rootConditon);
                        }
                        break;
                    case "rootcondition_left":
                        if (controllers_list.SelectedIndex > -1)
                        {
                            int index = Array.IndexOf(Conditions.Non_central(), rootcondition_left.SelectedIndex);
                            ai.controllers[triggers_list.SelectedIndex].CTD[controllers_list.SelectedIndex].rootConditon.ConditionLeft.OperID = index;
                            ai.controllers[triggers_list.SelectedIndex].CTD[controllers_list.SelectedIndex].rootConditon.ConditionLeft.Value = Conditions.CreateEmptyCondition(index);
                            ai.controllers[triggers_list.SelectedIndex].CTD[controllers_list.SelectedIndex].rootConditon.ConditionLeft.Type = Conditions.GetTypeByID(index);
                            Conditions.SetSubnoteByID(ref ai.controllers[triggers_list.SelectedIndex].CTD[controllers_list.SelectedIndex].rootConditon.ConditionLeft);
                            LoadCondition(ai.controllers[triggers_list.SelectedIndex].CTD[controllers_list.SelectedIndex].rootConditon);
                        }
                        break;
                    case "rootcondition_right":
                        if (controllers_list.SelectedIndex > -1)
                        {
                            int index = Array.IndexOf(Conditions.Non_central(), rootcondition_right.SelectedIndex);
                            ai.controllers[triggers_list.SelectedIndex].CTD[controllers_list.SelectedIndex].rootConditon.ConditionRight.OperID = index;
                            ai.controllers[triggers_list.SelectedIndex].CTD[controllers_list.SelectedIndex].rootConditon.ConditionRight.Value = Conditions.CreateEmptyCondition(index);
                            ai.controllers[triggers_list.SelectedIndex].CTD[controllers_list.SelectedIndex].rootConditon.ConditionRight.Type = Conditions.GetTypeByID(index);
                            Conditions.SetSubnoteByID(ref ai.controllers[triggers_list.SelectedIndex].CTD[controllers_list.SelectedIndex].rootConditon.ConditionRight);
                            LoadCondition(ai.controllers[triggers_list.SelectedIndex].CTD[controllers_list.SelectedIndex].rootConditon);
                        }
                        break;
                    case "rootcondition_left_param1":
                    case "rootcondition_left_param2":
                        ai.controllers[triggers_list.SelectedIndex].CTD[controllers_list.SelectedIndex].rootConditon.ConditionLeft.Value = Conditions.Write(new object[] { rootcondition_left_param1.Text, rootcondition_left_param2.Text }, Array.IndexOf(Conditions.Non_central(), rootcondition_left.SelectedIndex));
                        break;
                    case "rootcondition_param1":
                    case "rootcondition_param2":
                        ai.controllers[triggers_list.SelectedIndex].CTD[controllers_list.SelectedIndex].rootConditon.Value = Conditions.Write(new object[] { rootcondition_param1.Text, rootcondition_param2.Text }, rootcondition_center.SelectedIndex);
                        break;
                    case "rootcondition_right_param1":
                    case "rootcondition_right_param2":
                        ai.controllers[triggers_list.SelectedIndex].CTD[controllers_list.SelectedIndex].rootConditon.ConditionRight.Value = Conditions.Write(new object[] { rootcondition_right_param1.Text, rootcondition_right_param2.Text }, Array.IndexOf(Conditions.Non_central(), rootcondition_right.SelectedIndex));
                        break;
                    default:
                        MessageBox.Show("Amazing, but unknown control");
                        break;
                }
            }
            catch { }
        }

        public void disableAll()
        {
            rootcondition_left.Visible = false;
            rootcondition_right.Visible = false;
            rootcondition_txt1.Visible = false;
            rootcondition_param1.Visible = false;
            rootcondition_txt2.Visible = false;
            rootcondition_param2.Visible = false;
            rootcondition_txt1.Visible = false;
            rootcondition_param1.Visible = false;
            rootcondition_txt2.Visible = false;
            rootcondition_param2.Visible = false;
            rootcondition_right_txt1.Visible = false;
            rootcondition_right_param1.Visible = false;
            rootcondition_right_txt2.Visible = false;
            rootcondition_right_param2.Visible = false;
            rootcondition_left_txt1.Visible = false;
            rootcondition_left_param1.Visible = false;
            rootcondition_left_txt2.Visible = false;
            rootcondition_left_param2.Visible = false;
            SubConditionLeft.Visible = false;
            SubConditionRight.Visible = false;
        }

        public void LoadCondition(CTriggerDataCondition ctdc)
        {
            if (ctdc.ConditionLeft == null) ctdc.ConditionLeft = new CTriggerDataCondition();
            if (ctdc.ConditionRight == null) ctdc.ConditionRight = new CTriggerDataCondition();
            disableAll();
            int index = 0;
            rootcondition_center.SelectedIndex = ctdc.OperID;
            object[] cparam = Conditions.Read(ctdc.Value, ctdc.OperID);
            if (cparam.Length > 0)
            {
                rootcondition_txt1.Visible = true;
                rootcondition_txt1.Text = Lang.Translate(Conditions.GetInfo(ctdc.OperID).Fields[0]);
                rootcondition_param1.Visible = true;
                rootcondition_param1.Text = cparam[0].ToString();
                if (cparam.Length > 1)
                {
                    rootcondition_txt2.Visible = true;
                    rootcondition_txt2.Text = Lang.Translate(Conditions.GetInfo(ctdc.OperID).Fields[1]);
                    rootcondition_param2.Visible = true;
                    rootcondition_param2.Text = cparam[1].ToString();
                }
            }
            if (ctdc.Type <= 2)
            {
                index = Array.IndexOf(Conditions.Non_central(), ctdc.ConditionRight.OperID);
                if (index > -1)
                {
                    rootcondition_right.Visible = true;
                    rootcondition_right.SelectedIndex = index;
                    object[] cparamr = Conditions.Read(ctdc.ConditionRight.Value, ctdc.ConditionRight.OperID);
                    if (cparamr.Length > 0)
                    {
                        rootcondition_right_txt1.Visible = true;
                        rootcondition_right_txt1.Text = Lang.Translate(Conditions.GetInfo(ctdc.ConditionRight.OperID).Fields[0]);
                        rootcondition_right_param1.Visible = true;
                        rootcondition_right_param1.Text = cparamr[0].ToString();
                        if (cparamr.Length > 1)
                        {
                            rootcondition_right_txt2.Visible = true;
                            rootcondition_right_txt2.Text = Lang.Translate(Conditions.GetInfo(ctdc.ConditionRight.OperID).Fields[1]);
                            rootcondition_right_param2.Visible = true;
                            rootcondition_right_param2.Text = cparamr[1].ToString();
                        }
                    }
                }
                else
                {
                    rootcondition_right.SelectedIndex = Conditions.Non_central().Length;
                    SubConditionRight.Visible = true;
                }
                if (ctdc.Type == 1)
                {
                    index = Array.IndexOf(Conditions.Non_central(), ctdc.ConditionLeft.OperID);
                    if (index > -1)
                    {
                        rootcondition_left.Visible = true;
                        rootcondition_left.SelectedIndex = index;
                        object[] cparaml = Conditions.Read(ctdc.ConditionLeft.Value, ctdc.ConditionLeft.OperID);
                        if (cparaml.Length > 0)
                        {
                            rootcondition_left_txt1.Visible = true;
                            rootcondition_left_txt1.Text = Lang.Translate(Conditions.GetInfo(ctdc.ConditionLeft.OperID).Fields[0]);
                            rootcondition_left_param1.Visible = true;
                            rootcondition_left_param1.Text = cparaml[0].ToString();
                            if (cparaml.Length > 1)
                            {
                                rootcondition_left_txt2.Visible = true;
                                rootcondition_left_txt2.Text = Lang.Translate(Conditions.GetInfo(ctdc.ConditionLeft.OperID).Fields[1]);
                                rootcondition_left_param2.Visible = true;
                                rootcondition_left_param2.Text = cparaml[1].ToString();
                            }
                        }
                    }
                    else
                    {
                        rootcondition_left.SelectedIndex = Conditions.Non_central().Length;
                        SubConditionLeft.Visible = true;
                    }
                }
            }
        }

        private void triggers_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (triggers_list.SelectedIndex > -1)
            {
                LoadData(1);
            }
        }

        private void controllers_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (controllers_list.SelectedIndex > -1)
            {
                LoadData(2);
            }

        }

        private void operations_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (operations_list.SelectedIndex > -1)
            {
                LoadData(3);
            }
        }

        private void select_lang_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lang.SetLang(select_lang.Text);
            ini.Write("GENERAL", "Lang", select_lang.SelectedIndex);
            foreach (Control c in Controls)
            {
                string ui = Lang.Translate(c.Name);
                if (!string.IsNullOrEmpty(ui)) c.Text = ui;
            }
            file.Text = Lang.Translate("file");
            open_file.Text = Lang.Translate("open_file");
            save_file.Text = Lang.Translate("save_file");
            tools.Text = Lang.Translate("tools");
            delete_empty_triggers.Text = Lang.Translate("delete_empty_triggers");
            remove_empty_controllers.Text = Lang.Translate("remove_empty_controllers");
            about.Text = Lang.Translate("about");
            c_name.Text = Lang.Translate("c_name");
            op_box.Text = Lang.Translate("op_box");
            target.Text = Lang.Translate("target");
            target_param_txt.Text = Lang.Translate("target_param_txt");
            trigger_add.Text = Lang.Translate("add");
            trigger_remove.Text = Lang.Translate("remove");
            controller_add.Text = Lang.Translate("add");
            controller_remove.Text = Lang.Translate("remove");
            op_add.Text = Lang.Translate("add");
            op_add_c.Text = Lang.Translate("add");
            op_remove.Text = Lang.Translate("remove");
            operation_param.Columns[0].HeaderText = Lang.Translate("op_name");
            operation_param.Columns[1].HeaderText = Lang.Translate("op_param");
            TargetType.Items.Clear();
            foreach (string field in Operations.Targets)
            {
                TargetType.Items.Add(Lang.Translate(field));
            }
            rootcondition_right.Items.Clear();
            rootcondition_center.Items.Clear();
            rootcondition_left.Items.Clear();
            for (int i = 0; i < 27; ++i)
            {
                rootcondition_center.Items.Add(Lang.Translate(Conditions.GetInfo(i).Name));
            }
            for (int i = 0; i < Conditions.Non_central().Length; ++i)
            {
                string name = Lang.Translate(Conditions.GetInfo(Conditions.Non_central()[i]).Name);
                rootcondition_right.Items.Add(name);
                rootcondition_left.Items.Add(name);
            }
            rootcondition_right.Items.Add(Lang.Translate("cond_subcondition"));
            rootcondition_left.Items.Add(Lang.Translate("cond_subcondition"));
            operationsComboBox.Items.Clear();
            operation_list.Items.Clear();
            for (int i = 0; i < 34; ++i)
            {
                string name = Lang.Translate(Operations.GetInfo(i, 0).Name);
                operationsComboBox.Items.Add(name);
                operation_list.Items.Add(name);
            }
            if (ai != null) LoadData(0);
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Авторы: Kn1fe, Nes.\nKn1fe-Zone.Ru 2016-2017");
        }

        private void SubConditionLeft_Click(object sender, EventArgs e)
        {
            ConditionWin cw = new ConditionWin(ref ai.controllers[triggers_list.SelectedIndex].CTD[controllers_list.SelectedIndex].rootConditon.ConditionLeft, this, null);
            cw.Show();
        }

        private void SubConditionRight_Click(object sender, EventArgs e)
        {
            ConditionWin cw = new ConditionWin(ref ai.controllers[triggers_list.SelectedIndex].CTD[controllers_list.SelectedIndex].rootConditon.ConditionRight, this, null);
            cw.Show();
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                new AIFile().Save(sfd.FileName, ai, this);
            }
        }

        private void textBoxOnlyDigit(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            if ((e.KeyCode >= Keys.D0) && (e.KeyCode <= Keys.D9)) e.SuppressKeyPress = false;
            if ((e.KeyCode >= Keys.NumPad0) && (e.KeyCode <= Keys.NumPad9)) e.SuppressKeyPress = false;
            if ((e.KeyCode == Keys.Delete) || (e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Left) || (e.KeyCode == Keys.Right) || (e.KeyCode == Keys.Oemcomma) || (e.KeyCode == Keys.OemQuestion)) e.SuppressKeyPress = false;
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ai.controllers.Add(new CPolicyData(ai.controllers.Last().ID + 1));
            LoadData(0);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (triggers_list.SelectedIndex > -1)
            {
                List<int> ind = new List<int>();
                foreach (int i in triggers_list.SelectedIndices) ind.Add(i);
                ind.Reverse();
                foreach (int i in ind) ai.controllers.RemoveAt(i);
                LoadData(0);
            }
        }

        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (controllers_list.SelectedIndex > -1)
            {
                List<int> ind = new List<int>();
                foreach (int i in controllers_list.SelectedIndices) ind.Add(i);
                ind.Reverse();
                foreach (int i in ind) ai.controllers[triggers_list.SelectedIndex].CTD.RemoveAt(i);
                LoadData(1);
            }
        }

        private void добавитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ai.controllers[triggers_list.SelectedIndex].CTD.Add(new CTriggerData(ai.controllers.First().CTD.First().version, ai.controllers[triggers_list.SelectedIndex].CTD.Count > 0 ? ai.controllers[triggers_list.SelectedIndex].CTD.Last().uID + 1 : 0));
            LoadData(1);
        }

        private void operation_param_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (OnLoad) return;
            if (ai.controllers[triggers_list.SelectedIndex].CTD[controllers_list.SelectedIndex].listOperation[operations_list.SelectedIndex].iType == 2 && e.RowIndex == 0)
            {
                //var channel = language.getLangList(txt_lang, 3).Where(x => x.param[0].ToString() == operation_param.Rows[e.RowIndex].Cells[1].Value.ToString()).ToList();
                //ai.controllers[triggers_list.SelectedIndex].CTD[controllers_list.SelectedIndex].listOperation[operations_list.SelectedIndex].pParam[0] = channel.Count > 0 ? channel.First().name : "";
            }
            else
            {
                ai.controllers[triggers_list.SelectedIndex].CTD[controllers_list.SelectedIndex].listOperation[operations_list.SelectedIndex].pParam[e.RowIndex] = operation_param.Rows[e.RowIndex].Cells[1].Value;
            }
        }

        private void удалитьВсеПустыеТриггерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = ai.controllers.RemoveAll(x => x.CTD.Count == 0);
            LoadData(0);
            MetroMessageBox.Show(this, Lang.Translate("removed") + count);
        }

        private void удалитьВсеПустыеКонтроллерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (CPolicyData cpd in ai.controllers)
            {
                count += cpd.CTD.RemoveAll(x => x.listOperation.Count == 0);
            }
            LoadData(0);
            MetroMessageBox.Show(this, Lang.Translate("removed") + count);
        }

        private void удалитьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (operations_list.SelectedIndex > -1)
            {
                List<int> ind = new List<int>();
                foreach (int i in operations_list.SelectedIndices) ind.Add(i);
                ind.Reverse();
                foreach (int i in ind) ai.controllers[triggers_list.SelectedIndex].CTD[controllers_list.SelectedIndex].listOperation.RemoveAt(i);
                LoadData(1);
            }
        }

        private void добавитьToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CTriggerDataOperation ctdo = new CTriggerDataOperation();
            ctdo.iType = operationsComboBox.SelectedIndex;
            ctdo.pParam = Operations.GetEmptyOperation(ctdo.iType, ai.controllers[triggers_list.SelectedIndex].CTD[controllers_list.SelectedIndex].version);
            ai.controllers[triggers_list.SelectedIndex].CTD[controllers_list.SelectedIndex].listOperation.Add(ctdo);
            LoadData(2);
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (search_pattern.Text.Length > 0)
            {
                //0 - trigger id
                //1 - contoller name
                //2 - operation param
                //3 - condition param
                List<object[]> res = new List<object[]>();
                var res1 = ai.controllers.Where(x => x.ID.ToString().ToLower().Contains(search_pattern.Text.ToLower())).ToList();
                foreach (CPolicyData cpd in res1)
                {
                    res.Add(new object[] { 0, cpd, ai.controllers.IndexOf(cpd) });
                }
                Progress.Maximum = ai.controllers.Count;
                for (int i = 0; i < ai.controllers.Count; ++i)
                {
                    ++Progress.Value;
                    Application.DoEvents();
                    var res2 = ai.controllers[i].CTD.Where(x => x.Name.ToLower().Contains(search_pattern.Text.ToLower())).ToList();
                    foreach (CTriggerData ctd in res2)
                    {
                        res.Add(new object[] { 1, ai.controllers[i], ctd, i });
                    }
                    for (int j = 0; j < ai.controllers[i].CTD.Count; ++j)
                    {
                        for (int k = 0; k < ai.controllers[i].CTD[j].listOperation.Count; ++k)
                        {
                            var res3 = ai.controllers[i].CTD[j].listOperation[k].pParam.Where(x => x.ToString().ToLower().Contains(search_pattern.Text.ToLower())).ToList();
                            if (res3.Count >= 1)
                            {
                                res.Add(new object[] { 2, ai.controllers[i], ai.controllers[i].CTD[j], k, i, j, k});
                            }
                        }
                    }
                }
                Progress.Value = 0;
                new SearchUI(res, this).Show();
            }
            else
            {
                MetroMessageBox.Show(this, Lang.Translate("search_empty"));
            }
        }

        private void target_param_DoubleClick(object sender, EventArgs e)
        {
            new ClassMaskGenerator(this).Show();
        }

        private void find_uses_Click(object sender, EventArgs e)
        {
            List<object[]> res = new List<object[]>();
            Progress.Maximum = ai.controllers.Count;
            for (int i = 0; i < ai.controllers.Count; ++i)
            {
                ++Progress.Value;
                Application.DoEvents();
                for (int j = 0; j < ai.controllers[i].CTD.Count; ++j)
                {
                    for (int k = 0; k < ai.controllers[i].CTD[j].listOperation.Count; ++k)
                    {
                        if (ai.controllers[i].CTD[j].listOperation[k].iType == operation_list.SelectedIndex)
                        {
                            res.Add(new object[] { 2, ai.controllers[i], ai.controllers[i].CTD[j], k, i, j, k });
                        }
                    }
                }
            }
            Progress.Value = 0;
            new SearchUI(res, this).Show();
        }

        private void load_elements_Click(object sender, EventArgs e)
        {
            CustomData.LoadElements(this);
            if (ai != null) LoadData(0);
        }
    }
}
