namespace FichaRPG2
{
    public partial class Form1 : Form
    {
        int pro = 2;

        public Form1()
        {
            InitializeComponent();

            STR.ValueChanged += STR_ValueChanged;
            DEX.ValueChanged += STR_ValueChanged;
            CONS.ValueChanged += STR_ValueChanged;
            INT.ValueChanged += STR_ValueChanged;
            SAB.ValueChanged += STR_ValueChanged;
            CHA.ValueChanged += STR_ValueChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Classe_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selecionado = Classe.SelectedItem.ToString();

            switch (selecionado)
            {
                case "Humano":
                    bonusSTR.Text = "1";
                    bonusDEX.Text = "1";
                    bonusCONS.Text = "1";
                    bonusINT.Text = "1";
                    bonusSAB.Text = "1";
                    bonusCHA.Text = "1";
                    break;

                case "Elfo":
                    bonusSTR.Text = "0";
                    bonusDEX.Text = "2";
                    bonusCONS.Text = "0";
                    bonusINT.Text = "0";
                    bonusSAB.Text = "0";
                    bonusCHA.Text = "0";
                    break;

                case "Anão":
                    bonusSTR.Text = "0";
                    bonusDEX.Text = "0";
                    bonusCONS.Text = "2";
                    bonusINT.Text = "0";
                    bonusSAB.Text = "0";
                    bonusCHA.Text = "0";
                    break;

                case "Draconato":
                    bonusSTR.Text = "2";
                    bonusDEX.Text = "0";
                    bonusCONS.Text = "0";
                    bonusINT.Text = "0";
                    bonusSAB.Text = "0";
                    bonusCHA.Text = "1";
                    break;

                case "Meio Elfo":
                    bonusSTR.Text = "0";
                    bonusDEX.Text = "0";
                    bonusCONS.Text = "0";
                    bonusINT.Text = "0";
                    bonusSAB.Text = "0";
                    bonusCHA.Text = "2";
                    complemento1.Items.Add("STR");
                    complemento1.Items.Add("DEX");
                    complemento1.Items.Add("CONS");
                    complemento1.Items.Add("INT");
                    complemento1.Items.Add("SAB");
                    break;

                case "Halfling":
                    bonusSTR.Text = "0";
                    bonusDEX.Text = "2";
                    bonusCONS.Text = "0";
                    bonusINT.Text = "0";
                    bonusSAB.Text = "0";
                    bonusCHA.Text = "0";
                    break;

                case "Tielfling":
                    bonusSTR.Text = "0";
                    bonusDEX.Text = "0";
                    bonusCONS.Text = "0";
                    bonusINT.Text = "1";
                    bonusSAB.Text = "0";
                    bonusCHA.Text = "2";
                    break;

                case "Meio Orc":
                    bonusSTR.Text = "2";
                    bonusDEX.Text = "0";
                    bonusCONS.Text = "1";
                    bonusINT.Text = "0";
                    bonusSAB.Text = "0";
                    bonusCHA.Text = "0";
                    break;

                case "Gnomo":
                    bonusSTR.Text = "0";
                    bonusDEX.Text = "0";
                    bonusCONS.Text = "0";
                    bonusINT.Text = "2";
                    bonusSAB.Text = "0";
                    bonusCHA.Text = "0";
                    break;

                default:
                    bonusSTR.Text = "0";
                    bonusDEX.Text = "0";
                    bonusCONS.Text = "0";
                    bonusINT.Text = "0";
                    bonusSAB.Text = "0";
                    bonusCHA.Text = "0";
                    break;

            }
        }

