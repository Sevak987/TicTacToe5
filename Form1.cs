using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triliza
{
    public partial class Form1 : Form
    {
        
        bool flag;//gia na doume an paizei monos h oxi
        int x = 1;//to x kathorizei an paizei X h O
        Random r;
        public Form1()
        {
            InitializeComponent();
        }
        private void myfunction(object kati, EventArgs katiallo)
        {
            int y = 0;// to y elegxos gia draw
            bool t = false;//gia na termatizei thn anazhthsh tou random
            bool flag1 = false;// an xreiazetai random
            if (x == 1)
            {
                ((Button)kati).Text = "X";
                
                
                    x = 2;
                
                
                //Ελεγχος για το Χ ανα σειρα
                int counter = 0;
                bool f1 = false;
                for (int i = 0; i <= 24; i++)
                {
                    if (buttonArray[i].Text == "X")
                    {
                        counter++;//grammes
                        if (counter == 5)
                        {
                            i = 25;
                            f1 = true;
                        } else if (i < 24 & flag == true & counter >= 3)
                        { 
                            if (buttonArray[i + 1].Text == "")
                            {
                                buttonArray[i + 1].Text = "O";
                                buttonArray[i + 1].Enabled = false;
                                flag1 = true;
                            }
                        
                            
                        }
                    }
                    
                    else if (buttonArray[i].Text == "O")
                    {
                        counter = 0;
                    }
                    if(i == 4 | i == 9 | i == 14 | i == 19 | i == 24)
                    {
                        counter = 0;
                    }
                   

                }
                if (f1)
                {
                    MessageBox.Show("Player 1 won");
                    f1 = false;
                    t = true;
                }
                //Ελεγχος για το Χ ανα στήλη
                int counter2 = 0;
                
                for(int i = 0; i <= 4; i++)
                {
                    for(int j = i; j <= i + 20; j += 5)
                    {
                        if (buttonArray[j].Text == "X")
                        {
                            counter2++;// stiles
                            if (counter2 == 5)
                            {
                                j = 26;
                                i = 5;
                                f1 = true;
                            }
                            else if (j < 19 & flag == true & counter2 >= 3)
                            {
                                if (buttonArray[j + 5].Text == "")
                                {
                                    buttonArray[j + 5].Text = "O";
                                    buttonArray[j + 5].Enabled = false;
                                    flag1 = true;
                                }
                                
                            }
                        }
                       
                        else if (buttonArray[j].Text == "O")
                        {
                            counter2 = 0;
                        }
                        if (j == 20 | j == 21 | j == 22 | j == 23 | j == 24)
                        {
                            counter2 = 0;
                        }
                    }
                }
                if (f1==true)
                {
                    MessageBox.Show("Player1 won ");
                    f1 = false;
                    t = true;
                }

            }
            else
            {
                if (!flag)
                {
                    ((Button)kati).Text = "O";
                }
                else
                {
                    ((Button)kati).Text = "X";
                }
                
                x = 1;
                //Ελεγχος για το Ο ανα σειρα
                int counter = 0;
                bool f2 = false;
                for (int i = 0; i < 24; i++)
                {
                    if (buttonArray[i].Text == "O")
                    {
                        counter++;
                        if (counter == 5)
                        {
                            i = 25;
                            f2 = true;
                        }
                    }
                    
                    else if (buttonArray[i].Text == "X")
                    {
                        counter = 0;
                    }
                    if (i == 4 | i == 9 | i == 14 | i == 19 | i == 24)
                    {
                        counter = 0;
                    }


                }
                if (f2)
                {
                    MessageBox.Show("Player2 won");
                    t = true;
                    f2 = false;
                }
                //Ελεγχος για το Ο ανα στηλη
                int counter2 = 0;
                
                for (int i = 0; i <= 4; i++)
                {
                    for (int j = i; j <= i + 20; j += 5)
                    {
                        if (buttonArray[j].Text == "O")
                        {
                            counter2++;
                            if (counter2 == 5)
                            {
                                j = 25;
                                i = 5;
                                f2 = true;
                            }
                        }
                         
                        else if (buttonArray[j].Text == "X")
                        {
                            counter2 = 0;
                        }
                        if (j == 20 | j == 21 | j == 22 | j == 23 | j == 24)
                        {
                            counter2 = 0;
                        }
                    }
                }
                if (f2)
                {
                    MessageBox.Show("Player2 won");
                    t = true;
                    f2 = false;
                }


            }
            ((Button)kati).Enabled = false;
            for (int q = 0; q <= 24; q++)
            {
                if (buttonArray[q].Enabled == false)
                {
                    y++;
                }
            }
            
            if (y == 25)
            {
                MessageBox.Show("It's a draw");
                t = true;
            }
            int counter3 = 0;
            bool f3 = false;
            bool f4 = false;
            int counter4 = 0;
            
            for (int i = 4; i <= 20; i += 4)
            {
                // Ελεγχος διαγώνιας στήλης Χ
                if (buttonArray[i].Text == "X")
                {
                    counter3++;//diagonios
                    if (counter3 == 5)
                    {
                        i = 21;
                        f3 = true;

                    }
                    else if (i < 16 & flag == true & counter3 >= 3)
                    {
                        if (buttonArray[i + 4].Text == "")
                        {
                            buttonArray[i + 4].Text = "O";
                            buttonArray[i + 4].Enabled = false;
                            flag1 = true;
                        }
                        
                    }
                }

                else if (buttonArray[i].Text == "O")
                {
                    counter3 = 0;
                }
                // Ελεγχος διαγωνιας στήλης Ο
                if (buttonArray[i].Text == "O")
                {
                    counter4++;//alli diagonios
                    if (counter4 == 5)
                    {
                        f4 = true;
                        i = 21;
                    }
                    
                }

                else if (buttonArray[i].Text == "X")
                {
                    counter4 = 0;
                }
            }
            
            
            int counter5 = 0;
            int counter6 = 0;
            for (int i = 0; i <= 24; i += 6)
            {
                // Ελεγχος διαγώνιας στήλης Χ
                if (buttonArray[i].Text == "X")
                {
                    counter5++;//alli diagonios
                    if (counter5 == 5)
                    {
                        
                        f3 = true;
                        
                    }
                    else if (i <= 18 & flag == true & counter5 >= 3)
                    {
                        if (buttonArray[i + 6].Text == "")
                        {
                            buttonArray[i + 6].Text = "O";
                            buttonArray[i + 6].Enabled = false;
                            flag1 = true;
                        }
                        
                    }
                }

                else if (buttonArray[i].Text == "O")
                {
                    counter5 = 0;
                }
                // Ελεγχος διαγωνιας στήλης Ο
                
                if (buttonArray[i].Text == "O")
                {
                    counter6++;
                    if (counter6 == 5)
                    {
                        i = 26;
                        f4 = true;
                    }
                   
                }

                else if (buttonArray[i].Text == "X")
                {
                    counter6 = 0;
                }
            }
            if (f4)
            {
                MessageBox.Show("Player 2 has won!!");
                f4 = false;
            }
            if (f3)
            {
                MessageBox.Show("Player 1 has won!!");
                f3 = false;
            }
            bool xi = true;
            if (!flag1 & flag)
            {
                
                int temp = r.Next(0, 24);
                while (xi & !t)
                {
                    if (buttonArray[temp].Text == "")
                    {
                        buttonArray[temp].Text = "O";
                        buttonArray[temp].Enabled = false;
                        
                        xi = false;
                    }
                    else
                    {
                        temp = r.Next(0, 24);
                    }
                }
                
                
                
               
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        
        Button[] buttonArray;

        private void Form1_Load(object sender, EventArgs e)
        {
            r = new Random();
            buttonArray = new Button[25];
            buttonArray[0] = button1;
            buttonArray[1] = button2;
            buttonArray[2] = button3;
            buttonArray[3] = button4;
            buttonArray[4] = button5;
            buttonArray[5] = button6;
            buttonArray[6] = button7;
            buttonArray[7] = button8;
            buttonArray[8] = button9;
            buttonArray[9] = button10;
            buttonArray[10] = button11;
            buttonArray[11] = button12;
            buttonArray[12] = button13;
            buttonArray[13] = button14;
            buttonArray[14] = button15;
            buttonArray[15] = button16;
            buttonArray[16] = button17;
            buttonArray[17] = button18;
            buttonArray[18] = button19;
            buttonArray[19] = button20;
            buttonArray[20] = button21;
            buttonArray[21] = button22;
            buttonArray[22] = button23;
            buttonArray[23] = button24;
            buttonArray[24] = button25;
            for (int i = 0; i <= buttonArray.Length - 1; i++)
            {

                buttonArray[i].Enabled = false;
                


            }
        }
        
        bool k = true;

        private void button27_Click(object sender, EventArgs e)
        {
            
            flag = true;
            for (int i = 0; i <= buttonArray.Length - 1; i++)
            {
                buttonArray[i].Enabled = true;
                buttonArray[i].Text = "";
                if (k)
                {
                    buttonArray[i].Click += myfunction;
                    
                }
            }
            x = 1;
            k = false;
        }

        private void button26_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i <= buttonArray.Length - 1; i++)
            {
                buttonArray[i].Enabled = true;
                buttonArray[i].Text = "";
                if (k)
                {
                    buttonArray[i].Click += myfunction;
                    
                }
                flag = false;

            }
            
            k = false;
        }

        
    }
}
