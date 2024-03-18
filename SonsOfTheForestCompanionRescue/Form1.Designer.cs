namespace SonsOfTheForestCompanionRescue
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            gameSavesComboBox = new ComboBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            kelvinStatusLabel = new Label();
            label6 = new Label();
            label2 = new Label();
            label4 = new Label();
            theGreatKelvinUnstuckinatorButton = new Button();
            kelvinPosYNumeric = new NumericUpDown();
            kelvinPosXNumeric = new NumericUpDown();
            kelvinPosZNumeric = new NumericUpDown();
            kelvinHealthNumeric = new NumericUpDown();
            moveKelvinToPlayerButton = new Button();
            kelvinResurrectButton = new Button();
            moveKelvinToPosButton = new Button();
            saveChangesButton = new Button();
            selectedSaveThumbnailPictureBox = new PictureBox();
            groupBox3 = new GroupBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            selectedSaveType = new Label();
            selectedSaveDateLabel = new Label();
            selectedSavePathTextBox = new TextBox();
            groupBox2 = new GroupBox();
            label3 = new Label();
            label5 = new Label();
            label8 = new Label();
            virginiaStatusLabel = new Label();
            label13 = new Label();
            label17 = new Label();
            label18 = new Label();
            moveVirginiaToFixPosButton = new Button();
            virginiaPosYNumeric = new NumericUpDown();
            virginiaPosXNumeric = new NumericUpDown();
            virginiaPosZNumeric = new NumericUpDown();
            virginiaHealthNumeric = new NumericUpDown();
            moveVirginiaToPlayerButton = new Button();
            virginiaResurrectButton = new Button();
            moveVirginiaToPosButton = new Button();
            repoLinkLabel = new LinkLabel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kelvinPosYNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kelvinPosXNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kelvinPosZNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kelvinHealthNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)selectedSaveThumbnailPictureBox).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)virginiaPosYNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)virginiaPosXNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)virginiaPosZNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)virginiaHealthNumeric).BeginInit();
            SuspendLayout();
            // 
            // gameSavesComboBox
            // 
            gameSavesComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gameSavesComboBox.FormattingEnabled = true;
            gameSavesComboBox.Location = new Point(104, 9);
            gameSavesComboBox.Margin = new Padding(3, 2, 3, 2);
            gameSavesComboBox.Name = "gameSavesComboBox";
            gameSavesComboBox.Size = new Size(586, 23);
            gameSavesComboBox.TabIndex = 0;
            gameSavesComboBox.SelectedIndexChanged += gameSavesComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 11);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 1;
            label1.Text = "Selected save:";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(kelvinStatusLabel);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(theGreatKelvinUnstuckinatorButton);
            groupBox1.Controls.Add(kelvinPosYNumeric);
            groupBox1.Controls.Add(kelvinPosXNumeric);
            groupBox1.Controls.Add(kelvinPosZNumeric);
            groupBox1.Controls.Add(kelvinHealthNumeric);
            groupBox1.Controls.Add(moveKelvinToPlayerButton);
            groupBox1.Controls.Add(kelvinResurrectButton);
            groupBox1.Controls.Add(moveKelvinToPosButton);
            groupBox1.Location = new Point(10, 153);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(679, 128);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kelvin";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(315, 69);
            label12.Name = "label12";
            label12.Size = new Size(12, 15);
            label12.TabIndex = 20;
            label12.Text = "z";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(192, 69);
            label11.Name = "label11";
            label11.Size = new Size(13, 15);
            label11.TabIndex = 19;
            label11.Text = "y";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(72, 69);
            label10.Name = "label10";
            label10.Size = new Size(13, 15);
            label10.TabIndex = 18;
            label10.Text = "x";
            // 
            // kelvinStatusLabel
            // 
            kelvinStatusLabel.AutoSize = true;
            kelvinStatusLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            kelvinStatusLabel.ForeColor = Color.Purple;
            kelvinStatusLabel.Location = new Point(74, 17);
            kelvinStatusLabel.Name = "kelvinStatusLabel";
            kelvinStatusLabel.Size = new Size(61, 15);
            kelvinStatusLabel.TabIndex = 17;
            kelvinStatusLabel.Text = "Unknown";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 17);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 16;
            label6.Text = "State:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 41);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 7;
            label2.Text = "Health:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 69);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 15;
            label4.Text = "Position:";
            // 
            // theGreatKelvinUnstuckinatorButton
            // 
            theGreatKelvinUnstuckinatorButton.Location = new Point(324, 92);
            theGreatKelvinUnstuckinatorButton.Margin = new Padding(3, 2, 3, 2);
            theGreatKelvinUnstuckinatorButton.Name = "theGreatKelvinUnstuckinatorButton";
            theGreatKelvinUnstuckinatorButton.Size = new Size(172, 22);
            theGreatKelvinUnstuckinatorButton.TabIndex = 11;
            theGreatKelvinUnstuckinatorButton.Text = "Move to fix safe position";
            theGreatKelvinUnstuckinatorButton.UseVisualStyleBackColor = true;
            theGreatKelvinUnstuckinatorButton.Click += theGreatKelvinUnstuckinatorButton_Click;
            // 
            // kelvinPosYNumeric
            // 
            kelvinPosYNumeric.DecimalPlaces = 5;
            kelvinPosYNumeric.Location = new Point(212, 68);
            kelvinPosYNumeric.Margin = new Padding(3, 2, 3, 2);
            kelvinPosYNumeric.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            kelvinPosYNumeric.Minimum = new decimal(new int[] { 999999, 0, 0, int.MinValue });
            kelvinPosYNumeric.Name = "kelvinPosYNumeric";
            kelvinPosYNumeric.Size = new Size(94, 23);
            kelvinPosYNumeric.TabIndex = 7;
            // 
            // kelvinPosXNumeric
            // 
            kelvinPosXNumeric.DecimalPlaces = 5;
            kelvinPosXNumeric.Location = new Point(89, 68);
            kelvinPosXNumeric.Margin = new Padding(3, 2, 3, 2);
            kelvinPosXNumeric.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            kelvinPosXNumeric.Minimum = new decimal(new int[] { 999999, 0, 0, int.MinValue });
            kelvinPosXNumeric.Name = "kelvinPosXNumeric";
            kelvinPosXNumeric.Size = new Size(94, 23);
            kelvinPosXNumeric.TabIndex = 6;
            // 
            // kelvinPosZNumeric
            // 
            kelvinPosZNumeric.DecimalPlaces = 5;
            kelvinPosZNumeric.Location = new Point(334, 68);
            kelvinPosZNumeric.Margin = new Padding(3, 2, 3, 2);
            kelvinPosZNumeric.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            kelvinPosZNumeric.Minimum = new decimal(new int[] { 999999, 0, 0, int.MinValue });
            kelvinPosZNumeric.Name = "kelvinPosZNumeric";
            kelvinPosZNumeric.Size = new Size(94, 23);
            kelvinPosZNumeric.TabIndex = 8;
            // 
            // kelvinHealthNumeric
            // 
            kelvinHealthNumeric.Location = new Point(74, 40);
            kelvinHealthNumeric.Margin = new Padding(3, 2, 3, 2);
            kelvinHealthNumeric.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            kelvinHealthNumeric.Minimum = new decimal(new int[] { 999999, 0, 0, int.MinValue });
            kelvinHealthNumeric.Name = "kelvinHealthNumeric";
            kelvinHealthNumeric.Size = new Size(109, 23);
            kelvinHealthNumeric.TabIndex = 5;
            kelvinHealthNumeric.ValueChanged += kelvinHealthNumeric_ValueChanged;
            // 
            // moveKelvinToPlayerButton
            // 
            moveKelvinToPlayerButton.Location = new Point(145, 92);
            moveKelvinToPlayerButton.Margin = new Padding(3, 2, 3, 2);
            moveKelvinToPlayerButton.Name = "moveKelvinToPlayerButton";
            moveKelvinToPlayerButton.Size = new Size(173, 22);
            moveKelvinToPlayerButton.TabIndex = 10;
            moveKelvinToPlayerButton.Text = "Move to player position";
            moveKelvinToPlayerButton.UseVisualStyleBackColor = true;
            moveKelvinToPlayerButton.Click += moveKelvinToPlayerButton_Click;
            // 
            // kelvinResurrectButton
            // 
            kelvinResurrectButton.Location = new Point(192, 14);
            kelvinResurrectButton.Margin = new Padding(3, 2, 3, 2);
            kelvinResurrectButton.Name = "kelvinResurrectButton";
            kelvinResurrectButton.Size = new Size(114, 22);
            kelvinResurrectButton.TabIndex = 4;
            kelvinResurrectButton.Text = "Resurrect";
            kelvinResurrectButton.UseVisualStyleBackColor = true;
            kelvinResurrectButton.Click += kelvinResurrectButton_Click;
            // 
            // moveKelvinToPosButton
            // 
            moveKelvinToPosButton.Location = new Point(7, 92);
            moveKelvinToPosButton.Margin = new Padding(3, 2, 3, 2);
            moveKelvinToPosButton.Name = "moveKelvinToPosButton";
            moveKelvinToPosButton.Size = new Size(133, 22);
            moveKelvinToPosButton.TabIndex = 9;
            moveKelvinToPosButton.Text = "Move to position";
            moveKelvinToPosButton.UseVisualStyleBackColor = true;
            moveKelvinToPosButton.Click += moveKelvinToPosButton_Click;
            // 
            // saveChangesButton
            // 
            saveChangesButton.Location = new Point(7, 84);
            saveChangesButton.Margin = new Padding(3, 2, 3, 2);
            saveChangesButton.Name = "saveChangesButton";
            saveChangesButton.Size = new Size(178, 22);
            saveChangesButton.TabIndex = 21;
            saveChangesButton.Text = "Write changes to file";
            saveChangesButton.UseVisualStyleBackColor = true;
            saveChangesButton.Click += saveChangesButton_Click;
            // 
            // selectedSaveThumbnailPictureBox
            // 
            selectedSaveThumbnailPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            selectedSaveThumbnailPictureBox.Location = new Point(501, 20);
            selectedSaveThumbnailPictureBox.Margin = new Padding(3, 2, 3, 2);
            selectedSaveThumbnailPictureBox.Name = "selectedSaveThumbnailPictureBox";
            selectedSaveThumbnailPictureBox.Size = new Size(172, 90);
            selectedSaveThumbnailPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            selectedSaveThumbnailPictureBox.TabIndex = 21;
            selectedSaveThumbnailPictureBox.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(selectedSaveType);
            groupBox3.Controls.Add(selectedSaveDateLabel);
            groupBox3.Controls.Add(saveChangesButton);
            groupBox3.Controls.Add(selectedSavePathTextBox);
            groupBox3.Controls.Add(selectedSaveThumbnailPictureBox);
            groupBox3.Location = new Point(10, 34);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(679, 114);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Save info";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(7, 22);
            label16.Name = "label16";
            label16.Size = new Size(61, 15);
            label16.TabIndex = 27;
            label16.Text = "Save path:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(7, 45);
            label15.Name = "label15";
            label15.Size = new Size(60, 15);
            label15.TabIndex = 26;
            label15.Text = "Save type:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(7, 67);
            label14.Name = "label14";
            label14.Size = new Size(60, 15);
            label14.TabIndex = 25;
            label14.Text = "Save date:";
            // 
            // selectedSaveType
            // 
            selectedSaveType.AutoSize = true;
            selectedSaveType.Location = new Point(94, 45);
            selectedSaveType.Name = "selectedSaveType";
            selectedSaveType.Size = new Size(12, 15);
            selectedSaveType.TabIndex = 24;
            selectedSaveType.Text = "-";
            // 
            // selectedSaveDateLabel
            // 
            selectedSaveDateLabel.AutoSize = true;
            selectedSaveDateLabel.Location = new Point(94, 67);
            selectedSaveDateLabel.Name = "selectedSaveDateLabel";
            selectedSaveDateLabel.Size = new Size(12, 15);
            selectedSaveDateLabel.TabIndex = 23;
            selectedSaveDateLabel.Text = "-";
            // 
            // selectedSavePathTextBox
            // 
            selectedSavePathTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            selectedSavePathTextBox.Location = new Point(94, 20);
            selectedSavePathTextBox.Margin = new Padding(3, 2, 3, 2);
            selectedSavePathTextBox.Name = "selectedSavePathTextBox";
            selectedSavePathTextBox.ReadOnly = true;
            selectedSavePathTextBox.Size = new Size(402, 23);
            selectedSavePathTextBox.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(virginiaStatusLabel);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(moveVirginiaToFixPosButton);
            groupBox2.Controls.Add(virginiaPosYNumeric);
            groupBox2.Controls.Add(virginiaPosXNumeric);
            groupBox2.Controls.Add(virginiaPosZNumeric);
            groupBox2.Controls.Add(virginiaHealthNumeric);
            groupBox2.Controls.Add(moveVirginiaToPlayerButton);
            groupBox2.Controls.Add(virginiaResurrectButton);
            groupBox2.Controls.Add(moveVirginiaToPosButton);
            groupBox2.Location = new Point(10, 285);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(679, 128);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Virginia";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(315, 69);
            label3.Name = "label3";
            label3.Size = new Size(12, 15);
            label3.TabIndex = 20;
            label3.Text = "z";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(192, 69);
            label5.Name = "label5";
            label5.Size = new Size(13, 15);
            label5.TabIndex = 19;
            label5.Text = "y";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(72, 69);
            label8.Name = "label8";
            label8.Size = new Size(13, 15);
            label8.TabIndex = 18;
            label8.Text = "x";
            // 
            // virginiaStatusLabel
            // 
            virginiaStatusLabel.AutoSize = true;
            virginiaStatusLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            virginiaStatusLabel.ForeColor = Color.Purple;
            virginiaStatusLabel.Location = new Point(74, 17);
            virginiaStatusLabel.Name = "virginiaStatusLabel";
            virginiaStatusLabel.Size = new Size(61, 15);
            virginiaStatusLabel.TabIndex = 17;
            virginiaStatusLabel.Text = "Unknown";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(7, 17);
            label13.Name = "label13";
            label13.Size = new Size(36, 15);
            label13.TabIndex = 16;
            label13.Text = "State:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(7, 41);
            label17.Name = "label17";
            label17.Size = new Size(45, 15);
            label17.TabIndex = 7;
            label17.Text = "Health:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(7, 69);
            label18.Name = "label18";
            label18.Size = new Size(53, 15);
            label18.TabIndex = 15;
            label18.Text = "Position:";
            // 
            // moveVirginiaToFixPosButton
            // 
            moveVirginiaToFixPosButton.Location = new Point(324, 92);
            moveVirginiaToFixPosButton.Margin = new Padding(3, 2, 3, 2);
            moveVirginiaToFixPosButton.Name = "moveVirginiaToFixPosButton";
            moveVirginiaToFixPosButton.Size = new Size(172, 22);
            moveVirginiaToFixPosButton.TabIndex = 20;
            moveVirginiaToFixPosButton.Text = "Move to fix safe position";
            moveVirginiaToFixPosButton.UseVisualStyleBackColor = true;
            moveVirginiaToFixPosButton.Click += moveVirginiaToFixPosButton_Click;
            // 
            // virginiaPosYNumeric
            // 
            virginiaPosYNumeric.DecimalPlaces = 5;
            virginiaPosYNumeric.Location = new Point(212, 68);
            virginiaPosYNumeric.Margin = new Padding(3, 2, 3, 2);
            virginiaPosYNumeric.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            virginiaPosYNumeric.Minimum = new decimal(new int[] { 999999, 0, 0, int.MinValue });
            virginiaPosYNumeric.Name = "virginiaPosYNumeric";
            virginiaPosYNumeric.Size = new Size(94, 23);
            virginiaPosYNumeric.TabIndex = 16;
            // 
            // virginiaPosXNumeric
            // 
            virginiaPosXNumeric.DecimalPlaces = 5;
            virginiaPosXNumeric.Location = new Point(89, 68);
            virginiaPosXNumeric.Margin = new Padding(3, 2, 3, 2);
            virginiaPosXNumeric.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            virginiaPosXNumeric.Minimum = new decimal(new int[] { 999999, 0, 0, int.MinValue });
            virginiaPosXNumeric.Name = "virginiaPosXNumeric";
            virginiaPosXNumeric.Size = new Size(94, 23);
            virginiaPosXNumeric.TabIndex = 15;
            // 
            // virginiaPosZNumeric
            // 
            virginiaPosZNumeric.DecimalPlaces = 5;
            virginiaPosZNumeric.Location = new Point(334, 68);
            virginiaPosZNumeric.Margin = new Padding(3, 2, 3, 2);
            virginiaPosZNumeric.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            virginiaPosZNumeric.Minimum = new decimal(new int[] { 999999, 0, 0, int.MinValue });
            virginiaPosZNumeric.Name = "virginiaPosZNumeric";
            virginiaPosZNumeric.Size = new Size(94, 23);
            virginiaPosZNumeric.TabIndex = 17;
            // 
            // virginiaHealthNumeric
            // 
            virginiaHealthNumeric.Location = new Point(74, 40);
            virginiaHealthNumeric.Margin = new Padding(3, 2, 3, 2);
            virginiaHealthNumeric.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            virginiaHealthNumeric.Minimum = new decimal(new int[] { 999999, 0, 0, int.MinValue });
            virginiaHealthNumeric.Name = "virginiaHealthNumeric";
            virginiaHealthNumeric.Size = new Size(109, 23);
            virginiaHealthNumeric.TabIndex = 14;
            virginiaHealthNumeric.ValueChanged += virginiaHealthNumeric_ValueChanged;
            // 
            // moveVirginiaToPlayerButton
            // 
            moveVirginiaToPlayerButton.Location = new Point(145, 92);
            moveVirginiaToPlayerButton.Margin = new Padding(3, 2, 3, 2);
            moveVirginiaToPlayerButton.Name = "moveVirginiaToPlayerButton";
            moveVirginiaToPlayerButton.Size = new Size(173, 22);
            moveVirginiaToPlayerButton.TabIndex = 19;
            moveVirginiaToPlayerButton.Text = "Move to player position";
            moveVirginiaToPlayerButton.UseVisualStyleBackColor = true;
            moveVirginiaToPlayerButton.Click += moveVirginiaToPlayerButton_Click;
            // 
            // virginiaResurrectButton
            // 
            virginiaResurrectButton.Location = new Point(192, 14);
            virginiaResurrectButton.Margin = new Padding(3, 2, 3, 2);
            virginiaResurrectButton.Name = "virginiaResurrectButton";
            virginiaResurrectButton.Size = new Size(114, 22);
            virginiaResurrectButton.TabIndex = 13;
            virginiaResurrectButton.Text = "Resurrect";
            virginiaResurrectButton.UseVisualStyleBackColor = true;
            virginiaResurrectButton.Click += virginiaResurrectButton_Click;
            // 
            // moveVirginiaToPosButton
            // 
            moveVirginiaToPosButton.Location = new Point(7, 92);
            moveVirginiaToPosButton.Margin = new Padding(3, 2, 3, 2);
            moveVirginiaToPosButton.Name = "moveVirginiaToPosButton";
            moveVirginiaToPosButton.Size = new Size(133, 22);
            moveVirginiaToPosButton.TabIndex = 18;
            moveVirginiaToPosButton.Text = "Move to position";
            moveVirginiaToPosButton.UseVisualStyleBackColor = true;
            moveVirginiaToPosButton.Click += moveVirginiaToPosButton_Click;
            // 
            // repoLinkLabel
            // 
            repoLinkLabel.AutoSize = true;
            repoLinkLabel.Location = new Point(10, 415);
            repoLinkLabel.Name = "repoLinkLabel";
            repoLinkLabel.Size = new Size(406, 15);
            repoLinkLabel.TabIndex = 13;
            repoLinkLabel.TabStop = true;
            repoLinkLabel.Text = "https://github.com/Xerren09/Sons-Of-The-Forest-Companion-Rescue-Tool";
            repoLinkLabel.LinkClicked += repoLinkLabel_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 434);
            Controls.Add(repoLinkLabel);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(gameSavesComboBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimumSize = new Size(544, 460);
            Name = "Form1";
            Text = "Sons Of The Forest Companion Rescue Tool";
            FormClosing += Form1_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kelvinPosYNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)kelvinPosXNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)kelvinPosZNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)kelvinHealthNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)selectedSaveThumbnailPictureBox).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)virginiaPosYNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)virginiaPosXNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)virginiaPosZNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)virginiaHealthNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox gameSavesComboBox;
        private Label label1;
        private GroupBox groupBox1;
        private Button theGreatKelvinUnstuckinatorButton;
        private NumericUpDown kelvinPosYNumeric;
        private NumericUpDown kelvinPosXNumeric;
        private NumericUpDown kelvinPosZNumeric;
        private NumericUpDown kelvinHealthNumeric;
        private Button moveKelvinToPlayerButton;
        private Button kelvinResurrectButton;
        private Button moveKelvinToPosButton;
        private Button saveChangesButton;
        private Label label2;
        private Label label4;
        private Label kelvinStatusLabel;
        private Label label6;
        private Label label12;
        private Label label11;
        private Label label10;
        private PictureBox selectedSaveThumbnailPictureBox;
        private GroupBox groupBox3;
        private Label selectedSaveDateLabel;
        private TextBox selectedSavePathTextBox;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label selectedSaveType;
        private GroupBox groupBox2;
        private Label label3;
        private Label label5;
        private Label label8;
        private Label virginiaStatusLabel;
        private Label label13;
        private Label label17;
        private Label label18;
        private Button moveVirginiaToFixPosButton;
        private NumericUpDown virginiaPosYNumeric;
        private NumericUpDown virginiaPosXNumeric;
        private NumericUpDown virginiaPosZNumeric;
        private NumericUpDown virginiaHealthNumeric;
        private Button moveVirginiaToPlayerButton;
        private Button virginiaResurrectButton;
        private Button moveVirginiaToPosButton;
        private LinkLabel repoLinkLabel;
    }
}