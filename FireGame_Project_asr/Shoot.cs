using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireGame_Project_asr
{
    public class Shoot
    {
        public int checkPlayer(int trigger, int trg) {
            System.Media.SoundPlayer sund= new System.Media.SoundPlayer(FireGame_Project_asr.Properties.Resources.Shot);
            sund.Play();

            if (trigger == trg)
            {
                MessageBox.Show("You are dead ! ");
                return 0;
            }
            else if (trigger != trg)
            {
                MessageBox.Show("You are save  ");
                return 1;
            }

            else if (trigger >= 4)
            {
                
                return 0;
            }
            else {
                return 0;
            }
            
        }



        public int ShootAwayPlayer(int Trigger,int trg) {
            System.Media.SoundPlayer sund = new System.Media.SoundPlayer(FireGame_Project_asr.Properties.Resources.Shot);
            sund.Play();
            //we have two chance to trigger 
            if (Trigger == 2) {
                MessageBox.Show("Bullet finish ");
                return 0;
            } else {
                MessageBox.Show("You are save ");
                return 1;  
            }

        }

    }
}
