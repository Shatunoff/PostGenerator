namespace PostGenerator
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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.btnConfigSaveSettings = new System.Windows.Forms.Button();
            this.gbConfigSettings = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpSettingsVk = new System.Windows.Forms.TabPage();
            this.SchedulerSettingsForVK = new PostGenerator.ShedulerSettingsControl();
            this.gbSetVkAccountDetail = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSetVkGroupUrl = new System.Windows.Forms.TextBox();
            this.tbSetVkAccessToken = new System.Windows.Forms.TextBox();
            this.tbSetVkUserId = new System.Windows.Forms.TextBox();
            this.tbSetVkAppId = new System.Windows.Forms.TextBox();
            this.tpSettingsTelegram = new System.Windows.Forms.TabPage();
            this.gbConfigManageProject = new System.Windows.Forms.GroupBox();
            this.btnConfigSaveProject = new System.Windows.Forms.Button();
            this.btnConfigInitProject = new System.Windows.Forms.Button();
            this.btnConfigOpenProject = new System.Windows.Forms.Button();
            this.tbConfigProjectPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpCalendar = new System.Windows.Forms.TabPage();
            this.tpSheduler = new System.Windows.Forms.TabPage();
            this.tpImageBase = new System.Windows.Forms.TabPage();
            this.tpTextBase = new System.Windows.Forms.TabPage();
            this.gbImageBasePreview = new System.Windows.Forms.GroupBox();
            this.gbImageBase = new System.Windows.Forms.GroupBox();
            this.pbImageBasePreview = new System.Windows.Forms.PictureBox();
            this.btnImageBaseOpenOriginal = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbImageBaseCurrentFileName = new System.Windows.Forms.TextBox();
            this.btnImageBaseOpenInConductor = new System.Windows.Forms.Button();
            this.btnImageBaseCheckBaseWithFiles = new System.Windows.Forms.Button();
            this.dgvImageBase = new System.Windows.Forms.DataGridView();
            this.btnImageBaseSave = new System.Windows.Forms.Button();
            this.gbTextBaseManage = new System.Windows.Forms.GroupBox();
            this.gbTextBaseClearing = new System.Windows.Forms.GroupBox();
            this.btnTextBaseSave = new System.Windows.Forms.Button();
            this.btnTextBaseImportFromFile = new System.Windows.Forms.Button();
            this.btnTextBaseRemoveSelect = new System.Windows.Forms.Button();
            this.btnTextBaseAdd = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTextBaseRemoveDuplicate = new System.Windows.Forms.Button();
            this.btnTextBaseRemoveDuplicateWithoutSmiles = new System.Windows.Forms.Button();
            this.gbTextBase = new System.Windows.Forms.GroupBox();
            this.dgvTextBase = new System.Windows.Forms.DataGridView();
            this.gbCalendar = new System.Windows.Forms.GroupBox();
            this.btnCalendarPreviousDay = new System.Windows.Forms.Button();
            this.btnCalendarNextDay = new System.Windows.Forms.Button();
            this.dtpCalendarSelectedDay = new System.Windows.Forms.DateTimePicker();
            this.cbCalendarSelectedNetwork = new System.Windows.Forms.ComboBox();
            this.dgvCalendar = new System.Windows.Forms.DataGridView();
            this.gbShedulerGenerator = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbShedulerGeneratedText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pbShedulerGeneratedPicture = new System.Windows.Forms.PictureBox();
            this.btnShedulerGeneratePost = new System.Windows.Forms.Button();
            this.cbShedulerSelectedNetwork = new System.Windows.Forms.ComboBox();
            this.dtpShedulerGeneratedPostPubDate = new System.Windows.Forms.DateTimePicker();
            this.btnShedulerAddGeneratedPostInQueue = new System.Windows.Forms.Button();
            this.checkShedulerAutoSelectPostTime = new System.Windows.Forms.CheckBox();
            this.gbShedulerQueue = new System.Windows.Forms.GroupBox();
            this.dgvScheduler = new System.Windows.Forms.DataGridView();
            this.btnSchedulerRemoveFromQueue = new System.Windows.Forms.Button();
            this.btnShedulerToShedulePosts = new System.Windows.Forms.Button();
            this.tcMain.SuspendLayout();
            this.tpSettings.SuspendLayout();
            this.gbConfigSettings.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpSettingsVk.SuspendLayout();
            this.gbSetVkAccountDetail.SuspendLayout();
            this.gbConfigManageProject.SuspendLayout();
            this.tpCalendar.SuspendLayout();
            this.tpSheduler.SuspendLayout();
            this.tpImageBase.SuspendLayout();
            this.tpTextBase.SuspendLayout();
            this.gbImageBasePreview.SuspendLayout();
            this.gbImageBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageBasePreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImageBase)).BeginInit();
            this.gbTextBaseManage.SuspendLayout();
            this.gbTextBaseClearing.SuspendLayout();
            this.gbTextBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTextBase)).BeginInit();
            this.gbCalendar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalendar)).BeginInit();
            this.gbShedulerGenerator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbShedulerGeneratedPicture)).BeginInit();
            this.gbShedulerQueue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduler)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpSettings);
            this.tcMain.Controls.Add(this.tpCalendar);
            this.tcMain.Controls.Add(this.tpSheduler);
            this.tcMain.Controls.Add(this.tpImageBase);
            this.tcMain.Controls.Add(this.tpTextBase);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(774, 481);
            this.tcMain.TabIndex = 0;
            // 
            // tpSettings
            // 
            this.tpSettings.Controls.Add(this.btnConfigSaveSettings);
            this.tpSettings.Controls.Add(this.gbConfigSettings);
            this.tpSettings.Controls.Add(this.gbConfigManageProject);
            this.tpSettings.Location = new System.Drawing.Point(4, 22);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettings.Size = new System.Drawing.Size(766, 455);
            this.tpSettings.TabIndex = 0;
            this.tpSettings.Text = "Конфигурация проекта";
            this.tpSettings.UseVisualStyleBackColor = true;
            // 
            // btnConfigSaveSettings
            // 
            this.btnConfigSaveSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfigSaveSettings.Location = new System.Drawing.Point(610, 426);
            this.btnConfigSaveSettings.Name = "btnConfigSaveSettings";
            this.btnConfigSaveSettings.Size = new System.Drawing.Size(150, 23);
            this.btnConfigSaveSettings.TabIndex = 3;
            this.btnConfigSaveSettings.Text = "Сохранить настройки";
            this.btnConfigSaveSettings.UseVisualStyleBackColor = true;
            // 
            // gbConfigSettings
            // 
            this.gbConfigSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbConfigSettings.Controls.Add(this.tabControl1);
            this.gbConfigSettings.Location = new System.Drawing.Point(6, 92);
            this.gbConfigSettings.Name = "gbConfigSettings";
            this.gbConfigSettings.Size = new System.Drawing.Size(754, 328);
            this.gbConfigSettings.TabIndex = 2;
            this.gbConfigSettings.TabStop = false;
            this.gbConfigSettings.Text = "Параметры для социальных сетей";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpSettingsVk);
            this.tabControl1.Controls.Add(this.tpSettingsTelegram);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(748, 309);
            this.tabControl1.TabIndex = 0;
            // 
            // tpSettingsVk
            // 
            this.tpSettingsVk.Controls.Add(this.SchedulerSettingsForVK);
            this.tpSettingsVk.Controls.Add(this.gbSetVkAccountDetail);
            this.tpSettingsVk.Location = new System.Drawing.Point(4, 22);
            this.tpSettingsVk.Name = "tpSettingsVk";
            this.tpSettingsVk.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettingsVk.Size = new System.Drawing.Size(740, 283);
            this.tpSettingsVk.TabIndex = 0;
            this.tpSettingsVk.Text = "ВКонтакте";
            this.tpSettingsVk.UseVisualStyleBackColor = true;
            // 
            // SchedulerSettingsForVK
            // 
            this.SchedulerSettingsForVK.ImageTimeout = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SchedulerSettingsForVK.IntervalBetweenPosts = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SchedulerSettingsForVK.Location = new System.Drawing.Point(465, 6);
            this.SchedulerSettingsForVK.Name = "SchedulerSettingsForVK";
            this.SchedulerSettingsForVK.PubHoursRangeFrom = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SchedulerSettingsForVK.PubHoursRangeTo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SchedulerSettingsForVK.Size = new System.Drawing.Size(269, 155);
            this.SchedulerSettingsForVK.TabIndex = 1;
            this.SchedulerSettingsForVK.TabStop = false;
            this.SchedulerSettingsForVK.TextTimeout = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // gbSetVkAccountDetail
            // 
            this.gbSetVkAccountDetail.Controls.Add(this.label5);
            this.gbSetVkAccountDetail.Controls.Add(this.label4);
            this.gbSetVkAccountDetail.Controls.Add(this.label3);
            this.gbSetVkAccountDetail.Controls.Add(this.label2);
            this.gbSetVkAccountDetail.Controls.Add(this.tbSetVkGroupUrl);
            this.gbSetVkAccountDetail.Controls.Add(this.tbSetVkAccessToken);
            this.gbSetVkAccountDetail.Controls.Add(this.tbSetVkUserId);
            this.gbSetVkAccountDetail.Controls.Add(this.tbSetVkAppId);
            this.gbSetVkAccountDetail.Location = new System.Drawing.Point(6, 6);
            this.gbSetVkAccountDetail.Name = "gbSetVkAccountDetail";
            this.gbSetVkAccountDetail.Size = new System.Drawing.Size(453, 155);
            this.gbSetVkAccountDetail.TabIndex = 0;
            this.gbSetVkAccountDetail.TabStop = false;
            this.gbSetVkAccountDetail.Text = "Учетные данные";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ссылка на группу:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Токен доступа:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "userId:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ApplicationId:";
            // 
            // tbSetVkGroupUrl
            // 
            this.tbSetVkGroupUrl.Location = new System.Drawing.Point(117, 95);
            this.tbSetVkGroupUrl.Name = "tbSetVkGroupUrl";
            this.tbSetVkGroupUrl.Size = new System.Drawing.Size(330, 20);
            this.tbSetVkGroupUrl.TabIndex = 3;
            // 
            // tbSetVkAccessToken
            // 
            this.tbSetVkAccessToken.Location = new System.Drawing.Point(117, 70);
            this.tbSetVkAccessToken.Name = "tbSetVkAccessToken";
            this.tbSetVkAccessToken.Size = new System.Drawing.Size(330, 20);
            this.tbSetVkAccessToken.TabIndex = 2;
            // 
            // tbSetVkUserId
            // 
            this.tbSetVkUserId.Location = new System.Drawing.Point(117, 44);
            this.tbSetVkUserId.Name = "tbSetVkUserId";
            this.tbSetVkUserId.Size = new System.Drawing.Size(330, 20);
            this.tbSetVkUserId.TabIndex = 1;
            // 
            // tbSetVkAppId
            // 
            this.tbSetVkAppId.Location = new System.Drawing.Point(117, 19);
            this.tbSetVkAppId.Name = "tbSetVkAppId";
            this.tbSetVkAppId.Size = new System.Drawing.Size(330, 20);
            this.tbSetVkAppId.TabIndex = 0;
            // 
            // tpSettingsTelegram
            // 
            this.tpSettingsTelegram.Location = new System.Drawing.Point(4, 22);
            this.tpSettingsTelegram.Name = "tpSettingsTelegram";
            this.tpSettingsTelegram.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettingsTelegram.Size = new System.Drawing.Size(740, 169);
            this.tpSettingsTelegram.TabIndex = 1;
            this.tpSettingsTelegram.Text = "Telegram";
            this.tpSettingsTelegram.UseVisualStyleBackColor = true;
            // 
            // gbConfigManageProject
            // 
            this.gbConfigManageProject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbConfigManageProject.Controls.Add(this.btnConfigSaveProject);
            this.gbConfigManageProject.Controls.Add(this.btnConfigInitProject);
            this.gbConfigManageProject.Controls.Add(this.btnConfigOpenProject);
            this.gbConfigManageProject.Controls.Add(this.tbConfigProjectPath);
            this.gbConfigManageProject.Controls.Add(this.label1);
            this.gbConfigManageProject.Location = new System.Drawing.Point(6, 6);
            this.gbConfigManageProject.Name = "gbConfigManageProject";
            this.gbConfigManageProject.Size = new System.Drawing.Size(754, 80);
            this.gbConfigManageProject.TabIndex = 0;
            this.gbConfigManageProject.TabStop = false;
            this.gbConfigManageProject.Text = "Управление проектом";
            // 
            // btnConfigSaveProject
            // 
            this.btnConfigSaveProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfigSaveProject.Location = new System.Drawing.Point(338, 45);
            this.btnConfigSaveProject.Name = "btnConfigSaveProject";
            this.btnConfigSaveProject.Size = new System.Drawing.Size(200, 23);
            this.btnConfigSaveProject.TabIndex = 4;
            this.btnConfigSaveProject.Text = "Сохранить текущий проект";
            this.btnConfigSaveProject.UseVisualStyleBackColor = true;
            // 
            // btnConfigInitProject
            // 
            this.btnConfigInitProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfigInitProject.Location = new System.Drawing.Point(544, 45);
            this.btnConfigInitProject.Name = "btnConfigInitProject";
            this.btnConfigInitProject.Size = new System.Drawing.Size(200, 23);
            this.btnConfigInitProject.TabIndex = 3;
            this.btnConfigInitProject.Text = "Инициализировать новый проект";
            this.btnConfigInitProject.UseVisualStyleBackColor = true;
            // 
            // btnConfigOpenProject
            // 
            this.btnConfigOpenProject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfigOpenProject.Location = new System.Drawing.Point(132, 45);
            this.btnConfigOpenProject.Name = "btnConfigOpenProject";
            this.btnConfigOpenProject.Size = new System.Drawing.Size(200, 23);
            this.btnConfigOpenProject.TabIndex = 2;
            this.btnConfigOpenProject.Text = "Открыть существующий проект";
            this.btnConfigOpenProject.UseVisualStyleBackColor = true;
            // 
            // tbConfigProjectPath
            // 
            this.tbConfigProjectPath.Location = new System.Drawing.Point(132, 19);
            this.tbConfigProjectPath.Name = "tbConfigProjectPath";
            this.tbConfigProjectPath.Size = new System.Drawing.Size(612, 20);
            this.tbConfigProjectPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Путь к папке проекта:";
            // 
            // tpCalendar
            // 
            this.tpCalendar.Controls.Add(this.gbCalendar);
            this.tpCalendar.Location = new System.Drawing.Point(4, 22);
            this.tpCalendar.Name = "tpCalendar";
            this.tpCalendar.Size = new System.Drawing.Size(766, 455);
            this.tpCalendar.TabIndex = 3;
            this.tpCalendar.Text = "Календарь публикаций";
            this.tpCalendar.UseVisualStyleBackColor = true;
            // 
            // tpSheduler
            // 
            this.tpSheduler.Controls.Add(this.gbShedulerQueue);
            this.tpSheduler.Controls.Add(this.gbShedulerGenerator);
            this.tpSheduler.Location = new System.Drawing.Point(4, 22);
            this.tpSheduler.Name = "tpSheduler";
            this.tpSheduler.Size = new System.Drawing.Size(766, 455);
            this.tpSheduler.TabIndex = 4;
            this.tpSheduler.Text = "Планирование публикаций";
            this.tpSheduler.UseVisualStyleBackColor = true;
            // 
            // tpImageBase
            // 
            this.tpImageBase.Controls.Add(this.gbImageBase);
            this.tpImageBase.Controls.Add(this.gbImageBasePreview);
            this.tpImageBase.Location = new System.Drawing.Point(4, 22);
            this.tpImageBase.Name = "tpImageBase";
            this.tpImageBase.Padding = new System.Windows.Forms.Padding(3);
            this.tpImageBase.Size = new System.Drawing.Size(766, 455);
            this.tpImageBase.TabIndex = 1;
            this.tpImageBase.Text = "Каталог изображений";
            this.tpImageBase.UseVisualStyleBackColor = true;
            // 
            // tpTextBase
            // 
            this.tpTextBase.Controls.Add(this.gbTextBase);
            this.tpTextBase.Controls.Add(this.gbTextBaseClearing);
            this.tpTextBase.Controls.Add(this.gbTextBaseManage);
            this.tpTextBase.Location = new System.Drawing.Point(4, 22);
            this.tpTextBase.Name = "tpTextBase";
            this.tpTextBase.Size = new System.Drawing.Size(766, 455);
            this.tpTextBase.TabIndex = 2;
            this.tpTextBase.Text = "Каталог текстов";
            this.tpTextBase.UseVisualStyleBackColor = true;
            // 
            // gbImageBasePreview
            // 
            this.gbImageBasePreview.Controls.Add(this.btnImageBaseOpenInConductor);
            this.gbImageBasePreview.Controls.Add(this.tbImageBaseCurrentFileName);
            this.gbImageBasePreview.Controls.Add(this.label6);
            this.gbImageBasePreview.Controls.Add(this.btnImageBaseOpenOriginal);
            this.gbImageBasePreview.Controls.Add(this.pbImageBasePreview);
            this.gbImageBasePreview.Location = new System.Drawing.Point(6, 6);
            this.gbImageBasePreview.Name = "gbImageBasePreview";
            this.gbImageBasePreview.Size = new System.Drawing.Size(374, 443);
            this.gbImageBasePreview.TabIndex = 0;
            this.gbImageBasePreview.TabStop = false;
            this.gbImageBasePreview.Text = "Предварительный просмотр";
            // 
            // gbImageBase
            // 
            this.gbImageBase.Controls.Add(this.btnImageBaseSave);
            this.gbImageBase.Controls.Add(this.dgvImageBase);
            this.gbImageBase.Controls.Add(this.btnImageBaseCheckBaseWithFiles);
            this.gbImageBase.Location = new System.Drawing.Point(386, 6);
            this.gbImageBase.Name = "gbImageBase";
            this.gbImageBase.Size = new System.Drawing.Size(374, 443);
            this.gbImageBase.TabIndex = 1;
            this.gbImageBase.TabStop = false;
            this.gbImageBase.Text = "База изображений";
            // 
            // pbImageBasePreview
            // 
            this.pbImageBasePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImageBasePreview.Location = new System.Drawing.Point(6, 19);
            this.pbImageBasePreview.Name = "pbImageBasePreview";
            this.pbImageBasePreview.Size = new System.Drawing.Size(362, 363);
            this.pbImageBasePreview.TabIndex = 0;
            this.pbImageBasePreview.TabStop = false;
            // 
            // btnImageBaseOpenOriginal
            // 
            this.btnImageBaseOpenOriginal.Location = new System.Drawing.Point(226, 414);
            this.btnImageBaseOpenOriginal.Name = "btnImageBaseOpenOriginal";
            this.btnImageBaseOpenOriginal.Size = new System.Drawing.Size(142, 23);
            this.btnImageBaseOpenOriginal.TabIndex = 1;
            this.btnImageBaseOpenOriginal.Text = "Открыть оригинал";
            this.btnImageBaseOpenOriginal.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Имя файла:";
            // 
            // tbImageBaseCurrentFileName
            // 
            this.tbImageBaseCurrentFileName.Location = new System.Drawing.Point(79, 388);
            this.tbImageBaseCurrentFileName.Name = "tbImageBaseCurrentFileName";
            this.tbImageBaseCurrentFileName.Size = new System.Drawing.Size(289, 20);
            this.tbImageBaseCurrentFileName.TabIndex = 3;
            // 
            // btnImageBaseOpenInConductor
            // 
            this.btnImageBaseOpenInConductor.Location = new System.Drawing.Point(79, 414);
            this.btnImageBaseOpenInConductor.Name = "btnImageBaseOpenInConductor";
            this.btnImageBaseOpenInConductor.Size = new System.Drawing.Size(141, 23);
            this.btnImageBaseOpenInConductor.TabIndex = 4;
            this.btnImageBaseOpenInConductor.Text = "Открыть в проводнике";
            this.btnImageBaseOpenInConductor.UseVisualStyleBackColor = true;
            // 
            // btnImageBaseCheckBaseWithFiles
            // 
            this.btnImageBaseCheckBaseWithFiles.Location = new System.Drawing.Point(6, 19);
            this.btnImageBaseCheckBaseWithFiles.Name = "btnImageBaseCheckBaseWithFiles";
            this.btnImageBaseCheckBaseWithFiles.Size = new System.Drawing.Size(178, 23);
            this.btnImageBaseCheckBaseWithFiles.TabIndex = 0;
            this.btnImageBaseCheckBaseWithFiles.Text = "Сверить базу с файлами";
            this.btnImageBaseCheckBaseWithFiles.UseVisualStyleBackColor = true;
            // 
            // dgvImageBase
            // 
            this.dgvImageBase.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvImageBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImageBase.Location = new System.Drawing.Point(6, 48);
            this.dgvImageBase.Name = "dgvImageBase";
            this.dgvImageBase.Size = new System.Drawing.Size(362, 389);
            this.dgvImageBase.TabIndex = 1;
            // 
            // btnImageBaseSave
            // 
            this.btnImageBaseSave.Location = new System.Drawing.Point(190, 19);
            this.btnImageBaseSave.Name = "btnImageBaseSave";
            this.btnImageBaseSave.Size = new System.Drawing.Size(178, 23);
            this.btnImageBaseSave.TabIndex = 2;
            this.btnImageBaseSave.Text = "Сохранить базу";
            this.btnImageBaseSave.UseVisualStyleBackColor = true;
            // 
            // gbTextBaseManage
            // 
            this.gbTextBaseManage.Controls.Add(this.textBox1);
            this.gbTextBaseManage.Controls.Add(this.btnTextBaseAdd);
            this.gbTextBaseManage.Controls.Add(this.btnTextBaseRemoveSelect);
            this.gbTextBaseManage.Controls.Add(this.btnTextBaseImportFromFile);
            this.gbTextBaseManage.Controls.Add(this.btnTextBaseSave);
            this.gbTextBaseManage.Location = new System.Drawing.Point(6, 6);
            this.gbTextBaseManage.Name = "gbTextBaseManage";
            this.gbTextBaseManage.Size = new System.Drawing.Size(414, 81);
            this.gbTextBaseManage.TabIndex = 0;
            this.gbTextBaseManage.TabStop = false;
            this.gbTextBaseManage.Text = "Управление";
            // 
            // gbTextBaseClearing
            // 
            this.gbTextBaseClearing.Controls.Add(this.btnTextBaseRemoveDuplicateWithoutSmiles);
            this.gbTextBaseClearing.Controls.Add(this.btnTextBaseRemoveDuplicate);
            this.gbTextBaseClearing.Location = new System.Drawing.Point(426, 6);
            this.gbTextBaseClearing.Name = "gbTextBaseClearing";
            this.gbTextBaseClearing.Size = new System.Drawing.Size(334, 81);
            this.gbTextBaseClearing.TabIndex = 1;
            this.gbTextBaseClearing.TabStop = false;
            this.gbTextBaseClearing.Text = "Очистка базы";
            // 
            // btnTextBaseSave
            // 
            this.btnTextBaseSave.Location = new System.Drawing.Point(6, 19);
            this.btnTextBaseSave.Name = "btnTextBaseSave";
            this.btnTextBaseSave.Size = new System.Drawing.Size(198, 23);
            this.btnTextBaseSave.TabIndex = 0;
            this.btnTextBaseSave.Text = "Сохранить базу";
            this.btnTextBaseSave.UseVisualStyleBackColor = true;
            // 
            // btnTextBaseImportFromFile
            // 
            this.btnTextBaseImportFromFile.Location = new System.Drawing.Point(210, 19);
            this.btnTextBaseImportFromFile.Name = "btnTextBaseImportFromFile";
            this.btnTextBaseImportFromFile.Size = new System.Drawing.Size(198, 23);
            this.btnTextBaseImportFromFile.TabIndex = 1;
            this.btnTextBaseImportFromFile.Text = "Добавить из файла";
            this.btnTextBaseImportFromFile.UseVisualStyleBackColor = true;
            // 
            // btnTextBaseRemoveSelect
            // 
            this.btnTextBaseRemoveSelect.Location = new System.Drawing.Point(333, 48);
            this.btnTextBaseRemoveSelect.Name = "btnTextBaseRemoveSelect";
            this.btnTextBaseRemoveSelect.Size = new System.Drawing.Size(75, 23);
            this.btnTextBaseRemoveSelect.TabIndex = 2;
            this.btnTextBaseRemoveSelect.Text = "Удалить";
            this.btnTextBaseRemoveSelect.UseVisualStyleBackColor = true;
            // 
            // btnTextBaseAdd
            // 
            this.btnTextBaseAdd.Location = new System.Drawing.Point(252, 48);
            this.btnTextBaseAdd.Name = "btnTextBaseAdd";
            this.btnTextBaseAdd.Size = new System.Drawing.Size(75, 23);
            this.btnTextBaseAdd.TabIndex = 3;
            this.btnTextBaseAdd.Text = "Добавить";
            this.btnTextBaseAdd.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 20);
            this.textBox1.TabIndex = 4;
            // 
            // btnTextBaseRemoveDuplicate
            // 
            this.btnTextBaseRemoveDuplicate.Location = new System.Drawing.Point(6, 19);
            this.btnTextBaseRemoveDuplicate.Name = "btnTextBaseRemoveDuplicate";
            this.btnTextBaseRemoveDuplicate.Size = new System.Drawing.Size(322, 23);
            this.btnTextBaseRemoveDuplicate.TabIndex = 2;
            this.btnTextBaseRemoveDuplicate.Text = "Удалить дубликаты (полное совпадение)";
            this.btnTextBaseRemoveDuplicate.UseVisualStyleBackColor = true;
            // 
            // btnTextBaseRemoveDuplicateWithoutSmiles
            // 
            this.btnTextBaseRemoveDuplicateWithoutSmiles.Location = new System.Drawing.Point(6, 48);
            this.btnTextBaseRemoveDuplicateWithoutSmiles.Name = "btnTextBaseRemoveDuplicateWithoutSmiles";
            this.btnTextBaseRemoveDuplicateWithoutSmiles.Size = new System.Drawing.Size(322, 23);
            this.btnTextBaseRemoveDuplicateWithoutSmiles.TabIndex = 3;
            this.btnTextBaseRemoveDuplicateWithoutSmiles.Text = "Удалить дубликаты (без учета смайлов)";
            this.btnTextBaseRemoveDuplicateWithoutSmiles.UseVisualStyleBackColor = true;
            // 
            // gbTextBase
            // 
            this.gbTextBase.Controls.Add(this.dgvTextBase);
            this.gbTextBase.Location = new System.Drawing.Point(6, 93);
            this.gbTextBase.Name = "gbTextBase";
            this.gbTextBase.Size = new System.Drawing.Size(754, 354);
            this.gbTextBase.TabIndex = 2;
            this.gbTextBase.TabStop = false;
            this.gbTextBase.Text = "База текстов";
            // 
            // dgvTextBase
            // 
            this.dgvTextBase.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTextBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTextBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTextBase.Location = new System.Drawing.Point(3, 16);
            this.dgvTextBase.Name = "dgvTextBase";
            this.dgvTextBase.Size = new System.Drawing.Size(748, 335);
            this.dgvTextBase.TabIndex = 0;
            // 
            // gbCalendar
            // 
            this.gbCalendar.Controls.Add(this.dgvCalendar);
            this.gbCalendar.Controls.Add(this.cbCalendarSelectedNetwork);
            this.gbCalendar.Controls.Add(this.dtpCalendarSelectedDay);
            this.gbCalendar.Controls.Add(this.btnCalendarNextDay);
            this.gbCalendar.Controls.Add(this.btnCalendarPreviousDay);
            this.gbCalendar.Location = new System.Drawing.Point(6, 6);
            this.gbCalendar.Name = "gbCalendar";
            this.gbCalendar.Size = new System.Drawing.Size(753, 441);
            this.gbCalendar.TabIndex = 0;
            this.gbCalendar.TabStop = false;
            this.gbCalendar.Text = "Календарь публикаций";
            // 
            // btnCalendarPreviousDay
            // 
            this.btnCalendarPreviousDay.Location = new System.Drawing.Point(6, 19);
            this.btnCalendarPreviousDay.Name = "btnCalendarPreviousDay";
            this.btnCalendarPreviousDay.Size = new System.Drawing.Size(200, 23);
            this.btnCalendarPreviousDay.TabIndex = 0;
            this.btnCalendarPreviousDay.Text = "Предыдущий день";
            this.btnCalendarPreviousDay.UseVisualStyleBackColor = true;
            // 
            // btnCalendarNextDay
            // 
            this.btnCalendarNextDay.Location = new System.Drawing.Point(368, 19);
            this.btnCalendarNextDay.Name = "btnCalendarNextDay";
            this.btnCalendarNextDay.Size = new System.Drawing.Size(200, 23);
            this.btnCalendarNextDay.TabIndex = 1;
            this.btnCalendarNextDay.Text = "Следующий день";
            this.btnCalendarNextDay.UseVisualStyleBackColor = true;
            // 
            // dtpCalendarSelectedDay
            // 
            this.dtpCalendarSelectedDay.Location = new System.Drawing.Point(212, 20);
            this.dtpCalendarSelectedDay.Name = "dtpCalendarSelectedDay";
            this.dtpCalendarSelectedDay.Size = new System.Drawing.Size(150, 20);
            this.dtpCalendarSelectedDay.TabIndex = 2;
            // 
            // cbCalendarSelectedNetwork
            // 
            this.cbCalendarSelectedNetwork.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCalendarSelectedNetwork.FormattingEnabled = true;
            this.cbCalendarSelectedNetwork.Location = new System.Drawing.Point(574, 20);
            this.cbCalendarSelectedNetwork.Name = "cbCalendarSelectedNetwork";
            this.cbCalendarSelectedNetwork.Size = new System.Drawing.Size(173, 21);
            this.cbCalendarSelectedNetwork.TabIndex = 3;
            // 
            // dgvCalendar
            // 
            this.dgvCalendar.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvCalendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalendar.Location = new System.Drawing.Point(6, 48);
            this.dgvCalendar.Name = "dgvCalendar";
            this.dgvCalendar.Size = new System.Drawing.Size(741, 387);
            this.dgvCalendar.TabIndex = 4;
            // 
            // gbShedulerGenerator
            // 
            this.gbShedulerGenerator.Controls.Add(this.checkShedulerAutoSelectPostTime);
            this.gbShedulerGenerator.Controls.Add(this.btnShedulerAddGeneratedPostInQueue);
            this.gbShedulerGenerator.Controls.Add(this.dtpShedulerGeneratedPostPubDate);
            this.gbShedulerGenerator.Controls.Add(this.cbShedulerSelectedNetwork);
            this.gbShedulerGenerator.Controls.Add(this.btnShedulerGeneratePost);
            this.gbShedulerGenerator.Controls.Add(this.pbShedulerGeneratedPicture);
            this.gbShedulerGenerator.Controls.Add(this.label8);
            this.gbShedulerGenerator.Controls.Add(this.tbShedulerGeneratedText);
            this.gbShedulerGenerator.Controls.Add(this.label7);
            this.gbShedulerGenerator.Location = new System.Drawing.Point(6, 6);
            this.gbShedulerGenerator.Name = "gbShedulerGenerator";
            this.gbShedulerGenerator.Size = new System.Drawing.Size(300, 441);
            this.gbShedulerGenerator.TabIndex = 0;
            this.gbShedulerGenerator.TabStop = false;
            this.gbShedulerGenerator.Text = "Формирование записи";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Текст записи:";
            // 
            // tbShedulerGeneratedText
            // 
            this.tbShedulerGeneratedText.Location = new System.Drawing.Point(6, 32);
            this.tbShedulerGeneratedText.Name = "tbShedulerGeneratedText";
            this.tbShedulerGeneratedText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbShedulerGeneratedText.Size = new System.Drawing.Size(288, 20);
            this.tbShedulerGeneratedText.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Изображение:";
            // 
            // pbShedulerGeneratedPicture
            // 
            this.pbShedulerGeneratedPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbShedulerGeneratedPicture.Location = new System.Drawing.Point(6, 71);
            this.pbShedulerGeneratedPicture.Name = "pbShedulerGeneratedPicture";
            this.pbShedulerGeneratedPicture.Size = new System.Drawing.Size(288, 283);
            this.pbShedulerGeneratedPicture.TabIndex = 3;
            this.pbShedulerGeneratedPicture.TabStop = false;
            // 
            // btnShedulerGeneratePost
            // 
            this.btnShedulerGeneratePost.Location = new System.Drawing.Point(6, 360);
            this.btnShedulerGeneratePost.Name = "btnShedulerGeneratePost";
            this.btnShedulerGeneratePost.Size = new System.Drawing.Size(180, 23);
            this.btnShedulerGeneratePost.TabIndex = 4;
            this.btnShedulerGeneratePost.Text = "Сформировать запись";
            this.btnShedulerGeneratePost.UseVisualStyleBackColor = true;
            // 
            // cbShedulerSelectedNetwork
            // 
            this.cbShedulerSelectedNetwork.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShedulerSelectedNetwork.FormattingEnabled = true;
            this.cbShedulerSelectedNetwork.Location = new System.Drawing.Point(192, 362);
            this.cbShedulerSelectedNetwork.Name = "cbShedulerSelectedNetwork";
            this.cbShedulerSelectedNetwork.Size = new System.Drawing.Size(102, 21);
            this.cbShedulerSelectedNetwork.TabIndex = 5;
            // 
            // dtpShedulerGeneratedPostPubDate
            // 
            this.dtpShedulerGeneratedPostPubDate.Location = new System.Drawing.Point(6, 392);
            this.dtpShedulerGeneratedPostPubDate.Name = "dtpShedulerGeneratedPostPubDate";
            this.dtpShedulerGeneratedPostPubDate.Size = new System.Drawing.Size(180, 20);
            this.dtpShedulerGeneratedPostPubDate.TabIndex = 6;
            // 
            // btnShedulerAddGeneratedPostInQueue
            // 
            this.btnShedulerAddGeneratedPostInQueue.Location = new System.Drawing.Point(192, 389);
            this.btnShedulerAddGeneratedPostInQueue.Name = "btnShedulerAddGeneratedPostInQueue";
            this.btnShedulerAddGeneratedPostInQueue.Size = new System.Drawing.Size(102, 23);
            this.btnShedulerAddGeneratedPostInQueue.TabIndex = 7;
            this.btnShedulerAddGeneratedPostInQueue.Text = "В очередь";
            this.btnShedulerAddGeneratedPostInQueue.UseVisualStyleBackColor = true;
            // 
            // checkShedulerAutoSelectPostTime
            // 
            this.checkShedulerAutoSelectPostTime.AutoSize = true;
            this.checkShedulerAutoSelectPostTime.Location = new System.Drawing.Point(6, 418);
            this.checkShedulerAutoSelectPostTime.Name = "checkShedulerAutoSelectPostTime";
            this.checkShedulerAutoSelectPostTime.Size = new System.Drawing.Size(201, 17);
            this.checkShedulerAutoSelectPostTime.TabIndex = 8;
            this.checkShedulerAutoSelectPostTime.Text = "Автоматически определить время";
            this.checkShedulerAutoSelectPostTime.UseVisualStyleBackColor = true;
            // 
            // gbShedulerQueue
            // 
            this.gbShedulerQueue.Controls.Add(this.btnShedulerToShedulePosts);
            this.gbShedulerQueue.Controls.Add(this.btnSchedulerRemoveFromQueue);
            this.gbShedulerQueue.Controls.Add(this.dgvScheduler);
            this.gbShedulerQueue.Location = new System.Drawing.Point(312, 6);
            this.gbShedulerQueue.Name = "gbShedulerQueue";
            this.gbShedulerQueue.Size = new System.Drawing.Size(448, 441);
            this.gbShedulerQueue.TabIndex = 1;
            this.gbShedulerQueue.TabStop = false;
            this.gbShedulerQueue.Text = "Очередь на публикацию";
            // 
            // dgvScheduler
            // 
            this.dgvScheduler.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvScheduler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScheduler.Location = new System.Drawing.Point(6, 19);
            this.dgvScheduler.Name = "dgvScheduler";
            this.dgvScheduler.Size = new System.Drawing.Size(436, 387);
            this.dgvScheduler.TabIndex = 0;
            // 
            // btnSchedulerRemoveFromQueue
            // 
            this.btnSchedulerRemoveFromQueue.Location = new System.Drawing.Point(367, 412);
            this.btnSchedulerRemoveFromQueue.Name = "btnSchedulerRemoveFromQueue";
            this.btnSchedulerRemoveFromQueue.Size = new System.Drawing.Size(75, 23);
            this.btnSchedulerRemoveFromQueue.TabIndex = 1;
            this.btnSchedulerRemoveFromQueue.Text = "Удалить";
            this.btnSchedulerRemoveFromQueue.UseVisualStyleBackColor = true;
            // 
            // btnShedulerToShedulePosts
            // 
            this.btnShedulerToShedulePosts.Location = new System.Drawing.Point(6, 412);
            this.btnShedulerToShedulePosts.Name = "btnShedulerToShedulePosts";
            this.btnShedulerToShedulePosts.Size = new System.Drawing.Size(200, 23);
            this.btnShedulerToShedulePosts.TabIndex = 2;
            this.btnShedulerToShedulePosts.Text = "Запланировать публикации";
            this.btnShedulerToShedulePosts.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 481);
            this.Controls.Add(this.tcMain);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Менеджер попсовых постов";
            this.tcMain.ResumeLayout(false);
            this.tpSettings.ResumeLayout(false);
            this.gbConfigSettings.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpSettingsVk.ResumeLayout(false);
            this.gbSetVkAccountDetail.ResumeLayout(false);
            this.gbSetVkAccountDetail.PerformLayout();
            this.gbConfigManageProject.ResumeLayout(false);
            this.gbConfigManageProject.PerformLayout();
            this.tpCalendar.ResumeLayout(false);
            this.tpSheduler.ResumeLayout(false);
            this.tpImageBase.ResumeLayout(false);
            this.tpTextBase.ResumeLayout(false);
            this.gbImageBasePreview.ResumeLayout(false);
            this.gbImageBasePreview.PerformLayout();
            this.gbImageBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImageBasePreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImageBase)).EndInit();
            this.gbTextBaseManage.ResumeLayout(false);
            this.gbTextBaseManage.PerformLayout();
            this.gbTextBaseClearing.ResumeLayout(false);
            this.gbTextBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTextBase)).EndInit();
            this.gbCalendar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalendar)).EndInit();
            this.gbShedulerGenerator.ResumeLayout(false);
            this.gbShedulerGenerator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbShedulerGeneratedPicture)).EndInit();
            this.gbShedulerQueue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpSettings;
        private System.Windows.Forms.GroupBox gbConfigSettings;
        private System.Windows.Forms.GroupBox gbConfigManageProject;
        private System.Windows.Forms.Button btnConfigSaveProject;
        private System.Windows.Forms.Button btnConfigInitProject;
        private System.Windows.Forms.Button btnConfigOpenProject;
        private System.Windows.Forms.TextBox tbConfigProjectPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpCalendar;
        private System.Windows.Forms.TabPage tpSheduler;
        private System.Windows.Forms.TabPage tpImageBase;
        private System.Windows.Forms.TabPage tpTextBase;
        private System.Windows.Forms.Button btnConfigSaveSettings;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpSettingsVk;
        private System.Windows.Forms.TabPage tpSettingsTelegram;
        private System.Windows.Forms.GroupBox gbSetVkAccountDetail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSetVkGroupUrl;
        private System.Windows.Forms.TextBox tbSetVkAccessToken;
        private System.Windows.Forms.TextBox tbSetVkUserId;
        private System.Windows.Forms.TextBox tbSetVkAppId;
        private ShedulerSettingsControl SchedulerSettingsForVK;
        private System.Windows.Forms.GroupBox gbImageBase;
        private System.Windows.Forms.GroupBox gbImageBasePreview;
        private System.Windows.Forms.TextBox tbImageBaseCurrentFileName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnImageBaseOpenOriginal;
        private System.Windows.Forms.PictureBox pbImageBasePreview;
        private System.Windows.Forms.Button btnImageBaseOpenInConductor;
        private System.Windows.Forms.Button btnImageBaseSave;
        private System.Windows.Forms.DataGridView dgvImageBase;
        private System.Windows.Forms.Button btnImageBaseCheckBaseWithFiles;
        private System.Windows.Forms.GroupBox gbTextBaseClearing;
        private System.Windows.Forms.GroupBox gbTextBaseManage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnTextBaseAdd;
        private System.Windows.Forms.Button btnTextBaseRemoveSelect;
        private System.Windows.Forms.Button btnTextBaseImportFromFile;
        private System.Windows.Forms.Button btnTextBaseSave;
        private System.Windows.Forms.GroupBox gbTextBase;
        private System.Windows.Forms.DataGridView dgvTextBase;
        private System.Windows.Forms.Button btnTextBaseRemoveDuplicateWithoutSmiles;
        private System.Windows.Forms.Button btnTextBaseRemoveDuplicate;
        private System.Windows.Forms.GroupBox gbCalendar;
        private System.Windows.Forms.DataGridView dgvCalendar;
        private System.Windows.Forms.ComboBox cbCalendarSelectedNetwork;
        private System.Windows.Forms.DateTimePicker dtpCalendarSelectedDay;
        private System.Windows.Forms.Button btnCalendarNextDay;
        private System.Windows.Forms.Button btnCalendarPreviousDay;
        private System.Windows.Forms.GroupBox gbShedulerQueue;
        private System.Windows.Forms.GroupBox gbShedulerGenerator;
        private System.Windows.Forms.CheckBox checkShedulerAutoSelectPostTime;
        private System.Windows.Forms.Button btnShedulerAddGeneratedPostInQueue;
        private System.Windows.Forms.DateTimePicker dtpShedulerGeneratedPostPubDate;
        private System.Windows.Forms.ComboBox cbShedulerSelectedNetwork;
        private System.Windows.Forms.Button btnShedulerGeneratePost;
        private System.Windows.Forms.PictureBox pbShedulerGeneratedPicture;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbShedulerGeneratedText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnShedulerToShedulePosts;
        private System.Windows.Forms.Button btnSchedulerRemoveFromQueue;
        private System.Windows.Forms.DataGridView dgvScheduler;
    }
}

