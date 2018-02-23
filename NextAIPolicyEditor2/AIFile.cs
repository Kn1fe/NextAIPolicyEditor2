using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace NextAIPolicyEditor2
{

    public class AIPolicy
    {
        public int header { get; set; }
        public List<CPolicyData> controllers;
        public AIPolicy()
        {
            header = 0;
            controllers = new List<CPolicyData>();
        }
    }

    public class CPolicyData
    {
        public int version { get; set; }
        public int ID { get; set; }
        public List<CTriggerData> CTD;
        public CPolicyData(int id)
        {
            version = 1;
            ID = id;
            CTD = new List<CTriggerData>();
        }
        public CPolicyData()
        {
            version = 1;
            ID = 0;
            CTD = new List<CTriggerData>();
        }
    }

    public class CTriggerData
    {
        public int version { get; set; }
        public byte[] szName { get; set; }
        public string Name
        {
            get
            {
                return new AIFile().GBKBytesToString(szName);
            }
            set
            {
                szName = new AIFile().GBKStringToBytes(value);
            }
        }
        public bool bActive { get; set; }
        public bool bRun { get; set; }
        public bool bAttackValid { get; set; }
        public int uID { get; set; }
        public CTriggerDataCondition rootConditon;
        public List<CTriggerDataOperation> listOperation;
        public CTriggerData(int v, int uid)
        {
            version = v;
            szName = new AIFile().GBKStringToBytes("new trigger");
            bActive = true;
            bRun = false;
            bAttackValid = false;
            uID = uid;
            rootConditon = new CTriggerDataCondition();
            listOperation = new List<CTriggerDataOperation>();
        }
        public CTriggerData()
        {
            version = 0;
            szName = new AIFile().GBKStringToBytes("");
            bActive = false;
            bRun = false;
            bAttackValid = false;
            uID = 0;
            rootConditon = new CTriggerDataCondition();
            listOperation = new List<CTriggerDataOperation>();
        }
    }

    public class CTriggerDataCondition
    {
        public int OperID { get; set; }
        public byte[] Value { get; set; }
        public int Type { get; set; }
        public CTriggerDataCondition ConditionLeft;
        public int SubNodeL { get; set; }
        public CTriggerDataCondition ConditionRight;
        public int SubNodeR { get; set; }
        public CTriggerDataCondition()
        {
            OperID = 2;
            Value = new byte[0];
            Type = 3;
        }
    }

    public class CTriggerDataOperation
    {
        public int iType { get; set; }
        public object[] pParam { get; set; }
        public int iTargetType { get; set; }
        public int pTargetParam { get; set; }
        public CTriggerDataOperation()
        {
            iType = 0;
            pParam = new object[0];
            iTargetType = 0;
            pTargetParam = 0;
        }
    }

    class AIFile
    {
        public AIPolicy Read(string filepath, MainForm f)
        {
            AIPolicy ai = new AIPolicy();
            BinaryReader br = new BinaryReader(new FileStream(filepath, FileMode.Open, FileAccess.Read));
            ai.header = br.ReadInt32();
            int count = br.ReadInt32();
            f.Progress.Maximum = count;
            for (int i = 0; i < count; ++i)
            {
                ++f.Progress.Value;
                Application.DoEvents();
                CPolicyData aic = new CPolicyData();
                aic.version = br.ReadInt32();
                aic.ID = br.ReadInt32();
                int ccount = br.ReadInt32();
                for (int j = 0; j < ccount; ++j)
                {
                    CTriggerData ctd = new CTriggerData();
                    ctd.version = br.ReadInt32();
                    ctd.uID = br.ReadInt32();
                    ctd.bActive = br.ReadBoolean();
                    ctd.bRun = br.ReadBoolean();
                    ctd.bAttackValid = br.ReadBoolean();
                    ctd.szName = br.ReadBytes(128);
                    ctd.rootConditon = LoadCondition(br);
                    int pcount = br.ReadInt32();
                    for (int k = 0; k < pcount; ++k)
                    {
                        CTriggerDataOperation ctdo = new CTriggerDataOperation();
                        ctdo.iType = br.ReadInt32();
                        ctdo.pParam = Operations.Read(br, ctdo.iType, ctd.version);
                        ctdo.iTargetType = br.ReadInt32();
                        if (ctdo.iTargetType == 6)
                        {
                            ctdo.pTargetParam = br.ReadInt32();
                        }
                        else
                        {
                            ctdo.pTargetParam = 0;
                        }
                        ctd.listOperation.Add(ctdo);
                    }
                    aic.CTD.Add(ctd);
                }
                ai.controllers.Add(aic);
            }
            f.Progress.Value = 0;
            br.Close();
            return ai;
        }

        public void Save(string path, AIPolicy ai, MainForm f)
        {
            f.Progress.Maximum = ai.controllers.Count;
            BinaryWriter bw = new BinaryWriter(new FileStream(path, FileMode.Create, FileAccess.Write));
            bw.Write(ai.header);
            bw.Write(ai.controllers.Count);
            for (int i = 0; i < ai.controllers.Count; ++i)
            {
                ++f.Progress.Value;
                Application.DoEvents();
                bw.Write(ai.controllers[i].version);
                bw.Write(ai.controllers[i].ID);
                bw.Write(ai.controllers[i].CTD.Count);
                for (int j = 0; j < ai.controllers[i].CTD.Count; ++j)
                {
                    bw.Write(ai.controllers[i].CTD[j].version);
                    bw.Write(ai.controllers[i].CTD[j].uID);
                    bw.Write(ai.controllers[i].CTD[j].bActive);
                    bw.Write(ai.controllers[i].CTD[j].bRun);
                    bw.Write(ai.controllers[i].CTD[j].bAttackValid);
                    bw.Write(ai.controllers[i].CTD[j].szName);
                    SaveCondition(bw, ai.controllers[i].CTD[j].rootConditon);
                    bw.Write(ai.controllers[i].CTD[j].listOperation.Count);
                    for(int k = 0; k < ai.controllers[i].CTD[j].listOperation.Count; ++k)
                    {
                        bw.Write(ai.controllers[i].CTD[j].listOperation[k].iType);
                        Operations.Write(bw, ai.controllers[i].CTD[j].listOperation[k].iType, ai.controllers[i].CTD[j].version, ai.controllers[i].CTD[j].listOperation[k].pParam);
                        bw.Write(ai.controllers[i].CTD[j].listOperation[k].iTargetType);
                        if (ai.controllers[i].CTD[j].listOperation[k].iTargetType == 6)
                        {
                            bw.Write(ai.controllers[i].CTD[j].listOperation[k].pTargetParam);
                        }
                    }
                }
            }
            f.Progress.Value = 0;
            bw.Close();
            MessageBox.Show("Сохранено");
        }

        public CTriggerDataCondition LoadCondition(BinaryReader br)
        {
            CTriggerDataCondition condition = new CTriggerDataCondition();
            condition.OperID = br.ReadInt32();
            condition.Value = br.ReadBytes(br.ReadInt32());
            condition.Type = br.ReadInt32();
            if (condition.Type == 1)
            {
                condition.ConditionLeft = LoadCondition(br);
                condition.SubNodeL = br.ReadInt32();
                condition.ConditionRight = LoadCondition(br);
                condition.SubNodeR = br.ReadInt32();
            }
            if (condition.Type == 2)
            {
                condition.ConditionRight = LoadCondition(br);
                condition.SubNodeL = br.ReadInt32();
            }
            return condition;
        }

        public void SaveCondition(BinaryWriter bw, CTriggerDataCondition c)
        {
            bw.Write(c.OperID);
            bw.Write(c.Value.Length);
            bw.Write(c.Value);
            bw.Write(c.Type);
            if (c.Type == 1)
            {
                SaveCondition(bw, c.ConditionLeft);
                bw.Write(c.SubNodeL);
                if (c.SubNodeL == 2)
                {
                    SaveCondition(bw, c.ConditionRight);
                    bw.Write(c.SubNodeR);
                }
            }
            if (c.Type != 2)
            {
                return;
            }
            SaveCondition(bw, c.ConditionRight);
            bw.Write(c.SubNodeL);
        }

        public string GBKBytesToString(byte[] text)
        {
            string @string = Encoding.GetEncoding("GB18030").GetString(text);
            StringBuilder stringBuilder = new StringBuilder();
            int num = 0;
            while (num < 128 && @string[num] != '\0')
            {
                stringBuilder.Append(@string[num]);
                num++;
            }
            return stringBuilder.ToString();
        }

        public byte[] GBKStringToBytes(string str)
        {
            byte[] bytes = Encoding.GetEncoding("GB18030").GetBytes(str);
            byte[] data = new byte[128];
            Buffer.BlockCopy(bytes, 0, data, 0, Math.Min(128, bytes.Length));
            return data;
        }
    }
}
