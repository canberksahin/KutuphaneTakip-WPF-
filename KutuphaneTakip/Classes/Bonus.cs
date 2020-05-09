﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using System.Windows.Threading;

namespace KutuphaneTakip.Classes
{
    public class Bonus
    {
        public static void SesCikar()
        {
            MediaPlayer mp = new MediaPlayer();
            mp.Open(new Uri("music/popup.wav",UriKind.Relative));
            mp.Play();
        }

        public static void PopUpShow(Popup popup)
        {
            SesCikar();

            popup.IsOpen = true;
            DispatcherTimer timer = new DispatcherTimer()
            {
                Interval = TimeSpan.FromSeconds(4)
            };

            timer.Tick += delegate (object sender, EventArgs e)
            {
                ((DispatcherTimer)timer).Stop();
                if (popup.IsOpen)
                {
                    popup.IsOpen = false;
                }
            };
            timer.Start();
        }
    }

       
}
