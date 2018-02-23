using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace NextAIPolicyEditor2
{
    public partial class ConditionWin : MetroForm
    {
        CTriggerDataCondition ctdc;
        MainForm f;
        ConditionWin cw;
        new bool OnLoad = true;

        public ConditionWin(ref CTriggerDataCondition ctdc, MainForm f, ConditionWin cw)
        {
            this.ctdc = ctdc;
            this.f = f;
            this.cw = cw;
            InitializeComponent();
            rootcondition_center.DropDownStyle = ComboBoxStyle.DropDownList;
            rootcondition_left.DropDownStyle = ComboBoxStyle.DropDownList;
            rootcondition_right.DropDownStyle = ComboBoxStyle.DropDownList;
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
            foreach (Control c in Controls)
            {
                string ui = Lang.Translate(c.Name);
                if (!string.IsNullOrEmpty(ui)) c.Text = ui;
            }
            LoadCondition();
        }

        private void textBoxOnlyDigit(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            if ((e.KeyCode >= Keys.D0) && (e.KeyCode <= Keys.D9)) e.SuppressKeyPress = false;
            if ((e.KeyCode >= Keys.NumPad0) && (e.KeyCode <= Keys.NumPad9)) e.SuppressKeyPress = false;
            if ((e.KeyCode == Keys.Delete) || (e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Left) || (e.KeyCode == Keys.Right) || (e.KeyCode == Keys.Oemcomma) || (e.KeyCode == Keys.OemQuestion)) e.SuppressKeyPress = false;
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

        public void LoadCondition()
        {
            OnLoad = true;
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
            OnLoad = false;
        }

        private void SaveData(object sender, EventArgs e)
        {
            if (OnLoad) return;
            Control c = sender as Control;
            int index = 0;
            try
            {
                switch (c.Name)
                {
                    case "rootcondition_center":
                        ctdc.OperID = rootcondition_center.SelectedIndex;
                        ctdc.Value = Conditions.CreateEmptyCondition(rootcondition_center.SelectedIndex);
                        ctdc.Type = Conditions.GetTypeByID(rootcondition_center.SelectedIndex);
                        Conditions.SetSubnoteByID(ref ctdc);
                        LoadCondition();
                        break;
                    case "rootcondition_left":
                        index = Array.IndexOf(Conditions.Non_central(), rootcondition_left.SelectedIndex);
                        ctdc.ConditionLeft.OperID = index;
                        ctdc.ConditionLeft.Value = Conditions.CreateEmptyCondition(index);
                        ctdc.ConditionLeft.Type = Conditions.GetTypeByID(index);
                        Conditions.SetSubnoteByID(ref ctdc.ConditionLeft);
                        LoadCondition();
                        break;
                    case "rootcondition_right":
                        index = Array.IndexOf(Conditions.Non_central(), rootcondition_right.SelectedIndex);
                        ctdc.ConditionRight.OperID = index;
                        ctdc.ConditionRight.Value = Conditions.CreateEmptyCondition(index);
                        ctdc.ConditionRight.Type = Conditions.GetTypeByID(index);
                        Conditions.SetSubnoteByID(ref ctdc.ConditionRight);
                        LoadCondition();
                        break;
                    case "rootcondition_left_param1":
                    case "rootcondition_left_param2":
                        ctdc.ConditionLeft.Value = Conditions.Write(new object[] { rootcondition_left_param1.Text, rootcondition_left_param2.Text }, Array.IndexOf(Conditions.Non_central(), rootcondition_left.SelectedIndex));
                        break;
                    case "rootcondition_param1":
                    case "rootcondition_param2":
                        ctdc.Value = Conditions.Write(new object[] { rootcondition_param1.Text, rootcondition_param2.Text }, rootcondition_center.SelectedIndex);
                        break;
                    case "rootcondition_right_param1":
                    case "rootcondition_right_param2":
                        ctdc.ConditionRight.Value = Conditions.Write(new object[] { rootcondition_right_param1.Text, rootcondition_right_param2.Text }, Array.IndexOf(Conditions.Non_central(), rootcondition_right.SelectedIndex));
                        break;
                    default:
                        MessageBox.Show("Amazing, but unknown control");
                        break;
                }
            } catch { }
        }

        private void SubConditionLeft_Click(object sender, EventArgs e)
        {
            ConditionWin cw = new ConditionWin(ref ctdc.ConditionLeft, null, this);
            cw.Show();
        }

        private void SubConditionRight_Click(object sender, EventArgs e)
        {
            ConditionWin cw = new ConditionWin(ref ctdc.ConditionRight, null, this);
            cw.Show();
        }

        private void ConditionWin_FormClosed(object sender, FormClosedEventArgs e)
        {
            ctdc.ConditionLeft.Value = Conditions.Write(new object[] { rootcondition_left_param1.Text, rootcondition_left_param2.Text }, Array.IndexOf(Conditions.Non_central(), rootcondition_left.SelectedIndex));
            ctdc.Value = Conditions.Write(new object[] { rootcondition_param1.Text, rootcondition_param2.Text }, rootcondition_center.SelectedIndex);
            ctdc.ConditionRight.Value = Conditions.Write(new object[] { rootcondition_right_param1.Text, rootcondition_right_param2.Text }, Array.IndexOf(Conditions.Non_central(), rootcondition_right.SelectedIndex));
            if (cw != null) cw.LoadCondition();
            if (f != null) f.LoadCondition(f.ai.controllers[f.triggers_list.SelectedIndex].CTD[f.controllers_list.SelectedIndex].rootConditon);
        }
    }
}
