using AlarmSystem.AlarmSettings;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using WMPLib;

namespace AlarmSystem
{
    public partial class AlarmForm : MetroFramework.Forms.MetroForm
    {
        #region Criação de variáveis e propriedades
        System.Timers.Timer _timer;
        WindowsMediaPlayer _player;
        delegate void UpdateLabel(Label label, string value);

        Settings _settings;

        readonly string _start = "Em execução...";
        readonly string _stop = "Em espera...";
        bool _close;

        #endregion

        public AlarmForm()
        {
            InitializeComponent();
            
            _settings = new Settings();

            CreateTimer();
            SetTheme(_settings.Theme);
            AsignEvents();
            SetLabelsDate();
        }

        private void AsignEvents()
        {
            notifyIcon1.DoubleClick += NotifyIcon1_DoubleClick;
            this.FormClosing += AlarmForm_FormClosing;
        }

        private void AlarmForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (_close)
                    notifyIcon1.Dispose();
                else
                {
                    MinimizeToTray();
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                MessageError(ex.Message);
            }
        }

        #region Alterar labels de data e hora e barra de progresso
        private void SetLabelsDate()
        {
            var currentDateTime = DateTime.Now;
            lbDate.Text = currentDateTime.ToString("dd MMM yyyy");
            lbDay.Text = currentDateTime.ToString("ddd");
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                var currentDateTime = DateTime.Now;
                lbTime.Text = currentDateTime.ToShortTimeString();
                lbSegunds.Text = currentDateTime.ToString("ss");

                metroProgressBar1.Value = currentDateTime.Second;
            }
            catch (Exception ex)
            {
                MessageError(ex.Message);
            }
        }
        #endregion

        #region Alterar label de status
        private void UpdateLabelText()
        {
            UpdateLabel updateLabel = UpdatDataLabel;
            if (lbStatus.InvokeRequired)
                Invoke(updateLabel, lbStatus, _stop);
        }

        private void UpdatDataLabel(Label label, string value)
        {
            label.Text = value;
        }
        #endregion

        #region Eventos e métodos para minimizar para bandeja e maximizar
        private void NotifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                MaximizeForm();
            }
            catch (Exception ex)
            {
                MessageError(ex.Message);
            }
        }

        private void MaximizeForm()
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;
        }

        private void MinimizeToTray()
        {
            this.Visible = false;
            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;
            notifyIcon1.Visible = true;

            notifyIcon1.BalloonTipTitle = "AlarmSystem";
            notifyIcon1.BalloonTipText = " AlarmSystem ainda está sendo executado";
            notifyIcon1.ShowBalloonTip(500);
        }
        #endregion

        #region Criação de timer e evento do mesmo para controlar alarme e desligamento do computador
        private void CreateTimer()
        {
            _timer = new System.Timers.Timer();
            _timer.Interval = 1000;
            _timer.Elapsed += _timer_Elapsed;
        }

        private void _timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            var currentTime = DateTime.Now.ToLongTimeString();

            var userTime = txtUserTime.Text;

            if (string.IsNullOrEmpty(userTime))
                return;

            if (currentTime == userTime)
            {
                _timer.Stop();

                try
                {
                    UpdateLabelText();

                    if (metroToggleOnOff.Checked)
                        StartMusic();

                    if (chkShutdownComputer.Checked)
                        ShutDownComputer(ShutdownOptionsEnum.TurnOff);
                }
                catch (Exception ex)
                {
                    MessageError(ex.Message);
                }
            }
        }
        #endregion

        #region Métodos  para bloquear a desligar computador
        private void ShutDownComputer(ShutdownOptionsEnum shutdownOption)
        {
            var shutdown = string.Empty;

            switch (shutdownOption)
            {
                case ShutdownOptionsEnum.TurnOff:
                    shutdown = "-s";
                    break;
                case ShutdownOptionsEnum.Restart:
                    shutdown = "-r";
                    break;
                case ShutdownOptionsEnum.LogOut:
                    shutdown = "-l";
                    break;
                case ShutdownOptionsEnum.Block:
                    shutdown = "User32.dll, LockWorkStation";
                    break;
                case ShutdownOptionsEnum.Cancel:
                    shutdown = "-a";
                    break;
            }

            if (shutdownOption == ShutdownOptionsEnum.Block)
                BlockComputer();
            else
                Process.Start("Shutdown", shutdown);
        }

        private void BlockComputer()
        {
            var arquiveName = "Rundll32.exe";
            var arguments = "User32.dll, LockWorkStation";
            ProcessStartInfo startInfo = new ProcessStartInfo(arquiveName, arguments);
            Process.Start(startInfo);
        }
        #endregion

        #region Iniciar e parar alarme
        private void AlarmStart()
        {
            _timer.Start();
            lbStatus.Text = _start;
        }

        private void AlarmStop()
        {
            if (metroToggleOnOff.Checked || chkShutdownComputer.Checked)
                return;

            _timer.Stop();
            lbStatus.Text = _stop;
        }
        #endregion

        private void StartMusic()
        {
            _player = new WindowsMediaPlayer();
            _player.URL = _settings.MusicPath;
            _player.settings.setMode("Loop", true);
            _player.controls.play();
        }

        #region Mensagens de aviso
        private void MessageError(string message)
        {
            MetroFramework.MetroMessageBox.Show(this, message, "Mensagem do Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MessageSuccess(string message)
        {
            MetroFramework.MetroMessageBox.Show(this, message, "Mensagem do Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private DialogResult MessageQuestion(string message)
        {
            return MetroFramework.MetroMessageBox.Show(this, message, "Mensagem do Sistema",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        #endregion

        #region Eventos de alteração de estado de checkbox e toggle
        private void metroToggleOnOff_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (metroToggleOnOff.Checked)
                    AlarmStart();
                else
                {
                    AlarmStop();

                    if (_player != null)
                        _player.controls.stop();
                }
            }
            catch (Exception ex)
            {
                MessageError(ex.Message);
            }
        }

        private void chkShutdownComputer_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkShutdownComputer.Checked)
                    AlarmStart();
                else
                    AlarmStop();
            }
            catch (Exception ex)
            {
                MessageError(ex.Message);
            }
        }
        #endregion

        #region Escolher música e setar padrão
        private void ChooseMuisc()
        {
            var _openFile = new OpenFileDialog();

            DialogResult result = _openFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                var path = _openFile.FileName;
                var extension = Path.GetExtension(path);

                if (!_settings.Extensions.Contains(extension))
                    MessageError($"Extensão {extension} não é suportada");
                else
                {
                    _settings.SaveMusicPath(path);
                    MessageSuccess("Novo som de alarme definido");
                }
            }
        }

        private void SetDefaultMusic()
        {
            _settings.SetDefaultMusicPath();
            MessageSuccess("Música padrão definida");
        }
        #endregion

        #region Métodos para alterar temas
        private void SetLightTheme()
        {
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            chkShutdownComputer.Theme = MetroFramework.MetroThemeStyle.Light;
            lbDate.Theme = MetroFramework.MetroThemeStyle.Light;
            lbDay.Theme = MetroFramework.MetroThemeStyle.Light;
            lbTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lbSegunds.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;

            _settings.SaveTheme(ThemeEnum.Light);
            this.Refresh();
        }

        private void SetDarkTheme()
        {
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Dark;
            chkShutdownComputer.Theme = MetroFramework.MetroThemeStyle.Dark;
            lbDate.Theme = MetroFramework.MetroThemeStyle.Dark;
            lbDay.Theme = MetroFramework.MetroThemeStyle.Dark;
            lbTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            lbSegunds.ForeColor = System.Drawing.SystemColors.ButtonFace;

            _settings.SaveTheme(ThemeEnum.Dark);
            this.Refresh();
        }

        private void SetTheme(ThemeEnum theme)
        {
            if (theme == ThemeEnum.Light)
                SetLightTheme();
            else
                SetDarkTheme();
        }
        #endregion

        #region ContextMenuForm
        private void menuItemLight_Click(object sender, EventArgs e)
        {
            try
            {
                SetLightTheme();
            }
            catch (Exception ex)
            {
                MessageError(ex.Message);
            }
        }

        private void toolStripMenuItemDark_Click(object sender, EventArgs e)
        {
            try
            {
                SetDarkTheme();
            }
            catch (Exception ex)
            {
                MessageError(ex.Message);
            }
        }

        private void menuItemSelectSom_Click(object sender, EventArgs e)
        {
            try
            {
                ChooseMuisc();
            }
            catch (Exception ex)
            {
                MessageError(ex.Message);
            }
        }

        private void menuItemDefaultSom_Click(object sender, EventArgs e)
        {
            try
            {
                SetDefaultMusic();
            }
            catch (Exception ex)
            {
                MessageError(ex.Message);
            }
        }

        private void menuItemFormBlock_Click(object sender, EventArgs e)
        {
            try
            {
                ShutDownComputer(ShutdownOptionsEnum.Block);
            }
            catch (Exception ex)
            {
                MessageError(ex.Message);
            }
        }

        private void menuItemFormLogOut_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageQuestion("Deseja realmente trocar de usuário?") == DialogResult.Yes)
                    ShutDownComputer(ShutdownOptionsEnum.LogOut);
            }
            catch (Exception ex)
            {
                MessageError(ex.Message);
            }
        }

        private void menuItemFormRestart_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageQuestion("Deseja realmente reiniciar o computador?") == DialogResult.Yes)
                    ShutDownComputer(ShutdownOptionsEnum.Restart);
            }
            catch (Exception ex)
            {
                MessageError(ex.Message);
            }
        }

        private void menuItemFormTurnOff_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageQuestion("Deseja realmente desligar o computador?") == DialogResult.Yes)
                    ShutDownComputer(ShutdownOptionsEnum.TurnOff);
            }
            catch (Exception ex)
            {
                MessageError(ex.Message);
            }
        }

        private void menuItemFormCancel_Click(object sender, EventArgs e)
        {
            try
            {
                ShutDownComputer(ShutdownOptionsEnum.Cancel);
            }
            catch (Exception ex)
            {
                MessageError(ex.Message);
            }
        }
        #endregion

        #region ContextMenuNotify
        private void menuItemMaximize_Click(object sender, EventArgs e)
        {
            try
            {
                MaximizeForm();
            }
            catch (Exception ex)
            {
                MessageError(ex.Message);
            }
        }

        private void menuItemStart_Click(object sender, EventArgs e)
        {
            try
            {
                metroToggleOnOff.Checked = true;
                AlarmStart();
            }
            catch (Exception ex)
            {
                MessageError(ex.Message);
            }
        }

        private void menuItemStop_Click(object sender, EventArgs e)
        {
            try
            {
                metroToggleOnOff.Checked = false;
                AlarmStop();
            }
            catch (Exception ex)
            {
                MessageError(ex.Message);
            }
        }

        private void menuItemSelectMusic_Click(object sender, EventArgs e)
        {
            try
            {
                ChooseMuisc();
            }
            catch (Exception ex)
            {
                MessageError(ex.Message);
            }
        }

        private void menuItemDefaultMusic_Click(object sender, EventArgs e)
        {
            try
            {
                SetDefaultMusic();
            }
            catch (Exception ex)
            {
                MessageError(ex.Message);
            }
        }

        private void menuItemNotifyBlock_Click(object sender, EventArgs e)
        {
            try
            {
                ShutDownComputer(ShutdownOptionsEnum.Block);
            }
            catch (Exception ex)
            {
                MessageError(ex.Message);
            }
        }

        private void menuItemNotifyLogOff_Click(object sender, EventArgs e)
        {
            try
            {
                MaximizeForm();

                if (MessageQuestion("Deseja realmente trocar de usuário?") == DialogResult.Yes)
                    ShutDownComputer(ShutdownOptionsEnum.LogOut);
            }
            catch (Exception ex)
            {
                MessageError(ex.Message);
            }
        }

        private void menuItemNotifyRestart_Click(object sender, EventArgs e)
        {
            try
            {
                MaximizeForm();

                if (MessageQuestion("Deseja realmente reiniciar o computador?") == DialogResult.Yes)
                    ShutDownComputer(ShutdownOptionsEnum.Restart);
            }
            catch (Exception ex)
            {
                MessageError(ex.Message);
            }
        }

        private void menuItemNotifyTurnOff_Click(object sender, EventArgs e)
        {
            try
            {
                MaximizeForm();

                if (MessageQuestion("Deseja realmente desligar o computador?") == DialogResult.Yes)
                    ShutDownComputer(ShutdownOptionsEnum.TurnOff);
            }
            catch (Exception ex)
            {
                MessageError(ex.Message);
            }
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            try
            {
                _close = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageError(ex.Message);
            }
        }

        private void menuItemNotifyCancel_Click(object sender, EventArgs e)
        {
            try
            {
                ShutDownComputer(ShutdownOptionsEnum.Cancel);
            }
            catch (Exception ex)
            {
                MessageError(ex.Message);
            }
        }
        #endregion
    }
}
