using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NextAIPolicyEditor2
{
    public partial class SearchUI : Form
    {
        List<object[]> res = new List<object[]>();
        MainForm f;

        public SearchUI(List<object[]> res, MainForm f)
        {
            this.res = res;
            this.f = f;
            InitializeComponent();
            foreach (object[] o in res)
            {
                int type = Convert.ToInt32(o[0]);
                switch (type)
                {
                    case 0:
                        Result.Items.Add("Триггер ID: " + (o[1] as CPolicyData).ID);
                        break;
                    case 1:
                        Result.Items.Add(string.Format("Триггер ID: {0}; Контроллер: [{1}] {2}", (o[1] as CPolicyData).ID, (o[2] as CTriggerData).uID, (o[2] as CTriggerData).szName));
                        break;
                    case 2:
                        Result.Items.Add(string.Format("Триггер ID: {0}; Контроллер: {1}; Операция: {2}", (o[1] as CPolicyData).ID, (o[2] as CTriggerData).uID, o[3].ToString()));
                        break;
                }
            }
        }

        private void Result_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Result.SelectedIndex > -1)
            {
                int type = Convert.ToInt32(res[Result.SelectedIndex][0]);
                f.triggers_list.ClearSelected();
                f.controllers_list.ClearSelected();
                f.operations_list.ClearSelected();
                switch (type)
                {
                    case 0:
                        f.triggers_list.SelectedIndex = Convert.ToInt32(res[Result.SelectedIndex][2]);
                        break;
                    case 1:
                        f.triggers_list.SelectedIndex = Convert.ToInt32(res[Result.SelectedIndex][3]);
                        f.controllers_list.SelectedIndex = Convert.ToInt32(res[Result.SelectedIndex][4]);
                        break;
                    case 2:
                        f.triggers_list.SelectedIndex = Convert.ToInt32(res[Result.SelectedIndex][4]);
                        f.controllers_list.SelectedIndex = Convert.ToInt32(res[Result.SelectedIndex][5]);
                        f.operations_list.SelectedIndex = Convert.ToInt32(res[Result.SelectedIndex][6]);
                        break;
                }
                f.Focus();
            }
        }
    }
}
