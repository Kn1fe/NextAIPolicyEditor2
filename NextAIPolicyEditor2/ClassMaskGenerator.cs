using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NextAIPolicyEditor2
{
    public partial class ClassMaskGenerator : Form
    {
        uint combo;
        bool onLoad = true;
        MainForm f;

        public ClassMaskGenerator(MainForm f)
        {
            combo = Convert.ToUInt32(f.target_param.Text);
            this.f = f;
            InitializeComponent();
            LoadCombo();
        }

        private void Cb_CheckedChanged(object sender, EventArgs e)
        {
            if (!onLoad)
            {
                CheckBox cb = (CheckBox)sender;
                combo = cb.Checked ? combo += Convert.ToUInt32(cb.Tag) : combo -= Convert.ToUInt32(cb.Tag);
                f.target_param.Text = combo.ToString();
            }
        }

        void LoadCombo()
        {
            onLoad = true;
            for (int i = 0; i < Controls.Count - 1; ++i)
            {
                CheckBox cb = (CheckBox)Controls[i];
                cb.Checked = false;
            }
            List<uint> list = new List<uint>(GetPowers(combo));
            for (int j = 0; j < list.Count; j++)
            {
                if (list[j] != 0)
                {
                    CheckBox cb = (CheckBox)Controls["checkBox" + j.ToString()];
                    cb.Checked = true;
                }
            }
            onLoad = false;
        }

        IEnumerable<uint> GetPowers(uint value)
        {
            for (uint num = value; num > 0u; num >>= 1)
            {
                yield return num & 1u;
            }
            yield break;
        }
    }
}
