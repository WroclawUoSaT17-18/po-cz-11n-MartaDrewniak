using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kostka1
{

    public partial class Oblicz : Form
    {
        #region STRINGI
        int pojemnik_tymczasowy_1;
        int pojemnik_tymczasowy_2;
        int pojemnik_tymczasowy_3;
        int pojemnik_tymczasowy_4;
        int pojemnik_tymczasowy_5;
        int pojemnik_tymczasowy_6;
        int pojemnik_tymczasowy_7;
        int pojemnik_tymczasowy_8;
        int pojemnik_tymczasowy_9;

        int tyl_1;
        int tyl_2;
        int tyl_3;
        int  tyl_4;
        int tyl_5;
        int  tyl_6;
        int tyl_7;
        int tyl_8;
        int tyl_9;

        int gora_1;
        int gora_2;
        int gora_3;
        int gora_4;
        int gora_5;
        int gora_6;
        int gora_7;
        int gora_8;
        int gora_9;

        int dol_1;
        int dol_2;
        int dol_3;
        int dol_4;
        int dol_5;
        int dol_6;
        int dol_7;
        int dol_8;
        int dol_9;

        int przod_1;
        int przod_2;
        int przod_3;
        int przod_4;
        int przod_5;
        int przod_6;
        int przod_7;
        int przod_8;
        int przod_9;

        int prawy_bok_1;
        int prawy_bok_2;
        int prawy_bok_3;
        int prawy_bok_4;
        int prawy_bok_5;
        int prawy_bok_6;
        int prawy_bok_7;
        int prawy_bok_8;
        int prawy_bok_9;

        int lewy_bok_1;
        int lewy_bok_2;
        int lewy_bok_3;
        int lewy_bok_4;
        int lewy_bok_5;
        int lewy_bok_6;
        int lewy_bok_7;
        int lewy_bok_8;
        int lewy_bok_9;

        #endregion
        
        public Oblicz()
        {  InitializeComponent();   }
            
        private void menuStrip15_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {        }


        
        public void button1_Click(object sender, EventArgs e)
        {
            przod_1 = 5;
            przod_2 = 5;
            przod_3 = 5;
            przod_4 = 5;
            przod_5 = 5;
            przod_6 = 5;
            przod_7 = 5;
            przod_8 = 5;
            przod_9 = 5;

            gora_7 = 1;
            gora_8 = 1;
            gora_9 = 1;
            gora_5 = 1;

            dol_1 = 5;
            dol_2 = 5;
            dol_3 = 5;
            dol_5 = 5;

            lewy_bok_3 = 6;
            lewy_bok_6 = 6;
            lewy_bok_5 = 6;
            lewy_bok_9 = 6;

            prawy_bok_1 = 2;
            prawy_bok_4 = 2;
            prawy_bok_5 = 2;
            prawy_bok_7 = 2;

           
          

            if (tyl_1 != 0 && lewy_bok_4 != 0 && prawy_bok_3 != 0 && dol_9 != 0)
            {

                obrot_w_dol();
                #region

                for (int i = 0; i <= 10; i++) //ustawienie kolorowych bokow do okola z gory
                {
                    switch (gora_2) //gora                               
                    {
                        case 1: //niebieski  DOBRZE
                            switch (tyl_2)
                            {
                                case 2:   //czerwony  DOBRZE

                                    switch (przod_5)
                                    {
                                        case 1: // wkładanie niebiesko/czerwonego klocka
                                            obrot_U();
                                            obrot_w_lewo();
                                            wkladanie_rogu_lewy();
                                            MessageBox.Show("U X U R U' R' U' F' U F", "Etap pierwszy - boki");

                                            break;

                                        case 2:
                                            obrot_U();
                                            obrot_U();
                                            wkladanie_rogu_lewy();
                                            MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");

                                            break;
                                        case 5:
                                            obrot_Uprim();
                                            obrot_kostka();
                                            wkladanie_rogu_lewy();
                                            MessageBox.Show("U' X' U R U' R' U' F' U F", "Etap pierwszy - boki");

                                            break;
                                        case 6:
                                            obrot_w_lewo();
                                            obrot_w_lewo();
                                            wkladanie_rogu_lewy();
                                            MessageBox.Show("X X U R U' R' U' F' U F", "Etap pierwszy - boki");
                                            break;
                                    }

                                    break;



                                case 6:  // pomaranczowy DOBRZE
                                    switch (przod_5)
                                    {
                                        case 1: // wkładanie niebiesko/pomaranczowego klocka
                                            obrot_Uprim();
                                            obrot_kostka();
                                            wkladanie_rogu_prawy();
                                            MessageBox.Show("U' X' U R U' R' U' F' U F ", "Etap pierwszy - boki");

                                            break;

                                        case 2:
                                            obrot_kostka();
                                            obrot_kostka();
                                            wkladanie_rogu_prawy();
                                            MessageBox.Show("X X U R U' R' U' F' U F ", "Etap pierwszy - boki");

                                            break;
                                        case 5:
                                            obrot_U();
                                            obrot_w_lewo();
                                            wkladanie_rogu_prawy();
                                            MessageBox.Show("U X U R U' R' U' F' U F ", "Etap pierwszy - boki");

                                            break;
                                        case 6:
                                            obrot_U();
                                            obrot_U();
                                            wkladanie_rogu_prawy();
                                            MessageBox.Show("U U U R U' R' U' F' U F ", "Etap pierwszy - boki");

                                            break;
                                    }

                                    break;
                            }

                            break;


                        case 2: //czerwony   DOBRZE
                            switch (tyl_2)

                            {
                                case 1:   //niebieski DOBRZE 

                                    switch (przod_5)
                                    {
                                        case 1: // wkładanie niebiesko/czerwonego klocka
                                            obrot_U();
                                            obrot_U();
                                            wkladanie_rogu_prawy();
                                            MessageBox.Show("U U U R U' R' U' F' U F ", "Etap pierwszy - boki");

                                            break;

                                        case 2:
                                            obrot_Uprim();
                                            obrot_kostka();
                                            wkladanie_rogu_prawy();
                                            MessageBox.Show("U' X' U R U' R' U' F' U F ", "Etap pierwszy - boki");

                                            break;
                                        case 5:
                                            obrot_w_lewo();
                                            obrot_w_lewo();
                                            wkladanie_rogu_prawy();
                                            MessageBox.Show("X X U R U' R' U' F' U F ", "Etap pierwszy - boki");

                                            break;
                                        case 6:
                                            obrot_U();
                                            obrot_w_lewo();
                                            wkladanie_rogu_prawy();
                                            MessageBox.Show("U X U R U' R' U' F' U F ", "Etap pierwszy - boki");

                                            break;
                                    }

                                    break;



                                case 5: // zielony DOBRZE
                                    switch (przod_5)
                                    {
                                        case 1:
                                            obrot_w_lewo();
                                            obrot_w_lewo();
                                            wkladanie_rogu_lewy();
                                            MessageBox.Show("U X U R U' R' U' F' U F", "Etap pierwszy - boki");
                                            break;

                                        case 2:
                                            obrot_U();
                                            obrot_w_lewo();
                                            wkladanie_rogu_lewy();
                                            MessageBox.Show("U X U R U' R' U' F' U F", "Etap pierwszy - boki");
                                            break;
                                        case 5:
                                            obrot_U();
                                            obrot_U();
                                            wkladanie_rogu_lewy();
                                            MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                            break;
                                        case 6:
                                            obrot_Uprim();
                                            obrot_kostka();
                                            wkladanie_rogu_lewy();
                                            MessageBox.Show("U' X U R U' R' U' F' U F", "Etap pierwszy - boki");
                                            break;
                                    }

                                    break;
                            }

                            break;

                        case 5:  // zielony   DOBRZE
                            switch (tyl_2)
                            {
                                case 2:   //czerwony  DOBRZE

                                    switch (przod_5)
                                    {
                                        case 1: // wkładanie niebiesko/czerwonego klocka
                                            obrot_U();
                                            obrot_w_lewo();
                                            wkladanie_rogu_prawy();
                                            MessageBox.Show("U X U R U' R' U' F' U F", "Etap pierwszy - boki");
                                            break;

                                        case 2:
                                            obrot_U();
                                            obrot_U();
                                            wkladanie_rogu_prawy();
                                            MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                            break;
                                        case 5:
                                            obrot_Uprim();
                                            obrot_kostka();
                                            wkladanie_rogu_prawy();
                                            MessageBox.Show("U' X' U R U' R' U' F' U F", "Etap pierwszy - boki");
                                            break;
                                        case 6:
                                            obrot_w_lewo();
                                            obrot_w_lewo();
                                            wkladanie_rogu_prawy();
                                            MessageBox.Show("X X U R U' R' U' F' U F", "Etap pierwszy - boki");
                                            break;
                                    }

                                    break;



                                case 6:  // pomaranczowy DOBRZE
                                    switch (przod_5)
                                    {
                                        case 1:
                                            obrot_Uprim();
                                            obrot_kostka();
                                            wkladanie_rogu_lewy();
                                            MessageBox.Show("U' X' U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                            break;

                                        case 2:
                                            obrot_kostka();
                                            obrot_kostka();
                                            wkladanie_rogu_lewy();
                                            MessageBox.Show("X X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                            break;
                                        case 5:
                                            obrot_U();
                                            obrot_w_lewo();
                                            wkladanie_rogu_lewy();
                                            MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                            break;
                                        case 6:
                                            obrot_U();
                                            obrot_U();
                                            wkladanie_rogu_lewy();
                                            MessageBox.Show("U U U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                            break;
                                    }

                                    break;
                            }

                            break;


                        case 6:  //pomaranczowy  DOBRZE
                            switch (tyl_2)

                            {
                                case 1:   //niebieski  DOBRZE

                                    switch (przod_5)
                                    {
                                        case 1: // wkładanie niebiesko/czerwonego klocka
                                            obrot_U();
                                            obrot_U();
                                            wkladanie_rogu_lewy();
                                            MessageBox.Show("U U U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                            break;

                                        case 2:
                                            obrot_Uprim();
                                            obrot_kostka();
                                            wkladanie_rogu_lewy();
                                            MessageBox.Show("U' X' U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                            break;
                                        case 5:
                                            obrot_w_lewo();
                                            obrot_w_lewo();
                                            wkladanie_rogu_lewy();
                                            MessageBox.Show("X X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                            break;
                                        case 6:
                                            obrot_U();
                                            obrot_w_lewo();
                                            wkladanie_rogu_lewy();
                                            MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                            break;
                                    }

                                    break;



                                case 5: // zielony  DOBRZE
                                    switch (przod_5)
                                    {
                                        case 1:
                                            obrot_w_lewo();
                                            obrot_w_lewo();
                                            wkladanie_rogu_prawy();
                                            MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                            break;

                                        case 2:
                                            obrot_U();
                                            obrot_w_lewo();
                                            wkladanie_rogu_prawy();
                                            MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                            break;
                                        case 5:
                                            obrot_U();
                                            obrot_U();
                                            wkladanie_rogu_prawy();
                                            MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                            break;
                                        case 6:
                                            obrot_Uprim();
                                            obrot_kostka();
                                            wkladanie_rogu_prawy();
                                            MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                            break;
                                    }
                                    break;
                            }
                            break;
                    }

                    obrot_U();
                }

                for (int i = 0; i <= 10; i++)  //sprawdzanie bokow i ustawianie do okola
                {
                    switch (przod_4)
                    {
                        case 1:

                            #region boki
                            if (przod_4 == przod_5 || lewy_bok_6 == lewy_bok_5)
                                break;

                            wkladanie_rogu_lewy();
                            switch (gora_2) //gora                               
                            {
                                case 1: //niebieski  DOBRZE
                                    switch (tyl_2)
                                    {
                                        case 2:   //czerwony  DOBRZE

                                            switch (przod_5)
                                            {
                                                case 1: // wkładanie niebiesko/czerwonego klocka
                                                    obrot_U();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;

                                                case 2:
                                                    obrot_U();
                                                    obrot_U();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                                case 5:
                                                    obrot_Uprim();
                                                    obrot_kostka();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                                case 6:
                                                    obrot_w_lewo();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                            }

                                            break;



                                        case 6:  // pomaranczowy DOBRZE
                                            switch (przod_5)
                                            {
                                                case 1: // wkładanie niebiesko/pomaranczowego klocka
                                                    obrot_Uprim();
                                                    obrot_kostka();
                                                    wkladanie_rogu_prawy();
                                                    MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;

                                                case 2:
                                                    obrot_kostka();
                                                    obrot_kostka();
                                                    wkladanie_rogu_prawy();
                                                    MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                                case 5:
                                                    obrot_U();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_prawy();
                                                    MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                                case 6:
                                                    obrot_U();
                                                    obrot_U();
                                                    wkladanie_rogu_prawy();
                                                    MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                            }
                                            break;
                                    }
                                    break;


                                case 2: //czerwony   DOBRZE
                                    switch (tyl_2)

                                    {
                                        case 1:   //niebieski DOBRZE 

                                            switch (przod_5)
                                            {
                                                case 1: // wkładanie niebiesko/czerwonego klocka
                                                    obrot_U();
                                                    obrot_U();
                                                    wkladanie_rogu_prawy();
                                                    MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;

                                                case 2:
                                                    obrot_Uprim();
                                                    obrot_kostka();
                                                    wkladanie_rogu_prawy();
                                                    MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                                case 5:
                                                    obrot_w_lewo();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_prawy();
                                                    MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                                case 6:
                                                    obrot_U();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_prawy();
                                                    MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                            }

                                            break;



                                        case 5: // zielony DOBRZE
                                            switch (przod_5)
                                            {
                                                case 1:
                                                    obrot_w_lewo();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;

                                                case 2:
                                                    obrot_U();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                                case 5:
                                                    obrot_U();
                                                    obrot_U();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                                case 6:
                                                    obrot_Uprim();
                                                    obrot_kostka();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                            }

                                            break;
                                    }

                                    break;

                                case 5:  // zielony   DOBRZE
                                    switch (tyl_2)
                                    {
                                        case 2:   //czerwony  DOBRZE

                                            switch (przod_5)
                                            {
                                                case 1: // wkładanie niebiesko/czerwonego klocka
                                                    obrot_U();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_prawy();
                                                    MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;

                                                case 2:
                                                    obrot_U();
                                                    obrot_U();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                                case 5:
                                                    obrot_Uprim();
                                                    obrot_kostka();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                                case 6:
                                                    obrot_w_lewo();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                            }

                                            break;



                                        case 6:  // pomaranczowy DOBRZE
                                            switch (przod_5)
                                            {
                                                case 1:
                                                    obrot_Uprim();
                                                    obrot_kostka();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;

                                                case 2:
                                                    obrot_kostka();
                                                    obrot_kostka();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                                case 5:
                                                    obrot_U();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                                case 6:
                                                    obrot_U();
                                                    obrot_U();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                            }

                                            break;
                                    }

                                    break;


                                case 6:  //pomaranczowy  DOBRZE
                                    switch (tyl_2)

                                    {
                                        case 1:   //niebieski  DOBRZE

                                            switch (przod_5)
                                            {
                                                case 1: // wkładanie niebiesko/czerwonego klocka
                                                    obrot_U();
                                                    obrot_U();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;

                                                case 2:
                                                    obrot_Uprim();
                                                    obrot_kostka();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                                case 5:
                                                    obrot_w_lewo();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                                case 6:
                                                    obrot_U();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                            }

                                            break;



                                        case 5: // zielony  DOBRZE
                                            switch (przod_5)
                                            {
                                                case 1:
                                                    obrot_w_lewo();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;

                                                case 2:
                                                    obrot_U();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                                case 5:
                                                    obrot_U();
                                                    obrot_U();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                                case 6:
                                                    obrot_Uprim();
                                                    obrot_kostka();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                            }

                                            break;
                                    }


                                    break;

                            }
                            #endregion

                            break;

                        case 2:

                            #region boki
                            if (przod_4 == przod_5 || lewy_bok_6 == lewy_bok_5)
                                break;

                            wkladanie_rogu_lewy();
                            switch (gora_2) //gora                               
                            {
                                case 1: //niebieski  DOBRZE
                                    switch (tyl_2)
                                    {
                                        case 2:   //czerwony  DOBRZE

                                            switch (przod_5)
                                            {
                                                case 1: // wkładanie niebiesko/czerwonego klocka
                                                    obrot_U();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;

                                                case 2:
                                                    obrot_U();
                                                    obrot_U();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                                case 5:
                                                    obrot_Uprim();
                                                    obrot_kostka();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                                case 6:
                                                    obrot_w_lewo();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                            }

                                            break;



                                        case 6:  // pomaranczowy DOBRZE
                                            switch (przod_5)
                                            {
                                                case 1: // wkładanie niebiesko/pomaranczowego klocka
                                                    obrot_Uprim();
                                                    obrot_kostka();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;

                                                case 2:
                                                    obrot_kostka();
                                                    obrot_kostka();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                                case 5:
                                                    obrot_U();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                                case 6:
                                                    obrot_U();
                                                    obrot_U();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                            }

                                            break;
                                    }

                                    break;


                                case 2: //czerwony   DOBRZE
                                    switch (tyl_2)

                                    {
                                        case 1:   //niebieski DOBRZE 

                                            switch (przod_5)
                                            {
                                                case 1: // wkładanie niebiesko/czerwonego klocka
                                                    obrot_U();
                                                    obrot_U();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;

                                                case 2:
                                                    obrot_Uprim();
                                                    obrot_kostka();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                                case 5:
                                                    obrot_w_lewo();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                                case 6:
                                                    obrot_U();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                            }

                                            break;



                                        case 5: // zielony DOBRZE
                                            switch (przod_5)
                                            {
                                                case 1:
                                                    obrot_w_lewo();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;

                                                case 2:
                                                    obrot_U();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                                case 5:
                                                    obrot_U();
                                                    obrot_U();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                                case 6:
                                                    obrot_Uprim();
                                                    obrot_kostka();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                            }

                                            break;
                                    }

                                    break;

                                case 5:  // zielony   DOBRZE
                                    switch (tyl_2)
                                    {
                                        case 2:   //czerwony  DOBRZE

                                            switch (przod_5)
                                            {
                                                case 1: // wkładanie niebiesko/czerwonego klocka
                                                    obrot_U();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;

                                                case 2:
                                                    obrot_U();
                                                    obrot_U();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                                case 5:
                                                    obrot_Uprim();
                                                    obrot_kostka();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                                case 6:
                                                    obrot_w_lewo();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                            }

                                            break;



                                        case 6:  // pomaranczowy DOBRZE
                                            switch (przod_5)
                                            {
                                                case 1:
                                                    obrot_Uprim();
                                                    obrot_kostka();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;

                                                case 2:
                                                    obrot_kostka();
                                                    obrot_kostka();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                                case 5:
                                                    obrot_U();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                                case 6:
                                                    obrot_U();
                                                    obrot_U();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                            }

                                            break;
                                    }

                                    break;


                                case 6:  //pomaranczowy  DOBRZE
                                    switch (tyl_2)

                                    {
                                        case 1:   //niebieski  DOBRZE

                                            switch (przod_5)
                                            {
                                                case 1: // wkładanie niebiesko/czerwonego klocka
                                                    obrot_U();
                                                    obrot_U();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;

                                                case 2:
                                                    obrot_Uprim();
                                                    obrot_kostka();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                                case 5:
                                                    obrot_w_lewo();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                                case 6:
                                                    obrot_U();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                            }

                                            break;



                                        case 5: // zielony  DOBRZE
                                            switch (przod_5)
                                            {
                                                case 1:
                                                    obrot_w_lewo();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;

                                                case 2:
                                                    obrot_U();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                                case 5:
                                                    obrot_U();
                                                    obrot_U();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                                case 6:
                                                    obrot_Uprim();
                                                    obrot_kostka();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                            }

                                            break;
                                    }


                                    break;

                            }
                            #endregion

                            break;

                        case 5:

                            #region boki
                            if (przod_4 == przod_5 || lewy_bok_6 == lewy_bok_5)
                                break;

                            wkladanie_rogu_lewy();
                            switch (gora_2) //gora                               
                            {
                                case 1: //niebieski  DOBRZE
                                    switch (tyl_2)
                                    {
                                        case 2:   //czerwony  DOBRZE

                                            switch (przod_5)
                                            {
                                                case 1: // wkładanie niebiesko/czerwonego klocka
                                                    obrot_U();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;

                                                case 2:
                                                    obrot_U();
                                                    obrot_U();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                                case 5:
                                                    obrot_Uprim();
                                                    obrot_kostka();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                                case 6:
                                                    obrot_w_lewo();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                            }

                                            break;



                                        case 6:  // pomaranczowy DOBRZE
                                            switch (przod_5)
                                            {
                                                case 1: // wkładanie niebiesko/pomaranczowego klocka
                                                    obrot_Uprim();
                                                    obrot_kostka();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;

                                                case 2:
                                                    obrot_kostka();
                                                    obrot_kostka();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                                case 5:
                                                    obrot_U();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                                case 6:
                                                    obrot_U();
                                                    obrot_U();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                            }

                                            break;
                                    }

                                    break;


                                case 2: //czerwony   DOBRZE
                                    switch (tyl_2)

                                    {
                                        case 1:   //niebieski DOBRZE 

                                            switch (przod_5)
                                            {
                                                case 1: // wkładanie niebiesko/czerwonego klocka
                                                    obrot_U();
                                                    obrot_U();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;

                                                case 2:
                                                    obrot_Uprim();
                                                    obrot_kostka();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                                case 5:
                                                    obrot_w_lewo();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                                case 6:
                                                    obrot_U();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                            }

                                            break;



                                        case 5: // zielony DOBRZE
                                            switch (przod_5)
                                            {
                                                case 1:
                                                    obrot_w_lewo();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;

                                                case 2:
                                                    obrot_U();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                                case 5:
                                                    obrot_U();
                                                    obrot_U();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                                case 6:
                                                    obrot_Uprim();
                                                    obrot_kostka();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                            }

                                            break;
                                    }

                                    break;

                                case 5:  // zielony   DOBRZE
                                    switch (tyl_2)
                                    {
                                        case 2:   //czerwony  DOBRZE

                                            switch (przod_5)
                                            {
                                                case 1: // wkładanie niebiesko/czerwonego klocka
                                                    obrot_U();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;

                                                case 2:
                                                    obrot_U();
                                                    obrot_U();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                                case 5:
                                                    obrot_Uprim();
                                                    obrot_kostka();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                                case 6:
                                                    obrot_w_lewo();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                            }

                                            break;



                                        case 6:  // pomaranczowy DOBRZE
                                            switch (przod_5)
                                            {
                                                case 1:
                                                    obrot_Uprim();
                                                    obrot_kostka();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;

                                                case 2:
                                                    obrot_kostka();
                                                    obrot_kostka();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                                case 5:
                                                    obrot_U();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                                case 6:
                                                    obrot_U();
                                                    obrot_U();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                            }

                                            break;
                                    }

                                    break;


                                case 6:  //pomaranczowy  DOBRZE
                                    switch (tyl_2)

                                    {
                                        case 1:   //niebieski  DOBRZE

                                            switch (przod_5)
                                            {
                                                case 1: // wkładanie niebiesko/czerwonego klocka
                                                    obrot_U();
                                                    obrot_U();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;

                                                case 2:
                                                    obrot_Uprim();
                                                    obrot_kostka();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                                case 5:
                                                    obrot_w_lewo();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                                case 6:
                                                    obrot_U();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                            }

                                            break;



                                        case 5: // zielony  DOBRZE
                                            switch (przod_5)
                                            {
                                                case 1:
                                                    obrot_w_lewo();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;

                                                case 2:
                                                    obrot_U();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                                case 5:
                                                    obrot_U();
                                                    obrot_U();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                                case 6:
                                                    obrot_Uprim();
                                                    obrot_kostka();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                            }

                                            break;
                                    }


                                    break;

                            }
                            #endregion

                            break;

                        case 6:

                            #region boki
                            if (przod_4 == przod_5 || lewy_bok_6 == lewy_bok_5)
                                break;

                            wkladanie_rogu_lewy();
                            switch (gora_2) //gora                               
                            {
                                case 1: //niebieski  DOBRZE
                                    switch (tyl_2)
                                    {
                                        case 2:   //czerwony  DOBRZE

                                            switch (przod_5)
                                            {
                                                case 1: // wkładanie niebiesko/czerwonego klocka
                                                    obrot_U();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;

                                                case 2:
                                                    obrot_U();
                                                    obrot_U();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                                case 5:
                                                    obrot_Uprim();
                                                    obrot_kostka();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                                case 6:
                                                    obrot_w_lewo();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                            }

                                            break;



                                        case 6:  // pomaranczowy DOBRZE
                                            switch (przod_5)
                                            {
                                                case 1: // wkładanie niebiesko/pomaranczowego klocka
                                                    obrot_Uprim();
                                                    obrot_kostka();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;

                                                case 2:
                                                    obrot_kostka();
                                                    obrot_kostka();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                                case 5:
                                                    obrot_U();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                                case 6:
                                                    obrot_U();
                                                    obrot_U();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                            }

                                            break;
                                    }

                                    break;


                                case 2: //czerwony   DOBRZE
                                    switch (tyl_2)

                                    {
                                        case 1:   //niebieski DOBRZE 

                                            switch (przod_5)
                                            {
                                                case 1: // wkładanie niebiesko/czerwonego klocka
                                                    obrot_U();
                                                    obrot_U();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;

                                                case 2:
                                                    obrot_Uprim();
                                                    obrot_kostka();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                                case 5:
                                                    obrot_w_lewo();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                                case 6:
                                                    obrot_U();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                            }

                                            break;



                                        case 5: // zielony DOBRZE
                                            switch (przod_5)
                                            {
                                                case 1:
                                                    obrot_w_lewo();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;

                                                case 2:
                                                    obrot_U();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                                case 5:
                                                    obrot_U();
                                                    obrot_U();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                                case 6:
                                                    obrot_Uprim();
                                                    obrot_kostka();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                            }

                                            break;
                                    }

                                    break;

                                case 5:  // zielony   DOBRZE
                                    switch (tyl_2)
                                    {
                                        case 2:   //czerwony  DOBRZE

                                            switch (przod_5)
                                            {
                                                case 1: // wkładanie niebiesko/czerwonego klocka
                                                    obrot_U();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;

                                                case 2:
                                                    obrot_U();
                                                    obrot_U();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                                case 5:
                                                    obrot_Uprim();
                                                    obrot_kostka();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                                case 6:
                                                    obrot_w_lewo();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                            }

                                            break;



                                        case 6:  // pomaranczowy DOBRZE
                                            switch (przod_5)
                                            {
                                                case 1:
                                                    obrot_Uprim();
                                                    obrot_kostka();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;

                                                case 2:
                                                    obrot_kostka();
                                                    obrot_kostka();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                                case 5:
                                                    obrot_U();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                                case 6:
                                                    obrot_U();
                                                    obrot_U();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                            }

                                            break;
                                    }

                                    break;


                                case 6:  //pomaranczowy  DOBRZE
                                    switch (tyl_2)

                                    {
                                        case 1:   //niebieski  DOBRZE

                                            switch (przod_5)
                                            {
                                                case 1: // wkładanie niebiesko/czerwonego klocka
                                                    obrot_U();
                                                    obrot_U();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;

                                                case 2:
                                                    obrot_Uprim();
                                                    obrot_kostka();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                                case 5:
                                                    obrot_w_lewo();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                                case 6:
                                                    obrot_U();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_lewy(); MessageBox.Show("U X U U' L' U L U F U' F'", "Etap pierwszy - boki");
                                                    break;
                                            }

                                            break;



                                        case 5: // zielony  DOBRZE
                                            switch (przod_5)
                                            {
                                                case 1:
                                                    obrot_w_lewo();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;

                                                case 2:
                                                    obrot_U();
                                                    obrot_w_lewo();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                                case 5:
                                                    obrot_U();
                                                    obrot_U();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                                case 6:
                                                    obrot_Uprim();
                                                    obrot_kostka();
                                                    wkladanie_rogu_prawy(); MessageBox.Show("U U U R U' R' U' F' U F", "Etap pierwszy - boki");
                                                    break;
                                            }

                                            break;
                                    }


                                    break;

                            }
                            #endregion

                            break;
                    }
                    obrot_w_lewo();
                }


                if (gora_4 == 3 || gora_5 == 3 || gora_6 == 3)   // zrobienie krzyza
                {
                    krzyz();
                    MessageBox.Show("F R U R' U' F'", "Etap drugi - krzyz");
                }
                else if (gora_2 == 3 || gora_5 == 3 || gora_8 == 3)
                {
                    obrot_w_lewo();
                    krzyz(); MessageBox.Show("F R U R' U' F'", "Etap drugi - krzyz");
                }
                else
                {
                    do
                    {
                        krzyz(); MessageBox.Show("F R U R' U' F'", "Etap drugi - krzyz");
                        obrot_w_lewo();

                    } while (gora_4 == 3 || gora_5 == 3 || gora_6 == 3);

                    krzyz(); MessageBox.Show("F R U R' U' F'", "Etap drugi - krzyz");
                }

                // gdy jest rybka
                if (gora_1 != 3 || gora_2 == 3 || gora_3 != 3 || gora_4 == 3 || gora_5 == 3 || gora_6 == 3 || gora_7 == 3 || gora_8 == 3 || gora_9 != 3)
                {
                    switch (przod_3)
                    {
                        case 3:
                            rybka(); MessageBox.Show("R U R' U R U U R'", "Etap trzeci - zolta scianka");
                            break;

                        default:
                            rybka();
                            obrot_U();
                            obrot_U();
                            rybka();
                            MessageBox.Show("R U R' U R U U R' U U R U R' U R U U R'", "Etap trzeci - zolta scianka");
                            break;
                    }
                }
                else
                {

                    obrot_w_lewo();
                    if (gora_1 != 3 || gora_2 == 3 || gora_3 != 3 || gora_4 == 3 || gora_5 == 3 || gora_6 == 3 || gora_7 == 3 || gora_8 == 3 || gora_9 != 3)
                    {
                        switch (przod_3)
                        {
                            case 3:
                                rybka(); MessageBox.Show("U R U R' U R U U R'", "Etap trzeci -zolta scianka");
                                break;

                            default:
                                rybka();
                                obrot_U();
                                obrot_U();
                                rybka(); MessageBox.Show("U R U R' U R U U R' U U R U R' U R U U R'", "Etap trzeci - zolta scianka");
                                break;
                        }
                    }

                    obrot_w_lewo();

                    if (gora_1 != 3 || gora_2 == 3 || gora_3 != 3 || gora_4 == 3 || gora_5 == 3 || gora_6 == 3 || gora_7 == 3 || gora_8 == 3 || gora_9 != 3)
                    {
                        switch (przod_3)
                        {
                            case 3:
                                rybka(); MessageBox.Show("U R U R' U R U U R'", "Etap trzeci - zolta scianka");
                                break;

                            default:
                                rybka();
                                obrot_U();
                                obrot_U();
                                rybka(); MessageBox.Show("R U R' U R U U R' U U R U R' U R U U R'", "Etap trzeci - zolta scianka");
                                break;
                        }
                    }

                    obrot_w_lewo();

                    if (gora_1 != 3 || gora_2 == 3 || gora_3 != 3 || gora_4 == 3 || gora_5 == 3 || gora_6 == 3 || gora_7 == 3 || gora_8 == 3 || gora_9 != 3)
                    {
                        switch (przod_3)
                        {
                            case 3:
                                rybka(); MessageBox.Show("R U R' U R U U R'", "Etap trzeci - zolta scianka");
                                break;

                            default:
                                rybka();
                                obrot_U();
                                obrot_U();
                                rybka(); MessageBox.Show("R U R' U R U U R' U U R U R' U R U U R'", "Etap trzeci - zolta scianka");
                                break;
                        }
                    }





                }


                if (tyl_1 == tyl_3)
                {
                    do
                    {
                        a();
                        MessageBox.Show("R' F R' B B R F' R' B B R R", "Etap czarty - linia ");

                    } while (tyl_1 == tyl_3 || prawy_bok_1 == prawy_bok_3 || lewy_bok_1 == lewy_bok_3 || przod_1 == przod_3);

                    if (przod_1 != przod_5)
                    {
                        obrot_U();

                        if (przod_1 != przod_5)
                        {
                            obrot_U();
                            if (przod_1 != przod_5)
                            {
                                obrot_U();
                                MessageBox.Show("U U U U", "Etap czarty - linia ");
                            }
                        }
                    }

                    if (przod_2 != przod_5 || przod_1 == przod_4)
                    {
                        obrot_U();

                        if (przod_2 != przod_5 || przod_1 == przod_4)
                        {
                            obrot_U();

                            if (przod_2 != przod_5 || przod_1 == przod_4)
                            {
                                obrot_U();
                                MessageBox.Show("U U U U", "Etap czarty - linia ");
                            }
                        }
                    }

                    obrot_U();
                    obrot_U();

                    if (lewy_bok_2 == przod_2)
                    {
                        u_lewe();
                        MessageBox.Show("R' F R' B B R F' R' B B R R", "Etap czarty - linia ");
                    }
                    else
                    {
                        u_prawe();
                        MessageBox.Show("R' F R' B B R F' R' B B R R", "Etap czarty - linia ");
                    }



                }


                #endregion

                MessageBox.Show("BRAVO udało się :) ");

            }
            else
            {
                MessageBox.Show("Wprowadz wszystkie wartości");
            }




            //++++++++++++++++++++++     METODY    ++++++++++++++++++//

            void wkladanie_rogu_lewy()
            {
                obrot_Uprim();
                obrot_Lprim();
                obrot_U();
                obrot_L();
                obrot_U();
                obrot_F();
                obrot_Uprim();
                obrot_Fprim();
            }

            void wkladanie_rogu_prawy()
            {
                obrot_U();
                obrot_R();
                // obrot_Uprim();                 
                //obrot_Rprim();                   
                obrot_w_lewo();
                // obrot_Uprim();                    
                //obrot_Lprim();                   
                obrot_U();
                obrot_L();
            }

            void krzyz()
            {
                obrot_F();
                obrot_R();
                obrot_U();
                obrot_Rprim();
                obrot_Uprim();
                obrot_Fprim();
            }

            void rybka()
            {
                obrot_R();
                obrot_U();
                obrot_Rprim();
                obrot_U();
                obrot_R();
                obrot_U();
                obrot_U();
                obrot_Rprim();
            }

            void a()
            {
                obrot_Rprim();
                obrot_F();
                obrot_Rprim();
                obrot_B();
                obrot_B();
                obrot_R();
                obrot_Fprim();
                obrot_Rprim();
                obrot_B();
                obrot_B();
                obrot_R();
                obrot_R();
            }

            void u_prawe()
            {
                obrot_F();
                obrot_F();
                obrot_U();
                obrot_R();
                obrot_Lprim();
                obrot_U();
                obrot_U();
                obrot_Rprim();
                obrot_L();
                obrot_U();
                obrot_F();
                obrot_F();

            }

            void u_lewe()
            {
                obrot_F();
                obrot_F();
                obrot_Uprim();
                obrot_R();
                obrot_Lprim();
                obrot_U();
                obrot_U();
                obrot_Rprim();
                obrot_L();
                obrot_Uprim();
                obrot_F();
                obrot_F();
                
            }

            void obrot_Uprim() // DOBRZE
            {
                pojemnik_tymczasowy_1 = przod_1;
                pojemnik_tymczasowy_2 = przod_2;
                pojemnik_tymczasowy_3 = przod_3;

                przod_1 = lewy_bok_1;
                przod_2 = lewy_bok_2;
                przod_3 = lewy_bok_3;

                lewy_bok_1 = tyl_1;
                lewy_bok_2 = tyl_2;
                lewy_bok_3 = tyl_3;

                tyl_1 = prawy_bok_1;
                tyl_2 = prawy_bok_2;
                tyl_3 = prawy_bok_3;

                prawy_bok_1 = pojemnik_tymczasowy_1;
                prawy_bok_2 = pojemnik_tymczasowy_2;
                prawy_bok_3 = pojemnik_tymczasowy_3;                


                pojemnik_tymczasowy_1 = gora_2;
                pojemnik_tymczasowy_2 = gora_1;
                pojemnik_tymczasowy_3 = gora_4;
                pojemnik_tymczasowy_4 = gora_7;

               gora_1 = gora_3;
               gora_2 = gora_6 ;
               gora_3 = gora_9 ;
               gora_4 = pojemnik_tymczasowy_1 ;
               gora_6 = gora_8  ;
               gora_7 = pojemnik_tymczasowy_2 ;
               gora_8 = pojemnik_tymczasowy_3 ;
               gora_9 = pojemnik_tymczasowy_4;
            }

            void obrot_kostka()       //  --->
            {
                 pojemnik_tymczasowy_1= przod_1 ;
                 pojemnik_tymczasowy_2= przod_2 ;
                 pojemnik_tymczasowy_3= przod_3 ;
                 pojemnik_tymczasowy_4= przod_4 ;
                 pojemnik_tymczasowy_5= przod_5 ;
                 pojemnik_tymczasowy_6 = przod_6 ;
                 pojemnik_tymczasowy_7= przod_7 ;
                 pojemnik_tymczasowy_8 =przod_8  ;
                 pojemnik_tymczasowy_9 = przod_9 ;

                 przod_1=lewy_bok_1  ;
                 przod_2=lewy_bok_2  ;
                 przod_3=lewy_bok_3  ;
                 przod_4= lewy_bok_4 ;
                 przod_5= lewy_bok_5 ;
                 przod_6= lewy_bok_6 ;
                 przod_7 = lewy_bok_7 ;
                 przod_8= lewy_bok_8 ;
                 przod_9= lewy_bok_9 ;

                 lewy_bok_1 = tyl_1 ;
                 lewy_bok_2= tyl_2 ;
                 lewy_bok_3= tyl_3 ;
                 lewy_bok_4 =tyl_4  ;
                 lewy_bok_5= tyl_5 ;
                 lewy_bok_6= tyl_6 ;
                 lewy_bok_7 = tyl_7 ;
                 lewy_bok_8= tyl_8 ;
                 lewy_bok_9= tyl_9 ;

                 tyl_1= prawy_bok_1 ;
                 tyl_2= prawy_bok_2 ;
                 tyl_3= prawy_bok_3 ;
                 tyl_4 =prawy_bok_4 ;
                 tyl_5= prawy_bok_5 ;
                 tyl_6= prawy_bok_6 ;
                 tyl_7= prawy_bok_7 ;
                 tyl_8= prawy_bok_8 ;
                 tyl_9= prawy_bok_9 ;

                 prawy_bok_1= pojemnik_tymczasowy_1 ;
                 prawy_bok_2= pojemnik_tymczasowy_2 ;
                 prawy_bok_3= pojemnik_tymczasowy_3 ;
                 prawy_bok_4= pojemnik_tymczasowy_4 ;
                 prawy_bok_5= pojemnik_tymczasowy_5 ;
                 prawy_bok_6= pojemnik_tymczasowy_6 ;
                 prawy_bok_7= pojemnik_tymczasowy_7 ;
                 prawy_bok_8= pojemnik_tymczasowy_8 ;
                 prawy_bok_9= pojemnik_tymczasowy_9 ;

                 pojemnik_tymczasowy_1= gora_2 ;
                 pojemnik_tymczasowy_2= gora_1 ;
                 pojemnik_tymczasowy_3= gora_4 ;
                 pojemnik_tymczasowy_4= gora_7 ;

                 gora_1= gora_3 ;
                 gora_2= gora_6 ;
                 gora_3= gora_9 ;
                 gora_4= pojemnik_tymczasowy_1 ;                 
                 gora_6= gora_8 ;
                 gora_7= pojemnik_tymczasowy_2 ;
                 gora_8= pojemnik_tymczasowy_3 ;
                 gora_9= pojemnik_tymczasowy_4 ;

                 pojemnik_tymczasowy_1= dol_1 ;
                 pojemnik_tymczasowy_2= dol_2 ;
                 pojemnik_tymczasowy_3= dol_6 ;
                 pojemnik_tymczasowy_4= dol_3 ;

                 dol_1= dol_7 ;
                 dol_2= dol_4 ;
                 dol_3 = pojemnik_tymczasowy_1 ;
                 dol_4= dol_8 ;
                 dol_6= pojemnik_tymczasowy_2 ;
                 dol_7= dol_9 ;
                 dol_8= pojemnik_tymczasowy_3 ;
                 dol_9= pojemnik_tymczasowy_4 ;                
            }
                  
                                 //   ||
            void obrot_w_dol()  //    \/     
            {
                pojemnik_tymczasowy_1 = przod_1 ;
                pojemnik_tymczasowy_2 = przod_2 ;
                pojemnik_tymczasowy_3 = przod_3 ;
                pojemnik_tymczasowy_4 = przod_4 ;
                pojemnik_tymczasowy_5 = przod_5 ;
                pojemnik_tymczasowy_6 = przod_6 ;
                pojemnik_tymczasowy_7 = przod_7 ;
                pojemnik_tymczasowy_8 = przod_8 ;
                pojemnik_tymczasowy_9 = przod_9 ;
               
                 przod_1 = gora_1 ;
                 przod_2=  gora_2;
                 przod_3=  gora_3;
                 przod_4=  gora_4;
                 przod_5=  gora_5;
                 przod_6=  gora_6;
                 przod_7=  gora_7;
                 przod_8=  gora_8;
                 przod_9=  gora_9;

                 gora_1= tyl_9 ;
                 gora_2= tyl_8 ;               
                 gora_3= tyl_7 ;
                 gora_4= tyl_6 ;
                 gora_5=  tyl_5;
                 gora_6=  tyl_4;
                 gora_7=  tyl_3;
                 gora_8=  tyl_2;
                 gora_9=  tyl_1;

                 tyl_1= dol_9 ;
                 tyl_2= dol_8 ;
                 tyl_3=  dol_7;
                 tyl_4=  dol_6;
                 tyl_5= dol_5 ;
                 tyl_6=  dol_4;
                 tyl_7=  dol_3;
                 tyl_8=  dol_2;
                 tyl_9=  dol_1;

                dol_1 = pojemnik_tymczasowy_1 ;
                dol_2 = pojemnik_tymczasowy_2 ;
                dol_3 = pojemnik_tymczasowy_3 ;
                dol_4 = pojemnik_tymczasowy_4 ;
                dol_5 = pojemnik_tymczasowy_5 ;
                dol_6 = pojemnik_tymczasowy_6 ;
                dol_7 = pojemnik_tymczasowy_7 ;
                dol_8 = pojemnik_tymczasowy_8 ;
                dol_9 = pojemnik_tymczasowy_9 ;

                 pojemnik_tymczasowy_1= prawy_bok_2 ;
                 pojemnik_tymczasowy_2= prawy_bok_1 ;
                 pojemnik_tymczasowy_3= prawy_bok_4 ;
                 pojemnik_tymczasowy_4= prawy_bok_7 ;
                
                 prawy_bok_1 = prawy_bok_3 ;
                 prawy_bok_2= prawy_bok_6 ;
                 prawy_bok_3= prawy_bok_9 ;
                 prawy_bok_4= pojemnik_tymczasowy_1;                 
                 prawy_bok_6= prawy_bok_8 ;
                 prawy_bok_7= pojemnik_tymczasowy_2 ;
                 prawy_bok_8= pojemnik_tymczasowy_3 ;
                 prawy_bok_9= pojemnik_tymczasowy_4;

                 pojemnik_tymczasowy_1= lewy_bok_1 ;
                 pojemnik_tymczasowy_2= lewy_bok_2 ;
                 pojemnik_tymczasowy_3=  lewy_bok_6;
                 pojemnik_tymczasowy_4= lewy_bok_3 ;                

                 lewy_bok_1 = lewy_bok_7 ;
                 lewy_bok_2=  lewy_bok_4;
                 lewy_bok_3 = pojemnik_tymczasowy_1;
                 lewy_bok_4=  lewy_bok_8;
                 lewy_bok_6= pojemnik_tymczasowy_2;
                 lewy_bok_7=  lewy_bok_9;
                 lewy_bok_8=  pojemnik_tymczasowy_3;
                 lewy_bok_9=  pojemnik_tymczasowy_4;                
            }
                  
            void obrot_Fprim()
            {
                pojemnik_tymczasowy_1= gora_7 ;
               pojemnik_tymczasowy_2 =gora_8  ;
                pojemnik_tymczasowy_3= gora_9 ;

               gora_7 = prawy_bok_1 ;
                gora_8= prawy_bok_4 ;
                gora_9= prawy_bok_7 ;

               prawy_bok_1 = dol_3 ; 
               prawy_bok_4 =dol_2  ;
               prawy_bok_7 = dol_1 ;

                dol_1=lewy_bok_3  ;
                dol_2=lewy_bok_6  ;
                dol_3=lewy_bok_9  ;

              lewy_bok_3  =pojemnik_tymczasowy_3  ;
               lewy_bok_6 =pojemnik_tymczasowy_2  ;
               lewy_bok_9 =pojemnik_tymczasowy_1  ;

                pojemnik_tymczasowy_1 = przod_2 ;
                pojemnik_tymczasowy_2 = przod_1 ;
                pojemnik_tymczasowy_3 = przod_4 ;
                pojemnik_tymczasowy_4 = przod_7 ;
                
                 przod_1= przod_3 ;
                 przod_2= przod_6 ;
                 przod_3=  przod_9;
                 przod_4= pojemnik_tymczasowy_1 ;
                 przod_6= przod_8 ;
                 przod_7= pojemnik_tymczasowy_2 ;
                 przod_8= pojemnik_tymczasowy_3 ;
                 przod_9= pojemnik_tymczasowy_4;           
            }

            void obrot_Lprim()
            {
               pojemnik_tymczasowy_1 = gora_1 ;
               pojemnik_tymczasowy_2 = gora_4 ;
               pojemnik_tymczasowy_3 = gora_7;


               gora_1 = przod_1 ;
               gora_4 = przod_4 ;
               gora_7 = przod_7 ;

                przod_1= dol_1 ;
                przod_4=dol_4  ;
                przod_7= dol_7 ;

                dol_1 = tyl_9 ;
                dol_4= tyl_6 ;
                dol_7= tyl_3 ;

               tyl_3  =pojemnik_tymczasowy_3  ;
               tyl_6 = pojemnik_tymczasowy_2 ;
               tyl_9 = pojemnik_tymczasowy_1 ;

                pojemnik_tymczasowy_1 = lewy_bok_2;
                pojemnik_tymczasowy_2 = lewy_bok_1;
                pojemnik_tymczasowy_3 = lewy_bok_4;
                pojemnik_tymczasowy_4 = lewy_bok_7;

                lewy_bok_1=lewy_bok_3  ;
                lewy_bok_2= lewy_bok_6 ;
                lewy_bok_3= lewy_bok_9 ;
                lewy_bok_4= pojemnik_tymczasowy_1 ;
                lewy_bok_6= lewy_bok_8 ;
                lewy_bok_7= pojemnik_tymczasowy_2 ;
                lewy_bok_8= pojemnik_tymczasowy_3 ;
                lewy_bok_9= pojemnik_tymczasowy_4;


            }

            void obrot_Rprim() //         R' DOBRZZE
            {
                pojemnik_tymczasowy_1 = gora_3;
                pojemnik_tymczasowy_2 = gora_6;
                pojemnik_tymczasowy_3 = gora_9;

                gora_9 = tyl_1;
                gora_6 = tyl_4;
                gora_3 = tyl_7;

                tyl_1 = dol_9;
                tyl_4 = dol_6;
                tyl_7 = dol_3;

                dol_3 = przod_3;
                dol_6 = przod_6;
                dol_9 = przod_9;

                przod_3 = pojemnik_tymczasowy_1;
                przod_6 = pojemnik_tymczasowy_2;
                przod_9 = pojemnik_tymczasowy_3;

                pojemnik_tymczasowy_1 = prawy_bok_1;
                pojemnik_tymczasowy_2 = prawy_bok_2;
                pojemnik_tymczasowy_3 = prawy_bok_4;
                pojemnik_tymczasowy_4 = prawy_bok_7;

                prawy_bok_1 = prawy_bok_3;
                prawy_bok_2 = prawy_bok_6;
                prawy_bok_3 = prawy_bok_9;
                prawy_bok_4 = pojemnik_tymczasowy_2;
                prawy_bok_6 = prawy_bok_8;
                prawy_bok_7 = pojemnik_tymczasowy_1;
                prawy_bok_8 = pojemnik_tymczasowy_3;
                prawy_bok_9 = pojemnik_tymczasowy_4;
            }

            void obrot_L() //                 L         DOBRZE
            {
                pojemnik_tymczasowy_1 = gora_1;
                pojemnik_tymczasowy_2 = gora_4;
                pojemnik_tymczasowy_3 = gora_7;

                gora_1 = tyl_9;
                gora_4 = tyl_6;
                gora_7 = tyl_3;

                tyl_3 = dol_7;
                tyl_6 = dol_4;
                tyl_9 = dol_1;

                dol_1 = przod_1;
                dol_4 = przod_4;
                dol_7 = przod_7;

                przod_1 = pojemnik_tymczasowy_1;
                przod_4 = pojemnik_tymczasowy_2;
                przod_7 = pojemnik_tymczasowy_3;

                pojemnik_tymczasowy_1 = lewy_bok_3;
                pojemnik_tymczasowy_2 = lewy_bok_2;
                //pojemnik_tymczasowy_3 = lewy_bok_6;

                lewy_bok_3 = lewy_bok_1;
                lewy_bok_1 = lewy_bok_7;
                lewy_bok_2 = lewy_bok_4;
                lewy_bok_4 = lewy_bok_8;
                lewy_bok_7 = lewy_bok_9;
                lewy_bok_8 = lewy_bok_6;
                lewy_bok_6 = pojemnik_tymczasowy_2;
                lewy_bok_9 = pojemnik_tymczasowy_1;
               // lewy_bok_8 = pojemnik_tymczasowy_3;


            }

            void obrot_F() //                 F      DOBRZE
            {
                pojemnik_tymczasowy_1 = gora_7;
                pojemnik_tymczasowy_2 = gora_8;
                pojemnik_tymczasowy_3 = gora_9;

                gora_7 = lewy_bok_9;
                gora_8 = lewy_bok_6;
                gora_9 = lewy_bok_3;

                lewy_bok_3 = dol_1;
                lewy_bok_6 = dol_2;
                lewy_bok_9 = dol_3;

                dol_1 = prawy_bok_7;
                dol_2 = prawy_bok_4;
                dol_3 = prawy_bok_1;

                prawy_bok_1 = pojemnik_tymczasowy_1;
                prawy_bok_4 = pojemnik_tymczasowy_2;
                prawy_bok_7 = pojemnik_tymczasowy_3;

                pojemnik_tymczasowy_1 = przod_3;
                pojemnik_tymczasowy_2 = przod_2;
                //pojemnik_tymczasowy_3 = przod_6;

                przod_3 = przod_1;
                przod_1 = przod_7;
                przod_2 = przod_4;
                przod_4 = przod_8;
                przod_7 = przod_9;
                przod_8 = przod_6;
                przod_6 = pojemnik_tymczasowy_2;
                przod_9 = pojemnik_tymczasowy_1;
               // przod_8 = pojemnik_tymczasowy_3;
            }

            void obrot_B() //                 B 
            {
                pojemnik_tymczasowy_1 = gora_1;
                pojemnik_tymczasowy_2 = gora_2;
                pojemnik_tymczasowy_3 = gora_3;

                gora_1 = prawy_bok_3;
                gora_2 = prawy_bok_6;
                gora_3 = prawy_bok_9;

                prawy_bok_3 = dol_9;
                prawy_bok_6 = dol_8;
                prawy_bok_9 = dol_7;

                dol_9 = lewy_bok_7;
                dol_8 = lewy_bok_4;
                dol_7 = lewy_bok_1;

                lewy_bok_7 = pojemnik_tymczasowy_1;
                lewy_bok_4 = pojemnik_tymczasowy_2;
                lewy_bok_1 = pojemnik_tymczasowy_3;

                pojemnik_tymczasowy_1 = tyl_3;
                pojemnik_tymczasowy_2 = tyl_2;               

                tyl_3 = tyl_1;
                tyl_1 = tyl_7;
                tyl_2 = tyl_4;
                tyl_4 = tyl_8;
                tyl_7 = tyl_9;
                tyl_8 = tyl_6;
                tyl_6 = pojemnik_tymczasowy_2;
                tyl_9 = pojemnik_tymczasowy_1;                
            }
            
            void obrot_U() //                 U            DOBRZE
            {
                pojemnik_tymczasowy_1 = przod_1;
                pojemnik_tymczasowy_2 = przod_2;
                pojemnik_tymczasowy_3 = przod_3;

                przod_1 = prawy_bok_1;
                przod_2 = prawy_bok_2;
                przod_3 = prawy_bok_3;

                prawy_bok_1 = tyl_1;
                prawy_bok_2 = tyl_2;
                prawy_bok_3 = tyl_3;

                tyl_1 = lewy_bok_1;
                tyl_2 = lewy_bok_2;
                tyl_3 = lewy_bok_3;

                lewy_bok_1 = pojemnik_tymczasowy_1;
                lewy_bok_2 = pojemnik_tymczasowy_2;
                lewy_bok_3 = pojemnik_tymczasowy_3;

                pojemnik_tymczasowy_1 = gora_3;
                pojemnik_tymczasowy_2 = gora_2;              

                gora_3 = gora_1;
                gora_1 = gora_7;
                gora_2 = gora_4;
                gora_4 = gora_8;
                gora_7 = gora_9;
                gora_8 = gora_6;
                gora_6 = pojemnik_tymczasowy_2;
                gora_9 = pojemnik_tymczasowy_1;             
            }

            void obrot_D() //                 D
            {
                pojemnik_tymczasowy_1 = przod_7;
                pojemnik_tymczasowy_2 = przod_8;
                pojemnik_tymczasowy_3 = przod_9;

                przod_7 = lewy_bok_7;
                przod_8 = lewy_bok_8;
                przod_9 = lewy_bok_9;

                lewy_bok_7 = tyl_7;
                lewy_bok_8 = tyl_8;
                lewy_bok_9 = tyl_9;

                tyl_7 = prawy_bok_7;
                tyl_8 = prawy_bok_8;
                tyl_9 = prawy_bok_9;

                prawy_bok_7 = pojemnik_tymczasowy_1;
                prawy_bok_8 = pojemnik_tymczasowy_2;
                prawy_bok_9 = pojemnik_tymczasowy_3;


                pojemnik_tymczasowy_1 = dol_3;
                pojemnik_tymczasowy_2 = dol_2;
                pojemnik_tymczasowy_3 = dol_6;

                dol_3 = dol_1;
                dol_1 = dol_7;
                dol_2 = dol_4;
                dol_4 = dol_8;
                dol_7 = dol_9;
                dol_8 = dol_6;
                dol_6 = pojemnik_tymczasowy_2;
                dol_9 = pojemnik_tymczasowy_1;
                dol_8 = pojemnik_tymczasowy_3;

            }

            void obrot_R() //                 R       DOBRZE
            {
                pojemnik_tymczasowy_1 = gora_3;
                pojemnik_tymczasowy_2 = gora_6;
                pojemnik_tymczasowy_3 = gora_9;

                gora_9 = przod_9;
                gora_6 = przod_6;
                gora_3 = przod_3;

                przod_3 = dol_3;
                przod_6 = dol_6;
                przod_9 = dol_9;

                dol_3 = tyl_7;
                dol_6 = tyl_4;
                dol_9 = tyl_1;

                tyl_7 = pojemnik_tymczasowy_1;
                tyl_4 = pojemnik_tymczasowy_2;
                tyl_1 = pojemnik_tymczasowy_3;

                pojemnik_tymczasowy_1 = prawy_bok_3;
                pojemnik_tymczasowy_2 = prawy_bok_2;               

                prawy_bok_3 = prawy_bok_1;
                prawy_bok_1 = prawy_bok_7;
                prawy_bok_2 = prawy_bok_4;
                prawy_bok_4 = prawy_bok_8;
                prawy_bok_7 = prawy_bok_9;
                prawy_bok_8 = prawy_bok_6;
                prawy_bok_6 = pojemnik_tymczasowy_2;
                prawy_bok_9 = pojemnik_tymczasowy_1;              

            }

            void obrot_w_lewo() //                OBRÓT KOSTKI w lewo  <-- DOBRZE
            {
                pojemnik_tymczasowy_1 = przod_1;
                pojemnik_tymczasowy_2 = przod_2;
                pojemnik_tymczasowy_3 = przod_3;
                pojemnik_tymczasowy_4 = przod_4;
                pojemnik_tymczasowy_5 = przod_5;
                pojemnik_tymczasowy_6 = przod_6;
                pojemnik_tymczasowy_7 = przod_7;
                pojemnik_tymczasowy_8 = przod_8;
                pojemnik_tymczasowy_9 = przod_9;

                przod_1 = prawy_bok_1;
                przod_2 = prawy_bok_2;
                przod_3 = prawy_bok_3;
                przod_4 = prawy_bok_4;
                przod_5 = prawy_bok_5;
                przod_6 = prawy_bok_6;
                przod_7 = prawy_bok_7;
                przod_8 = prawy_bok_8;
                przod_9 = prawy_bok_9;

                prawy_bok_1 = tyl_1;
                prawy_bok_2 = tyl_2;
                prawy_bok_3 = tyl_3;
                prawy_bok_4 = tyl_4;
                prawy_bok_5 = tyl_5;
                prawy_bok_6 = tyl_6;
                prawy_bok_7 = tyl_7;
                prawy_bok_8 = tyl_8;
                prawy_bok_9 = tyl_9;

                tyl_1 = lewy_bok_1;
                tyl_2 = lewy_bok_2;
                tyl_3 = lewy_bok_3;
                tyl_4 = lewy_bok_4;
                tyl_5 = lewy_bok_5;
                tyl_6 = lewy_bok_6;
                tyl_7 = lewy_bok_7;
                tyl_8 = lewy_bok_8;
                tyl_9 = lewy_bok_9;                

                lewy_bok_1 = pojemnik_tymczasowy_1;
                lewy_bok_2 = pojemnik_tymczasowy_2;
                lewy_bok_3 = pojemnik_tymczasowy_3;                
                lewy_bok_4 = pojemnik_tymczasowy_4;
                lewy_bok_5 = pojemnik_tymczasowy_5;
                lewy_bok_6 = pojemnik_tymczasowy_6;
                lewy_bok_7 = pojemnik_tymczasowy_7;
                lewy_bok_8 = pojemnik_tymczasowy_8;
                lewy_bok_9 = pojemnik_tymczasowy_9;

                pojemnik_tymczasowy_1 = gora_1;
                pojemnik_tymczasowy_2 = gora_2;
                pojemnik_tymczasowy_3 = gora_6;
                pojemnik_tymczasowy_4 = gora_3;

                gora_1 = gora_7;
                gora_2 = gora_4;
                gora_3 = pojemnik_tymczasowy_1; 
                gora_4 = gora_8;
                gora_6 = pojemnik_tymczasowy_2;
                gora_7 = gora_9;
                gora_8 = pojemnik_tymczasowy_3;                
                gora_9 = pojemnik_tymczasowy_4;

                pojemnik_tymczasowy_1 = dol_2;
                pojemnik_tymczasowy_2 = dol_1;
                pojemnik_tymczasowy_3 = dol_4;
                pojemnik_tymczasowy_4 = dol_7;

                dol_1 = dol_3;
                dol_2 = dol_6;
                dol_3 = dol_9;
                dol_4 = pojemnik_tymczasowy_1;
                dol_6 = dol_8;
                dol_7 = pojemnik_tymczasowy_2;
                dol_8 = pojemnik_tymczasowy_3; 
                dol_9 = pojemnik_tymczasowy_4;
            }
                       
        }




        private void button2_Click(object sender, EventArgs e)
        {
         
            MessageBox.Show("Do widzenia :)");           
            this.Close();
        }   
             
        
        #region WYBOR KOLORU 


        //_____________________________//
        private void lista_tyl_5_Click(object sender, EventArgs e)
        { }
        private void toolStripMenuItem202_Click(object sender, EventArgs e)
        { }
        private void toolStripMenuItem153_Click(object sender, EventArgs e)
        { }
        private void katalog_ty_3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        { }

        //____________________________//





        //===============|    Wybor KOloru  |================//                 


        //tyl_1
        public void niebieski_tyl_1_Click(object sender, EventArgs e)
        { tyl_1 = 1;
            Katalog_tyl_1.BackColor = Color.Blue;
        }
        private void czerwony_tyl_1_Click(object sender, EventArgs e)
        { tyl_1 = 2;
            Katalog_tyl_1.BackColor = Color.Red;
        }
        private void bialy_tyl_1_Click_1(object sender, EventArgs e)
        { tyl_1 =3;
            Katalog_tyl_1.BackColor = Color.Yellow;
        }
        private void zolty_tyl_1_Click(object sender, EventArgs e)
        { tyl_1 = 4;
            Katalog_tyl_1.BackColor = Color.Yellow;
        }
        private void zielony_tyl_1_Click(object sender, EventArgs e)
        { tyl_1 = 5;
            Katalog_tyl_1.BackColor = Color.Green;
        }
        private void pomaranczowy_tyl_1_Click(object sender, EventArgs e)
        { tyl_1 = 6;
            Katalog_tyl_1.BackColor = Color.Orange;
        }

        //TYL_2 
        private void niebieski_tyl_2_Click(object sender, EventArgs e)
        { tyl_2 =1;
            katalog_tyl_2.BackColor = Color.Blue;
        }
        private void czerwony_tyl_2_Click(object sender, EventArgs e)
        { tyl_2 = 2;
            katalog_tyl_2.BackColor = Color.Red;
        }
        private void zolty_tyl_2_Click(object sender, EventArgs e)
        { tyl_2 = 3;
            katalog_tyl_2.BackColor = Color.Yellow;
        }
        private void bialy_tyl_2_Click(object sender, EventArgs e)
        { tyl_2 =4;
            katalog_tyl_2.BackColor = Color.White;
        }
        private void zielony_tyl_2_Click(object sender, EventArgs e)
        { tyl_2 = 5;
            katalog_tyl_2.BackColor = Color.Green;
        }
        private void pomaranczowy_tyl_2_Click(object sender, EventArgs e)
        { tyl_2 = 6;
            katalog_tyl_2.BackColor = Color.Orange;
        }

        //TYL_3
        private void niebieski_tyl_3_Click(object sender, EventArgs e)
        {  tyl_3 =1;
            katalog_ty_3.BackColor = Color.Blue;
        }
        private void czerwony_tyl_3_Click(object sender, EventArgs e)
        { tyl_3 = 2;
            katalog_ty_3.BackColor = Color.Red;
        }
        private void zolty_tyl_3_Click(object sender, EventArgs e)
        { tyl_3 = 3;
            katalog_ty_3.BackColor = Color.Yellow;
        }
        private void bialy_tyl_3_Click(object sender, EventArgs e)
        { tyl_3 = 4;
            katalog_ty_3.BackColor = Color.White;
        }
        private void zielony_tyl_3_Click(object sender, EventArgs e)
        { tyl_3 = 5;
            katalog_ty_3.BackColor = Color.Green;
        }
        private void pomaranczowy_tyl_3_Click(object sender, EventArgs e)
        { tyl_3 = 6;
            katalog_ty_3.BackColor = Color.Orange;
        }

        
        //TYL_4
        private void niebieski_tyl_4_Click(object sender, EventArgs e)
        {   tyl_4 = 1;
            menuStrip5.BackColor = Color.Blue;
        }
        private void czerwony_tyl_4_Click(object sender, EventArgs e)
        { tyl_4 = 2;
            menuStrip5.BackColor = Color.Red;
        }
        private void zolty_tyl_4_Click(object sender, EventArgs e)
        { tyl_4 =3;
            menuStrip5.BackColor = Color.Yellow;
        }
        private void bialy_tyl_4_Click(object sender, EventArgs e)
        { tyl_4 = 4;
            menuStrip5.BackColor = Color.White;
        }
        private void zielony_tyl_4_Click(object sender, EventArgs e)
        { tyl_4 = 5;
            menuStrip5.BackColor = Color.Green;
        }
        private void pomaranczowy_tyl_4_Click(object sender, EventArgs e)
        { tyl_4 = 6;
            menuStrip5.BackColor = Color.Orange;
        }


        //TYL_5
        private void niebieski_tyl_5_Click(object sender, EventArgs e)
        {        }
        private void czerwony_tyl_5_Click(object sender, EventArgs e)
        {        }
        private void zolty_tyl_5_Click(object sender, EventArgs e)
        {         }
        private void bialy_tyl_5_Click(object sender, EventArgs e)
        {         }
        private void zielony_tyl_5_Click(object sender, EventArgs e)
        {        }
        private void pomaranczowy_tyl_5_Click(object sender, EventArgs e)
        {         }


        //TYL_6
        private void niebieski_tyl_6_Click(object sender, EventArgs e)
        { tyl_6 = 1;
            menuStrip3.BackColor = Color.Blue;
        }
        private void czerwony_tyl_6_Click(object sender, EventArgs e)
        { tyl_6 = 2;
            menuStrip3.BackColor = Color.Red;
        }
        private void zolty_tyl_6_Click(object sender, EventArgs e)
        { tyl_6 = 3;
            menuStrip3.BackColor = Color.Yellow;
        }
        private void bialy_tyl_6_Click(object sender, EventArgs e)
        { tyl_6 = 4;
            menuStrip3.BackColor = Color.White;
        }
        private void zielony_tyl_6_Click(object sender, EventArgs e)
        { tyl_6 = 5;
            menuStrip3.BackColor = Color.Green;
        }
        private void pomaranczowy_tyl_6_Click(object sender, EventArgs e)
        { tyl_6 = 6;
            menuStrip3.BackColor = Color.Orange;
        }


        //TYL_7
        private void niebieski_tyl_7_Click(object sender, EventArgs e)
        { tyl_7 = 1;
            menuStrip8.BackColor = Color.Blue;        }
        private void czerwony_tyl_7_Click(object sender, EventArgs e)
        { tyl_7 = 2;
            menuStrip8.BackColor = Color.Red;        }
        private void zolty_tyl_7_Click(object sender, EventArgs e)
        { tyl_7 = 3;
            menuStrip8.BackColor = Color.Yellow;        }
        private void bialy_tyl_7_Click(object sender, EventArgs e)
        { tyl_7 = 4;
            menuStrip8.BackColor = Color.White;        }
        private void zielony_tyl_7_Click(object sender, EventArgs e)
        { tyl_7 = 5;
            menuStrip8.BackColor = Color.Green;        }
        private void pomaranczowy_tyl_7_Click(object sender, EventArgs e)
        { tyl_7 = 6;
            menuStrip8.BackColor = Color.Orange;        }


        //TYL_8
        private void niebieski_tyl_8_Click(object sender, EventArgs e)
        { tyl_8 = 1;
            menuStrip7.BackColor = Color.Blue;        }
        private void czerwony_tyl_8_Click(object sender, EventArgs e)
        { tyl_8 = 2;
            menuStrip7.BackColor = Color.Red;        }
        private void zolty_tyl_8_Click(object sender, EventArgs e)
        { tyl_8 = 3;
            menuStrip7.BackColor = Color.Yellow;        }
        private void bialy_tyl_8_Click(object sender, EventArgs e)
        { tyl_8 = 4;
            menuStrip7.BackColor = Color.White;        }
        private void zielony_tyl_8_Click(object sender, EventArgs e)
        { tyl_8 = 5;
            menuStrip7.BackColor = Color.Green;        }
        private void pomaranczowy_tyl_8_Click(object sender, EventArgs e)
        { tyl_8 = 6;
            menuStrip7.BackColor = Color.Orange;        }



        //TYL_9
        private void niebieski_tyl_9_Click(object sender, EventArgs e)
        { tyl_9 = 1;
            menuStrip6.BackColor = Color.Blue;        }
        private void czerwony_tyl_9_Click(object sender, EventArgs e)
        { tyl_9 = 2;
            menuStrip6.BackColor = Color.Red;        }
        private void zolty_tyl_9_Click(object sender, EventArgs e)
        { tyl_9 = 3;
            menuStrip6.BackColor = Color.Yellow;        }
        private void bialy_tyl_9_Click(object sender, EventArgs e)
        { tyl_9 = 4;
            menuStrip6.BackColor = Color.White;        }
        private void zielony_tyl_9_Click(object sender, EventArgs e)
        { tyl_9 = 5;
            menuStrip6.BackColor = Color.Green;        }
        private void pomaranczowy_tyl_9_Click(object sender, EventArgs e)
        { tyl_9 = 6;
            menuStrip6.BackColor = Color.Orange;        }

        
        ///......................///...................///...................///
                    

        //PRZOD_1
        private void niebieski_przod_1_Click(object sender, EventArgs e)
        { }
        private void czerwony_przod_1_Click(object sender, EventArgs e)
        {  }
        private void zolty_przod_1_Click(object sender, EventArgs e)
        {        }
        private void bialy_przod_1_Click(object sender, EventArgs e)
        { }
        private void zielony_przod_1_Click(object sender, EventArgs e)
        {  }
        private void pomaranczowy_przod_1_Click(object sender, EventArgs e)
        {        }


        //PRZOD_2
        private void niebieski_przod_2_Click(object sender, EventArgs e)
        {    }      
        private void czerwony_przod_2_Click(object sender, EventArgs e)
        {      }
        private void zolty_przod_2_Click(object sender, EventArgs e)
        {       }
        private void bialy_przod_2_Click(object sender, EventArgs e)
        {     }
        private void zielony_przod_2_Click(object sender, EventArgs e)
        {     }
        private void pomaranczowy_przod_2_Click(object sender, EventArgs e)
        {   }


        //PRZOD_3        
        private void niebieski_przod_3_Click(object sender, EventArgs e)
        {  }
        private void czerwony_przod_3_Click(object sender, EventArgs e)
        {      }
        private void zolty_przod_3_Click(object sender, EventArgs e)
        {         }
        private void bialy_przod_3_Click(object sender, EventArgs e)
        {         }
        private void zielony_przod_3_Click(object sender, EventArgs e)
        {        }
        private void pomaranczowy_przod_3_Click(object sender, EventArgs e)
        {         }


        //PRZOD_4
        private void niebieski_przod_4_Click(object sender, EventArgs e)
        {        }
        private void czerwony_przod_4_Click(object sender, EventArgs e)
        {        }
        private void zolty_przod_4_Click(object sender, EventArgs e)
        {       }
        private void bialy_przod_4_Click(object sender, EventArgs e)
        {        }
        private void zielony_przod_4_Click(object sender, EventArgs e)
        {        }
        private void pomaranczowy_przod_4_Click(object sender, EventArgs e)
        {     }


        //PRZOD_5
        private void niebieski_przod_5_Click(object sender, EventArgs e)
        {     }
        private void czerwony_przod_5_Click(object sender, EventArgs e)
        {        }
        private void zolty_przod_5_Click(object sender, EventArgs e)
        {         }
        private void bialy_przod_5_Click(object sender, EventArgs e)
        {       }
        private void zielony_przod_5_Click(object sender, EventArgs e)
        {   }
        private void pomaranczowy_przod_5_Click(object sender, EventArgs e)
        {       }


        //PRZOD_6
        private void niebieski_przod_6_Click(object sender, EventArgs e)
        {     }
        private void czerwony_przod_6_Click(object sender, EventArgs e)
        {       }
        private void zolty_przod_6_Click(object sender, EventArgs e)
        {       }
        private void bialy_przod_6_Click(object sender, EventArgs e)
        {        }
        private void zielony_przod_6_Click(object sender, EventArgs e)
        {       }
        private void pomaranczowy_przod_6_Click(object sender, EventArgs e)
        {       }

        //PRZOD_7
        private void niebieski_przod_7_Click(object sender, EventArgs e)
        {         }
        private void czerwony_przod_7_Click(object sender, EventArgs e)
        {        }
        private void zolty_przod_7_Click(object sender, EventArgs e)
        {         }
        private void bialy_przod_7_Click(object sender, EventArgs e)
        {       }
        private void zielony_przod_7_Click(object sender, EventArgs e)
        {       }
        private void pomaranczowy_przod_7_Click(object sender, EventArgs e)
        {        }


        void checkColor (int menunumber, string color)
        {
            //if (color == 1)
                menuStrip2.BackColor = Color.Blue;
            //else if (color == 3)
                menuStrip2.BackColor = Color.Yellow;
            //mozna na enumie?

        }

        //PRZOD_8
        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {      }
        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {         }
        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {     }
        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {        }


        //PRZOD_9
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {      }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {      }
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {       }
        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {        }

                

        ///......................///...................///...................///
        


        //LEWY_BOK_1
        private void toolStripMenuItem77_Click(object sender, EventArgs e)
        { lewy_bok_1 =1;
            menuStrip24.BackColor = Color.Blue;        }
        private void toolStripMenuItem78_Click(object sender, EventArgs e)
        { lewy_bok_1 = 2;
            menuStrip24.BackColor = Color.Red;                    }
        private void toolStripMenuItem79_Click(object sender, EventArgs e)
        { lewy_bok_1 = 3;
            menuStrip24.BackColor = Color.Yellow;        }
        private void toolStripMenuItem80_Click(object sender, EventArgs e)
        { lewy_bok_1 = 4;
            menuStrip24.BackColor = Color.White;                    }
        private void toolStripMenuItem81_Click(object sender, EventArgs e)
        { lewy_bok_1 = 5;
            menuStrip24.BackColor = Color.Green;                    }
        private void toolStripMenuItem82_Click(object sender, EventArgs e)
        { lewy_bok_1 = 6;
            menuStrip24.BackColor = Color.Orange;        }
        

        //LEWY_BOK_2
        private void toolStripMenuItem70_Click(object sender, EventArgs e)
        { lewy_bok_2 = 1;
            menuStrip23.BackColor = Color.Blue;        }
        private void toolStripMenuItem71_Click(object sender, EventArgs e)
        { lewy_bok_2 = 2;
            menuStrip23.BackColor = Color.Red;        }
        private void toolStripMenuItem72_Click(object sender, EventArgs e)
        { lewy_bok_2 = 3;
            menuStrip23.BackColor = Color.Yellow;        }
        private void toolStripMenuItem73_Click(object sender, EventArgs e)
        { lewy_bok_2 = 4;
            menuStrip23.BackColor = Color.White;        }
        private void toolStripMenuItem74_Click(object sender, EventArgs e)
        { lewy_bok_2 = 5;
            menuStrip23.BackColor = Color.Green;        }
        private void toolStripMenuItem75_Click(object sender, EventArgs e)
        { lewy_bok_2 = 6;
            menuStrip23.BackColor = Color.Orange;        }
        

        //LEWY_BOK_3
        private void toolStripMenuItem63_Click(object sender, EventArgs e)
        {         }
        private void toolStripMenuItem64_Click(object sender, EventArgs e)
        {      }
        private void toolStripMenuItem65_Click(object sender, EventArgs e)
        {       }
        private void toolStripMenuItem66_Click(object sender, EventArgs e)
        {       }
        private void toolStripMenuItem67_Click(object sender, EventArgs e)
        {       }
        private void toolStripMenuItem68_Click(object sender, EventArgs e)
        {        }

        
        //LEWY_BOK_4
        private void toolStripMenuItem56_Click(object sender, EventArgs e)
        { lewy_bok_4 = 1;
            menuStrip21.BackColor = Color.Blue;        }
        private void toolStripMenuItem57_Click(object sender, EventArgs e)
        { lewy_bok_4 = 2;
            menuStrip21.BackColor = Color.Red;        }
        private void toolStripMenuItem58_Click(object sender, EventArgs e)
        { lewy_bok_4 = 3;
            menuStrip21.BackColor = Color.Yellow;        }
        private void toolStripMenuItem59_Click(object sender, EventArgs e)
        { lewy_bok_4 = 4;
            menuStrip21.BackColor = Color.White;        }
        private void toolStripMenuItem60_Click(object sender, EventArgs e)
        { lewy_bok_4 = 5;
            menuStrip21.BackColor = Color.Green;        }
        private void toolStripMenuItem61_Click(object sender, EventArgs e)
        { lewy_bok_4 = 6;
            menuStrip21.BackColor = Color.Orange;        }




        ////LEWY_BOK_5
        private void toolStripMenuItem49_Click(object sender, EventArgs e)
        {         }
        private void toolStripMenuItem50_Click(object sender, EventArgs e)
        {     }
        private void toolStripMenuItem51_Click(object sender, EventArgs e)
        {      }
        private void toolStripMenuItem52_Click(object sender, EventArgs e)
        {         }
        private void toolStripMenuItem53_Click(object sender, EventArgs e)
        {     }
        private void toolStripMenuItem54_Click(object sender, EventArgs e)
        {     }



        //LEWY_BOK_6
        private void toolStripMenuItem41_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem42_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem44_Click(object sender, EventArgs e)
        {      }
        private void toolStripMenuItem45_Click(object sender, EventArgs e)
        {     }
        private void toolStripMenuItem46_Click(object sender, EventArgs e)
        {    }
        private void toolStripMenuItem47_Click(object sender, EventArgs e)
        {       }



        //LEWY_BOK_7
        private void toolStripMenuItem33_Click(object sender, EventArgs e)
        { lewy_bok_7 = 1;
            menuStrip18.BackColor = Color.Blue;        }
        private void toolStripMenuItem34_Click(object sender, EventArgs e)
        { lewy_bok_7 = 2;
            menuStrip18.BackColor = Color.Red;        }
        private void toolStripMenuItem35_Click(object sender, EventArgs e)
        { lewy_bok_7 = 3;
            menuStrip18.BackColor = Color.Yellow;        }
        private void toolStripMenuItem37_Click(object sender, EventArgs e)
        { lewy_bok_7 = 4;
            menuStrip18.BackColor = Color.White;        }
        private void toolStripMenuItem38_Click(object sender, EventArgs e)
        { lewy_bok_7 =5;
            menuStrip18.BackColor = Color.Green;        }
        private void toolStripMenuItem39_Click(object sender, EventArgs e)
        { lewy_bok_7 = 6;
            menuStrip18.BackColor = Color.Orange;        }




        //LEWY_BOK_8
        private void toolStripMenuItem25_Click(object sender, EventArgs e)
        { lewy_bok_8 = 1;
            menuStrip17.BackColor = Color.Blue;        }
        private void toolStripMenuItem26_Click(object sender, EventArgs e)
        { lewy_bok_8 = 2;
            menuStrip17.BackColor = Color.Red;        }
        private void toolStripMenuItem27_Click(object sender, EventArgs e)
        { lewy_bok_8 = 3;
            menuStrip17.BackColor = Color.Yellow;        }
        private void toolStripMenuItem28_Click(object sender, EventArgs e)
        { lewy_bok_8 = 4;
            menuStrip17.BackColor = Color.White;        }
        private void toolStripMenuItem30_Click(object sender, EventArgs e)
        { lewy_bok_8 = 5;
            menuStrip17.BackColor = Color.Green;        }
        private void toolStripMenuItem31_Click(object sender, EventArgs e)
        { lewy_bok_8 = 6;
            menuStrip17.BackColor = Color.Orange;        }



        //LEWY_BOK_9
        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {      }
        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {         }
        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {      }
        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {        }


        //______________________//
        private void menuStrip33_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        //_____________________//


            


        ///......................///...................///...................///



        //PRAWY_BOK_1
        private void toolStripMenuItem140_Click(object sender, EventArgs e)
        {      }
        private void toolStripMenuItem141_Click(object sender, EventArgs e)
        {      }
        private void toolStripMenuItem142_Click(object sender, EventArgs e)
        {      }
        private void toolStripMenuItem143_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem144_Click(object sender, EventArgs e)
        {    }
        private void toolStripMenuItem145_Click(object sender, EventArgs e)
        {       }
        
                
        //PRAWY_BOK_2
        private void toolStripMenuItem133_Click(object sender, EventArgs e)
        { prawy_bok_2 = 1;
            menuStrip32.BackColor = Color.Blue;        }
        private void toolStripMenuItem134_Click(object sender, EventArgs e)
        { prawy_bok_2 = 2;
            menuStrip32.BackColor = Color.Red;        }
        private void toolStripMenuItem135_Click(object sender, EventArgs e)
        { prawy_bok_2 = 3;
            menuStrip32.BackColor = Color.Yellow;        }
        private void toolStripMenuItem136_Click(object sender, EventArgs e)
        { prawy_bok_2 = 4;
            menuStrip32.BackColor = Color.White;        }
        private void toolStripMenuItem137_Click(object sender, EventArgs e)
        { prawy_bok_2 = 5;
            menuStrip32.BackColor = Color.Green;        }
        private void toolStripMenuItem138_Click(object sender, EventArgs e)
        { prawy_bok_2 = 6;
            menuStrip32.BackColor = Color.Orange;        }



        //PRAWY_BOK_3
        private void toolStripMenuItem126_Click(object sender, EventArgs e)
        { prawy_bok_3 = 1;
            menuStrip31.BackColor = Color.Blue;        }
        private void toolStripMenuItem127_Click(object sender, EventArgs e)
        { prawy_bok_3 = 2;
            menuStrip31.BackColor = Color.Red;        }
        private void toolStripMenuItem128_Click(object sender, EventArgs e)
        { prawy_bok_3 = 3;
            menuStrip31.BackColor = Color.Yellow;        }
        private void toolStripMenuItem129_Click(object sender, EventArgs e)
        { prawy_bok_3 = 4;
            menuStrip31.BackColor = Color.White;        }
        private void toolStripMenuItem130_Click(object sender, EventArgs e)
        { prawy_bok_3 = 5;
            menuStrip31.BackColor = Color.Green;        }
        private void toolStripMenuItem131_Click(object sender, EventArgs e)
        { prawy_bok_3 = 6;
            menuStrip31.BackColor = Color.Orange;        }


        //PRAWY_BOK_4
        private void toolStripMenuItem119_Click(object sender, EventArgs e)
        {       }
        private void toolStripMenuItem120_Click(object sender, EventArgs e)
        {         }
        private void toolStripMenuItem121_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem122_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem123_Click(object sender, EventArgs e)
        {       }
        private void toolStripMenuItem124_Click(object sender, EventArgs e)
        {        }


        //PRAWY_BOK_5
        private void toolStripMenuItem112_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem113_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem114_Click(object sender, EventArgs e)
        {       }
        private void toolStripMenuItem115_Click(object sender, EventArgs e)
        {       }
        private void toolStripMenuItem116_Click(object sender, EventArgs e)
        {      }
        private void toolStripMenuItem117_Click(object sender, EventArgs e)
        {       }


        //PRAWY_BOK_6
        private void toolStripMenuItem105_Click(object sender, EventArgs e)
        { prawy_bok_6 = 1;
            menuStrip28.BackColor = Color.Blue;        }
        private void toolStripMenuItem106_Click(object sender, EventArgs e)
        { prawy_bok_6 = 2;
            menuStrip28.BackColor = Color.Red;        }
        private void toolStripMenuItem107_Click(object sender, EventArgs e)
        { prawy_bok_6 = 3;
            menuStrip28.BackColor = Color.Yellow;        }
        private void toolStripMenuItem108_Click(object sender, EventArgs e)
        { prawy_bok_6 = 4;
            menuStrip28.BackColor = Color.White;        }
        private void toolStripMenuItem109_Click(object sender, EventArgs e)
        { prawy_bok_6 = 5;
            menuStrip28.BackColor = Color.Green;        }
        private void toolStripMenuItem110_Click(object sender, EventArgs e)
        { prawy_bok_6 = 6;
            menuStrip28.BackColor = Color.Orange;        }

        //________________//
        private void toolStripMenuItem97_Click(object sender, EventArgs e)
        {        }
        private void Oblicz_Load(object sender, EventArgs e)
        {        }
        //________________//



        //PRAWY_BOK_7
        private void toolStripMenuItem98_Click(object sender, EventArgs e)
        {         }
        private void toolStripMenuItem99_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem100_Click(object sender, EventArgs e)
        {     }
        private void toolStripMenuItem101_Click(object sender, EventArgs e)
        {      }
        private void toolStripMenuItem102_Click(object sender, EventArgs e)
        {         }
        private void toolStripMenuItem103_Click(object sender, EventArgs e)
        {       }


        //PRAWY_BOK_8
        private void toolStripMenuItem91_Click(object sender, EventArgs e)
        { prawy_bok_8 = 1;
            menuStrip26.BackColor = Color.Blue;        }
        private void toolStripMenuItem92_Click(object sender, EventArgs e)
        { prawy_bok_8 = 2;
            menuStrip26.BackColor = Color.Red;        }
        private void toolStripMenuItem93_Click(object sender, EventArgs e)
        {   prawy_bok_8 = 3;
            menuStrip26.BackColor = Color.Yellow;        }
        private void toolStripMenuItem94_Click(object sender, EventArgs e)
        { prawy_bok_8 = 4;
            menuStrip26.BackColor = Color.White;        }
        private void toolStripMenuItem95_Click(object sender, EventArgs e)
        { prawy_bok_8 = 5;
            menuStrip26.BackColor = Color.Green;        }
        private void toolStripMenuItem96_Click(object sender, EventArgs e)
        { prawy_bok_8 = 6;
            menuStrip26.BackColor = Color.Orange;        }


        //PRAWY_BOK_9
        private void toolStripMenuItem84_Click(object sender, EventArgs e)
        { prawy_bok_9 = 1;
            menuStrip25.BackColor = Color.Blue;        }
        private void toolStripMenuItem85_Click(object sender, EventArgs e)
        { prawy_bok_9 = 2;
            menuStrip25.BackColor = Color.Red;        }
        private void toolStripMenuItem86_Click(object sender, EventArgs e)
        { prawy_bok_9 = 3;
            menuStrip25.BackColor = Color.Yellow;        }
        private void toolStripMenuItem87_Click(object sender, EventArgs e)
        { prawy_bok_9 = 4;
            menuStrip25.BackColor = Color.White;        }
        private void toolStripMenuItem88_Click(object sender, EventArgs e)
        { prawy_bok_9 = 5;
            menuStrip25.BackColor = Color.Green;        }
        private void toolStripMenuItem89_Click(object sender, EventArgs e)
        { prawy_bok_9 = 6;
            menuStrip25.BackColor = Color.Orange;        }
       

        ///......................///...................///...................///



        //GORA_1
        private void toolStripMenuItem203_Click(object sender, EventArgs e)
        { gora_1 = 1;
            menuStrip42.BackColor = Color.Blue;        }
        private void toolStripMenuItem204_Click(object sender, EventArgs e)
        { gora_1 = 2;
            menuStrip42.BackColor = Color.Red;        }
        private void toolStripMenuItem205_Click(object sender, EventArgs e)
        { gora_1 =3;
            menuStrip42.BackColor = Color.Yellow;        }
        private void toolStripMenuItem206_Click(object sender, EventArgs e)
        { gora_1 = 4;
            menuStrip42.BackColor = Color.White;        }
        private void toolStripMenuItem207_Click(object sender, EventArgs e)
        { gora_1 = 5;
            menuStrip42.BackColor = Color.Green;        }
        private void toolStripMenuItem208_Click(object sender, EventArgs e)
        { gora_1 = 6;
            menuStrip42.BackColor = Color.Orange;        }



        //GORA_2
        private void toolStripMenuItem196_Click(object sender, EventArgs e)
        { gora_2 = 1;
            menuStrip41.BackColor = Color.Blue;        }
        private void toolStripMenuItem197_Click(object sender, EventArgs e)
        { gora_2 = 2;
            menuStrip41.BackColor = Color.Red;        }
        private void toolStripMenuItem198_Click(object sender, EventArgs e)
        { gora_2 = 3;
            menuStrip41.BackColor = Color.Yellow;        }
        private void toolStripMenuItem199_Click(object sender, EventArgs e)
        { gora_2 = 4;
            menuStrip41.BackColor = Color.White;        }
        private void toolStripMenuItem200_Click(object sender, EventArgs e)
        { gora_2 = 5;
            menuStrip41.BackColor = Color.Green;        }
        private void toolStripMenuItem201_Click(object sender, EventArgs e)
        { gora_2 = 6;
            menuStrip41.BackColor = Color.Orange;        }


        //GORA_3
        private void toolStripMenuItem189_Click(object sender, EventArgs e)
        { gora_3 = 1;
            menuStrip40.BackColor = Color.Blue;        }
        private void toolStripMenuItem190_Click(object sender, EventArgs e)
        { gora_3 = 2;
            menuStrip40.BackColor = Color.Red;        }
        private void toolStripMenuItem191_Click(object sender, EventArgs e)
        { gora_3 =3;
            menuStrip40.BackColor = Color.Yellow;        }
        private void toolStripMenuItem192_Click(object sender, EventArgs e)
        { gora_3 = 4;
            menuStrip40.BackColor = Color.White;        }
        private void toolStripMenuItem193_Click(object sender, EventArgs e)
        { gora_3 = 5;
            menuStrip40.BackColor = Color.Green;        }
        private void toolStripMenuItem194_Click(object sender, EventArgs e)
        { gora_3 = 6;
            menuStrip40.BackColor = Color.Orange;        }


        //GORA_4
        private void toolStripMenuItem182_Click(object sender, EventArgs e)
        { gora_4 = 1;
            menuStrip39.BackColor = Color.Blue;        }
        private void toolStripMenuItem183_Click(object sender, EventArgs e)
        {   gora_4 = 2;
            menuStrip39.BackColor = Color.Red;        }
        private void toolStripMenuItem184_Click(object sender, EventArgs e)
        { gora_4 = 3;
            menuStrip39.BackColor = Color.Yellow;        }
        private void toolStripMenuItem185_Click(object sender, EventArgs e)
        { gora_4 = 4;
            menuStrip39.BackColor = Color.White;        }
        private void toolStripMenuItem186_Click(object sender, EventArgs e)
        { gora_4 = 5;
            menuStrip39.BackColor = Color.Green;        }
        private void toolStripMenuItem187_Click(object sender, EventArgs e)
        { gora_4 = 6;
            menuStrip39.BackColor = Color.Orange;        }


        //GORA_5
        private void toolStripMenuItem175_Click(object sender, EventArgs e)
        {       }
        private void toolStripMenuItem176_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem177_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem178_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem179_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem180_Click(object sender, EventArgs e)
        {       }


        //GORA_6
        private void toolStripMenuItem168_Click(object sender, EventArgs e)
        { gora_6 = 1;
            menuStrip37.BackColor = Color.Blue;        }
        private void toolStripMenuItem169_Click(object sender, EventArgs e)
        { gora_6 = 2;
            menuStrip37.BackColor = Color.Red;        }
        private void toolStripMenuItem170_Click(object sender, EventArgs e)
        { gora_6 =3;
            menuStrip37.BackColor = Color.Yellow;        }
        private void toolStripMenuItem171_Click(object sender, EventArgs e)
        { gora_6 =4;
            menuStrip37.BackColor = Color.White;        }
        private void toolStripMenuItem172_Click(object sender, EventArgs e)
        { gora_6 = 5;
            menuStrip37.BackColor = Color.Green;        }
        private void toolStripMenuItem173_Click(object sender, EventArgs e)
        { gora_6 = 6;
            menuStrip37.BackColor = Color.Orange;        }


        //GORA_7
        private void toolStripMenuItem161_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem162_Click(object sender, EventArgs e)
        {      }
        private void toolStripMenuItem163_Click(object sender, EventArgs e)
        {       }
        private void toolStripMenuItem164_Click(object sender, EventArgs e)
        {         }
        private void toolStripMenuItem165_Click(object sender, EventArgs e)
        {      }
        private void toolStripMenuItem166_Click(object sender, EventArgs e)
        {       }


        //GORA_8
        private void toolStripMenuItem154_Click(object sender, EventArgs e)
        {       }
        private void toolStripMenuItem155_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem156_Click(object sender, EventArgs e)
        {       }
        private void toolStripMenuItem157_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem158_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem159_Click(object sender, EventArgs e)
        {       }


        //GORA_9
        private void toolStripMenuItem147_Click(object sender, EventArgs e)
        {       }
        private void toolStripMenuItem148_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem149_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem150_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem151_Click(object sender, EventArgs e)
        {       }
        private void toolStripMenuItem152_Click(object sender, EventArgs e)
        {        }


        ///......................///...................///...................///



        //DOL_1
        private void toolStripMenuItem266_Click(object sender, EventArgs e)
        {       }
        private void toolStripMenuItem267_Click(object sender, EventArgs e)
        {       }
        private void toolStripMenuItem268_Click(object sender, EventArgs e)
        {       }
        private void toolStripMenuItem269_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem270_Click(object sender, EventArgs e)
        {         }
        private void toolStripMenuItem271_Click(object sender, EventArgs e)
        {       }


        //DOL_2
        private void toolStripMenuItem259_Click(object sender, EventArgs e)
        {       }
        private void toolStripMenuItem260_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem261_Click(object sender, EventArgs e)
        {     }
        private void toolStripMenuItem262_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem263_Click(object sender, EventArgs e)
        {      }
        private void toolStripMenuItem264_Click(object sender, EventArgs e)
        {       }

        //DOL_3
        private void toolStripMenuItem252_Click(object sender, EventArgs e)
        {         }
        private void toolStripMenuItem253_Click(object sender, EventArgs e)
        {         }
        private void toolStripMenuItem254_Click(object sender, EventArgs e)
        {       }
        private void toolStripMenuItem255_Click(object sender, EventArgs e)
        {         }
        private void toolStripMenuItem256_Click(object sender, EventArgs e)
        {      }
        private void toolStripMenuItem257_Click(object sender, EventArgs e)
        {     }

        //DOL_4
        private void toolStripMenuItem245_Click(object sender, EventArgs e)
        { dol_4 = 1;
            menuStrip48.BackColor = Color.Blue;        }
        private void toolStripMenuItem246_Click(object sender, EventArgs e)
        { dol_4 = 2;
            menuStrip48.BackColor = Color.Red;        }
        private void toolStripMenuItem247_Click(object sender, EventArgs e)
        { dol_4 = 3;
            menuStrip48.BackColor = Color.Yellow;        }
        private void toolStripMenuItem248_Click(object sender, EventArgs e)
        { dol_4 = 4;
            menuStrip48.BackColor = Color.White;        }
        private void toolStripMenuItem249_Click(object sender, EventArgs e)
        { dol_4 = 5;
            menuStrip48.BackColor = Color.Green;        }
        private void toolStripMenuItem250_Click(object sender, EventArgs e)
        { dol_4 = 6;
            menuStrip48.BackColor = Color.Orange;        }

        //DOL_5
        private void toolStripMenuItem238_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem239_Click(object sender, EventArgs e)
        {       }
        private void toolStripMenuItem240_Click(object sender, EventArgs e)
        {     }
        private void toolStripMenuItem241_Click(object sender, EventArgs e)
        {      }
        private void toolStripMenuItem242_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem243_Click(object sender, EventArgs e)
        {     }

        //DOL_6
        private void toolStripMenuItem231_Click(object sender, EventArgs e)
        { dol_6 = 1;
            menuStrip46.BackColor = Color.Blue;        }
        private void toolStripMenuItem232_Click(object sender, EventArgs e)
        { dol_6 = 2;
            menuStrip46.BackColor = Color.Red;        }
        private void toolStripMenuItem233_Click(object sender, EventArgs e)
        { dol_6 =3;
            menuStrip46.BackColor = Color.Yellow;        }
        private void toolStripMenuItem234_Click(object sender, EventArgs e)
        { dol_6 =4;
            menuStrip46.BackColor = Color.White;        }
        private void toolStripMenuItem235_Click(object sender, EventArgs e)
        { dol_6 = 5;
            menuStrip46.BackColor = Color.Green;        }
        private void toolStripMenuItem236_Click(object sender, EventArgs e)
        { dol_6 = 6;
            menuStrip46.BackColor = Color.Orange;        }

        //DOL_7
        private void toolStripMenuItem224_Click(object sender, EventArgs e)
        { dol_7 = 1;
            menuStrip45.BackColor = Color.Blue;        }
        private void toolStripMenuItem225_Click(object sender, EventArgs e)
        { dol_7 = 2;
            menuStrip45.BackColor = Color.Red;        }
        private void toolStripMenuItem226_Click(object sender, EventArgs e)
        { dol_7 = 3;
            menuStrip45.BackColor = Color.Yellow;        }
        private void toolStripMenuItem227_Click(object sender, EventArgs e)
        { dol_7 = 4;
            menuStrip45.BackColor = Color.White;        }
        private void toolStripMenuItem228_Click(object sender, EventArgs e)
        { dol_7 = 5;
            menuStrip45.BackColor = Color.Green;        }
        private void toolStripMenuItem229_Click(object sender, EventArgs e)
        { dol_7 = 6;
            menuStrip45.BackColor = Color.Orange;        }

        //DOL_8
        private void toolStripMenuItem217_Click(object sender, EventArgs e)
        { dol_8 = 1;
            menuStrip44.BackColor = Color.Blue;        }
        private void toolStripMenuItem218_Click(object sender, EventArgs e)
        { dol_8 = 2;
            menuStrip44.BackColor = Color.Red;        }
        private void toolStripMenuItem219_Click(object sender, EventArgs e)
        { dol_8 = 3;
            menuStrip44.BackColor = Color.Yellow;        }
        private void toolStripMenuItem220_Click(object sender, EventArgs e)
        { dol_8 = 4;
            menuStrip44.BackColor = Color.White;        }
        private void toolStripMenuItem221_Click(object sender, EventArgs e)
        { dol_8 = 5;
            menuStrip44.BackColor = Color.Green;        }
        private void toolStripMenuItem222_Click(object sender, EventArgs e)
        { dol_8 = 6;
            menuStrip44.BackColor = Color.Orange;        }

        //DOL_9
        private void toolStripMenuItem210_Click(object sender, EventArgs e)
        { dol_9 = 1;
            menuStrip43.BackColor = Color.Blue;        }
        private void toolStripMenuItem211_Click(object sender, EventArgs e)
        { dol_9 = 2;
            menuStrip43.BackColor = Color.Red;        }
        private void toolStripMenuItem212_Click(object sender, EventArgs e)
        { dol_9 = 3;
            menuStrip43.BackColor = Color.Yellow;        }
        private void toolStripMenuItem213_Click(object sender, EventArgs e)
        { dol_9 = 4;
            menuStrip43.BackColor = Color.White;        }
        private void toolStripMenuItem214_Click(object sender, EventArgs e)
        { dol_9 = 5;
            menuStrip43.BackColor = Color.Green;        }
        private void toolStripMenuItem215_Click(object sender, EventArgs e)
        { dol_9 = 6;
            menuStrip43.BackColor = Color.Orange;        }
        #endregion

        private void menuStrip26_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lista_tyl_1_Click(object sender, EventArgs e)
        {

        }
    }
}
