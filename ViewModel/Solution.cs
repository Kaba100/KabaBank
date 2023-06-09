using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using KabaBank.Model;
namespace KabaBank.ViewModel;

public partial class Solution : ObservableObject
{
    [ObservableProperty]
    public ObservableCollection<Payment> payments;

    [ObservableProperty]
    public ObservableCollection<Advert> adverts;

    [ObservableProperty]
    public ObservableCollection<Business> businesses;
   

    public Solution ()
    {
      payments = new ObservableCollection<Payment>();

        Payment pay = new Payment();
        pay.Image = "people.png";
        pay.Transaction = "100 MTN";
        pay.Amount = "$100.00";
        pay.HighLightColor = Color.FromRgba(255, 255, 0, 50);
        payments.Add(pay);

        Payment B = new Payment();
        B.Image = "people.png";
        B.Transaction = "Quick500";
        B.Amount = "$500.00";
        B.HighLightColor = Color.FromRgba(255, 255, 0, 50);
        payments.Add(B);

        Payment C = new Payment();
        C.Image = "people.png";
        C.Transaction = "Quick1k";
        C.Amount = "$1000.00";
        C.HighLightColor = Color.FromRgba(255, 255, 0, 50);
        payments.Add(C);
        
        Payment D = new Payment();
        D.Image = "people.png";
        D.Transaction = "Borrow Airtime";
        D.Amount = " Min $100 .00";
        D.HighLightColor = Color.FromRgba(255, 255, 0, 50);
        payments.Add(D);

        Payment E = new Payment();
        E.Image = "people.png";
        E.Transaction = "Transfer to Kaba Bank";
        E.Amount = "Min $10";
        E.HighLightColor = Color.FromRgba(255, 255, 0, 50);
        payments.Add(E);

        Payment F = new Payment();
        F.Image = "people.png";
        F.Transaction = "Transfer to other Banks";
        F.Amount = "Minimum of $50";
        F.HighLightColor = Color.FromRgba(255, 255, 0, 50);
        payments.Add(F);

        Payment G = new Payment();
        G.Image = "people.png";
        G.Transaction = "Check Balance";
        G.Amount = "......";
        G.HighLightColor = Color.FromRgba(255, 255, 0, 50);
        payments.Add(G);


        adverts = new ObservableCollection<Advert>();

        Advert AA = new Advert();
        AA.Image = "im1.jpg";
        adverts.Add(AA);

        Advert AB = new Advert();
        AB.Image = "im2.jpg";
        adverts.Add(AB);

        Advert AC = new Advert();
        AC.Image = "im3.jpg";
        adverts.Add(AC);

        Advert AD = new Advert();
        AD.Image = "im4.png";
        adverts.Add(AD);


        businesses = new ObservableCollection<Business>();
        Business P = new Business();
        P.Name = "Account";
        P.Items = new List<string>();
        P.Items.Add("Account Number:0154884382");
        P.Items.Add("Account type:Savings account");
        businesses.Add(P);

        Business H = new Business();
        H.Name = "Transfers";
        H.Items = new List<string>();
        H.Items.Add("To Kaba Hadja Fanta");
        H.Items.Add("To Nfa Laye De");
        H.Items.Add("To Nna");
        H.Items.Add("To Mr Adeyemi Adedeji Oluwaseun");
        H.Items.Add("To Arc Imoh");
        H.Items.Add("To Nbarin Mamadou");
        H.Items.Add("To Ibrahim Abdulganiu");
        H.Items.Add("To Kaba Mouriba");
        H.Items.Add("To Kaba Fatimah");
        H.Items.Add("To Nbarin Dauda");
        H.Items.Add("To Mr Kamal Oyedunle");
        H.Items.Add("To Mr Nkodo Mamady");
        H.Items.Add("To Mr Godwin Iroanya John");
        H.Items.Add("To Mr Ogah Gabriel Bright");
        H.Items.Add("To Mr Ibrahim Idris");
        H.Items.Add("To Mr Olaleye Abdulhammed");
        H.Items.Add("To Mr Adebakin Yusuf");
        H.Items.Add("To Mr Abdulqudus (Kofoshi)");
        businesses.Add(H);

        Business I = new Business();
        I.Name = "Payment Methods";
        I.Items = new List<string>();
        I.Items.Add("USSD");
        I.Items.Add("Mobile Banking");
        I.Items.Add("Card");
        businesses.Add(I);

        Business J = new Business();
        J.Name = "Bills Payments";
        J.Items = new List<string>();
        J.Items.Add("Utility Bills");
        J.Items.Add("Electricity Bills");
        J.Items.Add("Insurance");
        J.Items.Add("Security Bills");
        businesses.Add(J);

        Business K = new Business();
        K.Name = "Lifestyle";
        K.Items = new List<string>();
        K.Items.Add(" Going to Exhibitions");
        K.Items.Add("Knowledge seeking");
        K.Items.Add("Gossiping");
        K.Items.Add("Shopping");
        businesses.Add(K);

        Business L = new Business();
        L.Name = "Cheques & Cards";
        businesses.Add(L);

        Business M = new Business();
        M.Name = "Loans & Investments";
        businesses.Add(M);

        Business N = new Business();
        N.Name = "Orientations";
        businesses.Add(N);
    }
}