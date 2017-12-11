namespace BattleShipClient
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameStateUpdate = new System.Windows.Forms.Timer(this.components);
            this.opponentGrp = new MetroFramework.Drawing.Html.HtmlPanel();
            this.opponentNameTxt = new MetroFramework.Controls.MetroTextBox();
            this.opponentShipGrp = new System.Windows.Forms.GroupBox();
            this.boatLbl = new MetroFramework.Controls.MetroLabel();
            this.destroyerLbl = new MetroFramework.Controls.MetroLabel();
            this.submarineLbl = new MetroFramework.Controls.MetroLabel();
            this.battleshipLbl = new MetroFramework.Controls.MetroLabel();
            this.carrierLbl = new MetroFramework.Controls.MetroLabel();
            this.metroProgressSpinner5 = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroProgressSpinner4 = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroProgressSpinner3 = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroProgressSpinner2 = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.opponentCanvas = new System.Windows.Forms.PictureBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new MetroFramework.Drawing.Html.HtmlPanel();
            this.startBtn = new MetroFramework.Controls.MetroButton();
            this.endBtn = new MetroFramework.Controls.MetroButton();
            this.playerNametxt = new MetroFramework.Controls.MetroTextBox();
            this.shipPlacementGrp = new System.Windows.Forms.GroupBox();
            this.verticalRadio = new MetroFramework.Controls.MetroRadioButton();
            this.horizontalRadio = new MetroFramework.Controls.MetroRadioButton();
            this.boatBtn = new MetroFramework.Controls.MetroButton();
            this.destroyerBtn = new MetroFramework.Controls.MetroButton();
            this.submarineBtn = new MetroFramework.Controls.MetroButton();
            this.battleShipBtn = new MetroFramework.Controls.MetroButton();
            this.carrierBtn = new MetroFramework.Controls.MetroButton();
            this.playerCanvas = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mTitle = new MetroFramework.Controls.MetroTile();
            this.opponentGrp.SuspendLayout();
            this.opponentShipGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opponentCanvas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.shipPlacementGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // gameStateUpdate
            // 
            this.gameStateUpdate.Tick += new System.EventHandler(this.gameStateUpdate_Tick);
            // 
            // opponentGrp
            // 
            this.opponentGrp.AutoScroll = true;
            this.opponentGrp.AutoScrollMinSize = new System.Drawing.Size(523, 0);
            this.opponentGrp.BackColor = System.Drawing.SystemColors.Window;
            this.opponentGrp.Controls.Add(this.opponentNameTxt);
            this.opponentGrp.Controls.Add(this.opponentShipGrp);
            this.opponentGrp.Controls.Add(this.opponentCanvas);
            this.opponentGrp.Controls.Add(this.nameLbl);
            this.opponentGrp.Location = new System.Drawing.Point(12, 69);
            this.opponentGrp.Name = "opponentGrp";
            this.opponentGrp.Size = new System.Drawing.Size(523, 338);
            this.opponentGrp.TabIndex = 6;
            // 
            // opponentNameTxt
            // 
            // 
            // 
            // 
            this.opponentNameTxt.CustomButton.Image = null;
            this.opponentNameTxt.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.opponentNameTxt.CustomButton.Name = "";
            this.opponentNameTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.opponentNameTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.opponentNameTxt.CustomButton.TabIndex = 1;
            this.opponentNameTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.opponentNameTxt.CustomButton.UseSelectable = true;
            this.opponentNameTxt.CustomButton.Visible = false;
            this.opponentNameTxt.Lines = new string[0];
            this.opponentNameTxt.Location = new System.Drawing.Point(10, 29);
            this.opponentNameTxt.MaxLength = 32767;
            this.opponentNameTxt.Name = "opponentNameTxt";
            this.opponentNameTxt.PasswordChar = '\0';
            this.opponentNameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.opponentNameTxt.SelectedText = "";
            this.opponentNameTxt.SelectionLength = 0;
            this.opponentNameTxt.SelectionStart = 0;
            this.opponentNameTxt.ShortcutsEnabled = true;
            this.opponentNameTxt.Size = new System.Drawing.Size(175, 23);
            this.opponentNameTxt.TabIndex = 7;
            this.opponentNameTxt.UseSelectable = true;
            this.opponentNameTxt.UseStyleColors = true;
            this.opponentNameTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.opponentNameTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // opponentShipGrp
            // 
            this.opponentShipGrp.Controls.Add(this.boatLbl);
            this.opponentShipGrp.Controls.Add(this.destroyerLbl);
            this.opponentShipGrp.Controls.Add(this.submarineLbl);
            this.opponentShipGrp.Controls.Add(this.battleshipLbl);
            this.opponentShipGrp.Controls.Add(this.carrierLbl);
            this.opponentShipGrp.Controls.Add(this.metroProgressSpinner5);
            this.opponentShipGrp.Controls.Add(this.metroProgressSpinner4);
            this.opponentShipGrp.Controls.Add(this.metroProgressSpinner3);
            this.opponentShipGrp.Controls.Add(this.metroProgressSpinner2);
            this.opponentShipGrp.Controls.Add(this.metroProgressSpinner1);
            this.opponentShipGrp.Location = new System.Drawing.Point(9, 56);
            this.opponentShipGrp.Name = "opponentShipGrp";
            this.opponentShipGrp.Size = new System.Drawing.Size(182, 228);
            this.opponentShipGrp.TabIndex = 9;
            this.opponentShipGrp.TabStop = false;
            this.opponentShipGrp.Text = "Opponent Ships";
            // 
            // boatLbl
            // 
            this.boatLbl.AutoSize = true;
            this.boatLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.boatLbl.Location = new System.Drawing.Point(6, 179);
            this.boatLbl.Name = "boatLbl";
            this.boatLbl.Size = new System.Drawing.Size(98, 25);
            this.boatLbl.TabIndex = 2;
            this.boatLbl.Text = "Patrol Boat:";
            this.boatLbl.UseStyleColors = true;
            // 
            // destroyerLbl
            // 
            this.destroyerLbl.AutoSize = true;
            this.destroyerLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.destroyerLbl.Location = new System.Drawing.Point(6, 139);
            this.destroyerLbl.Name = "destroyerLbl";
            this.destroyerLbl.Size = new System.Drawing.Size(89, 25);
            this.destroyerLbl.TabIndex = 2;
            this.destroyerLbl.Text = "Destroyer:";
            this.destroyerLbl.UseStyleColors = true;
            // 
            // submarineLbl
            // 
            this.submarineLbl.AutoSize = true;
            this.submarineLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.submarineLbl.Location = new System.Drawing.Point(6, 99);
            this.submarineLbl.Name = "submarineLbl";
            this.submarineLbl.Size = new System.Drawing.Size(98, 25);
            this.submarineLbl.TabIndex = 2;
            this.submarineLbl.Text = "Submarine:";
            this.submarineLbl.UseStyleColors = true;
            // 
            // battleshipLbl
            // 
            this.battleshipLbl.AutoSize = true;
            this.battleshipLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.battleshipLbl.Location = new System.Drawing.Point(6, 59);
            this.battleshipLbl.Name = "battleshipLbl";
            this.battleshipLbl.Size = new System.Drawing.Size(89, 25);
            this.battleshipLbl.TabIndex = 11;
            this.battleshipLbl.Text = "Battleship:";
            this.battleshipLbl.UseStyleColors = true;
            // 
            // carrierLbl
            // 
            this.carrierLbl.AutoSize = true;
            this.carrierLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.carrierLbl.Location = new System.Drawing.Point(6, 19);
            this.carrierLbl.Name = "carrierLbl";
            this.carrierLbl.Size = new System.Drawing.Size(124, 25);
            this.carrierLbl.TabIndex = 10;
            this.carrierLbl.Text = "Aircraft carrier:";
            this.carrierLbl.UseStyleColors = true;
            // 
            // metroProgressSpinner5
            // 
            this.metroProgressSpinner5.Location = new System.Drawing.Point(145, 179);
            this.metroProgressSpinner5.Maximum = 5;
            this.metroProgressSpinner5.Name = "metroProgressSpinner5";
            this.metroProgressSpinner5.Size = new System.Drawing.Size(31, 34);
            this.metroProgressSpinner5.TabIndex = 9;
            this.metroProgressSpinner5.UseSelectable = true;
            this.metroProgressSpinner5.Value = 5;
            // 
            // metroProgressSpinner4
            // 
            this.metroProgressSpinner4.Location = new System.Drawing.Point(145, 139);
            this.metroProgressSpinner4.Maximum = 5;
            this.metroProgressSpinner4.Name = "metroProgressSpinner4";
            this.metroProgressSpinner4.Size = new System.Drawing.Size(31, 34);
            this.metroProgressSpinner4.TabIndex = 8;
            this.metroProgressSpinner4.UseSelectable = true;
            this.metroProgressSpinner4.Value = 5;
            // 
            // metroProgressSpinner3
            // 
            this.metroProgressSpinner3.Location = new System.Drawing.Point(145, 99);
            this.metroProgressSpinner3.Maximum = 5;
            this.metroProgressSpinner3.Name = "metroProgressSpinner3";
            this.metroProgressSpinner3.Size = new System.Drawing.Size(31, 34);
            this.metroProgressSpinner3.TabIndex = 7;
            this.metroProgressSpinner3.UseSelectable = true;
            this.metroProgressSpinner3.Value = 5;
            // 
            // metroProgressSpinner2
            // 
            this.metroProgressSpinner2.Location = new System.Drawing.Point(145, 59);
            this.metroProgressSpinner2.Maximum = 5;
            this.metroProgressSpinner2.Name = "metroProgressSpinner2";
            this.metroProgressSpinner2.Size = new System.Drawing.Size(31, 34);
            this.metroProgressSpinner2.TabIndex = 6;
            this.metroProgressSpinner2.UseSelectable = true;
            this.metroProgressSpinner2.Value = 5;
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Location = new System.Drawing.Point(145, 19);
            this.metroProgressSpinner1.Maximum = 5;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(31, 34);
            this.metroProgressSpinner1.TabIndex = 5;
            this.metroProgressSpinner1.UseSelectable = true;
            this.metroProgressSpinner1.Value = 5;
            // 
            // opponentCanvas
            // 
            this.opponentCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.opponentCanvas.Location = new System.Drawing.Point(197, 9);
            this.opponentCanvas.Name = "opponentCanvas";
            this.opponentCanvas.Size = new System.Drawing.Size(320, 320);
            this.opponentCanvas.TabIndex = 8;
            this.opponentCanvas.TabStop = false;
            this.opponentCanvas.Click += new System.EventHandler(this.opponentCanvas_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(6, 13);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(41, 13);
            this.nameLbl.TabIndex = 6;
            this.nameLbl.Text = "Name: ";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoScroll = true;
            this.groupBox1.AutoScrollMinSize = new System.Drawing.Size(522, 0);
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.startBtn);
            this.groupBox1.Controls.Add(this.endBtn);
            this.groupBox1.Controls.Add(this.playerNametxt);
            this.groupBox1.Controls.Add(this.shipPlacementGrp);
            this.groupBox1.Controls.Add(this.playerCanvas);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(9, 411);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 338);
            this.groupBox1.TabIndex = 11;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(99, 296);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 33);
            this.startBtn.TabIndex = 16;
            this.startBtn.Text = "Start";
            this.startBtn.UseSelectable = true;
            this.startBtn.UseStyleColors = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // endBtn
            // 
            this.endBtn.Location = new System.Drawing.Point(12, 296);
            this.endBtn.Name = "endBtn";
            this.endBtn.Size = new System.Drawing.Size(75, 33);
            this.endBtn.TabIndex = 15;
            this.endBtn.Text = "End Turn";
            this.endBtn.UseSelectable = true;
            this.endBtn.UseStyleColors = true;
            this.endBtn.Click += new System.EventHandler(this.endBtn_Click);
            // 
            // playerNametxt
            // 
            // 
            // 
            // 
            this.playerNametxt.CustomButton.Image = null;
            this.playerNametxt.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.playerNametxt.CustomButton.Name = "";
            this.playerNametxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.playerNametxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.playerNametxt.CustomButton.TabIndex = 1;
            this.playerNametxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.playerNametxt.CustomButton.UseSelectable = true;
            this.playerNametxt.CustomButton.Visible = false;
            this.playerNametxt.Lines = new string[0];
            this.playerNametxt.Location = new System.Drawing.Point(12, 29);
            this.playerNametxt.MaxLength = 32767;
            this.playerNametxt.Name = "playerNametxt";
            this.playerNametxt.PasswordChar = '\0';
            this.playerNametxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.playerNametxt.SelectedText = "";
            this.playerNametxt.SelectionLength = 0;
            this.playerNametxt.SelectionStart = 0;
            this.playerNametxt.ShortcutsEnabled = true;
            this.playerNametxt.Size = new System.Drawing.Size(162, 23);
            this.playerNametxt.TabIndex = 14;
            this.playerNametxt.UseSelectable = true;
            this.playerNametxt.UseStyleColors = true;
            this.playerNametxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.playerNametxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.playerNametxt.TextChanged += new System.EventHandler(this.playerNametxt_TextChanged);
            // 
            // shipPlacementGrp
            // 
            this.shipPlacementGrp.Controls.Add(this.verticalRadio);
            this.shipPlacementGrp.Controls.Add(this.horizontalRadio);
            this.shipPlacementGrp.Controls.Add(this.boatBtn);
            this.shipPlacementGrp.Controls.Add(this.destroyerBtn);
            this.shipPlacementGrp.Controls.Add(this.submarineBtn);
            this.shipPlacementGrp.Controls.Add(this.battleShipBtn);
            this.shipPlacementGrp.Controls.Add(this.carrierBtn);
            this.shipPlacementGrp.Location = new System.Drawing.Point(3, 61);
            this.shipPlacementGrp.Name = "shipPlacementGrp";
            this.shipPlacementGrp.Size = new System.Drawing.Size(171, 229);
            this.shipPlacementGrp.TabIndex = 13;
            this.shipPlacementGrp.TabStop = false;
            this.shipPlacementGrp.Text = "Ship Placement";
            // 
            // verticalRadio
            // 
            this.verticalRadio.AutoSize = true;
            this.verticalRadio.Location = new System.Drawing.Point(26, 190);
            this.verticalRadio.Name = "verticalRadio";
            this.verticalRadio.Size = new System.Drawing.Size(61, 15);
            this.verticalRadio.TabIndex = 12;
            this.verticalRadio.Text = "Vertical";
            this.verticalRadio.UseSelectable = true;
            this.verticalRadio.UseStyleColors = true;
            this.verticalRadio.CheckedChanged += new System.EventHandler(this.verticalRadio_CheckedChanged);
            // 
            // horizontalRadio
            // 
            this.horizontalRadio.AutoSize = true;
            this.horizontalRadio.Checked = true;
            this.horizontalRadio.Location = new System.Drawing.Point(26, 169);
            this.horizontalRadio.Name = "horizontalRadio";
            this.horizontalRadio.Size = new System.Drawing.Size(78, 15);
            this.horizontalRadio.TabIndex = 11;
            this.horizontalRadio.TabStop = true;
            this.horizontalRadio.Text = "Horizontal";
            this.horizontalRadio.UseSelectable = true;
            this.horizontalRadio.UseStyleColors = true;
            this.horizontalRadio.CheckedChanged += new System.EventHandler(this.horizontalRadio_CheckedChanged);
            // 
            // boatBtn
            // 
            this.boatBtn.Location = new System.Drawing.Point(17, 140);
            this.boatBtn.Name = "boatBtn";
            this.boatBtn.Size = new System.Drawing.Size(145, 23);
            this.boatBtn.TabIndex = 10;
            this.boatBtn.Text = "Add Boat";
            this.boatBtn.UseSelectable = true;
            this.boatBtn.UseStyleColors = true;
            this.boatBtn.Click += new System.EventHandler(this.boatBtn_Click);
            // 
            // destroyerBtn
            // 
            this.destroyerBtn.Location = new System.Drawing.Point(17, 111);
            this.destroyerBtn.Name = "destroyerBtn";
            this.destroyerBtn.Size = new System.Drawing.Size(145, 23);
            this.destroyerBtn.TabIndex = 9;
            this.destroyerBtn.Text = "Add Destroyer";
            this.destroyerBtn.UseSelectable = true;
            this.destroyerBtn.UseStyleColors = true;
            this.destroyerBtn.Click += new System.EventHandler(this.destroyerBtn_Click);
            // 
            // submarineBtn
            // 
            this.submarineBtn.Location = new System.Drawing.Point(17, 82);
            this.submarineBtn.Name = "submarineBtn";
            this.submarineBtn.Size = new System.Drawing.Size(145, 23);
            this.submarineBtn.TabIndex = 8;
            this.submarineBtn.Text = "Add Submarine";
            this.submarineBtn.UseSelectable = true;
            this.submarineBtn.UseStyleColors = true;
            this.submarineBtn.Click += new System.EventHandler(this.submarineBtn_Click);
            // 
            // battleShipBtn
            // 
            this.battleShipBtn.Location = new System.Drawing.Point(17, 53);
            this.battleShipBtn.Name = "battleShipBtn";
            this.battleShipBtn.Size = new System.Drawing.Size(145, 23);
            this.battleShipBtn.TabIndex = 7;
            this.battleShipBtn.Text = "Add BattleShip";
            this.battleShipBtn.UseSelectable = true;
            this.battleShipBtn.UseStyleColors = true;
            this.battleShipBtn.Click += new System.EventHandler(this.battleShipBtn_Click);
            // 
            // carrierBtn
            // 
            this.carrierBtn.Location = new System.Drawing.Point(17, 24);
            this.carrierBtn.Name = "carrierBtn";
            this.carrierBtn.Size = new System.Drawing.Size(145, 23);
            this.carrierBtn.TabIndex = 6;
            this.carrierBtn.Text = "Add Carrier";
            this.carrierBtn.UseSelectable = true;
            this.carrierBtn.UseStyleColors = true;
            this.carrierBtn.Click += new System.EventHandler(this.carrierBtn_Click);
            // 
            // playerCanvas
            // 
            this.playerCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerCanvas.Location = new System.Drawing.Point(199, 9);
            this.playerCanvas.Name = "playerCanvas";
            this.playerCanvas.Size = new System.Drawing.Size(320, 320);
            this.playerCanvas.TabIndex = 12;
            this.playerCanvas.TabStop = false;
            this.playerCanvas.Click += new System.EventHandler(this.playerCanvas_Click);
            this.playerCanvas.MouseLeave += new System.EventHandler(this.playerCanvas_MouseLeave);
            this.playerCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.playerCanvas_MouseMove);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Name: ";
            // 
            // mTitle
            // 
            this.mTitle.ActiveControl = null;
            this.mTitle.BackColor = System.Drawing.Color.Red;
            this.mTitle.Location = new System.Drawing.Point(5, 35);
            this.mTitle.Name = "mTitle";
            this.mTitle.Size = new System.Drawing.Size(526, 37);
            this.mTitle.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTitle.TabIndex = 12;
            this.mTitle.Text = "BattleZone - Khodani Zuzeka Xabiso Lincoln";
            this.mTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTitle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mTitle.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTitle.UseSelectable = true;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(539, 772);
            this.Controls.Add(this.mTitle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.opponentGrp);
            this.Name = "GameForm";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Load += new System.EventHandler(this.Game_Load);
            this.opponentGrp.ResumeLayout(false);
            this.opponentGrp.PerformLayout();
            this.opponentShipGrp.ResumeLayout(false);
            this.opponentShipGrp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opponentCanvas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.shipPlacementGrp.ResumeLayout(false);
            this.shipPlacementGrp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer gameStateUpdate;
        private MetroFramework.Drawing.Html.HtmlPanel opponentGrp;
        private MetroFramework.Controls.MetroTextBox opponentNameTxt;
        private System.Windows.Forms.GroupBox opponentShipGrp;
        private MetroFramework.Controls.MetroLabel boatLbl;
        private MetroFramework.Controls.MetroLabel destroyerLbl;
        private MetroFramework.Controls.MetroLabel submarineLbl;
        private MetroFramework.Controls.MetroLabel battleshipLbl;
        private MetroFramework.Controls.MetroLabel carrierLbl;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner5;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner4;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner3;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner2;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private System.Windows.Forms.PictureBox opponentCanvas;
        private System.Windows.Forms.Label nameLbl;
        private MetroFramework.Drawing.Html.HtmlPanel groupBox1;
        private MetroFramework.Controls.MetroButton startBtn;
        private MetroFramework.Controls.MetroButton endBtn;
        private MetroFramework.Controls.MetroTextBox playerNametxt;
        private System.Windows.Forms.GroupBox shipPlacementGrp;
        private MetroFramework.Controls.MetroRadioButton verticalRadio;
        private MetroFramework.Controls.MetroRadioButton horizontalRadio;
        private MetroFramework.Controls.MetroButton boatBtn;
        private MetroFramework.Controls.MetroButton destroyerBtn;
        private MetroFramework.Controls.MetroButton submarineBtn;
        private MetroFramework.Controls.MetroButton battleShipBtn;
        private MetroFramework.Controls.MetroButton carrierBtn;
        private System.Windows.Forms.PictureBox playerCanvas;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTile mTitle;
    }
}