        private void complemento1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (complemento1 != null)
            {
                atualizarTexto1(complemento1.SelectedItem.ToString());
            }
        }
        private void atualizarTexto1(string selecionada)
        {
            bonusSTR.Text = "0";
            bonusDEX.Text = "0";
            bonusCONS.Text = "0";
            bonusINT.Text = "0";
            bonusSAB.Text = "0";

            switch (selecionada)
            {
                case "STR":
                    bonusSTR.Text = "1";
                    complemento2.Items.Clear();
                    complemento2.Items.Add("DEX");
                    complemento2.Items.Add("CONS");
                    complemento2.Items.Add("INT");
                    complemento2.Items.Add("SAB");
                    break;

                case "DEX":
                    bonusDEX.Text = "1";
                    complemento2.Items.Clear();
                    complemento2.Items.Add("STR");
                    complemento2.Items.Add("CONS");
                    complemento2.Items.Add("INT");
                    complemento2.Items.Add("SAB");
                    break;

                case "CONS":
                    bonusCONS.Text = "1";
                    complemento2.Items.Clear();
                    complemento2.Items.Add("STR");
                    complemento2.Items.Add("DEX");
                    complemento2.Items.Add("INT");
                    complemento2.Items.Add("SAB");
                    break;

                case "INT":
                    bonusINT.Text = "1";
                    complemento2.Items.Clear();
                    complemento2.Items.Add("STR");
                    complemento2.Items.Add("DEX");
                    complemento2.Items.Add("CONS");
                    complemento2.Items.Add("SAB");
                    break;

                case "SAB":
                    bonusSAB.Text = "1";
                    complemento2.Items.Clear();
                    complemento2.Items.Add("STR");
                    complemento2.Items.Add("DEX");
                    complemento2.Items.Add("CONS");
                    complemento2.Items.Add("INT");
                    break;

                default:
                    break;
            }
        }

        private void complemento2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selecionado = complemento2.SelectedItem.ToString();

            switch (selecionado)
            {
                case "STR":
                    bonusSTR.Text = "1";
                    complemento2.Items.Clear();
                    break;

                case "DEX":
                    bonusDEX.Text = "1";
                    complemento2.Items.Clear();
                    break;

                case "CONS":
                    bonusCONS.Text = "1";
                    complemento2.Items.Clear();
                    break;

                case "INT":
                    bonusINT.Text = "1";
                    complemento2.Items.Clear();
                    break;

                case "SAB":
                    bonusSAB.Text = "1";
                    complemento2.Items.Clear();
                    break;

                default:
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            atualizarCoisas();
        }

