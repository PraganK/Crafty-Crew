//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("EssentialUIKit.Views.Forms.SimpleSignUpPage.xaml", "Views/Forms/SimpleSignUpPage.xaml", typeof(global::EssentialUIKit.Views.Forms.SimpleSignUpPage))]

namespace EssentialUIKit.Views.Forms {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Views\\Forms\\SimpleSignUpPage.xaml")]
    public partial class SimpleSignUpPage : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Label text;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::EssentialUIKit.Controls.BorderlessEntry NameEntry;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::EssentialUIKit.Controls.BorderlessEntry PasswordEntry;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::EssentialUIKit.Controls.BorderlessEntry ConfirmPasswordEntry;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(SimpleSignUpPage));
            text = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "text");
            NameEntry = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::EssentialUIKit.Controls.BorderlessEntry>(this, "NameEntry");
            PasswordEntry = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::EssentialUIKit.Controls.BorderlessEntry>(this, "PasswordEntry");
            ConfirmPasswordEntry = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::EssentialUIKit.Controls.BorderlessEntry>(this, "ConfirmPasswordEntry");
        }
    }
}
