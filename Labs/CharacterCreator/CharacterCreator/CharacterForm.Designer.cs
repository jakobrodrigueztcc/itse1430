namespace CharacterCreator.Winforms
{
    partial class CharacterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._txtName = new System.Windows.Forms.TextBox();
            this._txtDescription = new System.Windows.Forms.TextBox();
            this._cbSpecies = new System.Windows.Forms.ComboBox();
            this._cbClass = new System.Windows.Forms.ComboBox();
            this._cbWeapon = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this._nudStrength = new System.Windows.Forms.NumericUpDown();
            this._nudDefense = new System.Windows.Forms.NumericUpDown();
            this._nudSpeed = new System.Windows.Forms.NumericUpDown();
            this._nudIntelligence = new System.Windows.Forms.NumericUpDown();
            this._nudSocial = new System.Windows.Forms.NumericUpDown();
            this._errors = new System.Windows.Forms.ErrorProvider(this.components);
            this._cbFlight = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this._nudStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudDefense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudIntelligence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudSocial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._errors)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Class";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Species";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Weapon";
            // 
            // _txtName
            // 
            this._txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtName.Location = new System.Drawing.Point(78, 6);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(233, 20);
            this._txtName.TabIndex = 0;
            this._txtName.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateName);
            // 
            // _txtDescription
            // 
            this._txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtDescription.Location = new System.Drawing.Point(78, 117);
            this._txtDescription.Multiline = true;
            this._txtDescription.Name = "_txtDescription";
            this._txtDescription.Size = new System.Drawing.Size(233, 80);
            this._txtDescription.TabIndex = 4;
            // 
            // _cbSpecies
            // 
            this._cbSpecies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbSpecies.FormattingEnabled = true;
            this._cbSpecies.Items.AddRange(new object[] {
            "Dinosaur",
            "Pterosaur",
            "Plesiosaur",
            "Fish",
            "Shark",
            "Amphibian",
            "Lizard",
            "Snake",
            "Bird",
            "Mammoth",
            "Ape",
            "Humanoid",
            "Mech",
            "Extraterrestrial",
            "Insect",
            "Arachnid",
            "Crustacean",
            "Mollusk"});
            this._cbSpecies.Location = new System.Drawing.Point(78, 33);
            this._cbSpecies.Name = "_cbSpecies";
            this._cbSpecies.Size = new System.Drawing.Size(141, 21);
            this._cbSpecies.TabIndex = 1;
            // 
            // _cbClass
            // 
            this._cbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbClass.FormattingEnabled = true;
            this._cbClass.Items.AddRange(new object[] {
            "Brawler",
            "Long-Range Fighter",
            "Defensive Tank",
            "Speedster",
            "Pacifist",
            "All-Around"});
            this._cbClass.Location = new System.Drawing.Point(78, 59);
            this._cbClass.Name = "_cbClass";
            this._cbClass.Size = new System.Drawing.Size(141, 21);
            this._cbClass.TabIndex = 2;
            // 
            // _cbWeapon
            // 
            this._cbWeapon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbWeapon.FormattingEnabled = true;
            this._cbWeapon.Items.AddRange(new object[] {
            "Nuclear Attack",
            "Elemental Attack",
            "Sonic Roar",
            "Prehensile Limb",
            "Telekinesis",
            "Shield",
            "Drill",
            "Sludge",
            "Web",
            "Reflective Scales",
            "None"});
            this._cbWeapon.Location = new System.Drawing.Point(78, 87);
            this._cbWeapon.Name = "_cbWeapon";
            this._cbWeapon.Size = new System.Drawing.Size(141, 21);
            this._cbWeapon.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Strength";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Defense";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Speed";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(158, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Intelligence";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(183, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Social";
            // 
            // _btnSave
            // 
            this._btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSave.Location = new System.Drawing.Point(155, 330);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(75, 23);
            this._btnSave.TabIndex = 11;
            this._btnSave.Text = "&Save";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this.OnSave);
            // 
            // _btnCancel
            // 
            this._btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnCancel.Location = new System.Drawing.Point(236, 330);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 12;
            this._btnCancel.Text = "&Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this.OnCancel);
            // 
            // _nudStrength
            // 
            this._nudStrength.Location = new System.Drawing.Point(78, 203);
            this._nudStrength.Name = "_nudStrength";
            this._nudStrength.Size = new System.Drawing.Size(70, 20);
            this._nudStrength.TabIndex = 5;
            this._nudStrength.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // _nudDefense
            // 
            this._nudDefense.Location = new System.Drawing.Point(225, 202);
            this._nudDefense.Name = "_nudDefense";
            this._nudDefense.Size = new System.Drawing.Size(70, 20);
            this._nudDefense.TabIndex = 6;
            this._nudDefense.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // _nudSpeed
            // 
            this._nudSpeed.Location = new System.Drawing.Point(78, 239);
            this._nudSpeed.Name = "_nudSpeed";
            this._nudSpeed.Size = new System.Drawing.Size(70, 20);
            this._nudSpeed.TabIndex = 7;
            this._nudSpeed.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // _nudIntelligence
            // 
            this._nudIntelligence.Location = new System.Drawing.Point(225, 239);
            this._nudIntelligence.Name = "_nudIntelligence";
            this._nudIntelligence.Size = new System.Drawing.Size(70, 20);
            this._nudIntelligence.TabIndex = 8;
            this._nudIntelligence.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // _nudSocial
            // 
            this._nudSocial.Location = new System.Drawing.Point(225, 277);
            this._nudSocial.Name = "_nudSocial";
            this._nudSocial.Size = new System.Drawing.Size(70, 20);
            this._nudSocial.TabIndex = 9;
            this._nudSocial.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // _errors
            // 
            this._errors.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this._errors.ContainerControl = this;
            // 
            // _cbFlight
            // 
            this._cbFlight.AutoSize = true;
            this._cbFlight.Location = new System.Drawing.Point(78, 304);
            this._cbFlight.Name = "_cbFlight";
            this._cbFlight.Size = new System.Drawing.Size(92, 17);
            this._cbFlight.TabIndex = 10;
            this._cbFlight.Text = "Flight-capable";
            this._cbFlight.UseVisualStyleBackColor = true;
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.Controls.Add(this._cbFlight);
            this.Controls.Add(this._nudSocial);
            this.Controls.Add(this._nudIntelligence);
            this.Controls.Add(this._nudSpeed);
            this.Controls.Add(this._nudDefense);
            this.Controls.Add(this._nudStrength);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._cbWeapon);
            this.Controls.Add(this._cbClass);
            this.Controls.Add(this._cbSpecies);
            this.Controls.Add(this._txtDescription);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 400);
            this.Name = "CharacterForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kaiju Details";
            ((System.ComponentModel.ISupportInitialize)(this._nudStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudDefense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudIntelligence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudSocial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._errors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.TextBox _txtDescription;
        private System.Windows.Forms.ComboBox _cbSpecies;
        private System.Windows.Forms.ComboBox _cbClass;
        private System.Windows.Forms.ComboBox _cbWeapon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.NumericUpDown _nudStrength;
        private System.Windows.Forms.NumericUpDown _nudDefense;
        private System.Windows.Forms.NumericUpDown _nudSpeed;
        private System.Windows.Forms.NumericUpDown _nudIntelligence;
        private System.Windows.Forms.NumericUpDown _nudSocial;
        private System.Windows.Forms.ErrorProvider _errors;
        private System.Windows.Forms.CheckBox _cbFlight;
    }
}