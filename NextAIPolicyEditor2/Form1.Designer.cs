using MetroFramework.Controls;

namespace NextAIPolicyEditor2
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.file = new System.Windows.Forms.ToolStripMenuItem();
            this.open_file = new System.Windows.Forms.ToolStripMenuItem();
            this.save_file = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.load_elements = new System.Windows.Forms.ToolStripMenuItem();
            this.tools = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_empty_triggers = new System.Windows.Forms.ToolStripMenuItem();
            this.remove_empty_controllers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.find = new System.Windows.Forms.ToolStripMenuItem();
            this.operation_list = new System.Windows.Forms.ToolStripComboBox();
            this.find_uses = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.trigger_box = new System.Windows.Forms.GroupBox();
            this.label5 = new MetroFramework.Controls.MetroLabel();
            this.triggers_list = new System.Windows.Forms.ListBox();
            this.trigger_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trigger_add = new System.Windows.Forms.ToolStripMenuItem();
            this.trigger_remove = new System.Windows.Forms.ToolStripMenuItem();
            this.trigger_id = new MetroFramework.Controls.MetroTextBox();
            this.controller_box = new System.Windows.Forms.GroupBox();
            this.bAttackValid = new MetroFramework.Controls.MetroCheckBox();
            this.bRun = new MetroFramework.Controls.MetroCheckBox();
            this.bActive = new MetroFramework.Controls.MetroCheckBox();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.controller_id = new MetroFramework.Controls.MetroTextBox();
            this.c_name = new MetroFramework.Controls.MetroLabel();
            this.controller_name = new MetroFramework.Controls.MetroTextBox();
            this.controllers_list = new System.Windows.Forms.ListBox();
            this.controller_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.controller_add = new System.Windows.Forms.ToolStripMenuItem();
            this.controller_remove = new System.Windows.Forms.ToolStripMenuItem();
            this.cond_box = new System.Windows.Forms.GroupBox();
            this.SubConditionRight = new MetroFramework.Controls.MetroButton();
            this.SubConditionLeft = new MetroFramework.Controls.MetroButton();
            this.rootcondition_left_txt2 = new MetroFramework.Controls.MetroLabel();
            this.rootcondition_left_param2 = new MetroFramework.Controls.MetroTextBox();
            this.rootcondition_left_txt1 = new MetroFramework.Controls.MetroLabel();
            this.rootcondition_left_param1 = new MetroFramework.Controls.MetroTextBox();
            this.rootcondition_right_txt2 = new MetroFramework.Controls.MetroLabel();
            this.rootcondition_right_param2 = new MetroFramework.Controls.MetroTextBox();
            this.rootcondition_right_txt1 = new MetroFramework.Controls.MetroLabel();
            this.rootcondition_right_param1 = new MetroFramework.Controls.MetroTextBox();
            this.rootcondition_txt2 = new MetroFramework.Controls.MetroLabel();
            this.rootcondition_param2 = new MetroFramework.Controls.MetroTextBox();
            this.rootcondition_txt1 = new MetroFramework.Controls.MetroLabel();
            this.rootcondition_param1 = new MetroFramework.Controls.MetroTextBox();
            this.rootcondition_right = new MetroFramework.Controls.MetroComboBox();
            this.rootcondition_left = new MetroFramework.Controls.MetroComboBox();
            this.rootcondition_center = new MetroFramework.Controls.MetroComboBox();
            this.operation_box = new System.Windows.Forms.GroupBox();
            this.op_box = new System.Windows.Forms.GroupBox();
            this.operation_param = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.target_param = new MetroFramework.Controls.MetroTextBox();
            this.target_param_txt = new MetroFramework.Controls.MetroLabel();
            this.target = new MetroFramework.Controls.MetroLabel();
            this.TargetType = new MetroFramework.Controls.MetroComboBox();
            this.operations_list = new System.Windows.Forms.ListBox();
            this.operation_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.op_add = new System.Windows.Forms.ToolStripMenuItem();
            this.operationsComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.op_add_c = new System.Windows.Forms.ToolStripMenuItem();
            this.op_remove = new System.Windows.Forms.ToolStripMenuItem();
            this.select_lang = new MetroFramework.Controls.MetroComboBox();
            this.lang = new MetroFramework.Controls.MetroLabel();
            this.Progress = new MetroFramework.Controls.MetroProgressBar();
            this.search_pattern = new MetroFramework.Controls.MetroTextBox();
            this.search_string = new MetroFramework.Controls.MetroLabel();
            this.Search = new MetroFramework.Controls.MetroButton();
            this.triggers_mobs = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.trigger_box.SuspendLayout();
            this.trigger_menu.SuspendLayout();
            this.controller_box.SuspendLayout();
            this.controller_menu.SuspendLayout();
            this.cond_box.SuspendLayout();
            this.operation_box.SuspendLayout();
            this.op_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operation_param)).BeginInit();
            this.operation_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file,
            this.tools,
            this.about});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(810, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // file
            // 
            this.file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open_file,
            this.save_file,
            this.toolStripSeparator2,
            this.load_elements});
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(57, 20);
            this.file.Text = "Файлы";
            // 
            // open_file
            // 
            this.open_file.Name = "open_file";
            this.open_file.Size = new System.Drawing.Size(205, 22);
            this.open_file.Text = "Открыть";
            this.open_file.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // save_file
            // 
            this.save_file.Name = "save_file";
            this.save_file.Size = new System.Drawing.Size(205, 22);
            this.save_file.Text = "Сохранить как";
            this.save_file.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(202, 6);
            // 
            // load_elements
            // 
            this.load_elements.Name = "load_elements";
            this.load_elements.Size = new System.Drawing.Size(205, 22);
            this.load_elements.Text = "Загрузить Elements.data";
            this.load_elements.Click += new System.EventHandler(this.load_elements_Click);
            // 
            // tools
            // 
            this.tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delete_empty_triggers,
            this.remove_empty_controllers,
            this.toolStripSeparator1,
            this.find});
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(107, 20);
            this.tools.Text = "Дополнительно";
            // 
            // delete_empty_triggers
            // 
            this.delete_empty_triggers.Name = "delete_empty_triggers";
            this.delete_empty_triggers.Size = new System.Drawing.Size(259, 22);
            this.delete_empty_triggers.Text = "Удалить все пустые триггеры";
            this.delete_empty_triggers.Click += new System.EventHandler(this.удалитьВсеПустыеТриггерыToolStripMenuItem_Click);
            // 
            // remove_empty_controllers
            // 
            this.remove_empty_controllers.Name = "remove_empty_controllers";
            this.remove_empty_controllers.Size = new System.Drawing.Size(259, 22);
            this.remove_empty_controllers.Text = "Удалить все пустые контроллеры";
            this.remove_empty_controllers.Click += new System.EventHandler(this.удалитьВсеПустыеКонтроллерыToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(256, 6);
            // 
            // find
            // 
            this.find.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operation_list,
            this.find_uses});
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(259, 22);
            this.find.Text = "Найти использование";
            // 
            // operation_list
            // 
            this.operation_list.Name = "operation_list";
            this.operation_list.Size = new System.Drawing.Size(121, 23);
            // 
            // find_uses
            // 
            this.find_uses.Name = "find_uses";
            this.find_uses.Size = new System.Drawing.Size(181, 22);
            this.find_uses.Text = "Найти";
            this.find_uses.Click += new System.EventHandler(this.find_uses_Click);
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(94, 20);
            this.about.Text = "О программе";
            this.about.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // trigger_box
            // 
            this.trigger_box.Controls.Add(this.label5);
            this.trigger_box.Controls.Add(this.triggers_list);
            this.trigger_box.Controls.Add(this.trigger_id);
            this.trigger_box.Location = new System.Drawing.Point(20, 87);
            this.trigger_box.Name = "trigger_box";
            this.trigger_box.Size = new System.Drawing.Size(175, 205);
            this.trigger_box.TabIndex = 1;
            this.trigger_box.TabStop = false;
            this.trigger_box.Text = "Триггеры";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "ID:";
            // 
            // triggers_list
            // 
            this.triggers_list.ContextMenuStrip = this.trigger_menu;
            this.triggers_list.FormattingEnabled = true;
            this.triggers_list.Location = new System.Drawing.Point(6, 19);
            this.triggers_list.Name = "triggers_list";
            this.triggers_list.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.triggers_list.Size = new System.Drawing.Size(163, 147);
            this.triggers_list.TabIndex = 0;
            this.triggers_list.SelectedIndexChanged += new System.EventHandler(this.triggers_list_SelectedIndexChanged);
            // 
            // trigger_menu
            // 
            this.trigger_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trigger_add,
            this.trigger_remove});
            this.trigger_menu.Name = "trigger_menu";
            this.trigger_menu.Size = new System.Drawing.Size(127, 48);
            // 
            // trigger_add
            // 
            this.trigger_add.Name = "trigger_add";
            this.trigger_add.Size = new System.Drawing.Size(126, 22);
            this.trigger_add.Text = "Добавить";
            this.trigger_add.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // trigger_remove
            // 
            this.trigger_remove.Name = "trigger_remove";
            this.trigger_remove.Size = new System.Drawing.Size(126, 22);
            this.trigger_remove.Text = "Удалить";
            this.trigger_remove.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // trigger_id
            // 
            // 
            // 
            // 
            this.trigger_id.CustomButton.Image = null;
            this.trigger_id.CustomButton.Location = new System.Drawing.Point(111, 2);
            this.trigger_id.CustomButton.Name = "";
            this.trigger_id.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.trigger_id.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.trigger_id.CustomButton.TabIndex = 1;
            this.trigger_id.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.trigger_id.CustomButton.UseSelectable = true;
            this.trigger_id.CustomButton.Visible = false;
            this.trigger_id.Lines = new string[0];
            this.trigger_id.Location = new System.Drawing.Point(40, 172);
            this.trigger_id.MaxLength = 32767;
            this.trigger_id.Name = "trigger_id";
            this.trigger_id.PasswordChar = '\0';
            this.trigger_id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.trigger_id.SelectedText = "";
            this.trigger_id.SelectionLength = 0;
            this.trigger_id.SelectionStart = 0;
            this.trigger_id.ShortcutsEnabled = true;
            this.trigger_id.Size = new System.Drawing.Size(129, 20);
            this.trigger_id.TabIndex = 15;
            this.trigger_id.UseSelectable = true;
            this.trigger_id.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.trigger_id.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.trigger_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxOnlyDigit);
            this.trigger_id.Leave += new System.EventHandler(this.SaveData);
            // 
            // controller_box
            // 
            this.controller_box.Controls.Add(this.bAttackValid);
            this.controller_box.Controls.Add(this.bRun);
            this.controller_box.Controls.Add(this.bActive);
            this.controller_box.Controls.Add(this.label2);
            this.controller_box.Controls.Add(this.controller_id);
            this.controller_box.Controls.Add(this.c_name);
            this.controller_box.Controls.Add(this.controller_name);
            this.controller_box.Controls.Add(this.controllers_list);
            this.controller_box.Location = new System.Drawing.Point(20, 298);
            this.controller_box.Name = "controller_box";
            this.controller_box.Size = new System.Drawing.Size(175, 372);
            this.controller_box.TabIndex = 2;
            this.controller_box.TabStop = false;
            this.controller_box.Text = "Контроллеры (Версия 1)";
            // 
            // bAttackValid
            // 
            this.bAttackValid.AutoSize = true;
            this.bAttackValid.Location = new System.Drawing.Point(10, 351);
            this.bAttackValid.Name = "bAttackValid";
            this.bAttackValid.Size = new System.Drawing.Size(89, 15);
            this.bAttackValid.TabIndex = 14;
            this.bAttackValid.Text = "bAttackValid";
            this.bAttackValid.UseSelectable = true;
            this.bAttackValid.CheckedChanged += new System.EventHandler(this.SaveData);
            // 
            // bRun
            // 
            this.bRun.AutoSize = true;
            this.bRun.Location = new System.Drawing.Point(10, 330);
            this.bRun.Name = "bRun";
            this.bRun.Size = new System.Drawing.Size(51, 15);
            this.bRun.TabIndex = 13;
            this.bRun.Text = "bRun";
            this.bRun.UseSelectable = true;
            this.bRun.CheckedChanged += new System.EventHandler(this.SaveData);
            // 
            // bActive
            // 
            this.bActive.AutoSize = true;
            this.bActive.Location = new System.Drawing.Point(10, 305);
            this.bActive.Name = "bActive";
            this.bActive.Size = new System.Drawing.Size(63, 15);
            this.bActive.TabIndex = 12;
            this.bActive.Text = "bActive";
            this.bActive.UseSelectable = true;
            this.bActive.CheckedChanged += new System.EventHandler(this.SaveData);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID:";
            // 
            // controller_id
            // 
            // 
            // 
            // 
            this.controller_id.CustomButton.Image = null;
            this.controller_id.CustomButton.Location = new System.Drawing.Point(145, 2);
            this.controller_id.CustomButton.Name = "";
            this.controller_id.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.controller_id.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.controller_id.CustomButton.TabIndex = 1;
            this.controller_id.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.controller_id.CustomButton.UseSelectable = true;
            this.controller_id.CustomButton.Visible = false;
            this.controller_id.Lines = new string[0];
            this.controller_id.Location = new System.Drawing.Point(6, 232);
            this.controller_id.MaxLength = 32767;
            this.controller_id.Name = "controller_id";
            this.controller_id.PasswordChar = '\0';
            this.controller_id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.controller_id.SelectedText = "";
            this.controller_id.SelectionLength = 0;
            this.controller_id.SelectionStart = 0;
            this.controller_id.ShortcutsEnabled = true;
            this.controller_id.Size = new System.Drawing.Size(163, 20);
            this.controller_id.TabIndex = 10;
            this.controller_id.UseSelectable = true;
            this.controller_id.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.controller_id.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.controller_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxOnlyDigit);
            this.controller_id.Leave += new System.EventHandler(this.SaveData);
            // 
            // c_name
            // 
            this.c_name.AutoSize = true;
            this.c_name.Location = new System.Drawing.Point(6, 255);
            this.c_name.Name = "c_name";
            this.c_name.Size = new System.Drawing.Size(71, 19);
            this.c_name.TabIndex = 9;
            this.c_name.Text = "Название:";
            // 
            // controller_name
            // 
            // 
            // 
            // 
            this.controller_name.CustomButton.Image = null;
            this.controller_name.CustomButton.Location = new System.Drawing.Point(145, 2);
            this.controller_name.CustomButton.Name = "";
            this.controller_name.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.controller_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.controller_name.CustomButton.TabIndex = 1;
            this.controller_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.controller_name.CustomButton.UseSelectable = true;
            this.controller_name.CustomButton.Visible = false;
            this.controller_name.Lines = new string[0];
            this.controller_name.Location = new System.Drawing.Point(6, 277);
            this.controller_name.MaxLength = 32767;
            this.controller_name.Name = "controller_name";
            this.controller_name.PasswordChar = '\0';
            this.controller_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.controller_name.SelectedText = "";
            this.controller_name.SelectionLength = 0;
            this.controller_name.SelectionStart = 0;
            this.controller_name.ShortcutsEnabled = true;
            this.controller_name.Size = new System.Drawing.Size(163, 20);
            this.controller_name.TabIndex = 8;
            this.controller_name.UseSelectable = true;
            this.controller_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.controller_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.controller_name.Leave += new System.EventHandler(this.SaveData);
            // 
            // controllers_list
            // 
            this.controllers_list.ContextMenuStrip = this.controller_menu;
            this.controllers_list.FormattingEnabled = true;
            this.controllers_list.Location = new System.Drawing.Point(6, 19);
            this.controllers_list.Name = "controllers_list";
            this.controllers_list.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.controllers_list.Size = new System.Drawing.Size(163, 186);
            this.controllers_list.TabIndex = 0;
            this.controllers_list.SelectedIndexChanged += new System.EventHandler(this.controllers_list_SelectedIndexChanged);
            // 
            // controller_menu
            // 
            this.controller_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controller_add,
            this.controller_remove});
            this.controller_menu.Name = "trigger_menu";
            this.controller_menu.Size = new System.Drawing.Size(127, 48);
            // 
            // controller_add
            // 
            this.controller_add.Name = "controller_add";
            this.controller_add.Size = new System.Drawing.Size(126, 22);
            this.controller_add.Text = "Добавить";
            this.controller_add.Click += new System.EventHandler(this.добавитьToolStripMenuItem1_Click);
            // 
            // controller_remove
            // 
            this.controller_remove.Name = "controller_remove";
            this.controller_remove.Size = new System.Drawing.Size(126, 22);
            this.controller_remove.Text = "Удалить";
            this.controller_remove.Click += new System.EventHandler(this.удалитьToolStripMenuItem1_Click);
            // 
            // cond_box
            // 
            this.cond_box.Controls.Add(this.SubConditionRight);
            this.cond_box.Controls.Add(this.SubConditionLeft);
            this.cond_box.Controls.Add(this.rootcondition_left_txt2);
            this.cond_box.Controls.Add(this.rootcondition_left_param2);
            this.cond_box.Controls.Add(this.rootcondition_left_txt1);
            this.cond_box.Controls.Add(this.rootcondition_left_param1);
            this.cond_box.Controls.Add(this.rootcondition_right_txt2);
            this.cond_box.Controls.Add(this.rootcondition_right_param2);
            this.cond_box.Controls.Add(this.rootcondition_right_txt1);
            this.cond_box.Controls.Add(this.rootcondition_right_param1);
            this.cond_box.Controls.Add(this.rootcondition_txt2);
            this.cond_box.Controls.Add(this.rootcondition_param2);
            this.cond_box.Controls.Add(this.rootcondition_txt1);
            this.cond_box.Controls.Add(this.rootcondition_param1);
            this.cond_box.Controls.Add(this.rootcondition_right);
            this.cond_box.Controls.Add(this.rootcondition_left);
            this.cond_box.Controls.Add(this.rootcondition_center);
            this.cond_box.Location = new System.Drawing.Point(201, 87);
            this.cond_box.Name = "cond_box";
            this.cond_box.Size = new System.Drawing.Size(629, 205);
            this.cond_box.TabIndex = 3;
            this.cond_box.TabStop = false;
            this.cond_box.Text = "Условие";
            // 
            // SubConditionRight
            // 
            this.SubConditionRight.Location = new System.Drawing.Point(373, 159);
            this.SubConditionRight.Name = "SubConditionRight";
            this.SubConditionRight.Size = new System.Drawing.Size(121, 23);
            this.SubConditionRight.TabIndex = 18;
            this.SubConditionRight.Text = "Вложенное условие";
            this.SubConditionRight.UseSelectable = true;
            this.SubConditionRight.Visible = false;
            this.SubConditionRight.Click += new System.EventHandler(this.SubConditionRight_Click);
            // 
            // SubConditionLeft
            // 
            this.SubConditionLeft.Location = new System.Drawing.Point(119, 159);
            this.SubConditionLeft.Name = "SubConditionLeft";
            this.SubConditionLeft.Size = new System.Drawing.Size(121, 23);
            this.SubConditionLeft.TabIndex = 17;
            this.SubConditionLeft.Text = "Вложенное условие";
            this.SubConditionLeft.UseSelectable = true;
            this.SubConditionLeft.Visible = false;
            this.SubConditionLeft.Click += new System.EventHandler(this.SubConditionLeft_Click);
            // 
            // rootcondition_left_txt2
            // 
            this.rootcondition_left_txt2.Location = new System.Drawing.Point(119, 109);
            this.rootcondition_left_txt2.Name = "rootcondition_left_txt2";
            this.rootcondition_left_txt2.Size = new System.Drawing.Size(121, 21);
            this.rootcondition_left_txt2.TabIndex = 16;
            this.rootcondition_left_txt2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rootcondition_left_txt2.Visible = false;
            // 
            // rootcondition_left_param2
            // 
            // 
            // 
            // 
            this.rootcondition_left_param2.CustomButton.Image = null;
            this.rootcondition_left_param2.CustomButton.Location = new System.Drawing.Point(103, 2);
            this.rootcondition_left_param2.CustomButton.Name = "";
            this.rootcondition_left_param2.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.rootcondition_left_param2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.rootcondition_left_param2.CustomButton.TabIndex = 1;
            this.rootcondition_left_param2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rootcondition_left_param2.CustomButton.UseSelectable = true;
            this.rootcondition_left_param2.CustomButton.Visible = false;
            this.rootcondition_left_param2.Lines = new string[0];
            this.rootcondition_left_param2.Location = new System.Drawing.Point(119, 133);
            this.rootcondition_left_param2.MaxLength = 32767;
            this.rootcondition_left_param2.Name = "rootcondition_left_param2";
            this.rootcondition_left_param2.PasswordChar = '\0';
            this.rootcondition_left_param2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rootcondition_left_param2.SelectedText = "";
            this.rootcondition_left_param2.SelectionLength = 0;
            this.rootcondition_left_param2.SelectionStart = 0;
            this.rootcondition_left_param2.ShortcutsEnabled = true;
            this.rootcondition_left_param2.Size = new System.Drawing.Size(121, 20);
            this.rootcondition_left_param2.TabIndex = 15;
            this.rootcondition_left_param2.UseSelectable = true;
            this.rootcondition_left_param2.Visible = false;
            this.rootcondition_left_param2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.rootcondition_left_param2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.rootcondition_left_param2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxOnlyDigit);
            this.rootcondition_left_param2.Leave += new System.EventHandler(this.SaveData);
            // 
            // rootcondition_left_txt1
            // 
            this.rootcondition_left_txt1.Location = new System.Drawing.Point(119, 62);
            this.rootcondition_left_txt1.Name = "rootcondition_left_txt1";
            this.rootcondition_left_txt1.Size = new System.Drawing.Size(121, 21);
            this.rootcondition_left_txt1.TabIndex = 14;
            this.rootcondition_left_txt1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rootcondition_left_txt1.Visible = false;
            // 
            // rootcondition_left_param1
            // 
            // 
            // 
            // 
            this.rootcondition_left_param1.CustomButton.Image = null;
            this.rootcondition_left_param1.CustomButton.Location = new System.Drawing.Point(103, 2);
            this.rootcondition_left_param1.CustomButton.Name = "";
            this.rootcondition_left_param1.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.rootcondition_left_param1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.rootcondition_left_param1.CustomButton.TabIndex = 1;
            this.rootcondition_left_param1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rootcondition_left_param1.CustomButton.UseSelectable = true;
            this.rootcondition_left_param1.CustomButton.Visible = false;
            this.rootcondition_left_param1.Lines = new string[0];
            this.rootcondition_left_param1.Location = new System.Drawing.Point(119, 86);
            this.rootcondition_left_param1.MaxLength = 32767;
            this.rootcondition_left_param1.Name = "rootcondition_left_param1";
            this.rootcondition_left_param1.PasswordChar = '\0';
            this.rootcondition_left_param1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rootcondition_left_param1.SelectedText = "";
            this.rootcondition_left_param1.SelectionLength = 0;
            this.rootcondition_left_param1.SelectionStart = 0;
            this.rootcondition_left_param1.ShortcutsEnabled = true;
            this.rootcondition_left_param1.Size = new System.Drawing.Size(121, 20);
            this.rootcondition_left_param1.TabIndex = 13;
            this.rootcondition_left_param1.UseSelectable = true;
            this.rootcondition_left_param1.Visible = false;
            this.rootcondition_left_param1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.rootcondition_left_param1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.rootcondition_left_param1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxOnlyDigit);
            this.rootcondition_left_param1.Leave += new System.EventHandler(this.SaveData);
            // 
            // rootcondition_right_txt2
            // 
            this.rootcondition_right_txt2.Location = new System.Drawing.Point(373, 109);
            this.rootcondition_right_txt2.Name = "rootcondition_right_txt2";
            this.rootcondition_right_txt2.Size = new System.Drawing.Size(121, 21);
            this.rootcondition_right_txt2.TabIndex = 12;
            this.rootcondition_right_txt2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rootcondition_right_txt2.Visible = false;
            // 
            // rootcondition_right_param2
            // 
            // 
            // 
            // 
            this.rootcondition_right_param2.CustomButton.Image = null;
            this.rootcondition_right_param2.CustomButton.Location = new System.Drawing.Point(103, 2);
            this.rootcondition_right_param2.CustomButton.Name = "";
            this.rootcondition_right_param2.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.rootcondition_right_param2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.rootcondition_right_param2.CustomButton.TabIndex = 1;
            this.rootcondition_right_param2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rootcondition_right_param2.CustomButton.UseSelectable = true;
            this.rootcondition_right_param2.CustomButton.Visible = false;
            this.rootcondition_right_param2.Lines = new string[0];
            this.rootcondition_right_param2.Location = new System.Drawing.Point(373, 133);
            this.rootcondition_right_param2.MaxLength = 32767;
            this.rootcondition_right_param2.Name = "rootcondition_right_param2";
            this.rootcondition_right_param2.PasswordChar = '\0';
            this.rootcondition_right_param2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rootcondition_right_param2.SelectedText = "";
            this.rootcondition_right_param2.SelectionLength = 0;
            this.rootcondition_right_param2.SelectionStart = 0;
            this.rootcondition_right_param2.ShortcutsEnabled = true;
            this.rootcondition_right_param2.Size = new System.Drawing.Size(121, 20);
            this.rootcondition_right_param2.TabIndex = 11;
            this.rootcondition_right_param2.UseSelectable = true;
            this.rootcondition_right_param2.Visible = false;
            this.rootcondition_right_param2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.rootcondition_right_param2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.rootcondition_right_param2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxOnlyDigit);
            this.rootcondition_right_param2.Leave += new System.EventHandler(this.SaveData);
            // 
            // rootcondition_right_txt1
            // 
            this.rootcondition_right_txt1.Location = new System.Drawing.Point(373, 62);
            this.rootcondition_right_txt1.Name = "rootcondition_right_txt1";
            this.rootcondition_right_txt1.Size = new System.Drawing.Size(121, 21);
            this.rootcondition_right_txt1.TabIndex = 10;
            this.rootcondition_right_txt1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rootcondition_right_txt1.Visible = false;
            // 
            // rootcondition_right_param1
            // 
            // 
            // 
            // 
            this.rootcondition_right_param1.CustomButton.Image = null;
            this.rootcondition_right_param1.CustomButton.Location = new System.Drawing.Point(103, 2);
            this.rootcondition_right_param1.CustomButton.Name = "";
            this.rootcondition_right_param1.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.rootcondition_right_param1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.rootcondition_right_param1.CustomButton.TabIndex = 1;
            this.rootcondition_right_param1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rootcondition_right_param1.CustomButton.UseSelectable = true;
            this.rootcondition_right_param1.CustomButton.Visible = false;
            this.rootcondition_right_param1.Lines = new string[0];
            this.rootcondition_right_param1.Location = new System.Drawing.Point(373, 86);
            this.rootcondition_right_param1.MaxLength = 32767;
            this.rootcondition_right_param1.Name = "rootcondition_right_param1";
            this.rootcondition_right_param1.PasswordChar = '\0';
            this.rootcondition_right_param1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rootcondition_right_param1.SelectedText = "";
            this.rootcondition_right_param1.SelectionLength = 0;
            this.rootcondition_right_param1.SelectionStart = 0;
            this.rootcondition_right_param1.ShortcutsEnabled = true;
            this.rootcondition_right_param1.Size = new System.Drawing.Size(121, 20);
            this.rootcondition_right_param1.TabIndex = 9;
            this.rootcondition_right_param1.UseSelectable = true;
            this.rootcondition_right_param1.Visible = false;
            this.rootcondition_right_param1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.rootcondition_right_param1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.rootcondition_right_param1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxOnlyDigit);
            this.rootcondition_right_param1.Leave += new System.EventHandler(this.SaveData);
            // 
            // rootcondition_txt2
            // 
            this.rootcondition_txt2.Location = new System.Drawing.Point(246, 109);
            this.rootcondition_txt2.Name = "rootcondition_txt2";
            this.rootcondition_txt2.Size = new System.Drawing.Size(121, 21);
            this.rootcondition_txt2.TabIndex = 6;
            this.rootcondition_txt2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rootcondition_txt2.Visible = false;
            // 
            // rootcondition_param2
            // 
            // 
            // 
            // 
            this.rootcondition_param2.CustomButton.Image = null;
            this.rootcondition_param2.CustomButton.Location = new System.Drawing.Point(103, 2);
            this.rootcondition_param2.CustomButton.Name = "";
            this.rootcondition_param2.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.rootcondition_param2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.rootcondition_param2.CustomButton.TabIndex = 1;
            this.rootcondition_param2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rootcondition_param2.CustomButton.UseSelectable = true;
            this.rootcondition_param2.CustomButton.Visible = false;
            this.rootcondition_param2.Lines = new string[0];
            this.rootcondition_param2.Location = new System.Drawing.Point(246, 133);
            this.rootcondition_param2.MaxLength = 32767;
            this.rootcondition_param2.Name = "rootcondition_param2";
            this.rootcondition_param2.PasswordChar = '\0';
            this.rootcondition_param2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rootcondition_param2.SelectedText = "";
            this.rootcondition_param2.SelectionLength = 0;
            this.rootcondition_param2.SelectionStart = 0;
            this.rootcondition_param2.ShortcutsEnabled = true;
            this.rootcondition_param2.Size = new System.Drawing.Size(121, 20);
            this.rootcondition_param2.TabIndex = 5;
            this.rootcondition_param2.UseSelectable = true;
            this.rootcondition_param2.Visible = false;
            this.rootcondition_param2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.rootcondition_param2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.rootcondition_param2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxOnlyDigit);
            this.rootcondition_param2.Leave += new System.EventHandler(this.SaveData);
            // 
            // rootcondition_txt1
            // 
            this.rootcondition_txt1.Location = new System.Drawing.Point(246, 62);
            this.rootcondition_txt1.Name = "rootcondition_txt1";
            this.rootcondition_txt1.Size = new System.Drawing.Size(121, 21);
            this.rootcondition_txt1.TabIndex = 4;
            this.rootcondition_txt1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rootcondition_txt1.Visible = false;
            // 
            // rootcondition_param1
            // 
            // 
            // 
            // 
            this.rootcondition_param1.CustomButton.Image = null;
            this.rootcondition_param1.CustomButton.Location = new System.Drawing.Point(103, 2);
            this.rootcondition_param1.CustomButton.Name = "";
            this.rootcondition_param1.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.rootcondition_param1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.rootcondition_param1.CustomButton.TabIndex = 1;
            this.rootcondition_param1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rootcondition_param1.CustomButton.UseSelectable = true;
            this.rootcondition_param1.CustomButton.Visible = false;
            this.rootcondition_param1.Lines = new string[0];
            this.rootcondition_param1.Location = new System.Drawing.Point(246, 86);
            this.rootcondition_param1.MaxLength = 32767;
            this.rootcondition_param1.Name = "rootcondition_param1";
            this.rootcondition_param1.PasswordChar = '\0';
            this.rootcondition_param1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rootcondition_param1.SelectedText = "";
            this.rootcondition_param1.SelectionLength = 0;
            this.rootcondition_param1.SelectionStart = 0;
            this.rootcondition_param1.ShortcutsEnabled = true;
            this.rootcondition_param1.Size = new System.Drawing.Size(121, 20);
            this.rootcondition_param1.TabIndex = 3;
            this.rootcondition_param1.UseSelectable = true;
            this.rootcondition_param1.Visible = false;
            this.rootcondition_param1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.rootcondition_param1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.rootcondition_param1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxOnlyDigit);
            this.rootcondition_param1.Leave += new System.EventHandler(this.SaveData);
            // 
            // rootcondition_right
            // 
            this.rootcondition_right.FormattingEnabled = true;
            this.rootcondition_right.ItemHeight = 23;
            this.rootcondition_right.Location = new System.Drawing.Point(373, 30);
            this.rootcondition_right.Name = "rootcondition_right";
            this.rootcondition_right.Size = new System.Drawing.Size(121, 29);
            this.rootcondition_right.TabIndex = 2;
            this.rootcondition_right.UseSelectable = true;
            this.rootcondition_right.Visible = false;
            this.rootcondition_right.SelectedIndexChanged += new System.EventHandler(this.SaveData);
            // 
            // rootcondition_left
            // 
            this.rootcondition_left.FormattingEnabled = true;
            this.rootcondition_left.ItemHeight = 23;
            this.rootcondition_left.Location = new System.Drawing.Point(119, 30);
            this.rootcondition_left.Name = "rootcondition_left";
            this.rootcondition_left.Size = new System.Drawing.Size(121, 29);
            this.rootcondition_left.TabIndex = 1;
            this.rootcondition_left.UseSelectable = true;
            this.rootcondition_left.Visible = false;
            this.rootcondition_left.SelectedIndexChanged += new System.EventHandler(this.SaveData);
            // 
            // rootcondition_center
            // 
            this.rootcondition_center.FormattingEnabled = true;
            this.rootcondition_center.ItemHeight = 23;
            this.rootcondition_center.Location = new System.Drawing.Point(246, 30);
            this.rootcondition_center.Name = "rootcondition_center";
            this.rootcondition_center.Size = new System.Drawing.Size(121, 29);
            this.rootcondition_center.TabIndex = 0;
            this.rootcondition_center.UseSelectable = true;
            this.rootcondition_center.SelectedIndexChanged += new System.EventHandler(this.SaveData);
            // 
            // operation_box
            // 
            this.operation_box.Controls.Add(this.op_box);
            this.operation_box.Controls.Add(this.operations_list);
            this.operation_box.Location = new System.Drawing.Point(201, 298);
            this.operation_box.Name = "operation_box";
            this.operation_box.Size = new System.Drawing.Size(629, 297);
            this.operation_box.TabIndex = 4;
            this.operation_box.TabStop = false;
            this.operation_box.Text = "Операции (Версия 1)";
            // 
            // op_box
            // 
            this.op_box.Controls.Add(this.operation_param);
            this.op_box.Controls.Add(this.target_param);
            this.op_box.Controls.Add(this.target_param_txt);
            this.op_box.Controls.Add(this.target);
            this.op_box.Controls.Add(this.TargetType);
            this.op_box.Location = new System.Drawing.Point(211, 19);
            this.op_box.Name = "op_box";
            this.op_box.Size = new System.Drawing.Size(412, 266);
            this.op_box.TabIndex = 10;
            this.op_box.TabStop = false;
            this.op_box.Text = "Параметры операции";
            // 
            // operation_param
            // 
            this.operation_param.AllowUserToAddRows = false;
            this.operation_param.AllowUserToDeleteRows = false;
            this.operation_param.AllowUserToResizeColumns = false;
            this.operation_param.AllowUserToResizeRows = false;
            this.operation_param.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.operation_param.BackgroundColor = System.Drawing.SystemColors.Window;
            this.operation_param.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.operation_param.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.operation_param.GridColor = System.Drawing.Color.Black;
            this.operation_param.Location = new System.Drawing.Point(9, 19);
            this.operation_param.Name = "operation_param";
            this.operation_param.RowHeadersVisible = false;
            this.operation_param.Size = new System.Drawing.Size(397, 204);
            this.operation_param.TabIndex = 14;
            this.operation_param.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.operation_param_CellEndEdit);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Имя";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 150F;
            this.Column2.HeaderText = "Значение";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // target_param
            // 
            // 
            // 
            // 
            this.target_param.CustomButton.Image = null;
            this.target_param.CustomButton.Location = new System.Drawing.Point(53, 2);
            this.target_param.CustomButton.Name = "";
            this.target_param.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.target_param.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.target_param.CustomButton.TabIndex = 1;
            this.target_param.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.target_param.CustomButton.UseSelectable = true;
            this.target_param.CustomButton.Visible = false;
            this.target_param.Lines = new string[0];
            this.target_param.Location = new System.Drawing.Point(306, 229);
            this.target_param.MaxLength = 32767;
            this.target_param.Name = "target_param";
            this.target_param.PasswordChar = '\0';
            this.target_param.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.target_param.SelectedText = "";
            this.target_param.SelectionLength = 0;
            this.target_param.SelectionStart = 0;
            this.target_param.ShortcutsEnabled = true;
            this.target_param.Size = new System.Drawing.Size(71, 20);
            this.target_param.TabIndex = 13;
            this.target_param.UseSelectable = true;
            this.target_param.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.target_param.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.target_param.DoubleClick += new System.EventHandler(this.target_param_DoubleClick);
            this.target_param.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxOnlyDigit);
            this.target_param.Leave += new System.EventHandler(this.SaveData);
            // 
            // target_param_txt
            // 
            this.target_param_txt.AutoSize = true;
            this.target_param_txt.Location = new System.Drawing.Point(232, 229);
            this.target_param_txt.Name = "target_param_txt";
            this.target_param_txt.Size = new System.Drawing.Size(69, 19);
            this.target_param_txt.TabIndex = 12;
            this.target_param_txt.Text = "Параметр";
            // 
            // target
            // 
            this.target.AutoSize = true;
            this.target.Location = new System.Drawing.Point(6, 229);
            this.target.Name = "target";
            this.target.Size = new System.Drawing.Size(48, 19);
            this.target.TabIndex = 10;
            this.target.Text = "Таргет";
            // 
            // TargetType
            // 
            this.TargetType.FormattingEnabled = true;
            this.TargetType.ItemHeight = 23;
            this.TargetType.Location = new System.Drawing.Point(54, 226);
            this.TargetType.Name = "TargetType";
            this.TargetType.Size = new System.Drawing.Size(172, 29);
            this.TargetType.TabIndex = 9;
            this.TargetType.UseSelectable = true;
            this.TargetType.SelectedIndexChanged += new System.EventHandler(this.SaveData);
            // 
            // operations_list
            // 
            this.operations_list.ContextMenuStrip = this.operation_menu;
            this.operations_list.FormattingEnabled = true;
            this.operations_list.Location = new System.Drawing.Point(21, 21);
            this.operations_list.Name = "operations_list";
            this.operations_list.Size = new System.Drawing.Size(184, 264);
            this.operations_list.TabIndex = 8;
            this.operations_list.SelectedIndexChanged += new System.EventHandler(this.operations_list_SelectedIndexChanged);
            // 
            // operation_menu
            // 
            this.operation_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.op_add,
            this.op_remove});
            this.operation_menu.Name = "contextMenuStrip1";
            this.operation_menu.Size = new System.Drawing.Size(127, 48);
            // 
            // op_add
            // 
            this.op_add.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operationsComboBox,
            this.op_add_c});
            this.op_add.Name = "op_add";
            this.op_add.Size = new System.Drawing.Size(126, 22);
            this.op_add.Text = "Добавить";
            // 
            // operationsComboBox
            // 
            this.operationsComboBox.IntegralHeight = false;
            this.operationsComboBox.Name = "operationsComboBox";
            this.operationsComboBox.Size = new System.Drawing.Size(160, 23);
            // 
            // op_add_c
            // 
            this.op_add_c.Name = "op_add_c";
            this.op_add_c.Size = new System.Drawing.Size(220, 22);
            this.op_add_c.Text = "Добавить";
            this.op_add_c.Click += new System.EventHandler(this.добавитьToolStripMenuItem3_Click);
            // 
            // op_remove
            // 
            this.op_remove.Name = "op_remove";
            this.op_remove.Size = new System.Drawing.Size(126, 22);
            this.op_remove.Text = "Удалить";
            this.op_remove.Click += new System.EventHandler(this.удалитьToolStripMenuItem2_Click);
            // 
            // select_lang
            // 
            this.select_lang.FormattingEnabled = true;
            this.select_lang.ItemHeight = 23;
            this.select_lang.Location = new System.Drawing.Point(727, 651);
            this.select_lang.Name = "select_lang";
            this.select_lang.Size = new System.Drawing.Size(103, 29);
            this.select_lang.TabIndex = 5;
            this.select_lang.UseSelectable = true;
            this.select_lang.SelectedIndexChanged += new System.EventHandler(this.select_lang_SelectedIndexChanged);
            // 
            // lang
            // 
            this.lang.AutoSize = true;
            this.lang.Location = new System.Drawing.Point(679, 655);
            this.lang.Name = "lang";
            this.lang.Size = new System.Drawing.Size(42, 19);
            this.lang.TabIndex = 6;
            this.lang.Text = "Язык:";
            // 
            // Progress
            // 
            this.Progress.Location = new System.Drawing.Point(20, 676);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(175, 13);
            this.Progress.TabIndex = 7;
            // 
            // search_pattern
            // 
            // 
            // 
            // 
            this.search_pattern.CustomButton.Image = null;
            this.search_pattern.CustomButton.Location = new System.Drawing.Point(222, 2);
            this.search_pattern.CustomButton.Name = "";
            this.search_pattern.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.search_pattern.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.search_pattern.CustomButton.TabIndex = 1;
            this.search_pattern.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.search_pattern.CustomButton.UseSelectable = true;
            this.search_pattern.CustomButton.Visible = false;
            this.search_pattern.Lines = new string[0];
            this.search_pattern.Location = new System.Drawing.Point(306, 654);
            this.search_pattern.MaxLength = 32767;
            this.search_pattern.Name = "search_pattern";
            this.search_pattern.PasswordChar = '\0';
            this.search_pattern.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.search_pattern.SelectedText = "";
            this.search_pattern.SelectionLength = 0;
            this.search_pattern.SelectionStart = 0;
            this.search_pattern.ShortcutsEnabled = true;
            this.search_pattern.Size = new System.Drawing.Size(240, 20);
            this.search_pattern.TabIndex = 8;
            this.search_pattern.UseSelectable = true;
            this.search_pattern.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.search_pattern.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // search_string
            // 
            this.search_string.AutoSize = true;
            this.search_string.Location = new System.Drawing.Point(201, 653);
            this.search_string.Name = "search_string";
            this.search_string.Size = new System.Drawing.Size(99, 19);
            this.search_string.TabIndex = 9;
            this.search_string.Text = "Строка поиска";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(552, 654);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(85, 23);
            this.Search.TabIndex = 10;
            this.Search.Text = "Поиск";
            this.Search.UseSelectable = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // triggers_mobs
            // 
            this.triggers_mobs.BackColor = System.Drawing.SystemColors.Window;
            this.triggers_mobs.Location = new System.Drawing.Point(201, 601);
            this.triggers_mobs.Name = "triggers_mobs";
            this.triggers_mobs.ReadOnly = true;
            this.triggers_mobs.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.triggers_mobs.Size = new System.Drawing.Size(629, 49);
            this.triggers_mobs.TabIndex = 12;
            this.triggers_mobs.Text = "Mobs:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 700);
            this.Controls.Add(this.triggers_mobs);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.search_string);
            this.Controls.Add(this.search_pattern);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.lang);
            this.Controls.Add(this.select_lang);
            this.Controls.Add(this.operation_box);
            this.Controls.Add(this.cond_box);
            this.Controls.Add(this.controller_box);
            this.Controls.Add(this.trigger_box);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(850, 700);
            this.MinimumSize = new System.Drawing.Size(850, 700);
            this.Name = "MainForm";
            this.Text = "Next AIPolicy Editor 2.1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.trigger_box.ResumeLayout(false);
            this.trigger_box.PerformLayout();
            this.trigger_menu.ResumeLayout(false);
            this.controller_box.ResumeLayout(false);
            this.controller_box.PerformLayout();
            this.controller_menu.ResumeLayout(false);
            this.cond_box.ResumeLayout(false);
            this.operation_box.ResumeLayout(false);
            this.op_box.ResumeLayout(false);
            this.op_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operation_param)).EndInit();
            this.operation_menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem file;
        private System.Windows.Forms.ToolStripMenuItem open_file;
        private System.Windows.Forms.ToolStripMenuItem save_file;
        private System.Windows.Forms.GroupBox trigger_box;
        private System.Windows.Forms.GroupBox controller_box;
        private System.Windows.Forms.GroupBox cond_box;
        private System.Windows.Forms.GroupBox operation_box;
        private MetroComboBox TargetType;
        private System.Windows.Forms.GroupBox op_box;
        private MetroLabel target;
        private MetroComboBox select_lang;
        private MetroLabel lang;
        private MetroCheckBox bAttackValid;
        private MetroCheckBox bRun;
        private MetroCheckBox bActive;
        private MetroLabel label2;
        private MetroTextBox controller_id;
        private MetroLabel c_name;
        private MetroTextBox controller_name;
        private MetroLabel target_param_txt;
        private System.Windows.Forms.DataGridView operation_param;
        private System.Windows.Forms.ToolStripMenuItem about;
        private MetroComboBox rootcondition_center;
        private MetroComboBox rootcondition_right;
        private MetroComboBox rootcondition_left;
        private MetroTextBox rootcondition_param1;
        private MetroLabel rootcondition_txt1;
        private MetroLabel rootcondition_txt2;
        private MetroTextBox rootcondition_param2;
        private MetroLabel rootcondition_left_txt2;
        private MetroTextBox rootcondition_left_param2;
        private MetroLabel rootcondition_left_txt1;
        private MetroTextBox rootcondition_left_param1;
        private MetroLabel rootcondition_right_txt2;
        private MetroTextBox rootcondition_right_param2;
        private MetroLabel rootcondition_right_txt1;
        private MetroTextBox rootcondition_right_param1;
        private MetroButton SubConditionLeft;
        private MetroButton SubConditionRight;
        private System.Windows.Forms.ContextMenuStrip trigger_menu;
        private System.Windows.Forms.ContextMenuStrip controller_menu;
        private System.Windows.Forms.ContextMenuStrip operation_menu;
        private System.Windows.Forms.ToolStripMenuItem trigger_add;
        private System.Windows.Forms.ToolStripMenuItem trigger_remove;
        private MetroLabel label5;
        private MetroTextBox trigger_id;
        private MetroTextBox search_pattern;
        private MetroLabel search_string;
        private MetroButton Search;
        private System.Windows.Forms.ToolStripMenuItem controller_add;
        private System.Windows.Forms.ToolStripMenuItem controller_remove;
        private System.Windows.Forms.ToolStripMenuItem tools;
        private System.Windows.Forms.ToolStripMenuItem delete_empty_triggers;
        private System.Windows.Forms.ToolStripMenuItem remove_empty_controllers;
        private System.Windows.Forms.ToolStripMenuItem op_add;
        private System.Windows.Forms.ToolStripMenuItem op_remove;
        private System.Windows.Forms.ToolStripComboBox operationsComboBox;
        private System.Windows.Forms.ToolStripMenuItem op_add_c;
        public System.Windows.Forms.ListBox triggers_list;
        public System.Windows.Forms.ListBox controllers_list;
        public System.Windows.Forms.ListBox operations_list;
        public MetroProgressBar Progress;
        public MetroTextBox target_param;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem find;
        private System.Windows.Forms.ToolStripComboBox operation_list;
        private System.Windows.Forms.ToolStripMenuItem find_uses;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem load_elements;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.RichTextBox triggers_mobs;
    }
}

