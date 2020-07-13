using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireGame_Project_asr
{
    public partial class Form1 : Form
    {
        //instance object of the other clas 
        Random rd = new Random();
        Shoot instance = new Shoot();

        //global variable 
        int clk = 0, trig = 0;
        int clk1 = 0, trig1 = 0;
        public Form1()
        {
            InitializeComponent();
            //first of disable all the button which ahaving no position to start 
            as_start_btn.Enabled = true;
            as_load_btn.Enabled = false;
            as_spin_btn.Enabled = false;
            as_shoot_btn.Enabled = false;
            as_shootAway_btn.Enabled = false;
            as_restart_btn.Enabled = false;

            //get the random value to trigger 
            trig =rd.Next(1,5);
            trig1 = rd.Next(1, 3);
        }

        private void as_start_btn_Click(object sender, EventArgs e)
        {
            //if we are interested then  click on start button to tart the game 
            as_Picture.Image = FireGame_Project_asr.Properties.Resources.fire_start;
            as_start_btn.Enabled = false;
            as_load_btn.Enabled =true;

        }

        private void as_load_btn_Click(object sender, EventArgs e)
        {
            //after starting the  game we must need bullet to fire so thus load the bullet in the gun
            as_Picture.Image = FireGame_Project_asr.Properties.Resources.fire_load;
            as_load_btn.Enabled = false;
            as_spin_btn.Enabled = true;

        }

        private void as_shootAway_btn_Click(object sender, EventArgs e)
        {

            // wehave another two chance to fire 
            clk1++;
            as_Picture.Image = FireGame_Project_asr.Properties.Resources.fire_shoot_away;
            if (instance.ShootAwayPlayer(clk1,trig1)==0) {
                as_shootAway_btn.Enabled = false;
                as_restart_btn.Enabled = true;
            }
        }

        private void as_restart_btn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void as_spin_btn_Click(object sender, EventArgs e)
        {
            //after loading the gun we must spin the case before fire 
            as_Picture.Image = FireGame_Project_asr.Properties.Resources.fire_load;
            as_spin_btn.Enabled = false;
            as_shoot_btn.Enabled = true;
            as_shootAway_btn.Enabled =true;

        }

        private void as_shoot_btn_Click(object sender, EventArgs e)
        {
            as_Picture.Image = FireGame_Project_asr.Properties.Resources.fire_shoot;
            clk++;
            //if the method return  means the player is dead 
            if (instance.checkPlayer(clk, trig) == 0)
            {
                as_shoot_btn.Enabled = false;
                as_shootAway_btn.Enabled = false;
                as_restart_btn.Enabled = true;
            }
            

        }
    }
}
