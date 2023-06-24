using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace STUDENT_TEACHER_DATA.Notification
{
    internal class MessageCollection
    {
        public static void showNatification(string l_notificatio)
        {
            SoundPlayer _soundPlayer = new SoundPlayer(soundLocation: @"C:\Users\RWDA TECH\Desktop\Visual S\Project Hoteel\Project Hoteel\Project Hoteel\Sound\Background_Sound.wav");
            _soundPlayer.Play();
            F_NOTIFICATION notification = new F_NOTIFICATION();
            notification.Show();
            notification.lbl_notification.Text = l_notificatio;
        }
    }
}
