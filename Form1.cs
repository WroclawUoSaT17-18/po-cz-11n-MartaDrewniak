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
        string pojemnik_tymczasowy_1;
        string pojemnik_tymczasowy_2;
        string pojemnik_tymczasowy_3;
        string pojemnik_tymczasowy_4;

        string tyl_1;
        string tyl_2;
        string tyl_3;
        string tyl_4;
        string tyl_5;
        string tyl_6;
        string tyl_7;
        string tyl_8;
        string tyl_9;

        string gora_1;
        string gora_2;
        string gora_3;
        string gora_4;
        string gora_5;
        string gora_6;
        string gora_7;
        string gora_8;
        string gora_9;

        string dol_1;
        string dol_2;
        string dol_3;
        string dol_4;
        string dol_5;
        string dol_6;
        string dol_7;
        string dol_8;
        string dol_9;

        string przod_1;
        string przod_2;
        string przod_3;
        string przod_4;
        string przod_5;
        string przod_6;
        string przod_7;
        string przod_8;
        string przod_9;

        string prawy_bok_1;
        string prawy_bok_2;
        string prawy_bok_3;
        string prawy_bok_4;
        string prawy_bok_5;
        string prawy_bok_6;
        string prawy_bok_7;
        string prawy_bok_8;
        string prawy_bok_9;

        string lewy_bok_1;
        string lewy_bok_2;
        string lewy_bok_3;
        string lewy_bok_4;
        string lewy_bok_5;
        string lewy_bok_6;
        string lewy_bok_7;
        string lewy_bok_8;
        string lewy_bok_9;
   





        public Oblicz()
        {            InitializeComponent();        }
            
        private void menuStrip15_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {        }         




        private void button1_Click(object sender, EventArgs e)
        {
            if (tyl_1 == "niebieski")
            {
                MessageBox.Show("działa");
            };

        }


        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do widzenia :)");
            this.Close();
        }








        //===============|    Metody  |================//

        void obrot_R() //         R' gdzies jest blad
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

        void obrot_L() //                 L
        {
            pojemnik_tymczasowy_1 = gora_1;
            pojemnik_tymczasowy_2 = gora_4;
            pojemnik_tymczasowy_3 = gora_7;

            gora_1 = tyl_9;
            gora_4 = tyl_6;
            gora_7= tyl_3;

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
            pojemnik_tymczasowy_3 = lewy_bok_6;
           
            lewy_bok_3 = lewy_bok_1;
            lewy_bok_1 = lewy_bok_7;
            lewy_bok_2 = lewy_bok_4;
            lewy_bok_4 = lewy_bok_8;
            lewy_bok_7 = lewy_bok_9;
            lewy_bok_8 = lewy_bok_6;            
            lewy_bok_6 = pojemnik_tymczasowy_2;
            lewy_bok_9 = pojemnik_tymczasowy_1;
            lewy_bok_8 = pojemnik_tymczasowy_3;                    
            
           
        }

        void obrot_F() //                 F
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
            pojemnik_tymczasowy_3 = przod_6;

            przod_3 = przod_1;
            przod_1 = przod_7;
            przod_2 = przod_4;
            przod_4 = przod_8;
            przod_7 = przod_9;
            przod_8 = przod_6;
            przod_6 = pojemnik_tymczasowy_2;
            przod_9 = pojemnik_tymczasowy_1;
            przod_8 = pojemnik_tymczasowy_3;
        }
        void obrot_B() //                 B jeszcze nie zaczelam , zrobiona plaszczyzna
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

            pojemnik_tymczasowy_1 = tyl_3;
            pojemnik_tymczasowy_2 = tyl_2;
            pojemnik_tymczasowy_3 = tyl_6;

            tyl_3 = tyl_1;
            tyl_1 = tyl_7;
            tyl_2 = tyl_4;
            tyl_4 = tyl_8;
            tyl_7 = tyl_9;
            tyl_8 = tyl_6;
            tyl_6 = pojemnik_tymczasowy_2;
            tyl_9 = pojemnik_tymczasowy_1;
            tyl_8 = pojemnik_tymczasowy_3;
        }

        /* obrot plaszczyzny
         
            U
            pojemnik_tymczasowy_1 = gora_3;
            pojemnik_tymczasowy_2 = gora_2;
            pojemnik_tymczasowy_3 = gora_6;

            gora_3 = gora_1;
            gora_1 = gora_7;
            gora_2 = gora_4;
            gora_4 = gora_8;
            gora_7 = gora_9;
            gora_8 = gora_6;
            gora_6 = pojemnik_tymczasowy_2;
            gora_9 = pojemnik_tymczasowy_1;
            gora_8 = pojemnik_tymczasowy_3;


            D

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



            R
            pojemnik_tymczasowy_1 = prawy_bok_3;
            pojemnik_tymczasowy_2 = prawy_bok_2;
            pojemnik_tymczasowy_3 = prawy_bok_6;

            prawy_bok_3 = prawy_bok_1;
            prawy_bok_1 = prawy_bok_7;
            prawy_bok_2 = prawy_bok_4;
            prawy_bok_4 = prawy_bok_8;
            prawy_bok_7 = prawy_bok_9;
            prawy_bok_8 = prawy_bok_6;
            prawy_bok_6 = pojemnik_tymczasowy_2;
            prawy_bok_9 = pojemnik_tymczasowy_1;
            prawy_bok_8 = pojemnik_tymczasowy_3;



         */


        //===============|    Wybor KOloru  |================//                 


        //tyl_1
        public void niebieski_tyl_1_Click(object sender, EventArgs e)
        { tyl_1 = "niebieski"; }
        private void czerwony_tyl_1_Click(object sender, EventArgs e)
        { tyl_1 = "czerwony"; }
        private void bialy_tyl_1_Click_1(object sender, EventArgs e)
        { tyl_1 = "bialy"; }
        private void zolty_tyl_1_Click(object sender, EventArgs e)
        { tyl_1 = "zolty"; }
        private void zielony_tyl_1_Click(object sender, EventArgs e)
        { tyl_1 = "zielony"; }
        private void pomaranczowy_tyl_1_Click(object sender, EventArgs e)
        { tyl_1 = "pomaranczowy"; }

        //TYL_2 
        private void niebieski_tyl_2_Click(object sender, EventArgs e)
        { tyl_2 = "niebieski"; }
        private void czerwony_tyl_2_Click(object sender, EventArgs e)
        { tyl_2 = "czerwony"; }
        private void zolty_tyl_2_Click(object sender, EventArgs e)
        { tyl_2 = "zolty"; }
        private void bialy_tyl_2_Click(object sender, EventArgs e)
        { tyl_2 = "bialy"; }
        private void zielony_tyl_2_Click(object sender, EventArgs e)
        { tyl_2 = "zielony"; }
        private void pomaranczowy_tyl_2_Click(object sender, EventArgs e)
        { tyl_2 = "pomaranczowy"; }

        //TYL_3
        private void niebieski_tyl_3_Click(object sender, EventArgs e)
        {  tyl_3 = "niebieski"; }
        private void czerwony_tyl_3_Click(object sender, EventArgs e)
        { tyl_3 = "czerwony"; }
        private void zolty_tyl_3_Click(object sender, EventArgs e)
        { tyl_3 =  "zolty"; }
        private void bialy_tyl_3_Click(object sender, EventArgs e)
        { tyl_3 = "bialy"; }
        private void zielony_tyl_3_Click(object sender, EventArgs e)
        { tyl_3 = "zielony"; }
        private void pomaranczowy_tyl_3_Click(object sender, EventArgs e)
        { tyl_3 = "pomaranczowy"; }

        
        //TYL_4
        private void niebieski_tyl_4_Click(object sender, EventArgs e)
        {   tyl_4 = "niebieski"; }
        private void czerwony_tyl_4_Click(object sender, EventArgs e)
        { tyl_4 = "czerwony";   }
        private void zolty_tyl_4_Click(object sender, EventArgs e)
        { tyl_4 = "zolty"; }
        private void bialy_tyl_4_Click(object sender, EventArgs e)
        { tyl_4 = "bialy"; }
        private void zielony_tyl_4_Click(object sender, EventArgs e)
        { tyl_4 = "zielony"; }
        private void pomaranczowy_tyl_4_Click(object sender, EventArgs e)
        { tyl_4 = "pomaranczowy"; }


        //TYL_5
        private void niebieski_tyl_5_Click(object sender, EventArgs e)
        { tyl_5 = "niebieski"; }
        private void czerwony_tyl_5_Click(object sender, EventArgs e)
        { tyl_5 = "czerwony"; }
        private void zolty_tyl_5_Click(object sender, EventArgs e)
        { tyl_5 = "zolty"; }
        private void bialy_tyl_5_Click(object sender, EventArgs e)
        { tyl_5 = "bialy"; }
        private void zielony_tyl_5_Click(object sender, EventArgs e)
        { tyl_5 = "zielony"; }
        private void pomaranczowy_tyl_5_Click(object sender, EventArgs e)
        { tyl_5 = "pomaranczowy"; }


        //TYL_6
        private void niebieski_tyl_6_Click(object sender, EventArgs e)
        { tyl_6 = "niebieski"; }
        private void czerwony_tyl_6_Click(object sender, EventArgs e)
        { tyl_6 = "czerwony"; }
        private void zolty_tyl_6_Click(object sender, EventArgs e)
        { tyl_6 = "zolty"; }
        private void bialy_tyl_6_Click(object sender, EventArgs e)
        { tyl_6 = "bialy"; }
        private void zielony_tyl_6_Click(object sender, EventArgs e)
        { tyl_6 = "zielony"; }
        private void pomaranczowy_tyl_6_Click(object sender, EventArgs e)
        { tyl_6 = "pomaranczowy"; }


        //TYL_7
        private void niebieski_tyl_7_Click(object sender, EventArgs e)
        { tyl_7 = "niebieski"; }
        private void czerwony_tyl_7_Click(object sender, EventArgs e)
        { tyl_7 = "czerwony"; }
        private void zolty_tyl_7_Click(object sender, EventArgs e)
        { tyl_7 = "zolty"; }
        private void bialy_tyl_7_Click(object sender, EventArgs e)
        { tyl_7 = "bialy"; }
        private void zielony_tyl_7_Click(object sender, EventArgs e)
        { tyl_7 = "zielony"; }
        private void pomaranczowy_tyl_7_Click(object sender, EventArgs e)
        { tyl_7 = "pomaranczowy"; }


        //TYL_8
        private void niebieski_tyl_8_Click(object sender, EventArgs e)
        { tyl_8 = "niebieski"; }
        private void czerwony_tyl_8_Click(object sender, EventArgs e)
        { tyl_8 = "czerwony"; }
        private void zolty_tyl_8_Click(object sender, EventArgs e)
        { tyl_8 = "zolty"; }
        private void bialy_tyl_8_Click(object sender, EventArgs e)
        { tyl_8 = "bialy"; }
        private void zielony_tyl_8_Click(object sender, EventArgs e)
        { tyl_8 = "zielony"; }
        private void pomaranczowy_tyl_8_Click(object sender, EventArgs e)
        { tyl_8 = "pomaranczowy"; }



        //TYL_9
        private void niebieski_tyl_9_Click(object sender, EventArgs e)
        { tyl_9 = "niebieski"; }
        private void czerwony_tyl_9_Click(object sender, EventArgs e)
        { tyl_9 = "czerwony"; }
        private void zolty_tyl_9_Click(object sender, EventArgs e)
        { tyl_9 = "zolty"; }
        private void bialy_tyl_9_Click(object sender, EventArgs e)
        { tyl_9 = "bialy"; }
        private void zielony_tyl_9_Click(object sender, EventArgs e)
        { tyl_9 = "zielony"; }
        private void pomaranczowy_tyl_9_Click(object sender, EventArgs e)
        { tyl_9 = "pomaranczowy"; }

        
        ///......................///...................///...................///
                    

        //PRZOD_1
        private void niebieski_przod_1_Click(object sender, EventArgs e)
        { przod_1 = "niebieski"; }
        private void czerwony_przod_1_Click(object sender, EventArgs e)
        { przod_1 = "czerwony"; }
        private void zolty_przod_1_Click(object sender, EventArgs e)
        { przod_1 = "zolty"; }
        private void bialy_przod_1_Click(object sender, EventArgs e)
        { przod_1 = "bialy"; }
        private void zielony_przod_1_Click(object sender, EventArgs e)
        { przod_1 = "zielony"; }
        private void pomaranczowy_przod_1_Click(object sender, EventArgs e)
        { przod_1 = "pomaranczowy"; }


        //PRZOD_2
        private void niebieski_przod_2_Click(object sender, EventArgs e)
        { przod_2 = "niebieski"; }      
        private void czerwony_przod_2_Click(object sender, EventArgs e)
        { przod_2 = "czerwony"; }
        private void zolty_przod_2_Click(object sender, EventArgs e)
        { przod_2 = "zolty"; }
        private void bialy_przod_2_Click(object sender, EventArgs e)
        { przod_2 = "bialy"; }
        private void zielony_przod_2_Click(object sender, EventArgs e)
        { przod_2 = "zielony"; }
        private void pomaranczowy_przod_2_Click(object sender, EventArgs e)
        { przod_2 = "pomaranczowy"; }


        //PRZOD_3        
        private void niebieski_przod_3_Click(object sender, EventArgs e)
        { przod_3 = "niebieski"; }
        private void czerwony_przod_3_Click(object sender, EventArgs e)
        { przod_3 = "czerwony"; }
        private void zolty_przod_3_Click(object sender, EventArgs e)
        { przod_3 = "zolty"; }
        private void bialy_przod_3_Click(object sender, EventArgs e)
        { przod_3 = "bialy"; }
        private void zielony_przod_3_Click(object sender, EventArgs e)
        { przod_3 = "zielony"; }
        private void pomaranczowy_przod_3_Click(object sender, EventArgs e)
        { przod_3 = "pomaranczowy"; }


        //PRZOD_4
        private void niebieski_przod_4_Click(object sender, EventArgs e)
        { przod_4 = "niebieski"; }
        private void czerwony_przod_4_Click(object sender, EventArgs e)
        { przod_4 = "czerwony"; }
        private void zolty_przod_4_Click(object sender, EventArgs e)
        { przod_4 = "zolty"; }
        private void bialy_przod_4_Click(object sender, EventArgs e)
        { przod_4 = "bialy"; }
        private void zielony_przod_4_Click(object sender, EventArgs e)
        { przod_4 = "zielony"; }
        private void pomaranczowy_przod_4_Click(object sender, EventArgs e)
        { przod_4 = "pomaranczowy"; }


        //PRZOD_5
        private void niebieski_przod_5_Click(object sender, EventArgs e)
        { przod_5 = "niebieski"; }
        private void czerwony_przod_5_Click(object sender, EventArgs e)
        { przod_5 = "czerwony"; }
        private void zolty_przod_5_Click(object sender, EventArgs e)
        { przod_5 = "zolty"; }
        private void bialy_przod_5_Click(object sender, EventArgs e)
        { przod_5 = "bialy"; }
        private void zielony_przod_5_Click(object sender, EventArgs e)
        { przod_5 = "zielony"; }
        private void pomaranczowy_przod_5_Click(object sender, EventArgs e)
        { przod_5 = "pomaranczowy"; }


        //PRZOD_6
        private void niebieski_przod_6_Click(object sender, EventArgs e)
        { przod_6 = "niebieski"; }
        private void czerwony_przod_6_Click(object sender, EventArgs e)
        { przod_6 = "czerwony"; }
        private void zolty_przod_6_Click(object sender, EventArgs e)
        { przod_6 = "zolty"; }
        private void bialy_przod_6_Click(object sender, EventArgs e)
        { przod_6 = "bialy"; }
        private void zielony_przod_6_Click(object sender, EventArgs e)
        { przod_6 = "zielony"; }
        private void pomaranczowy_przod_6_Click(object sender, EventArgs e)
        { przod_6 = "pomaranczowy"; }


        //PRZOD_7
        private void niebieski_przod_7_Click(object sender, EventArgs e)
        { przod_7 = "niebieski"; }
        private void czerwony_przod_7_Click(object sender, EventArgs e)
        { przod_7 = "czerwony"; }
        private void zolty_przod_7_Click(object sender, EventArgs e)
        { przod_7 = "zolty"; }
        private void bialy_przod_7_Click(object sender, EventArgs e)
        { przod_7 = "bialy"; }
        private void zielony_przod_7_Click(object sender, EventArgs e)
        { przod_7 = "zielony"; }
        private void pomaranczowy_przod_7_Click(object sender, EventArgs e)
        { przod_7 = "pomaranczowy"; }


        //PRZOD_8
        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        { przod_8 = "niebieski"; }
        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        { przod_8 = "czerwony"; }
        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        { przod_8 = "zolty"; }
        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        { przod_8 = "bialy"; }
        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        { przod_8 = "zielony"; }
        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        { przod_8 = "pomaranczowy"; }


        //PRZOD_9
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        { przod_9 = "niebieski"; }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        { przod_9 = "czerwony"; }
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        { przod_9 = "zolty"; }
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        { przod_9 = "bialy"; }
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        { przod_9 = "zielony"; }
        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        { przod_9 = "pomaranczowy"; }


        

        ///......................///...................///...................///
        


        //LEWY_BOK_1
        private void toolStripMenuItem77_Click(object sender, EventArgs e)
        { lewy_bok_1 = "niebieski"; }
        private void toolStripMenuItem78_Click(object sender, EventArgs e)
        { lewy_bok_1 = "czerwony"; }
        private void toolStripMenuItem79_Click(object sender, EventArgs e)
        { lewy_bok_1 = "zolty"; }
        private void toolStripMenuItem80_Click(object sender, EventArgs e)
        { lewy_bok_1 = "bialy"; }
        private void toolStripMenuItem81_Click(object sender, EventArgs e)
        { lewy_bok_1 = "zielony"; }
        private void toolStripMenuItem82_Click(object sender, EventArgs e)
        { lewy_bok_1 = "pomaranczowy"; }



        //LEWY_BOK_2
        private void toolStripMenuItem70_Click(object sender, EventArgs e)
        { lewy_bok_2 = "niebieski"; }
        private void toolStripMenuItem71_Click(object sender, EventArgs e)
        { lewy_bok_2 = "czerwony"; }
        private void toolStripMenuItem72_Click(object sender, EventArgs e)
        { lewy_bok_2 = "zolty"; }
        private void toolStripMenuItem73_Click(object sender, EventArgs e)
        { lewy_bok_2 = "bialy"; }
        private void toolStripMenuItem74_Click(object sender, EventArgs e)
        { lewy_bok_2 = "zielony"; }
        private void toolStripMenuItem75_Click(object sender, EventArgs e)
        { lewy_bok_2 = "pomaranczowy"; }



        //LEWY_BOK_3
        private void toolStripMenuItem63_Click(object sender, EventArgs e)
        { lewy_bok_3 = "niebieski"; }
        private void toolStripMenuItem64_Click(object sender, EventArgs e)
        { lewy_bok_3 = "czerwony"; }
        private void toolStripMenuItem65_Click(object sender, EventArgs e)
        { lewy_bok_3 = "zolty"; }
        private void toolStripMenuItem66_Click(object sender, EventArgs e)
        { lewy_bok_3 = "bialy"; }
        private void toolStripMenuItem67_Click(object sender, EventArgs e)
        { lewy_bok_3 = "zielony"; }
        private void toolStripMenuItem68_Click(object sender, EventArgs e)
        { lewy_bok_3 = "pomaranczowy"; }

        

        //LEWY_BOK_4
        private void toolStripMenuItem56_Click(object sender, EventArgs e)
        { lewy_bok_4 = "niebieski"; }
        private void toolStripMenuItem57_Click(object sender, EventArgs e)
        { lewy_bok_4 = "czerwony"; }
        private void toolStripMenuItem58_Click(object sender, EventArgs e)
        { lewy_bok_4 = "zolty"; }
        private void toolStripMenuItem59_Click(object sender, EventArgs e)
        { lewy_bok_4 = "bialy"; }
        private void toolStripMenuItem60_Click(object sender, EventArgs e)
        { lewy_bok_4 = "zielony"; }
        private void toolStripMenuItem61_Click(object sender, EventArgs e)
        { lewy_bok_4 = "pomaranczowy"; }




        ////LEWY_BOK_5
        private void toolStripMenuItem49_Click(object sender, EventArgs e)
        { lewy_bok_5 = "niebieski"; }
        private void toolStripMenuItem50_Click(object sender, EventArgs e)
        { lewy_bok_5 = "czerwony"; }
        private void toolStripMenuItem51_Click(object sender, EventArgs e)
        { lewy_bok_5 = "zolty"; }
        private void toolStripMenuItem52_Click(object sender, EventArgs e)
        { lewy_bok_5 = "bialy"; }
        private void toolStripMenuItem53_Click(object sender, EventArgs e)
        { lewy_bok_5 = "zielony"; }
        private void toolStripMenuItem54_Click(object sender, EventArgs e)
        { lewy_bok_5 = "pomaranczowy"; }



        //LEWY_BOK_6
        private void toolStripMenuItem41_Click(object sender, EventArgs e)
        { lewy_bok_6 = "niebieski"; }
        private void toolStripMenuItem42_Click(object sender, EventArgs e)
        { lewy_bok_6 = "czerwony"; }
        private void toolStripMenuItem44_Click(object sender, EventArgs e)
        { lewy_bok_6 = "zolty"; }
        private void toolStripMenuItem45_Click(object sender, EventArgs e)
        { lewy_bok_6 = "bialy"; }
        private void toolStripMenuItem46_Click(object sender, EventArgs e)
        { lewy_bok_6 = "zielony"; }
        private void toolStripMenuItem47_Click(object sender, EventArgs e)
        { lewy_bok_6 = "pomaranczowy"; }



        //LEWY_BOK_7
        private void toolStripMenuItem33_Click(object sender, EventArgs e)
        { lewy_bok_7 = "niebieski"; }
        private void toolStripMenuItem34_Click(object sender, EventArgs e)
        { lewy_bok_7 = "czerwony"; }
        private void toolStripMenuItem35_Click(object sender, EventArgs e)
        { lewy_bok_7 = "zolty"; }
        private void toolStripMenuItem37_Click(object sender, EventArgs e)
        { lewy_bok_7 = "bialy"; }
        private void toolStripMenuItem38_Click(object sender, EventArgs e)
        { lewy_bok_7 = "zielony"; }
        private void toolStripMenuItem39_Click(object sender, EventArgs e)
        { lewy_bok_7 = "pomaranczowy"; }




        //LEWY_BOK_8
        private void toolStripMenuItem25_Click(object sender, EventArgs e)
        { lewy_bok_8 = "niebieski"; }
        private void toolStripMenuItem26_Click(object sender, EventArgs e)
        { lewy_bok_8 = "czerwony"; }
        private void toolStripMenuItem27_Click(object sender, EventArgs e)
        { lewy_bok_8 = "zolty"; }
        private void toolStripMenuItem28_Click(object sender, EventArgs e)
        { lewy_bok_8 = "bialy"; }
        private void toolStripMenuItem30_Click(object sender, EventArgs e)
        { lewy_bok_8 = "zielony"; }
        private void toolStripMenuItem31_Click(object sender, EventArgs e)
        { lewy_bok_8 = "pomaranczowy"; }



        //LEWY_BOK_9
        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        { lewy_bok_9 = "niebieski"; }
        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        { lewy_bok_9 = "czerwony"; }
        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        { lewy_bok_9 = "zolty"; }
        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        { lewy_bok_9 = "bialy"; }
        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        { lewy_bok_9 = "zielony"; }
        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        { lewy_bok_9 = "pomaranczowy"; }


        //______________________//
        private void menuStrip33_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        //_____________________//


            


        ///......................///...................///...................///



        //PRAWY_BOK_1
        private void toolStripMenuItem140_Click(object sender, EventArgs e)
        { prawy_bok_1 = "niebieski"; }
        private void toolStripMenuItem141_Click(object sender, EventArgs e)
        { prawy_bok_1 = "czerwony"; }
        private void toolStripMenuItem142_Click(object sender, EventArgs e)
        { prawy_bok_1 = "zolty"; }
        private void toolStripMenuItem143_Click(object sender, EventArgs e)
        { prawy_bok_1 = "bialy"; }
        private void toolStripMenuItem144_Click(object sender, EventArgs e)
        { prawy_bok_1 = "zielony"; }
        private void toolStripMenuItem145_Click(object sender, EventArgs e)
        { prawy_bok_1 = "pomaranczowy"; }
        
                
        //PRAWY_BOK_2
        private void toolStripMenuItem133_Click(object sender, EventArgs e)
        { prawy_bok_2 = "niebieski"; }
        private void toolStripMenuItem134_Click(object sender, EventArgs e)
        { prawy_bok_2 = "czerwony"; }
        private void toolStripMenuItem135_Click(object sender, EventArgs e)
        { prawy_bok_2 = "zolty"; }
        private void toolStripMenuItem136_Click(object sender, EventArgs e)
        { prawy_bok_2 = "bialy"; }
        private void toolStripMenuItem137_Click(object sender, EventArgs e)
        { prawy_bok_2 = "zielony"; }
        private void toolStripMenuItem138_Click(object sender, EventArgs e)
        { prawy_bok_2 = "pomaranczowy"; }



        //PRAWY_BOK_3
        private void toolStripMenuItem126_Click(object sender, EventArgs e)
        { prawy_bok_3 = "niebieski"; }
        private void toolStripMenuItem127_Click(object sender, EventArgs e)
        { prawy_bok_3 = "czerwony"; }
        private void toolStripMenuItem128_Click(object sender, EventArgs e)
        { prawy_bok_3 = "zolty"; }
        private void toolStripMenuItem129_Click(object sender, EventArgs e)
        { prawy_bok_3 = "bialy"; }
        private void toolStripMenuItem130_Click(object sender, EventArgs e)
        { prawy_bok_3 = "zielony"; }
        private void toolStripMenuItem131_Click(object sender, EventArgs e)
        { prawy_bok_3 = "pomaranczowy"; }


        //PRAWY_BOK_4
        private void toolStripMenuItem119_Click(object sender, EventArgs e)
        { prawy_bok_4 = "niebieski"; }
        private void toolStripMenuItem120_Click(object sender, EventArgs e)
        { prawy_bok_4 = "czerwony"; }
        private void toolStripMenuItem121_Click(object sender, EventArgs e)
        { prawy_bok_4 = "zolty"; }
        private void toolStripMenuItem122_Click(object sender, EventArgs e)
        { prawy_bok_4 = "bialy"; }
        private void toolStripMenuItem123_Click(object sender, EventArgs e)
        { prawy_bok_4 = "zielony"; }
        private void toolStripMenuItem124_Click(object sender, EventArgs e)
        { prawy_bok_4 = "pomaranczowy"; }


        //PRAWY_BOK_5
        private void toolStripMenuItem112_Click(object sender, EventArgs e)
        { prawy_bok_5 = "niebieski"; }
        private void toolStripMenuItem113_Click(object sender, EventArgs e)
        { prawy_bok_5 = "czerwony"; }
        private void toolStripMenuItem114_Click(object sender, EventArgs e)
        { prawy_bok_5 = "zolty"; }
        private void toolStripMenuItem115_Click(object sender, EventArgs e)
        { prawy_bok_5 = "bialy"; }
        private void toolStripMenuItem116_Click(object sender, EventArgs e)
        { prawy_bok_5 = "zielony"; }
        private void toolStripMenuItem117_Click(object sender, EventArgs e)
        { prawy_bok_5 = "pomaranczowy"; }


        //PRAWY_BOK_6
        private void toolStripMenuItem105_Click(object sender, EventArgs e)
        { prawy_bok_6 = "niebieski"; }
        private void toolStripMenuItem106_Click(object sender, EventArgs e)
        { prawy_bok_6 = "czerwony"; }
        private void toolStripMenuItem107_Click(object sender, EventArgs e)
        { prawy_bok_6 = "zolty"; }
        private void toolStripMenuItem108_Click(object sender, EventArgs e)
        { prawy_bok_6 = "bialy"; }
        private void toolStripMenuItem109_Click(object sender, EventArgs e)
        { prawy_bok_6 = "zielony"; }
        private void toolStripMenuItem110_Click(object sender, EventArgs e)
        { prawy_bok_6 = "pomaranczowy"; }

        //________________//
        private void toolStripMenuItem97_Click(object sender, EventArgs e)
        {

        }
        private void Oblicz_Load(object sender, EventArgs e)
        {        }
        //________________//



        //PRAWY_BOK_7
        private void toolStripMenuItem98_Click(object sender, EventArgs e)
        { prawy_bok_7 = "niebieski"; }
        private void toolStripMenuItem99_Click(object sender, EventArgs e)
        { prawy_bok_7 = "czerwony"; }
        private void toolStripMenuItem100_Click(object sender, EventArgs e)
        { prawy_bok_7 = "zolty"; }
        private void toolStripMenuItem101_Click(object sender, EventArgs e)
        { prawy_bok_7 = "bialy"; }
        private void toolStripMenuItem102_Click(object sender, EventArgs e)
        { prawy_bok_7 = "zielony"; }
        private void toolStripMenuItem103_Click(object sender, EventArgs e)
        { prawy_bok_7 = "pomaranczowy"; }


        //PRAWY_BOK_8
        private void toolStripMenuItem91_Click(object sender, EventArgs e)
        { prawy_bok_8 = "niebieski"; }
        private void toolStripMenuItem92_Click(object sender, EventArgs e)
        { prawy_bok_8 = "czerwony"; }
        private void toolStripMenuItem93_Click(object sender, EventArgs e)
        { prawy_bok_8 = "zolty"; }
        private void toolStripMenuItem94_Click(object sender, EventArgs e)
        { prawy_bok_8 = "bialy"; }
        private void toolStripMenuItem95_Click(object sender, EventArgs e)
        { prawy_bok_8 = "zielony"; }
        private void toolStripMenuItem96_Click(object sender, EventArgs e)
        { prawy_bok_8 = "pomaranczowy"; }


        //PRAWY_BOK_9
        private void toolStripMenuItem84_Click(object sender, EventArgs e)
        { prawy_bok_9 = "niebieski"; }
        private void toolStripMenuItem85_Click(object sender, EventArgs e)
        { prawy_bok_9 = "czerwony"; }
        private void toolStripMenuItem86_Click(object sender, EventArgs e)
        { prawy_bok_9 = "zolty"; }
        private void toolStripMenuItem87_Click(object sender, EventArgs e)
        { prawy_bok_9 = "bialy"; }
        private void toolStripMenuItem88_Click(object sender, EventArgs e)
        { prawy_bok_9 = "zielony"; }
        private void toolStripMenuItem89_Click(object sender, EventArgs e)
        { prawy_bok_9 = "pomaranczowy"; }

        //________________//
        private void lista_tyl_5_Click(object sender, EventArgs e)
        { }
        private void toolStripMenuItem202_Click(object sender, EventArgs e)
        {  }
        private void toolStripMenuItem153_Click(object sender, EventArgs e)
        {        }
        //________________//



        ///......................///...................///...................///



        //GORA_1
        private void toolStripMenuItem203_Click(object sender, EventArgs e)
        {      }
        private void toolStripMenuItem204_Click(object sender, EventArgs e)
        {     }
        private void toolStripMenuItem205_Click(object sender, EventArgs e)
        {       }
        private void toolStripMenuItem206_Click(object sender, EventArgs e)
        {    }
        private void toolStripMenuItem207_Click(object sender, EventArgs e)
        {      }
        private void toolStripMenuItem208_Click(object sender, EventArgs e)
        {        }



        //GORA_2
        private void toolStripMenuItem196_Click(object sender, EventArgs e)
        {      }
        private void toolStripMenuItem197_Click(object sender, EventArgs e)
        {     }
        private void toolStripMenuItem198_Click(object sender, EventArgs e)
        {     }
        private void toolStripMenuItem199_Click(object sender, EventArgs e)
        {      }
        private void toolStripMenuItem200_Click(object sender, EventArgs e)
        {     }
        private void toolStripMenuItem201_Click(object sender, EventArgs e)
        {     }


        //GORA_3
        private void toolStripMenuItem189_Click(object sender, EventArgs e)
        {       }
        private void toolStripMenuItem190_Click(object sender, EventArgs e)
        {      }
        private void toolStripMenuItem191_Click(object sender, EventArgs e)
        {     }
        private void toolStripMenuItem192_Click(object sender, EventArgs e)
        {    }
        private void toolStripMenuItem193_Click(object sender, EventArgs e)
        {    }
        private void toolStripMenuItem194_Click(object sender, EventArgs e)
        {      }


        //GORA_4
        private void toolStripMenuItem182_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem183_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem184_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem185_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem186_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem187_Click(object sender, EventArgs e)
        {        }


        //GORA_5
        private void toolStripMenuItem175_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem176_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem177_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem178_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem179_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem180_Click(object sender, EventArgs e)
        {        }


        //GORA_6
        private void toolStripMenuItem168_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem169_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem170_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem171_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem172_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem173_Click(object sender, EventArgs e)
        {        }


        //GORA_7
        private void toolStripMenuItem161_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem162_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem163_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem164_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem165_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem166_Click(object sender, EventArgs e)
        {        }


        //GORA_8
        private void toolStripMenuItem154_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem155_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem156_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem157_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem158_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem159_Click(object sender, EventArgs e)
        {        }


        //GORA_9
        private void toolStripMenuItem147_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem148_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem149_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem150_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem151_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem152_Click(object sender, EventArgs e)
        {        }


        ///......................///...................///...................///



        //DOL_1
        private void toolStripMenuItem266_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem267_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem268_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem269_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem270_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem271_Click(object sender, EventArgs e)
        {        }


        //DOL_2
        private void toolStripMenuItem259_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem260_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem261_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem262_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem263_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem264_Click(object sender, EventArgs e)
        {        }

        //DOL_3
        private void toolStripMenuItem252_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem253_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem254_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem255_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem256_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem257_Click(object sender, EventArgs e)
        {        }

        //DOL_4
        private void toolStripMenuItem245_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem246_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem247_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem248_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem249_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem250_Click(object sender, EventArgs e)
        {        }

        //DOL_5
        private void toolStripMenuItem238_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem239_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem240_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem241_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem242_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem243_Click(object sender, EventArgs e)
        {        }

        //DOL_6
        private void toolStripMenuItem231_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem232_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem233_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem234_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem235_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem236_Click(object sender, EventArgs e)
        {        }

        //DOL_7
        private void toolStripMenuItem224_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem225_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem226_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem227_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem228_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem229_Click(object sender, EventArgs e)
        {        }

        //DOL_8
        private void toolStripMenuItem217_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem218_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem219_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem220_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem221_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem222_Click(object sender, EventArgs e)
        {        }

        //DOL_9
        private void toolStripMenuItem210_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem211_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem212_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem213_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem214_Click(object sender, EventArgs e)
        {        }
        private void toolStripMenuItem215_Click(object sender, EventArgs e)
        {        }
    }

}
