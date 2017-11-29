namespace AlarmSystem
{
    partial class AlarmForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmForm));
            this.txtUserTime = new System.Windows.Forms.MaskedTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbTime = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemMaximize = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemStart = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemStop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemSelectMusic = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDefaultMusic = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemNotifyBlock = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNotifyLogOff = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNotifyRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNotifyTurnOff = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNotifyCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lbSegunds = new System.Windows.Forms.Label();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.metroToggleOnOff = new MetroFramework.Controls.MetroToggle();
            this.contextMenuSettings = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.menuItemLight = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDark = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemSelectSound = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDefaultSound = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemFormBlock = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFormLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFormRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFormTurnOff = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFormCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.chkShutdownComputer = new MetroFramework.Controls.MetroCheckBox();
            this.lbDate = new MetroFramework.Controls.MetroLabel();
            this.lbDay = new MetroFramework.Controls.MetroLabel();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.contextMenuStripNotify.SuspendLayout();
            this.contextMenuSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUserTime
            // 
            this.txtUserTime.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtUserTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserTime.Location = new System.Drawing.Point(170, 169);
            this.txtUserTime.Mask = "00:00:00";
            this.txtUserTime.Name = "txtUserTime";
            this.txtUserTime.Size = new System.Drawing.Size(109, 31);
            this.txtUserTime.TabIndex = 6;
            this.txtUserTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroToolTip1.SetToolTip(this.txtUserTime, "Hora do alarme/desligamento");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lbTime
            // 
            this.lbTime.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTime.Location = new System.Drawing.Point(125, 49);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(199, 73);
            this.lbTime.TabIndex = 7;
            this.lbTime.Text = "00:00";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(8, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 10);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbStatus.Location = new System.Drawing.Point(175, 122);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(98, 20);
            this.lbStatus.TabIndex = 9;
            this.lbStatus.Text = "Em espera...";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStripNotify;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "AlarmSystem";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStripNotify
            // 
            this.contextMenuStripNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemMaximize,
            this.toolStripSeparator3,
            this.menuItemStart,
            this.menuItemStop,
            this.toolStripSeparator1,
            this.menuItemSelectMusic,
            this.menuItemDefaultMusic,
            this.toolStripSeparator2,
            this.menuItemNotifyBlock,
            this.menuItemNotifyLogOff,
            this.menuItemNotifyRestart,
            this.menuItemNotifyTurnOff,
            this.menuItemNotifyCancel,
            this.toolStripSeparator6,
            this.menuItemExit});
            this.contextMenuStripNotify.Name = "contextMenuStrip1";
            this.contextMenuStripNotify.Size = new System.Drawing.Size(170, 270);
            this.contextMenuStripNotify.Text = "Parar Alarme";
            // 
            // menuItemMaximize
            // 
            this.menuItemMaximize.Image = global::AlarmSystem.Properties.Resources.Plasma_Display_icon;
            this.menuItemMaximize.Name = "menuItemMaximize";
            this.menuItemMaximize.Size = new System.Drawing.Size(169, 22);
            this.menuItemMaximize.Text = "Restaurar";
            this.menuItemMaximize.ToolTipText = "Maximizar janela";
            this.menuItemMaximize.Click += new System.EventHandler(this.menuItemMaximize_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(166, 6);
            // 
            // menuItemStart
            // 
            this.menuItemStart.Image = global::AlarmSystem.Properties.Resources.start_icon;
            this.menuItemStart.Name = "menuItemStart";
            this.menuItemStart.Size = new System.Drawing.Size(169, 22);
            this.menuItemStart.Text = "Iniciar Alarme";
            this.menuItemStart.ToolTipText = "Iniciar alarme";
            this.menuItemStart.Click += new System.EventHandler(this.menuItemStart_Click);
            // 
            // menuItemStop
            // 
            this.menuItemStop.Image = global::AlarmSystem.Properties.Resources.Stop_icon;
            this.menuItemStop.Name = "menuItemStop";
            this.menuItemStop.Size = new System.Drawing.Size(169, 22);
            this.menuItemStop.Text = "Para Alarme";
            this.menuItemStop.ToolTipText = "Parar alarme";
            this.menuItemStop.Click += new System.EventHandler(this.menuItemStop_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(166, 6);
            // 
            // menuItemSelectMusic
            // 
            this.menuItemSelectMusic.Image = global::AlarmSystem.Properties.Resources.Cursor_Click_icon;
            this.menuItemSelectMusic.Name = "menuItemSelectMusic";
            this.menuItemSelectMusic.Size = new System.Drawing.Size(169, 22);
            this.menuItemSelectMusic.Text = "Selecionar Música";
            this.menuItemSelectMusic.ToolTipText = "Selecionar música para alarme";
            this.menuItemSelectMusic.Click += new System.EventHandler(this.menuItemSelectMusic_Click);
            // 
            // menuItemDefaultMusic
            // 
            this.menuItemDefaultMusic.Image = global::AlarmSystem.Properties.Resources.Default_Icon_icon;
            this.menuItemDefaultMusic.Name = "menuItemDefaultMusic";
            this.menuItemDefaultMusic.Size = new System.Drawing.Size(169, 22);
            this.menuItemDefaultMusic.Text = "Música Padrão";
            this.menuItemDefaultMusic.ToolTipText = "Definir música padrão do sistema";
            this.menuItemDefaultMusic.Click += new System.EventHandler(this.menuItemDefaultMusic_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(166, 6);
            // 
            // menuItemNotifyBlock
            // 
            this.menuItemNotifyBlock.Image = global::AlarmSystem.Properties.Resources.Windows_Log_Off_icon;
            this.menuItemNotifyBlock.Name = "menuItemNotifyBlock";
            this.menuItemNotifyBlock.Size = new System.Drawing.Size(169, 22);
            this.menuItemNotifyBlock.Text = "Bloquear";
            this.menuItemNotifyBlock.ToolTipText = "Bloquear computador";
            this.menuItemNotifyBlock.Click += new System.EventHandler(this.menuItemNotifyBlock_Click);
            // 
            // menuItemNotifyLogOff
            // 
            this.menuItemNotifyLogOff.Image = global::AlarmSystem.Properties.Resources.Button_Turn_Off_icon;
            this.menuItemNotifyLogOff.Name = "menuItemNotifyLogOff";
            this.menuItemNotifyLogOff.Size = new System.Drawing.Size(169, 22);
            this.menuItemNotifyLogOff.Text = "Logoff";
            this.menuItemNotifyLogOff.ToolTipText = "Trocar usuário";
            this.menuItemNotifyLogOff.Click += new System.EventHandler(this.menuItemNotifyLogOff_Click);
            // 
            // menuItemNotifyRestart
            // 
            this.menuItemNotifyRestart.Image = global::AlarmSystem.Properties.Resources.Windows_Restart_icon;
            this.menuItemNotifyRestart.Name = "menuItemNotifyRestart";
            this.menuItemNotifyRestart.Size = new System.Drawing.Size(169, 22);
            this.menuItemNotifyRestart.Text = "Reiniciar";
            this.menuItemNotifyRestart.ToolTipText = "Reiniciar computador";
            this.menuItemNotifyRestart.Click += new System.EventHandler(this.menuItemNotifyRestart_Click);
            // 
            // menuItemNotifyTurnOff
            // 
            this.menuItemNotifyTurnOff.Image = global::AlarmSystem.Properties.Resources.Windows_Turn_Off_icon;
            this.menuItemNotifyTurnOff.Name = "menuItemNotifyTurnOff";
            this.menuItemNotifyTurnOff.Size = new System.Drawing.Size(169, 22);
            this.menuItemNotifyTurnOff.Text = "Desligar";
            this.menuItemNotifyTurnOff.ToolTipText = "Desligar computador";
            this.menuItemNotifyTurnOff.Click += new System.EventHandler(this.menuItemNotifyTurnOff_Click);
            // 
            // menuItemNotifyCancel
            // 
            this.menuItemNotifyCancel.Image = global::AlarmSystem.Properties.Resources.Close_2_icon;
            this.menuItemNotifyCancel.Name = "menuItemNotifyCancel";
            this.menuItemNotifyCancel.Size = new System.Drawing.Size(169, 22);
            this.menuItemNotifyCancel.Text = "Cancelar";
            this.menuItemNotifyCancel.ToolTipText = "Cancelar desligamento";
            this.menuItemNotifyCancel.Click += new System.EventHandler(this.menuItemNotifyCancel_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(166, 6);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Image = global::AlarmSystem.Properties.Resources.Log_Out_icon;
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(169, 22);
            this.menuItemExit.Text = "Fechar";
            this.menuItemExit.ToolTipText = "Fechar aplicação";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // lbSegunds
            // 
            this.lbSegunds.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbSegunds.AutoSize = true;
            this.lbSegunds.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSegunds.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbSegunds.Location = new System.Drawing.Point(310, 97);
            this.lbSegunds.Name = "lbSegunds";
            this.lbSegunds.Size = new System.Drawing.Size(38, 25);
            this.lbSegunds.TabIndex = 12;
            this.lbSegunds.Text = "00";
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroProgressBar1.Location = new System.Drawing.Point(8, 148);
            this.metroProgressBar1.Maximum = 60;
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(423, 10);
            this.metroProgressBar1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroProgressBar1.TabIndex = 13;
            this.metroProgressBar1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroToggleOnOff
            // 
            this.metroToggleOnOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroToggleOnOff.AutoSize = true;
            this.metroToggleOnOff.Location = new System.Drawing.Point(338, 183);
            this.metroToggleOnOff.Name = "metroToggleOnOff";
            this.metroToggleOnOff.Size = new System.Drawing.Size(80, 17);
            this.metroToggleOnOff.Style = MetroFramework.MetroColorStyle.Green;
            this.metroToggleOnOff.TabIndex = 14;
            this.metroToggleOnOff.Text = "Off";
            this.metroToggleOnOff.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroToolTip1.SetToolTip(this.metroToggleOnOff, "Habilitar/desabilitar alarme\r\n");
            this.metroToggleOnOff.UseSelectable = true;
            this.metroToggleOnOff.CheckedChanged += new System.EventHandler(this.metroToggleOnOff_CheckedChanged);
            // 
            // contextMenuSettings
            // 
            this.contextMenuSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemLight,
            this.toolStripMenuItemDark,
            this.toolStripSeparator4,
            this.menuItemSelectSound,
            this.menuItemDefaultSound,
            this.toolStripSeparator5,
            this.menuItemFormBlock,
            this.menuItemFormLogOut,
            this.menuItemFormRestart,
            this.menuItemFormTurnOff,
            this.menuItemFormCancel});
            this.contextMenuSettings.Name = "contextMenuSettings";
            this.contextMenuSettings.Size = new System.Drawing.Size(170, 214);
            this.contextMenuSettings.Text = "Configurações";
            // 
            // menuItemLight
            // 
            this.menuItemLight.Image = global::AlarmSystem.Properties.Resources.themes_2_icon;
            this.menuItemLight.Name = "menuItemLight";
            this.menuItemLight.Size = new System.Drawing.Size(169, 22);
            this.menuItemLight.Text = "Tema Light";
            this.menuItemLight.ToolTipText = "Definir tema light";
            this.menuItemLight.Click += new System.EventHandler(this.menuItemLight_Click);
            // 
            // toolStripMenuItemDark
            // 
            this.toolStripMenuItemDark.Image = global::AlarmSystem.Properties.Resources.themes_icon;
            this.toolStripMenuItemDark.Name = "toolStripMenuItemDark";
            this.toolStripMenuItemDark.Size = new System.Drawing.Size(169, 22);
            this.toolStripMenuItemDark.Text = "Tema Dark";
            this.toolStripMenuItemDark.ToolTipText = "Definir tema dark";
            this.toolStripMenuItemDark.Click += new System.EventHandler(this.toolStripMenuItemDark_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(166, 6);
            // 
            // menuItemSelectSound
            // 
            this.menuItemSelectSound.Image = global::AlarmSystem.Properties.Resources.Cursor_Click_icon;
            this.menuItemSelectSound.Name = "menuItemSelectSound";
            this.menuItemSelectSound.Size = new System.Drawing.Size(169, 22);
            this.menuItemSelectSound.Text = "Selecionar Música";
            this.menuItemSelectSound.ToolTipText = "Selecionar música para alarme";
            this.menuItemSelectSound.Click += new System.EventHandler(this.menuItemSelectSom_Click);
            // 
            // menuItemDefaultSound
            // 
            this.menuItemDefaultSound.Image = global::AlarmSystem.Properties.Resources.Default_Icon_icon;
            this.menuItemDefaultSound.Name = "menuItemDefaultSound";
            this.menuItemDefaultSound.Size = new System.Drawing.Size(169, 22);
            this.menuItemDefaultSound.Text = "Música Padrão";
            this.menuItemDefaultSound.ToolTipText = "Definir música padrão do sistema\r\n para alarme";
            this.menuItemDefaultSound.Click += new System.EventHandler(this.menuItemDefaultSom_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(166, 6);
            // 
            // menuItemFormBlock
            // 
            this.menuItemFormBlock.Image = global::AlarmSystem.Properties.Resources.Windows_Log_Off_icon;
            this.menuItemFormBlock.Name = "menuItemFormBlock";
            this.menuItemFormBlock.Size = new System.Drawing.Size(169, 22);
            this.menuItemFormBlock.Text = "Bloquear";
            this.menuItemFormBlock.ToolTipText = "Bloquear computador";
            this.menuItemFormBlock.Click += new System.EventHandler(this.menuItemFormBlock_Click);
            // 
            // menuItemFormLogOut
            // 
            this.menuItemFormLogOut.Image = global::AlarmSystem.Properties.Resources.Button_Turn_Off_icon;
            this.menuItemFormLogOut.Name = "menuItemFormLogOut";
            this.menuItemFormLogOut.Size = new System.Drawing.Size(169, 22);
            this.menuItemFormLogOut.Text = "Logoff";
            this.menuItemFormLogOut.ToolTipText = "Trocar usuário dos sistema";
            this.menuItemFormLogOut.Click += new System.EventHandler(this.menuItemFormLogOut_Click);
            // 
            // menuItemFormRestart
            // 
            this.menuItemFormRestart.Image = global::AlarmSystem.Properties.Resources.Windows_Restart_icon;
            this.menuItemFormRestart.Name = "menuItemFormRestart";
            this.menuItemFormRestart.Size = new System.Drawing.Size(169, 22);
            this.menuItemFormRestart.Text = "Reiniciar";
            this.menuItemFormRestart.ToolTipText = "Reiniciar computador";
            this.menuItemFormRestart.Click += new System.EventHandler(this.menuItemFormRestart_Click);
            // 
            // menuItemFormTurnOff
            // 
            this.menuItemFormTurnOff.Image = global::AlarmSystem.Properties.Resources.Windows_Turn_Off_icon;
            this.menuItemFormTurnOff.Name = "menuItemFormTurnOff";
            this.menuItemFormTurnOff.Size = new System.Drawing.Size(169, 22);
            this.menuItemFormTurnOff.Text = "Desligar";
            this.menuItemFormTurnOff.ToolTipText = "Desligar computador";
            this.menuItemFormTurnOff.Click += new System.EventHandler(this.menuItemFormTurnOff_Click);
            // 
            // menuItemFormCancel
            // 
            this.menuItemFormCancel.Image = global::AlarmSystem.Properties.Resources.Close_2_icon;
            this.menuItemFormCancel.Name = "menuItemFormCancel";
            this.menuItemFormCancel.Size = new System.Drawing.Size(169, 22);
            this.menuItemFormCancel.Text = "Cancelar";
            this.menuItemFormCancel.ToolTipText = "Cancelar desligamento";
            this.menuItemFormCancel.Click += new System.EventHandler(this.menuItemFormCancel_Click);
            // 
            // chkShutdownComputer
            // 
            this.chkShutdownComputer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkShutdownComputer.AutoSize = true;
            this.chkShutdownComputer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkShutdownComputer.Location = new System.Drawing.Point(14, 184);
            this.chkShutdownComputer.Name = "chkShutdownComputer";
            this.chkShutdownComputer.Size = new System.Drawing.Size(83, 15);
            this.chkShutdownComputer.Style = MetroFramework.MetroColorStyle.Green;
            this.chkShutdownComputer.TabIndex = 15;
            this.chkShutdownComputer.Text = "Desligar PC";
            this.chkShutdownComputer.UseSelectable = true;
            this.chkShutdownComputer.CheckedChanged += new System.EventHandler(this.chkShutdownComputer_CheckedChanged);
            // 
            // lbDate
            // 
            this.lbDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbDate.AutoSize = true;
            this.lbDate.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbDate.Location = new System.Drawing.Point(8, 117);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(98, 25);
            this.lbDate.TabIndex = 16;
            this.lbDate.Text = "31 mai 2017";
            // 
            // lbDay
            // 
            this.lbDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDay.AutoSize = true;
            this.lbDay.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbDay.Location = new System.Drawing.Point(390, 117);
            this.lbDay.Name = "lbDay";
            this.lbDay.Size = new System.Drawing.Size(41, 25);
            this.lbDay.TabIndex = 17;
            this.lbDay.Text = "qua";
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Tag = "Habilita/Desabilita Alarme";
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // AlarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 213);
            this.ContextMenuStrip = this.contextMenuSettings;
            this.Controls.Add(this.lbDay);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.chkShutdownComputer);
            this.Controls.Add(this.metroToggleOnOff);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.lbSegunds);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.txtUserTime);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(441, 213);
            this.MinimumSize = new System.Drawing.Size(441, 213);
            this.Name = "AlarmForm";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Alarme";
            this.contextMenuStripNotify.ResumeLayout(false);
            this.contextMenuSettings.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox txtUserTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNotify;
        private System.Windows.Forms.ToolStripMenuItem menuItemStop;
        private System.Windows.Forms.ToolStripMenuItem menuItemSelectMusic;
        private System.Windows.Forms.ToolStripMenuItem menuItemDefaultMusic;
        private System.Windows.Forms.ToolStripMenuItem menuItemMaximize;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.Label lbSegunds;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroToggle metroToggleOnOff;
        private MetroFramework.Controls.MetroContextMenu contextMenuSettings;
        private System.Windows.Forms.ToolStripMenuItem menuItemSelectSound;
        private System.Windows.Forms.ToolStripMenuItem menuItemDefaultSound;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuItemStart;
        private MetroFramework.Controls.MetroCheckBox chkShutdownComputer;
        private System.Windows.Forms.ToolStripMenuItem menuItemLight;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDark;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private MetroFramework.Controls.MetroLabel lbDate;
        private MetroFramework.Controls.MetroLabel lbDay;
        private System.Windows.Forms.ToolStripMenuItem menuItemFormLogOut;
        private System.Windows.Forms.ToolStripMenuItem menuItemFormRestart;
        private System.Windows.Forms.ToolStripMenuItem menuItemFormTurnOff;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem menuItemNotifyLogOff;
        private System.Windows.Forms.ToolStripMenuItem menuItemNotifyRestart;
        private System.Windows.Forms.ToolStripMenuItem menuItemNotifyTurnOff;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem menuItemNotifyBlock;
        private System.Windows.Forms.ToolStripMenuItem menuItemFormBlock;
        private System.Windows.Forms.ToolStripMenuItem menuItemFormCancel;
        private System.Windows.Forms.ToolStripMenuItem menuItemNotifyCancel;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
    }
}

