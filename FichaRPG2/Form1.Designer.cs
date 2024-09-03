namespace FichaRPG2
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
            components = new System.ComponentModel.Container();
            STR = new NumericUpDown();
            DEX = new NumericUpDown();
            CONS = new NumericUpDown();
            INT = new NumericUpDown();
            SAB = new NumericUpDown();
            CHA = new NumericUpDown();
            labelSTR = new Label();
            labelDEX = new Label();
            labelCONS = new Label();
            labelINT = new Label();
            labelSAB = new Label();
            labelCHA = new Label();
            labelLimite = new Label();
            Classe = new ComboBox();
            labelClasse = new Label();
            label1 = new Label();
            bonusSTR = new Label();
            bonusDEX = new Label();
            bonusCONS = new Label();
            bonusINT = new Label();
            bonusSAB = new Label();
            bonusCHA = new Label();
            label7 = new Label();
            labelComp1 = new Label();
            complemento1 = new ComboBox();
            labelComp2 = new Label();
            complemento2 = new ComboBox();
            labelTotal = new Label();
            totalSTR = new Label();
            totalDEX = new Label();
            totalCONS = new Label();
            totalINT = new Label();
            totalSAB = new Label();
            totalCHA = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            modSTR = new Label();
            modDEX = new Label();
            modCONS = new Label();
            modINT = new Label();
            modSAB = new Label();
            modCHA = new Label();
            label3 = new Label();
            checkSTR = new CheckBox();
            checkDEX = new CheckBox();
            checkINT = new CheckBox();
            checkSAB = new CheckBox();
            checkCONS = new CheckBox();
            checkCHA = new CheckBox();
            saveSTR = new Label();
            saveCONS = new Label();
            saveDEX = new Label();
            saveINT = new Label();
            saveSAB = new Label();
            saveCHA = new Label();
            label4 = new Label();
            perception = new Label();
            nature = new Label();
            medicine = new Label();
            animalHanding = new Label();
            arcana = new Label();
            acrobatics = new Label();
            checkBoxPercep = new CheckBox();
            checkBoxArcana = new CheckBox();
            checkBoxNature = new CheckBox();
            checkBoxMedicine = new CheckBox();
            checkBoxAnimal = new CheckBox();
            checkBoxAcro = new CheckBox();
            religion = new Label();
            persuasion = new Label();
            performace = new Label();
            deception = new Label();
            history = new Label();
            athletic = new Label();
            checkBoxReligion = new CheckBox();
            checkBoxHistory = new CheckBox();
            checkBoxPersua = new CheckBox();
            checkBoxPerfor = new CheckBox();
            checkBoxDeception = new CheckBox();
            checkBoxAthletic = new CheckBox();
            survival = new Label();
            stealth = new Label();
            sleight = new Label();
            intimidation = new Label();
            investigation = new Label();
            insight = new Label();
            checkBoxSurvival = new CheckBox();
            checkBoxInvesti = new CheckBox();
            checkBoxStealth = new CheckBox();
            checkBoxSleight = new CheckBox();
            checkBoxIntimidate = new CheckBox();
            checkBoxInsight = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)STR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DEX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CONS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)INT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SAB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CHA).BeginInit();
            SuspendLayout();
            // 
            // STR
            // 
            STR.Location = new Point(123, 105);
            STR.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            STR.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            STR.Name = "STR";
            STR.Size = new Size(51, 23);
            STR.TabIndex = 0;
            STR.Value = new decimal(new int[] { 8, 0, 0, 0 });
            STR.ValueChanged += STR_ValueChanged;
            // 
            // DEX
            // 
            DEX.Location = new Point(123, 148);
            DEX.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            DEX.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            DEX.Name = "DEX";
            DEX.Size = new Size(51, 23);
            DEX.TabIndex = 1;
            DEX.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // CONS
            // 
            CONS.Location = new Point(123, 191);
            CONS.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            CONS.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            CONS.Name = "CONS";
            CONS.Size = new Size(51, 23);
            CONS.TabIndex = 2;
            CONS.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // INT
            // 
            INT.Location = new Point(123, 234);
            INT.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            INT.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            INT.Name = "INT";
            INT.Size = new Size(51, 23);
            INT.TabIndex = 3;
            INT.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // SAB
            // 
            SAB.Location = new Point(123, 277);
            SAB.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            SAB.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            SAB.Name = "SAB";
            SAB.Size = new Size(51, 23);
            SAB.TabIndex = 4;
            SAB.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // CHA
            // 
            CHA.Location = new Point(123, 320);
            CHA.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            CHA.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            CHA.Name = "CHA";
            CHA.Size = new Size(51, 23);
            CHA.TabIndex = 5;
            CHA.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // labelSTR
            // 
            labelSTR.AutoSize = true;
            labelSTR.Location = new Point(94, 108);
            labelSTR.Name = "labelSTR";
            labelSTR.Size = new Size(26, 15);
            labelSTR.TabIndex = 6;
            labelSTR.Text = "STR";
            // 
            // labelDEX
            // 
            labelDEX.AutoSize = true;
            labelDEX.Location = new Point(93, 151);
            labelDEX.Name = "labelDEX";
            labelDEX.Size = new Size(28, 15);
            labelDEX.TabIndex = 7;
            labelDEX.Text = "DEX";
            // 
            // labelCONS
            // 
            labelCONS.AutoSize = true;
            labelCONS.Location = new Point(82, 194);
            labelCONS.Name = "labelCONS";
            labelCONS.Size = new Size(39, 15);
            labelCONS.TabIndex = 8;
            labelCONS.Text = "CONS";
            // 
            // labelINT
            // 
            labelINT.AutoSize = true;
            labelINT.Location = new Point(95, 237);
            labelINT.Name = "labelINT";
            labelINT.Size = new Size(25, 15);
            labelINT.TabIndex = 9;
            labelINT.Text = "INT";
            // 
            // labelSAB
            // 
            labelSAB.AutoSize = true;
            labelSAB.Location = new Point(93, 280);
            labelSAB.Name = "labelSAB";
            labelSAB.Size = new Size(28, 15);
            labelSAB.TabIndex = 10;
            labelSAB.Text = "SAB";
            // 
            // labelCHA
            // 
            labelCHA.AutoSize = true;
            labelCHA.Location = new Point(89, 323);
            labelCHA.Name = "labelCHA";
            labelCHA.Size = new Size(32, 15);
            labelCHA.TabIndex = 11;
            labelCHA.Text = "CHA";
            // 
            // labelLimite
            // 
            labelLimite.AutoSize = true;
            labelLimite.Location = new Point(111, 366);
            labelLimite.Name = "labelLimite";
            labelLimite.Size = new Size(30, 15);
            labelLimite.TabIndex = 13;
            labelLimite.Text = "0/27";
            // 
            // Classe
            // 
            Classe.DropDownStyle = ComboBoxStyle.DropDownList;
            Classe.FormattingEnabled = true;
            Classe.Items.AddRange(new object[] { "Humano", "Anão", "Elfo", "Halfling", "Draconato", "Gnomo", "Meio Elfo", "Meio Orc", "Tielfling" });
            Classe.Location = new Point(123, 27);
            Classe.Name = "Classe";
            Classe.Size = new Size(121, 23);
            Classe.TabIndex = 15;
            Classe.SelectedIndexChanged += Classe_SelectedIndexChanged;
            // 
            // labelClasse
            // 
            labelClasse.AutoSize = true;
            labelClasse.Location = new Point(80, 30);
            labelClasse.Name = "labelClasse";
            labelClasse.Size = new Size(41, 15);
            labelClasse.TabIndex = 16;
            labelClasse.Text = "RAÇA:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(206, 73);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 17;
            label1.Text = "Ponto Bonus";
            // 
            // bonusSTR
            // 
            bonusSTR.AutoSize = true;
            bonusSTR.Location = new Point(235, 109);
            bonusSTR.Name = "bonusSTR";
            bonusSTR.Size = new Size(13, 15);
            bonusSTR.TabIndex = 18;
            bonusSTR.Text = "0";
            bonusSTR.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bonusDEX
            // 
            bonusDEX.AutoSize = true;
            bonusDEX.Location = new Point(235, 150);
            bonusDEX.Name = "bonusDEX";
            bonusDEX.Size = new Size(13, 15);
            bonusDEX.TabIndex = 19;
            bonusDEX.Text = "0";
            bonusDEX.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bonusCONS
            // 
            bonusCONS.AutoSize = true;
            bonusCONS.Location = new Point(235, 193);
            bonusCONS.Name = "bonusCONS";
            bonusCONS.Size = new Size(13, 15);
            bonusCONS.TabIndex = 20;
            bonusCONS.Text = "0";
            bonusCONS.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bonusINT
            // 
            bonusINT.AutoSize = true;
            bonusINT.Location = new Point(235, 236);
            bonusINT.Name = "bonusINT";
            bonusINT.Size = new Size(13, 15);
            bonusINT.TabIndex = 21;
            bonusINT.Text = "0";
            bonusINT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bonusSAB
            // 
            bonusSAB.AutoSize = true;
            bonusSAB.Location = new Point(235, 280);
            bonusSAB.Name = "bonusSAB";
            bonusSAB.Size = new Size(13, 15);
            bonusSAB.TabIndex = 22;
            bonusSAB.Text = "0";
            bonusSAB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bonusCHA
            // 
            bonusCHA.AutoSize = true;
            bonusCHA.Location = new Point(235, 323);
            bonusCHA.Name = "bonusCHA";
            bonusCHA.Size = new Size(13, 15);
            bonusCHA.TabIndex = 23;
            bonusCHA.Text = "0";
            bonusCHA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(107, 73);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 24;
            label7.Text = "Atributos";
            // 
            // labelComp1
            // 
            labelComp1.AutoSize = true;
            labelComp1.Location = new Point(264, 30);
            labelComp1.Name = "labelComp1";
            labelComp1.Size = new Size(103, 15);
            labelComp1.TabIndex = 25;
            labelComp1.Text = "COMPLEMENTO 1";
            // 
            // complemento1
            // 
            complemento1.DropDownStyle = ComboBoxStyle.DropDownList;
            complemento1.FormattingEnabled = true;
            complemento1.Items.AddRange(new object[] { "" });
            complemento1.Location = new Point(369, 27);
            complemento1.Name = "complemento1";
            complemento1.Size = new Size(121, 23);
            complemento1.TabIndex = 26;
            complemento1.SelectedIndexChanged += complemento1_SelectedIndexChanged;
            // 
            // labelComp2
            // 
            labelComp2.AutoSize = true;
            labelComp2.Location = new Point(520, 30);
            labelComp2.Name = "labelComp2";
            labelComp2.Size = new Size(103, 15);
            labelComp2.TabIndex = 27;
            labelComp2.Text = "COMPLEMENTO 2";
            // 
            // complemento2
            // 
            complemento2.DropDownStyle = ComboBoxStyle.DropDownList;
            complemento2.FormattingEnabled = true;
            complemento2.Items.AddRange(new object[] { "" });
            complemento2.Location = new Point(625, 27);
            complemento2.Name = "complemento2";
            complemento2.Size = new Size(121, 23);
            complemento2.TabIndex = 28;
            complemento2.SelectedIndexChanged += complemento2_SelectedIndexChanged;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(316, 73);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(32, 15);
            labelTotal.TabIndex = 29;
            labelTotal.Text = "Total";
            // 
            // totalSTR
            // 
            totalSTR.AutoSize = true;
            totalSTR.Location = new Point(326, 107);
            totalSTR.Name = "totalSTR";
            totalSTR.Size = new Size(13, 15);
            totalSTR.TabIndex = 30;
            totalSTR.Text = "0";
            totalSTR.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // totalDEX
            // 
            totalDEX.AutoSize = true;
            totalDEX.Location = new Point(326, 150);
            totalDEX.Name = "totalDEX";
            totalDEX.Size = new Size(13, 15);
            totalDEX.TabIndex = 31;
            totalDEX.Text = "0";
            totalDEX.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // totalCONS
            // 
            totalCONS.AutoSize = true;
            totalCONS.Location = new Point(326, 193);
            totalCONS.Name = "totalCONS";
            totalCONS.Size = new Size(13, 15);
            totalCONS.TabIndex = 32;
            totalCONS.Text = "0";
            totalCONS.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // totalINT
            // 
            totalINT.AutoSize = true;
            totalINT.Location = new Point(326, 236);
            totalINT.Name = "totalINT";
            totalINT.Size = new Size(13, 15);
            totalINT.TabIndex = 33;
            totalINT.Text = "0";
            totalINT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // totalSAB
            // 
            totalSAB.AutoSize = true;
            totalSAB.Location = new Point(326, 280);
            totalSAB.Name = "totalSAB";
            totalSAB.Size = new Size(13, 15);
            totalSAB.TabIndex = 34;
            totalSAB.Text = "0";
            totalSAB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // totalCHA
            // 
            totalCHA.AutoSize = true;
            totalCHA.Location = new Point(326, 323);
            totalCHA.Name = "totalCHA";
            totalCHA.Size = new Size(13, 15);
            totalCHA.TabIndex = 35;
            totalCHA.Text = "0";
            totalCHA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(388, 73);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 36;
            label2.Text = "Modificador";
            // 
            // modSTR
            // 
            modSTR.AutoSize = true;
            modSTR.Location = new Point(417, 107);
            modSTR.Name = "modSTR";
            modSTR.Size = new Size(13, 15);
            modSTR.TabIndex = 37;
            modSTR.Text = "0";
            modSTR.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // modDEX
            // 
            modDEX.AutoSize = true;
            modDEX.Location = new Point(417, 150);
            modDEX.Name = "modDEX";
            modDEX.Size = new Size(13, 15);
            modDEX.TabIndex = 38;
            modDEX.Text = "0";
            modDEX.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // modCONS
            // 
            modCONS.AutoSize = true;
            modCONS.Location = new Point(417, 194);
            modCONS.Name = "modCONS";
            modCONS.Size = new Size(13, 15);
            modCONS.TabIndex = 39;
            modCONS.Text = "0";
            modCONS.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // modINT
            // 
            modINT.AutoSize = true;
            modINT.Location = new Point(417, 236);
            modINT.Name = "modINT";
            modINT.Size = new Size(13, 15);
            modINT.TabIndex = 40;
            modINT.Text = "0";
            modINT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // modSAB
            // 
            modSAB.AutoSize = true;
            modSAB.Location = new Point(417, 279);
            modSAB.Name = "modSAB";
            modSAB.Size = new Size(13, 15);
            modSAB.TabIndex = 41;
            modSAB.Text = "0";
            modSAB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // modCHA
            // 
            modCHA.AutoSize = true;
            modCHA.Location = new Point(417, 322);
            modCHA.Name = "modCHA";
            modCHA.Size = new Size(13, 15);
            modCHA.TabIndex = 42;
            modCHA.Text = "0";
            modCHA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(597, 73);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 43;
            label3.Text = "Saving Throw";
            // 
            // checkSTR
            // 
            checkSTR.AutoSize = true;
            checkSTR.Location = new Point(550, 106);
            checkSTR.Name = "checkSTR";
            checkSTR.Size = new Size(48, 19);
            checkSTR.TabIndex = 44;
            checkSTR.Text = "STR:";
            checkSTR.UseVisualStyleBackColor = true;
            // 
            // checkDEX
            // 
            checkDEX.AutoSize = true;
            checkDEX.Location = new Point(550, 131);
            checkDEX.Name = "checkDEX";
            checkDEX.Size = new Size(50, 19);
            checkDEX.TabIndex = 45;
            checkDEX.Text = "DEX:";
            checkDEX.UseVisualStyleBackColor = true;
            // 
            // checkINT
            // 
            checkINT.AutoSize = true;
            checkINT.Location = new Point(655, 107);
            checkINT.Name = "checkINT";
            checkINT.Size = new Size(47, 19);
            checkINT.TabIndex = 46;
            checkINT.Text = "INT:";
            checkINT.UseVisualStyleBackColor = true;
            // 
            // checkSAB
            // 
            checkSAB.AutoSize = true;
            checkSAB.Location = new Point(655, 131);
            checkSAB.Name = "checkSAB";
            checkSAB.Size = new Size(50, 19);
            checkSAB.TabIndex = 47;
            checkSAB.Text = "SAB:";
            checkSAB.UseVisualStyleBackColor = true;
            // 
            // checkCONS
            // 
            checkCONS.AutoSize = true;
            checkCONS.Location = new Point(550, 156);
            checkCONS.Name = "checkCONS";
            checkCONS.Size = new Size(61, 19);
            checkCONS.TabIndex = 48;
            checkCONS.Text = "CONS:";
            checkCONS.UseVisualStyleBackColor = true;
            // 
            // checkCHA
            // 
            checkCHA.AutoSize = true;
            checkCHA.Location = new Point(655, 156);
            checkCHA.Name = "checkCHA";
            checkCHA.Size = new Size(54, 19);
            checkCHA.TabIndex = 49;
            checkCHA.Text = "CHA:";
            checkCHA.UseVisualStyleBackColor = true;
            // 
            // saveSTR
            // 
            saveSTR.AutoSize = true;
            saveSTR.Location = new Point(608, 107);
            saveSTR.Name = "saveSTR";
            saveSTR.Size = new Size(18, 15);
            saveSTR.TabIndex = 50;
            saveSTR.Text = "-1";
            // 
            // saveCONS
            // 
            saveCONS.AutoSize = true;
            saveCONS.Location = new Point(609, 157);
            saveCONS.Name = "saveCONS";
            saveCONS.Size = new Size(18, 15);
            saveCONS.TabIndex = 51;
            saveCONS.Text = "-1";
            // 
            // saveDEX
            // 
            saveDEX.AutoSize = true;
            saveDEX.Location = new Point(608, 132);
            saveDEX.Name = "saveDEX";
            saveDEX.Size = new Size(18, 15);
            saveDEX.TabIndex = 52;
            saveDEX.Text = "-1";
            // 
            // saveINT
            // 
            saveINT.AutoSize = true;
            saveINT.Location = new Point(709, 107);
            saveINT.Name = "saveINT";
            saveINT.Size = new Size(18, 15);
            saveINT.TabIndex = 53;
            saveINT.Text = "-1";
            // 
            // saveSAB
            // 
            saveSAB.AutoSize = true;
            saveSAB.Location = new Point(708, 132);
            saveSAB.Name = "saveSAB";
            saveSAB.Size = new Size(18, 15);
            saveSAB.TabIndex = 54;
            saveSAB.Text = "-1";
            // 
            // saveCHA
            // 
            saveCHA.AutoSize = true;
            saveCHA.Location = new Point(708, 157);
            saveCHA.Name = "saveCHA";
            saveCHA.Size = new Size(18, 15);
            saveCHA.TabIndex = 55;
            saveCHA.Text = "-1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(616, 193);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 56;
            label4.Text = "Pericias";
            // 
            // perception
            // 
            perception.AutoSize = true;
            perception.Location = new Point(765, 269);
            perception.Name = "perception";
            perception.Size = new Size(18, 15);
            perception.TabIndex = 68;
            perception.Text = "-1";
            perception.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nature
            // 
            nature.AutoSize = true;
            nature.Location = new Point(765, 244);
            nature.Name = "nature";
            nature.Size = new Size(18, 15);
            nature.TabIndex = 67;
            nature.Text = "-1";
            nature.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // medicine
            // 
            medicine.AutoSize = true;
            medicine.Location = new Point(765, 219);
            medicine.Name = "medicine";
            medicine.Size = new Size(18, 15);
            medicine.TabIndex = 66;
            medicine.Text = "-1";
            medicine.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // animalHanding
            // 
            animalHanding.AutoSize = true;
            animalHanding.Location = new Point(610, 244);
            animalHanding.Name = "animalHanding";
            animalHanding.Size = new Size(18, 15);
            animalHanding.TabIndex = 65;
            animalHanding.Text = "-1";
            animalHanding.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // arcana
            // 
            arcana.AutoSize = true;
            arcana.Location = new Point(611, 269);
            arcana.Name = "arcana";
            arcana.Size = new Size(18, 15);
            arcana.TabIndex = 64;
            arcana.Text = "-1";
            arcana.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // acrobatics
            // 
            acrobatics.AutoSize = true;
            acrobatics.Location = new Point(610, 219);
            acrobatics.Name = "acrobatics";
            acrobatics.Size = new Size(18, 15);
            acrobatics.TabIndex = 63;
            acrobatics.Text = "-1";
            acrobatics.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkBoxPercep
            // 
            checkBoxPercep.AutoSize = true;
            checkBoxPercep.Location = new Point(657, 268);
            checkBoxPercep.Name = "checkBoxPercep";
            checkBoxPercep.Size = new Size(86, 19);
            checkBoxPercep.TabIndex = 62;
            checkBoxPercep.Text = "Perception:";
            checkBoxPercep.UseVisualStyleBackColor = true;
            // 
            // checkBoxArcana
            // 
            checkBoxArcana.AutoSize = true;
            checkBoxArcana.Location = new Point(491, 268);
            checkBoxArcana.Name = "checkBoxArcana";
            checkBoxArcana.Size = new Size(66, 19);
            checkBoxArcana.TabIndex = 61;
            checkBoxArcana.Text = "Arcana:";
            checkBoxArcana.UseVisualStyleBackColor = true;
            // 
            // checkBoxNature
            // 
            checkBoxNature.AutoSize = true;
            checkBoxNature.Location = new Point(657, 243);
            checkBoxNature.Name = "checkBoxNature";
            checkBoxNature.Size = new Size(65, 19);
            checkBoxNature.TabIndex = 60;
            checkBoxNature.Text = "Nature:";
            checkBoxNature.UseVisualStyleBackColor = true;
            // 
            // checkBoxMedicine
            // 
            checkBoxMedicine.AutoSize = true;
            checkBoxMedicine.Location = new Point(657, 219);
            checkBoxMedicine.Name = "checkBoxMedicine";
            checkBoxMedicine.Size = new Size(78, 19);
            checkBoxMedicine.TabIndex = 59;
            checkBoxMedicine.Text = "Medicine:";
            checkBoxMedicine.UseVisualStyleBackColor = true;
            // 
            // checkBoxAnimal
            // 
            checkBoxAnimal.AutoSize = true;
            checkBoxAnimal.Location = new Point(491, 243);
            checkBoxAnimal.Name = "checkBoxAnimal";
            checkBoxAnimal.Size = new Size(116, 19);
            checkBoxAnimal.TabIndex = 58;
            checkBoxAnimal.Text = "Animal Handing:";
            checkBoxAnimal.UseVisualStyleBackColor = true;
            // 
            // checkBoxAcro
            // 
            checkBoxAcro.AutoSize = true;
            checkBoxAcro.Location = new Point(491, 218);
            checkBoxAcro.Name = "checkBoxAcro";
            checkBoxAcro.Size = new Size(85, 19);
            checkBoxAcro.TabIndex = 57;
            checkBoxAcro.Text = "Acrobatics:";
            checkBoxAcro.UseVisualStyleBackColor = true;
            // 
            // religion
            // 
            religion.AutoSize = true;
            religion.Location = new Point(765, 342);
            religion.Name = "religion";
            religion.Size = new Size(18, 15);
            religion.TabIndex = 80;
            religion.Text = "-1";
            religion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // persuasion
            // 
            persuasion.AutoSize = true;
            persuasion.Location = new Point(765, 317);
            persuasion.Name = "persuasion";
            persuasion.Size = new Size(18, 15);
            persuasion.TabIndex = 79;
            persuasion.Text = "-1";
            persuasion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // performace
            // 
            performace.AutoSize = true;
            performace.Location = new Point(765, 295);
            performace.Name = "performace";
            performace.Size = new Size(18, 15);
            performace.TabIndex = 78;
            performace.Text = "-1";
            performace.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // deception
            // 
            deception.AutoSize = true;
            deception.Location = new Point(610, 317);
            deception.Name = "deception";
            deception.Size = new Size(18, 15);
            deception.TabIndex = 77;
            deception.Text = "-1";
            deception.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // history
            // 
            history.AutoSize = true;
            history.Location = new Point(611, 342);
            history.Name = "history";
            history.Size = new Size(18, 15);
            history.TabIndex = 76;
            history.Text = "-1";
            history.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // athletic
            // 
            athletic.AutoSize = true;
            athletic.Location = new Point(610, 294);
            athletic.Name = "athletic";
            athletic.Size = new Size(18, 15);
            athletic.TabIndex = 75;
            athletic.Text = "-1";
            athletic.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkBoxReligion
            // 
            checkBoxReligion.AutoSize = true;
            checkBoxReligion.Location = new Point(657, 341);
            checkBoxReligion.Name = "checkBoxReligion";
            checkBoxReligion.Size = new Size(72, 19);
            checkBoxReligion.TabIndex = 74;
            checkBoxReligion.Text = "Religion:";
            checkBoxReligion.UseVisualStyleBackColor = true;
            // 
            // checkBoxHistory
            // 
            checkBoxHistory.AutoSize = true;
            checkBoxHistory.Location = new Point(491, 341);
            checkBoxHistory.Name = "checkBoxHistory";
            checkBoxHistory.Size = new Size(67, 19);
            checkBoxHistory.TabIndex = 73;
            checkBoxHistory.Text = "History:";
            checkBoxHistory.UseVisualStyleBackColor = true;
            // 
            // checkBoxPersua
            // 
            checkBoxPersua.AutoSize = true;
            checkBoxPersua.Location = new Point(657, 316);
            checkBoxPersua.Name = "checkBoxPersua";
            checkBoxPersua.Size = new Size(86, 19);
            checkBoxPersua.TabIndex = 72;
            checkBoxPersua.Text = "Persuasion:";
            checkBoxPersua.UseVisualStyleBackColor = true;
            // 
            // checkBoxPerfor
            // 
            checkBoxPerfor.AutoSize = true;
            checkBoxPerfor.Location = new Point(657, 294);
            checkBoxPerfor.Name = "checkBoxPerfor";
            checkBoxPerfor.Size = new Size(90, 19);
            checkBoxPerfor.TabIndex = 71;
            checkBoxPerfor.Text = "Performace:";
            checkBoxPerfor.UseVisualStyleBackColor = true;
            // 
            // checkBoxDeception
            // 
            checkBoxDeception.AutoSize = true;
            checkBoxDeception.Location = new Point(491, 316);
            checkBoxDeception.Name = "checkBoxDeception";
            checkBoxDeception.Size = new Size(83, 19);
            checkBoxDeception.TabIndex = 70;
            checkBoxDeception.Text = "Deception:";
            checkBoxDeception.UseVisualStyleBackColor = true;
            // 
            // checkBoxAthletic
            // 
            checkBoxAthletic.AutoSize = true;
            checkBoxAthletic.Location = new Point(491, 293);
            checkBoxAthletic.Name = "checkBoxAthletic";
            checkBoxAthletic.Size = new Size(75, 19);
            checkBoxAthletic.TabIndex = 69;
            checkBoxAthletic.Text = "Athletics:";
            checkBoxAthletic.UseVisualStyleBackColor = true;
            // 
            // survival
            // 
            survival.AutoSize = true;
            survival.Location = new Point(765, 416);
            survival.Name = "survival";
            survival.Size = new Size(18, 15);
            survival.TabIndex = 92;
            survival.Text = "-1";
            survival.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // stealth
            // 
            stealth.AutoSize = true;
            stealth.Location = new Point(765, 391);
            stealth.Name = "stealth";
            stealth.Size = new Size(18, 15);
            stealth.TabIndex = 91;
            stealth.Text = "-1";
            stealth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sleight
            // 
            sleight.AutoSize = true;
            sleight.Location = new Point(765, 367);
            sleight.Name = "sleight";
            sleight.Size = new Size(18, 15);
            sleight.TabIndex = 90;
            sleight.Text = "-1";
            sleight.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // intimidation
            // 
            intimidation.AutoSize = true;
            intimidation.Location = new Point(610, 391);
            intimidation.Name = "intimidation";
            intimidation.Size = new Size(18, 15);
            intimidation.TabIndex = 89;
            intimidation.Text = "-1";
            intimidation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // investigation
            // 
            investigation.AutoSize = true;
            investigation.Location = new Point(611, 416);
            investigation.Name = "investigation";
            investigation.Size = new Size(18, 15);
            investigation.TabIndex = 88;
            investigation.Text = "-1";
            investigation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // insight
            // 
            insight.AutoSize = true;
            insight.Location = new Point(610, 366);
            insight.Name = "insight";
            insight.Size = new Size(18, 15);
            insight.TabIndex = 87;
            insight.Text = "-1";
            insight.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkBoxSurvival
            // 
            checkBoxSurvival.AutoSize = true;
            checkBoxSurvival.Location = new Point(657, 415);
            checkBoxSurvival.Name = "checkBoxSurvival";
            checkBoxSurvival.Size = new Size(70, 19);
            checkBoxSurvival.TabIndex = 86;
            checkBoxSurvival.Text = "Survival:";
            checkBoxSurvival.UseVisualStyleBackColor = true;
            // 
            // checkBoxInvesti
            // 
            checkBoxInvesti.AutoSize = true;
            checkBoxInvesti.Location = new Point(491, 415);
            checkBoxInvesti.Name = "checkBoxInvesti";
            checkBoxInvesti.Size = new Size(97, 19);
            checkBoxInvesti.TabIndex = 85;
            checkBoxInvesti.Text = "Investigation:";
            checkBoxInvesti.UseVisualStyleBackColor = true;
            // 
            // checkBoxStealth
            // 
            checkBoxStealth.AutoSize = true;
            checkBoxStealth.Location = new Point(657, 390);
            checkBoxStealth.Name = "checkBoxStealth";
            checkBoxStealth.Size = new Size(65, 19);
            checkBoxStealth.TabIndex = 84;
            checkBoxStealth.Text = "Stealth:";
            checkBoxStealth.UseVisualStyleBackColor = true;
            // 
            // checkBoxSleight
            // 
            checkBoxSleight.AutoSize = true;
            checkBoxSleight.Location = new Point(657, 366);
            checkBoxSleight.Name = "checkBoxSleight";
            checkBoxSleight.Size = new Size(111, 19);
            checkBoxSleight.TabIndex = 83;
            checkBoxSleight.Text = "Sleight of Hand:";
            checkBoxSleight.UseVisualStyleBackColor = true;
            // 
            // checkBoxIntimidate
            // 
            checkBoxIntimidate.AutoSize = true;
            checkBoxIntimidate.Location = new Point(491, 390);
            checkBoxIntimidate.Name = "checkBoxIntimidate";
            checkBoxIntimidate.Size = new Size(94, 19);
            checkBoxIntimidate.TabIndex = 82;
            checkBoxIntimidate.Text = "Intimidation:";
            checkBoxIntimidate.UseVisualStyleBackColor = true;
            // 
            // checkBoxInsight
            // 
            checkBoxInsight.AutoSize = true;
            checkBoxInsight.Location = new Point(491, 365);
            checkBoxInsight.Name = "checkBoxInsight";
            checkBoxInsight.Size = new Size(65, 19);
            checkBoxInsight.TabIndex = 81;
            checkBoxInsight.Text = "Insight:";
            checkBoxInsight.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 481);
            Controls.Add(survival);
            Controls.Add(stealth);
            Controls.Add(sleight);
            Controls.Add(intimidation);
            Controls.Add(investigation);
            Controls.Add(insight);
            Controls.Add(checkBoxSurvival);
            Controls.Add(checkBoxInvesti);
            Controls.Add(checkBoxStealth);
            Controls.Add(checkBoxSleight);
            Controls.Add(checkBoxIntimidate);
            Controls.Add(checkBoxInsight);
            Controls.Add(religion);
            Controls.Add(persuasion);
            Controls.Add(performace);
            Controls.Add(deception);
            Controls.Add(history);
            Controls.Add(athletic);
            Controls.Add(checkBoxReligion);
            Controls.Add(checkBoxHistory);
            Controls.Add(checkBoxPersua);
            Controls.Add(checkBoxPerfor);
            Controls.Add(checkBoxDeception);
            Controls.Add(checkBoxAthletic);
            Controls.Add(perception);
            Controls.Add(nature);
            Controls.Add(medicine);
            Controls.Add(animalHanding);
            Controls.Add(arcana);
            Controls.Add(acrobatics);
            Controls.Add(checkBoxPercep);
            Controls.Add(checkBoxArcana);
            Controls.Add(checkBoxNature);
            Controls.Add(checkBoxMedicine);
            Controls.Add(checkBoxAnimal);
            Controls.Add(checkBoxAcro);
            Controls.Add(label4);
            Controls.Add(saveCHA);
            Controls.Add(saveSAB);
            Controls.Add(saveINT);
            Controls.Add(saveDEX);
            Controls.Add(saveCONS);
            Controls.Add(saveSTR);
            Controls.Add(checkCHA);
            Controls.Add(checkCONS);
            Controls.Add(checkSAB);
            Controls.Add(checkINT);
            Controls.Add(checkDEX);
            Controls.Add(checkSTR);
            Controls.Add(label3);
            Controls.Add(modCHA);
            Controls.Add(modSAB);
            Controls.Add(modINT);
            Controls.Add(modCONS);
            Controls.Add(modDEX);
            Controls.Add(modSTR);
            Controls.Add(label2);
            Controls.Add(totalCHA);
            Controls.Add(totalSAB);
            Controls.Add(totalINT);
            Controls.Add(totalCONS);
            Controls.Add(totalDEX);
            Controls.Add(totalSTR);
            Controls.Add(labelTotal);
            Controls.Add(complemento2);
            Controls.Add(labelComp2);
            Controls.Add(complemento1);
            Controls.Add(labelComp1);
            Controls.Add(label7);
            Controls.Add(bonusCHA);
            Controls.Add(bonusSAB);
            Controls.Add(bonusINT);
            Controls.Add(bonusCONS);
            Controls.Add(bonusDEX);
            Controls.Add(bonusSTR);
            Controls.Add(label1);
            Controls.Add(labelClasse);
            Controls.Add(Classe);
            Controls.Add(labelLimite);
            Controls.Add(labelCHA);
            Controls.Add(labelSAB);
            Controls.Add(labelINT);
            Controls.Add(labelCONS);
            Controls.Add(labelDEX);
            Controls.Add(labelSTR);
            Controls.Add(CHA);
            Controls.Add(SAB);
            Controls.Add(INT);
            Controls.Add(CONS);
            Controls.Add(DEX);
            Controls.Add(STR);
            Name = "Form1";
            Text = "D&D 5e: Calculando a build";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)STR).EndInit();
            ((System.ComponentModel.ISupportInitialize)DEX).EndInit();
            ((System.ComponentModel.ISupportInitialize)CONS).EndInit();
            ((System.ComponentModel.ISupportInitialize)INT).EndInit();
            ((System.ComponentModel.ISupportInitialize)SAB).EndInit();
            ((System.ComponentModel.ISupportInitialize)CHA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown STR;
        private NumericUpDown DEX;
        private NumericUpDown CONS;
        private NumericUpDown INT;
        private NumericUpDown SAB;
        private NumericUpDown CHA;
        private Label labelSTR;
        private Label labelDEX;
        private Label labelCONS;
        private Label labelINT;
        private Label labelSAB;
        private Label labelCHA;
        private Label labelLimite;
        private ComboBox Classe;
        private Label labelClasse;
        private Label label1;
        private Label bonusSTR;
        private Label bonusDEX;
        private Label bonusCONS;
        private Label bonusINT;
        private Label bonusSAB;
        private Label bonusCHA;
        private Label label7;
        private Label labelComp1;
        private ComboBox complemento1;
        private Label labelComp2;
        private ComboBox complemento2;
        private Label labelTotal;
        private Label totalSTR;
        private Label totalDEX;
        private Label totalCONS;
        private Label totalINT;
        private Label totalSAB;
        private Label totalCHA;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private Label modSTR;
        private Label modDEX;
        private Label modCONS;
        private Label modINT;
        private Label modSAB;
        private Label modCHA;
        private Label label3;
        private CheckBox checkSTR;
        private CheckBox checkDEX;
        private CheckBox checkINT;
        private CheckBox checkSAB;
        private CheckBox checkCONS;
        private CheckBox checkCHA;
        private Label saveSTR;
        private Label saveCONS;
        private Label saveDEX;
        private Label saveINT;
        private Label saveSAB;
        private Label saveCHA;
        private Label label4;
        private Label perception;
        private Label nature;
        private Label medicine;
        private Label animalHanding;
        private Label arcana;
        private Label acrobatics;
        private CheckBox checkBoxPercep;
        private CheckBox checkBoxArcana;
        private CheckBox checkBoxNature;
        private CheckBox checkBoxMedicine;
        private CheckBox checkBoxAnimal;
        private CheckBox checkBoxAcro;
        private Label religion;
        private Label persuasion;
        private Label performace;
        private Label deception;
        private Label history;
        private Label athletic;
        private CheckBox checkBoxReligion;
        private CheckBox checkBoxHistory;
        private CheckBox checkBoxPersua;
        private CheckBox checkBoxPerfor;
        private CheckBox checkBoxDeception;
        private CheckBox checkBoxAthletic;
        private Label survival;
        private Label stealth;
        private Label sleight;
        private Label intimidation;
        private Label investigation;
        private Label insight;
        private CheckBox checkBoxSurvival;
        private CheckBox checkBoxInvesti;
        private CheckBox checkBoxStealth;
        private CheckBox checkBoxSleight;
        private CheckBox checkBoxIntimidate;
        private CheckBox checkBoxInsight;
    }
}
