using System.Collections.ObjectModel;
using System.Windows.Input;
using AuthenticationServices;
using CommunityToolkit.Mvvm.ComponentModel;
using MauiGPayApp.Constants;
using MauiGPayApp.Models;

namespace MauiGPayApp.ViewModels;

public partial class HomeViewModel : BaseViewModel
{

    public HomeViewModel() : base()
    {
        
        
    }
    
    public override Task Initialize()
    {
        OtherOptionList = new ObservableCollection<OtherOption>
        {
            new() { Icon = IconConstants.TapAndPayIcon, IconTitle = "Tap & Pay", IconSubTitle ="View Cards" },
            new() { Icon = IconConstants.UPILiteIcon,  IconTitle = "UPI Lite", IconSubTitle ="Activate", IconSubTitleTextColor = Colors.Blue},
            new() { Icon = IconConstants.RewardsIcon, IconTitle = "Rewards", IconSubTitle ="New" },
            new() { Icon = IconConstants.UPIIDIcon , IconTitle = "UPI ID", IconSubTitle ="vivek@bankname" },
           
        };
        PeopleList = new ObservableCollection<People>()
        {
            new (){FullName = "Vivek"},
            new(){ FullName = "Rahul" },
            new(){ FullName = "Amit" },
            new(){ FullName = "Neha" },
            new(){ FullName = "Priya" },
            new(){ FullName = "Rohit" },
            new(){ FullName = "Ankit" },
            new(){ FullName = "Kunal" },
            new(){ FullName = "Sandeep" },
            new(){ FullName = "Pooja" },
            new(){ FullName = "Deepak" },
            new(){ FullName = "Arjun" },
            new(){ FullName = "Riya" },
        };

        BillsAndRechargeList = new ObservableCollection<People>()
        {
            new() { FullName = "Mobile\nRecharge", IconImage = "mobile_recharge"},
            new() { FullName = "Credit\nCard", IconImage = "credit_card"},
            new() { FullName = "Postpaid\nmobile" , IconImage = "postpaid"},
            new() { FullName = "DTH /\nCable TV" , IconImage = "dth"},
        };
        return Task.CompletedTask;
    }

    [ObservableProperty] 
    private ObservableCollection<OtherOption> _otherOptionList;

    [ObservableProperty] 
    private ObservableCollection<People> _peopleList;
    
    [ObservableProperty] 
    private ObservableCollection<People> _billsAndRechargeList;
}

public partial class OtherOption : ObservableObject
{
    
    [ObservableProperty]
    private string _icon;
    
    [ObservableProperty]
    private string _iconTitle;
    
    [ObservableProperty]
    private string _iconSubTitle;

    [ObservableProperty]
    private Color _iconSubTitleTextColor = Colors.Black;

    [ObservableProperty] 
    private Color _iconColor = Colors.White;
}