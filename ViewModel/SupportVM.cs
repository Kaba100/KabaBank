using System;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;
using KabaBank.Model;
using System.Threading.Tasks;

namespace KabaBank.ViewModel
{
  public partial  class SupportVM : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<Support> supports;

        [ObservableProperty]
        public ObservableCollection<SocialMedia> socialMedias;

        [ObservableProperty]
        public ObservableCollection<Call> calls;
        [ObservableProperty]
        public ObservableCollection<CheckIn> checkIns; 
        public SupportVM()
        {
            supports = new ObservableCollection<Support>();
            Support Acc = new Support();
            Acc.Name = "Account Officer";
            Acc.Icon = "sendfeedback.png";
            Acc.Image = "people.png";
            supports.Add(Acc);

            Support Live = new Support();
            Live.Name = "Livechat";
            Live.Icon = "livechat.png";
            Live.Image = "people.png";
            supports.Add(Live);

            Support faq = new Support();
            faq.Name = "FAQ";
            faq.Icon = "faqq.png";
            faq.Image = "people.png";
            supports.Add(faq);

            Support KInflow = new Support();
            KInflow.Name = "Kaba Inflow Details";
            KInflow.Icon = "inflowdetails.png";
            KInflow.Image = "people.png";
            supports.Add(KInflow);

            Support rep = new Support();
            rep.Name = "Report an Issue";
            rep.Icon = "reportissue.png";
            rep.Image = "people.png";
            supports.Add(rep);

            Support send = new Support();
            send.Name = "Send Feedback";
            send.Icon = "accountofficer.png";
            send.Image = "people.png";
            supports.Add(send);


            socialMedias = new ObservableCollection<SocialMedia>();
            SocialMedia twi = new SocialMedia();
            twi.Name = "Twitter";
            twi.Icon = "twitter.png";
            socialMedias.Add(twi);

            SocialMedia face = new SocialMedia();
            face.Name = "Facebook";
            face.Icon = "facebook.png";
            socialMedias.Add(face);

            SocialMedia Insta = new SocialMedia();
            Insta.Name = "WhatsApp";
            Insta.Icon = "whatsapp.png";
            socialMedias.Add(Insta);


            calls = new ObservableCollection<Call>();
            Call c1 = new Call();
            c1.Name = "01-5000232-9";
            c1.Icon = "call.png";
            calls.Add(c1);

            Call c2 = new Call();
            c2.Name = "00-39045011";
            c2.Icon = "call.png";
            calls.Add(c2);

            Call c3 = new Call();
            c3.Name = "0600CALLKABA";
            c3.Icon = "call.png";
            calls.Add(c3);

            checkIns = new ObservableCollection<CheckIn>();
            CheckIn mail = new CheckIn();
            mail.Name = "kabamouribamoney6000@gmail.com";
            mail.Icon = "email.png";
            checkIns.Add(mail);

        }
    }
}
