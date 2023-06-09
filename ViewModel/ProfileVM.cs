using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KabaBank.Model;

namespace KabaBank.ViewModel
{
  public partial class ProfileVM : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<Work> works;

        [ObservableProperty]
        public ObservableCollection<General> generals;

        [ObservableProperty]
        public ObservableCollection<Unlimited> unlimiteds;

        [ObservableProperty]
        public ObservableCollection<Appearance> appearances;

        [ObservableProperty]
        public ObservableCollection<Logout> logouts;
        public ProfileVM()
        {
            works = new ObservableCollection<Work>();   
            Work A = new Work();
            A.Name = "Change/Reset PIN";
            A.Icons = "changeresetpin.png";
            A.Image = "people.png";
            A.IsActive= true;
            A.IsVisible = true;
            works.Add(A);

            Work B = new Work();
            B.Name = "Change Password";
            B.Icons = "changepassword.png";
            B.Image = "people.png";
            B.IsActive = false;
            B.IsVisible = true;
            works.Add(B);

            Work C = new Work();
            C.Name = "Change Personal Data";
            C.Icons = "chngepersonaldata.png";
            C.Image = "people.png";
            C.IsActive = false;
            C.IsVisible = false;
            works.Add(C);

            Work D = new Work();
            D.Name = "Change Biometric Login";
            D.Icons = "dotnet_bot.svg";
            D.Image = "people.png";
            D.IsActive = false;
            D.IsVisible = true;
            works.Add(D);

            Work E = new Work();
            E.Name = "Auto Login on app start";
            E.Icons = "autologin.png";
            E.Image = "people.png";
            E.IsActive = true;
            E.IsVisible = true;
            works.Add(E);

            Work F = new Work();
            F.Name = "Biometric Transactions";
            F.Icons = "biometrictransaction.png";
            F.Image = "people.png";
            F.IsActive = true;
            works.Add(F);

            Work G = new Work();
            G.Name = "Hide Account Balance";
            G.Icons = "hideaccountbalance.png";
            G.Image = "people.png";
            G.IsActive = false;
            G.IsVisible = true;
            works.Add(G);

           

            generals = new ObservableCollection<General>();
            General gen = new General();
            gen.Name = "Banking Screw....";
            gen.Icon = "beatingheart.png";
            gen.Image = "people.png";
            generals.Add(gen);


            unlimiteds = new ObservableCollection<Unlimited>();
            Unlimited limit = new Unlimited();
            limit.Name = "Transaction Limits";
            limit.Icon = "dotnet_bot.svg";
            limit.Image = "people.png";
            unlimiteds.Add(limit);

            appearances = new ObservableCollection<Appearance>();
            Appearance ap = new Appearance();
            ap.Name = "Theme";
            ap.Icons = "theme.png";
            ap.Image = "people.png";
            ap.IsActive = true;
            ap.IsVisible = false;
            appearances.Add(ap);

            Appearance aq = new Appearance();
            aq.Name = "App Icon";
            aq.Icons = "dotnet_bot.svg";
            aq.Image = "people.png";
            aq.IsActive = true;
            aq.IsVisible = false;
            appearances.Add(aq);

            Appearance ar = new Appearance();
            ar.Name = "Intro Video";
            ar.Icons = "introvideo.png";
            ar.Image = "people.png";
            ar.IsActive = true;
            ar.IsVisible = true;
            appearances.Add(ar);


            Appearance at = new Appearance();
            at.Name = "Product Suggestions";
            at.Icons = "productsuggestions.svg";
            at.Image = "people.png";
            at.IsActive = true;
            at.IsVisible = true;
            appearances.Add(at);


            logouts = new ObservableCollection<Logout>();
            Logout log = new Logout();
            log.Name = "Logout";
            log.Icon = "logout.png";
            logouts.Add(log);




        }


    }
}