        private void atualizarCoisas()
        {
            int nSTR = int.Parse(bonusSTR.Text);
            int nDEX = int.Parse(bonusDEX.Text);
            int nCONS = int.Parse(bonusCONS.Text);
            int nINT = int.Parse(bonusINT.Text);
            int nSAB = int.Parse(bonusSAB.Text);
            int nCHA = int.Parse(bonusCHA.Text);

            int somaSTR = (int)(STR.Value + nSTR);
            int somaDEX = (int)(DEX.Value + nDEX);
            int somaCONS = (int)(CONS.Value + nCONS);
            int somaINT = (int)(INT.Value + nINT);
            int somaSAB = (int)(SAB.Value + nSAB);
            int somaCHA = (int)(CHA.Value + nCHA);

            totalSTR.Text = somaSTR.ToString();
            totalDEX.Text = somaDEX.ToString();
            totalCONS.Text = somaCONS.ToString();
            totalINT.Text = somaINT.ToString();
            totalSAB.Text = somaSAB.ToString();
            totalCHA.Text = somaCHA.ToString();

            int tSTR = int.Parse(totalSTR.Text);
            int tDEX = int.Parse(totalDEX.Text);
            int tCONS = int.Parse(totalCONS.Text);
            int tINT = int.Parse(totalINT.Text);
            int tSAB = int.Parse(totalSAB.Text);
            int tCHA = int.Parse(totalCHA.Text);

            //MODIFICADOR FORÇA
            if (tSTR < 10)
            {
                modSTR.Text = "-1";
            }
            else if (tSTR < 12)
            {
                modSTR.Text = "0";
            }
            else if (tSTR < 14)
            {
                modSTR.Text = "1";
            }
            else if (tSTR < 16)
            {
                modSTR.Text = "2";
            }
            else
            {
                modSTR.Text = "3";
            }

            //MODIFICADOR DESTREZA
            if (tDEX < 10)
            {
                modDEX.Text = "-1";
            }
            else if (tDEX < 12)
            {
                modDEX.Text = "0";
            }
            else if (tDEX < 14)
            {
                modDEX.Text = "1";
            }
            else if (tDEX < 16)
            {
                modDEX.Text = "2";
            }
            else
            {
                modDEX.Text = "3";
            }

            //MODIFICADOR CONSTITUIÇÃO
            if (tCONS < 10)
            {
                modCONS.Text = "-1";
            }
            else if (tCONS < 12)
            {
                modCONS.Text = "0";
            }
            else if (tCONS < 14)
            {
                modCONS.Text = "1";
            }
            else if (tCONS < 16)
            {
                modCONS.Text = "2";
            }
            else
            {
                modCONS.Text = "3";
            }

            //MODIFICADOR INTELIGENCIA
            if (tINT < 10)
            {
                modINT.Text = "-1";
            }
            else if (tINT < 12)
            {
                modINT.Text = "0";
            }
            else if (tINT < 14)
            {
                modINT.Text = "1";
            }
            else if (tINT < 16)
            {
                modINT.Text = "2";
            }
            else
            {
                modINT.Text = "3";
            }

            //MODIFICDOR SABEDORIA 
            if (tSAB < 10)
            {
                modSAB.Text = "-1";
            }
            else if (tSAB < 12)
            {
                modSAB.Text = "0";
            }
            else if (tSAB < 14)
            {
                modSAB.Text = "1";
            }
            else if (tSAB < 16)
            {
                modSAB.Text = "2";
            }
            else
            {
                modSAB.Text = "3";
            }

            //MODIFICADOR CARISMA
            if (tCHA < 10)
            {
                modCHA.Text = "-1";
            }
            else if (tCHA < 12)
            {
                modCHA.Text = "0";
            }
            else if (tCHA < 14)
            {
                modCHA.Text = "1";
            }
            else if (tCHA < 16)
            {
                modCHA.Text = "2";
            }
            else
            {
                modCHA.Text = "3";
            }

            int mSTR = int.Parse(modSTR.Text);
            int mDEX = int.Parse(modDEX.Text);
            int mCONS = int.Parse(modCONS.Text);
            int mINT = int.Parse(modINT.Text);
            int mSAB = int.Parse(modSAB.Text);
            int mCHA = int.Parse(modCHA.Text);

            if (checkSTR.Checked)
            {
                mSTR += pro;
            }
            if (checkDEX.Checked)
            {
                mDEX += pro;
            }
            if (checkCONS.Checked)
            {
                mCONS += pro;
            }
            if (checkINT.Checked)
            {
                mINT += pro;
            }
            if (checkSAB.Checked)
            {
                mSAB += pro;
            }
            if (checkCHA.Checked)
            {
                mCHA += pro;
            }

            saveSTR.Text = mSTR.ToString();
            saveDEX.Text = mDEX.ToString();
            saveCONS.Text = mCONS.ToString();
            saveINT.Text = mINT.ToString();
            saveSAB.Text = mSAB.ToString();
            saveCHA.Text = mCHA.ToString();

            int pAcro = int.Parse(modDEX.Text);
            int pAnimal = int.Parse(modSAB.Text);
            int pArcana = int.Parse(modINT.Text);
            int pAthle = int.Parse(modSTR.Text);
            int pDecep = int.Parse(modCHA.Text);
            int pHist = int.Parse(modINT.Text);
            int pInsight = int.Parse(modSAB.Text);
            int pIntimidation = int.Parse(modCHA.Text);
            int pInves = int.Parse(modINT.Text);
            int pMedi = int.Parse(modSAB.Text);
            int pNatu = int.Parse(modINT.Text);
            int pPercep = int.Parse(modSAB.Text);
            int pPerfor = int.Parse(modCHA.Text);
            int pPersua = int.Parse(modCHA.Text);
            int pReligi = int.Parse(modINT.Text);
            int pSlei = int.Parse(modDEX.Text);
            int pStealth = int.Parse(modDEX.Text);
            int pSurvival = int.Parse(modSAB.Text);



            if (checkBoxAcro.Checked)
            {
                pAcro += pro;
            }
            if (checkBoxAnimal.Checked)
            {
                pAnimal += pro;
            }
            if (checkBoxArcana.Checked)
            {
                pArcana += pro;
            }
            if (checkBoxAthletic.Checked)
            {
                pAthle += pro;
            }
            if (checkBoxDeception.Checked)
            {
                pDecep += pro;
            }
            if (checkBoxHistory.Checked)
            {
                pHist += pro;
            }
            if (checkBoxInsight.Checked)
            {
                pInsight += pro;
            }
            if (checkBoxIntimidate.Checked)
            {
                pIntimidation += pro;
            }
            if (checkBoxInvesti.Checked)
            {
                pInves += pro;
            }
            if (checkBoxMedicine.Checked)
            {
                pMedi += pro;
            }
            if (checkBoxNature.Checked)
            {
                pNatu += pro;
            }
            if (checkBoxPercep.Checked)
            {
                pPercep += pro;
            }
            if (checkBoxPerfor.Checked)
            {
                pPerfor += pro;
            }
            if (checkBoxPersua.Checked)
            {
                pPersua += pro;
            }
            if (checkBoxReligion.Checked)
            {
                pReligi += pro;
            }
            if (checkBoxSleight.Checked)
            {
                pSlei += pro;
            }
            if (checkBoxStealth.Checked)
            {
                pStealth += pro;
            }
            if (checkBoxSurvival.Checked)
            {
                pSurvival += pro;
            }

            acrobatics.Text = pAcro.ToString();
            animalHanding.Text = pAnimal.ToString();
            arcana.Text = pArcana.ToString();
            athletic.Text = pAthle.ToString();
            deception.Text = pDecep.ToString();
            history.Text = pHist.ToString();
            insight.Text = pInsight.ToString();
            intimidation.Text = pIntimidation.ToString();
            investigation.Text = pInves.ToString();
            medicine.Text = pMedi.ToString();
            nature.Text = pNatu.ToString();
            perception.Text = pPercep.ToString();
            performace.Text = pPerfor.ToString();
            persuasion.Text = pPersua.ToString();
            religion.Text = pReligi.ToString();
            sleight.Text = pSlei.ToString();
            stealth.Text = pStealth.ToString();
            survival.Text = pSurvival.ToString();
        }

        private void custoPontos()
        {
            NumericUpDown[] attributes = new NumericUpDown[]
            {
            STR,
            DEX,
            CONS,
            INT,
            SAB,
            CHA
            };

            int custo = 0;

            foreach (var attribute in attributes)
            {
                int value = (int)attribute.Value;
                custo += calcularCusto(value);
            }

            labelLimite.Text = custo.ToString() + "/27";

            if (custo > 27)
            {
                labelLimite.ForeColor = Color.Red; 
            }
            else
            {
                labelLimite.ForeColor = Color.Black; 
            }
        }

        private int calcularCusto(int value)
        {
            if (value == 8) return 0;
            if (value == 9) return 1;
            if (value == 10) return 2;
            if (value == 11) return 3;
            if (value == 12) return 4;
            if (value == 13) return 5;
            if (value == 14) return 7;
            if (value == 15) return 9;

            return 0; 
        }

        private void STR_ValueChanged(object sender, EventArgs e)
        {
            custoPontos();
        }
    }
}
