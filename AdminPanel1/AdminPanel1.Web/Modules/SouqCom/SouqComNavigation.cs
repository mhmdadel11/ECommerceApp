using Serenity.Navigation;
using MyPages = AdminPanel1.SouqCom.Pages;

[assembly: NavigationLink(int.MaxValue, "SouqCom/Category", typeof(MyPages.CategoryPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "SouqCom/Cart", typeof(MyPages.CartPage), icon: null)]